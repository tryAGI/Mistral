# Chat Client Five Random Words Streaming



This example assumes `using Mistral;` is in scope and `apiKey` contains your Mistral API key.

```csharp
using var client = new MistralClient(apiKey);

Meai.IChatClient chatClient = client;
var updates = chatClient.GetStreamingResponseAsync(
    [
        new Meai.ChatMessage(Meai.ChatRole.User, "Generate 5 random words.")
    ],
    new Meai.ChatOptions
    {
        ModelId = "mistral-small-latest",
    });

var deltas = new List<string>();
await foreach (var update in updates)
{
    if (!string.IsNullOrWhiteSpace(update.Text))
    {
        deltas.Add(update.Text);
    }
}
```