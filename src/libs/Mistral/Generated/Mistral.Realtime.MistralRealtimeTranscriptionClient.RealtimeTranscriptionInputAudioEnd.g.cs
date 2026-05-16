
#nullable enable

namespace Mistral.Realtime
{
    public sealed partial class MistralRealtimeTranscriptionClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendRealtimeTranscriptionInputAudioEndAsync(
            global::Mistral.Realtime.RealtimeTranscriptionInputAudioEnd message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Mistral.Realtime.RealtimeTranscriptionInputAudioEnd), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}