#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/mistralai/platform-docs-public/refs/heads/main/openapi.yaml

dotnet tool update --global autosdk.cli --prerelease 2>/dev/null || dotnet tool install --global autosdk.cli --prerelease
curl --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/mistralai/platform-docs-public/refs/heads/main/openapi.yaml

# build-asyncapi.py requires PyYAML; install it on first run (CI or fresh clones).
python3 -c "import yaml" 2>/dev/null || python3 -m pip install --quiet --user --break-system-packages pyyaml
python3 build-asyncapi.py

rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Mistral \
  --clientClassName MistralClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --generate-http-exception-hierarchy \
  --generate-retry-handler \
  --generate-pageable-helpers \
  --generate-multipart-upload-helpers \
  --auth-env-var MISTRAL_API_KEY \
  --methodNamingConvention Summary

autosdk generate asyncapi.json \
  --namespace Mistral.Realtime \
  --websocket-class-name MistralRealtimeTranscriptionClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated \
  --base-url wss://api.mistral.ai
