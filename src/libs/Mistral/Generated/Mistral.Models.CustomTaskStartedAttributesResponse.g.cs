
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Attributes for custom task started events.
    /// </summary>
    public sealed partial class CustomTaskStartedAttributesResponse
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
        /// The initial state or payload for the custom task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public global::Mistral.JSONPayloadResponse? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTaskStartedAttributesResponse" /> class.
        /// </summary>
        /// <param name="customTaskId">
        /// Unique identifier for the custom task within the workflow.
        /// </param>
        /// <param name="customTaskType">
        /// The type/category of the custom task (e.g., 'llm_call', 'api_request').
        /// </param>
        /// <param name="payload">
        /// The initial state or payload for the custom task.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTaskStartedAttributesResponse(
            string customTaskId,
            string customTaskType,
            global::Mistral.JSONPayloadResponse? payload)
        {
            this.CustomTaskId = customTaskId ?? throw new global::System.ArgumentNullException(nameof(customTaskId));
            this.CustomTaskType = customTaskType ?? throw new global::System.ArgumentNullException(nameof(customTaskType));
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTaskStartedAttributesResponse" /> class.
        /// </summary>
        public CustomTaskStartedAttributesResponse()
        {
        }
    }
}