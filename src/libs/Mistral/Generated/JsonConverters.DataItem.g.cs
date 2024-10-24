#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class DataItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.DataItem>
    {
        /// <inheritdoc />
        public override global::Mistral.DataItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ModelListDataItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ModelListDataItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ModelListDataItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.BaseModelCard? baseModelCard = default;
            if (discriminator?.Type == global::Mistral.ModelListDataItemDiscriminatorType.Base)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.BaseModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.BaseModelCard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.BaseModelCard)}");
                baseModelCard = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.FTModelCard? fTModelCard = default;
            if (discriminator?.Type == global::Mistral.ModelListDataItemDiscriminatorType.FineTuned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.FTModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.FTModelCard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.FTModelCard)}");
                fTModelCard = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.DataItem(
                discriminator?.Type,
                baseModelCard,
                fTModelCard
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.DataItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBaseModelCard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.BaseModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.BaseModelCard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.BaseModelCard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseModelCard, typeInfo);
            }
            else if (value.IsFTModelCard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.FTModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.FTModelCard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.FTModelCard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FTModelCard, typeInfo);
            }
        }
    }
}