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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ContentChunkDiscriminator>(ref readerCopy, options);

            global::Mistral.TextChunk? text = default;
            if (discriminator?.Type == global::Mistral.ContentChunkDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.TextChunk>(ref reader, options);
            }
            global::Mistral.ImageURLChunk? imageUrl = default;
            if (discriminator?.Type == global::Mistral.ContentChunkDiscriminatorType.ImageUrl)
            {
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ImageURLChunk>(ref reader, options);
            }
            global::Mistral.DocumentURLChunk? documentUrl = default;
            if (discriminator?.Type == global::Mistral.ContentChunkDiscriminatorType.DocumentUrl)
            {
                documentUrl = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.DocumentURLChunk>(ref reader, options);
            }
            global::Mistral.ReferenceChunk? reference = default;
            if (discriminator?.Type == global::Mistral.ContentChunkDiscriminatorType.Reference)
            {
                reference = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ReferenceChunk>(ref reader, options);
            }
            global::Mistral.FileChunk? file = default;
            if (discriminator?.Type == global::Mistral.ContentChunkDiscriminatorType.File)
            {
                file = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.FileChunk>(ref reader, options);
            }
            global::Mistral.ThinkChunk? thinking = default;
            if (discriminator?.Type == global::Mistral.ContentChunkDiscriminatorType.Thinking)
            {
                thinking = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ThinkChunk>(ref reader, options);
            }
            global::Mistral.AudioChunk? inputAudio = default;
            if (discriminator?.Type == global::Mistral.ContentChunkDiscriminatorType.InputAudio)
            {
                inputAudio = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.AudioChunk>(ref reader, options);
            }

            var __value = new global::Mistral.ContentChunk(
                discriminator?.Type,
                text,

                imageUrl,

                documentUrl,

                reference,

                file,

                thinking,

                inputAudio
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ContentChunk value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Mistral.TextChunk), options);
            }
            else if (value.IsImageUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeof(global::Mistral.ImageURLChunk), options);
            }
            else if (value.IsDocumentUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentUrl, typeof(global::Mistral.DocumentURLChunk), options);
            }
            else if (value.IsReference)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reference, typeof(global::Mistral.ReferenceChunk), options);
            }
            else if (value.IsFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeof(global::Mistral.FileChunk), options);
            }
            else if (value.IsThinking)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking, typeof(global::Mistral.ThinkChunk), options);
            }
            else if (value.IsInputAudio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudio, typeof(global::Mistral.AudioChunk), options);
            }
        }
    }
}