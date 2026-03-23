
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        V1AudioTranscriptions,
        /// <summary>
        /// 
        /// </summary>
        V1ChatClassifications,
        /// <summary>
        /// 
        /// </summary>
        V1ChatCompletions,
        /// <summary>
        /// 
        /// </summary>
        V1ChatModerations,
        /// <summary>
        /// 
        /// </summary>
        V1Classifications,
        /// <summary>
        /// 
        /// </summary>
        V1Conversations,
        /// <summary>
        /// 
        /// </summary>
        V1Embeddings,
        /// <summary>
        /// 
        /// </summary>
        V1FimCompletions,
        /// <summary>
        /// 
        /// </summary>
        V1Moderations,
        /// <summary>
        /// 
        /// </summary>
        V1Ocr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiEndpoint value)
        {
            return value switch
            {
                ApiEndpoint.V1AudioTranscriptions => "/v1/audio/transcriptions",
                ApiEndpoint.V1ChatClassifications => "/v1/chat/classifications",
                ApiEndpoint.V1ChatCompletions => "/v1/chat/completions",
                ApiEndpoint.V1ChatModerations => "/v1/chat/moderations",
                ApiEndpoint.V1Classifications => "/v1/classifications",
                ApiEndpoint.V1Conversations => "/v1/conversations",
                ApiEndpoint.V1Embeddings => "/v1/embeddings",
                ApiEndpoint.V1FimCompletions => "/v1/fim/completions",
                ApiEndpoint.V1Moderations => "/v1/moderations",
                ApiEndpoint.V1Ocr => "/v1/ocr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "/v1/audio/transcriptions" => ApiEndpoint.V1AudioTranscriptions,
                "/v1/chat/classifications" => ApiEndpoint.V1ChatClassifications,
                "/v1/chat/completions" => ApiEndpoint.V1ChatCompletions,
                "/v1/chat/moderations" => ApiEndpoint.V1ChatModerations,
                "/v1/classifications" => ApiEndpoint.V1Classifications,
                "/v1/conversations" => ApiEndpoint.V1Conversations,
                "/v1/embeddings" => ApiEndpoint.V1Embeddings,
                "/v1/fim/completions" => ApiEndpoint.V1FimCompletions,
                "/v1/moderations" => ApiEndpoint.V1Moderations,
                "/v1/ocr" => ApiEndpoint.V1Ocr,
                _ => null,
            };
        }
    }
}