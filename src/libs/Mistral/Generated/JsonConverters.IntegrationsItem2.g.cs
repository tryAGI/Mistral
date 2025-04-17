#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class IntegrationsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.IntegrationsItem2>
    {
        /// <inheritdoc />
        public override global::Mistral.IntegrationsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ClassifierJobOutIntegrationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ClassifierJobOutIntegrationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ClassifierJobOutIntegrationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.WandbIntegrationOut? wandb = default;
            if (discriminator?.Type == global::Mistral.ClassifierJobOutIntegrationDiscriminatorType.Wandb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.WandbIntegrationOut), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.WandbIntegrationOut> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.WandbIntegrationOut)}");
                wandb = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.IntegrationsItem2(
                discriminator?.Type,
                wandb
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.IntegrationsItem2 value,
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