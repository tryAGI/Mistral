/*
order: 80
title: Chat Client Tool Calling Streaming
slug: chat-client-tool-calling-streaming
*/

using Meai = Microsoft.Extensions.AI;

namespace Mistral.IntegrationTests;

public partial class Tests
{
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
