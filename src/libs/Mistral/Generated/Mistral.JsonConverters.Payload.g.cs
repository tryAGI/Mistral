#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class PayloadJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.Payload>
    {
        /// <inheritdoc />
        public override global::Mistral.Payload Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.JSONPayloadResponse? json = default;
            if (discriminator?.Type == global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType.Json)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JSONPayloadResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JSONPayloadResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JSONPayloadResponse)}");
                json = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.JSONPatchPayloadResponse? jsonPatch = default;
            if (discriminator?.Type == global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType.JsonPatch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JSONPatchPayloadResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JSONPatchPayloadResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JSONPatchPayloadResponse)}");
                jsonPatch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mistral.Payload(
                discriminator?.Type,
                json,

                jsonPatch
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.Payload value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JSONPayloadResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JSONPayloadResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.JSONPayloadResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Json!, typeInfo);
            }
            else if (value.IsJsonPatch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JSONPatchPayloadResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JSONPatchPayloadResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.JSONPatchPayloadResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonPatch!, typeInfo);
            }
        }
    }
}