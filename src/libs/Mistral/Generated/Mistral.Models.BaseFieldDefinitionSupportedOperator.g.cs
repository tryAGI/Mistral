
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseFieldDefinitionSupportedOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Startswith,
        /// <summary>
        /// 
        /// </summary>
        Istartswith,
        /// <summary>
        /// 
        /// </summary>
        Endswith,
        /// <summary>
        /// 
        /// </summary>
        Iendswith,
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        Icontains,
        /// <summary>
        /// 
        /// </summary>
        Matches,
        /// <summary>
        /// 
        /// </summary>
        Notcontains,
        /// <summary>
        /// 
        /// </summary>
        Inotcontains,
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Neq,
        /// <summary>
        /// 
        /// </summary>
        Isnull,
        /// <summary>
        /// 
        /// </summary>
        Includes,
        /// <summary>
        /// 
        /// </summary>
        Excludes,
        /// <summary>
        /// 
        /// </summary>
        LenEq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseFieldDefinitionSupportedOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseFieldDefinitionSupportedOperator value)
        {
            return value switch
            {
                BaseFieldDefinitionSupportedOperator.Lt => "lt",
                BaseFieldDefinitionSupportedOperator.Lte => "lte",
                BaseFieldDefinitionSupportedOperator.Gt => "gt",
                BaseFieldDefinitionSupportedOperator.Gte => "gte",
                BaseFieldDefinitionSupportedOperator.Startswith => "startswith",
                BaseFieldDefinitionSupportedOperator.Istartswith => "istartswith",
                BaseFieldDefinitionSupportedOperator.Endswith => "endswith",
                BaseFieldDefinitionSupportedOperator.Iendswith => "iendswith",
                BaseFieldDefinitionSupportedOperator.Contains => "contains",
                BaseFieldDefinitionSupportedOperator.Icontains => "icontains",
                BaseFieldDefinitionSupportedOperator.Matches => "matches",
                BaseFieldDefinitionSupportedOperator.Notcontains => "notcontains",
                BaseFieldDefinitionSupportedOperator.Inotcontains => "inotcontains",
                BaseFieldDefinitionSupportedOperator.Eq => "eq",
                BaseFieldDefinitionSupportedOperator.Neq => "neq",
                BaseFieldDefinitionSupportedOperator.Isnull => "isnull",
                BaseFieldDefinitionSupportedOperator.Includes => "includes",
                BaseFieldDefinitionSupportedOperator.Excludes => "excludes",
                BaseFieldDefinitionSupportedOperator.LenEq => "len_eq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseFieldDefinitionSupportedOperator? ToEnum(string value)
        {
            return value switch
            {
                "lt" => BaseFieldDefinitionSupportedOperator.Lt,
                "lte" => BaseFieldDefinitionSupportedOperator.Lte,
                "gt" => BaseFieldDefinitionSupportedOperator.Gt,
                "gte" => BaseFieldDefinitionSupportedOperator.Gte,
                "startswith" => BaseFieldDefinitionSupportedOperator.Startswith,
                "istartswith" => BaseFieldDefinitionSupportedOperator.Istartswith,
                "endswith" => BaseFieldDefinitionSupportedOperator.Endswith,
                "iendswith" => BaseFieldDefinitionSupportedOperator.Iendswith,
                "contains" => BaseFieldDefinitionSupportedOperator.Contains,
                "icontains" => BaseFieldDefinitionSupportedOperator.Icontains,
                "matches" => BaseFieldDefinitionSupportedOperator.Matches,
                "notcontains" => BaseFieldDefinitionSupportedOperator.Notcontains,
                "inotcontains" => BaseFieldDefinitionSupportedOperator.Inotcontains,
                "eq" => BaseFieldDefinitionSupportedOperator.Eq,
                "neq" => BaseFieldDefinitionSupportedOperator.Neq,
                "isnull" => BaseFieldDefinitionSupportedOperator.Isnull,
                "includes" => BaseFieldDefinitionSupportedOperator.Includes,
                "excludes" => BaseFieldDefinitionSupportedOperator.Excludes,
                "len_eq" => BaseFieldDefinitionSupportedOperator.LenEq,
                _ => null,
            };
        }
    }
}