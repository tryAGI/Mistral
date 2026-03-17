
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationsSchemasApiToolTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public global::Mistral.IntegrationsSchemasTurbineToolLocale? Locale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jsonschema")]
        public object? Jsonschema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_config")]
        public global::Mistral.ExecutionConfig? ExecutionConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ResourceVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ResourceVisibility Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsSchemasApiToolTool" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="locale"></param>
        /// <param name="jsonschema"></param>
        /// <param name="executionConfig"></param>
        /// <param name="visibility"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="active"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsSchemasApiToolTool(
            string id,
            string name,
            string description,
            global::Mistral.ResourceVisibility visibility,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt,
            string? systemPrompt,
            global::Mistral.IntegrationsSchemasTurbineToolLocale? locale,
            object? jsonschema,
            global::Mistral.ExecutionConfig? executionConfig,
            bool? active)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Visibility = visibility;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.SystemPrompt = systemPrompt;
            this.Locale = locale;
            this.Jsonschema = jsonschema;
            this.ExecutionConfig = executionConfig;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsSchemasApiToolTool" /> class.
        /// </summary>
        public IntegrationsSchemasApiToolTool()
        {
        }
    }
}