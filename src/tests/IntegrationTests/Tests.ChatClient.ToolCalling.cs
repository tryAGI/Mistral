using Meai = Microsoft.Extensions.AI;

namespace Mistral.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_ToolCalling_SingleTurn()
    {
        using var client = GetAuthenticatedClient();

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

        functionCall.Should().NotBeNull();
        functionCall!.Name.Should().Be("get_weather");
        functionCall.Arguments.Should().NotBeNull();
    }

    [TestMethod]
    public async Task ChatClient_ToolCalling_MultiTurn()
    {
        using var client = GetAuthenticatedClient();

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

        functionCall.Should().NotBeNull("the model should request a tool call");

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

        finalResponse.Text.Should().NotBeNullOrWhiteSpace();
        finalResponse.Text.Should().Contain("72", "the response should include information from the tool result");
    }

    [TestMethod]
    public async Task ChatClient_ToolCalling_Streaming()
    {
        using var client = GetAuthenticatedClient();

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

        functionCalls.Should().NotBeEmpty("the model should request a tool call via streaming");
        functionCalls[0].Name.Should().Be("get_weather");
        functionCalls[0].Arguments.Should().NotBeNull();
    }
}
