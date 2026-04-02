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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("agent_version")) __score0++;
            if (__jsonProps.Contains("completion_args")) __score0++;
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
                        @base = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ConversationRestartRequestBase>(__rawJson, options);
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
                        conversationRestartRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ConversationRestartRequestVariant2>(__rawJson, options);
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
                    @base = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ConversationRestartRequestBase>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conversationRestartRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ConversationRestartRequestVariant2>(__rawJson, options);
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

            if (value.IsBase)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base, typeof(global::Mistral.ConversationRestartRequestBase), options);
            }
            else if (value.IsConversationRestartRequestVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationRestartRequestVariant2, typeof(global::Mistral.ConversationRestartRequestVariant2), options);
            }
        }
    }
}