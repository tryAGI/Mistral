# Chat Client Get Service Returns Self



This example assumes `using Mistral;` is in scope and `apiKey` contains your Mistral API key.

```csharp
using var client = CreateTestClient();
Meai.IChatClient chatClient = client;

var self = Meai.ChatClientExtensions.GetService<MistralClient>(chatClient);
```