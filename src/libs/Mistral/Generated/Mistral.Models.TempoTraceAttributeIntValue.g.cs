
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TempoTraceAttributeIntValue
    {
        /// <summary>
        /// The integer value of the attribute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceAttributeIntValue" /> class.
        /// </summary>
        /// <param name="intValue">
        /// The integer value of the attribute
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TempoTraceAttributeIntValue(
            string intValue)
        {
            this.IntValue = intValue ?? throw new global::System.ArgumentNullException(nameof(intValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceAttributeIntValue" /> class.
        /// </summary>
        public TempoTraceAttributeIntValue()
        {
        }
    }
}