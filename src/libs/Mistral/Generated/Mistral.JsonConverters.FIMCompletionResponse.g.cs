#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class FIMCompletionResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.FIMCompletionResponse>
    {
        /// <inheritdoc />
        public override global::Mistral.FIMCompletionResponse Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("model")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Mistral.ChatCompletionResponse? chat = default;
            global::Mistral.FIMCompletionResponseVariant2? fIMCompletionResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        chat = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ChatCompletionResponse>(__rawJson, options);
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
                        fIMCompletionResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.FIMCompletionResponseVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chat == null && fIMCompletionResponseVariant2 == null)
            {
                try
                {
                    chat = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ChatCompletionResponse>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    fIMCompletionResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.FIMCompletionResponseVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mistral.FIMCompletionResponse(
                chat,

                fIMCompletionResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.FIMCompletionResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsChat)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat, typeof(global::Mistral.ChatCompletionResponse), options);
            }
            else if (value.IsFIMCompletionResponseVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FIMCompletionResponseVariant2, typeof(global::Mistral.FIMCompletionResponseVariant2), options);
            }
        }
    }
}