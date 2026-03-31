
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionRequest
    {
        /// <summary>
        /// Allows you to specify a custom execution ID. If not provided, a random ID will be generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        public string? ExecutionId { get; set; }

        /// <summary>
        /// The input to the workflow. This should be a dictionary that matches the workflow's input schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Encoded input to the workflow, used when payload encoding is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoded_input")]
        public global::Mistral.NetworkEncodedInput? EncodedInput { get; set; }

        /// <summary>
        /// If true, wait for the workflow to complete and return the result directly.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_for_result")]
        public bool? WaitForResult { get; set; }

        /// <summary>
        /// Maximum time to wait for completion when wait_for_result is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_tracing_attributes")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomTracingAttributes { get; set; }

        /// <summary>
        /// Deprecated. Use deployment_name instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_queue")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? TaskQueue { get; set; }

        /// <summary>
        /// Name of the deployment to route this execution to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        public string? DeploymentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionRequest" /> class.
        /// </summary>
        /// <param name="executionId">
        /// Allows you to specify a custom execution ID. If not provided, a random ID will be generated.
        /// </param>
        /// <param name="input">
        /// The input to the workflow. This should be a dictionary that matches the workflow's input schema.
        /// </param>
        /// <param name="encodedInput">
        /// Encoded input to the workflow, used when payload encoding is enabled.
        /// </param>
        /// <param name="waitForResult">
        /// If true, wait for the workflow to complete and return the result directly.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="timeoutSeconds">
        /// Maximum time to wait for completion when wait_for_result is true.
        /// </param>
        /// <param name="customTracingAttributes"></param>
        /// <param name="deploymentName">
        /// Name of the deployment to route this execution to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionRequest(
            string? executionId,
            object? input,
            global::Mistral.NetworkEncodedInput? encodedInput,
            bool? waitForResult,
            double? timeoutSeconds,
            global::System.Collections.Generic.Dictionary<string, string>? customTracingAttributes,
            string? deploymentName)
        {
            this.ExecutionId = executionId;
            this.Input = input;
            this.EncodedInput = encodedInput;
            this.WaitForResult = waitForResult;
            this.TimeoutSeconds = timeoutSeconds;
            this.CustomTracingAttributes = customTracingAttributes;
            this.DeploymentName = deploymentName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionRequest" /> class.
        /// </summary>
        public WorkflowExecutionRequest()
        {
        }
    }
}