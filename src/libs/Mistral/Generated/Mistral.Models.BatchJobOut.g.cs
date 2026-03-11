
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchJobOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Default Value: batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::System.Guid> InputFiles { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Endpoint { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_file")]
        public global::System.Guid? OutputFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_file")]
        public global::System.Guid? ErrorFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Mistral.BatchError> Errors { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<object>? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.BatchJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.BatchJobStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int CompletedRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int SucceededRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int FailedRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public int? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public int? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object">
        /// Default Value: batch
        /// </param>
        /// <param name="inputFiles"></param>
        /// <param name="metadata"></param>
        /// <param name="endpoint"></param>
        /// <param name="model"></param>
        /// <param name="agentId"></param>
        /// <param name="outputFile"></param>
        /// <param name="errorFile"></param>
        /// <param name="errors"></param>
        /// <param name="outputs"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="totalRequests"></param>
        /// <param name="completedRequests"></param>
        /// <param name="succeededRequests"></param>
        /// <param name="failedRequests"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchJobOut(
            string id,
            global::System.Collections.Generic.IList<global::System.Guid> inputFiles,
            string endpoint,
            global::System.Collections.Generic.IList<global::Mistral.BatchError> errors,
            global::Mistral.BatchJobStatus status,
            int createdAt,
            int totalRequests,
            int completedRequests,
            int succeededRequests,
            int failedRequests,
            string? @object,
            object? metadata,
            string? model,
            string? agentId,
            global::System.Guid? outputFile,
            global::System.Guid? errorFile,
            global::System.Collections.Generic.IList<object>? outputs,
            int? startedAt,
            int? completedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InputFiles = inputFiles ?? throw new global::System.ArgumentNullException(nameof(inputFiles));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.TotalRequests = totalRequests;
            this.CompletedRequests = completedRequests;
            this.SucceededRequests = succeededRequests;
            this.FailedRequests = failedRequests;
            this.Object = @object;
            this.Metadata = metadata;
            this.Model = model;
            this.AgentId = agentId;
            this.OutputFile = outputFile;
            this.ErrorFile = errorFile;
            this.Outputs = outputs;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobOut" /> class.
        /// </summary>
        public BatchJobOut()
        {
        }
    }
}