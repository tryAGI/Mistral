
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TempoTraceAttribute
    {
        /// <summary>
        /// The key of the attribute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The value of the attribute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TempoTraceAttributeStringValue, global::Mistral.TempoTraceAttributeIntValue, global::Mistral.TempoTraceAttributeBoolValue>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<global::Mistral.TempoTraceAttributeStringValue, global::Mistral.TempoTraceAttributeIntValue, global::Mistral.TempoTraceAttributeBoolValue> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceAttribute" /> class.
        /// </summary>
        /// <param name="key">
        /// The key of the attribute
        /// </param>
        /// <param name="value">
        /// The value of the attribute
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TempoTraceAttribute(
            string key,
            global::Mistral.AnyOf<global::Mistral.TempoTraceAttributeStringValue, global::Mistral.TempoTraceAttributeIntValue, global::Mistral.TempoTraceAttributeBoolValue> value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceAttribute" /> class.
        /// </summary>
        public TempoTraceAttribute()
        {
        }
    }
}