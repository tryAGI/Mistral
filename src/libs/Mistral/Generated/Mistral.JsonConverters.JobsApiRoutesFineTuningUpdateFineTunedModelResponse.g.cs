#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class JobsApiRoutesFineTuningUpdateFineTunedModelResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponse>
    {
        /// <inheritdoc />
        public override global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminator>(ref readerCopy, options);

            global::Mistral.CompletionFTModelOut? completion = default;
            if (discriminator?.ModelType == global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType.Completion)
            {
                completion = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.CompletionFTModelOut>(ref reader, options);
            }
            global::Mistral.ClassifierFTModelOut? classifier = default;
            if (discriminator?.ModelType == global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType.Classifier)
            {
                classifier = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ClassifierFTModelOut>(ref reader, options);
            }

            var __value = new global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponse(
                discriminator?.ModelType,
                completion,

                classifier
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCompletion)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion, typeof(global::Mistral.CompletionFTModelOut), options);
            }
            else if (value.IsClassifier)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Classifier, typeof(global::Mistral.ClassifierFTModelOut), options);
            }
        }
    }
}