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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.CustomConnectorAuthorizationVariant1Discriminator>(ref readerCopy, options);

            global::Mistral.OAuth2TokenAuth? oauth2Token = default;
            if (discriminator?.Type == global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType.Oauth2Token)
            {
                oauth2Token = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.OAuth2TokenAuth>(ref reader, options);
            }
            global::Mistral.APIKeyAuth? apiKey = default;
            if (discriminator?.Type == global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType.ApiKey)
            {
                apiKey = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.APIKeyAuth>(ref reader, options);
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

            if (value.IsOauth2Token)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2Token, typeof(global::Mistral.OAuth2TokenAuth), options);
            }
            else if (value.IsApiKey)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey, typeof(global::Mistral.APIKeyAuth), options);
            }
        }
    }
}