
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobsOut
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Mistral.DataItem2>? Data { get; set; }

        /// <summary>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsOut" /> class.
        /// </summary>
        /// <param name="data">
        /// Default Value: []
        /// </param>
        /// <param name="object">
        /// Default Value: list
        /// </param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobsOut(
            int total,
            global::System.Collections.Generic.IList<global::Mistral.DataItem2>? data,
            string? @object)
        {
            this.Total = total;
            this.Data = data;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsOut" /> class.
        /// </summary>
        public JobsOut()
        {
        }
    }
}