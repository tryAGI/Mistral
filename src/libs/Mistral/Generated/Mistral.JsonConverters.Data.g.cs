#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class DataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.Data>
    {
        /// <inheritdoc />
        public override global::Mistral.Data Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationEventsDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationEventsDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ConversationEventsDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.ResponseStartedEvent? conversationResponseStarted = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.ConversationResponseStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ResponseStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ResponseStartedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ResponseStartedEvent)}");
                conversationResponseStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.ResponseDoneEvent? conversationResponseDone = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.ConversationResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ResponseDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ResponseDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ResponseDoneEvent)}");
                conversationResponseDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.ResponseErrorEvent? conversationResponseError = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.ConversationResponseError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ResponseErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ResponseErrorEvent)}");
                conversationResponseError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.ToolExecutionStartedEvent? toolExecutionStarted = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.ToolExecutionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ToolExecutionStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ToolExecutionStartedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ToolExecutionStartedEvent)}");
                toolExecutionStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.ToolExecutionDoneEvent? toolExecutionDone = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.ToolExecutionDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ToolExecutionDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ToolExecutionDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ToolExecutionDoneEvent)}");
                toolExecutionDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.MessageOutputEvent? messageOutputDelta = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.MessageOutputDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.MessageOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.MessageOutputEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.MessageOutputEvent)}");
                messageOutputDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.FunctionCallEvent? functionCallDelta = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.FunctionCallDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.FunctionCallEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.FunctionCallEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.FunctionCallEvent)}");
                functionCallDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.AgentHandoffStartedEvent? agentHandoffStarted = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.AgentHandoffStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.AgentHandoffStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.AgentHandoffStartedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.AgentHandoffStartedEvent)}");
                agentHandoffStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.AgentHandoffDoneEvent? agentHandoffDone = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.AgentHandoffDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.AgentHandoffDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.AgentHandoffDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.AgentHandoffDoneEvent)}");
                agentHandoffDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.Data(
                discriminator?.Type,
                conversationResponseStarted,
                conversationResponseDone,
                conversationResponseError,
                toolExecutionStarted,
                toolExecutionDone,
                messageOutputDelta,
                functionCallDelta,
                agentHandoffStarted,
                agentHandoffDone
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.Data value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConversationResponseStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ResponseStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ResponseStartedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ResponseStartedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationResponseStarted, typeInfo);
            }
            else if (value.IsConversationResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ResponseDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ResponseDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ResponseDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationResponseDone, typeInfo);
            }
            else if (value.IsConversationResponseError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ResponseErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ResponseErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationResponseError, typeInfo);
            }
            else if (value.IsToolExecutionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ToolExecutionStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ToolExecutionStartedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ToolExecutionStartedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolExecutionStarted, typeInfo);
            }
            else if (value.IsToolExecutionDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ToolExecutionDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ToolExecutionDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ToolExecutionDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolExecutionDone, typeInfo);
            }
            else if (value.IsMessageOutputDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.MessageOutputEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.MessageOutputEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.MessageOutputEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageOutputDelta, typeInfo);
            }
            else if (value.IsFunctionCallDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.FunctionCallEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.FunctionCallEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.FunctionCallEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallDelta, typeInfo);
            }
            else if (value.IsAgentHandoffStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.AgentHandoffStartedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.AgentHandoffStartedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.AgentHandoffStartedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentHandoffStarted, typeInfo);
            }
            else if (value.IsAgentHandoffDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.AgentHandoffDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.AgentHandoffDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.AgentHandoffDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentHandoffDone, typeInfo);
            }
        }
    }
}