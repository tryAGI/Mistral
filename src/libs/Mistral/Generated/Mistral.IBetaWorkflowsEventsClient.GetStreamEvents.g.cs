#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsEventsClient
    {
        /// <summary>
        /// Get Stream Events
        /// </summary>
        /// <param name="scope">
        /// Default Value: *
        /// </param>
        /// <param name="activityName">
        /// Default Value: *
        /// </param>
        /// <param name="activityId">
        /// Default Value: *
        /// </param>
        /// <param name="workflowName">
        /// Default Value: *
        /// </param>
        /// <param name="workflowExecId">
        /// Default Value: *
        /// </param>
        /// <param name="rootWorkflowExecId">
        /// Default Value: *
        /// </param>
        /// <param name="parentWorkflowExecId">
        /// Default Value: *
        /// </param>
        /// <param name="stream">
        /// Default Value: *
        /// </param>
        /// <param name="startSeq">
        /// Default Value: 0
        /// </param>
        /// <param name="metadataFilters"></param>
        /// <param name="workflowEventTypes"></param>
        /// <param name="lastEventId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetResponse> GetStreamEventsAsync(
            global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope? scope = default,
            string? activityName = default,
            string? activityId = default,
            string? workflowName = default,
            string? workflowExecId = default,
            string? rootWorkflowExecId = default,
            string? parentWorkflowExecId = default,
            string? stream = default,
            int? startSeq = default,
            object? metadataFilters = default,
            global::System.Collections.Generic.IList<global::Mistral.WorkflowEventType>? workflowEventTypes = default,
            string? lastEventId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}