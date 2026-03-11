
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public object Body { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequest" /> class.
        /// </summary>
        /// <param name="customId"></param>
        /// <param name="body"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRequest(
            object body,
            string? customId)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.CustomId = customId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequest" /> class.
        /// </summary>
        public BatchRequest()
        {
        }
    }
}