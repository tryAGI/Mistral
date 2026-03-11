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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JobInRepositoriesVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.GithubRepositoryIn? github = default;
            if (discriminator?.Type == global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType.Github)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.GithubRepositoryIn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.GithubRepositoryIn> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.GithubRepositoryIn)}");
                github = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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