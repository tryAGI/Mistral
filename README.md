# Mistral

[![Nuget package](https://img.shields.io/nuget/vpre/Mistral)](https://www.nuget.org/packages/Mistral/)
[![dotnet](https://github.com/tryAGI/Mistral/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Mistral/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Mistral)](https://github.com/tryAGI/Mistral/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Mistral OpenAPI specification](https://raw.githubusercontent.com/mistralai/platform-docs-public/refs/heads/main/openapi.yaml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Microsoft.Extensions.AI `IChatClient` support

### Usage
```csharp
using Mistral;

using var client = new MistralClient(apiKey);

ChatCompletionResponse response = await client.Agents.AgentsCompletionAsync(
    agentId: "Test",
    messages: new List<OneOf<UserMessage, AssistantMessage, ToolMessage>>
    {
        new UserMessage
        {
            Content = "Hello",
        },
    });
```

### Microsoft.Extensions.AI

The SDK implements [`IChatClient`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.ichatclient) for seamless integration with the .NET AI ecosystem:
```csharp
using Mistral;
using Meai = Microsoft.Extensions.AI;

Meai.IChatClient chatClient = new MistralClient(apiKey);

var response = await chatClient.GetResponseAsync(
    [new Meai.ChatMessage(Meai.ChatRole.User, "Hello!")],
    new Meai.ChatOptions { ModelId = "mistral-large-latest" });

Console.WriteLine(response.Text);
```

> **Note:** Use the `Meai` alias because the Mistral SDK has its own generated `IChatClient` interface.

<!-- EXAMPLES:START -->
### Chat Client Five Random Words Streaming
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

### Chat Client Five Random Words
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

### Chat Client Get Service Returns Chat Client Metadata
```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var metadata = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient);
```

### Chat Client Get Service Returns Null For Unknown Key
```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var result = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient, serviceKey: "unknown");
```

### Chat Client Get Service Returns Self
```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var self = Meai.ChatClientExtensions.GetService<MistralClient>(chatClient);
```

### Chat Client Tool Calling Multi Turn
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

### Chat Client Tool Calling Single Turn
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

### Chat Client Tool Calling Streaming
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

### Test
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
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Mistral/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Mistral/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
