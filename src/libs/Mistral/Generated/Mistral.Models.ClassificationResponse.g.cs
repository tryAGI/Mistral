
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassificationResponse
    {
        /// <summary>
        /// Example: mod-e5cc70bb28c444948073e77776eb30ef
        /// </summary>
        /// <example>mod-e5cc70bb28c444948073e77776eb30ef</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Mistral.ClassificationObject>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: mod-e5cc70bb28c444948073e77776eb30ef
        /// </param>
        /// <param name="model"></param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassificationResponse(
            string? id,
            string? model,
            global::System.Collections.Generic.IList<global::Mistral.ClassificationObject>? results)
        {
            this.Id = id;
            this.Model = model;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationResponse" /> class.
        /// </summary>
        public ClassificationResponse()
        {
        }
    }
}