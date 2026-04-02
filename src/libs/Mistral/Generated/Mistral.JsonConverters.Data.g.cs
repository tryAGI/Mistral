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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ConversationEventsDataDiscriminator>(ref readerCopy, options);

            global::Mistral.ResponseStartedEvent? conversationResponseStarted = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.ConversationResponseStarted)
            {
                conversationResponseStarted = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ResponseStartedEvent>(ref reader, options);
            }
            global::Mistral.ResponseDoneEvent? conversationResponseDone = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.ConversationResponseDone)
            {
                conversationResponseDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ResponseDoneEvent>(ref reader, options);
            }
            global::Mistral.ResponseErrorEvent? conversationResponseError = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.ConversationResponseError)
            {
                conversationResponseError = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ResponseErrorEvent>(ref reader, options);
            }
            global::Mistral.ToolExecutionStartedEvent? toolExecutionStarted = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.ToolExecutionStarted)
            {
                toolExecutionStarted = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ToolExecutionStartedEvent>(ref reader, options);
            }
            global::Mistral.ToolExecutionDeltaEvent? toolExecutionDelta = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.ToolExecutionDelta)
            {
                toolExecutionDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ToolExecutionDeltaEvent>(ref reader, options);
            }
            global::Mistral.ToolExecutionDoneEvent? toolExecutionDone = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.ToolExecutionDone)
            {
                toolExecutionDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ToolExecutionDoneEvent>(ref reader, options);
            }
            global::Mistral.MessageOutputEvent? messageOutputDelta = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.MessageOutputDelta)
            {
                messageOutputDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.MessageOutputEvent>(ref reader, options);
            }
            global::Mistral.FunctionCallEvent? functionCallDelta = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.FunctionCallDelta)
            {
                functionCallDelta = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.FunctionCallEvent>(ref reader, options);
            }
            global::Mistral.AgentHandoffStartedEvent? agentHandoffStarted = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.AgentHandoffStarted)
            {
                agentHandoffStarted = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.AgentHandoffStartedEvent>(ref reader, options);
            }
            global::Mistral.AgentHandoffDoneEvent? agentHandoffDone = default;
            if (discriminator?.Type == global::Mistral.ConversationEventsDataDiscriminatorType.AgentHandoffDone)
            {
                agentHandoffDone = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.AgentHandoffDoneEvent>(ref reader, options);
            }

            var __value = new global::Mistral.Data(
                discriminator?.Type,
                conversationResponseStarted,

                conversationResponseDone,

                conversationResponseError,

                toolExecutionStarted,

                toolExecutionDelta,

                toolExecutionDone,

                messageOutputDelta,

                functionCallDelta,

                agentHandoffStarted,

                agentHandoffDone
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.Data value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsConversationResponseStarted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationResponseStarted, typeof(global::Mistral.ResponseStartedEvent), options);
            }
            else if (value.IsConversationResponseDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationResponseDone, typeof(global::Mistral.ResponseDoneEvent), options);
            }
            else if (value.IsConversationResponseError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationResponseError, typeof(global::Mistral.ResponseErrorEvent), options);
            }
            else if (value.IsToolExecutionStarted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolExecutionStarted, typeof(global::Mistral.ToolExecutionStartedEvent), options);
            }
            else if (value.IsToolExecutionDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolExecutionDelta, typeof(global::Mistral.ToolExecutionDeltaEvent), options);
            }
            else if (value.IsToolExecutionDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolExecutionDone, typeof(global::Mistral.ToolExecutionDoneEvent), options);
            }
            else if (value.IsMessageOutputDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageOutputDelta, typeof(global::Mistral.MessageOutputEvent), options);
            }
            else if (value.IsFunctionCallDelta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallDelta, typeof(global::Mistral.FunctionCallEvent), options);
            }
            else if (value.IsAgentHandoffStarted)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentHandoffStarted, typeof(global::Mistral.AgentHandoffStartedEvent), options);
            }
            else if (value.IsAgentHandoffDone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentHandoffDone, typeof(global::Mistral.AgentHandoffDoneEvent), options);
            }
        }
    }
}