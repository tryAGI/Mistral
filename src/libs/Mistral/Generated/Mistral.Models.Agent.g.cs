
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Agent
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
        public global::System.Collections.Generic.IList<global::Mistral.ToolsItem>? Tools { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

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
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Default Value: agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<int> Versions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_chat")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool DeploymentChat { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Source { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="Agent" /> class.
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
        /// <param name="metadata"></param>
        /// <param name="object">
        /// Default Value: agent
        /// </param>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="versions"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="deploymentChat"></param>
        /// <param name="source"></param>
        /// <param name="versionMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Agent(
            string model,
            string name,
            string id,
            int version,
            global::System.Collections.Generic.IList<int> versions,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            bool deploymentChat,
            string source,
            string? instructions,
            global::System.Collections.Generic.IList<global::Mistral.ToolsItem>? tools,
            global::Mistral.CompletionArgs? completionArgs,
            global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>? guardrails,
            string? description,
            global::System.Collections.Generic.IList<string>? handoffs,
            object? metadata,
            string? @object,
            string? versionMessage)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeploymentChat = deploymentChat;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Instructions = instructions;
            this.Tools = tools;
            this.CompletionArgs = completionArgs;
            this.Guardrails = guardrails;
            this.Description = description;
            this.Handoffs = handoffs;
            this.Metadata = metadata;
            this.Object = @object;
            this.VersionMessage = versionMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        public Agent()
        {
        }
    }
}