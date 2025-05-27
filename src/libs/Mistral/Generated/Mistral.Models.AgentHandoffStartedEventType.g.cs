
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: agent.handoff.started
    /// </summary>
    public enum AgentHandoffStartedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentHandoffStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentHandoffStartedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentHandoffStartedEventType value)
        {
            return value switch
            {
                AgentHandoffStartedEventType.AgentHandoffStarted => "agent.handoff.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentHandoffStartedEventType? ToEnum(string value)
        {
            return value switch
            {
                "agent.handoff.started" => AgentHandoffStartedEventType.AgentHandoffStarted,
                _ => null,
            };
        }
    }
}