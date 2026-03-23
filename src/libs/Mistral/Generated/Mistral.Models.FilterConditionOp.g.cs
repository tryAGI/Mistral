
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
    public static class FilterConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterConditionOp value)
        {
            return value switch
            {
                FilterConditionOp.Contains => "contains",
                FilterConditionOp.Endswith => "endswith",
                FilterConditionOp.Eq => "eq",
                FilterConditionOp.Excludes => "excludes",
                FilterConditionOp.Gt => "gt",
                FilterConditionOp.Gte => "gte",
                FilterConditionOp.Icontains => "icontains",
                FilterConditionOp.Iendswith => "iendswith",
                FilterConditionOp.Includes => "includes",
                FilterConditionOp.Inotcontains => "inotcontains",
                FilterConditionOp.Isnull => "isnull",
                FilterConditionOp.Istartswith => "istartswith",
                FilterConditionOp.LenEq => "len_eq",
                FilterConditionOp.Lt => "lt",
                FilterConditionOp.Lte => "lte",
                FilterConditionOp.Matches => "matches",
                FilterConditionOp.Neq => "neq",
                FilterConditionOp.Notcontains => "notcontains",
                FilterConditionOp.Startswith => "startswith",
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
                "contains" => FilterConditionOp.Contains,
                "endswith" => FilterConditionOp.Endswith,
                "eq" => FilterConditionOp.Eq,
                "excludes" => FilterConditionOp.Excludes,
                "gt" => FilterConditionOp.Gt,
                "gte" => FilterConditionOp.Gte,
                "icontains" => FilterConditionOp.Icontains,
                "iendswith" => FilterConditionOp.Iendswith,
                "includes" => FilterConditionOp.Includes,
                "inotcontains" => FilterConditionOp.Inotcontains,
                "isnull" => FilterConditionOp.Isnull,
                "istartswith" => FilterConditionOp.Istartswith,
                "len_eq" => FilterConditionOp.LenEq,
                "lt" => FilterConditionOp.Lt,
                "lte" => FilterConditionOp.Lte,
                "matches" => FilterConditionOp.Matches,
                "neq" => FilterConditionOp.Neq,
                "notcontains" => FilterConditionOp.Notcontains,
                "startswith" => FilterConditionOp.Startswith,
                _ => null,
            };
        }
    }
}