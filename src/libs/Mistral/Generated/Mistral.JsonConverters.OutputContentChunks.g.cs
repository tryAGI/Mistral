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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TextChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TextChunk> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.TextChunk).Name}");
                        textChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ImageURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ImageURLChunk> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ImageURLChunk).Name}");
                        imageURLChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ToolFileChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ToolFileChunk> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ToolFileChunk).Name}");
                        toolFileChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.DocumentURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.DocumentURLChunk> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.DocumentURLChunk).Name}");
                        documentURLChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ThinkChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ThinkChunk> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ThinkChunk).Name}");
                        thinkChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ToolReferenceChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ToolReferenceChunk> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ToolReferenceChunk).Name}");
                        toolReferenceChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TextChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TextChunk> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.TextChunk).Name}");
                    textChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ImageURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ImageURLChunk> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ImageURLChunk).Name}");
                    imageURLChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ToolFileChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ToolFileChunk> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ToolFileChunk).Name}");
                    toolFileChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.DocumentURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.DocumentURLChunk> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.DocumentURLChunk).Name}");
                    documentURLChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ThinkChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ThinkChunk> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ThinkChunk).Name}");
                    thinkChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ToolReferenceChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ToolReferenceChunk> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ToolReferenceChunk).Name}");
                    toolReferenceChunk = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TextChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TextChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.TextChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextChunk!, typeInfo);
            }
            else if (value.IsImageURLChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ImageURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ImageURLChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ImageURLChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageURLChunk!, typeInfo);
            }
            else if (value.IsToolFileChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ToolFileChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ToolFileChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ToolFileChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolFileChunk!, typeInfo);
            }
            else if (value.IsDocumentURLChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.DocumentURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.DocumentURLChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.DocumentURLChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentURLChunk!, typeInfo);
            }
            else if (value.IsThinkChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ThinkChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ThinkChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ThinkChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkChunk!, typeInfo);
            }
            else if (value.IsToolReferenceChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ToolReferenceChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ToolReferenceChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ToolReferenceChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReferenceChunk!, typeInfo);
            }
        }
    }
}