
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: *
    /// </summary>
    public enum GetStreamEventsV1WorkflowsEventsStreamGetScope
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
        /// <summary>
        /// 
        /// </summary>
        Activity,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetStreamEventsV1WorkflowsEventsStreamGetScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStreamEventsV1WorkflowsEventsStreamGetScope value)
        {
            return value switch
            {
                GetStreamEventsV1WorkflowsEventsStreamGetScope.Multiply => "*",
                GetStreamEventsV1WorkflowsEventsStreamGetScope.Activity => "activity",
                GetStreamEventsV1WorkflowsEventsStreamGetScope.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStreamEventsV1WorkflowsEventsStreamGetScope? ToEnum(string value)
        {
            return value switch
            {
                "*" => GetStreamEventsV1WorkflowsEventsStreamGetScope.Multiply,
                "activity" => GetStreamEventsV1WorkflowsEventsStreamGetScope.Activity,
                "workflow" => GetStreamEventsV1WorkflowsEventsStreamGetScope.Workflow,
                _ => null,
            };
        }
    }
}