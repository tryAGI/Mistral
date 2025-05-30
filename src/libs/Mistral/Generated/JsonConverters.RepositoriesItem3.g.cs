#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class RepositoriesItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.RepositoriesItem3>
    {
        /// <inheritdoc />
        public override global::Mistral.RepositoriesItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JobInRepositorieDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JobInRepositorieDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JobInRepositorieDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.GithubRepositoryIn? github = default;
            if (discriminator?.Type == global::Mistral.JobInRepositorieDiscriminatorType.Github)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.GithubRepositoryIn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.GithubRepositoryIn> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.GithubRepositoryIn)}");
                github = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.RepositoriesItem3(
                discriminator?.Type,
                github
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.RepositoriesItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGithub)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.GithubRepositoryIn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.GithubRepositoryIn?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.GithubRepositoryIn).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Github, typeInfo);
            }
        }
    }
}