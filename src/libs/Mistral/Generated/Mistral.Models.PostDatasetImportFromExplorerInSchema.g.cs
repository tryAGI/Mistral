
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostDatasetImportFromExplorerInSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_event_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CompletionEventIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDatasetImportFromExplorerInSchema" /> class.
        /// </summary>
        /// <param name="completionEventIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostDatasetImportFromExplorerInSchema(
            global::System.Collections.Generic.IList<string> completionEventIds)
        {
            this.CompletionEventIds = completionEventIds ?? throw new global::System.ArgumentNullException(nameof(completionEventIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDatasetImportFromExplorerInSchema" /> class.
        /// </summary>
        public PostDatasetImportFromExplorerInSchema()
        {
        }
    }
}