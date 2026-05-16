# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Mistral AI](https://mistral.ai/) platform, auto-generated from the Mistral OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Mistral.slnx

# Build for release (also produces NuGet package)
dotnet build Mistral.slnx -c Release

# Run integration tests (requires MISTRAL_API_KEY env var)
dotnet test src/tests/IntegrationTests/Mistral.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Mistral && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code in `Generated/` is **auto-generated** -- do not manually edit files in `src/libs/Mistral/Generated/`. Hand-written extensions live in `src/libs/Mistral/Extensions/`.

1. `src/libs/Mistral/openapi.yaml` -- the Mistral OpenAPI spec (fetched from the upstream `mistralai/platform-docs-public` repo)
2. `src/libs/Mistral/build-asyncapi.py` -- synthesizes `src/libs/Mistral/asyncapi.json` from `openapi.yaml` for the Voxtral Realtime WebSocket. The upstream OpenAPI ships the client-side schemas but is missing the server-side session/error schemas, so the script inlines them (reverse-engineered from the upstream `mistralai` Python client at `client/models/realtimetranscription*.py`). It also synthesizes a `RealtimeTranscriptionServerEvent` `oneOf` union schema and emits a single `receiveServerEvent` operation — a per-message-op layout would trigger an AutoSDK WS-dispatcher naming-mismatch (see "Voxtral Realtime" below).
3. `src/libs/Mistral/generate.sh` -- orchestrates: download spec, run `build-asyncapi.py`, run `autosdk generate` on both `openapi.yaml` (namespace `Mistral`) and `asyncapi.json` (namespace `Mistral.Realtime`), output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Mistral/` | Main SDK library (`MistralClient` + `Mistral.Realtime.MistralRealtimeTranscriptionClient`) |
| `src/libs/Mistral/Extensions/` | Hand-written extensions (MEAI `IChatClient`, MEAI `ISpeechToTextClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Mistral API |

### Hand-Written Extensions

| Path | Purpose |
|------|---------|
| `Extensions/MistralClient.ChatClient.cs` | Implements `Microsoft.Extensions.AI.IChatClient` on `MistralClient`. Maps text + image + audio content; tool calling; streaming. |
| `Extensions/MistralClient.SpeechToTextClient.cs` | Implements `Microsoft.Extensions.AI.ISpeechToTextClient` on `MistralClient`. `GetTextAsync` uses REST `/v1/audio/transcriptions` (default model `voxtral-mini-2507`); `GetStreamingTextAsync` opens the Voxtral Realtime WebSocket (default model `voxtral-mini-transcribe-realtime-2602`). |

### Voxtral (audio) capabilities

Voxtral is Mistral's audio-understanding line. It is **not** a separate SDK — it ships as part of `tryAGI.Mistral`:

| Capability | API surface | Default model |
|-----------|-------------|---------------|
| Batch transcription | `client.AudioTranscriptions.CreateTranscriptionAsync(...)` or `Meai.ISpeechToTextClient.GetTextAsync` | `voxtral-mini-2507` |
| SSE-streamed transcription | `client.AudioTranscriptions.CreateStreamingTranscriptionSseAsync(...)` | `voxtral-mini-2507` |
| Realtime (WebSocket) transcription | `new Mistral.Realtime.MistralRealtimeTranscriptionClient(apiKey)` or `Meai.ISpeechToTextClient.GetStreamingTextAsync` | `voxtral-mini-transcribe-realtime-2602` |
| Chat with audio inputs | `Meai.IChatClient.GetResponseAsync(...)` with `Meai.DataContent` whose `MediaType` starts with `audio/` | Any Voxtral chat model (e.g. `voxtral-small-latest`) |
| TTS (voice synthesis) | `client.AudioSpeech.SpeechAsync(...)` | n/a — voice-driven |
| Voice management | `client.AudioVoices.*` | n/a |

### Voxtral Realtime WebSocket — generation details

- Endpoint: `wss://api.mistral.ai/v1/audio/transcriptions/realtime?model=<id>` (auth: `Authorization: Bearer <MISTRAL_API_KEY>`)
- Client → server messages (already in upstream OpenAPI): `session.update`, `input_audio.append` (base64 PCM, max 262 144 decoded bytes per frame), `input_audio.flush`, `input_audio.end`
- Server → client messages: `transcription.language`, `transcription.segment`, `transcription.text.delta`, `transcription.done` (in upstream OpenAPI) plus `session.created`, `session.updated`, `error` (synthesized in `build-asyncapi.py` from the upstream `mistralai` Python client)

`build-asyncapi.py` emits one `send*` op per client message and one `receive*` op per server message; AutoSDK auto-synthesises the `Mistral.Realtime.ServerEvent` oneOf union from the receive payloads (since AutoSDK [#324](https://github.com/tryAGI/AutoSDK/issues/324) — requires `autosdk.cli` ≥ 0.30.2-dev.45). No hand-authored union wrapper schema is required.

### Documentation Generation

Tests in `src/tests/IntegrationTests/Examples` are the single source of truth for both test coverage and documentation:
- Each file has a JSDoc header (`order`, `title`, `slug`) consumed by `autosdk docs sync .`
- Comments prefixed with `////` become prose paragraphs in generated docs
- CI workflow (`.github/workflows/mkdocs.yml`) auto-generates `docs/examples/` and populates `EXAMPLES:START/END` markers in README.md, docs/index.md, and mkdocs.yml
- Config: `autosdk.docs.json` points to `src/tests/IntegrationTests/Examples`
### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
