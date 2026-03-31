
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Jitter to apply each action.<br/>
    /// An action's scheduled time will be incremented by a random value between 0<br/>
    /// and this value if present (but not past the next schedule).
    /// </summary>
    public sealed partial class ScheduleDefinitionJitter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}