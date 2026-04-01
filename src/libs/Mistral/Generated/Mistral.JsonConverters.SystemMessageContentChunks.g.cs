#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class SystemMessageContentChunksJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.SystemMessageContentChunks>
    {
        /// <inheritdoc />
        public override global::Mistral.SystemMessageContentChunks Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.SystemMessageContentChunksDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.SystemMessageContentChunksDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.SystemMessageContentChunksDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.TextChunk? text = default;
            if (discriminator?.Type == global::Mistral.SystemMessageContentChunksDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TextChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TextChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.TextChunk)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.ThinkChunk? thinking = default;
            if (discriminator?.Type == global::Mistral.SystemMessageContentChunksDiscriminatorType.Thinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ThinkChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ThinkChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ThinkChunk)}");
                thinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mistral.SystemMessageContentChunks(
                discriminator?.Type,
                text,

                thinking
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.SystemMessageContentChunks value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TextChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TextChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.TextChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ThinkChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ThinkChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ThinkChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking!, typeInfo);
            }
        }
    }
}