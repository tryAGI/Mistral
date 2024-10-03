namespace Mistral.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static MistralClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MISTRAL_API_KEY") ??
            throw new AssertInconclusiveException("MISTRAL_API_KEY environment variable is not found.");

        var client = new MistralClient(apiKey);
        
        return client;
    }
}
