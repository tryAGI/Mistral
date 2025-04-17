#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class JobsApiRoutesFineTuningCancelFineTuningJobResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponse>
    {
        /// <inheritdoc />
        public override global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.CompletionDetailedJobOut? completion = default;
            if (discriminator?.JobType == global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType.Completion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.CompletionDetailedJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.CompletionDetailedJobOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.CompletionDetailedJobOut)}");
                completion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.ClassifierDetailedJobOut? classifier = default;
            if (discriminator?.JobType == global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType.Classifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ClassifierDetailedJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ClassifierDetailedJobOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ClassifierDetailedJobOut)}");
                classifier = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponse(
                discriminator?.JobType,
                completion,
                classifier
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponse value,
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