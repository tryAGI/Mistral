
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostChatCompletionEventJudgingInSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.PostJudgeInSchema JudgeDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostChatCompletionEventJudgingInSchema" /> class.
        /// </summary>
        /// <param name="judgeDefinition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostChatCompletionEventJudgingInSchema(
            global::Mistral.PostJudgeInSchema judgeDefinition)
        {
            this.JudgeDefinition = judgeDefinition ?? throw new global::System.ArgumentNullException(nameof(judgeDefinition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostChatCompletionEventJudgingInSchema" /> class.
        /// </summary>
        public PostChatCompletionEventJudgingInSchema()
        {
        }
    }
}