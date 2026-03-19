# Chat Client Tool Calling Single Turn



This example assumes `using Mistral;` is in scope and `apiKey` contains your Mistral API key.

```csharp
using var client = new MistralClient(apiKey);

var getWeatherTool = Meai.AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is 72°F and sunny.",
    name: "get_weather",
    description: "Gets the current weather for a given location.");

Meai.IChatClient chatClient = client;
var response = await chatClient.GetResponseAsync(
    [
        new Meai.ChatMessage(Meai.ChatRole.User, "What is the weather in Paris?")
    ],
    new Meai.ChatOptions
    {
        ModelId = "mistral-small-latest",
        Tools = [getWeatherTool],
    });

var functionCall = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<Meai.FunctionCallContent>()
    .FirstOrDefault();
```