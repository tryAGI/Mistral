/*
order: 70
title: Chat Client Tool Calling Single Turn
slug: chat-client-tool-calling-single-turn
*/

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
}
