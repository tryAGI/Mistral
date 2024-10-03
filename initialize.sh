dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Mistral \
  MistralClient \
  https://docs.mistral.ai/redocusaurus/plugin-redoc-0.yaml \
  tryAGI \
  --output .
