
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutDatasetRecordPayloadInSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ConversationPayload Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDatasetRecordPayloadInSchema" /> class.
        /// </summary>
        /// <param name="payload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutDatasetRecordPayloadInSchema(
            global::Mistral.ConversationPayload payload)
        {
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDatasetRecordPayloadInSchema" /> class.
        /// </summary>
        public PutDatasetRecordPayloadInSchema()
        {
        }
    }
}