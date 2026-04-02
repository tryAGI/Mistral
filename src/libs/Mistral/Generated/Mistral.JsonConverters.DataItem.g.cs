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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ModelListDataItemDiscriminator>(ref readerCopy, options);

            global::Mistral.BaseModelCard? @base = default;
            if (discriminator?.Type == global::Mistral.ModelListDataItemDiscriminatorType.Base)
            {
                @base = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.BaseModelCard>(ref reader, options);
            }
            global::Mistral.FTModelCard? fineTuned = default;
            if (discriminator?.Type == global::Mistral.ModelListDataItemDiscriminatorType.FineTuned)
            {
                fineTuned = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.FTModelCard>(ref reader, options);
            }

            var __value = new global::Mistral.DataItem(
                discriminator?.Type,
                @base,

                fineTuned
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.DataItem value,
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