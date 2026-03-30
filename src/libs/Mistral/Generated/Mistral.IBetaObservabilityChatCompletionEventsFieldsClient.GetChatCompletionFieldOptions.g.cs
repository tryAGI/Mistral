#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityChatCompletionEventsFieldsClient
    {
        /// <summary>
        /// Get Chat Completion Field Options
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="operator">
        /// The operator to use for filtering options
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ChatCompletionFieldOptions> GetChatCompletionFieldOptionsAsync(
            string fieldName,
            global::Mistral.GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperator @operator,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}