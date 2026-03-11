
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobInRepositoriesVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.JobInRepositoriesVariant1ItemDiscriminatorTypeJsonConverter))]
        public global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobInRepositoriesVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobInRepositoriesVariant1ItemDiscriminator(
            global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobInRepositoriesVariant1ItemDiscriminator" /> class.
        /// </summary>
        public JobInRepositoriesVariant1ItemDiscriminator()
        {
        }
    }
}