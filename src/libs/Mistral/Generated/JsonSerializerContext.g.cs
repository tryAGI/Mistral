
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Mistral.JsonConverters.TextChunkTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.TextChunkTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ImageURLChunkTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.ImageURLChunkTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.UserMessageRoleJsonConverter),
            typeof(global::Mistral.JsonConverters.UserMessageRoleNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.AssistantMessageRoleJsonConverter),
            typeof(global::Mistral.JsonConverters.AssistantMessageRoleNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ToolTypesJsonConverter),
            typeof(global::Mistral.JsonConverters.ToolTypesNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ToolMessageRoleJsonConverter),
            typeof(global::Mistral.JsonConverters.ToolMessageRoleNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ResponseFormatsJsonConverter),
            typeof(global::Mistral.JsonConverters.ResponseFormatsNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ToolChoiceEnumJsonConverter),
            typeof(global::Mistral.JsonConverters.ToolChoiceEnumNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ArchiveFTModelOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.ArchiveFTModelOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.BaseModelCardTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.BaseModelCardTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter),
            typeof(global::Mistral.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.SystemMessageRoleJsonConverter),
            typeof(global::Mistral.JsonConverters.SystemMessageRoleNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.CompletionResponseStreamChoiceFinishReasonJsonConverter),
            typeof(global::Mistral.JsonConverters.CompletionResponseStreamChoiceFinishReasonNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.WandbIntegrationOutTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.WandbIntegrationOutTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.FineTuneableModelJsonConverter),
            typeof(global::Mistral.JsonConverters.FineTuneableModelNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.DetailedJobOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.DetailedJobOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.GithubRepositoryOutTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.GithubRepositoryOutTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.DetailedJobOutStatusJsonConverter),
            typeof(global::Mistral.JsonConverters.DetailedJobOutStatusNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.FTModelCardTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.FTModelCardTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.FTModelOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.FTModelOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.FileSchemaPurposeJsonConverter),
            typeof(global::Mistral.JsonConverters.FileSchemaPurposeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.SampleTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.SampleTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.SourceJsonConverter),
            typeof(global::Mistral.JsonConverters.SourceNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.GithubRepositoryInTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.GithubRepositoryInTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.WandbIntegrationTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.WandbIntegrationTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.JobOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.JobOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.JobOutStatusJsonConverter),
            typeof(global::Mistral.JsonConverters.JobOutStatusNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.JobsOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.JobsOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.LegacyJobMetadataOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.LegacyJobMetadataOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.RetrieveFileOutPurposeJsonConverter),
            typeof(global::Mistral.JsonConverters.RetrieveFileOutPurposeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.UnarchiveFTModelOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.UnarchiveFTModelOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.UploadFileOutPurposeJsonConverter),
            typeof(global::Mistral.JsonConverters.UploadFileOutPurposeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestPurposeJsonConverter),
            typeof(global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestPurposeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatusJsonConverter),
            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatusNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.OneOfJsonConverterFactory3),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverterFactory2),
            typeof(global::Mistral.JsonConverters.ContentChunkJsonConverter),
            typeof(global::Mistral.JsonConverters.OneOfJsonConverterFactory4),
            typeof(global::Mistral.JsonConverters.ChatCompletionResponseJsonConverter),
            typeof(global::Mistral.JsonConverters.ChatCompletionResponseBaseJsonConverter),
            typeof(global::Mistral.JsonConverters.OneOfJsonConverterFactory1),
            typeof(global::Mistral.JsonConverters.EmbeddingResponseJsonConverter),
            typeof(global::Mistral.JsonConverters.FIMCompletionResponseJsonConverter),
            typeof(global::Mistral.JsonConverters.OneOfJsonConverterFactory2),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}