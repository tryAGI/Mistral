
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GithubRepositoryIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Default Value: github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.GithubRepositoryInTypeJsonConverter))]
        public global::Mistral.GithubRepositoryInType? Type { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubRepositoryIn" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="ref"></param>
        /// <param name="token"></param>
        /// <param name="type">
        /// Default Value: github
        /// </param>
        /// <param name="weight">
        /// Default Value: 1
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GithubRepositoryIn(
            string name,
            string owner,
            string token,
            string? @ref,
            global::Mistral.GithubRepositoryInType? type,
            double? weight)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Ref = @ref;
            this.Type = type;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubRepositoryIn" /> class.
        /// </summary>
        public GithubRepositoryIn()
        {
        }
    }
}