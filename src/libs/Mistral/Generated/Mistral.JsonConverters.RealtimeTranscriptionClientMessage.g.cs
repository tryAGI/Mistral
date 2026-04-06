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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.RealtimeTranscriptionClientMessageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.RealtimeTranscriptionClientMessageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.RealtimeTranscriptionClientMessageDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.RealtimeTranscriptionSessionUpdateMessage? sessionUpdate = default;
            if (discriminator?.Type == global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType.SessionUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.RealtimeTranscriptionSessionUpdateMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.RealtimeTranscriptionSessionUpdateMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.RealtimeTranscriptionSessionUpdateMessage)}");
                sessionUpdate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.RealtimeTranscriptionInputAudioAppend? inputAudioAppend = default;
            if (discriminator?.Type == global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType.InputAudioAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.RealtimeTranscriptionInputAudioAppend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.RealtimeTranscriptionInputAudioAppend> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.RealtimeTranscriptionInputAudioAppend)}");
                inputAudioAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.RealtimeTranscriptionInputAudioFlush? inputAudioFlush = default;
            if (discriminator?.Type == global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType.InputAudioFlush)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.RealtimeTranscriptionInputAudioFlush), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.RealtimeTranscriptionInputAudioFlush> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.RealtimeTranscriptionInputAudioFlush)}");
                inputAudioFlush = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.RealtimeTranscriptionInputAudioEnd? inputAudioEnd = default;
            if (discriminator?.Type == global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType.InputAudioEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.RealtimeTranscriptionInputAudioEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.RealtimeTranscriptionInputAudioEnd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.RealtimeTranscriptionInputAudioEnd)}");
                inputAudioEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.RealtimeTranscriptionSessionUpdateMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.RealtimeTranscriptionSessionUpdateMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.RealtimeTranscriptionSessionUpdateMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdate!, typeInfo);
            }
            else if (value.IsInputAudioAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.RealtimeTranscriptionInputAudioAppend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.RealtimeTranscriptionInputAudioAppend?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.RealtimeTranscriptionInputAudioAppend).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioAppend!, typeInfo);
            }
            else if (value.IsInputAudioFlush)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.RealtimeTranscriptionInputAudioFlush), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.RealtimeTranscriptionInputAudioFlush?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.RealtimeTranscriptionInputAudioFlush).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioFlush!, typeInfo);
            }
            else if (value.IsInputAudioEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.RealtimeTranscriptionInputAudioEnd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.RealtimeTranscriptionInputAudioEnd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.RealtimeTranscriptionInputAudioEnd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioEnd!, typeInfo);
            }
        }
    }
}