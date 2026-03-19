/*
order: 60
title: Chat Client Tool Calling Multi Turn
slug: chat-client-tool-calling-multi-turn
*/

using Meai = Microsoft.Extensions.AI;

namespace Mistral.IntegrationTests;

public partial class Tests
{
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
}
