
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JudgePreviews
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.PaginatedResultJudgePreview Judges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JudgePreviews" /> class.
        /// </summary>
        /// <param name="judges"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JudgePreviews(
            global::Mistral.PaginatedResultJudgePreview judges)
        {
            this.Judges = judges ?? throw new global::System.ArgumentNullException(nameof(judges));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JudgePreviews" /> class.
        /// </summary>
        public JudgePreviews()
        {
        }
    }
}