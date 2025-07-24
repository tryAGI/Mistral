
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelCapabilities
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification")]
        public bool? Classification { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_chat")]
        public bool? CompletionChat { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_fim")]
        public bool? CompletionFim { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuning")]
        public bool? FineTuning { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_calling")]
        public bool? FunctionCalling { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vision")]
        public bool? Vision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCapabilities" /> class.
        /// </summary>
        /// <param name="classification">
        /// Default Value: false
        /// </param>
        /// <param name="completionChat">
        /// Default Value: true
        /// </param>
        /// <param name="completionFim">
        /// Default Value: false
        /// </param>
        /// <param name="fineTuning">
        /// Default Value: false
        /// </param>
        /// <param name="functionCalling">
        /// Default Value: true
        /// </param>
        /// <param name="vision">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelCapabilities(
            bool? classification,
            bool? completionChat,
            bool? completionFim,
            bool? fineTuning,
            bool? functionCalling,
            bool? vision)
        {
            this.Classification = classification;
            this.CompletionChat = completionChat;
            this.CompletionFim = completionFim;
            this.FineTuning = fineTuning;
            this.FunctionCalling = functionCalling;
            this.Vision = vision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCapabilities" /> class.
        /// </summary>
        public ModelCapabilities()
        {
        }
    }
}