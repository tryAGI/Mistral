#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityChatCompletionEventsClient
    {
        /// <summary>
        /// Run Judge on an event based on the given options
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.JudgeOutput> RunJudgeOnAnEventBasedOnTheGivenOptionsAsync(
            global::System.Guid eventId,

            global::Mistral.PostChatCompletionEventJudgingInSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Judge on an event based on the given options
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="judgeDefinition"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.JudgeOutput> RunJudgeOnAnEventBasedOnTheGivenOptionsAsync(
            global::System.Guid eventId,
            global::Mistral.PostJudgeInSchema judgeDefinition,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}