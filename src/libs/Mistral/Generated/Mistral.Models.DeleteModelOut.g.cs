
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteModelOut
    {
        /// <summary>
        /// The deletion status<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; } = true;

        /// <summary>
        /// The ID of the deleted model.<br/>
        /// Example: ft:open-mistral-7b:587a6b29:20240514:7e773925
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type that was deleted<br/>
        /// Default Value: model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; } = "model";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}