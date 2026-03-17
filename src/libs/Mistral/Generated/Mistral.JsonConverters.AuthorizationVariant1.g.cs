#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class AuthorizationVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.AuthorizationVariant1>
    {
        /// <inheritdoc />
        public override global::Mistral.AuthorizationVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.CustomConnectorAuthorizationVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.CustomConnectorAuthorizationVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.CustomConnectorAuthorizationVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.OAuth2TokenAuth? oauth2Token = default;
            if (discriminator?.Type == global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType.Oauth2Token)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OAuth2TokenAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OAuth2TokenAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OAuth2TokenAuth)}");
                oauth2Token = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.APIKeyAuth? apiKey = default;
            if (discriminator?.Type == global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType.ApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.APIKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.APIKeyAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.APIKeyAuth)}");
                apiKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mistral.AuthorizationVariant1(
                discriminator?.Type,
                oauth2Token,

                apiKey
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.AuthorizationVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOauth2Token)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OAuth2TokenAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OAuth2TokenAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OAuth2TokenAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2Token, typeInfo);
            }
            else if (value.IsApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.APIKeyAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.APIKeyAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.APIKeyAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey, typeInfo);
            }
        }
    }
}