#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class InputVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.InputVariant1Item>
    {
        /// <inheritdoc />
        public override global::Mistral.InputVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.SystemMessage? system = default;
            if (discriminator?.Role == global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminatorRole.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.SystemMessage)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.UserMessage? user = default;
            if (discriminator?.Role == global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminatorRole.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.UserMessage)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.AssistantMessage? assistant = default;
            if (discriminator?.Role == global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminatorRole.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.AssistantMessage)}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.ToolMessage? tool = default;
            if (discriminator?.Role == global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminatorRole.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ToolMessage)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.InputVariant1Item(
                discriminator?.Role,
                system,
                user,
                assistant,
                tool
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.InputVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.SystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.SystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
            else if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.UserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.UserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeInfo);
            }
            else if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.AssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.AssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
        }
    }
}