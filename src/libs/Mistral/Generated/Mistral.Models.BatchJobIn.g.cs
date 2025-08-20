
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchJobIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ApiEndpointJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ApiEndpoint Endpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> InputFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Default Value: 24
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_hours")]
        public int? TimeoutHours { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobIn" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="endpoint"></param>
        /// <param name="inputFiles"></param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="timeoutHours">
        /// Default Value: 24
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchJobIn(
            global::Mistral.ApiEndpoint endpoint,
            global::System.Collections.Generic.IList<global::System.Guid> inputFiles,
            string? agentId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? model,
            int? timeoutHours)
        {
            this.Endpoint = endpoint;
            this.InputFiles = inputFiles ?? throw new global::System.ArgumentNullException(nameof(inputFiles));
            this.AgentId = agentId;
            this.Metadata = metadata;
            this.Model = model;
            this.TimeoutHours = timeoutHours;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobIn" /> class.
        /// </summary>
        public BatchJobIn()
        {
        }
    }
}