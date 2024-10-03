#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class ContentChunkJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ContentChunk>
    {
        /// <inheritdoc />
        public override global::Mistral.ContentChunk Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Mistral.TextChunk? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TextChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TextChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.TextChunk).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Mistral.ImageURLChunk? imageURL = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ImageURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ImageURLChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ImageURLChunk).Name}");
                imageURL = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::Mistral.ContentChunk(
                text,
                imageURL
                );

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TextChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TextChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.TextChunk).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (imageURL != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ImageURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ImageURLChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ImageURLChunk).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ContentChunk value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TextChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TextChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.TextChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImageURL)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ImageURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ImageURLChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ImageURLChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageURL, typeInfo);
            }
        }
    }
}