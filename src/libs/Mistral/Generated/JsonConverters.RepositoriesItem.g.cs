#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class RepositoriesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.RepositoriesItem>
    {
        /// <inheritdoc />
        public override global::Mistral.RepositoriesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.DetailedJobOutRepositorieDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.DetailedJobOutRepositorieDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.DetailedJobOutRepositorieDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.GithubRepositoryOut? githubRepositoryOut = default;
            if (discriminator?.Type == global::Mistral.DetailedJobOutRepositorieDiscriminatorType.Github)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.GithubRepositoryOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.GithubRepositoryOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.GithubRepositoryOut)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.RepositoriesItem(
                discriminator?.Type,
                githubRepositoryOut
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.RepositoriesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGithubRepositoryOut)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.GithubRepositoryOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.GithubRepositoryOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.GithubRepositoryOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GithubRepositoryOut, typeInfo);
            }
        }
    }
}