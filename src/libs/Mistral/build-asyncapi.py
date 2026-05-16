#!/usr/bin/env python3
"""Synthesize asyncapi.json from openapi.yaml.

Mistral doesn't publish an AsyncAPI spec for the Voxtral Realtime Transcription
WebSocket. The OpenAPI spec already contains every client-side payload as a
``RealtimeTranscription*`` schema and every text-event payload as a
``TranscriptionStream*`` schema, but the server-side session/error events
(``RealtimeTranscriptionSession``, ``RealtimeTranscriptionSessionCreated``,
``RealtimeTranscriptionSessionUpdated``, ``RealtimeTranscriptionError``,
``RealtimeTranscriptionErrorDetail``) are missing — they're reverse-engineered
from the upstream ``mistralai`` Python client.

This script stitches everything into a self-contained AsyncAPI 3.0 document so
AutoSDK's WebSocket generator can emit a Mistral.Realtime namespace.

Run after fetching openapi.yaml; invoked by generate.sh.
"""
from __future__ import annotations

import argparse
import json
import sys
from pathlib import Path

import yaml

HERE = Path(__file__).resolve().parent
DEFAULT_OPENAPI_PATH = HERE / "openapi.yaml"
DEFAULT_ASYNCAPI_PATH = HERE / "asyncapi.json"

CLIENT_MESSAGES: list[tuple[str, str]] = [
    ("RealtimeTranscriptionSessionUpdateMessage", "session.update"),
    ("RealtimeTranscriptionInputAudioAppend", "input_audio.append"),
    ("RealtimeTranscriptionInputAudioFlush", "input_audio.flush"),
    ("RealtimeTranscriptionInputAudioEnd", "input_audio.end"),
]

EXISTING_SERVER_MESSAGES: list[tuple[str, str]] = [
    ("TranscriptionStreamLanguage", "transcription.language"),
    ("TranscriptionStreamSegmentDelta", "transcription.segment"),
    ("TranscriptionStreamTextDelta", "transcription.text.delta"),
    ("TranscriptionStreamDone", "transcription.done"),
]

SYNTHESIZED_SERVER_MESSAGES: list[tuple[str, str]] = [
    ("RealtimeTranscriptionSessionCreated", "session.created"),
    ("RealtimeTranscriptionSessionUpdated", "session.updated"),
    ("RealtimeTranscriptionError", "error"),
]

SERVER_UNION_SCHEMA = "RealtimeTranscriptionServerEvent"


def find_refs(node, refs: set[str] | None = None) -> set[str]:
    if refs is None:
        refs = set()
    if isinstance(node, dict):
        for k, v in node.items():
            if k == "$ref" and isinstance(v, str) and v.startswith("#/components/schemas/"):
                refs.add(v.rsplit("/", 1)[-1])
            else:
                find_refs(v, refs)
    elif isinstance(node, list):
        for item in node:
            find_refs(item, refs)
    return refs


def transitive_closure(all_schemas: dict, seed: set[str]) -> set[str]:
    included = set(seed)
    pending: set[str] = set()
    for name in seed:
        pending |= find_refs(all_schemas.get(name, {}))
    pending -= included
    while pending:
        next_batch: set[str] = set()
        for name in pending:
            if name in all_schemas:
                included.add(name)
                next_batch |= find_refs(all_schemas[name])
        pending = next_batch - included
    return included


def synthesized_schemas() -> dict:
    """Schemas missing from upstream openapi.yaml — modelled after the
    ``mistralai`` Python client (``client/models/realtimetranscription*``).
    """
    return {
        "RealtimeTranscriptionSession": {
            "type": "object",
            "title": "RealtimeTranscriptionSession",
            "properties": {
                "request_id": {"type": "string", "title": "Request Id"},
                "model": {"type": "string", "title": "Model"},
                "audio_format": {"$ref": "#/components/schemas/AudioFormat"},
                "target_streaming_delay_ms": {
                    "anyOf": [{"type": "integer"}, {"type": "null"}],
                    "title": "Target Streaming Delay Ms",
                    "default": None,
                },
            },
            "required": ["request_id", "model", "audio_format"],
            "additionalProperties": False,
        },
        "RealtimeTranscriptionSessionCreated": {
            "type": "object",
            "title": "RealtimeTranscriptionSessionCreated",
            "properties": {
                "type": {
                    "type": "string",
                    "title": "Type",
                    "default": "session.created",
                    "const": "session.created",
                },
                "session": {"$ref": "#/components/schemas/RealtimeTranscriptionSession"},
            },
            "required": ["session"],
            "additionalProperties": False,
        },
        "RealtimeTranscriptionSessionUpdated": {
            "type": "object",
            "title": "RealtimeTranscriptionSessionUpdated",
            "properties": {
                "type": {
                    "type": "string",
                    "title": "Type",
                    "default": "session.updated",
                    "const": "session.updated",
                },
                "session": {"$ref": "#/components/schemas/RealtimeTranscriptionSession"},
            },
            "required": ["session"],
            "additionalProperties": False,
        },
        "RealtimeTranscriptionErrorDetail": {
            "type": "object",
            "title": "RealtimeTranscriptionErrorDetail",
            "properties": {
                "message": {
                    "type": "string",
                    "title": "Message",
                    "description": "Human-readable error message.",
                },
                "code": {
                    "type": "integer",
                    "title": "Code",
                    "description": "Internal error code for debugging.",
                },
            },
            "required": ["message", "code"],
            "additionalProperties": False,
        },
        "RealtimeTranscriptionError": {
            "type": "object",
            "title": "RealtimeTranscriptionError",
            "properties": {
                "type": {
                    "type": "string",
                    "title": "Type",
                    "default": "error",
                    "const": "error",
                },
                "error": {"$ref": "#/components/schemas/RealtimeTranscriptionErrorDetail"},
            },
            "required": ["error"],
            "additionalProperties": False,
        },
        SERVER_UNION_SCHEMA: {
            "title": SERVER_UNION_SCHEMA,
            "oneOf": [
                {"$ref": f"#/components/schemas/{name}"}
                for name, _ in EXISTING_SERVER_MESSAGES + SYNTHESIZED_SERVER_MESSAGES
            ],
            "discriminator": {
                "propertyName": "type",
                "mapping": {
                    type_str: f"#/components/schemas/{name}"
                    for name, type_str in EXISTING_SERVER_MESSAGES + SYNTHESIZED_SERVER_MESSAGES
                },
            },
        },
    }


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--input", type=Path, default=DEFAULT_OPENAPI_PATH,
                        help=f"Path to openapi.yaml (default: {DEFAULT_OPENAPI_PATH})")
    parser.add_argument("--output", type=Path, default=DEFAULT_ASYNCAPI_PATH,
                        help=f"Path to write asyncapi.json (default: {DEFAULT_ASYNCAPI_PATH})")
    args = parser.parse_args()

    spec = yaml.safe_load(args.input.read_text())
    all_schemas: dict = spec["components"]["schemas"]

    merged_schemas = dict(all_schemas)
    merged_schemas.update(synthesized_schemas())

    seed: set[str] = {SERVER_UNION_SCHEMA}
    for schema_name, _ in CLIENT_MESSAGES:
        seed.add(schema_name)
    for schema_name, _ in EXISTING_SERVER_MESSAGES:
        seed.add(schema_name)
    for schema_name, _ in SYNTHESIZED_SERVER_MESSAGES:
        seed.add(schema_name)

    missing = seed - merged_schemas.keys()
    if missing:
        print(
            f"warning: schemas missing from openapi.yaml and synthesized set: {sorted(missing)}",
            file=sys.stderr,
        )

    included = transitive_closure(merged_schemas, seed)
    inline_schemas = {k: merged_schemas[k] for k in sorted(included)}

    channel_messages: dict = {}
    component_messages: dict = {}
    operations: dict = {}

    for schema_name, type_str in CLIENT_MESSAGES:
        msg_name = schema_name
        component_messages[msg_name] = {
            "name": msg_name,
            "title": type_str,
            "payload": {"$ref": f"#/components/schemas/{schema_name}"},
        }
        channel_messages[msg_name] = {"$ref": f"#/components/messages/{msg_name}"}
        operations[f"send{schema_name}"] = {
            "action": "send",
            "channel": {"$ref": "#/channels/realtime"},
            "messages": [{"$ref": f"#/channels/realtime/messages/{msg_name}"}],
        }

    server_message_names: list[str] = []
    component_messages["ServerEvent"] = {
        "name": "ServerEvent",
        "title": "Realtime Transcription Server Event",
        "summary": "Discriminated union of all server-sent realtime transcription events.",
        "payload": {"$ref": f"#/components/schemas/{SERVER_UNION_SCHEMA}"},
    }
    channel_messages["ServerEvent"] = {"$ref": "#/components/messages/ServerEvent"}
    operations["receiveServerEvent"] = {
        "action": "receive",
        "channel": {"$ref": "#/channels/realtime"},
        "messages": [{"$ref": "#/channels/realtime/messages/ServerEvent"}],
    }
    server_message_names.append("ServerEvent")

    doc = {
        "asyncapi": "3.0.0",
        "info": {
            "title": "Mistral Voxtral Realtime Transcription API",
            "version": "1.0.0",
            "description": (
                "Mistral Voxtral realtime transcription over WebSocket.\n\n"
                "Auto-generated from openapi.yaml by build-asyncapi.py — do not "
                "edit by hand. Server event schemas missing from the upstream "
                "OpenAPI spec are reverse-engineered from the upstream mistralai "
                "Python client."
            ),
        },
        "servers": {
            "production": {
                "host": "api.mistral.ai",
                "pathname": "/v1/audio/transcriptions/realtime",
                "protocol": "wss",
                "description": "Mistral Voxtral Realtime WebSocket server",
                "variables": {
                    "model": {
                        "description": (
                            "Realtime transcription model ID. Appended to the URL "
                            "as ?model=<id>."
                        ),
                        "examples": ["voxtral-mini-transcribe-realtime-2602"],
                    }
                },
                "security": [
                    {"$ref": "#/components/securitySchemes/bearer"},
                ],
            }
        },
        "channels": {
            "realtime": {
                "address": "/v1/audio/transcriptions/realtime",
                "messages": channel_messages,
            }
        },
        "operations": operations,
        "components": {
            "securitySchemes": {
                "bearer": {
                    "type": "http",
                    "scheme": "bearer",
                    "description": "Mistral API key as a Bearer token.",
                },
            },
            "messages": component_messages,
            "schemas": inline_schemas,
        },
    }

    args.output.write_text(json.dumps(doc, indent=2) + "\n")
    print(
        f"Wrote {args.output}: "
        f"{len(CLIENT_MESSAGES)} client messages, "
        f"{len(server_message_names)} server messages, "
        f"{len(inline_schemas)} schemas"
    )
    return 0


if __name__ == "__main__":
    sys.exit(main())
