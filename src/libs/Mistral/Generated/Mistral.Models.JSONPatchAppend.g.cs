
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JSONPatchAppend
    {
        /// <summary>
        /// A JSON Pointer (RFC 6901) identifying the target location within the document. Can be a string path (e.g., '/foo/bar'), '/', '', or an empty list [] for root-level operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The value to use for the operation. A string to append to the existing value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 'append' is an extension for efficient string concatenation in streaming scenarios.
        /// </summary>
        /// <default>"append"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        public string Op { get; set; } = "append";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONPatchAppend" /> class.
        /// </summary>
        /// <param name="path">
        /// A JSON Pointer (RFC 6901) identifying the target location within the document. Can be a string path (e.g., '/foo/bar'), '/', '', or an empty list [] for root-level operations.
        /// </param>
        /// <param name="value">
        /// The value to use for the operation. A string to append to the existing value
        /// </param>
        /// <param name="op">
        /// 'append' is an extension for efficient string concatenation in streaming scenarios.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JSONPatchAppend(
            string path,
            string value,
            string op = "append")
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Op = op;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONPatchAppend" /> class.
        /// </summary>
        public JSONPatchAppend()
        {
        }
    }
}