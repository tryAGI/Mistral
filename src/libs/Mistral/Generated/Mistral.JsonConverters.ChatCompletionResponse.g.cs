#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ChatCompletionResponse>
    {
        /// <inheritdoc />
        public override global::Mistral.ChatCompletionResponse Read(
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
            if (__jsonProps.Contains("choices")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Mistral.ChatCompletionResponseBase? @base = default;
            global::Mistral.ChatCompletionResponseChatCompletionResponse1? response1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        @base = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ChatCompletionResponseBase>(__rawJson, options);
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
                        response1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ChatCompletionResponseChatCompletionResponse1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && response1 == null)
            {
                try
                {
                    @base = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ChatCompletionResponseBase>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    response1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ChatCompletionResponseChatCompletionResponse1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mistral.ChatCompletionResponse(
                @base,

                response1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ChatCompletionResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBase)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base, typeof(global::Mistral.ChatCompletionResponseBase), options);
            }
            else if (value.IsResponse1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Response1, typeof(global::Mistral.ChatCompletionResponseChatCompletionResponse1), options);
            }
        }
    }
}