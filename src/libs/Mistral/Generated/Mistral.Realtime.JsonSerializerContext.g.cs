
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Mistral.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Mistral.Realtime.JsonConverters.AudioEncodingJsonConverter),

            typeof(global::Mistral.Realtime.JsonConverters.AudioEncodingNullableJsonConverter),

            typeof(global::Mistral.Realtime.JsonConverters.ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.Realtime.JsonConverters.ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.Realtime.JsonConverters.ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.AudioEncoding), TypeInfoPropertyName = "AudioEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.AudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.PromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.RealtimeTranscriptionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.RealtimeTranscriptionErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.RealtimeTranscriptionInputAudioAppend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.RealtimeTranscriptionInputAudioEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.RealtimeTranscriptionInputAudioFlush))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.RealtimeTranscriptionSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.RealtimeTranscriptionSessionCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.RealtimeTranscriptionSessionUpdateMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.RealtimeTranscriptionSessionUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.TranscriptionSegmentChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.TranscriptionStreamDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.Realtime.TranscriptionSegmentChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.UsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.TranscriptionStreamLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.TranscriptionStreamSegmentDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.TranscriptionStreamTextDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Realtime.ServerEventDiscriminatorType), TypeInfoPropertyName = "ServerEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Realtime.TranscriptionSegmentChunk>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}