#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class Data3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.Data3>
    {
        /// <inheritdoc />
        public override global::Mistral.Data3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.TranscriptionStreamEventsDataDiscriminator>(ref readerCopy, options);

            global::Mistral.TranscriptionStreamTextDelta? transcriptionTextDelta = default;
            if (discriminator?.Type == global::Mistral.TranscriptionStreamEventsDataDiscriminatorType.TranscriptionTextDelta)
            {
                transcriptionTextDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.TranscriptionStreamTextDelta>(ref reader, options);
            }
            global::Mistral.TranscriptionStreamLanguage? transcriptionLanguage = default;
            if (discriminator?.Type == global::Mistral.TranscriptionStreamEventsDataDiscriminatorType.TranscriptionLanguage)
            {
                transcriptionLanguage = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.TranscriptionStreamLanguage>(ref reader, options);
            }
            global::Mistral.TranscriptionStreamSegmentDelta? transcriptionSegment = default;
            if (discriminator?.Type == global::Mistral.TranscriptionStreamEventsDataDiscriminatorType.TranscriptionSegment)
            {
                transcriptionSegment = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.TranscriptionStreamSegmentDelta>(ref reader, options);
            }
            global::Mistral.TranscriptionStreamDone? transcriptionDone = default;
            if (discriminator?.Type == global::Mistral.TranscriptionStreamEventsDataDiscriminatorType.TranscriptionDone)
            {
                transcriptionDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.TranscriptionStreamDone>(ref reader, options);
            }

            var __value = new global::Mistral.Data3(
                discriminator?.Type,
                transcriptionTextDelta,

                transcriptionLanguage,

                transcriptionSegment,

                transcriptionDone
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.Data3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsTranscriptionTextDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionTextDelta, typeof(global::Mistral.TranscriptionStreamTextDelta), options);
            }
            else if (value.IsTranscriptionLanguage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionLanguage, typeof(global::Mistral.TranscriptionStreamLanguage), options);
            }
            else if (value.IsTranscriptionSegment)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionSegment, typeof(global::Mistral.TranscriptionStreamSegmentDelta), options);
            }
            else if (value.IsTranscriptionDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionDone, typeof(global::Mistral.TranscriptionStreamDone), options);
            }
        }
    }
}