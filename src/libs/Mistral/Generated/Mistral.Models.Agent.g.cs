
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Agent
    {
        /// <summary>
        /// White-listed arguments from the completion API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_args")]
        public global::Mistral.CompletionArgs? CompletionArgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Instruction prompt the model will follow during the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AgentObjectJsonConverter))]
        public global::Mistral.AgentObject? Object { get; set; }

        /// <summary>
        /// List of tools which are available to the model during the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Mistral.ToolsItem>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        /// <param name="completionArgs">
        /// White-listed arguments from the completion API
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="handoffs"></param>
        /// <param name="id"></param>
        /// <param name="instructions">
        /// Instruction prompt the model will follow during the conversation.
        /// </param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="object">
        /// Default Value: agent
        /// </param>
        /// <param name="tools">
        /// List of tools which are available to the model during the conversation.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Agent(
            global::System.DateTime createdAt,
            string id,
            string model,
            string name,
            global::System.DateTime updatedAt,
            int version,
            global::Mistral.CompletionArgs? completionArgs,
            string? description,
            global::System.Collections.Generic.IList<string>? handoffs,
            string? instructions,
            global::Mistral.AgentObject? @object,
            global::System.Collections.Generic.IList<global::Mistral.ToolsItem>? tools)
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UpdatedAt = updatedAt;
            this.Version = version;
            this.CompletionArgs = completionArgs;
            this.Description = description;
            this.Handoffs = handoffs;
            this.Instructions = instructions;
            this.Object = @object;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        public Agent()
        {
        }
    }
}