
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationAppendRequestBase
    {
        /// <summary>
        /// White-listed arguments from the completion API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_args")]
        public global::Mistral.CompletionArgs? CompletionArgs { get; set; }

        /// <summary>
        /// Default Value: server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handoff_execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ConversationAppendRequestBaseHandoffExecutionJsonConverter))]
        public global::Mistral.ConversationAppendRequestBaseHandoffExecution? HandoffExecution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ConversationInputsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ConversationInputs Inputs { get; set; }

        /// <summary>
        /// Whether to store the results into our servers or not.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// Whether to stream back partial progress. Otherwise, the server will hold the request open until the timeout or until completion, with the response containing the full result as JSON.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAppendRequestBase" /> class.
        /// </summary>
        /// <param name="completionArgs">
        /// White-listed arguments from the completion API
        /// </param>
        /// <param name="handoffExecution">
        /// Default Value: server
        /// </param>
        /// <param name="inputs"></param>
        /// <param name="store">
        /// Whether to store the results into our servers or not.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="stream">
        /// Whether to stream back partial progress. Otherwise, the server will hold the request open until the timeout or until completion, with the response containing the full result as JSON.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationAppendRequestBase(
            global::Mistral.ConversationInputs inputs,
            global::Mistral.CompletionArgs? completionArgs,
            global::Mistral.ConversationAppendRequestBaseHandoffExecution? handoffExecution,
            bool? store,
            bool? stream)
        {
            this.Inputs = inputs;
            this.CompletionArgs = completionArgs;
            this.HandoffExecution = handoffExecution;
            this.Store = store;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAppendRequestBase" /> class.
        /// </summary>
        public ConversationAppendRequestBase()
        {
        }
    }
}