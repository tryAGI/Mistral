# Test



This example assumes `using Mistral;` is in scope and `apiKey` contains your Mistral API key.

```csharp
using var client = new MistralClient(apiKey);

ChatCompletionResponse response = await client.Agents.AgentsCompletionAsync(
    agentId: "Test",
    messages: new List<MessagesItem3>
    {
        new UserMessage
        {
            Content = "Hello",
        },
    });
```