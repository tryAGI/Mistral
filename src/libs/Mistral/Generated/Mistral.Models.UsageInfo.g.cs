
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageInfo
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        /// <default>0</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_audio_seconds")]
        public int? PromptAudioSeconds { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        /// <default>0</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; } = 0;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        /// <default>0</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; } = 0;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageInfo" /> class.
        /// </summary>
        /// <param name="completionTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="promptAudioSeconds"></param>
        /// <param name="promptTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalTokens">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageInfo(
            int completionTokens,
            int promptTokens,
            int totalTokens,
            int? promptAudioSeconds)
        {
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
            this.PromptAudioSeconds = promptAudioSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageInfo" /> class.
        /// </summary>
        public UsageInfo()
        {
        }
    }
}