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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.BaseModelCard? baseCard = default;
            if (discriminator?.Type == global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType.Base)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.BaseModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.BaseModelCard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.BaseModelCard)}");
                baseCard = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.FTModelCard? fTCard = default;
            if (discriminator?.Type == global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType.FineTuned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.FTModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.FTModelCard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.FTModelCard)}");
                fTCard = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.RetrieveModelV1ModelsModelIdGetResponse(
                discriminator?.Type,
                baseCard,
                fTCard
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.RetrieveModelV1ModelsModelIdGetResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBaseCard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.BaseModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.BaseModelCard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.BaseModelCard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseCard, typeInfo);
            }
            else if (value.IsFTCard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.FTModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.FTModelCard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.FTModelCard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FTCard, typeInfo);
            }
        }
    }
}