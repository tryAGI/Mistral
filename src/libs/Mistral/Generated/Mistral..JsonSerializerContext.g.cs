
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
            typeof(global::Mistral.JsonConverters.ModelListDataItemDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.ModelListDataItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.APIKeyAuthTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.APIKeyAuthTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionToolTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionToolTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.WebSearchToolTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.WebSearchToolTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.WebSearchPremiumToolTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.WebSearchPremiumToolTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CodeInterpreterToolTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ImageGenerationToolTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.ImageGenerationToolTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.DocumentLibraryToolTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.DocumentLibraryToolTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CustomConnectorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.CustomConnectorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.OAuth2TokenAuthTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.OAuth2TokenAuthTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CustomConnectorAuthorizationVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.CustomConnectorAuthorizationVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentToolDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ResponseFormatsJsonConverter),

            typeof(global::Mistral.JsonConverters.ResponseFormatsNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolChoiceEnumJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolChoiceEnumNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ModerationLLMActionJsonConverter),

            typeof(global::Mistral.JsonConverters.ModerationLLMActionNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentCreationRequestToolDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentCreationRequestToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentUpdateRequestToolDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentUpdateRequestToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.BuiltInConnectorsJsonConverter),

            typeof(global::Mistral.JsonConverters.BuiltInConnectorsNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.MessageInputEntryRoleJsonConverter),

            typeof(global::Mistral.JsonConverters.MessageInputEntryRoleNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionCallEntryConfirmationStatus2JsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionCallEntryConfirmationStatus2NullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationAppendRequestBaseHandoffExecutionJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationAppendRequestBaseHandoffExecutionNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolCallConfirmationConfirmationJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolCallConfirmationConfirmationNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ImageDetailJsonConverter),

            typeof(global::Mistral.JsonConverters.ImageDetailNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRestartRequestBaseHandoffExecutionJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRestartRequestBaseHandoffExecutionNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ModelConversationToolDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.ModelConversationToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.RequestSourceJsonConverter),

            typeof(global::Mistral.JsonConverters.RequestSourceNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRequestBaseHandoffExecution2JsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRequestBaseHandoffExecution2NullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRequestBaseToolsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRequestBaseToolsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionCallEventConfirmationStatus2JsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionCallEventConfirmationStatus2NullableJsonConverter),

            typeof(global::Mistral.JsonConverters.SSETypesJsonConverter),

            typeof(global::Mistral.JsonConverters.SSETypesNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationEventsDataDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationEventsDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FilePurposeJsonConverter),

            typeof(global::Mistral.JsonConverters.FilePurposeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FileVisibilityJsonConverter),

            typeof(global::Mistral.JsonConverters.FileVisibilityNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.SampleTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.SampleTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.SourceJsonConverter),

            typeof(global::Mistral.JsonConverters.SourceNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FineTuneableModelTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.FineTuneableModelTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ClassifierJobOutStatusJsonConverter),

            typeof(global::Mistral.JsonConverters.ClassifierJobOutStatusNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionJobOutStatusJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionJobOutStatusNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionJobOutRepositorieDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionJobOutRepositorieDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsOutDataItemDiscriminatorJobTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsOutDataItemDiscriminatorJobTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FTClassifierLossFunctionJsonConverter),

            typeof(global::Mistral.JsonConverters.FTClassifierLossFunctionNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JobInIntegrationsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.JobInIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JobInRepositoriesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.JobInRepositoriesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ClassifierDetailedJobOutStatusJsonConverter),

            typeof(global::Mistral.JsonConverters.ClassifierDetailedJobOutStatusNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionDetailedJobOutStatusJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionDetailedJobOutStatusNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionDetailedJobOutRepositorieDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionDetailedJobOutRepositorieDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.BatchJobStatusJsonConverter),

            typeof(global::Mistral.JsonConverters.BatchJobStatusNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ApiEndpointJsonConverter),

            typeof(global::Mistral.JsonConverters.ApiEndpointNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ContentChunkDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.ContentChunkDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolTypesJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolTypesNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.SystemMessageContentChunksDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.SystemMessageContentChunksDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.MistralPromptModeJsonConverter),

            typeof(global::Mistral.JsonConverters.MistralPromptModeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatModerationRequestInputVariant1ItemDiscriminatorRoleJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatModerationRequestInputVariant1ItemDiscriminatorRoleNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatModerationRequestInputVariant2ItemItemDiscriminatorRoleJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatModerationRequestInputVariant2ItemItemDiscriminatorRoleNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.EmbeddingDtypeJsonConverter),

            typeof(global::Mistral.JsonConverters.EmbeddingDtypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.EncodingFormatJsonConverter),

            typeof(global::Mistral.JsonConverters.EncodingFormatNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.InstructRequestMessageDiscriminatorRoleJsonConverter),

            typeof(global::Mistral.JsonConverters.InstructRequestMessageDiscriminatorRoleNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.OCRTableObjectFormatJsonConverter),

            typeof(global::Mistral.JsonConverters.OCRTableObjectFormatNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.OCRRequestTableFormat2JsonConverter),

            typeof(global::Mistral.JsonConverters.OCRRequestTableFormat2NullableJsonConverter),

            typeof(global::Mistral.JsonConverters.TimestampGranularityJsonConverter),

            typeof(global::Mistral.JsonConverters.TimestampGranularityNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.TranscriptionStreamEventTypesJsonConverter),

            typeof(global::Mistral.JsonConverters.TranscriptionStreamEventTypesNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.TranscriptionStreamEventsDataDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.TranscriptionStreamEventsDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.AudioEncodingJsonConverter),

            typeof(global::Mistral.JsonConverters.AudioEncodingNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.RealtimeTranscriptionClientMessageDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.RealtimeTranscriptionClientMessageDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentsCompletionRequestMessageDiscriminatorRoleJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentsCompletionRequestMessageDiscriminatorRoleNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ProcessStatusJsonConverter),

            typeof(global::Mistral.JsonConverters.ProcessStatusNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FilterConditionOpJsonConverter),

            typeof(global::Mistral.JsonConverters.FilterConditionOpNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ShareEnumJsonConverter),

            typeof(global::Mistral.JsonConverters.ShareEnumNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.EntityTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.EntityTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.BaseFieldDefinitionTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.BaseFieldDefinitionTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.BaseFieldDefinitionSupportedOperatorJsonConverter),

            typeof(global::Mistral.JsonConverters.BaseFieldDefinitionSupportedOperatorNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.BaseTaskStatusJsonConverter),

            typeof(global::Mistral.JsonConverters.BaseTaskStatusNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JudgePreviewOutputDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.JudgePreviewOutputDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationSourceJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationSourceNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JudgeOutputTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.JudgeOutputTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.PostJudgeInSchemaOutputDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.PostJudgeInSchemaOutputDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.PutJudgeInSchemaOutputDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.PutJudgeInSchemaOutputDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.AnnotationsAudienceVariant1ItemJsonConverter),

            typeof(global::Mistral.JsonConverters.AnnotationsAudienceVariant1ItemNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ResourceVisibilityJsonConverter),

            typeof(global::Mistral.JsonConverters.ResourceVisibilityNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ConnectorSupportedLanguageJsonConverter),

            typeof(global::Mistral.JsonConverters.ConnectorSupportedLanguageNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionResponseStreamChoiceFinishReasonJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionResponseStreamChoiceFinishReasonNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestVisibilityJsonConverter),

            typeof(global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestVisibilityNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatus2JsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatus2NullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesBatchGetBatchJobsOrderByJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesBatchGetBatchJobsOrderByNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.DataItemJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolsItemJsonConverter),

            typeof(global::Mistral.JsonConverters.AuthorizationVariant1JsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionArgsStopJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolsItem2JsonConverter),

            typeof(global::Mistral.JsonConverters.ToolsItem3JsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationAppendRequestJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationInputsJsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionCallEntryArgumentsJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRestartRequestJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolsItem4JsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRequestJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolsVariant1ItemJsonConverter),

            typeof(global::Mistral.JsonConverters.OutputContentChunksJsonConverter),

            typeof(global::Mistral.JsonConverters.DataJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationStreamRequestJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationAppendStreamRequestJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRestartStreamRequestJsonConverter),

            typeof(global::Mistral.JsonConverters.IntegrationsVariant1ItemJsonConverter),

            typeof(global::Mistral.JsonConverters.IntegrationsVariant1Item2JsonConverter),

            typeof(global::Mistral.JsonConverters.RepositoriesItemJsonConverter),

            typeof(global::Mistral.JsonConverters.DataItem2JsonConverter),

            typeof(global::Mistral.JsonConverters.IntegrationsVariant1Item3JsonConverter),

            typeof(global::Mistral.JsonConverters.RepositoriesVariant1ItemJsonConverter),

            typeof(global::Mistral.JsonConverters.IntegrationsVariant1Item4JsonConverter),

            typeof(global::Mistral.JsonConverters.IntegrationsVariant1Item5JsonConverter),

            typeof(global::Mistral.JsonConverters.RepositoriesItem2JsonConverter),

            typeof(global::Mistral.JsonConverters.ContentChunkJsonConverter),

            typeof(global::Mistral.JsonConverters.MessagesItemJsonConverter),

            typeof(global::Mistral.JsonConverters.SystemMessageContentChunksJsonConverter),

            typeof(global::Mistral.JsonConverters.InputVariant1ItemJsonConverter),

            typeof(global::Mistral.JsonConverters.InputVariant2ItemItemJsonConverter),

            typeof(global::Mistral.JsonConverters.MessagesItem2JsonConverter),

            typeof(global::Mistral.JsonConverters.Data2JsonConverter),

            typeof(global::Mistral.JsonConverters.RealtimeTranscriptionClientMessageJsonConverter),

            typeof(global::Mistral.JsonConverters.MessagesItem3JsonConverter),

            typeof(global::Mistral.JsonConverters.ChatClassificationRequestInputsJsonConverter),

            typeof(global::Mistral.JsonConverters.OutputJsonConverter),

            typeof(global::Mistral.JsonConverters.Output2JsonConverter),

            typeof(global::Mistral.JsonConverters.Output3JsonConverter),

            typeof(global::Mistral.JsonConverters.ChatCompletionResponseBaseJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatCompletionResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.FIMCompletionResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.EmbeddingResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1JsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningCancelFineTuningJobResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningUpdateFineTunedModelResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ImageURL, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::Mistral.OutputContentChunks?>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.CompletionTrainingParametersIn, global::Mistral.ClassifierTrainingParametersIn>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, byte[]>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<object, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<bool>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, bool?, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, double?>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextResourceContents, global::Mistral.BlobResourceContents>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ModelConversation, global::Mistral.AgentConversation>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ModelConversation, global::Mistral.AgentConversation>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?, global::Mistral.LegacyJobMetadataOut>),

            typeof(global::Mistral.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseModelCard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DeleteModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FTModelCard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelListDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelListDataItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.APIKeyAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.APIKeyAuthType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchPremiumTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchPremiumToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CodeInterpreterTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CodeInterpreterToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageGenerationTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageGenerationToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentLibraryTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentLibraryToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AuthorizationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OAuth2TokenAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OAuth2TokenAuthType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorAuthorizationVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentToolDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsStop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Prediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolChoiceEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GuardrailConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV1Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV1CategoryThresholds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV2Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV2CategoryThresholds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentAliasResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentCreationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentCreationRequestToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentCreationRequestToolDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentHandoffEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentUpdateRequestToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentUpdateRequestToolDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BuiltInConnectors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessageInputEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessageInputEntryRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TextChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ImageURL, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolFileChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.BuiltInConnectors?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ThinkChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolReferenceChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ReferenceChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessageOutputEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionResultEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEntryArguments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEntryConfirmationStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecutionEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendRequestBaseHandoffExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolCallConfirmation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolCallConfirmation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolCallConfirmationConfirmation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartRequestBaseHandoffExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelConversationToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelConversationToolDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RequestSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationUsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBaseHandoffExecution2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBaseToolsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBaseToolsVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentHandoffDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentHandoffStartedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEventConfirmationStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessageOutputEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::Mistral.OutputContentChunks?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OutputContentChunks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseStartedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SSETypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecutionDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecutionDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecutionStartedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationEventsDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationEventsDataDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationStreamRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendStreamRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartStreamRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilePurpose))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FileVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SampleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UploadFileOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FileSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListFilesOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.FileSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RetrieveFileOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DeleteFileOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FileSignedURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FineTuneableModelType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOutStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WandbIntegrationOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobMetadataOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierTrainingParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionTrainingParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GithubRepositoryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutRepositorieDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutRepositorieDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DataItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsOutDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsOutDataItemDiscriminatorJobType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.LegacyJobMetadataOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierTargetIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FTClassifierLossFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierTrainingParametersIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionTrainingParametersIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GithubRepositoryIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.TrainingFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TrainingFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WandbIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.CompletionTrainingParametersIn, global::Mistral.ClassifierTrainingParametersIn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.RepositoriesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ClassifierTargetIn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CheckpointOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MetricOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOutStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.EventOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EventOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.CheckpointOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ClassifierTargetOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierTargetOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierFTModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FTModelCapabilitiesOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionFTModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UpdateFTModelIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ArchiveFTModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UnarchiveFTModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchJobStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.BatchError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchJobsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.BatchJobOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ApiEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchJobIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.BatchRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ContentChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FileChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunkDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunkDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<object, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.MessagesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunksDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionRequestMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionRequestMessageDiscriminatorRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.Tool3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Tool3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolChoice2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MistralPromptMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InputVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InputVariant2ItemItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddingDtype))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EncodingFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FIMCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InstructRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.MessagesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InstructRequestMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InstructRequestMessageDiscriminatorRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRPageDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRPageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OCRImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OCRTableObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRTableObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRTableObjectFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRRequestTableFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OCRPageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRUsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.TranscriptionSegmentChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionSegmentChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TimestampGranularity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.TimestampGranularity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioTranscriptionRequestStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamSegmentDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamTextDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamEventTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Data2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamEventsDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamEventsDataDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionClientMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionSessionUpdateMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionSessionUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioEncoding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionInputAudioAppend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionInputAudioFlush))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionInputAudioEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionClientMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentsCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.MessagesItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentsCompletionRequestMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentsCompletionRequestMessageDiscriminatorRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatClassificationRequestInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.InstructRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassificationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::Mistral.ClassificationTargetResult>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Mistral.ClassificationTargetResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassificationTargetResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ModerationObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ProcessStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentUpdateIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<bool>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterConditionOp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.LibraryIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.LibraryInUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.LibraryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListDocumentOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DocumentOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListLibraryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.LibraryOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListSharingOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.SharingOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SharingOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ProcessingStatusOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ShareEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SharingDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EntityType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SharingIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseFieldDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseFieldDefinitionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.BaseFieldDefinitionSupportedOperator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseFieldDefinitionSupportedOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseTaskStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CampaignPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgePreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeClassificationOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.JudgeClassificationOutputOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeClassificationOutputOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeRegressionOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgePreviewOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgePreviewOutputDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CampaignPreviews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultCampaignPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.CampaignPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CampaignSelectedEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultChatCompletionEventPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ChatCompletionEventPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionEventPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CampaignStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionEventIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ChatTranscriptionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatTranscriptionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FeedResultChatCompletionEventPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionFieldOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<string, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, bool?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.BaseFieldDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.FieldGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FieldGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetExport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetImportTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetImportTasks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultDatasetImportTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DatasetImportTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetPreviews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultDatasetPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DatasetPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetRecords))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultDatasetRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DatasetRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DeleteDatasetRecordsInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FieldOptionCountItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FieldOptionCountsInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FieldOptionCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.FieldOptionCountItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GetChatCompletionEventIdsInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GetChatCompletionEventsInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgePreviews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultJudgePreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.JudgePreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PatchDatasetInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostCampaignInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostChatCompletionEventJudgingInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostJudgeInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostJudgeInSchemaOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostJudgeInSchemaOutputDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetImportFromCampaignInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetImportFromDatasetInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetImportFromExplorerInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetImportFromFileInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetImportFromPlaygroundInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetRecordInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetRecordJudgingInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PutDatasetRecordPayloadInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PutDatasetRecordPropertiesInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PutJudgeInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PutJudgeInSchemaOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PutJudgeInSchemaOutputDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Annotations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnnotationsAudienceVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnnotationsAudienceVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AuthData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BlobResourceContents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Connector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsSchemasApiToolTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsSchemasApiToolTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsSchemasTurbineToolLocale))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ExecutionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResourceVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConnectorMCPCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConnectorMCPUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConnectorSupportedLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConnectorsQueryFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddedResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextResourceContents, global::Mistral.BlobResourceContents>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TextResourceContents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPResultMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPToolCallMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPToolCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPToolCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResourceLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.MCPServerIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPServerIcon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedConnectors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.Connector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.CompletionResponseStreamChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionResponseStreamChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionResponseStreamChoiceFinishReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionChoiceFinishReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionResponseBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionResponseChatCompletionResponse1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FIMCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FIMCompletionResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddingResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddingResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.EmbeddingResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilesApiRoutesUploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.LibrariesDocumentsUploadV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.RequestSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<int?, string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.SampleType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.BatchJobStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesBatchGetBatchJobsOrderBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AgentAliasResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?, global::Mistral.LegacyJobMetadataOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.GuardrailConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolCallConfirmation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.FileSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.IntegrationsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.IntegrationsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.RepositoriesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.TrainingFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.IntegrationsVariant1Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.RepositoriesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ClassifierTargetIn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.IntegrationsVariant1Item4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.EventOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.CheckpointOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ClassifierTargetOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.IntegrationsVariant1Item5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.RepositoriesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.BatchError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.BatchJobOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.BatchRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, object, global::System.Collections.Generic.List<global::Mistral.ContentChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ContentChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.MessagesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.List<global::Mistral.SystemMessageContentChunks>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.SystemMessageContentChunks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Tool3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::System.Collections.Generic.List<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Mistral.InputVariant2ItemItem>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.InputVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Mistral.InputVariant2ItemItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.InputVariant2ItemItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.MessagesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OCRImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OCRTableObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OCRPageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.TranscriptionSegmentChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.TimestampGranularity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.MessagesItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.InstructRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, global::Mistral.ClassificationTargetResult>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ModerationObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<bool>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DocumentOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.LibraryOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.SharingOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.BaseFieldDefinitionSupportedOperator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.JudgeClassificationOutputOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.CampaignPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ChatCompletionEventPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ChatTranscriptionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<string, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.BaseFieldDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.FieldGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DatasetImportTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DatasetPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DatasetRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.FieldOptionCountItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.JudgePreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnnotationsAudienceVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.IntegrationsSchemasApiToolTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.MCPServerIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Connector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.CompletionResponseStreamChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.EmbeddingResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.RequestSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.SampleType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.BatchJobStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AgentAliasResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}