#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class CompletionArgsStopJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.CompletionArgsStop>
    {
        /// <inheritdoc />
        public override global::Mistral.CompletionArgsStop Read(
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
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            string? completionArgsStopVariant1 = default;
            global::System.Collections.Generic.IList<string>? completionArgsStopVariant2 = default;
            object? completionArgsStopVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        completionArgsStopVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        completionArgsStopVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<string>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        completionArgsStopVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (completionArgsStopVariant1 == null && completionArgsStopVariant2 == null && completionArgsStopVariant3 == null)
            {
                try
                {

                    completionArgsStopVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    completionArgsStopVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<string>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    completionArgsStopVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mistral.CompletionArgsStop(
                completionArgsStopVariant1,

                completionArgsStopVariant2,

                completionArgsStopVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.CompletionArgsStop value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCompletionArgsStopVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionArgsStopVariant1, typeof(string), options);
            }
            else if (value.IsCompletionArgsStopVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionArgsStopVariant2, typeof(global::System.Collections.Generic.IList<string>), options);
            }
            else if (value.IsCompletionArgsStopVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompletionArgsStopVariant3, typeof(object), options);
            }
        }
    }
}