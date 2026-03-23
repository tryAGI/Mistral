
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
        ToolExecutionDelta,
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
    public static class SSETypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SSETypes value)
        {
            return value switch
            {
                SSETypes.AgentHandoffDone => "agent.handoff.done",
                SSETypes.AgentHandoffStarted => "agent.handoff.started",
                SSETypes.ConversationResponseDone => "conversation.response.done",
                SSETypes.ConversationResponseError => "conversation.response.error",
                SSETypes.ConversationResponseStarted => "conversation.response.started",
                SSETypes.FunctionCallDelta => "function.call.delta",
                SSETypes.MessageOutputDelta => "message.output.delta",
                SSETypes.ToolExecutionDelta => "tool.execution.delta",
                SSETypes.ToolExecutionDone => "tool.execution.done",
                SSETypes.ToolExecutionStarted => "tool.execution.started",
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
                "agent.handoff.done" => SSETypes.AgentHandoffDone,
                "agent.handoff.started" => SSETypes.AgentHandoffStarted,
                "conversation.response.done" => SSETypes.ConversationResponseDone,
                "conversation.response.error" => SSETypes.ConversationResponseError,
                "conversation.response.started" => SSETypes.ConversationResponseStarted,
                "function.call.delta" => SSETypes.FunctionCallDelta,
                "message.output.delta" => SSETypes.MessageOutputDelta,
                "tool.execution.delta" => SSETypes.ToolExecutionDelta,
                "tool.execution.done" => SSETypes.ToolExecutionDone,
                "tool.execution.started" => SSETypes.ToolExecutionStarted,
                _ => null,
            };
        }
    }
}