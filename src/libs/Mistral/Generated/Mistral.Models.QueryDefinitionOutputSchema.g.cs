
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Output JSON schema of the query's model
    /// </summary>
    public sealed partial class QueryDefinitionOutputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}