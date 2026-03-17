
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterConditionOp
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
    public static class FilterConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterConditionOp value)
        {
            return value switch
            {
                FilterConditionOp.Lt => "lt",
                FilterConditionOp.Lte => "lte",
                FilterConditionOp.Gt => "gt",
                FilterConditionOp.Gte => "gte",
                FilterConditionOp.Startswith => "startswith",
                FilterConditionOp.Istartswith => "istartswith",
                FilterConditionOp.Endswith => "endswith",
                FilterConditionOp.Iendswith => "iendswith",
                FilterConditionOp.Contains => "contains",
                FilterConditionOp.Icontains => "icontains",
                FilterConditionOp.Matches => "matches",
                FilterConditionOp.Notcontains => "notcontains",
                FilterConditionOp.Inotcontains => "inotcontains",
                FilterConditionOp.Eq => "eq",
                FilterConditionOp.Neq => "neq",
                FilterConditionOp.Isnull => "isnull",
                FilterConditionOp.Includes => "includes",
                FilterConditionOp.Excludes => "excludes",
                FilterConditionOp.LenEq => "len_eq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "lt" => FilterConditionOp.Lt,
                "lte" => FilterConditionOp.Lte,
                "gt" => FilterConditionOp.Gt,
                "gte" => FilterConditionOp.Gte,
                "startswith" => FilterConditionOp.Startswith,
                "istartswith" => FilterConditionOp.Istartswith,
                "endswith" => FilterConditionOp.Endswith,
                "iendswith" => FilterConditionOp.Iendswith,
                "contains" => FilterConditionOp.Contains,
                "icontains" => FilterConditionOp.Icontains,
                "matches" => FilterConditionOp.Matches,
                "notcontains" => FilterConditionOp.Notcontains,
                "inotcontains" => FilterConditionOp.Inotcontains,
                "eq" => FilterConditionOp.Eq,
                "neq" => FilterConditionOp.Neq,
                "isnull" => FilterConditionOp.Isnull,
                "includes" => FilterConditionOp.Includes,
                "excludes" => FilterConditionOp.Excludes,
                "len_eq" => FilterConditionOp.LenEq,
                _ => null,
            };
        }
    }
}