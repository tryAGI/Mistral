
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum TempoTraceScopeKind
    {
        /// <summary>
        /// 
        /// </summary>
        SpanKindClient,
        /// <summary>
        /// 
        /// </summary>
        SpanKindInternal,
        /// <summary>
        /// 
        /// </summary>
        SpanKindServer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TempoTraceScopeKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TempoTraceScopeKind value)
        {
            return value switch
            {
                TempoTraceScopeKind.SpanKindClient => "SPAN_KIND_CLIENT",
                TempoTraceScopeKind.SpanKindInternal => "SPAN_KIND_INTERNAL",
                TempoTraceScopeKind.SpanKindServer => "SPAN_KIND_SERVER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TempoTraceScopeKind? ToEnum(string value)
        {
            return value switch
            {
                "SPAN_KIND_CLIENT" => TempoTraceScopeKind.SpanKindClient,
                "SPAN_KIND_INTERNAL" => TempoTraceScopeKind.SpanKindInternal,
                "SPAN_KIND_SERVER" => TempoTraceScopeKind.SpanKindServer,
                _ => null,
            };
        }
    }
}