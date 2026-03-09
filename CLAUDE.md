# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Mistral AI](https://mistral.ai/) platform, auto-generated from the Mistral OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Mistral.sln

# Build for release (also produces NuGet package)
dotnet build Mistral.sln -c Release

# Run integration tests (requires MISTRAL_API_KEY env var)
dotnet test src/tests/IntegrationTests/Mistral.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Mistral && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Mistral/Generated/`.

1. `src/libs/Mistral/openapi.yaml` -- the Mistral OpenAPI spec (fetched from `https://docs.mistral.ai/redocusaurus/plugin-redoc-0.yaml`)
2. `src/helpers/FixOpenApiSpec/` -- converts OpenAPI 3.1 to 3.0 format for compatibility
3. `src/libs/Mistral/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Mistral/` | Main SDK library (`MistralClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Mistral API |
| `src/helpers/FixOpenApiSpec/` | OpenAPI spec fixer tool |
| `src/helpers/GenerateDocs/` | Documentation generator from integration tests |
| `src/helpers/TrimmingHelper/` | NativeAOT/trimming compatibility validator |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
