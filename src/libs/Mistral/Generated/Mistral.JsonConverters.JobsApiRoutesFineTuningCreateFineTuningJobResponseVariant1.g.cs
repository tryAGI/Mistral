#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1>
    {
        /// <inheritdoc />
        public override global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.CompletionJobOut? completion = default;
            if (discriminator?.JobType == global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType.Completion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.CompletionJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.CompletionJobOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.CompletionJobOut)}");
                completion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.ClassifierJobOut? classifier = default;
            if (discriminator?.JobType == global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType.Classifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ClassifierJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ClassifierJobOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ClassifierJobOut)}");
                classifier = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1(
                discriminator?.JobType,
                completion,
                classifier
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompletion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.CompletionJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.CompletionJobOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.CompletionJobOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion, typeInfo);
            }
            else if (value.IsClassifier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ClassifierJobOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ClassifierJobOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ClassifierJobOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Classifier, typeInfo);
            }
        }
    }
}