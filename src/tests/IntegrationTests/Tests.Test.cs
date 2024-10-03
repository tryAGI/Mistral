namespace Mistral.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Generate()
    {
        using var client = GetAuthenticatedClient();

        ChatCompletionResponse response = await client.Agents.AgentsCompletionAsync(
            agentId: "Test",
            messages: new List<OneOf<UserMessage, AssistantMessage, ToolMessage>>
            {
                new UserMessage
                {
                    Content = "Hello",
                },
            });
    }
}
