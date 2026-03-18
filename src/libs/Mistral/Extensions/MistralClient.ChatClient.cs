using System.Runtime.CompilerServices;
using System.Text.Json;
using Meai = Microsoft.Extensions.AI;

namespace Mistral;

public partial class MistralClient : Meai.IChatClient
{
    private Meai.ChatClientMetadata? _chatMetadata;

    object? Meai.IChatClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(Meai.ChatClientMetadata) ? (_chatMetadata ??= new(nameof(MistralClient), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<Meai.ChatResponse> Meai.IChatClient.GetResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(messages);

        var request = CreateRequest(messages, options);
        var response = await Chat.ChatCompletionAsync(request, cancellationToken).ConfigureAwait(false);

        return CreateChatResponse(response, options?.ModelId);
    }

    async IAsyncEnumerable<Meai.ChatResponseUpdate> Meai.IChatClient.GetStreamingResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(messages);

        var request = CreateRequest(messages, options);
        request.Stream = true;

        await foreach (var completionEvent in Chat.ChatCompletionAsStreamAsync(request, cancellationToken).ConfigureAwait(false))
        {
            var chunk = completionEvent.Data;
            var choice = chunk.Choices.Count > 0 ? chunk.Choices[0] : null;

            var update = new Meai.ChatResponseUpdate
            {
                ResponseId = chunk.Id,
                ModelId = chunk.Model,
                RawRepresentation = chunk,
                Role = Meai.ChatRole.Assistant,
            };

            if (choice is not null)
            {
                AddDeltaContents(update.Contents, choice.Delta);
                update.FinishReason = ToFinishReason(choice.FinishReason);
            }

            if (chunk.Usage is { } usage)
            {
                update.Contents.Add(new Meai.UsageContent(CreateUsageDetails(usage))
                {
                    RawRepresentation = usage,
                });
            }

            yield return update;
        }
    }

    private static ChatCompletionRequest CreateRequest(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions? options)
    {
        var requestMessages = new List<MessagesItem>();

        if (!string.IsNullOrWhiteSpace(options?.Instructions))
        {
            requestMessages.Add(new SystemMessage
            {
                Content = options!.Instructions!,
            });
        }

        foreach (var message in messages)
        {
            requestMessages.Add(ToMistralMessage(message));
        }

        var request = options?.RawRepresentationFactory?.Invoke(null!) as ChatCompletionRequest;
        if (request is null)
        {
            request = new ChatCompletionRequest
            {
                Model = options?.ModelId ?? "mistral-small-latest",
                Messages = requestMessages,
            };
        }
        else
        {
            request.Model ??= options?.ModelId ?? "mistral-small-latest";
            request.Messages ??= [];
            foreach (var message in requestMessages)
            {
                request.Messages.Add(message);
            }
        }

        ApplyOptions(request, options);
        return request;
    }

    private static MessagesItem ToMistralMessage(Meai.ChatMessage message)
    {
        if (message.Role == Meai.ChatRole.System)
        {
            return new SystemMessage
            {
                Content = string.Concat(message.Contents.OfType<Meai.TextContent>().Select(tc => tc.Text)),
            };
        }

        if (message.Role == Meai.ChatRole.Tool)
        {
            var functionResult = message.Contents.OfType<Meai.FunctionResultContent>().FirstOrDefault();
            return new ToolMessage
            {
                Content = ToResultString(functionResult),
                ToolCallId = functionResult?.CallId,
            };
        }

        if (message.Role == Meai.ChatRole.Assistant)
        {
            var toolCalls = message.Contents.OfType<Meai.FunctionCallContent>().ToList();
            var text = string.Concat(message.Contents.OfType<Meai.TextContent>().Select(tc => tc.Text));

            var assistantMessage = new AssistantMessage
            {
                Content = string.IsNullOrEmpty(text) ? null : (AnyOf<string, object, IList<ContentChunk>>?)new AnyOf<string, object, IList<ContentChunk>>(text),
            };

            if (toolCalls.Count > 0)
            {
                assistantMessage.ToolCalls = toolCalls.Select(tc => new ToolCall
                {
                    Id = tc.CallId,
                    Type = ToolTypes.Function,
                    Function = new FunctionCall
                    {
                        Name = tc.Name,
                        Arguments = tc.Arguments is { } args
                            ? new AnyOf<object, string>(JsonSerializer.Serialize(args))
                            : new AnyOf<object, string>("{}"),
                    },
                }).ToList();
            }

            return assistantMessage;
        }

        // User message
        var contents = new List<ContentChunk>();
        foreach (var item in message.Contents)
        {
            switch (item)
            {
                case Meai.TextContent textContent:
                    contents.Add(new TextChunk { Text = textContent.Text });
                    break;

                case Meai.DataContent dataContent when dataContent.HasTopLevelMediaType("image"):
                    if (dataContent.Uri is { } uri)
                    {
                        contents.Add(new ImageURLChunk
                        {
                            ImageUrl = new ImageURL { Url = uri.ToString() },
                        });
                    }
                    else if (dataContent.Data is { } data)
                    {
                        var mediaType = dataContent.MediaType ?? "image/png";
                        contents.Add(new ImageURLChunk
                        {
                            ImageUrl = new ImageURL
                            {
                                Url = $"data:{mediaType};base64,{Convert.ToBase64String(data.ToArray())}",
                            },
                        });
                    }
                    break;

                case Meai.TextReasoningContent:
                case Meai.UsageContent:
                    break;
            }
        }

        if (contents.Count == 1 && contents[0].IsText)
        {
            return new UserMessage
            {
                Content = contents[0].Text!.Text,
            };
        }

        return new UserMessage
        {
            Content = new AnyOf<string, object, IList<ContentChunk>>(contents),
        };
    }

    private static void ApplyOptions(ChatCompletionRequest request, Meai.ChatOptions? options)
    {
        if (options is null)
        {
            return;
        }

        request.Temperature ??= options.Temperature;
        request.TopP ??= options.TopP;
        request.MaxTokens ??= options.MaxOutputTokens;
        request.RandomSeed ??= ToInt32(options.Seed);

        if (request.Stop is null && options.StopSequences is { Count: > 0 } stopSequences)
        {
            request.Stop = stopSequences.Count == 1
                ? new AnyOf<string, IList<string>>(stopSequences[0])
                : new AnyOf<string, IList<string>>(stopSequences.ToList());
        }

        if (request.ResponseFormat is null && options.ResponseFormat is Meai.ChatResponseFormatJson jsonFormat)
        {
            if (jsonFormat.Schema is JsonElement schema &&
                schema.ValueKind is not JsonValueKind.Null and not JsonValueKind.Undefined)
            {
                request.ResponseFormat = new ResponseFormat
                {
                    Type = ResponseFormats.JsonSchema,
                };
            }
            else
            {
                request.ResponseFormat = new ResponseFormat
                {
                    Type = ResponseFormats.JsonObject,
                };
            }
        }

        ApplyTools(request, options);
    }

    private static void ApplyTools(ChatCompletionRequest request, Meai.ChatOptions options)
    {
        if (options.ToolMode is Meai.NoneChatToolMode)
        {
            request.ToolChoice = new AnyOf<ToolChoice2, ToolChoiceEnum?>(ToolChoiceEnum.None);
            return;
        }

        if (options.Tools is { Count: > 0 } aiTools)
        {
            request.Tools ??= [];
            foreach (var tool in aiTools)
            {
                if (tool is not Meai.AIFunction function)
                {
                    throw new NotSupportedException(
                        $"Tool type '{tool.GetType().Name}' is not supported by Mistral. Only function tools are supported.");
                }

                request.Tools.Add(new Tool3
                {
                    Type = ToolTypes.Function,
                    Function = new Function
                    {
                        Name = function.Name,
                        Description = function.Description,
                        Parameters = function.JsonSchema.ValueKind is JsonValueKind.Null or JsonValueKind.Undefined
                            ? new object()
                            : function.JsonSchema,
                    },
                });
            }
        }

        if (options.ToolMode is Meai.RequiredChatToolMode requiredToolMode)
        {
            if (!string.IsNullOrWhiteSpace(requiredToolMode.RequiredFunctionName))
            {
                request.ToolChoice = new AnyOf<ToolChoice2, ToolChoiceEnum?>(new ToolChoice2
                {
                    Type = ToolTypes.Function,
                    Function = new FunctionName { Name = requiredToolMode.RequiredFunctionName! },
                });
            }
            else
            {
                request.ToolChoice = new AnyOf<ToolChoice2, ToolChoiceEnum?>(ToolChoiceEnum.Any);
            }
        }
    }

    private static Meai.ChatResponse CreateChatResponse(ChatCompletionResponse response, string? requestedModelId)
    {
        var responseBase = response.Value1?.ResponseBase;
        var choices = response.Value2?.Choices;
        var choice = choices is { Count: > 0 } ? choices[0] : null;

        var responseMessage = new Meai.ChatMessage
        {
            Role = Meai.ChatRole.Assistant,
            RawRepresentation = response,
        };

        if (choice is not null)
        {
            AddAssistantContents(responseMessage.Contents, choice.Message);
        }

        var chatResponse = new Meai.ChatResponse(responseMessage)
        {
            ResponseId = responseBase?.Id,
            ModelId = responseBase?.Model ?? requestedModelId,
            FinishReason = choice is not null ? ToFinishReason(choice.FinishReason) : null,
            Usage = responseBase?.Usage is { } usage ? CreateUsageDetails(usage) : null,
            RawRepresentation = response,
        };

        return chatResponse;
    }

    private static void AddAssistantContents(IList<Meai.AIContent> contents, AssistantMessage message)
    {
        var textContent = ExtractText(message.Content);
        if (!string.IsNullOrEmpty(textContent))
        {
            contents.Add(new Meai.TextContent(textContent)
            {
                RawRepresentation = message,
            });
        }

        if (message.ToolCalls is { Count: > 0 } toolCalls)
        {
            foreach (var toolCall in toolCalls)
            {
                contents.Add(new Meai.FunctionCallContent(
                    callId: toolCall.Id ?? string.Empty,
                    name: toolCall.Function.Name,
                    arguments: ParseArguments(toolCall.Function.Arguments))
                {
                    RawRepresentation = toolCall,
                });
            }
        }
    }

    private static void AddDeltaContents(IList<Meai.AIContent> contents, DeltaMessage delta)
    {
        var textContent = ExtractText(delta.Content);
        if (!string.IsNullOrEmpty(textContent))
        {
            contents.Add(new Meai.TextContent(textContent)
            {
                RawRepresentation = delta,
            });
        }

        if (delta.ToolCalls is { Count: > 0 } toolCalls)
        {
            foreach (var toolCall in toolCalls)
            {
                contents.Add(new Meai.FunctionCallContent(
                    callId: toolCall.Id ?? string.Empty,
                    name: toolCall.Function.Name,
                    arguments: ParseArguments(toolCall.Function.Arguments))
                {
                    RawRepresentation = toolCall,
                });
            }
        }
    }

    private static string? ExtractText(AnyOf<string, object, IList<ContentChunk>>? content)
    {
        if (content is null)
        {
            return null;
        }

        if (content.Value.IsValue1)
        {
            return content.Value.Value1;
        }

        if (content.Value.IsValue3)
        {
            return string.Concat(content.Value.Value3!
                .Where(c => c.IsText)
                .Select(c => c.Text!.Text));
        }

        return null;
    }

    private static Dictionary<string, object?>? ParseArguments(AnyOf<object, string> arguments)
    {
        if (arguments.IsValue2 && arguments.Value2 is { } argsString)
        {
            if (string.IsNullOrWhiteSpace(argsString) || argsString is "{}")
            {
                return null;
            }

            try
            {
                var element = JsonSerializer.Deserialize<JsonElement>(argsString);
                if (element.ValueKind == JsonValueKind.Object)
                {
                    var dict = new Dictionary<string, object?>(StringComparer.Ordinal);
                    foreach (var property in element.EnumerateObject())
                    {
                        dict[property.Name] = property.Value;
                    }

                    return dict;
                }
            }
            catch (JsonException)
            {
                return null;
            }
        }

        if (arguments.IsValue1 && arguments.Value1 is JsonElement jsonElement)
        {
            if (jsonElement.ValueKind == JsonValueKind.Object)
            {
                var dict = new Dictionary<string, object?>(StringComparer.Ordinal);
                foreach (var property in jsonElement.EnumerateObject())
                {
                    dict[property.Name] = property.Value;
                }

                return dict;
            }
        }

        return null;
    }

    private static string ToResultString(Meai.FunctionResultContent? functionResult)
    {
        if (functionResult is null)
        {
            return string.Empty;
        }

        if (functionResult.Result is JsonElement jsonElement)
        {
            return jsonElement.ValueKind == JsonValueKind.String
                ? jsonElement.GetString() ?? string.Empty
                : jsonElement.GetRawText();
        }

        if (functionResult.Result is string text)
        {
            return text;
        }

        if (functionResult.Result is not null)
        {
            return JsonSerializer.Serialize(functionResult.Result);
        }

        return functionResult.Exception?.Message ?? string.Empty;
    }

    private static Meai.ChatFinishReason? ToFinishReason(ChatCompletionChoiceFinishReason finishReason) =>
        finishReason switch
        {
            ChatCompletionChoiceFinishReason.Stop => Meai.ChatFinishReason.Stop,
            ChatCompletionChoiceFinishReason.Length => Meai.ChatFinishReason.Length,
            ChatCompletionChoiceFinishReason.ModelLength => Meai.ChatFinishReason.Length,
            ChatCompletionChoiceFinishReason.ToolCalls => Meai.ChatFinishReason.ToolCalls,
            ChatCompletionChoiceFinishReason.Error => new Meai.ChatFinishReason("error"),
            _ => null,
        };

    private static Meai.ChatFinishReason? ToFinishReason(CompletionResponseStreamChoiceFinishReason? finishReason) =>
        finishReason switch
        {
            null => null,
            CompletionResponseStreamChoiceFinishReason.Stop => Meai.ChatFinishReason.Stop,
            CompletionResponseStreamChoiceFinishReason.Length => Meai.ChatFinishReason.Length,
            CompletionResponseStreamChoiceFinishReason.ToolCalls => Meai.ChatFinishReason.ToolCalls,
            CompletionResponseStreamChoiceFinishReason.Error => new Meai.ChatFinishReason("error"),
            _ => null,
        };

    private static Meai.UsageDetails CreateUsageDetails(UsageInfo usage) =>
        new()
        {
            InputTokenCount = usage.PromptTokens,
            OutputTokenCount = usage.CompletionTokens,
            TotalTokenCount = usage.TotalTokens,
        };

    private static int? ToInt32(long? value)
    {
        if (value is null)
        {
            return null;
        }

        if (value < int.MinValue || value > int.MaxValue)
        {
            throw new ArgumentOutOfRangeException(nameof(value), value, "The value must fit into a 32-bit integer.");
        }

        return (int)value.Value;
    }
}
