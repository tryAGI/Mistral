#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class Output2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.Output2>
    {
        /// <inheritdoc />
        public override global::Mistral.Output2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.PostJudgeInSchemaOutputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.PostJudgeInSchemaOutputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.PostJudgeInSchemaOutputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.JudgeClassificationOutput? classification = default;
            if (discriminator?.Type == global::Mistral.PostJudgeInSchemaOutputDiscriminatorType.Classification)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JudgeClassificationOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JudgeClassificationOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JudgeClassificationOutput)}");
                classification = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.JudgeRegressionOutput? regression = default;
            if (discriminator?.Type == global::Mistral.PostJudgeInSchemaOutputDiscriminatorType.Regression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JudgeRegressionOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JudgeRegressionOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JudgeRegressionOutput)}");
                regression = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mistral.Output2(
                discriminator?.Type,
                classification,

                regression
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.Output2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsClassification)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JudgeClassificationOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JudgeClassificationOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.JudgeClassificationOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Classification, typeInfo);
            }
            else if (value.IsRegression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JudgeRegressionOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JudgeRegressionOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.JudgeRegressionOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Regression, typeInfo);
            }
        }
    }
}