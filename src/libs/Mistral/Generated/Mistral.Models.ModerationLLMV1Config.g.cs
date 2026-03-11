
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationLLMV1Config
    {
        /// <summary>
        /// Override model name. Should be omitted in general.<br/>
        /// Default Value: mistral-moderation-2411
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// Override default thresholds for specific categories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_category_thresholds")]
        public global::Mistral.ModerationLLMV1CategoryThresholds? CustomCategoryThresholds { get; set; }

        /// <summary>
        /// If true, only evaluate categories in custom_category_thresholds; others are ignored.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_other_categories")]
        public bool? IgnoreOtherCategories { get; set; }

        /// <summary>
        /// Action to take if any score is above the threshold for any category.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ModerationLLMV1ActionJsonConverter))]
        public global::Mistral.ModerationLLMV1Action? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationLLMV1Config" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Override model name. Should be omitted in general.<br/>
        /// Default Value: mistral-moderation-2411
        /// </param>
        /// <param name="customCategoryThresholds">
        /// Override default thresholds for specific categories.
        /// </param>
        /// <param name="ignoreOtherCategories">
        /// If true, only evaluate categories in custom_category_thresholds; others are ignored.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="action">
        /// Action to take if any score is above the threshold for any category.<br/>
        /// Default Value: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationLLMV1Config(
            string? modelName,
            global::Mistral.ModerationLLMV1CategoryThresholds? customCategoryThresholds,
            bool? ignoreOtherCategories,
            global::Mistral.ModerationLLMV1Action? action)
        {
            this.ModelName = modelName;
            this.CustomCategoryThresholds = customCategoryThresholds;
            this.IgnoreOtherCategories = ignoreOtherCategories;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationLLMV1Config" /> class.
        /// </summary>
        public ModerationLLMV1Config()
        {
        }
    }
}