#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class ConversationRestartRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ConversationRestartRequest>
    {
        /// <inheritdoc />
        public override global::Mistral.ConversationRestartRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("agent_version")) __score0++;
            if (__jsonProps.Contains("completion_args")) __score0++;
            if (__jsonProps.Contains("completion_args.frequency_penalty")) __score0++;
            if (__jsonProps.Contains("completion_args.max_tokens")) __score0++;
            if (__jsonProps.Contains("completion_args.prediction")) __score0++;
            if (__jsonProps.Contains("completion_args.presence_penalty")) __score0++;
            if (__jsonProps.Contains("completion_args.random_seed")) __score0++;
            if (__jsonProps.Contains("completion_args.reasoning_effort")) __score0++;
            if (__jsonProps.Contains("completion_args.response_format")) __score0++;
            if (__jsonProps.Contains("completion_args.stop")) __score0++;
            if (__jsonProps.Contains("completion_args.temperature")) __score0++;
            if (__jsonProps.Contains("completion_args.tool_choice")) __score0++;
            if (__jsonProps.Contains("completion_args.top_p")) __score0++;
            if (__jsonProps.Contains("from_entry_id")) __score0++;
            if (__jsonProps.Contains("guardrails")) __score0++;
            if (__jsonProps.Contains("handoff_execution")) __score0++;
            if (__jsonProps.Contains("inputs")) __score0++;
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("store")) __score0++;
            if (__jsonProps.Contains("stream")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("stream")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Mistral.ConversationRestartRequestBase? @base = default;
            global::Mistral.ConversationRestartRequestVariant2? conversationRestartRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRestartRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRestartRequestBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRestartRequestBase).Name}");
                        @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRestartRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRestartRequestVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRestartRequestVariant2).Name}");
                        conversationRestartRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && conversationRestartRequestVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRestartRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRestartRequestBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRestartRequestBase).Name}");
                    @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRestartRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRestartRequestVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRestartRequestVariant2).Name}");
                    conversationRestartRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mistral.ConversationRestartRequest(
                @base,

                conversationRestartRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ConversationRestartRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRestartRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRestartRequestBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRestartRequestBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!, typeInfo);
            }
            else if (value.IsConversationRestartRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRestartRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRestartRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRestartRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationRestartRequestVariant2!, typeInfo);
            }
        }
    }
}