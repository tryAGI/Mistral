#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://raw.githubusercontent.com/mistralai/platform-docs-public/refs/heads/main/openapi.yaml

use_pinned_spec=false
for arg in "$@"; do
  case "$arg" in
    --pinned-spec)
      use_pinned_spec=true
      ;;
    *)
      echo "Unknown argument: $arg" >&2
      exit 1
      ;;
  esac
done
if [[ "${TRYAGI_PINNED_SPEC:-0}" == "1" ]]; then
  use_pinned_spec=true
fi
install_autosdk_cli
if [[ "$use_pinned_spec" == false ]]; then
  fetch_spec --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/mistralai/platform-docs-public/refs/heads/main/openapi.yaml
elif [[ ! -f openapi.yaml ]]; then
  echo "error: --pinned-spec requested but openapi.yaml does not exist." >&2
  exit 1
fi

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
