
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TurbineToolMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public global::Mistral.TurbineToolLocale? Locale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        public global::Mistral.ToolType? ToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_execution")]
        public bool? PrivateExecution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurbineToolMeta" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="toolType"></param>
        /// <param name="timeout"></param>
        /// <param name="privateExecution"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurbineToolMeta(
            global::Mistral.TurbineToolLocale? locale,
            global::Mistral.ToolType? toolType,
            double? timeout,
            bool? privateExecution)
        {
            this.Locale = locale;
            this.ToolType = toolType;
            this.Timeout = timeout;
            this.PrivateExecution = privateExecution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurbineToolMeta" /> class.
        /// </summary>
        public TurbineToolMeta()
        {
        }
    }
}