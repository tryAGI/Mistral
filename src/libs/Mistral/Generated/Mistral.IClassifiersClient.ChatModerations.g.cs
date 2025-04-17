#nullable enable

namespace Mistral
{
    public partial interface IClassifiersClient
    {
        /// <summary>
        /// Chat Moderations
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ModerationResponse> ChatModerationsAsync(
            global::Mistral.ChatModerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Chat Moderations
        /// </summary>
        /// <param name="input">
        /// Chat to classify
        /// </param>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ModerationResponse> ChatModerationsAsync(
            global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>> input,
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}