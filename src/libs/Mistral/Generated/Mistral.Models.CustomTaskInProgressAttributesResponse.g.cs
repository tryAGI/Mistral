
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Attributes for custom task in-progress events with streaming updates.
    /// </summary>
    public sealed partial class CustomTaskInProgressAttributesResponse
    {
        /// <summary>
        /// Unique identifier for the custom task within the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomTaskId { get; set; }

        /// <summary>
        /// The type/category of the custom task (e.g., 'llm_call', 'api_request').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_task_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomTaskType { get; set; }

        /// <summary>
        /// The current state or incremental update for the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.PayloadJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.Payload Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTaskInProgressAttributesResponse" /> class.
        /// </summary>
        /// <param name="customTaskId">
        /// Unique identifier for the custom task within the workflow.
        /// </param>
        /// <param name="customTaskType">
        /// The type/category of the custom task (e.g., 'llm_call', 'api_request').
        /// </param>
        /// <param name="payload">
        /// The current state or incremental update for the task.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTaskInProgressAttributesResponse(
            string customTaskId,
            string customTaskType,
            global::Mistral.Payload payload)
        {
            this.CustomTaskId = customTaskId ?? throw new global::System.ArgumentNullException(nameof(customTaskId));
            this.CustomTaskType = customTaskType ?? throw new global::System.ArgumentNullException(nameof(customTaskType));
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTaskInProgressAttributesResponse" /> class.
        /// </summary>
        public CustomTaskInProgressAttributesResponse()
        {
        }
    }
}