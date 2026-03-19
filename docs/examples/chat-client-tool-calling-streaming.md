# Chat Client Tool Calling Streaming



This example assumes `using Mistral;` is in scope and `apiKey` contains your Mistral API key.

```csharp
using var client = new MistralClient(apiKey);

var getWeatherTool = Meai.AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is 72°F and sunny.",
    name: "get_weather",
    description: "Gets the current weather for a given location.");

Meai.IChatClient chatClient = client;
var updates = chatClient.GetStreamingResponseAsync(
    [
        new Meai.ChatMessage(Meai.ChatRole.User, "What is the weather in Paris?")
    ],
    new Meai.ChatOptions
    {
        ModelId = "mistral-small-latest",
        Tools = [getWeatherTool],
    });

var functionCalls = new List<Meai.FunctionCallContent>();
await foreach (var update in updates)
{
    functionCalls.AddRange(update.Contents.OfType<Meai.FunctionCallContent>());
}
```