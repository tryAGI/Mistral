#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class ChatClassificationRequestInputsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ChatClassificationRequestInputs>
    {
        /// <inheritdoc />
        public override global::Mistral.ChatClassificationRequestInputs Read(
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
            if (__jsonProps.Contains("messages")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Mistral.InstructRequest? instructRequest = default;
            global::System.Collections.Generic.IList<global::Mistral.InstructRequest>? chatClassificationRequestInputsVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        instructRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.InstructRequest>(__rawJson, options);
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
                        chatClassificationRequestInputsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::Mistral.InstructRequest>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (instructRequest == null && chatClassificationRequestInputsVariant2 == null)
            {
                try
                {
                    instructRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.InstructRequest>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatClassificationRequestInputsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::Mistral.InstructRequest>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mistral.ChatClassificationRequestInputs(
                instructRequest,

                chatClassificationRequestInputsVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ChatClassificationRequestInputs value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInstructRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InstructRequest, typeof(global::Mistral.InstructRequest), options);
            }
            else if (value.IsChatClassificationRequestInputsVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatClassificationRequestInputsVariant2, typeof(global::System.Collections.Generic.IList<global::Mistral.InstructRequest>), options);
            }
        }
    }
}