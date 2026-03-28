
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelConversation
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
        public global::System.Collections.Generic.IList<global::Mistral.ToolsItem4>? Tools { get; set; }

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
        /// Name given to the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the what the conversation is about.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Custom metadata for the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Mistral.MetadataDict? Metadata { get; set; }

        /// <summary>
        /// Default Value: conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConversation" /> class.
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
        /// <param name="name">
        /// Name given to the conversation.
        /// </param>
        /// <param name="description">
        /// Description of the what the conversation is about.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata for the conversation.
        /// </param>
        /// <param name="object">
        /// Default Value: conversation
        /// </param>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelConversation(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string model,
            string? instructions,
            global::System.Collections.Generic.IList<global::Mistral.ToolsItem4>? tools,
            global::Mistral.CompletionArgs? completionArgs,
            global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>? guardrails,
            string? name,
            string? description,
            global::Mistral.MetadataDict? metadata,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Instructions = instructions;
            this.Tools = tools;
            this.CompletionArgs = completionArgs;
            this.Guardrails = guardrails;
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelConversation" /> class.
        /// </summary>
        public ModelConversation()
        {
        }
    }
}