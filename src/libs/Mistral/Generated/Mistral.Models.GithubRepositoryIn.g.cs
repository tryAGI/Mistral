
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GithubRepositoryIn
    {
        /// <summary>
        /// Default Value: github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Owner { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GithubRepositoryIn" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: github
        /// </param>
        /// <param name="name"></param>
        /// <param name="owner"></param>
        /// <param name="ref"></param>
        /// <param name="weight">
        /// Default Value: 1.0
        /// </param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GithubRepositoryIn(
            string name,
            string owner,
            string token,
            string? type,
            string? @ref,
            double? weight)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Type = type;
            this.Ref = @ref;
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