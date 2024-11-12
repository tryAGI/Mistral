
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchJobsOut
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Mistral.BatchJobOut>? Data { get; set; }

        /// <summary>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.BatchJobsOutObjectJsonConverter))]
        public global::Mistral.BatchJobsOutObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobsOut" /> class.
        /// </summary>
        /// <param name="data">
        /// Default Value: []
        /// </param>
        /// <param name="object">
        /// Default Value: list
        /// </param>
        /// <param name="total"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BatchJobsOut(
            int total,
            global::System.Collections.Generic.IList<global::Mistral.BatchJobOut>? data,
            global::Mistral.BatchJobsOutObject? @object)
        {
            this.Total = total;
            this.Data = data;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobsOut" /> class.
        /// </summary>
        public BatchJobsOut()
        {
        }
    }
}