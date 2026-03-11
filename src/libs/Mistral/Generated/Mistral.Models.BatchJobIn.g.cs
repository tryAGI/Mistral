
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchJobIn
    {
        /// <summary>
        /// The list of input files to be used for batch inference, these files should be `jsonl` files, containing the input data corresponding to the bory request for the batch inference in a "body" field. An example of such file is the following: ```json {"custom_id": "0", "body": {"max_tokens": 100, "messages": [{"role": "user", "content": "What is the best French cheese?"}]}} {"custom_id": "1", "body": {"max_tokens": 100, "messages": [{"role": "user", "content": "What is the best French wine?"}]}} ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_files")]
        public global::System.Collections.Generic.IList<global::System.Guid>? InputFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public global::System.Collections.Generic.IList<global::Mistral.BatchRequest>? Requests { get; set; }

        /// <summary>
        /// The endpoint to be used for batch inference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ApiEndpointJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.ApiEndpoint Endpoint { get; set; } = default!;

        /// <summary>
        /// The model to be used for batch inference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// In case you want to use a specific agent from the **deprecated** agents api for batch inference, you can specify the agent ID here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The metadata of your choice to be associated with the batch inference job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The timeout in hours for the batch inference job.<br/>
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
        /// <param name="inputFiles">
        /// The list of input files to be used for batch inference, these files should be `jsonl` files, containing the input data corresponding to the bory request for the batch inference in a "body" field. An example of such file is the following: ```json {"custom_id": "0", "body": {"max_tokens": 100, "messages": [{"role": "user", "content": "What is the best French cheese?"}]}} {"custom_id": "1", "body": {"max_tokens": 100, "messages": [{"role": "user", "content": "What is the best French wine?"}]}} ```
        /// </param>
        /// <param name="requests"></param>
        /// <param name="endpoint">
        /// The endpoint to be used for batch inference.
        /// </param>
        /// <param name="model">
        /// The model to be used for batch inference.
        /// </param>
        /// <param name="agentId">
        /// In case you want to use a specific agent from the **deprecated** agents api for batch inference, you can specify the agent ID here.
        /// </param>
        /// <param name="metadata">
        /// The metadata of your choice to be associated with the batch inference job.
        /// </param>
        /// <param name="timeoutHours">
        /// The timeout in hours for the batch inference job.<br/>
        /// Default Value: 24
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchJobIn(
            global::Mistral.ApiEndpoint endpoint,
            global::System.Collections.Generic.IList<global::System.Guid>? inputFiles,
            global::System.Collections.Generic.IList<global::Mistral.BatchRequest>? requests,
            string? model,
            string? agentId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            int? timeoutHours)
        {
            this.Endpoint = endpoint;
            this.InputFiles = inputFiles;
            this.Requests = requests;
            this.Model = model;
            this.AgentId = agentId;
            this.Metadata = metadata;
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