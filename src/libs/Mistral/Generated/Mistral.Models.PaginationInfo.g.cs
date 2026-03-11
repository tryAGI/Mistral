
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginationInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalItems { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalPages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int CurrentPage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int PageSize { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationInfo" /> class.
        /// </summary>
        /// <param name="totalItems"></param>
        /// <param name="totalPages"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="hasMore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginationInfo(
            int totalItems,
            int totalPages,
            int currentPage,
            int pageSize,
            bool hasMore)
        {
            this.TotalItems = totalItems;
            this.TotalPages = totalPages;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationInfo" /> class.
        /// </summary>
        public PaginationInfo()
        {
        }
    }
}