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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.SpeechStreamEventsDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.SpeechStreamEventsDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.SpeechStreamEventsDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.SpeechStreamAudioDelta? speechAudioDelta = default;
            if (discriminator?.Type == global::Mistral.SpeechStreamEventsDataDiscriminatorType.SpeechAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.SpeechStreamAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.SpeechStreamAudioDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.SpeechStreamAudioDelta)}");
                speechAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.SpeechStreamDone? speechAudioDone = default;
            if (discriminator?.Type == global::Mistral.SpeechStreamEventsDataDiscriminatorType.SpeechAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.SpeechStreamDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.SpeechStreamDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.SpeechStreamDone)}");
                speechAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSpeechAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.SpeechStreamAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.SpeechStreamAudioDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.SpeechStreamAudioDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechAudioDelta, typeInfo);
            }
            else if (value.IsSpeechAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.SpeechStreamDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.SpeechStreamDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.SpeechStreamDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechAudioDone, typeInfo);
            }
        }
    }
}