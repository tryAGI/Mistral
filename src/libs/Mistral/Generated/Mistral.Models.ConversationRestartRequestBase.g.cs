
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// Request to restart a new conversation from a given entry in the conversation.
    /// </summary>
    public sealed partial class ConversationRestartRequestBase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ConversationInputsJsonConverter))]
        public global::Mistral.ConversationInputs? Inputs { get; set; }

        /// <summary>
        /// Whether to stream back partial progress. Otherwise, the server will hold the request open until the timeout or until completion, with the response containing the full result as JSON.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Whether to store the results into our servers or not.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Default Value: server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handoff_execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ConversationRestartRequestBaseHandoffExecutionJsonConverter))]
        public global::Mistral.ConversationRestartRequestBaseHandoffExecution? HandoffExecution { get; set; }

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
        /// Custom metadata for the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_entry_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string FromEntryId { get; set; } = default!;

        /// <summary>
        /// Specific version of the agent to use when restarting. If not provided, uses the current version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>))]
        public global::Mistral.AnyOf<string, int?, object>? AgentVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationRestartRequestBase" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="stream">
        /// Whether to stream back partial progress. Otherwise, the server will hold the request open until the timeout or until completion, with the response containing the full result as JSON.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="store">
        /// Whether to store the results into our servers or not.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="handoffExecution">
        /// Default Value: server
        /// </param>
        /// <param name="completionArgs">
        /// Completion arguments that will be used to generate assistant responses. Can be overridden at each message request.
        /// </param>
        /// <param name="guardrails"></param>
        /// <param name="metadata">
        /// Custom metadata for the conversation.
        /// </param>
        /// <param name="fromEntryId"></param>
        /// <param name="agentVersion">
        /// Specific version of the agent to use when restarting. If not provided, uses the current version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationRestartRequestBase(
            string fromEntryId,
            global::Mistral.ConversationInputs? inputs,
            bool? stream,
            bool? store,
            global::Mistral.ConversationRestartRequestBaseHandoffExecution? handoffExecution,
            global::Mistral.CompletionArgs? completionArgs,
            global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>? guardrails,
            object? metadata,
            global::Mistral.AnyOf<string, int?, object>? agentVersion)
        {
            this.FromEntryId = fromEntryId ?? throw new global::System.ArgumentNullException(nameof(fromEntryId));
            this.Inputs = inputs;
            this.Stream = stream;
            this.Store = store;
            this.HandoffExecution = handoffExecution;
            this.CompletionArgs = completionArgs;
            this.Guardrails = guardrails;
            this.Metadata = metadata;
            this.AgentVersion = agentVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationRestartRequestBase" /> class.
        /// </summary>
        public ConversationRestartRequestBase()
        {
        }
    }
}