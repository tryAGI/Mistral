
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestSource
    {
        /// <summary>
        /// 
        /// </summary>
        AgentBuilderV1,
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        Playground,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestSource value)
        {
            return value switch
            {
                RequestSource.AgentBuilderV1 => "agent_builder_v1",
                RequestSource.Api => "api",
                RequestSource.Playground => "playground",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestSource? ToEnum(string value)
        {
            return value switch
            {
                "agent_builder_v1" => RequestSource.AgentBuilderV1,
                "api" => RequestSource.Api,
                "playground" => RequestSource.Playground,
                _ => null,
            };
        }
    }
}