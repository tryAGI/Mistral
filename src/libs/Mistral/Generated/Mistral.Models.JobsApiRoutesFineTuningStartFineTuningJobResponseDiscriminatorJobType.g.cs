
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType
    {
        /// <summary>
        /// 
        /// </summary>
        Classifier,
        /// <summary>
        /// 
        /// </summary>
        Completion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType value)
        {
            return value switch
            {
                JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType.Classifier => "classifier",
                JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType? ToEnum(string value)
        {
            return value switch
            {
                "classifier" => JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType.Classifier,
                "completion" => JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType.Completion,
                _ => null,
            };
        }
    }
}