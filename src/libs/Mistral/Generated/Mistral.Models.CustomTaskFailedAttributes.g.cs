
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Attributes for custom task failed events.
    /// </summary>
    public sealed partial class CustomTaskFailedAttributes
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
        /// Details about the failure that caused the task to fail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.Failure Failure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTaskFailedAttributes" /> class.
        /// </summary>
        /// <param name="customTaskId">
        /// Unique identifier for the custom task within the workflow.
        /// </param>
        /// <param name="customTaskType">
        /// The type/category of the custom task (e.g., 'llm_call', 'api_request').
        /// </param>
        /// <param name="failure">
        /// Details about the failure that caused the task to fail.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTaskFailedAttributes(
            string customTaskId,
            string customTaskType,
            global::Mistral.Failure failure)
        {
            this.CustomTaskId = customTaskId ?? throw new global::System.ArgumentNullException(nameof(customTaskId));
            this.CustomTaskType = customTaskType ?? throw new global::System.ArgumentNullException(nameof(customTaskType));
            this.Failure = failure ?? throw new global::System.ArgumentNullException(nameof(failure));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTaskFailedAttributes" /> class.
        /// </summary>
        public CustomTaskFailedAttributes()
        {
        }
    }
}