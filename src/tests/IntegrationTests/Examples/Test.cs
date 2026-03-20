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

        ChatCompletionResponse response = await client.Chat.ChatCompletionAsync(
            model: "mistral-small-latest",
            messages: new List<MessagesItem>
            {
                new UserMessage
                {
                    Content = "Hello",
                },
            });
    }
}
