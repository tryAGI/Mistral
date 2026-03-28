
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentUpdateRequest
    {
        /// <summary>
        /// Instruction prompt the model will follow during the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// List of tools which are available to the model during the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Mistral.ToolsItem3>? Tools { get; set; }

        /// <summary>
        /// Completion arguments that will be used to generate assistant responses. Can be overridden at each message request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_args")]
        public global::Mistral.CompletionArgs? CompletionArgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails")]
        public global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>? Guardrails { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_chat")]
        public bool? DeploymentChat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Mistral.MetadataDict? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_message")]
        public string? VersionMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateRequest" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Instruction prompt the model will follow during the conversation.
        /// </param>
        /// <param name="tools">
        /// List of tools which are available to the model during the conversation.
        /// </param>
        /// <param name="completionArgs">
        /// Completion arguments that will be used to generate assistant responses. Can be overridden at each message request.
        /// </param>
        /// <param name="guardrails"></param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="handoffs"></param>
        /// <param name="deploymentChat"></param>
        /// <param name="metadata"></param>
        /// <param name="versionMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentUpdateRequest(
            string? instructions,
            global::System.Collections.Generic.IList<global::Mistral.ToolsItem3>? tools,
            global::Mistral.CompletionArgs? completionArgs,
            global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>? guardrails,
            string? model,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<string>? handoffs,
            bool? deploymentChat,
            global::Mistral.MetadataDict? metadata,
            string? versionMessage)
        {
            this.Instructions = instructions;
            this.Tools = tools;
            this.CompletionArgs = completionArgs;
            this.Guardrails = guardrails;
            this.Model = model;
            this.Name = name;
            this.Description = description;
            this.Handoffs = handoffs;
            this.DeploymentChat = deploymentChat;
            this.Metadata = metadata;
            this.VersionMessage = versionMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateRequest" /> class.
        /// </summary>
        public AgentUpdateRequest()
        {
        }
    }
}