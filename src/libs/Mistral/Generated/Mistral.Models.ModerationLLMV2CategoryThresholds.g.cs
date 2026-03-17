
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationLLMV2CategoryThresholds
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual")]
        public double? Sexual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate_and_discrimination")]
        public double? HateAndDiscrimination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence_and_threats")]
        public double? ViolenceAndThreats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dangerous")]
        public double? Dangerous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criminal")]
        public double? Criminal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selfharm")]
        public double? Selfharm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health")]
        public double? Health { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("financial")]
        public double? Financial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("law")]
        public double? Law { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii")]
        public double? Pii { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jailbreaking")]
        public double? Jailbreaking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationLLMV2CategoryThresholds" /> class.
        /// </summary>
        /// <param name="sexual"></param>
        /// <param name="hateAndDiscrimination"></param>
        /// <param name="violenceAndThreats"></param>
        /// <param name="dangerous"></param>
        /// <param name="criminal"></param>
        /// <param name="selfharm"></param>
        /// <param name="health"></param>
        /// <param name="financial"></param>
        /// <param name="law"></param>
        /// <param name="pii"></param>
        /// <param name="jailbreaking"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationLLMV2CategoryThresholds(
            double? sexual,
            double? hateAndDiscrimination,
            double? violenceAndThreats,
            double? dangerous,
            double? criminal,
            double? selfharm,
            double? health,
            double? financial,
            double? law,
            double? pii,
            double? jailbreaking)
        {
            this.Sexual = sexual;
            this.HateAndDiscrimination = hateAndDiscrimination;
            this.ViolenceAndThreats = violenceAndThreats;
            this.Dangerous = dangerous;
            this.Criminal = criminal;
            this.Selfharm = selfharm;
            this.Health = health;
            this.Financial = financial;
            this.Law = law;
            this.Pii = pii;
            this.Jailbreaking = jailbreaking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationLLMV2CategoryThresholds" /> class.
        /// </summary>
        public ModerationLLMV2CategoryThresholds()
        {
        }
    }
}