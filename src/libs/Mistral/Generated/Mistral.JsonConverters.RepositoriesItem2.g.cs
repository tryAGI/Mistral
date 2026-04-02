#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class RepositoriesItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.RepositoriesItem2>
    {
        /// <inheritdoc />
        public override global::Mistral.RepositoriesItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.CompletionDetailedJobOutRepositorieDiscriminator>(ref readerCopy, options);

            global::Mistral.GithubRepositoryOut? github = default;
            if (discriminator?.Type == global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType.Github)
            {
                github = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.GithubRepositoryOut>(ref reader, options);
            }

            var __value = new global::Mistral.RepositoriesItem2(
                discriminator?.Type,
                github
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.RepositoriesItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsGithub)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Github, typeof(global::Mistral.GithubRepositoryOut), options);
            }
        }
    }
}