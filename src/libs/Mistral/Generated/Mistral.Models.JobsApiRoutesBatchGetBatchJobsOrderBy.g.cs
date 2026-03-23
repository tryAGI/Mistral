
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: -created
    /// </summary>
    public enum JobsApiRoutesBatchGetBatchJobsOrderBy
    {
        /// <summary>
        /// 
        /// </summary>
        Minuscreated,
        /// <summary>
        /// 
        /// </summary>
        Created,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobsApiRoutesBatchGetBatchJobsOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsApiRoutesBatchGetBatchJobsOrderBy value)
        {
            return value switch
            {
                JobsApiRoutesBatchGetBatchJobsOrderBy.Minuscreated => "-created",
                JobsApiRoutesBatchGetBatchJobsOrderBy.Created => "created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsApiRoutesBatchGetBatchJobsOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "-created" => JobsApiRoutesBatchGetBatchJobsOrderBy.Minuscreated,
                "created" => JobsApiRoutesBatchGetBatchJobsOrderBy.Created,
                _ => null,
            };
        }
    }
}