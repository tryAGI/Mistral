#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionResponseBaseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ChatCompletionResponseBase>
    {
        /// <inheritdoc />
        public override global::Mistral.ChatCompletionResponseBase Read(
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
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("object")) __score0++;
            if (__jsonProps.Contains("usage")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("created")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Mistral.ResponseBase? responseBase = default;
            global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1? base1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        responseBase = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ResponseBase>(__rawJson, options);
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
                        base1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responseBase == null && base1 == null)
            {
                try
                {
                    responseBase = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ResponseBase>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    base1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mistral.ChatCompletionResponseBase(
                responseBase,

                base1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ChatCompletionResponseBase value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsResponseBase)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseBase, typeof(global::Mistral.ResponseBase), options);
            }
            else if (value.IsBase1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base1, typeof(global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1), options);
            }
        }
    }
}