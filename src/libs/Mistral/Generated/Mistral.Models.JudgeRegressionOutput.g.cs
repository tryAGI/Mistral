
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JudgeRegressionOutput
    {
        /// <summary>
        /// Default Value: REGRESSION
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MinDescription { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MaxDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JudgeRegressionOutput" /> class.
        /// </summary>
        /// <param name="minDescription"></param>
        /// <param name="maxDescription"></param>
        /// <param name="type">
        /// Default Value: REGRESSION
        /// </param>
        /// <param name="min">
        /// Default Value: 0
        /// </param>
        /// <param name="max">
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JudgeRegressionOutput(
            string minDescription,
            string maxDescription,
            string? type,
            double? min,
            double? max)
        {
            this.Type = type;
            this.Min = min;
            this.MinDescription = minDescription ?? throw new global::System.ArgumentNullException(nameof(minDescription));
            this.Max = max;
            this.MaxDescription = maxDescription ?? throw new global::System.ArgumentNullException(nameof(maxDescription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JudgeRegressionOutput" /> class.
        /// </summary>
        public JudgeRegressionOutput()
        {
        }
    }
}