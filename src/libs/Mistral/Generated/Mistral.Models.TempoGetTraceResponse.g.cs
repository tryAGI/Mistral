
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Trace response in OpenTelemetry format.<br/>
    /// This is the unified trace format used across all trace providers (Tempo, ClickHouse, etc.).<br/>
    /// Regardless of the underlying backend, all trace data is normalized to this Tempo-compatible<br/>
    /// OpenTelemetry format to ensure consistency in the API response structure.
    /// </summary>
    public sealed partial class TempoGetTraceResponse
    {
        /// <summary>
        /// The batches of the trace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batches")]
        public global::System.Collections.Generic.IList<global::Mistral.TempoTraceBatch>? Batches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoGetTraceResponse" /> class.
        /// </summary>
        /// <param name="batches">
        /// The batches of the trace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TempoGetTraceResponse(
            global::System.Collections.Generic.IList<global::Mistral.TempoTraceBatch>? batches)
        {
            this.Batches = batches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoGetTraceResponse" /> class.
        /// </summary>
        public TempoGetTraceResponse()
        {
        }
    }
}