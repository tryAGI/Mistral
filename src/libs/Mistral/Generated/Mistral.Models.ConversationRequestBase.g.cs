
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationRequestBase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_args")]
        public object? CompletionArgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handoff_execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ConversationRequestBaseHandoffExecutionJsonConverter))]
        public global::Mistral.ConversationRequestBaseHandoffExecution? HandoffExecution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ConversationInputsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ConversationInputs Inputs { get; set; }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Mistral.ToolsItem4>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationRequestBase" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="completionArgs"></param>
        /// <param name="description"></param>
        /// <param name="handoffExecution"></param>
        /// <param name="inputs"></param>
        /// <param name="instructions"></param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="store"></param>
        /// <param name="stream"></param>
        /// <param name="tools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationRequestBase(
            global::Mistral.ConversationInputs inputs,
            string? agentId,
            object? completionArgs,
            string? description,
            global::Mistral.ConversationRequestBaseHandoffExecution? handoffExecution,
            string? instructions,
            string? model,
            string? name,
            bool? store,
            bool? stream,
            global::System.Collections.Generic.IList<global::Mistral.ToolsItem4>? tools)
        {
            this.Inputs = inputs;
            this.AgentId = agentId;
            this.CompletionArgs = completionArgs;
            this.Description = description;
            this.HandoffExecution = handoffExecution;
            this.Instructions = instructions;
            this.Model = model;
            this.Name = name;
            this.Store = store;
            this.Stream = stream;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationRequestBase" /> class.
        /// </summary>
        public ConversationRequestBase()
        {
        }
    }
}