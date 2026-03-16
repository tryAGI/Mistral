dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/mistralai/platform-docs-public/refs/heads/main/openapi.yaml
perl -0pi -e "s/it's/its/g" openapi.yaml
autosdk generate openapi.yaml \
  --namespace Mistral \
  --clientClassName MistralClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention Summary
