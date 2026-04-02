#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class IntegrationsVariant1Item5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.IntegrationsVariant1Item5>
    {
        /// <inheritdoc />
        public override global::Mistral.IntegrationsVariant1Item5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminator>(ref readerCopy, options);

            global::Mistral.WandbIntegrationOut? wandb = default;
            if (discriminator?.Type == global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType.Wandb)
            {
                wandb = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.WandbIntegrationOut>(ref reader, options);
            }

            var __value = new global::Mistral.IntegrationsVariant1Item5(
                discriminator?.Type,
                wandb
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.IntegrationsVariant1Item5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsWandb)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wandb, typeof(global::Mistral.WandbIntegrationOut), options);
            }
        }
    }
}