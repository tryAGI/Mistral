
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Server side events sent when streaming a conversation response.
    /// </summary>
    public enum SSETypes
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationResponseStarted,
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
        MessageOutputDelta,
        /// <summary>
        /// 
        /// </summary>
        ToolExecutionStarted,
        /// <summary>
        /// 
        /// </summary>
        ToolExecutionDelta,
        /// <summary>
        /// 
        /// </summary>
        ToolExecutionDone,
        /// <summary>
        /// 
        /// </summary>
        AgentHandoffStarted,
        /// <summary>
        /// 
        /// </summary>
        AgentHandoffDone,
        /// <summary>
        /// 
        /// </summary>
        FunctionCallDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SSETypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SSETypes value)
        {
            return value switch
            {
                SSETypes.ConversationResponseStarted => "conversation.response.started",
                SSETypes.ConversationResponseDone => "conversation.response.done",
                SSETypes.ConversationResponseError => "conversation.response.error",
                SSETypes.MessageOutputDelta => "message.output.delta",
                SSETypes.ToolExecutionStarted => "tool.execution.started",
                SSETypes.ToolExecutionDelta => "tool.execution.delta",
                SSETypes.ToolExecutionDone => "tool.execution.done",
                SSETypes.AgentHandoffStarted => "agent.handoff.started",
                SSETypes.AgentHandoffDone => "agent.handoff.done",
                SSETypes.FunctionCallDelta => "function.call.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SSETypes? ToEnum(string value)
        {
            return value switch
            {
                "conversation.response.started" => SSETypes.ConversationResponseStarted,
                "conversation.response.done" => SSETypes.ConversationResponseDone,
                "conversation.response.error" => SSETypes.ConversationResponseError,
                "message.output.delta" => SSETypes.MessageOutputDelta,
                "tool.execution.started" => SSETypes.ToolExecutionStarted,
                "tool.execution.delta" => SSETypes.ToolExecutionDelta,
                "tool.execution.done" => SSETypes.ToolExecutionDone,
                "agent.handoff.started" => SSETypes.AgentHandoffStarted,
                "agent.handoff.done" => SSETypes.AgentHandoffDone,
                "function.call.delta" => SSETypes.FunctionCallDelta,
                _ => null,
            };
        }
    }
}