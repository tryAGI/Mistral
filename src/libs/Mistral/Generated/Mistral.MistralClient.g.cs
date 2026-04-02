
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Our Chat Completion and Embeddings APIs specification. Create your account on [La Plateforme](https://console.mistral.ai) to get access and read the [docs](https://docs.mistral.ai) to learn how to use it.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class MistralClient : global::Mistral.IMistralClient, global::System.IDisposable
    {
        /// <summary>
        /// Production server
        /// </summary>
        public const string DefaultBaseUrl = "https://api.mistral.ai";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Mistral.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Mistral.JsonConverters.ModelListDataItemDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.ModelListDataItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.APIKeyAuthTypeJsonConverter(),
                    new global::Mistral.JsonConverters.APIKeyAuthTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.AgentToolDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.AgentToolDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.AgentCreationRequestToolDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.AgentCreationRequestToolDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.AgentUpdateRequestToolDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.AgentUpdateRequestToolDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.BuiltInConnectorsJsonConverter(),
                    new global::Mistral.JsonConverters.BuiltInConnectorsNullableJsonConverter(),
                    new global::Mistral.JsonConverters.CodeInterpreterToolTypeJsonConverter(),
                    new global::Mistral.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionArgsReasoningEffort2JsonConverter(),
                    new global::Mistral.JsonConverters.CompletionArgsReasoningEffort2NullableJsonConverter(),
                    new global::Mistral.JsonConverters.CustomConnectorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.CustomConnectorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.CustomConnectorAuthorizationVariant1DiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.CustomConnectorAuthorizationVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.DocumentLibraryToolTypeJsonConverter(),
                    new global::Mistral.JsonConverters.DocumentLibraryToolTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.FunctionCallEntryConfirmationStatus2JsonConverter(),
                    new global::Mistral.JsonConverters.FunctionCallEntryConfirmationStatus2NullableJsonConverter(),
                    new global::Mistral.JsonConverters.FunctionToolTypeJsonConverter(),
                    new global::Mistral.JsonConverters.FunctionToolTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ImageDetailJsonConverter(),
                    new global::Mistral.JsonConverters.ImageDetailNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ImageGenerationToolTypeJsonConverter(),
                    new global::Mistral.JsonConverters.ImageGenerationToolTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.MessageInputEntryRoleJsonConverter(),
                    new global::Mistral.JsonConverters.MessageInputEntryRoleNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ModelConversationToolDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.ModelConversationToolDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ModerationLLMActionJsonConverter(),
                    new global::Mistral.JsonConverters.ModerationLLMActionNullableJsonConverter(),
                    new global::Mistral.JsonConverters.OAuth2TokenAuthTypeJsonConverter(),
                    new global::Mistral.JsonConverters.OAuth2TokenAuthTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.RequestSourceJsonConverter(),
                    new global::Mistral.JsonConverters.RequestSourceNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ResponseFormatsJsonConverter(),
                    new global::Mistral.JsonConverters.ResponseFormatsNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ToolCallConfirmationConfirmationJsonConverter(),
                    new global::Mistral.JsonConverters.ToolCallConfirmationConfirmationNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ToolChoiceEnumJsonConverter(),
                    new global::Mistral.JsonConverters.ToolChoiceEnumNullableJsonConverter(),
                    new global::Mistral.JsonConverters.WebSearchPremiumToolTypeJsonConverter(),
                    new global::Mistral.JsonConverters.WebSearchPremiumToolTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.WebSearchToolTypeJsonConverter(),
                    new global::Mistral.JsonConverters.WebSearchToolTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.FunctionCallEventConfirmationStatus2JsonConverter(),
                    new global::Mistral.JsonConverters.FunctionCallEventConfirmationStatus2NullableJsonConverter(),
                    new global::Mistral.JsonConverters.SSETypesJsonConverter(),
                    new global::Mistral.JsonConverters.SSETypesNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationEventsDataDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationEventsDataDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationRequestBaseHandoffExecution2JsonConverter(),
                    new global::Mistral.JsonConverters.ConversationRequestBaseHandoffExecution2NullableJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationRequestBaseToolsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationRequestBaseToolsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationAppendRequestBaseHandoffExecutionJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationAppendRequestBaseHandoffExecutionNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationRestartRequestBaseHandoffExecutionJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationRestartRequestBaseHandoffExecutionNullableJsonConverter(),
                    new global::Mistral.JsonConverters.FilePurposeJsonConverter(),
                    new global::Mistral.JsonConverters.FilePurposeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.FileVisibilityJsonConverter(),
                    new global::Mistral.JsonConverters.FileVisibilityNullableJsonConverter(),
                    new global::Mistral.JsonConverters.SampleTypeJsonConverter(),
                    new global::Mistral.JsonConverters.SampleTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.SourceJsonConverter(),
                    new global::Mistral.JsonConverters.SourceNullableJsonConverter(),
                    new global::Mistral.JsonConverters.FineTuneableModelTypeJsonConverter(),
                    new global::Mistral.JsonConverters.FineTuneableModelTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ClassifierJobOutStatusJsonConverter(),
                    new global::Mistral.JsonConverters.ClassifierJobOutStatusNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionJobOutStatusJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionJobOutStatusNullableJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionJobOutRepositorieDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionJobOutRepositorieDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.JobsOutDataItemDiscriminatorJobTypeJsonConverter(),
                    new global::Mistral.JsonConverters.JobsOutDataItemDiscriminatorJobTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.FTClassifierLossFunctionJsonConverter(),
                    new global::Mistral.JsonConverters.FTClassifierLossFunctionNullableJsonConverter(),
                    new global::Mistral.JsonConverters.JobInIntegrationsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.JobInIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.JobInRepositoriesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.JobInRepositoriesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ClassifierDetailedJobOutStatusJsonConverter(),
                    new global::Mistral.JsonConverters.ClassifierDetailedJobOutStatusNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionDetailedJobOutStatusJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionDetailedJobOutStatusNullableJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionDetailedJobOutRepositorieDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionDetailedJobOutRepositorieDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.BatchJobStatusJsonConverter(),
                    new global::Mistral.JsonConverters.BatchJobStatusNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ApiEndpointJsonConverter(),
                    new global::Mistral.JsonConverters.ApiEndpointNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleJsonConverter(),
                    new global::Mistral.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ChatCompletionRequestReasoningEffortJsonConverter(),
                    new global::Mistral.JsonConverters.ChatCompletionRequestReasoningEffortNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ChatModerationRequestInputVariant1ItemDiscriminatorRoleJsonConverter(),
                    new global::Mistral.JsonConverters.ChatModerationRequestInputVariant1ItemDiscriminatorRoleNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ChatModerationRequestInputVariant2ItemItemDiscriminatorRoleJsonConverter(),
                    new global::Mistral.JsonConverters.ChatModerationRequestInputVariant2ItemItemDiscriminatorRoleNullableJsonConverter(),
                    new global::Mistral.JsonConverters.EmbeddingDtypeJsonConverter(),
                    new global::Mistral.JsonConverters.EmbeddingDtypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.EncodingFormatJsonConverter(),
                    new global::Mistral.JsonConverters.EncodingFormatNullableJsonConverter(),
                    new global::Mistral.JsonConverters.InstructRequestMessageDiscriminatorRoleJsonConverter(),
                    new global::Mistral.JsonConverters.InstructRequestMessageDiscriminatorRoleNullableJsonConverter(),
                    new global::Mistral.JsonConverters.MistralPromptModeJsonConverter(),
                    new global::Mistral.JsonConverters.MistralPromptModeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.OCRRequestTableFormat2JsonConverter(),
                    new global::Mistral.JsonConverters.OCRRequestTableFormat2NullableJsonConverter(),
                    new global::Mistral.JsonConverters.OCRTableObjectFormatJsonConverter(),
                    new global::Mistral.JsonConverters.OCRTableObjectFormatNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ToolTypesJsonConverter(),
                    new global::Mistral.JsonConverters.ToolTypesNullableJsonConverter(),
                    new global::Mistral.JsonConverters.SpeechOutputFormatJsonConverter(),
                    new global::Mistral.JsonConverters.SpeechOutputFormatNullableJsonConverter(),
                    new global::Mistral.JsonConverters.SpeechStreamEventsEventJsonConverter(),
                    new global::Mistral.JsonConverters.SpeechStreamEventsEventNullableJsonConverter(),
                    new global::Mistral.JsonConverters.SpeechStreamEventsDataDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.SpeechStreamEventsDataDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.TimestampGranularityJsonConverter(),
                    new global::Mistral.JsonConverters.TimestampGranularityNullableJsonConverter(),
                    new global::Mistral.JsonConverters.TranscriptionStreamEventsDataDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.TranscriptionStreamEventsDataDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.TranscriptionStreamEventTypesJsonConverter(),
                    new global::Mistral.JsonConverters.TranscriptionStreamEventTypesNullableJsonConverter(),
                    new global::Mistral.JsonConverters.RealtimeTranscriptionClientMessageDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.RealtimeTranscriptionClientMessageDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.AudioEncodingJsonConverter(),
                    new global::Mistral.JsonConverters.AudioEncodingNullableJsonConverter(),
                    new global::Mistral.JsonConverters.AgentsCompletionRequestMessageDiscriminatorRoleJsonConverter(),
                    new global::Mistral.JsonConverters.AgentsCompletionRequestMessageDiscriminatorRoleNullableJsonConverter(),
                    new global::Mistral.JsonConverters.AgentsCompletionRequestReasoningEffortJsonConverter(),
                    new global::Mistral.JsonConverters.AgentsCompletionRequestReasoningEffortNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ContentChunkDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.ContentChunkDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.SystemMessageContentChunksDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.SystemMessageContentChunksDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.FilterConditionOpJsonConverter(),
                    new global::Mistral.JsonConverters.FilterConditionOpNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ProcessStatusJsonConverter(),
                    new global::Mistral.JsonConverters.ProcessStatusNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ShareEnumJsonConverter(),
                    new global::Mistral.JsonConverters.ShareEnumNullableJsonConverter(),
                    new global::Mistral.JsonConverters.EntityTypeJsonConverter(),
                    new global::Mistral.JsonConverters.EntityTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.BaseFieldDefinitionTypeJsonConverter(),
                    new global::Mistral.JsonConverters.BaseFieldDefinitionTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.BaseFieldDefinitionSupportedOperatorJsonConverter(),
                    new global::Mistral.JsonConverters.BaseFieldDefinitionSupportedOperatorNullableJsonConverter(),
                    new global::Mistral.JsonConverters.BaseTaskStatusJsonConverter(),
                    new global::Mistral.JsonConverters.BaseTaskStatusNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationSourceJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationSourceNullableJsonConverter(),
                    new global::Mistral.JsonConverters.JudgeOutputTypeJsonConverter(),
                    new global::Mistral.JsonConverters.JudgeOutputTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.JudgePreviewOutputDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.JudgePreviewOutputDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.PostJudgeInSchemaOutputDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.PostJudgeInSchemaOutputDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.PutJudgeInSchemaOutputDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.PutJudgeInSchemaOutputDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ObservabilityErrorCodeJsonConverter(),
                    new global::Mistral.JsonConverters.ObservabilityErrorCodeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.AnnotationsAudienceVariant1ItemJsonConverter(),
                    new global::Mistral.JsonConverters.AnnotationsAudienceVariant1ItemNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ConnectorSupportedLanguageJsonConverter(),
                    new global::Mistral.JsonConverters.ConnectorSupportedLanguageNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ResourceVisibilityJsonConverter(),
                    new global::Mistral.JsonConverters.ResourceVisibilityNullableJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionResponseStreamChoiceFinishReasonJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionResponseStreamChoiceFinishReasonNullableJsonConverter(),
                    new global::Mistral.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter(),
                    new global::Mistral.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter(),
                    new global::Mistral.JsonConverters.CustomTaskInProgressAttributesResponsePayloadDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.CustomTaskInProgressAttributesResponsePayloadDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.EncodedPayloadOptionsJsonConverter(),
                    new global::Mistral.JsonConverters.EncodedPayloadOptionsNullableJsonConverter(),
                    new global::Mistral.JsonConverters.EventProgressStatusJsonConverter(),
                    new global::Mistral.JsonConverters.EventProgressStatusNullableJsonConverter(),
                    new global::Mistral.JsonConverters.EventSourceJsonConverter(),
                    new global::Mistral.JsonConverters.EventSourceNullableJsonConverter(),
                    new global::Mistral.JsonConverters.EventTypeJsonConverter(),
                    new global::Mistral.JsonConverters.EventTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.JSONPatchPayloadResponseValueItemDiscriminatorOpJsonConverter(),
                    new global::Mistral.JsonConverters.JSONPatchPayloadResponseValueItemDiscriminatorOpNullableJsonConverter(),
                    new global::Mistral.JsonConverters.TempoTraceScopeKindJsonConverter(),
                    new global::Mistral.JsonConverters.TempoTraceScopeKindNullableJsonConverter(),
                    new global::Mistral.JsonConverters.WorkflowEventTypeJsonConverter(),
                    new global::Mistral.JsonConverters.WorkflowEventTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.WorkflowExecutionStatusJsonConverter(),
                    new global::Mistral.JsonConverters.WorkflowExecutionStatusNullableJsonConverter(),
                    new global::Mistral.JsonConverters.WorkflowTypeJsonConverter(),
                    new global::Mistral.JsonConverters.WorkflowTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestVisibilityJsonConverter(),
                    new global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestVisibilityNullableJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatus2JsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatus2NullableJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesBatchGetBatchJobsOrderByJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesBatchGetBatchJobsOrderByNullableJsonConverter(),
                    new global::Mistral.JsonConverters.GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperatorJsonConverter(),
                    new global::Mistral.JsonConverters.GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperatorNullableJsonConverter(),
                    new global::Mistral.JsonConverters.GetStreamEventsV1WorkflowsEventsStreamGetScopeJsonConverter(),
                    new global::Mistral.JsonConverters.GetStreamEventsV1WorkflowsEventsStreamGetScopeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeJsonConverter(),
                    new global::Mistral.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobTypeJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobTypeJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobTypeJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobTypeJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelTypeJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelTypeNullableJsonConverter(),
                    new global::Mistral.JsonConverters.DataItemJsonConverter(),
                    new global::Mistral.JsonConverters.ToolsItemJsonConverter(),
                    new global::Mistral.JsonConverters.ToolsItem2JsonConverter(),
                    new global::Mistral.JsonConverters.ToolsItem3JsonConverter(),
                    new global::Mistral.JsonConverters.ConversationAppendRequestJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationRestartRequestJsonConverter(),
                    new global::Mistral.JsonConverters.AuthorizationVariant1JsonConverter(),
                    new global::Mistral.JsonConverters.ToolsItem4JsonConverter(),
                    new global::Mistral.JsonConverters.ConversationRequestJsonConverter(),
                    new global::Mistral.JsonConverters.DataJsonConverter(),
                    new global::Mistral.JsonConverters.OutputContentChunksJsonConverter(),
                    new global::Mistral.JsonConverters.CompletionArgsStopJsonConverter(),
                    new global::Mistral.JsonConverters.FunctionCallEntryArgumentsJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationInputsJsonConverter(),
                    new global::Mistral.JsonConverters.ToolsVariant1ItemJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationStreamRequestJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationAppendStreamRequestJsonConverter(),
                    new global::Mistral.JsonConverters.ConversationRestartStreamRequestJsonConverter(),
                    new global::Mistral.JsonConverters.IntegrationsVariant1ItemJsonConverter(),
                    new global::Mistral.JsonConverters.IntegrationsVariant1Item2JsonConverter(),
                    new global::Mistral.JsonConverters.RepositoriesItemJsonConverter(),
                    new global::Mistral.JsonConverters.DataItem2JsonConverter(),
                    new global::Mistral.JsonConverters.IntegrationsVariant1Item3JsonConverter(),
                    new global::Mistral.JsonConverters.RepositoriesVariant1ItemJsonConverter(),
                    new global::Mistral.JsonConverters.IntegrationsVariant1Item4JsonConverter(),
                    new global::Mistral.JsonConverters.IntegrationsVariant1Item5JsonConverter(),
                    new global::Mistral.JsonConverters.RepositoriesItem2JsonConverter(),
                    new global::Mistral.JsonConverters.MessagesItemJsonConverter(),
                    new global::Mistral.JsonConverters.InputVariant1ItemJsonConverter(),
                    new global::Mistral.JsonConverters.InputVariant2ItemItemJsonConverter(),
                    new global::Mistral.JsonConverters.MessagesItem2JsonConverter(),
                    new global::Mistral.JsonConverters.Data2JsonConverter(),
                    new global::Mistral.JsonConverters.Data3JsonConverter(),
                    new global::Mistral.JsonConverters.RealtimeTranscriptionClientMessageJsonConverter(),
                    new global::Mistral.JsonConverters.MessagesItem3JsonConverter(),
                    new global::Mistral.JsonConverters.ChatClassificationRequestInputsJsonConverter(),
                    new global::Mistral.JsonConverters.ContentChunkJsonConverter(),
                    new global::Mistral.JsonConverters.SystemMessageContentChunksJsonConverter(),
                    new global::Mistral.JsonConverters.OutputJsonConverter(),
                    new global::Mistral.JsonConverters.Output2JsonConverter(),
                    new global::Mistral.JsonConverters.Output3JsonConverter(),
                    new global::Mistral.JsonConverters.ChatCompletionResponseBaseJsonConverter(),
                    new global::Mistral.JsonConverters.ChatCompletionResponseJsonConverter(),
                    new global::Mistral.JsonConverters.FIMCompletionResponseJsonConverter(),
                    new global::Mistral.JsonConverters.EmbeddingResponseJsonConverter(),
                    new global::Mistral.JsonConverters.PayloadJsonConverter(),
                    new global::Mistral.JsonConverters.ValueItemJsonConverter(),
                    new global::Mistral.JsonConverters.WorkflowExecutionTraceSummaryAttributesValuesJsonConverter(),
                    new global::Mistral.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1JsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCancelFineTuningJobResponseJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseJsonConverter(),
                    new global::Mistral.JsonConverters.JobsApiRoutesFineTuningUpdateFineTunedModelResponseJsonConverter(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ImageURL, string>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>>>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::Mistral.OutputContentChunks?>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.CompletionTrainingParametersIn, global::Mistral.ClassifierTrainingParametersIn>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, byte[]>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<bool>>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, bool?, object>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition, object>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, double?>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextResourceContents, global::Mistral.BlobResourceContents>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>(),
                    new global::Mistral.JsonConverters.OneOfJsonConverter<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.NetworkEncodedInput, object, object>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<int?, double?>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.NetworkEncodedInput, object, object>(),
                    new global::Mistral.JsonConverters.OneOfJsonConverter<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TempoTraceAttributeStringValue, global::Mistral.TempoTraceAttributeIntValue, global::Mistral.TempoTraceAttributeBoolValue>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.NetworkEncodedInput, object, object>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.WorkflowExecutionTraceEvent, global::Mistral.WorkflowExecutionProgressTraceEvent>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.WorkflowExecutionStatus?, global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionStatus>, object>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ModelConversation, global::Mistral.AgentConversation>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ModelConversation, global::Mistral.AgentConversation>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?, global::Mistral.LegacyJobMetadataOut>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.WorkflowExecutionResponse, global::Mistral.WorkflowExecutionSyncResponse>(),
                    new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.WorkflowExecutionResponse, global::Mistral.WorkflowExecutionSyncResponse>(),
                    new global::Mistral.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// Speech API
        /// </summary>
        public AudioSpeechClient AudioSpeech => new AudioSpeechClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Transcriptions API
        /// </summary>
        public AudioTranscriptionsClient AudioTranscriptions => new AudioTranscriptionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Voices API
        /// </summary>
        public AudioVoicesClient AudioVoices => new AudioVoicesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Batch
        /// </summary>
        public BatchClient Batch => new BatchClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// (beta) Agents API
        /// </summary>
        public BetaAgentsClient BetaAgents => new BetaAgentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// (beta) Conversations API
        /// </summary>
        public BetaConversationsClient BetaConversations => new BetaConversationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// (beta) Libraries  API - Main
        /// </summary>
        public BetaLibrariesClient BetaLibraries => new BetaLibrariesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// (beta) Libraries  API - Access
        /// </summary>
        public BetaLibrariesAccessesClient BetaLibrariesAccesses => new BetaLibrariesAccessesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// (beta) Libraries  API - Documents
        /// </summary>
        public BetaLibrariesDocumentsClient BetaLibrariesDocuments => new BetaLibrariesDocumentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// (beta) Observability - Campaigns
        /// </summary>
        public BetaObservabilityCampaignsClient BetaObservabilityCampaigns => new BetaObservabilityCampaignsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// (beta) Observability - Chat completion events
        /// </summary>
        public BetaObservabilityChatCompletionEventsClient BetaObservabilityChatCompletionEvents => new BetaObservabilityChatCompletionEventsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// (beta) Observability - Chat completion fields
        /// </summary>
        public BetaObservabilityChatCompletionEventsFieldsClient BetaObservabilityChatCompletionEventsFields => new BetaObservabilityChatCompletionEventsFieldsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// (beta) Observability - Datasets
        /// </summary>
        public BetaObservabilityDatasetsClient BetaObservabilityDatasets => new BetaObservabilityDatasetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// (beta) Observability - Dataset records
        /// </summary>
        public BetaObservabilityDatasetsRecordsClient BetaObservabilityDatasetsRecords => new BetaObservabilityDatasetsRecordsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// (beta) Observability - Judges
        /// </summary>
        public BetaObservabilityJudgesClient BetaObservabilityJudges => new BetaObservabilityJudgesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Workflows
        /// </summary>
        public BetaWorkflowsClient BetaWorkflows => new BetaWorkflowsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Deployments
        /// </summary>
        public BetaWorkflowsDeploymentsClient BetaWorkflowsDeployments => new BetaWorkflowsDeploymentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Events
        /// </summary>
        public BetaWorkflowsEventsClient BetaWorkflowsEvents => new BetaWorkflowsEventsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Executions
        /// </summary>
        public BetaWorkflowsExecutionsClient BetaWorkflowsExecutions => new BetaWorkflowsExecutionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Metrics
        /// </summary>
        public BetaWorkflowsMetricsClient BetaWorkflowsMetrics => new BetaWorkflowsMetricsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Runs
        /// </summary>
        public BetaWorkflowsRunsClient BetaWorkflowsRuns => new BetaWorkflowsRunsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Schedules
        /// </summary>
        public BetaWorkflowsSchedulesClient BetaWorkflowsSchedules => new BetaWorkflowsSchedulesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Workers
        /// </summary>
        public BetaWorkflowsWorkersClient BetaWorkflowsWorkers => new BetaWorkflowsWorkersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Chat
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Classifiers
        /// </summary>
        public ClassifiersClient Classifiers => new ClassifiersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// (deprecated) Fine Tuning
        /// </summary>
        public DeprecatedFineTuningClient DeprecatedFineTuning => new DeprecatedFineTuningClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Embeddings
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Files
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// FIM
        /// </summary>
        public FimClient Fim => new FimClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Models
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// OCR API
        /// </summary>
        public OcrClient Ocr => new OcrClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the MistralClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public MistralClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Mistral.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Mistral.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}