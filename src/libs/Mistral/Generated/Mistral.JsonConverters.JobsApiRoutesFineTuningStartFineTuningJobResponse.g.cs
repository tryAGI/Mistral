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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.CompletionDetailedJobOut? completion = default;
            if (discriminator?.JobType == global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType.Completion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.CompletionDetailedJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.CompletionDetailedJobOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.CompletionDetailedJobOut)}");
                completion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.ClassifierDetailedJobOut? classifier = default;
            if (discriminator?.JobType == global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType.Classifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ClassifierDetailedJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ClassifierDetailedJobOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ClassifierDetailedJobOut)}");
                classifier = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponse(
                discriminator?.JobType,
                completion,
                classifier
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.CompletionDetailedJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.CompletionDetailedJobOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.CompletionDetailedJobOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion, typeInfo);
            }
            else if (value.IsClassifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ClassifierDetailedJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ClassifierDetailedJobOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ClassifierDetailedJobOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Classifier, typeInfo);
            }
        }
    }
}