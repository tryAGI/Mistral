#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class MessagesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.MessagesItem>
    {
        /// <inheritdoc />
        public override global::Mistral.MessagesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ChatCompletionRequestMessageDiscriminator>(ref readerCopy, options);

            global::Mistral.SystemMessage? system = default;
            if (discriminator?.Role == global::Mistral.ChatCompletionRequestMessageDiscriminatorRole.System)
            {
                system = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.SystemMessage>(ref reader, options);
            }
            global::Mistral.UserMessage? user = default;
            if (discriminator?.Role == global::Mistral.ChatCompletionRequestMessageDiscriminatorRole.User)
            {
                user = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.UserMessage>(ref reader, options);
            }
            global::Mistral.AssistantMessage? assistant = default;
            if (discriminator?.Role == global::Mistral.ChatCompletionRequestMessageDiscriminatorRole.Assistant)
            {
                assistant = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.AssistantMessage>(ref reader, options);
            }
            global::Mistral.ToolMessage? tool = default;
            if (discriminator?.Role == global::Mistral.ChatCompletionRequestMessageDiscriminatorRole.Tool)
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ToolMessage>(ref reader, options);
            }

            var __value = new global::Mistral.MessagesItem(
                discriminator?.Role,
                system,

                user,

                assistant,

                tool
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.MessagesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSystem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeof(global::Mistral.SystemMessage), options);
            }
            else if (value.IsUser)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeof(global::Mistral.UserMessage), options);
            }
            else if (value.IsAssistant)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeof(global::Mistral.AssistantMessage), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::Mistral.ToolMessage), options);
            }
        }
    }
}