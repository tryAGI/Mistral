#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class RetrieveModelV1ModelsModelIdGetResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.RetrieveModelV1ModelsModelIdGetResponse>
    {
        /// <inheritdoc />
        public override global::Mistral.RetrieveModelV1ModelsModelIdGetResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminator>(ref readerCopy, options);

            global::Mistral.BaseModelCard? @base = default;
            if (discriminator?.Type == global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType.Base)
            {
                @base = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.BaseModelCard>(ref reader, options);
            }
            global::Mistral.FTModelCard? fineTuned = default;
            if (discriminator?.Type == global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType.FineTuned)
            {
                fineTuned = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.FTModelCard>(ref reader, options);
            }

            var __value = new global::Mistral.RetrieveModelV1ModelsModelIdGetResponse(
                discriminator?.Type,
                @base,

                fineTuned
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.RetrieveModelV1ModelsModelIdGetResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBase)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base, typeof(global::Mistral.BaseModelCard), options);
            }
            else if (value.IsFineTuned)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FineTuned, typeof(global::Mistral.FTModelCard), options);
            }
        }
    }
}