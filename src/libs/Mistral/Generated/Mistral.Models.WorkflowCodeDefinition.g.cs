
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowCodeDefinition
    {
        /// <summary>
        /// Input schema of the workflow's run method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InputSchema { get; set; }

        /// <summary>
        /// Output schema of the workflow's run method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Signal handlers defined by the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signals")]
        public global::System.Collections.Generic.IList<global::Mistral.SignalDefinition>? Signals { get; set; }

        /// <summary>
        /// Query handlers defined by the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        public global::System.Collections.Generic.IList<global::Mistral.QueryDefinition>? Queries { get; set; }

        /// <summary>
        /// Update handlers defined by the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updates")]
        public global::System.Collections.Generic.IList<global::Mistral.UpdateDefinition>? Updates { get; set; }

        /// <summary>
        /// Whether the workflow enforces deterministic execution<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_determinism")]
        public bool? EnforceDeterminism { get; set; }

        /// <summary>
        /// Maximum total execution time including retries and continue-as-new
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_timeout")]
        public double? ExecutionTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCodeDefinition" /> class.
        /// </summary>
        /// <param name="inputSchema">
        /// Input schema of the workflow's run method
        /// </param>
        /// <param name="outputSchema">
        /// Output schema of the workflow's run method
        /// </param>
        /// <param name="signals">
        /// Signal handlers defined by the workflow
        /// </param>
        /// <param name="queries">
        /// Query handlers defined by the workflow
        /// </param>
        /// <param name="updates">
        /// Update handlers defined by the workflow
        /// </param>
        /// <param name="enforceDeterminism">
        /// Whether the workflow enforces deterministic execution<br/>
        /// Default Value: false
        /// </param>
        /// <param name="executionTimeout">
        /// Maximum total execution time including retries and continue-as-new
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowCodeDefinition(
            object inputSchema,
            object? outputSchema,
            global::System.Collections.Generic.IList<global::Mistral.SignalDefinition>? signals,
            global::System.Collections.Generic.IList<global::Mistral.QueryDefinition>? queries,
            global::System.Collections.Generic.IList<global::Mistral.UpdateDefinition>? updates,
            bool? enforceDeterminism,
            double? executionTimeout)
        {
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.OutputSchema = outputSchema;
            this.Signals = signals;
            this.Queries = queries;
            this.Updates = updates;
            this.EnforceDeterminism = enforceDeterminism;
            this.ExecutionTimeout = executionTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowCodeDefinition" /> class.
        /// </summary>
        public WorkflowCodeDefinition()
        {
        }
    }
}