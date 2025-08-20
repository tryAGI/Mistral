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
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TranscriptionStreamEventsDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TranscriptionStreamEventsDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.TranscriptionStreamEventsDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.TranscriptionStreamTextDelta? transcriptionTextDelta = default;
            if (discriminator?.Type == global::Mistral.TranscriptionStreamEventsDataDiscriminatorType.TranscriptionTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TranscriptionStreamTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TranscriptionStreamTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.TranscriptionStreamTextDelta)}");
                transcriptionTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.TranscriptionStreamLanguage? transcriptionLanguage = default;
            if (discriminator?.Type == global::Mistral.TranscriptionStreamEventsDataDiscriminatorType.TranscriptionLanguage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TranscriptionStreamLanguage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TranscriptionStreamLanguage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.TranscriptionStreamLanguage)}");
                transcriptionLanguage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.TranscriptionStreamSegmentDelta? transcriptionSegment = default;
            if (discriminator?.Type == global::Mistral.TranscriptionStreamEventsDataDiscriminatorType.TranscriptionSegment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TranscriptionStreamSegmentDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TranscriptionStreamSegmentDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.TranscriptionStreamSegmentDelta)}");
                transcriptionSegment = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.TranscriptionStreamDone? transcriptionDone = default;
            if (discriminator?.Type == global::Mistral.TranscriptionStreamEventsDataDiscriminatorType.TranscriptionDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TranscriptionStreamDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TranscriptionStreamDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.TranscriptionStreamDone)}");
                transcriptionDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.Data2(
                discriminator?.Type,
                transcriptionTextDelta,
                transcriptionLanguage,
                transcriptionSegment,
                transcriptionDone
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.Data2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTranscriptionTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TranscriptionStreamTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TranscriptionStreamTextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.TranscriptionStreamTextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionTextDelta, typeInfo);
            }
            else if (value.IsTranscriptionLanguage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TranscriptionStreamLanguage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TranscriptionStreamLanguage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.TranscriptionStreamLanguage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionLanguage, typeInfo);
            }
            else if (value.IsTranscriptionSegment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TranscriptionStreamSegmentDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TranscriptionStreamSegmentDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.TranscriptionStreamSegmentDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionSegment, typeInfo);
            }
            else if (value.IsTranscriptionDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.TranscriptionStreamDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.TranscriptionStreamDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.TranscriptionStreamDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptionDone, typeInfo);
            }
        }
    }
}