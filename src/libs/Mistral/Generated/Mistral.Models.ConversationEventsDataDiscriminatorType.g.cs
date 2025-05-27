
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationEventsDataDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentHandoffDone,
        /// <summary>
        /// 
        /// </summary>
        AgentHandoffStarted,
        /// <summary>
        /// 
        /// </summary>
        ConversationResponseDone,
        /// <summary>
        /// 
        /// </summary>
        ConversationResponseError,
        /// <summary>
        /// 
        /// </summary>
        ConversationResponseStarted,
        /// <summary>
        /// 
        /// </summary>
        FunctionCallDelta,
        /// <summary>
        /// 
        /// </summary>
        MessageOutputDelta,
        /// <summary>
        /// 
        /// </summary>
        ToolExecutionDone,
        /// <summary>
        /// 
        /// </summary>
        ToolExecutionStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationEventsDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationEventsDataDiscriminatorType value)
        {
            return value switch
            {
                ConversationEventsDataDiscriminatorType.AgentHandoffDone => "agent.handoff.done",
                ConversationEventsDataDiscriminatorType.AgentHandoffStarted => "agent.handoff.started",
                ConversationEventsDataDiscriminatorType.ConversationResponseDone => "conversation.response.done",
                ConversationEventsDataDiscriminatorType.ConversationResponseError => "conversation.response.error",
                ConversationEventsDataDiscriminatorType.ConversationResponseStarted => "conversation.response.started",
                ConversationEventsDataDiscriminatorType.FunctionCallDelta => "function.call.delta",
                ConversationEventsDataDiscriminatorType.MessageOutputDelta => "message.output.delta",
                ConversationEventsDataDiscriminatorType.ToolExecutionDone => "tool.execution.done",
                ConversationEventsDataDiscriminatorType.ToolExecutionStarted => "tool.execution.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationEventsDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent.handoff.done" => ConversationEventsDataDiscriminatorType.AgentHandoffDone,
                "agent.handoff.started" => ConversationEventsDataDiscriminatorType.AgentHandoffStarted,
                "conversation.response.done" => ConversationEventsDataDiscriminatorType.ConversationResponseDone,
                "conversation.response.error" => ConversationEventsDataDiscriminatorType.ConversationResponseError,
                "conversation.response.started" => ConversationEventsDataDiscriminatorType.ConversationResponseStarted,
                "function.call.delta" => ConversationEventsDataDiscriminatorType.FunctionCallDelta,
                "message.output.delta" => ConversationEventsDataDiscriminatorType.MessageOutputDelta,
                "tool.execution.done" => ConversationEventsDataDiscriminatorType.ToolExecutionDone,
                "tool.execution.started" => ConversationEventsDataDiscriminatorType.ToolExecutionStarted,
                _ => null,
            };
        }
    }
}