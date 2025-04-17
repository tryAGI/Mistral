
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobTypeJsonConverter))]
        public global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType? JobType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="jobType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminator(
            global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType? jobType)
        {
            this.JobType = jobType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminator" /> class.
        /// </summary>
        public JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminator()
        {
        }
    }
}