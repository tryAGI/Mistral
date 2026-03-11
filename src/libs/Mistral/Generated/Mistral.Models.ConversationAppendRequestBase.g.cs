
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationAppendRequestBase
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ConversationAppendRequestBaseHandoffExecutionJsonConverter))]
        public global::Mistral.ConversationAppendRequestBaseHandoffExecution? HandoffExecution { get; set; }

        /// <summary>
        /// Completion arguments that will be used to generate assistant responses. Can be overridden at each message request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_args")]
        public global::Mistral.CompletionArgs? CompletionArgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_confirmations")]
        public global::System.Collections.Generic.IList<global::Mistral.ToolCallConfirmation>? ToolConfirmations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAppendRequestBase" /> class.
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
        /// <param name="toolConfirmations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationAppendRequestBase(
            global::Mistral.ConversationInputs? inputs,
            bool? stream,
            bool? store,
            global::Mistral.ConversationAppendRequestBaseHandoffExecution? handoffExecution,
            global::Mistral.CompletionArgs? completionArgs,
            global::System.Collections.Generic.IList<global::Mistral.ToolCallConfirmation>? toolConfirmations)
        {
            this.Inputs = inputs;
            this.Stream = stream;
            this.Store = store;
            this.HandoffExecution = handoffExecution;
            this.CompletionArgs = completionArgs;
            this.ToolConfirmations = toolConfirmations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAppendRequestBase" /> class.
        /// </summary>
        public ConversationAppendRequestBase()
        {
        }
    }
}