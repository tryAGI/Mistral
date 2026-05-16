#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeTranscriptionServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.Realtime.RealtimeTranscriptionServerEvent>
    {
        /// <inheritdoc />
        public override global::Mistral.Realtime.RealtimeTranscriptionServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.Realtime.TranscriptionStreamLanguage? transcriptionLanguage = default;
            if (discriminator?.Type == global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminatorType.TranscriptionLanguage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.TranscriptionStreamLanguage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.TranscriptionStreamLanguage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.Realtime.TranscriptionStreamLanguage)}");
                transcriptionLanguage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.Realtime.TranscriptionStreamSegmentDelta? transcriptionSegment = default;
            if (discriminator?.Type == global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminatorType.TranscriptionSegment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.TranscriptionStreamSegmentDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.TranscriptionStreamSegmentDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.Realtime.TranscriptionStreamSegmentDelta)}");
                transcriptionSegment = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.Realtime.TranscriptionStreamTextDelta? transcriptionTextDelta = default;
            if (discriminator?.Type == global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminatorType.TranscriptionTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.TranscriptionStreamTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.TranscriptionStreamTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.Realtime.TranscriptionStreamTextDelta)}");
                transcriptionTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.Realtime.TranscriptionStreamDone? transcriptionDone = default;
            if (discriminator?.Type == global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminatorType.TranscriptionDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.TranscriptionStreamDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.TranscriptionStreamDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.Realtime.TranscriptionStreamDone)}");
                transcriptionDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.Realtime.RealtimeTranscriptionSessionCreated? sessionCreated = default;
            if (discriminator?.Type == global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminatorType.SessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.RealtimeTranscriptionSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.RealtimeTranscriptionSessionCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.Realtime.RealtimeTranscriptionSessionCreated)}");
                sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated? sessionUpdated = default;
            if (discriminator?.Type == global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminatorType.SessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated)}");
                sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.Realtime.RealtimeTranscriptionError? error = default;
            if (discriminator?.Type == global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.RealtimeTranscriptionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.RealtimeTranscriptionError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.Realtime.RealtimeTranscriptionError)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mistral.Realtime.RealtimeTranscriptionServerEvent(
                discriminator?.Type,
                transcriptionLanguage,

                transcriptionSegment,

                transcriptionTextDelta,

                transcriptionDone,

                sessionCreated,

                sessionUpdated,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.Realtime.RealtimeTranscriptionServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTranscriptionLanguage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.TranscriptionStreamLanguage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.TranscriptionStreamLanguage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.Realtime.TranscriptionStreamLanguage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionLanguage!, typeInfo);
            }
            else if (value.IsTranscriptionSegment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.TranscriptionStreamSegmentDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.TranscriptionStreamSegmentDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.Realtime.TranscriptionStreamSegmentDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionSegment!, typeInfo);
            }
            else if (value.IsTranscriptionTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.TranscriptionStreamTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.TranscriptionStreamTextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.Realtime.TranscriptionStreamTextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionTextDelta!, typeInfo);
            }
            else if (value.IsTranscriptionDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.TranscriptionStreamDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.TranscriptionStreamDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.Realtime.TranscriptionStreamDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionDone!, typeInfo);
            }
            else if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.RealtimeTranscriptionSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.RealtimeTranscriptionSessionCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.Realtime.RealtimeTranscriptionSessionCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated!, typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.Realtime.RealtimeTranscriptionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.Realtime.RealtimeTranscriptionError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.Realtime.RealtimeTranscriptionError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}