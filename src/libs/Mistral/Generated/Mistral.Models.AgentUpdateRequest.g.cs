
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentUpdateRequest
    {
        /// <summary>
        /// White-listed arguments from the completion API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_args")]
        public global::Mistral.CompletionArgs? CompletionArgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handoffs")]
        public global::System.Collections.Generic.IList<string>? Handoffs { get; set; }

        /// <summary>
        /// Instruction prompt the model will follow during the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// List of tools which are available to the model during the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Mistral.ToolsItem3>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateRequest" /> class.
        /// </summary>
        /// <param name="completionArgs">
        /// White-listed arguments from the completion API
        /// </param>
        /// <param name="description"></param>
        /// <param name="handoffs"></param>
        /// <param name="instructions">
        /// Instruction prompt the model will follow during the conversation.
        /// </param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="tools">
        /// List of tools which are available to the model during the conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentUpdateRequest(
            global::Mistral.CompletionArgs? completionArgs,
            string? description,
            global::System.Collections.Generic.IList<string>? handoffs,
            string? instructions,
            string? model,
            string? name,
            global::System.Collections.Generic.IList<global::Mistral.ToolsItem3>? tools)
        {
            this.CompletionArgs = completionArgs;
            this.Description = description;
            this.Handoffs = handoffs;
            this.Instructions = instructions;
            this.Model = model;
            this.Name = name;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateRequest" /> class.
        /// </summary>
        public AgentUpdateRequest()
        {
        }
    }
}