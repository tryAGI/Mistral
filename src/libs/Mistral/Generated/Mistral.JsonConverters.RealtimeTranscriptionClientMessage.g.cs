#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeTranscriptionClientMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.RealtimeTranscriptionClientMessage>
    {
        /// <inheritdoc />
        public override global::Mistral.RealtimeTranscriptionClientMessage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.RealtimeTranscriptionClientMessageDiscriminator>(ref readerCopy, options);

            global::Mistral.RealtimeTranscriptionSessionUpdateMessage? sessionUpdate = default;
            if (discriminator?.Type == global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType.SessionUpdate)
            {
                sessionUpdate = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.RealtimeTranscriptionSessionUpdateMessage>(ref reader, options);
            }
            global::Mistral.RealtimeTranscriptionInputAudioAppend? inputAudioAppend = default;
            if (discriminator?.Type == global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType.InputAudioAppend)
            {
                inputAudioAppend = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.RealtimeTranscriptionInputAudioAppend>(ref reader, options);
            }
            global::Mistral.RealtimeTranscriptionInputAudioFlush? inputAudioFlush = default;
            if (discriminator?.Type == global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType.InputAudioFlush)
            {
                inputAudioFlush = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.RealtimeTranscriptionInputAudioFlush>(ref reader, options);
            }
            global::Mistral.RealtimeTranscriptionInputAudioEnd? inputAudioEnd = default;
            if (discriminator?.Type == global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType.InputAudioEnd)
            {
                inputAudioEnd = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.RealtimeTranscriptionInputAudioEnd>(ref reader, options);
            }

            var __value = new global::Mistral.RealtimeTranscriptionClientMessage(
                discriminator?.Type,
                sessionUpdate,

                inputAudioAppend,

                inputAudioFlush,

                inputAudioEnd
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.RealtimeTranscriptionClientMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSessionUpdate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdate, typeof(global::Mistral.RealtimeTranscriptionSessionUpdateMessage), options);
            }
            else if (value.IsInputAudioAppend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioAppend, typeof(global::Mistral.RealtimeTranscriptionInputAudioAppend), options);
            }
            else if (value.IsInputAudioFlush)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioFlush, typeof(global::Mistral.RealtimeTranscriptionInputAudioFlush), options);
            }
            else if (value.IsInputAudioEnd)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioEnd, typeof(global::Mistral.RealtimeTranscriptionInputAudioEnd), options);
            }
        }
    }
}