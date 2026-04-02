#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class OutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.Output>
    {
        /// <inheritdoc />
        public override global::Mistral.Output Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JudgePreviewOutputDiscriminator>(ref readerCopy, options);

            global::Mistral.JudgeClassificationOutput? classification = default;
            if (discriminator?.Type == global::Mistral.JudgePreviewOutputDiscriminatorType.Classification)
            {
                classification = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JudgeClassificationOutput>(ref reader, options);
            }
            global::Mistral.JudgeRegressionOutput? regression = default;
            if (discriminator?.Type == global::Mistral.JudgePreviewOutputDiscriminatorType.Regression)
            {
                regression = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JudgeRegressionOutput>(ref reader, options);
            }

            var __value = new global::Mistral.Output(
                discriminator?.Type,
                classification,

                regression
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.Output value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsClassification)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Classification, typeof(global::Mistral.JudgeClassificationOutput), options);
            }
            else if (value.IsRegression)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Regression, typeof(global::Mistral.JudgeRegressionOutput), options);
            }
        }
    }
}