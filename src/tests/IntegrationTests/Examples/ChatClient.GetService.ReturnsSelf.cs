/*
order: 50
title: Chat Client Get Service Returns Self
slug: chat-client-get-service-returns-self
*/

using Meai = Microsoft.Extensions.AI;

namespace Mistral.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void ChatClient_GetService_ReturnsSelf()
    {
        using var client = CreateTestClient();
        Meai.IChatClient chatClient = client;

        var self = Meai.ChatClientExtensions.GetService<MistralClient>(chatClient);

        self.Should().BeSameAs(client);
    }
}
