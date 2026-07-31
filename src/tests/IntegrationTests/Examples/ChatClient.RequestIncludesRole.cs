/*
order: 15
title: Chat Client Request Includes Role
slug: chat-client-request-includes-role
*/

using System.Net;
using System.Text;
using System.Text.Json;
using Meai = Microsoft.Extensions.AI;

namespace Mistral.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_RequestIncludesRole()
    {
        var handler = new RecordingHandler();
        using var httpClient = new HttpClient(handler);
        using var client = new MistralClient("test-key", httpClient, disposeHttpClient: false);

        Meai.IChatClient chatClient = client;
        await chatClient.GetResponseAsync(
            [new Meai.ChatMessage(Meai.ChatRole.User, "Generate 5 random words.")]);

        using var request = JsonDocument.Parse(handler.RequestBody!);
        var message = request.RootElement.GetProperty("messages")[0];

        message.GetProperty("role").GetString().Should().Be("user");
        message.GetProperty("content").GetString().Should().Be("Generate 5 random words.");
    }

    private sealed class RecordingHandler : HttpMessageHandler
    {
        public string? RequestBody { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            RequestBody = await request.Content!.ReadAsStringAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(
                    """
                    {
                      "id": "test-response",
                      "object": "chat.completion",
                      "model": "mistral-small-latest",
                      "usage": {
                        "prompt_tokens": 5,
                        "completion_tokens": 5,
                        "total_tokens": 10
                      },
                      "created": 0,
                      "choices": [
                        {
                          "index": 0,
                          "message": {
                            "role": "assistant",
                            "content": "alpha beta gamma delta epsilon"
                          },
                          "finish_reason": "stop"
                        }
                      ]
                    }
                    """,
                    Encoding.UTF8,
                    "application/json"),
            };
        }
    }
}
