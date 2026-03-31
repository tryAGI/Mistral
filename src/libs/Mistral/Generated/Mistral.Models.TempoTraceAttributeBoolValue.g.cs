
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TempoTraceAttributeBoolValue
    {
        /// <summary>
        /// The boolean value of the attribute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("boolValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BoolValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceAttributeBoolValue" /> class.
        /// </summary>
        /// <param name="boolValue">
        /// The boolean value of the attribute
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TempoTraceAttributeBoolValue(
            bool boolValue)
        {
            this.BoolValue = boolValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceAttributeBoolValue" /> class.
        /// </summary>
        public TempoTraceAttributeBoolValue()
        {
        }
    }
}