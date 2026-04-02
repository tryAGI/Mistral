#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class FunctionCallEntryArgumentsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.FunctionCallEntryArguments>
    {
        /// <inheritdoc />
        public override global::Mistral.FunctionCallEntryArguments Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            object? functionCallEntryArgumentsVariant1 = default;
            string? functionCallEntryArgumentsVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        functionCallEntryArgumentsVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
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

                        functionCallEntryArgumentsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (functionCallEntryArgumentsVariant1 == null && functionCallEntryArgumentsVariant2 == null)
            {
                try
                {

                    functionCallEntryArgumentsVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    functionCallEntryArgumentsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mistral.FunctionCallEntryArguments(
                functionCallEntryArgumentsVariant1,

                functionCallEntryArgumentsVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.FunctionCallEntryArguments value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsFunctionCallEntryArgumentsVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallEntryArgumentsVariant1, typeof(object), options);
            }
            else if (value.IsFunctionCallEntryArgumentsVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallEntryArgumentsVariant2, typeof(string), options);
            }
        }
    }
}