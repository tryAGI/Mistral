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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminator>(ref readerCopy, options);

            global::Mistral.JSONPayloadResponse? json = default;
            if (discriminator?.Type == global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType.Json)
            {
                json = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JSONPayloadResponse>(ref reader, options);
            }
            global::Mistral.JSONPatchPayloadResponse? jsonPatch = default;
            if (discriminator?.Type == global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType.JsonPatch)
            {
                jsonPatch = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JSONPatchPayloadResponse>(ref reader, options);
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

            if (value.IsJson)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Json, typeof(global::Mistral.JSONPayloadResponse), options);
            }
            else if (value.IsJsonPatch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonPatch, typeof(global::Mistral.JSONPatchPayloadResponse), options);
            }
        }
    }
}