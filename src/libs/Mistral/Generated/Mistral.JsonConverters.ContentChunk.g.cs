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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ContentChunkDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ContentChunkDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ContentChunkDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.TextChunk? text = default;
            if (discriminator?.Type == global::Mistral.ContentChunkDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TextChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TextChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.TextChunk)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.ImageURLChunk? imageUrl = default;
            if (discriminator?.Type == global::Mistral.ContentChunkDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ImageURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ImageURLChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ImageURLChunk)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.DocumentURLChunk? documentUrl = default;
            if (discriminator?.Type == global::Mistral.ContentChunkDiscriminatorType.DocumentUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.DocumentURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.DocumentURLChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.DocumentURLChunk)}");
                documentUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.ReferenceChunk? reference = default;
            if (discriminator?.Type == global::Mistral.ContentChunkDiscriminatorType.Reference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ReferenceChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ReferenceChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ReferenceChunk)}");
                reference = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.FileChunk? file = default;
            if (discriminator?.Type == global::Mistral.ContentChunkDiscriminatorType.File)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.FileChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.FileChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.FileChunk)}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.ContentChunk(
                discriminator?.Type,
                text,
                imageUrl,
                documentUrl,
                reference,
                file
                );

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
            else if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ImageURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ImageURLChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ImageURLChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeInfo);
            }
            else if (value.IsDocumentUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.DocumentURLChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.DocumentURLChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.DocumentURLChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentUrl, typeInfo);
            }
            else if (value.IsReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ReferenceChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ReferenceChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ReferenceChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reference, typeInfo);
            }
            else if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.FileChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.FileChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.FileChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeInfo);
            }
        }
    }
}