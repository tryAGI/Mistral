
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectorsQueryFilters
    {
        /// <summary>
        /// Filter for active connectors for a given user, workspace and organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Fetch connection secrets.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fetch_connection_secrets")]
        public bool? FetchConnectionSecrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsQueryFilters" /> class.
        /// </summary>
        /// <param name="active">
        /// Filter for active connectors for a given user, workspace and organization.
        /// </param>
        /// <param name="fetchConnectionSecrets">
        /// Fetch connection secrets.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectorsQueryFilters(
            bool? active,
            bool? fetchConnectionSecrets)
        {
            this.Active = active;
            this.FetchConnectionSecrets = fetchConnectionSecrets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsQueryFilters" /> class.
        /// </summary>
        public ConnectorsQueryFilters()
        {
        }
    }
}