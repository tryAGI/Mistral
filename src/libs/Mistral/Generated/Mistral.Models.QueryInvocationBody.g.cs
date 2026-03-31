
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryInvocationBody
    {
        /// <summary>
        /// The name of the query to request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Input data for the query, matching its schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.NetworkEncodedInput, object, object>))]
        public global::Mistral.AnyOf<global::Mistral.NetworkEncodedInput, object, object>? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryInvocationBody" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the query to request
        /// </param>
        /// <param name="input">
        /// Input data for the query, matching its schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryInvocationBody(
            string name,
            global::Mistral.AnyOf<global::Mistral.NetworkEncodedInput, object, object>? input)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryInvocationBody" /> class.
        /// </summary>
        public QueryInvocationBody()
        {
        }
    }
}