
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

            typeof(global::Mistral.JsonConverters.AgentToolDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentCreationRequestToolDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentCreationRequestToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentUpdateRequestToolDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentUpdateRequestToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.BuiltInConnectorsJsonConverter),

            typeof(global::Mistral.JsonConverters.BuiltInConnectorsNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CodeInterpreterToolTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionArgsReasoningEffort2JsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionArgsReasoningEffort2NullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CustomConnectorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.CustomConnectorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CustomConnectorAuthorizationVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.CustomConnectorAuthorizationVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.DocumentLibraryToolTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.DocumentLibraryToolTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionCallEntryConfirmationStatus2JsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionCallEntryConfirmationStatus2NullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionToolTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionToolTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ImageDetailJsonConverter),

            typeof(global::Mistral.JsonConverters.ImageDetailNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ImageGenerationToolTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.ImageGenerationToolTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.MessageInputEntryRoleJsonConverter),

            typeof(global::Mistral.JsonConverters.MessageInputEntryRoleNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ModelConversationToolDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.ModelConversationToolDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ModerationLLMActionJsonConverter),

            typeof(global::Mistral.JsonConverters.ModerationLLMActionNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.OAuth2TokenAuthTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.OAuth2TokenAuthTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.RequestSourceJsonConverter),

            typeof(global::Mistral.JsonConverters.RequestSourceNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ResponseFormatsJsonConverter),

            typeof(global::Mistral.JsonConverters.ResponseFormatsNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolCallConfirmationConfirmationJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolCallConfirmationConfirmationNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolChoiceEnumJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolChoiceEnumNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.WebSearchPremiumToolTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.WebSearchPremiumToolTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.WebSearchToolTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.WebSearchToolTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionCallEventConfirmationStatus2JsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionCallEventConfirmationStatus2NullableJsonConverter),

            typeof(global::Mistral.JsonConverters.SSETypesJsonConverter),

            typeof(global::Mistral.JsonConverters.SSETypesNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationEventsDataDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationEventsDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRequestBaseHandoffExecution2JsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRequestBaseHandoffExecution2NullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRequestBaseToolsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRequestBaseToolsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationAppendRequestBaseHandoffExecutionJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationAppendRequestBaseHandoffExecutionNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRestartRequestBaseHandoffExecutionJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRestartRequestBaseHandoffExecutionNullableJsonConverter),

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

            typeof(global::Mistral.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatCompletionRequestReasoningEffortJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatCompletionRequestReasoningEffortNullableJsonConverter),

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

            typeof(global::Mistral.JsonConverters.MistralPromptModeJsonConverter),

            typeof(global::Mistral.JsonConverters.MistralPromptModeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.OCRRequestTableFormat2JsonConverter),

            typeof(global::Mistral.JsonConverters.OCRRequestTableFormat2NullableJsonConverter),

            typeof(global::Mistral.JsonConverters.OCRTableObjectFormatJsonConverter),

            typeof(global::Mistral.JsonConverters.OCRTableObjectFormatNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolTypesJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolTypesNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.SpeechOutputFormatJsonConverter),

            typeof(global::Mistral.JsonConverters.SpeechOutputFormatNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.SpeechStreamEventsEventJsonConverter),

            typeof(global::Mistral.JsonConverters.SpeechStreamEventsEventNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.SpeechStreamEventsDataDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.SpeechStreamEventsDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.TimestampGranularityJsonConverter),

            typeof(global::Mistral.JsonConverters.TimestampGranularityNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.TranscriptionStreamEventsDataDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.TranscriptionStreamEventsDataDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.TranscriptionStreamEventTypesJsonConverter),

            typeof(global::Mistral.JsonConverters.TranscriptionStreamEventTypesNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.RealtimeTranscriptionClientMessageDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.RealtimeTranscriptionClientMessageDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.AudioEncodingJsonConverter),

            typeof(global::Mistral.JsonConverters.AudioEncodingNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentsCompletionRequestMessageDiscriminatorRoleJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentsCompletionRequestMessageDiscriminatorRoleNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentsCompletionRequestReasoningEffortJsonConverter),

            typeof(global::Mistral.JsonConverters.AgentsCompletionRequestReasoningEffortNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ContentChunkDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.ContentChunkDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.SystemMessageContentChunksDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.SystemMessageContentChunksDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FilterConditionOpJsonConverter),

            typeof(global::Mistral.JsonConverters.FilterConditionOpNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ProcessStatusJsonConverter),

            typeof(global::Mistral.JsonConverters.ProcessStatusNullableJsonConverter),

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

            typeof(global::Mistral.JsonConverters.ConversationSourceJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationSourceNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JudgeOutputTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.JudgeOutputTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JudgePreviewOutputDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.JudgePreviewOutputDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.PostJudgeInSchemaOutputDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.PostJudgeInSchemaOutputDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.PutJudgeInSchemaOutputDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.PutJudgeInSchemaOutputDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ObservabilityErrorCodeJsonConverter),

            typeof(global::Mistral.JsonConverters.ObservabilityErrorCodeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.AnnotationsAudienceVariant1ItemJsonConverter),

            typeof(global::Mistral.JsonConverters.AnnotationsAudienceVariant1ItemNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ConnectorSupportedLanguageJsonConverter),

            typeof(global::Mistral.JsonConverters.ConnectorSupportedLanguageNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ResourceVisibilityJsonConverter),

            typeof(global::Mistral.JsonConverters.ResourceVisibilityNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionResponseStreamChoiceFinishReasonJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionResponseStreamChoiceFinishReasonNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.CustomTaskInProgressAttributesResponsePayloadDiscriminatorTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.CustomTaskInProgressAttributesResponsePayloadDiscriminatorTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.EncodedPayloadOptionsJsonConverter),

            typeof(global::Mistral.JsonConverters.EncodedPayloadOptionsNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.EventProgressStatusJsonConverter),

            typeof(global::Mistral.JsonConverters.EventProgressStatusNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.EventSourceJsonConverter),

            typeof(global::Mistral.JsonConverters.EventSourceNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.EventTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.EventTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JSONPatchPayloadResponseValueItemDiscriminatorOpJsonConverter),

            typeof(global::Mistral.JsonConverters.JSONPatchPayloadResponseValueItemDiscriminatorOpNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.TempoTraceScopeKindJsonConverter),

            typeof(global::Mistral.JsonConverters.TempoTraceScopeKindNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.WorkflowEventTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.WorkflowEventTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.WorkflowExecutionStatusJsonConverter),

            typeof(global::Mistral.JsonConverters.WorkflowExecutionStatusNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.WorkflowTypeJsonConverter),

            typeof(global::Mistral.JsonConverters.WorkflowTypeNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestVisibilityJsonConverter),

            typeof(global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestVisibilityNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatus2JsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatus2NullableJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesBatchGetBatchJobsOrderByJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesBatchGetBatchJobsOrderByNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperatorJsonConverter),

            typeof(global::Mistral.JsonConverters.GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperatorNullableJsonConverter),

            typeof(global::Mistral.JsonConverters.GetStreamEventsV1WorkflowsEventsStreamGetScopeJsonConverter),

            typeof(global::Mistral.JsonConverters.GetStreamEventsV1WorkflowsEventsStreamGetScopeNullableJsonConverter),

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

            typeof(global::Mistral.JsonConverters.ToolsItem2JsonConverter),

            typeof(global::Mistral.JsonConverters.ToolsItem3JsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationAppendRequestJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRestartRequestJsonConverter),

            typeof(global::Mistral.JsonConverters.AuthorizationVariant1JsonConverter),

            typeof(global::Mistral.JsonConverters.ToolsItem4JsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationRequestJsonConverter),

            typeof(global::Mistral.JsonConverters.DataJsonConverter),

            typeof(global::Mistral.JsonConverters.OutputContentChunksJsonConverter),

            typeof(global::Mistral.JsonConverters.CompletionArgsStopJsonConverter),

            typeof(global::Mistral.JsonConverters.FunctionCallEntryArgumentsJsonConverter),

            typeof(global::Mistral.JsonConverters.ConversationInputsJsonConverter),

            typeof(global::Mistral.JsonConverters.ToolsVariant1ItemJsonConverter),

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

            typeof(global::Mistral.JsonConverters.MessagesItemJsonConverter),

            typeof(global::Mistral.JsonConverters.InputVariant1ItemJsonConverter),

            typeof(global::Mistral.JsonConverters.InputVariant2ItemItemJsonConverter),

            typeof(global::Mistral.JsonConverters.MessagesItem2JsonConverter),

            typeof(global::Mistral.JsonConverters.Data2JsonConverter),

            typeof(global::Mistral.JsonConverters.Data3JsonConverter),

            typeof(global::Mistral.JsonConverters.RealtimeTranscriptionClientMessageJsonConverter),

            typeof(global::Mistral.JsonConverters.MessagesItem3JsonConverter),

            typeof(global::Mistral.JsonConverters.ChatClassificationRequestInputsJsonConverter),

            typeof(global::Mistral.JsonConverters.ContentChunkJsonConverter),

            typeof(global::Mistral.JsonConverters.SystemMessageContentChunksJsonConverter),

            typeof(global::Mistral.JsonConverters.OutputJsonConverter),

            typeof(global::Mistral.JsonConverters.Output2JsonConverter),

            typeof(global::Mistral.JsonConverters.Output3JsonConverter),

            typeof(global::Mistral.JsonConverters.ChatCompletionResponseBaseJsonConverter),

            typeof(global::Mistral.JsonConverters.ChatCompletionResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.FIMCompletionResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.EmbeddingResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.PayloadJsonConverter),

            typeof(global::Mistral.JsonConverters.ValueItemJsonConverter),

            typeof(global::Mistral.JsonConverters.WorkflowExecutionTraceSummaryAttributesValuesJsonConverter),

            typeof(global::Mistral.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1JsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningCancelFineTuningJobResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.JobsApiRoutesFineTuningUpdateFineTunedModelResponseJsonConverter),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ImageURL, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::Mistral.OutputContentChunks?>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.CompletionTrainingParametersIn, global::Mistral.ClassifierTrainingParametersIn>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, byte[]>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<object, string>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<bool>>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, bool?, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, double?>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextResourceContents, global::Mistral.BlobResourceContents>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>),

            typeof(global::Mistral.JsonConverters.OneOfJsonConverter<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.NetworkEncodedInput, object, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<int?, double?>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.NetworkEncodedInput, object, object>),

            typeof(global::Mistral.JsonConverters.OneOfJsonConverter<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TempoTraceAttributeStringValue, global::Mistral.TempoTraceAttributeIntValue, global::Mistral.TempoTraceAttributeBoolValue>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.NetworkEncodedInput, object, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.WorkflowExecutionTraceEvent, global::Mistral.WorkflowExecutionProgressTraceEvent>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<int?, string, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.WorkflowExecutionStatus?, global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionStatus>, object>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ModelConversation, global::Mistral.AgentConversation>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ModelConversation, global::Mistral.AgentConversation>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?, global::Mistral.LegacyJobMetadataOut>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.WorkflowExecutionResponse, global::Mistral.WorkflowExecutionSyncResponse>),

            typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.WorkflowExecutionResponse, global::Mistral.WorkflowExecutionSyncResponse>),

            typeof(global::Mistral.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseModelCard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DeleteModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FTModelCard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DataItem), TypeInfoPropertyName = "DataItem3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelListDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelListDataItemDiscriminatorType), TypeInfoPropertyName = "ModelListDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.APIKeyAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.APIKeyAuthType), TypeInfoPropertyName = "APIKeyAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem), TypeInfoPropertyName = "ToolsItem5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchPremiumTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CodeInterpreterTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageGenerationTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentLibraryTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentToolDiscriminatorType), TypeInfoPropertyName = "AgentToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GuardrailConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MetadataDict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentAliasResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?, object>), TypeInfoPropertyName = "AnyOfStringInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentCreationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem2), TypeInfoPropertyName = "ToolsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentCreationRequestToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentCreationRequestToolDiscriminatorType), TypeInfoPropertyName = "AgentCreationRequestToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentHandoffEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem3), TypeInfoPropertyName = "ToolsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentUpdateRequestToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentUpdateRequestToolDiscriminatorType), TypeInfoPropertyName = "AgentUpdateRequestToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BuiltInConnectors), TypeInfoPropertyName = "BuiltInConnectors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CodeInterpreterToolType), TypeInfoPropertyName = "CodeInterpreterToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsStop), TypeInfoPropertyName = "CompletionArgsStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Prediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolChoiceEnum), TypeInfoPropertyName = "ToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsReasoningEffort2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendRequest), TypeInfoPropertyName = "ConversationAppendRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>), TypeInfoPropertyName = "AnyOfMessageInputEntryMessageOutputEntryFunctionResultEntryFunctionCallEntryToolExecutionEntryAgentHandoffEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessageInputEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessageOutputEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionResultEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecutionEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartRequest), TypeInfoPropertyName = "ConversationRestartRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorType), TypeInfoPropertyName = "CustomConnectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AuthorizationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OAuth2TokenAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorAuthorizationVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType), TypeInfoPropertyName = "CustomConnectorAuthorizationVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentLibraryToolType), TypeInfoPropertyName = "DocumentLibraryToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEntryArguments), TypeInfoPropertyName = "FunctionCallEntryArguments2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEntryConfirmationStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionToolType), TypeInfoPropertyName = "FunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV1Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV2Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageDetail), TypeInfoPropertyName = "ImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageGenerationToolType), TypeInfoPropertyName = "ImageGenerationToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ImageURL, string>), TypeInfoPropertyName = "AnyOfImageURLString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessageInputEntryRole), TypeInfoPropertyName = "MessageInputEntryRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>>), TypeInfoPropertyName = "AnyOfStringIListAnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>>>), TypeInfoPropertyName = "AnyOfStringIListAnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunkToolReferenceChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem4), TypeInfoPropertyName = "ToolsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelConversationToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelConversationToolDiscriminatorType), TypeInfoPropertyName = "ModelConversationToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMAction), TypeInfoPropertyName = "ModerationLLMAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV1CategoryThresholds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV2CategoryThresholds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OAuth2TokenAuthType), TypeInfoPropertyName = "OAuth2TokenAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RequestSource), TypeInfoPropertyName = "RequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormats), TypeInfoPropertyName = "ResponseFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TextChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ThinkChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>), TypeInfoPropertyName = "AnyOfTextChunkToolReferenceChunkReferenceChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolReferenceChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ReferenceChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolCallConfirmation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolCallConfirmationConfirmation), TypeInfoPropertyName = "ToolCallConfirmationConfirmation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.BuiltInConnectors?, string>), TypeInfoPropertyName = "AnyOfBuiltInConnectorsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecutionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolFileChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchPremiumToolType), TypeInfoPropertyName = "WebSearchPremiumToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchToolType), TypeInfoPropertyName = "WebSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationUsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>), TypeInfoPropertyName = "AnyOfMessageOutputEntryToolExecutionEntryFunctionCallEntryAgentHandoffEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequest), TypeInfoPropertyName = "ConversationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentHandoffDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentHandoffStartedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEventConfirmationStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessageOutputEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::Mistral.OutputContentChunks?>), TypeInfoPropertyName = "AnyOfStringOutputContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OutputContentChunks), TypeInfoPropertyName = "OutputContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseStartedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SSETypes), TypeInfoPropertyName = "SSETypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecutionDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecutionDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecutionStartedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Data), TypeInfoPropertyName = "Data4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationEventsDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationEventsDataDiscriminatorType), TypeInfoPropertyName = "ConversationEventsDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>), TypeInfoPropertyName = "AnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>), TypeInfoPropertyName = "AnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunkToolReferenceChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>), TypeInfoPropertyName = "AnyOfMessageInputEntryMessageOutputEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationInputs), TypeInfoPropertyName = "ConversationInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBaseHandoffExecution2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsVariant1Item), TypeInfoPropertyName = "ToolsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBaseToolsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBaseToolsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "ConversationRequestBaseToolsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationStreamRequest), TypeInfoPropertyName = "ConversationStreamRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationStreamRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendRequestBaseHandoffExecution), TypeInfoPropertyName = "ConversationAppendRequestBaseHandoffExecution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolCallConfirmation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendStreamRequest), TypeInfoPropertyName = "ConversationAppendStreamRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendStreamRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartRequestBaseHandoffExecution), TypeInfoPropertyName = "ConversationRestartRequestBaseHandoffExecution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartStreamRequest), TypeInfoPropertyName = "ConversationRestartStreamRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartStreamRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilePurpose), TypeInfoPropertyName = "FilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FileVisibility), TypeInfoPropertyName = "FileVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SampleType), TypeInfoPropertyName = "SampleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Source), TypeInfoPropertyName = "Source2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FineTuneableModelType), TypeInfoPropertyName = "FineTuneableModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOutStatus), TypeInfoPropertyName = "ClassifierJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item), TypeInfoPropertyName = "IntegrationsVariant1Item6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WandbIntegrationOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobMetadataOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierTrainingParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutStatus), TypeInfoPropertyName = "CompletionJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item2), TypeInfoPropertyName = "IntegrationsVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "CompletionJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionTrainingParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesItem), TypeInfoPropertyName = "RepositoriesItem3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GithubRepositoryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutRepositorieDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutRepositorieDiscriminatorType), TypeInfoPropertyName = "CompletionJobOutRepositorieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DataItem2), TypeInfoPropertyName = "DataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsOutDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsOutDataItemDiscriminatorJobType), TypeInfoPropertyName = "JobsOutDataItemDiscriminatorJobType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item3), TypeInfoPropertyName = "IntegrationsVariant1Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WandbIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "JobInIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.CompletionTrainingParametersIn, global::Mistral.ClassifierTrainingParametersIn>), TypeInfoPropertyName = "AnyOfCompletionTrainingParametersInClassifierTrainingParametersIn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.RepositoriesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesVariant1Item), TypeInfoPropertyName = "RepositoriesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType), TypeInfoPropertyName = "JobInRepositoriesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ClassifierTargetIn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CheckpointOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MetricOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOutStatus), TypeInfoPropertyName = "ClassifierDetailedJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item4), TypeInfoPropertyName = "IntegrationsVariant1Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.EventOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EventOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.CheckpointOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ClassifierTargetOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierTargetOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutStatus), TypeInfoPropertyName = "CompletionDetailedJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item5), TypeInfoPropertyName = "IntegrationsVariant1Item52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesItem2), TypeInfoPropertyName = "RepositoriesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType), TypeInfoPropertyName = "CompletionDetailedJobOutRepositorieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierFTModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FTModelCapabilitiesOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionFTModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UpdateFTModelIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ArchiveFTModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UnarchiveFTModelOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchJobStatus), TypeInfoPropertyName = "BatchJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.BatchError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchJobsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.BatchJobOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ApiEndpoint), TypeInfoPropertyName = "ApiEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchJobIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.BatchRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>), TypeInfoPropertyName = "AnyOfStringObjectIListContentChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ContentChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunk), TypeInfoPropertyName = "ContentChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, byte[]>), TypeInfoPropertyName = "AnyOfStringByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.MessagesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem), TypeInfoPropertyName = "MessagesItem4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionRequestMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionRequestMessageDiscriminatorRole), TypeInfoPropertyName = "ChatCompletionRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.Tool3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Tool3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>), TypeInfoPropertyName = "AnyOfToolChoice2ToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolChoice2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MistralPromptMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionRequestReasoningEffort), TypeInfoPropertyName = "ChatCompletionRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>>), TypeInfoPropertyName = "AnyOfIListInputVariant1ItemIListIListInputVariant2ItemItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InputVariant1Item), TypeInfoPropertyName = "InputVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole), TypeInfoPropertyName = "ChatModerationRequestInputVariant1ItemDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InputVariant2ItemItem), TypeInfoPropertyName = "InputVariant2ItemItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole), TypeInfoPropertyName = "ChatModerationRequestInputVariant2ItemItemDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddingDtype), TypeInfoPropertyName = "EmbeddingDtype2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EncodingFormat), TypeInfoPropertyName = "EncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FIMCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FileChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<object, string>), TypeInfoPropertyName = "AnyOfObjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InstructRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.MessagesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem2), TypeInfoPropertyName = "MessagesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InstructRequestMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InstructRequestMessageDiscriminatorRole), TypeInfoPropertyName = "InstructRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRPageDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRPageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OCRImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OCRTableObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRTableObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk>), TypeInfoPropertyName = "AnyOfFileChunkDocumentURLChunkImageURLChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRRequestTableFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OCRPageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRUsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRTableObjectFormat), TypeInfoPropertyName = "OCRTableObjectFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>>), TypeInfoPropertyName = "AnyOfStringIListSystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunks), TypeInfoPropertyName = "SystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolTypes), TypeInfoPropertyName = "ToolTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.TranscriptionSegmentChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionSegmentChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SpeechOutputFormat), TypeInfoPropertyName = "SpeechOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SpeechStreamAudioDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SpeechStreamDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SpeechStreamEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SpeechStreamEventsEvent), TypeInfoPropertyName = "SpeechStreamEventsEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Data2), TypeInfoPropertyName = "Data22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SpeechStreamEventsDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SpeechStreamEventsDataDiscriminatorType), TypeInfoPropertyName = "SpeechStreamEventsDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.VoiceCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.VoiceListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.VoiceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.VoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.VoiceUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TimestampGranularity), TypeInfoPropertyName = "TimestampGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.TimestampGranularity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioTranscriptionRequestStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamSegmentDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamTextDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamDone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamEventTypes), TypeInfoPropertyName = "TranscriptionStreamEventTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Data3), TypeInfoPropertyName = "Data32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamEventsDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamEventsDataDiscriminatorType), TypeInfoPropertyName = "TranscriptionStreamEventsDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionClientMessage), TypeInfoPropertyName = "RealtimeTranscriptionClientMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionSessionUpdateMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionInputAudioAppend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionInputAudioFlush))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionInputAudioEnd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionClientMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType), TypeInfoPropertyName = "RealtimeTranscriptionClientMessageDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioEncoding), TypeInfoPropertyName = "AudioEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionSessionUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentsCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.MessagesItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem3), TypeInfoPropertyName = "MessagesItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentsCompletionRequestMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentsCompletionRequestMessageDiscriminatorRole), TypeInfoPropertyName = "AgentsCompletionRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentsCompletionRequestReasoningEffort), TypeInfoPropertyName = "AgentsCompletionRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatClassificationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatClassificationRequestInputs), TypeInfoPropertyName = "ChatClassificationRequestInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.InstructRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassificationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::Mistral.ClassificationTargetResult>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Mistral.ClassificationTargetResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassificationTargetResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunkDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunkDiscriminatorType), TypeInfoPropertyName = "ContentChunkDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ModerationObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunksDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType), TypeInfoPropertyName = "SystemMessageContentChunksDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ProcessStatus), TypeInfoPropertyName = "ProcessStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentUpdateIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<bool>>), TypeInfoPropertyName = "AnyOfBooleanStringInt32DoubleDateTimeIListStringIListInt32IListDoubleIListBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterConditionOp), TypeInfoPropertyName = "FilterConditionOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>), TypeInfoPropertyName = "AnyOfFilterGroupFilterCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.LibraryIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.LibraryInUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.LibraryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListDocumentOut), TypeInfoPropertyName = "ListDocumentOut_Mistral_ListDocumentOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DocumentOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListLibraryOut), TypeInfoPropertyName = "ListLibraryOut_Mistral_ListLibraryOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.LibraryOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListSharingOut), TypeInfoPropertyName = "ListSharingOut_Mistral_ListSharingOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.SharingOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SharingOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ProcessingStatusOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ShareEnum), TypeInfoPropertyName = "ShareEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SharingDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EntityType), TypeInfoPropertyName = "EntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SharingIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseFieldDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseFieldDefinitionType), TypeInfoPropertyName = "BaseFieldDefinitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.BaseFieldDefinitionSupportedOperator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseFieldDefinitionSupportedOperator), TypeInfoPropertyName = "BaseFieldDefinitionSupportedOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseTaskStatus), TypeInfoPropertyName = "BaseTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CampaignPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgePreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CampaignPreviews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultCampaignPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CampaignSelectedEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultChatCompletionEventPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CampaignStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionEventIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfBooleanInt32DoubleStringDateTimeIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ChatTranscriptionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatTranscriptionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionEventPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FeedResultChatCompletionEventPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionFieldOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<string, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, bool?, object>), TypeInfoPropertyName = "AnyOfStringBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.BaseFieldDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.FieldGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FieldGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationSource), TypeInfoPropertyName = "ConversationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetExport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetImportTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetImportTasks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultDatasetImportTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetPreviews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultDatasetPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DatasetRecords))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultDatasetRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DeleteDatasetRecordsInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ChatCompletionEventPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FieldOptionCountItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FieldOptionCountsInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FieldOptionCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.FieldOptionCountItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition, object>), TypeInfoPropertyName = "AnyOfFilterGroupFilterConditionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GetChatCompletionEventIdsInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GetChatCompletionEventsInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeClassificationOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.JudgeClassificationOutputOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeClassificationOutputOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, double?>), TypeInfoPropertyName = "AnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeOutputType), TypeInfoPropertyName = "JudgeOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output), TypeInfoPropertyName = "Output4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeRegressionOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgePreviewOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgePreviewOutputDiscriminatorType), TypeInfoPropertyName = "JudgePreviewOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgePreviews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultJudgePreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.CampaignPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DatasetImportTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DatasetPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DatasetRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.JudgePreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PatchDatasetInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostCampaignInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostChatCompletionEventJudgingInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostJudgeInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetImportFromCampaignInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetImportFromDatasetInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetImportFromExplorerInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetImportFromFileInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetImportFromPlaygroundInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetRecordInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostDatasetRecordJudgingInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output2), TypeInfoPropertyName = "Output22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostJudgeInSchemaOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostJudgeInSchemaOutputDiscriminatorType), TypeInfoPropertyName = "PostJudgeInSchemaOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PutDatasetRecordPayloadInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PutDatasetRecordPropertiesInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PutJudgeInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output3), TypeInfoPropertyName = "Output32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PutJudgeInSchemaOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PutJudgeInSchemaOutputDiscriminatorType), TypeInfoPropertyName = "PutJudgeInSchemaOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ObservabilityErrorCode), TypeInfoPropertyName = "ObservabilityErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ObservabilityErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ObservabilityError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeConversationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Annotations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnnotationsAudienceVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnnotationsAudienceVariant1Item), TypeInfoPropertyName = "AnnotationsAudienceVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AuthData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BlobResourceContents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Connector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsSchemasApiToolTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsSchemasApiToolTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConnectorMCPCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResourceVisibility), TypeInfoPropertyName = "ResourceVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConnectorMCPUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConnectorSupportedLanguage), TypeInfoPropertyName = "ConnectorSupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConnectorsQueryFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddedResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextResourceContents, global::Mistral.BlobResourceContents>), TypeInfoPropertyName = "AnyOfTextResourceContentsBlobResourceContents2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TextResourceContents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ExecutionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPResultMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPToolCallMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPToolCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPToolCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>), TypeInfoPropertyName = "AnyOfTextContentImageContentAudioContentResourceLinkEmbeddedResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResourceLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.MCPServerIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPServerIcon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsSchemasTurbineToolLocale))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedConnectors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.Connector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.CompletionResponseStreamChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionResponseStreamChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DeltaMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionResponseStreamChoiceFinishReason), TypeInfoPropertyName = "CompletionResponseStreamChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionChoiceFinishReason), TypeInfoPropertyName = "ChatCompletionChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionResponseBase), TypeInfoPropertyName = "ChatCompletionResponseBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionResponse), TypeInfoPropertyName = "ChatCompletionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionResponseChatCompletionResponse1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FIMCompletionResponse), TypeInfoPropertyName = "FIMCompletionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FIMCompletionResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddingResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddingResponse), TypeInfoPropertyName = "EmbeddingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddingResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.EmbeddingResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ActivityTaskCompletedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ActivityTaskCompletedAttributesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JSONPayloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ActivityTaskFailedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ActivityTaskFailedAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Failure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ActivityTaskRetryingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ActivityTaskRetryingAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ActivityTaskStartedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ActivityTaskStartedAttributesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchExecutionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchExecutionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Mistral.BatchExecutionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchExecutionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskCanceledResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskCanceledAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskCompletedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskCompletedAttributesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskFailedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskFailedAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskInProgressResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskInProgressAttributesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Payload), TypeInfoPropertyName = "Payload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JSONPatchPayloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType), TypeInfoPropertyName = "CustomTaskInProgressAttributesResponsePayloadDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskStartedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskStartedAttributesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskTimedOutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskTimedOutAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DeploymentDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DeploymentWorkerResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DeploymentWorkerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DeploymentListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DeploymentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DeploymentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EncodedPayloadOptions), TypeInfoPropertyName = "EncodedPayloadOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EventProgressStatus), TypeInfoPropertyName = "EventProgressStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EventSource), TypeInfoPropertyName = "EventSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EventType), TypeInfoPropertyName = "EventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JSONPatchAdd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JSONPatchAppend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ValueItem), TypeInfoPropertyName = "ValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JSONPatchReplace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JSONPatchRemove))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp), TypeInfoPropertyName = "JSONPatchPayloadResponseValueItemDiscriminatorOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListWorkflowEventResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>), TypeInfoPropertyName = "OneOfWorkflowExecutionStartedResponseWorkflowExecutionCompletedResponseWorkflowExecutionFailedResponseWorkflowExecutionCanceledResponseWorkflowExecutionContinuedAsNewResponseWorkflowTaskTimedOutResponseWorkflowTaskFailedResponseCustomTaskStartedResponseCustomTaskInProgressResponseCustomTaskCompletedResponseCustomTaskFailedResponseCustomTaskTimedOutResponseCustomTaskCanceledResponseActivityTaskStartedResponseActivityTaskCompletedResponseActivityTaskRetryingResponseActivityTaskFailedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionStartedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionCompletedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionFailedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionCanceledResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionContinuedAsNewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowTaskTimedOutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowTaskFailedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.NetworkEncodedInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.EncodedPayloadOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.QueryDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.QueryInvocationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.NetworkEncodedInput, object, object>), TypeInfoPropertyName = "AnyOfNetworkEncodedInputObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.QueryWorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResetInvocationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ScalarMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<int?, double?>), TypeInfoPropertyName = "AnyOfInt32Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ScheduleCalendar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ScheduleRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ScheduleDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ScheduleCalendar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ScheduleInterval>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ScheduleInterval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SchedulePolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ScheduleDefinitionOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SignalDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SignalInvocationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SignalWorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.StreamEventSsePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.StreamEventWorkflowContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TempoGetTraceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.TempoTraceBatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TempoTraceBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TempoTraceAttribute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TempoTraceAttributeStringValue, global::Mistral.TempoTraceAttributeIntValue, global::Mistral.TempoTraceAttributeBoolValue>), TypeInfoPropertyName = "AnyOfTempoTraceAttributeStringValueTempoTraceAttributeIntValueTempoTraceAttributeBoolValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TempoTraceAttributeStringValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TempoTraceAttributeIntValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TempoTraceAttributeBoolValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TempoTraceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.TempoTraceScopeSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TempoTraceScopeSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TempoTraceEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.TempoTraceAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TempoTraceScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TempoTraceScopeKind), TypeInfoPropertyName = "TempoTraceScopeKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.TempoTraceSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TempoTraceSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.TempoTraceEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TimeSeriesMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UpdateDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UpdateInvocationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UpdateWorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkerInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Workflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowType), TypeInfoPropertyName = "WorkflowType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowArchiveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowBasicDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowCodeDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.SignalDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.QueryDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.UpdateDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowEventType), TypeInfoPropertyName = "WorkflowEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionCanceledAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionCompletedAttributesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionContinuedAsNewAttributesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionFailedAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionWithoutResultResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionWithoutResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionProgressTraceEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionTraceSummaryAttributesValues), TypeInfoPropertyName = "WorkflowExecutionTraceSummaryAttributesValues2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionStartedAttributesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionSyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionTraceEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionTraceEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.WorkflowExecutionTraceEvent, global::Mistral.WorkflowExecutionProgressTraceEvent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.WorkflowExecutionTraceEvent, global::Mistral.WorkflowExecutionProgressTraceEvent>), TypeInfoPropertyName = "AnyOfWorkflowExecutionTraceEventWorkflowExecutionProgressTraceEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionTraceOTelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionTraceSummaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionTraceSummarySpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionTraceEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionTraceSummarySpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowWithWorkerStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.WorkflowBasicDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowRegistration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowRegistrationGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowRegistrationWithWorkerStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowRegistrationListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.WorkflowRegistration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowScheduleListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ScheduleDefinitionOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowScheduleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowScheduleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowTaskFailedAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowTaskTimedOutAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowUnarchiveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilesApiRoutesUploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility), TypeInfoPropertyName = "FilesApiRoutesUploadFileRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.LibrariesDocumentsUploadV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.RequestSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<int?, string, object>), TypeInfoPropertyName = "AnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.SampleType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.BatchJobStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesBatchGetBatchJobsOrderBy), TypeInfoPropertyName = "JobsApiRoutesBatchGetBatchJobsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperator), TypeInfoPropertyName = "GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.JudgeOutputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.WorkflowExecutionStatus?, global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionStatus>, object>), TypeInfoPropertyName = "AnyOfWorkflowExecutionStatusIListWorkflowExecutionStatusObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope), TypeInfoPropertyName = "GetStreamEventsV1WorkflowsEventsStreamGetScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.WorkflowEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponse), TypeInfoPropertyName = "RetrieveModelV1ModelsModelIdGetResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType), TypeInfoPropertyName = "RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>), TypeInfoPropertyName = "AnyOfModelConversationAgentConversation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AgentAliasResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?, global::Mistral.LegacyJobMetadataOut>), TypeInfoPropertyName = "AnyOfJobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1LegacyJobMetadataOut2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1), TypeInfoPropertyName = "JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType), TypeInfoPropertyName = "JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponse), TypeInfoPropertyName = "JobsApiRoutesFineTuningGetFineTuningJobResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType), TypeInfoPropertyName = "JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponse), TypeInfoPropertyName = "JobsApiRoutesFineTuningCancelFineTuningJobResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType), TypeInfoPropertyName = "JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponse), TypeInfoPropertyName = "JobsApiRoutesFineTuningStartFineTuningJobResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType), TypeInfoPropertyName = "JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponse), TypeInfoPropertyName = "JobsApiRoutesFineTuningUpdateFineTunedModelResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType), TypeInfoPropertyName = "JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.StreamV1WorkflowsExecutionsExecutionIdStreamGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.WorkflowExecutionResponse, global::Mistral.WorkflowExecutionSyncResponse>), TypeInfoPropertyName = "AnyOfWorkflowExecutionResponseWorkflowExecutionSyncResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.GuardrailConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolCallConfirmation>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Tool3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::System.Collections.Generic.List<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Mistral.InputVariant2ItemItem>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.InputVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Mistral.InputVariant2ItemItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.InputVariant2ItemItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.MessagesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OCRImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OCRTableObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OCRPageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.List<global::Mistral.SystemMessageContentChunks>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.SystemMessageContentChunks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.TranscriptionSegmentChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.VoiceResponse>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ChatTranscriptionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<string, bool?, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.BaseFieldDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.FieldGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ChatCompletionEventPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.FieldOptionCountItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.JudgeClassificationOutputOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.CampaignPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DatasetImportTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DatasetPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DatasetRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.JudgePreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnnotationsAudienceVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.IntegrationsSchemasApiToolTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.MCPServerIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Connector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.CompletionResponseStreamChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.EmbeddingResponseData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DeploymentWorkerResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DeploymentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.EncodedPayloadOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ScheduleRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ScheduleCalendar>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ScheduleInterval>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.TempoTraceBatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.TempoTraceScopeSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.TempoTraceAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.TempoTraceSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.TempoTraceEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.SignalDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.QueryDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.UpdateDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.WorkflowExecutionWithoutResultResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.WorkflowExecutionTraceEvent, global::Mistral.WorkflowExecutionProgressTraceEvent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.WorkflowExecutionTraceEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.WorkflowExecutionTraceSummarySpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.WorkflowBasicDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.WorkflowRegistration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ScheduleDefinitionOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.RequestSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.SampleType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.BatchJobStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.JudgeOutputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.WorkflowExecutionStatus?, global::System.Collections.Generic.List<global::Mistral.WorkflowExecutionStatus>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.WorkflowExecutionStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.WorkflowEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AgentAliasResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}