/*
order: 90
title: Test
slug: test
*/

namespace Mistral.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Generate()
    {
        using var client = GetAuthenticatedClient();

        ChatCompletionResponse response = await client.Agents.AgentsCompletionAsync(
            agentId: "Test",
            messages: new List<MessagesItem3>
            {
                new UserMessage
                {
                    Content = "Hello",
                },
            });
    }
}
