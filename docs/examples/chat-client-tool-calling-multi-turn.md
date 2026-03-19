# Chat Client Tool Calling Multi Turn



This example assumes `using Mistral;` is in scope and `apiKey` contains your Mistral API key.

```csharp
using var client = new MistralClient(apiKey);

var getWeatherTool = Meai.AIFunctionFactory.Create(
    (string location) => $"The weather in {location} is 72°F and sunny.",
    name: "get_weather",
    description: "Gets the current weather for a given location.");

Meai.IChatClient chatClient = client;
var messages = new List<Meai.ChatMessage>
{
    new(Meai.ChatRole.User, "What is the weather in Paris?"),
};

// First turn: model requests tool call
var response = await chatClient.GetResponseAsync(
    messages,
    new Meai.ChatOptions
    {
        ModelId = "mistral-small-latest",
        Tools = [getWeatherTool],
    });

var functionCall = response.Messages
    .SelectMany(m => m.Contents)
    .OfType<Meai.FunctionCallContent>()
    .FirstOrDefault();

// Add assistant message with function call and tool result
messages.AddRange(response.Messages);
var toolResult = await getWeatherTool.InvokeAsync(
    functionCall!.Arguments is { } args ? new Meai.AIFunctionArguments(args) : null);
messages.Add(new Meai.ChatMessage(Meai.ChatRole.Tool,
[
    new Meai.FunctionResultContent(functionCall.CallId, toolResult),
]));

// Second turn: model should produce a final text response
var finalResponse = await chatClient.GetResponseAsync(
    messages,
    new Meai.ChatOptions
    {
        ModelId = "mistral-small-latest",
        Tools = [getWeatherTool],
    });
```