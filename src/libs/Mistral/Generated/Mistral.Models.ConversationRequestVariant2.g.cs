
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationRequestVariant2
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationRequestVariant2" /> class.
        /// </summary>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationRequestVariant2(
            bool? stream)
        {
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationRequestVariant2" /> class.
        /// </summary>
        public ConversationRequestVariant2()
        {
        }
    }
}