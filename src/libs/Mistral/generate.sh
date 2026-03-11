dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/mistralai/platform-docs-public/refs/heads/main/openapi.yaml
sed -i "s/it's/its/g" openapi.yaml
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
 echo "Failed, exiting..."
 exit 1
fi
autosdk generate openapi.yaml \
  --namespace Mistral \
  --clientClassName MistralClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention Summary
