
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prediction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Default Value: content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.PredictionTypeJsonConverter))]
        public global::Mistral.PredictionType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prediction" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type">
        /// Default Value: content
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Prediction(
            string? content,
            global::Mistral.PredictionType? type)
        {
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prediction" /> class.
        /// </summary>
        public Prediction()
        {
        }
    }
}