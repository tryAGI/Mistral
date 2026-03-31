
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowUpdateRequest
    {
        /// <summary>
        /// New display name value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// New description value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether to make the workflow available in the chat assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_chat_assistant")]
        public bool? AvailableInChatAssistant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUpdateRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// New display name value
        /// </param>
        /// <param name="description">
        /// New description value
        /// </param>
        /// <param name="availableInChatAssistant">
        /// Whether to make the workflow available in the chat assistant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowUpdateRequest(
            string? displayName,
            string? description,
            bool? availableInChatAssistant)
        {
            this.DisplayName = displayName;
            this.Description = description;
            this.AvailableInChatAssistant = availableInChatAssistant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUpdateRequest" /> class.
        /// </summary>
        public WorkflowUpdateRequest()
        {
        }
    }
}