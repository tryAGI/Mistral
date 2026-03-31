
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkerInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduler_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SchedulerUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tls")]
        public bool? Tls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkerInfo" /> class.
        /// </summary>
        /// <param name="schedulerUrl"></param>
        /// <param name="namespace"></param>
        /// <param name="tls">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkerInfo(
            string schedulerUrl,
            string @namespace,
            bool? tls)
        {
            this.SchedulerUrl = schedulerUrl ?? throw new global::System.ArgumentNullException(nameof(schedulerUrl));
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Tls = tls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkerInfo" /> class.
        /// </summary>
        public WorkerInfo()
        {
        }
    }
}