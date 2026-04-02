#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class DataItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.DataItem2>
    {
        /// <inheritdoc />
        public override global::Mistral.DataItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JobsOutDataItemDiscriminator>(ref readerCopy, options);

            global::Mistral.CompletionJobOut? completion = default;
            if (discriminator?.JobType == global::Mistral.JobsOutDataItemDiscriminatorJobType.Completion)
            {
                completion = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.CompletionJobOut>(ref reader, options);
            }
            global::Mistral.ClassifierJobOut? classifier = default;
            if (discriminator?.JobType == global::Mistral.JobsOutDataItemDiscriminatorJobType.Classifier)
            {
                classifier = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ClassifierJobOut>(ref reader, options);
            }

            var __value = new global::Mistral.DataItem2(
                discriminator?.JobType,
                completion,

                classifier
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.DataItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCompletion)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completion, typeof(global::Mistral.CompletionJobOut), options);
            }
            else if (value.IsClassifier)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Classifier, typeof(global::Mistral.ClassifierJobOut), options);
            }
        }
    }
}