
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostDatasetImportFromPlaygroundInSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ConversationIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDatasetImportFromPlaygroundInSchema" /> class.
        /// </summary>
        /// <param name="conversationIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostDatasetImportFromPlaygroundInSchema(
            global::System.Collections.Generic.IList<string> conversationIds)
        {
            this.ConversationIds = conversationIds ?? throw new global::System.ArgumentNullException(nameof(conversationIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDatasetImportFromPlaygroundInSchema" /> class.
        /// </summary>
        public PostDatasetImportFromPlaygroundInSchema()
        {
        }
    }
}