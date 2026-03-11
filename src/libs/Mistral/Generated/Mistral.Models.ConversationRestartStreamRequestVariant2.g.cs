
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationRestartStreamRequestVariant2
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationRestartStreamRequestVariant2" /> class.
        /// </summary>
        /// <param name="stream">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationRestartStreamRequestVariant2(
            bool? stream)
        {
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationRestartStreamRequestVariant2" /> class.
        /// </summary>
        public ConversationRestartStreamRequestVariant2()
        {
        }
    }
}