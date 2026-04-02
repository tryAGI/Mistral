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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.SystemMessageContentChunksDiscriminator>(ref readerCopy, options);

            global::Mistral.TextChunk? text = default;
            if (discriminator?.Type == global::Mistral.SystemMessageContentChunksDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.TextChunk>(ref reader, options);
            }
            global::Mistral.ThinkChunk? thinking = default;
            if (discriminator?.Type == global::Mistral.SystemMessageContentChunksDiscriminatorType.Thinking)
            {
                thinking = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ThinkChunk>(ref reader, options);
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

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Mistral.TextChunk), options);
            }
            else if (value.IsThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeof(global::Mistral.ThinkChunk), options);
            }
        }
    }
}