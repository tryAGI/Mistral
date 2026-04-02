#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class RepositoriesVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.RepositoriesVariant1Item>
    {
        /// <inheritdoc />
        public override global::Mistral.RepositoriesVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JobInRepositoriesVariant1ItemDiscriminator>(ref readerCopy, options);

            global::Mistral.GithubRepositoryIn? github = default;
            if (discriminator?.Type == global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType.Github)
            {
                github = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.GithubRepositoryIn>(ref reader, options);
            }

            var __value = new global::Mistral.RepositoriesVariant1Item(
                discriminator?.Type,
                github
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.RepositoriesVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsGithub)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Github, typeof(global::Mistral.GithubRepositoryIn), options);
            }
        }
    }
}