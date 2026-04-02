#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class OutputContentChunksJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.OutputContentChunks>
    {
        /// <inheritdoc />
        public override global::Mistral.OutputContentChunks Read(
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
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("image_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("file_id")) __score2++;
            if (__jsonProps.Contains("file_name")) __score2++;
            if (__jsonProps.Contains("file_type")) __score2++;
            if (__jsonProps.Contains("tool")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("document_name")) __score3++;
            if (__jsonProps.Contains("document_url")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("closed")) __score4++;
            if (__jsonProps.Contains("thinking")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("description")) __score5++;
            if (__jsonProps.Contains("favicon")) __score5++;
            if (__jsonProps.Contains("title")) __score5++;
            if (__jsonProps.Contains("tool")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("url")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::Mistral.TextChunk? textChunk = default;
            global::Mistral.ImageURLChunk? imageURLChunk = default;
            global::Mistral.ToolFileChunk? toolFileChunk = default;
            global::Mistral.DocumentURLChunk? documentURLChunk = default;
            global::Mistral.ThinkChunk? thinkChunk = default;
            global::Mistral.ToolReferenceChunk? toolReferenceChunk = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        textChunk = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.TextChunk>(__rawJson, options);
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
                        imageURLChunk = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ImageURLChunk>(__rawJson, options);
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
                        toolFileChunk = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ToolFileChunk>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        documentURLChunk = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.DocumentURLChunk>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        thinkChunk = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ThinkChunk>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        toolReferenceChunk = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ToolReferenceChunk>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (textChunk == null && imageURLChunk == null && toolFileChunk == null && documentURLChunk == null && thinkChunk == null && toolReferenceChunk == null)
            {
                try
                {
                    textChunk = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.TextChunk>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    imageURLChunk = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ImageURLChunk>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolFileChunk = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ToolFileChunk>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    documentURLChunk = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.DocumentURLChunk>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    thinkChunk = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ThinkChunk>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolReferenceChunk = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ToolReferenceChunk>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mistral.OutputContentChunks(
                textChunk,

                imageURLChunk,

                toolFileChunk,

                documentURLChunk,

                thinkChunk,

                toolReferenceChunk
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.OutputContentChunks value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTextChunk)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextChunk, typeof(global::Mistral.TextChunk), options);
            }
            else if (value.IsImageURLChunk)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageURLChunk, typeof(global::Mistral.ImageURLChunk), options);
            }
            else if (value.IsToolFileChunk)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolFileChunk, typeof(global::Mistral.ToolFileChunk), options);
            }
            else if (value.IsDocumentURLChunk)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentURLChunk, typeof(global::Mistral.DocumentURLChunk), options);
            }
            else if (value.IsThinkChunk)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkChunk, typeof(global::Mistral.ThinkChunk), options);
            }
            else if (value.IsToolReferenceChunk)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReferenceChunk, typeof(global::Mistral.ToolReferenceChunk), options);
            }
        }
    }
}