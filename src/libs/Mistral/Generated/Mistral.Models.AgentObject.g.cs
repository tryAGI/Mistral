
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: agent
    /// </summary>
    public enum AgentObject
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentObject value)
        {
            return value switch
            {
                AgentObject.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentObject? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AgentObject.Agent,
                _ => null,
            };
        }
    }
}