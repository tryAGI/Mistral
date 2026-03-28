
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JudgeOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Analysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, double?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<string, double?> Answer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JudgeOutput" /> class.
        /// </summary>
        /// <param name="analysis"></param>
        /// <param name="answer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JudgeOutput(
            string analysis,
            global::Mistral.AnyOf<string, double?> answer)
        {
            this.Analysis = analysis ?? throw new global::System.ArgumentNullException(nameof(analysis));
            this.Answer = answer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JudgeOutput" /> class.
        /// </summary>
        public JudgeOutput()
        {
        }
    }
}