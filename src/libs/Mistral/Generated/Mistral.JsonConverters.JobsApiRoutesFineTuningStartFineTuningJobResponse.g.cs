#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class JobsApiRoutesFineTuningStartFineTuningJobResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponse>
    {
        /// <inheritdoc />
        public override global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminator>(ref readerCopy, options);

            global::Mistral.CompletionDetailedJobOut? completion = default;
            if (discriminator?.JobType == global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType.Completion)
            {
                completion = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.CompletionDetailedJobOut>(ref reader, options);
            }
            global::Mistral.ClassifierDetailedJobOut? classifier = default;
            if (discriminator?.JobType == global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType.Classifier)
            {
                classifier = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ClassifierDetailedJobOut>(ref reader, options);
            }

            var __value = new global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponse(
                discriminator?.JobType,
                completion,

                classifier
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCompletion)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion, typeof(global::Mistral.CompletionDetailedJobOut), options);
            }
            else if (value.IsClassifier)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Classifier, typeof(global::Mistral.ClassifierDetailedJobOut), options);
            }
        }
    }
}