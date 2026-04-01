#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class IntegrationsVariant1Item3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.IntegrationsVariant1Item3>
    {
        /// <inheritdoc />
        public override global::Mistral.IntegrationsVariant1Item3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JobInIntegrationsVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.WandbIntegration? wandb = default;
            if (discriminator?.Type == global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType.Wandb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.WandbIntegration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.WandbIntegration> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.WandbIntegration)}");
                wandb = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mistral.IntegrationsVariant1Item3(
                discriminator?.Type,
                wandb
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.IntegrationsVariant1Item3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWandb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.WandbIntegration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.WandbIntegration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.WandbIntegration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wandb!, typeInfo);
            }
        }
    }
}