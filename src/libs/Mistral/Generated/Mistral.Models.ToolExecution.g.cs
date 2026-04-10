
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Execution-related properties for a tool.
    /// </summary>
    public sealed partial class ToolExecution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskSupport")]
        public global::Mistral.ToolExecutionTaskSupport2? TaskSupport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolExecution" /> class.
        /// </summary>
        /// <param name="taskSupport"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolExecution(
            global::Mistral.ToolExecutionTaskSupport2? taskSupport)
        {
            this.TaskSupport = taskSupport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolExecution" /> class.
        /// </summary>
        public ToolExecution()
        {
        }
    }
}