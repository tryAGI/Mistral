
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChatCompletionEventIdsInSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.FilterPayload SearchParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_fields")]
        public global::System.Collections.Generic.IList<string>? ExtraFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChatCompletionEventIdsInSchema" /> class.
        /// </summary>
        /// <param name="searchParams"></param>
        /// <param name="extraFields"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChatCompletionEventIdsInSchema(
            global::Mistral.FilterPayload searchParams,
            global::System.Collections.Generic.IList<string>? extraFields)
        {
            this.SearchParams = searchParams ?? throw new global::System.ArgumentNullException(nameof(searchParams));
            this.ExtraFields = extraFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChatCompletionEventIdsInSchema" /> class.
        /// </summary>
        public GetChatCompletionEventIdsInSchema()
        {
        }
    }
}