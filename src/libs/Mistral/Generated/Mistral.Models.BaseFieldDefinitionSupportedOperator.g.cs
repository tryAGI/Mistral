
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
        Contains,
        /// <summary>
        /// 
        /// </summary>
        Endswith,
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Excludes,
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
        Icontains,
        /// <summary>
        /// 
        /// </summary>
        Iendswith,
        /// <summary>
        /// 
        /// </summary>
        Includes,
        /// <summary>
        /// 
        /// </summary>
        Inotcontains,
        /// <summary>
        /// 
        /// </summary>
        Isnull,
        /// <summary>
        /// 
        /// </summary>
        Istartswith,
        /// <summary>
        /// 
        /// </summary>
        LenEq,
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
        Matches,
        /// <summary>
        /// 
        /// </summary>
        Neq,
        /// <summary>
        /// 
        /// </summary>
        Notcontains,
        /// <summary>
        /// 
        /// </summary>
        Startswith,
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
                BaseFieldDefinitionSupportedOperator.Contains => "contains",
                BaseFieldDefinitionSupportedOperator.Endswith => "endswith",
                BaseFieldDefinitionSupportedOperator.Eq => "eq",
                BaseFieldDefinitionSupportedOperator.Excludes => "excludes",
                BaseFieldDefinitionSupportedOperator.Gt => "gt",
                BaseFieldDefinitionSupportedOperator.Gte => "gte",
                BaseFieldDefinitionSupportedOperator.Icontains => "icontains",
                BaseFieldDefinitionSupportedOperator.Iendswith => "iendswith",
                BaseFieldDefinitionSupportedOperator.Includes => "includes",
                BaseFieldDefinitionSupportedOperator.Inotcontains => "inotcontains",
                BaseFieldDefinitionSupportedOperator.Isnull => "isnull",
                BaseFieldDefinitionSupportedOperator.Istartswith => "istartswith",
                BaseFieldDefinitionSupportedOperator.LenEq => "len_eq",
                BaseFieldDefinitionSupportedOperator.Lt => "lt",
                BaseFieldDefinitionSupportedOperator.Lte => "lte",
                BaseFieldDefinitionSupportedOperator.Matches => "matches",
                BaseFieldDefinitionSupportedOperator.Neq => "neq",
                BaseFieldDefinitionSupportedOperator.Notcontains => "notcontains",
                BaseFieldDefinitionSupportedOperator.Startswith => "startswith",
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
                "contains" => BaseFieldDefinitionSupportedOperator.Contains,
                "endswith" => BaseFieldDefinitionSupportedOperator.Endswith,
                "eq" => BaseFieldDefinitionSupportedOperator.Eq,
                "excludes" => BaseFieldDefinitionSupportedOperator.Excludes,
                "gt" => BaseFieldDefinitionSupportedOperator.Gt,
                "gte" => BaseFieldDefinitionSupportedOperator.Gte,
                "icontains" => BaseFieldDefinitionSupportedOperator.Icontains,
                "iendswith" => BaseFieldDefinitionSupportedOperator.Iendswith,
                "includes" => BaseFieldDefinitionSupportedOperator.Includes,
                "inotcontains" => BaseFieldDefinitionSupportedOperator.Inotcontains,
                "isnull" => BaseFieldDefinitionSupportedOperator.Isnull,
                "istartswith" => BaseFieldDefinitionSupportedOperator.Istartswith,
                "len_eq" => BaseFieldDefinitionSupportedOperator.LenEq,
                "lt" => BaseFieldDefinitionSupportedOperator.Lt,
                "lte" => BaseFieldDefinitionSupportedOperator.Lte,
                "matches" => BaseFieldDefinitionSupportedOperator.Matches,
                "neq" => BaseFieldDefinitionSupportedOperator.Neq,
                "notcontains" => BaseFieldDefinitionSupportedOperator.Notcontains,
                "startswith" => BaseFieldDefinitionSupportedOperator.Startswith,
                _ => null,
            };
        }
    }
}