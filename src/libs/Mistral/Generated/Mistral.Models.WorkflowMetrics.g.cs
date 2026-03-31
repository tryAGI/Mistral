
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Complete metrics for a specific workflow.<br/>
    /// This type combines all metric categories.
    /// </summary>
    public sealed partial class WorkflowMetrics
    {
        /// <summary>
        /// Scalar metric with a single value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ScalarMetric ExecutionCount { get; set; }

        /// <summary>
        /// Scalar metric with a single value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ScalarMetric SuccessCount { get; set; }

        /// <summary>
        /// Scalar metric with a single value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ScalarMetric ErrorCount { get; set; }

        /// <summary>
        /// Scalar metric with a single value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_latency_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ScalarMetric AverageLatencyMs { get; set; }

        /// <summary>
        /// Time-series metric with timestamp-value pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_over_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.TimeSeriesMetric LatencyOverTime { get; set; }

        /// <summary>
        /// Scalar metric with a single value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ScalarMetric RetryRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowMetrics" /> class.
        /// </summary>
        /// <param name="executionCount">
        /// Scalar metric with a single value.
        /// </param>
        /// <param name="successCount">
        /// Scalar metric with a single value.
        /// </param>
        /// <param name="errorCount">
        /// Scalar metric with a single value.
        /// </param>
        /// <param name="averageLatencyMs">
        /// Scalar metric with a single value.
        /// </param>
        /// <param name="latencyOverTime">
        /// Time-series metric with timestamp-value pairs.
        /// </param>
        /// <param name="retryRate">
        /// Scalar metric with a single value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowMetrics(
            global::Mistral.ScalarMetric executionCount,
            global::Mistral.ScalarMetric successCount,
            global::Mistral.ScalarMetric errorCount,
            global::Mistral.ScalarMetric averageLatencyMs,
            global::Mistral.TimeSeriesMetric latencyOverTime,
            global::Mistral.ScalarMetric retryRate)
        {
            this.ExecutionCount = executionCount ?? throw new global::System.ArgumentNullException(nameof(executionCount));
            this.SuccessCount = successCount ?? throw new global::System.ArgumentNullException(nameof(successCount));
            this.ErrorCount = errorCount ?? throw new global::System.ArgumentNullException(nameof(errorCount));
            this.AverageLatencyMs = averageLatencyMs ?? throw new global::System.ArgumentNullException(nameof(averageLatencyMs));
            this.LatencyOverTime = latencyOverTime ?? throw new global::System.ArgumentNullException(nameof(latencyOverTime));
            this.RetryRate = retryRate ?? throw new global::System.ArgumentNullException(nameof(retryRate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowMetrics" /> class.
        /// </summary>
        public WorkflowMetrics()
        {
        }
    }
}