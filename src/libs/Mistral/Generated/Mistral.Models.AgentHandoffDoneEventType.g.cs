
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: agent.handoff.done
    /// </summary>
    public enum AgentHandoffDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentHandoffDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentHandoffDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentHandoffDoneEventType value)
        {
            return value switch
            {
                AgentHandoffDoneEventType.AgentHandoffDone => "agent.handoff.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentHandoffDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent.handoff.done" => AgentHandoffDoneEventType.AgentHandoffDone,
                _ => null,
            };
        }
    }
}