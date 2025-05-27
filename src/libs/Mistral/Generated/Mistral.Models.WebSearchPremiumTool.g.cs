
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchPremiumTool
    {
        /// <summary>
        /// Default Value: web_search_premium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.WebSearchPremiumToolTypeJsonConverter))]
        public global::Mistral.WebSearchPremiumToolType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchPremiumTool" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: web_search_premium
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchPremiumTool(
            global::Mistral.WebSearchPremiumToolType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchPremiumTool" /> class.
        /// </summary>
        public WebSearchPremiumTool()
        {
        }
    }
}