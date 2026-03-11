
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentUpdateIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentUpdateIn" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentUpdateIn(
            string? name,
            object? attributes)
        {
            this.Name = name;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentUpdateIn" /> class.
        /// </summary>
        public DocumentUpdateIn()
        {
        }
    }
}