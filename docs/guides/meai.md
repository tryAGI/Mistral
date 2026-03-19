# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The `tryAGI.Mistral` SDK implements the `IChatClient` interface from `Microsoft.Extensions.AI`, enabling you to use Mistral models through a standardized .NET AI abstraction.

!!! warning "Namespace Conflict"
    This SDK has a generated `IChatClient` interface that conflicts with `Microsoft.Extensions.AI.IChatClient`. Use the `Meai` alias pattern shown below.

## Supported Interfaces

| Interface | Support Level |
|-----------|--------------|
| `IChatClient` | Full (text, streaming, tool calling, images) |

## IChatClient

### Installation

```bash
dotnet add package tryAGI.Mistral
```

### Basic Usage

Because the SDK generates its own `IChatClient` interface, you must use a namespace alias to reference the MEAI interface explicitly:

```csharp
using Mistral;
using Meai = Microsoft.Extensions.AI;

using var client = new MistralClient(apiKey);
Meai.IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    "What is the capital of France?",
    new Meai.ChatOptions
    {
        ModelId = "mistral-large-latest",
    });

Console.WriteLine(response.Text);
```

### Streaming

```csharp
using Meai = Microsoft.Extensions.AI;

Meai.IChatClient chatClient = client;

await foreach (var update in chatClient.GetStreamingResponseAsync(
    "Write a short poem about coding.",
    new Meai.ChatOptions
    {
        ModelId = "mistral-large-latest",
    }))
{
    Console.Write(update.Text);
}
```

### Tool Calling

```csharp
using CSharpToJsonSchema;
using Meai = Microsoft.Extensions.AI;

[GenerateJsonSchema]
public interface IWeatherTools
{
    [Description("Gets the current weather for a location.")]
    string GetWeather(
        [Description("The city name")] string city);
}

Meai.IChatClient chatClient = client;
var service = new WeatherToolsService();

var response = await chatClient.GetResponseAsync(
    "What's the weather in Paris?",
    new Meai.ChatOptions
    {
        ModelId = "mistral-large-latest",
        Tools = service.AsTools().AsAITools(),
    });
```

### Image Input

```csharp
using Meai = Microsoft.Extensions.AI;

Meai.IChatClient chatClient = client;

var response = await chatClient.GetResponseAsync(
    [
        new Meai.ChatMessage(Meai.ChatRole.User,
        [
            new Meai.ImageContent(imageBytes, "image/png"),
            new Meai.TextContent("Describe this image."),
        ]),
    ],
    new Meai.ChatOptions
    {
        ModelId = "mistral-large-latest",
    });
```

### Accessing Client Metadata

When using the `Meai` alias, call extension methods explicitly:

```csharp
var metadata = Meai.ChatClientExtensions.GetService<Meai.ChatClientMetadata>(chatClient);
var self = Meai.ChatClientExtensions.GetService<MistralClient>(chatClient);
```
