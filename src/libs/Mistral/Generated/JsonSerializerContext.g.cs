
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
            typeof(global::Mistral.JsonConverters.SystemMessageRoleJsonConverter),
            typeof(global::Mistral.JsonConverters.SystemMessageRoleNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ImageURLChunkTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.ImageURLChunkTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ContentChunkDiscriminatorTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.ContentChunkDiscriminatorTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.UserMessageRoleJsonConverter),
            typeof(global::Mistral.JsonConverters.UserMessageRoleNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.AssistantMessageRoleJsonConverter),
            typeof(global::Mistral.JsonConverters.AssistantMessageRoleNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ToolTypesJsonConverter),
            typeof(global::Mistral.JsonConverters.ToolTypesNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ToolMessageRoleJsonConverter),
            typeof(global::Mistral.JsonConverters.ToolMessageRoleNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.AgentsCompletionRequestMessageDiscriminatorRoleJsonConverter),
            typeof(global::Mistral.JsonConverters.AgentsCompletionRequestMessageDiscriminatorRoleNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ResponseFormatsJsonConverter),
            typeof(global::Mistral.JsonConverters.ResponseFormatsNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ToolChoiceEnumJsonConverter),
            typeof(global::Mistral.JsonConverters.ToolChoiceEnumNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ApiEndpointJsonConverter),
            typeof(global::Mistral.JsonConverters.ApiEndpointNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ArchiveFTModelOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.ArchiveFTModelOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.BaseModelCardTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.BaseModelCardTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.BatchJobOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.BatchJobOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.BatchJobStatusJsonConverter),
            typeof(global::Mistral.JsonConverters.BatchJobStatusNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.BatchJobsOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.BatchJobsOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ChatClassificationRequestInputVariant1ItemDiscriminatorRoleJsonConverter),
            typeof(global::Mistral.JsonConverters.ChatClassificationRequestInputVariant1ItemDiscriminatorRoleNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ChatClassificationRequestInputVariant2ItemItemDiscriminatorRoleJsonConverter),
            typeof(global::Mistral.JsonConverters.ChatClassificationRequestInputVariant2ItemItemDiscriminatorRoleNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter),
            typeof(global::Mistral.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleJsonConverter),
            typeof(global::Mistral.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.CompletionResponseStreamChoiceFinishReasonJsonConverter),
            typeof(global::Mistral.JsonConverters.CompletionResponseStreamChoiceFinishReasonNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.WandbIntegrationOutTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.WandbIntegrationOutTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.DetailedJobOutIntegrationDiscriminatorTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.DetailedJobOutIntegrationDiscriminatorTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.FineTuneableModelJsonConverter),
            typeof(global::Mistral.JsonConverters.FineTuneableModelNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.DetailedJobOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.DetailedJobOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.GithubRepositoryOutTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.GithubRepositoryOutTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.DetailedJobOutRepositorieDiscriminatorTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.DetailedJobOutRepositorieDiscriminatorTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.DetailedJobOutStatusJsonConverter),
            typeof(global::Mistral.JsonConverters.DetailedJobOutStatusNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.FTModelCardTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.FTModelCardTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.FTModelOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.FTModelOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.FilePurposeJsonConverter),
            typeof(global::Mistral.JsonConverters.FilePurposeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.SampleTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.SampleTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.SourceJsonConverter),
            typeof(global::Mistral.JsonConverters.SourceNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.GithubRepositoryInTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.GithubRepositoryInTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.WandbIntegrationTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.WandbIntegrationTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.JobInIntegrationDiscriminatorTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.JobInIntegrationDiscriminatorTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.JobInRepositorieDiscriminatorTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.JobInRepositorieDiscriminatorTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.JobOutIntegrationDiscriminatorTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.JobOutIntegrationDiscriminatorTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.JobOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.JobOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.JobOutRepositorieDiscriminatorTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.JobOutRepositorieDiscriminatorTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.JobOutStatusJsonConverter),
            typeof(global::Mistral.JsonConverters.JobOutStatusNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.JobsOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.JobsOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.LegacyJobMetadataOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.LegacyJobMetadataOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.ModelListDataItemDiscriminatorTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.ModelListDataItemDiscriminatorTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.UnarchiveFTModelOutObjectJsonConverter),
            typeof(global::Mistral.JsonConverters.UnarchiveFTModelOutObjectNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestPurposeJsonConverter),
            typeof(global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestPurposeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatusJsonConverter),
            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatusNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeJsonConverter),
            typeof(global::Mistral.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeNullableJsonConverter),
            typeof(global::Mistral.JsonConverters.MessagesItemJsonConverter),
            typeof(global::Mistral.JsonConverters.ContentChunkJsonConverter),
            typeof(global::Mistral.JsonConverters.InputVariant1ItemJsonConverter),
            typeof(global::Mistral.JsonConverters.InputVariant2ItemItemJsonConverter),
            typeof(global::Mistral.JsonConverters.MessagesItem2JsonConverter),
            typeof(global::Mistral.JsonConverters.ChatCompletionResponseJsonConverter),
            typeof(global::Mistral.JsonConverters.ChatCompletionResponseBaseJsonConverter),
            typeof(global::Mistral.JsonConverters.IntegrationsItemJsonConverter),
            typeof(global::Mistral.JsonConverters.RepositoriesItemJsonConverter),
            typeof(global::Mistral.JsonConverters.EmbeddingResponseJsonConverter),
            typeof(global::Mistral.JsonConverters.FIMCompletionResponseJsonConverter),
            typeof(global::Mistral.JsonConverters.IntegrationsItem2JsonConverter),
            typeof(global::Mistral.JsonConverters.RepositoriesItem2JsonConverter),
            typeof(global::Mistral.JsonConverters.IntegrationsItem3JsonConverter),
            typeof(global::Mistral.JsonConverters.RepositoriesItem3JsonConverter),
            typeof(global::Mistral.JsonConverters.DataItemJsonConverter),
            typeof(global::Mistral.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseJsonConverter),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.TextChunk>>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ImageURL, string>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<object, string>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ToolChoice3, global::Mistral.ToolChoiceEnum?>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ToolChoice3, global::Mistral.ToolChoiceEnum?>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?>),
            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.JobOut, global::Mistral.LegacyJobMetadataOut>),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}