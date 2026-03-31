
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Represents an error or exception that occurred during execution.
    /// </summary>
    public sealed partial class Failure
    {
        /// <summary>
        /// A human-readable description of the failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Failure" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable description of the failure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Failure(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Failure" /> class.
        /// </summary>
        public Failure()
        {
        }
    }
}