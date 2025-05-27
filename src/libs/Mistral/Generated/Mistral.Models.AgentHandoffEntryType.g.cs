
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: agent.handoff
    /// </summary>
    public enum AgentHandoffEntryType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentHandoff,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentHandoffEntryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentHandoffEntryType value)
        {
            return value switch
            {
                AgentHandoffEntryType.AgentHandoff => "agent.handoff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentHandoffEntryType? ToEnum(string value)
        {
            return value switch
            {
                "agent.handoff" => AgentHandoffEntryType.AgentHandoff,
                _ => null,
            };
        }
    }
}