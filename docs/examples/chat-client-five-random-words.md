# Chat Client Five Random Words



This example assumes `using Mistral;` is in scope and `apiKey` contains your Mistral API key.

```csharp
using var client = new MistralClient(apiKey);

Meai.IChatClient chatClient = client;
var response = await chatClient.GetResponseAsync(
    [
        new Meai.ChatMessage(Meai.ChatRole.User, "Generate 5 random words.")
    ],
    new Meai.ChatOptions
    {
        ModelId = "mistral-small-latest",
    });
```