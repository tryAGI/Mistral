#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class IntegrationsItem4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.IntegrationsItem4>
    {
        /// <inheritdoc />
        public override global::Mistral.IntegrationsItem4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.CompletionJobOutIntegrationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.CompletionJobOutIntegrationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.CompletionJobOutIntegrationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.WandbIntegrationOut? wandb = default;
            if (discriminator?.Type == global::Mistral.CompletionJobOutIntegrationDiscriminatorType.Wandb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.WandbIntegrationOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.WandbIntegrationOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.WandbIntegrationOut)}");
                wandb = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.IntegrationsItem4(
                discriminator?.Type,
                wandb
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.IntegrationsItem4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWandb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.WandbIntegrationOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.WandbIntegrationOut?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.WandbIntegrationOut).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wandb, typeInfo);
            }
        }
    }
}