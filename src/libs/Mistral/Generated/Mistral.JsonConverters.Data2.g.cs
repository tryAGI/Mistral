#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class Data2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.Data2>
    {
        /// <inheritdoc />
        public override global::Mistral.Data2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.SpeechStreamEventsDataDiscriminator>(ref readerCopy, options);

            global::Mistral.SpeechStreamAudioDelta? speechAudioDelta = default;
            if (discriminator?.Type == global::Mistral.SpeechStreamEventsDataDiscriminatorType.SpeechAudioDelta)
            {
                speechAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.SpeechStreamAudioDelta>(ref reader, options);
            }
            global::Mistral.SpeechStreamDone? speechAudioDone = default;
            if (discriminator?.Type == global::Mistral.SpeechStreamEventsDataDiscriminatorType.SpeechAudioDone)
            {
                speechAudioDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.SpeechStreamDone>(ref reader, options);
            }

            var __value = new global::Mistral.Data2(
                discriminator?.Type,
                speechAudioDelta,

                speechAudioDone
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.Data2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSpeechAudioDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechAudioDelta, typeof(global::Mistral.SpeechStreamAudioDelta), options);
            }
            else if (value.IsSpeechAudioDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechAudioDone, typeof(global::Mistral.SpeechStreamDone), options);
            }
        }
    }
}