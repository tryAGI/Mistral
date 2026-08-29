
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListDocumentOut), TypeInfoPropertyName = "ListDocumentOut_Mistral_ListDocumentOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListLibraryOut), TypeInfoPropertyName = "ListLibraryOut_Mistral_ListLibraryOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListSharingOut), TypeInfoPropertyName = "ListSharingOut_Mistral_ListSharingOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>>), TypeInfoPropertyName = "ActivityTaskFailedResponse_4eb8600ed13d6756")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>), TypeInfoPropertyName = "ActivityTaskFailedResponse_0bde6d32684fee68")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>?), TypeInfoPropertyName = "ActivityTaskFailedResponse_d33e2eb74053f9ed")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DocumentOut>), TypeInfoPropertyName = "ListDocumentOut_System_Collections_Generic_List_global_Mistral_DocumentOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.LibraryOut>), TypeInfoPropertyName = "ListLibraryOut_System_Collections_Generic_List_global_Mistral_LibraryOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.SharingOut>), TypeInfoPropertyName = "ListSharingOut_System_Collections_Generic_List_global_Mistral_SharingOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>>), TypeInfoPropertyName = "ActivityTaskFailedResponse_40289a742d078cef")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DataItem), TypeInfoPropertyName = "DataItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelListDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelListDataItemDiscriminatorType), TypeInfoPropertyName = "ModelListDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.APIKeyAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.APIKeyAuthType), TypeInfoPropertyName = "APIKeyAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem), TypeInfoPropertyName = "ToolsItem2_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentListPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.Agent>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsReasoningEffort2), TypeInfoPropertyName = "CompletionArgsReasoningEffort22")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEntryConfirmationStatus2), TypeInfoPropertyName = "FunctionCallEntryConfirmationStatus22")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEventConfirmationStatus2), TypeInfoPropertyName = "FunctionCallEventConfirmationStatus22")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Data), TypeInfoPropertyName = "Data2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationEventsDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationEventsDataDiscriminatorType), TypeInfoPropertyName = "ConversationEventsDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>), TypeInfoPropertyName = "AnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>), TypeInfoPropertyName = "AnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunkToolReferenceChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>), TypeInfoPropertyName = "AnyOfMessageInputEntryMessageOutputEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationInputs), TypeInfoPropertyName = "ConversationInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBaseHandoffExecution2), TypeInfoPropertyName = "ConversationRequestBaseHandoffExecution22")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item), TypeInfoPropertyName = "IntegrationsVariant1Item2_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesItem), TypeInfoPropertyName = "RepositoriesItem2_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FTClassifierLossFunction), TypeInfoPropertyName = "FTClassifierLossFunction2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem), TypeInfoPropertyName = "MessagesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionRequestMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionRequestMessageDiscriminatorRole), TypeInfoPropertyName = "ChatCompletionRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.Tool3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Tool3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>), TypeInfoPropertyName = "AnyOfToolChoice2ToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolChoice2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MistralPromptMode), TypeInfoPropertyName = "MistralPromptMode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRAsideTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRCaptionBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRCodeBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRConfidenceScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCREquationBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRFooterBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRHeaderBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRImageBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRImageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRListBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRPageConfidenceScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OCRConfidenceScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRPageDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRPageObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OCRImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OCRTableObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRTableObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.BlocksVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BlocksVariant1Item), TypeInfoPropertyName = "BlocksVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRTableBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRTitleBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRReferencesBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRSignatureBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType), TypeInfoPropertyName = "OCRPageObjectBlocksVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk>), TypeInfoPropertyName = "AnyOfFileChunkDocumentURLChunkImageURLChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<int>, object>), TypeInfoPropertyName = "AnyOfStringIListInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRRequestTableFormat2), TypeInfoPropertyName = "OCRRequestTableFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRRequestConfidenceScoresGranularity2), TypeInfoPropertyName = "OCRRequestConfidenceScoresGranularity22")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DocumentOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.LibraryOut>))]
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
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListDocumentOut), TypeInfoPropertyName = "ListDocumentOut_Mistral_ListDocumentOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListLibraryOut), TypeInfoPropertyName = "ListLibraryOut_Mistral_ListLibraryOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListSharingOut), TypeInfoPropertyName = "ListSharingOut_Mistral_ListSharingOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>>), TypeInfoPropertyName = "ActivityTaskFailedResponse_4eb8600ed13d6756")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>), TypeInfoPropertyName = "ActivityTaskFailedResponse_0bde6d32684fee68")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>?), TypeInfoPropertyName = "ActivityTaskFailedResponse_d33e2eb74053f9ed")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DocumentOut>), TypeInfoPropertyName = "ListDocumentOut_System_Collections_Generic_List_global_Mistral_DocumentOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.LibraryOut>), TypeInfoPropertyName = "ListLibraryOut_System_Collections_Generic_List_global_Mistral_LibraryOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.SharingOut>), TypeInfoPropertyName = "ListSharingOut_System_Collections_Generic_List_global_Mistral_SharingOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>>), TypeInfoPropertyName = "ActivityTaskFailedResponse_40289a742d078cef")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output), TypeInfoPropertyName = "Output2_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionStatus), TypeInfoPropertyName = "WorkflowExecutionStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AuthUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AuthenticationConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OutboundAuthenticationType), TypeInfoPropertyName = "OutboundAuthenticationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConnectionCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OAuth2Token))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConnectorAuthenticationHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CredentialsCreateOrUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CredentialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AuthenticationConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OutboundAuthenticationType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPSupportedLanguage), TypeInfoPropertyName = "MCPSupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolAnnotations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPToolMeta2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPUIToolMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TurbineToolMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.MCPUIToolMetaVisibilityVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPUIToolMetaVisibilityVariant1Item), TypeInfoPropertyName = "MCPUIToolMetaVisibilityVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PublicAuthenticationMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ConnectorAuthenticationHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecutionTaskSupport2), TypeInfoPropertyName = "ToolExecutionTaskSupport22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolType), TypeInfoPropertyName = "ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TurbineToolLocale))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilesApiRoutesUploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility), TypeInfoPropertyName = "FilesApiRoutesUploadFileRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.LibrariesDocumentsUploadV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.RequestSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<int?, string, object>), TypeInfoPropertyName = "AnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.SampleType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus2), TypeInfoPropertyName = "JobsApiRoutesFineTuningGetFineTuningJobsStatus22")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.IntegrationsSchemasApiToolTool>, global::System.Collections.Generic.IList<global::Mistral.MCPTool>, global::System.Collections.Generic.IList<object>>), TypeInfoPropertyName = "AnyOfIListIntegrationsSchemasApiToolToolIListMCPToolIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.MCPTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.PublicAuthenticationMethod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DataItem?), TypeInfoPropertyName = "NullableDataItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelListDataItemDiscriminatorType?), TypeInfoPropertyName = "NullableModelListDataItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.APIKeyAuthType?), TypeInfoPropertyName = "NullableAPIKeyAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem?), TypeInfoPropertyName = "NullableToolsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentToolDiscriminatorType?), TypeInfoPropertyName = "NullableAgentToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?, object>?), TypeInfoPropertyName = "NullableAnyOfStringInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem2?), TypeInfoPropertyName = "NullableToolsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentCreationRequestToolDiscriminatorType?), TypeInfoPropertyName = "NullableAgentCreationRequestToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem3?), TypeInfoPropertyName = "NullableToolsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentUpdateRequestToolDiscriminatorType?), TypeInfoPropertyName = "NullableAgentUpdateRequestToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BuiltInConnectors?), TypeInfoPropertyName = "NullableBuiltInConnectors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CodeInterpreterToolType?), TypeInfoPropertyName = "NullableCodeInterpreterToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsStop?), TypeInfoPropertyName = "NullableCompletionArgsStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolChoiceEnum?), TypeInfoPropertyName = "NullableToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsReasoningEffort2?), TypeInfoPropertyName = "NullableCompletionArgsReasoningEffort22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendRequest?), TypeInfoPropertyName = "NullableConversationAppendRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>?), TypeInfoPropertyName = "NullableAnyOfMessageInputEntryMessageOutputEntryFunctionResultEntryFunctionCallEntryToolExecutionEntryAgentHandoffEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartRequest?), TypeInfoPropertyName = "NullableConversationRestartRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorType?), TypeInfoPropertyName = "NullableCustomConnectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableCustomConnectorAuthorizationVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentLibraryToolType?), TypeInfoPropertyName = "NullableDocumentLibraryToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEntryArguments?), TypeInfoPropertyName = "NullableFunctionCallEntryArguments2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEntryConfirmationStatus2?), TypeInfoPropertyName = "NullableFunctionCallEntryConfirmationStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionToolType?), TypeInfoPropertyName = "NullableFunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageDetail?), TypeInfoPropertyName = "NullableImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageGenerationToolType?), TypeInfoPropertyName = "NullableImageGenerationToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ImageURL, string>?), TypeInfoPropertyName = "NullableAnyOfImageURLString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessageInputEntryRole?), TypeInfoPropertyName = "NullableMessageInputEntryRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>>?), TypeInfoPropertyName = "NullableAnyOfStringIListAnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>>>?), TypeInfoPropertyName = "NullableAnyOfStringIListAnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunkToolReferenceChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem4?), TypeInfoPropertyName = "NullableToolsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModelConversationToolDiscriminatorType?), TypeInfoPropertyName = "NullableModelConversationToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMAction?), TypeInfoPropertyName = "NullableModerationLLMAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OAuth2TokenAuthType?), TypeInfoPropertyName = "NullableOAuth2TokenAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RequestSource?), TypeInfoPropertyName = "NullableRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormats?), TypeInfoPropertyName = "NullableResponseFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>?), TypeInfoPropertyName = "NullableAnyOfTextChunkToolReferenceChunkReferenceChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolCallConfirmationConfirmation?), TypeInfoPropertyName = "NullableToolCallConfirmationConfirmation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.BuiltInConnectors?, string>?), TypeInfoPropertyName = "NullableAnyOfBuiltInConnectorsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchPremiumToolType?), TypeInfoPropertyName = "NullableWebSearchPremiumToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchToolType?), TypeInfoPropertyName = "NullableWebSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>?), TypeInfoPropertyName = "NullableAnyOfMessageOutputEntryToolExecutionEntryFunctionCallEntryAgentHandoffEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequest?), TypeInfoPropertyName = "NullableConversationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEventConfirmationStatus2?), TypeInfoPropertyName = "NullableFunctionCallEventConfirmationStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::Mistral.OutputContentChunks?>?), TypeInfoPropertyName = "NullableAnyOfStringOutputContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OutputContentChunks?), TypeInfoPropertyName = "NullableOutputContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SSETypes?), TypeInfoPropertyName = "NullableSSETypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Data?), TypeInfoPropertyName = "NullableData2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationEventsDataDiscriminatorType?), TypeInfoPropertyName = "NullableConversationEventsDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>?), TypeInfoPropertyName = "NullableAnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>?), TypeInfoPropertyName = "NullableAnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunkToolReferenceChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>?), TypeInfoPropertyName = "NullableAnyOfMessageInputEntryMessageOutputEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationInputs?), TypeInfoPropertyName = "NullableConversationInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBaseHandoffExecution2?), TypeInfoPropertyName = "NullableConversationRequestBaseHandoffExecution22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsVariant1Item?), TypeInfoPropertyName = "NullableToolsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBaseToolsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableConversationRequestBaseToolsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationStreamRequest?), TypeInfoPropertyName = "NullableConversationStreamRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendRequestBaseHandoffExecution?), TypeInfoPropertyName = "NullableConversationAppendRequestBaseHandoffExecution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendStreamRequest?), TypeInfoPropertyName = "NullableConversationAppendStreamRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartRequestBaseHandoffExecution?), TypeInfoPropertyName = "NullableConversationRestartRequestBaseHandoffExecution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartStreamRequest?), TypeInfoPropertyName = "NullableConversationRestartStreamRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilePurpose?), TypeInfoPropertyName = "NullableFilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FileVisibility?), TypeInfoPropertyName = "NullableFileVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SampleType?), TypeInfoPropertyName = "NullableSampleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Source?), TypeInfoPropertyName = "NullableSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FineTuneableModelType?), TypeInfoPropertyName = "NullableFineTuneableModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOutStatus?), TypeInfoPropertyName = "NullableClassifierJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item?), TypeInfoPropertyName = "NullableIntegrationsVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableClassifierJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutStatus?), TypeInfoPropertyName = "NullableCompletionJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item2?), TypeInfoPropertyName = "NullableIntegrationsVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableCompletionJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesItem?), TypeInfoPropertyName = "NullableRepositoriesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutRepositorieDiscriminatorType?), TypeInfoPropertyName = "NullableCompletionJobOutRepositorieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DataItem2?), TypeInfoPropertyName = "NullableDataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsOutDataItemDiscriminatorJobType?), TypeInfoPropertyName = "NullableJobsOutDataItemDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FTClassifierLossFunction?), TypeInfoPropertyName = "NullableFTClassifierLossFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item3?), TypeInfoPropertyName = "NullableIntegrationsVariant1Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableJobInIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.CompletionTrainingParametersIn, global::Mistral.ClassifierTrainingParametersIn>?), TypeInfoPropertyName = "NullableAnyOfCompletionTrainingParametersInClassifierTrainingParametersIn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesVariant1Item?), TypeInfoPropertyName = "NullableRepositoriesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableJobInRepositoriesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOutStatus?), TypeInfoPropertyName = "NullableClassifierDetailedJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item4?), TypeInfoPropertyName = "NullableIntegrationsVariant1Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutStatus?), TypeInfoPropertyName = "NullableCompletionDetailedJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item5?), TypeInfoPropertyName = "NullableIntegrationsVariant1Item52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableCompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesItem2?), TypeInfoPropertyName = "NullableRepositoriesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType?), TypeInfoPropertyName = "NullableCompletionDetailedJobOutRepositorieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BatchJobStatus?), TypeInfoPropertyName = "NullableBatchJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ApiEndpoint?), TypeInfoPropertyName = "NullableApiEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>?), TypeInfoPropertyName = "NullableAnyOfStringObjectIListContentChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunk?), TypeInfoPropertyName = "NullableContentChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, byte[]>?), TypeInfoPropertyName = "NullableAnyOfStringByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem?), TypeInfoPropertyName = "NullableMessagesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionRequestMessageDiscriminatorRole?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>?), TypeInfoPropertyName = "NullableAnyOfToolChoice2ToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MistralPromptMode?), TypeInfoPropertyName = "NullableMistralPromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionRequestReasoningEffort?), TypeInfoPropertyName = "NullableChatCompletionRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>>?), TypeInfoPropertyName = "NullableAnyOfIListInputVariant1ItemIListIListInputVariant2ItemItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InputVariant1Item?), TypeInfoPropertyName = "NullableInputVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole?), TypeInfoPropertyName = "NullableChatModerationRequestInputVariant1ItemDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InputVariant2ItemItem?), TypeInfoPropertyName = "NullableInputVariant2ItemItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole?), TypeInfoPropertyName = "NullableChatModerationRequestInputVariant2ItemItemDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddingDtype?), TypeInfoPropertyName = "NullableEmbeddingDtype2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EncodingFormat?), TypeInfoPropertyName = "NullableEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<object, string>?), TypeInfoPropertyName = "NullableAnyOfObjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem2?), TypeInfoPropertyName = "NullableMessagesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InstructRequestMessageDiscriminatorRole?), TypeInfoPropertyName = "NullableInstructRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BlocksVariant1Item?), TypeInfoPropertyName = "NullableBlocksVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableOCRPageObjectBlocksVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk>?), TypeInfoPropertyName = "NullableAnyOfFileChunkDocumentURLChunkImageURLChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<int>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRRequestTableFormat2?), TypeInfoPropertyName = "NullableOCRRequestTableFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRRequestConfidenceScoresGranularity2?), TypeInfoPropertyName = "NullableOCRRequestConfidenceScoresGranularity22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRTableObjectFormat?), TypeInfoPropertyName = "NullableOCRTableObjectFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>>?), TypeInfoPropertyName = "NullableAnyOfStringIListSystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunks?), TypeInfoPropertyName = "NullableSystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolTypes?), TypeInfoPropertyName = "NullableToolTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SpeechOutputFormat?), TypeInfoPropertyName = "NullableSpeechOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SpeechStreamEventsEvent?), TypeInfoPropertyName = "NullableSpeechStreamEventsEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Data2?), TypeInfoPropertyName = "NullableData22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SpeechStreamEventsDataDiscriminatorType?), TypeInfoPropertyName = "NullableSpeechStreamEventsDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TimestampGranularity?), TypeInfoPropertyName = "NullableTimestampGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamEventTypes?), TypeInfoPropertyName = "NullableTranscriptionStreamEventTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Data3?), TypeInfoPropertyName = "NullableData32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TranscriptionStreamEventsDataDiscriminatorType?), TypeInfoPropertyName = "NullableTranscriptionStreamEventsDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionClientMessage?), TypeInfoPropertyName = "NullableRealtimeTranscriptionClientMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType?), TypeInfoPropertyName = "NullableRealtimeTranscriptionClientMessageDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioEncoding?), TypeInfoPropertyName = "NullableAudioEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem3?), TypeInfoPropertyName = "NullableMessagesItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentsCompletionRequestMessageDiscriminatorRole?), TypeInfoPropertyName = "NullableAgentsCompletionRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentsCompletionRequestReasoningEffort?), TypeInfoPropertyName = "NullableAgentsCompletionRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatClassificationRequestInputs?), TypeInfoPropertyName = "NullableChatClassificationRequestInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunkDiscriminatorType?), TypeInfoPropertyName = "NullableContentChunkDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType?), TypeInfoPropertyName = "NullableSystemMessageContentChunksDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ProcessStatus?), TypeInfoPropertyName = "NullableProcessStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<bool>>?), TypeInfoPropertyName = "NullableAnyOfBooleanStringInt32DoubleDateTimeIListStringIListInt32IListDoubleIListBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterConditionOp?), TypeInfoPropertyName = "NullableFilterConditionOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>?), TypeInfoPropertyName = "NullableAnyOfFilterGroupFilterCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ShareEnum?), TypeInfoPropertyName = "NullableShareEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EntityType?), TypeInfoPropertyName = "NullableEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseFieldDefinitionType?), TypeInfoPropertyName = "NullableBaseFieldDefinitionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseFieldDefinitionSupportedOperator?), TypeInfoPropertyName = "NullableBaseFieldDefinitionSupportedOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseTaskStatus?), TypeInfoPropertyName = "NullableBaseTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>?), TypeInfoPropertyName = "NullableAnyOfBooleanInt32DoubleStringDateTimeIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringBooleanObject2")]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListDocumentOut), TypeInfoPropertyName = "ListDocumentOut_Mistral_ListDocumentOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListLibraryOut), TypeInfoPropertyName = "ListLibraryOut_Mistral_ListLibraryOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ListSharingOut), TypeInfoPropertyName = "ListSharingOut_Mistral_ListSharingOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>>), TypeInfoPropertyName = "ActivityTaskFailedResponse_4eb8600ed13d6756")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>), TypeInfoPropertyName = "ActivityTaskFailedResponse_0bde6d32684fee68")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>?), TypeInfoPropertyName = "ActivityTaskFailedResponse_d33e2eb74053f9ed")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DocumentOut>), TypeInfoPropertyName = "ListDocumentOut_System_Collections_Generic_List_global_Mistral_DocumentOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.LibraryOut>), TypeInfoPropertyName = "ListLibraryOut_System_Collections_Generic_List_global_Mistral_LibraryOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.SharingOut>), TypeInfoPropertyName = "ListSharingOut_System_Collections_Generic_List_global_Mistral_SharingOut")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>>), TypeInfoPropertyName = "ActivityTaskFailedResponse_40289a742d078cef")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationSource?), TypeInfoPropertyName = "NullableConversationSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition, object>?), TypeInfoPropertyName = "NullableAnyOfFilterGroupFilterConditionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, double?>?), TypeInfoPropertyName = "NullableAnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeOutputType?), TypeInfoPropertyName = "NullableJudgeOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output?), TypeInfoPropertyName = "NullableOutput2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgePreviewOutputDiscriminatorType?), TypeInfoPropertyName = "NullableJudgePreviewOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output2?), TypeInfoPropertyName = "NullableOutput22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostJudgeInSchemaOutputDiscriminatorType?), TypeInfoPropertyName = "NullablePostJudgeInSchemaOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output3?), TypeInfoPropertyName = "NullableOutput32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PutJudgeInSchemaOutputDiscriminatorType?), TypeInfoPropertyName = "NullablePutJudgeInSchemaOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ObservabilityErrorCode?), TypeInfoPropertyName = "NullableObservabilityErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnnotationsAudienceVariant1Item?), TypeInfoPropertyName = "NullableAnnotationsAudienceVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResourceVisibility?), TypeInfoPropertyName = "NullableResourceVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConnectorSupportedLanguage?), TypeInfoPropertyName = "NullableConnectorSupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextResourceContents, global::Mistral.BlobResourceContents>?), TypeInfoPropertyName = "NullableAnyOfTextResourceContentsBlobResourceContents2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>?), TypeInfoPropertyName = "NullableAnyOfTextContentImageContentAudioContentResourceLinkEmbeddedResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionResponseStreamChoiceFinishReason?), TypeInfoPropertyName = "NullableCompletionResponseStreamChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionChoiceFinishReason?), TypeInfoPropertyName = "NullableChatCompletionChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionResponseBase?), TypeInfoPropertyName = "NullableChatCompletionResponseBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionResponse?), TypeInfoPropertyName = "NullableChatCompletionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FIMCompletionResponse?), TypeInfoPropertyName = "NullableFIMCompletionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EmbeddingResponse?), TypeInfoPropertyName = "NullableEmbeddingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Payload?), TypeInfoPropertyName = "NullablePayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType?), TypeInfoPropertyName = "NullableCustomTaskInProgressAttributesResponsePayloadDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EncodedPayloadOptions?), TypeInfoPropertyName = "NullableEncodedPayloadOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EventProgressStatus?), TypeInfoPropertyName = "NullableEventProgressStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EventSource?), TypeInfoPropertyName = "NullableEventSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EventType?), TypeInfoPropertyName = "NullableEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ValueItem?), TypeInfoPropertyName = "NullableValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp?), TypeInfoPropertyName = "NullableJSONPatchPayloadResponseValueItemDiscriminatorOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.NetworkEncodedInput, object, object>?), TypeInfoPropertyName = "NullableAnyOfNetworkEncodedInputObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<int?, double?>?), TypeInfoPropertyName = "NullableAnyOfInt32Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TempoTraceAttributeStringValue, global::Mistral.TempoTraceAttributeIntValue, global::Mistral.TempoTraceAttributeBoolValue>?), TypeInfoPropertyName = "NullableAnyOfTempoTraceAttributeStringValueTempoTraceAttributeIntValueTempoTraceAttributeBoolValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TempoTraceScopeKind?), TypeInfoPropertyName = "NullableTempoTraceScopeKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowType?), TypeInfoPropertyName = "NullableWorkflowType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowEventType?), TypeInfoPropertyName = "NullableWorkflowEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionTraceSummaryAttributesValues?), TypeInfoPropertyName = "NullableWorkflowExecutionTraceSummaryAttributesValues2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionStatus?), TypeInfoPropertyName = "NullableWorkflowExecutionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.WorkflowExecutionTraceEvent, global::Mistral.WorkflowExecutionProgressTraceEvent>?), TypeInfoPropertyName = "NullableAnyOfWorkflowExecutionTraceEventWorkflowExecutionProgressTraceEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OutboundAuthenticationType?), TypeInfoPropertyName = "NullableOutboundAuthenticationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPSupportedLanguage?), TypeInfoPropertyName = "NullableMCPSupportedLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPUIToolMetaVisibilityVariant1Item?), TypeInfoPropertyName = "NullableMCPUIToolMetaVisibilityVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecutionTaskSupport2?), TypeInfoPropertyName = "NullableToolExecutionTaskSupport22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolType?), TypeInfoPropertyName = "NullableToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility?), TypeInfoPropertyName = "NullableFilesApiRoutesUploadFileRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<int?, string, object>?), TypeInfoPropertyName = "NullableAnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus2?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningGetFineTuningJobsStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesBatchGetBatchJobsOrderBy?), TypeInfoPropertyName = "NullableJobsApiRoutesBatchGetBatchJobsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperator?), TypeInfoPropertyName = "NullableGetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.WorkflowExecutionStatus?, global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionStatus>, object>?), TypeInfoPropertyName = "NullableAnyOfWorkflowExecutionStatusIListWorkflowExecutionStatusObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope?), TypeInfoPropertyName = "NullableGetStreamEventsV1WorkflowsEventsStreamGetScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponse?), TypeInfoPropertyName = "NullableRetrieveModelV1ModelsModelIdGetResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType?), TypeInfoPropertyName = "NullableRetrieveModelV1ModelsModelIdGetResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>?), TypeInfoPropertyName = "NullableAnyOfModelConversationAgentConversation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?, global::Mistral.LegacyJobMetadataOut>?), TypeInfoPropertyName = "NullableAnyOfJobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1LegacyJobMetadataOut2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningCreateFineTuningJobResponseVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponse?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningGetFineTuningJobResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponse?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningCancelFineTuningJobResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponse?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningStartFineTuningJobResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponse?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningUpdateFineTunedModelResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.WorkflowExecutionResponse, global::Mistral.WorkflowExecutionSyncResponse>?), TypeInfoPropertyName = "NullableAnyOfWorkflowExecutionResponseWorkflowExecutionSyncResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.IntegrationsSchemasApiToolTool>, global::System.Collections.Generic.IList<global::Mistral.MCPTool>, global::System.Collections.Generic.IList<object>>?), TypeInfoPropertyName = "NullableAnyOfIListIntegrationsSchemasApiToolToolIListMCPToolIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.GuardrailConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Agent>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OCRConfidenceScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OCRImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OCRTableObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.BlocksVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.List<int>, object>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AuthenticationConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OutboundAuthenticationType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.MCPUIToolMetaVisibilityVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ConnectorAuthenticationHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.RequestSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.SampleType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.BatchJobStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.JudgeOutputType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.WorkflowExecutionStatus?, global::System.Collections.Generic.List<global::Mistral.WorkflowExecutionStatus>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.WorkflowExecutionStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.WorkflowEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AgentAliasResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::System.Collections.Generic.List<global::Mistral.IntegrationsSchemasApiToolTool>, global::System.Collections.Generic.List<global::Mistral.MCPTool>, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.MCPTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.PublicAuthenticationMethod>))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Mistral.JsonConverters.DataItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ToolsItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ToolsItem2JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ToolsItem3JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ConversationAppendRequestJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ConversationRestartRequestJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.AuthorizationVariant1JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ToolsItem4JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ConversationRequestJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.DataJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.OutputContentChunksJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.CompletionArgsStopJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.FunctionCallEntryArgumentsJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ConversationInputsJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ToolsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ConversationStreamRequestJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ConversationAppendStreamRequestJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ConversationRestartStreamRequestJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.IntegrationsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.IntegrationsVariant1Item2JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.RepositoriesItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.DataItem2JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.IntegrationsVariant1Item3JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.RepositoriesVariant1ItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.IntegrationsVariant1Item4JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.IntegrationsVariant1Item5JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.RepositoriesItem2JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.MessagesItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.InputVariant1ItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.InputVariant2ItemItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.MessagesItem2JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.BlocksVariant1ItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.Data2JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.Data3JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.RealtimeTranscriptionClientMessageJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.MessagesItem3JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ChatClassificationRequestInputsJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ContentChunkJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.SystemMessageContentChunksJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.OutputJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.Output2JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.Output3JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ChatCompletionResponseBaseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ChatCompletionResponseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.FIMCompletionResponseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.EmbeddingResponseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.PayloadJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ValueItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.WorkflowExecutionTraceSummaryAttributesValuesJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCancelFineTuningJobResponseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.JobsApiRoutesFineTuningUpdateFineTunedModelResponseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ImageURL, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::Mistral.OutputContentChunks?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.CompletionTrainingParametersIn, global::Mistral.ClassifierTrainingParametersIn>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, byte[]>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<int>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<bool>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, bool?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextResourceContents, global::Mistral.BlobResourceContents>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>());
            options.Converters.Add(new global::Mistral.JsonConverters.OneOfJsonConverter<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.NetworkEncodedInput, object, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.NetworkEncodedInput, object, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.OneOfJsonConverter<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TempoTraceAttributeStringValue, global::Mistral.TempoTraceAttributeIntValue, global::Mistral.TempoTraceAttributeBoolValue>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.NetworkEncodedInput, object, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.WorkflowExecutionTraceEvent, global::Mistral.WorkflowExecutionProgressTraceEvent>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.WorkflowExecutionStatus?, global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionStatus>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ModelConversation, global::Mistral.AgentConversation>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ModelConversation, global::Mistral.AgentConversation>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?, global::Mistral.LegacyJobMetadataOut>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.WorkflowExecutionResponse, global::Mistral.WorkflowExecutionSyncResponse>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.WorkflowExecutionResponse, global::Mistral.WorkflowExecutionSyncResponse>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mistral.IntegrationsSchemasApiToolTool>, global::System.Collections.Generic.IList<global::Mistral.MCPTool>, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Mistral.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Mistral.ModelListDataItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.ModelListDataItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.APIKeyAuthType)

                    || typeToConvert == typeof(global::Mistral.APIKeyAuthType?)

                    || typeToConvert == typeof(global::Mistral.AgentToolDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.AgentToolDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.AgentCreationRequestToolDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.AgentCreationRequestToolDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.AgentUpdateRequestToolDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.AgentUpdateRequestToolDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.BuiltInConnectors)

                    || typeToConvert == typeof(global::Mistral.BuiltInConnectors?)

                    || typeToConvert == typeof(global::Mistral.CodeInterpreterToolType)

                    || typeToConvert == typeof(global::Mistral.CodeInterpreterToolType?)

                    || typeToConvert == typeof(global::Mistral.CompletionArgsReasoningEffort2)

                    || typeToConvert == typeof(global::Mistral.CompletionArgsReasoningEffort2?)

                    || typeToConvert == typeof(global::Mistral.CustomConnectorType)

                    || typeToConvert == typeof(global::Mistral.CustomConnectorType?)

                    || typeToConvert == typeof(global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.DocumentLibraryToolType)

                    || typeToConvert == typeof(global::Mistral.DocumentLibraryToolType?)

                    || typeToConvert == typeof(global::Mistral.FunctionCallEntryConfirmationStatus2)

                    || typeToConvert == typeof(global::Mistral.FunctionCallEntryConfirmationStatus2?)

                    || typeToConvert == typeof(global::Mistral.FunctionToolType)

                    || typeToConvert == typeof(global::Mistral.FunctionToolType?)

                    || typeToConvert == typeof(global::Mistral.ImageDetail)

                    || typeToConvert == typeof(global::Mistral.ImageDetail?)

                    || typeToConvert == typeof(global::Mistral.ImageGenerationToolType)

                    || typeToConvert == typeof(global::Mistral.ImageGenerationToolType?)

                    || typeToConvert == typeof(global::Mistral.MessageInputEntryRole)

                    || typeToConvert == typeof(global::Mistral.MessageInputEntryRole?)

                    || typeToConvert == typeof(global::Mistral.ModelConversationToolDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.ModelConversationToolDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.ModerationLLMAction)

                    || typeToConvert == typeof(global::Mistral.ModerationLLMAction?)

                    || typeToConvert == typeof(global::Mistral.OAuth2TokenAuthType)

                    || typeToConvert == typeof(global::Mistral.OAuth2TokenAuthType?)

                    || typeToConvert == typeof(global::Mistral.RequestSource)

                    || typeToConvert == typeof(global::Mistral.RequestSource?)

                    || typeToConvert == typeof(global::Mistral.ResponseFormats)

                    || typeToConvert == typeof(global::Mistral.ResponseFormats?)

                    || typeToConvert == typeof(global::Mistral.ToolCallConfirmationConfirmation)

                    || typeToConvert == typeof(global::Mistral.ToolCallConfirmationConfirmation?)

                    || typeToConvert == typeof(global::Mistral.ToolChoiceEnum)

                    || typeToConvert == typeof(global::Mistral.ToolChoiceEnum?)

                    || typeToConvert == typeof(global::Mistral.WebSearchPremiumToolType)

                    || typeToConvert == typeof(global::Mistral.WebSearchPremiumToolType?)

                    || typeToConvert == typeof(global::Mistral.WebSearchToolType)

                    || typeToConvert == typeof(global::Mistral.WebSearchToolType?)

                    || typeToConvert == typeof(global::Mistral.FunctionCallEventConfirmationStatus2)

                    || typeToConvert == typeof(global::Mistral.FunctionCallEventConfirmationStatus2?)

                    || typeToConvert == typeof(global::Mistral.SSETypes)

                    || typeToConvert == typeof(global::Mistral.SSETypes?)

                    || typeToConvert == typeof(global::Mistral.ConversationEventsDataDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.ConversationEventsDataDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.ConversationRequestBaseHandoffExecution2)

                    || typeToConvert == typeof(global::Mistral.ConversationRequestBaseHandoffExecution2?)

                    || typeToConvert == typeof(global::Mistral.ConversationRequestBaseToolsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.ConversationRequestBaseToolsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.ConversationAppendRequestBaseHandoffExecution)

                    || typeToConvert == typeof(global::Mistral.ConversationAppendRequestBaseHandoffExecution?)

                    || typeToConvert == typeof(global::Mistral.ConversationRestartRequestBaseHandoffExecution)

                    || typeToConvert == typeof(global::Mistral.ConversationRestartRequestBaseHandoffExecution?)

                    || typeToConvert == typeof(global::Mistral.FilePurpose)

                    || typeToConvert == typeof(global::Mistral.FilePurpose?)

                    || typeToConvert == typeof(global::Mistral.FileVisibility)

                    || typeToConvert == typeof(global::Mistral.FileVisibility?)

                    || typeToConvert == typeof(global::Mistral.SampleType)

                    || typeToConvert == typeof(global::Mistral.SampleType?)

                    || typeToConvert == typeof(global::Mistral.Source)

                    || typeToConvert == typeof(global::Mistral.Source?)

                    || typeToConvert == typeof(global::Mistral.FineTuneableModelType)

                    || typeToConvert == typeof(global::Mistral.FineTuneableModelType?)

                    || typeToConvert == typeof(global::Mistral.ClassifierJobOutStatus)

                    || typeToConvert == typeof(global::Mistral.ClassifierJobOutStatus?)

                    || typeToConvert == typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.CompletionJobOutStatus)

                    || typeToConvert == typeof(global::Mistral.CompletionJobOutStatus?)

                    || typeToConvert == typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.CompletionJobOutRepositorieDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.CompletionJobOutRepositorieDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.JobsOutDataItemDiscriminatorJobType)

                    || typeToConvert == typeof(global::Mistral.JobsOutDataItemDiscriminatorJobType?)

                    || typeToConvert == typeof(global::Mistral.FTClassifierLossFunction)

                    || typeToConvert == typeof(global::Mistral.FTClassifierLossFunction?)

                    || typeToConvert == typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutStatus)

                    || typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutStatus?)

                    || typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutStatus)

                    || typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutStatus?)

                    || typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.BatchJobStatus)

                    || typeToConvert == typeof(global::Mistral.BatchJobStatus?)

                    || typeToConvert == typeof(global::Mistral.ApiEndpoint)

                    || typeToConvert == typeof(global::Mistral.ApiEndpoint?)

                    || typeToConvert == typeof(global::Mistral.ChatCompletionRequestMessageDiscriminatorRole)

                    || typeToConvert == typeof(global::Mistral.ChatCompletionRequestMessageDiscriminatorRole?)

                    || typeToConvert == typeof(global::Mistral.ChatCompletionRequestReasoningEffort)

                    || typeToConvert == typeof(global::Mistral.ChatCompletionRequestReasoningEffort?)

                    || typeToConvert == typeof(global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole)

                    || typeToConvert == typeof(global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole?)

                    || typeToConvert == typeof(global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole)

                    || typeToConvert == typeof(global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole?)

                    || typeToConvert == typeof(global::Mistral.EmbeddingDtype)

                    || typeToConvert == typeof(global::Mistral.EmbeddingDtype?)

                    || typeToConvert == typeof(global::Mistral.EncodingFormat)

                    || typeToConvert == typeof(global::Mistral.EncodingFormat?)

                    || typeToConvert == typeof(global::Mistral.InstructRequestMessageDiscriminatorRole)

                    || typeToConvert == typeof(global::Mistral.InstructRequestMessageDiscriminatorRole?)

                    || typeToConvert == typeof(global::Mistral.MistralPromptMode)

                    || typeToConvert == typeof(global::Mistral.MistralPromptMode?)

                    || typeToConvert == typeof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.OCRRequestTableFormat2)

                    || typeToConvert == typeof(global::Mistral.OCRRequestTableFormat2?)

                    || typeToConvert == typeof(global::Mistral.OCRRequestConfidenceScoresGranularity2)

                    || typeToConvert == typeof(global::Mistral.OCRRequestConfidenceScoresGranularity2?)

                    || typeToConvert == typeof(global::Mistral.OCRTableObjectFormat)

                    || typeToConvert == typeof(global::Mistral.OCRTableObjectFormat?)

                    || typeToConvert == typeof(global::Mistral.ToolTypes)

                    || typeToConvert == typeof(global::Mistral.ToolTypes?)

                    || typeToConvert == typeof(global::Mistral.SpeechOutputFormat)

                    || typeToConvert == typeof(global::Mistral.SpeechOutputFormat?)

                    || typeToConvert == typeof(global::Mistral.SpeechStreamEventsEvent)

                    || typeToConvert == typeof(global::Mistral.SpeechStreamEventsEvent?)

                    || typeToConvert == typeof(global::Mistral.SpeechStreamEventsDataDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.SpeechStreamEventsDataDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.TimestampGranularity)

                    || typeToConvert == typeof(global::Mistral.TimestampGranularity?)

                    || typeToConvert == typeof(global::Mistral.TranscriptionStreamEventsDataDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.TranscriptionStreamEventsDataDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.TranscriptionStreamEventTypes)

                    || typeToConvert == typeof(global::Mistral.TranscriptionStreamEventTypes?)

                    || typeToConvert == typeof(global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.AudioEncoding)

                    || typeToConvert == typeof(global::Mistral.AudioEncoding?)

                    || typeToConvert == typeof(global::Mistral.AgentsCompletionRequestMessageDiscriminatorRole)

                    || typeToConvert == typeof(global::Mistral.AgentsCompletionRequestMessageDiscriminatorRole?)

                    || typeToConvert == typeof(global::Mistral.AgentsCompletionRequestReasoningEffort)

                    || typeToConvert == typeof(global::Mistral.AgentsCompletionRequestReasoningEffort?)

                    || typeToConvert == typeof(global::Mistral.ContentChunkDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.ContentChunkDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.FilterConditionOp)

                    || typeToConvert == typeof(global::Mistral.FilterConditionOp?)

                    || typeToConvert == typeof(global::Mistral.ProcessStatus)

                    || typeToConvert == typeof(global::Mistral.ProcessStatus?)

                    || typeToConvert == typeof(global::Mistral.ShareEnum)

                    || typeToConvert == typeof(global::Mistral.ShareEnum?)

                    || typeToConvert == typeof(global::Mistral.EntityType)

                    || typeToConvert == typeof(global::Mistral.EntityType?)

                    || typeToConvert == typeof(global::Mistral.BaseFieldDefinitionType)

                    || typeToConvert == typeof(global::Mistral.BaseFieldDefinitionType?)

                    || typeToConvert == typeof(global::Mistral.BaseFieldDefinitionSupportedOperator)

                    || typeToConvert == typeof(global::Mistral.BaseFieldDefinitionSupportedOperator?)

                    || typeToConvert == typeof(global::Mistral.BaseTaskStatus)

                    || typeToConvert == typeof(global::Mistral.BaseTaskStatus?)

                    || typeToConvert == typeof(global::Mistral.ConversationSource)

                    || typeToConvert == typeof(global::Mistral.ConversationSource?)

                    || typeToConvert == typeof(global::Mistral.JudgeOutputType)

                    || typeToConvert == typeof(global::Mistral.JudgeOutputType?)

                    || typeToConvert == typeof(global::Mistral.JudgePreviewOutputDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.JudgePreviewOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.PostJudgeInSchemaOutputDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.PostJudgeInSchemaOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.PutJudgeInSchemaOutputDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.PutJudgeInSchemaOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.ObservabilityErrorCode)

                    || typeToConvert == typeof(global::Mistral.ObservabilityErrorCode?)

                    || typeToConvert == typeof(global::Mistral.AnnotationsAudienceVariant1Item)

                    || typeToConvert == typeof(global::Mistral.AnnotationsAudienceVariant1Item?)

                    || typeToConvert == typeof(global::Mistral.ConnectorSupportedLanguage)

                    || typeToConvert == typeof(global::Mistral.ConnectorSupportedLanguage?)

                    || typeToConvert == typeof(global::Mistral.ResourceVisibility)

                    || typeToConvert == typeof(global::Mistral.ResourceVisibility?)

                    || typeToConvert == typeof(global::Mistral.CompletionResponseStreamChoiceFinishReason)

                    || typeToConvert == typeof(global::Mistral.CompletionResponseStreamChoiceFinishReason?)

                    || typeToConvert == typeof(global::Mistral.ChatCompletionChoiceFinishReason)

                    || typeToConvert == typeof(global::Mistral.ChatCompletionChoiceFinishReason?)

                    || typeToConvert == typeof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.EncodedPayloadOptions)

                    || typeToConvert == typeof(global::Mistral.EncodedPayloadOptions?)

                    || typeToConvert == typeof(global::Mistral.EventProgressStatus)

                    || typeToConvert == typeof(global::Mistral.EventProgressStatus?)

                    || typeToConvert == typeof(global::Mistral.EventSource)

                    || typeToConvert == typeof(global::Mistral.EventSource?)

                    || typeToConvert == typeof(global::Mistral.EventType)

                    || typeToConvert == typeof(global::Mistral.EventType?)

                    || typeToConvert == typeof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp)

                    || typeToConvert == typeof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp?)

                    || typeToConvert == typeof(global::Mistral.TempoTraceScopeKind)

                    || typeToConvert == typeof(global::Mistral.TempoTraceScopeKind?)

                    || typeToConvert == typeof(global::Mistral.WorkflowEventType)

                    || typeToConvert == typeof(global::Mistral.WorkflowEventType?)

                    || typeToConvert == typeof(global::Mistral.WorkflowExecutionStatus)

                    || typeToConvert == typeof(global::Mistral.WorkflowExecutionStatus?)

                    || typeToConvert == typeof(global::Mistral.WorkflowType)

                    || typeToConvert == typeof(global::Mistral.WorkflowType?)

                    || typeToConvert == typeof(global::Mistral.MCPSupportedLanguage)

                    || typeToConvert == typeof(global::Mistral.MCPSupportedLanguage?)

                    || typeToConvert == typeof(global::Mistral.MCPUIToolMetaVisibilityVariant1Item)

                    || typeToConvert == typeof(global::Mistral.MCPUIToolMetaVisibilityVariant1Item?)

                    || typeToConvert == typeof(global::Mistral.OutboundAuthenticationType)

                    || typeToConvert == typeof(global::Mistral.OutboundAuthenticationType?)

                    || typeToConvert == typeof(global::Mistral.ToolExecutionTaskSupport2)

                    || typeToConvert == typeof(global::Mistral.ToolExecutionTaskSupport2?)

                    || typeToConvert == typeof(global::Mistral.ToolType)

                    || typeToConvert == typeof(global::Mistral.ToolType?)

                    || typeToConvert == typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility)

                    || typeToConvert == typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility?)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus2)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus2?)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesBatchGetBatchJobsOrderBy)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesBatchGetBatchJobsOrderBy?)

                    || typeToConvert == typeof(global::Mistral.GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperator)

                    || typeToConvert == typeof(global::Mistral.GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperator?)

                    || typeToConvert == typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope)

                    || typeToConvert == typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope?)

                    || typeToConvert == typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType?)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType?)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType?)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType?)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Mistral.ModelListDataItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.ModelListDataItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ModelListDataItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.ModelListDataItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.APIKeyAuthType))
                {
                    return new global::Mistral.JsonConverters.APIKeyAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.APIKeyAuthType?))
                {
                    return new global::Mistral.JsonConverters.APIKeyAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AgentToolDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.AgentToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AgentToolDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.AgentToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AgentCreationRequestToolDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.AgentCreationRequestToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AgentCreationRequestToolDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.AgentCreationRequestToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AgentUpdateRequestToolDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.AgentUpdateRequestToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AgentUpdateRequestToolDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.AgentUpdateRequestToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.BuiltInConnectors))
                {
                    return new global::Mistral.JsonConverters.BuiltInConnectorsJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.BuiltInConnectors?))
                {
                    return new global::Mistral.JsonConverters.BuiltInConnectorsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CodeInterpreterToolType))
                {
                    return new global::Mistral.JsonConverters.CodeInterpreterToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CodeInterpreterToolType?))
                {
                    return new global::Mistral.JsonConverters.CodeInterpreterToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionArgsReasoningEffort2))
                {
                    return new global::Mistral.JsonConverters.CompletionArgsReasoningEffort2JsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionArgsReasoningEffort2?))
                {
                    return new global::Mistral.JsonConverters.CompletionArgsReasoningEffort2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CustomConnectorType))
                {
                    return new global::Mistral.JsonConverters.CustomConnectorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CustomConnectorType?))
                {
                    return new global::Mistral.JsonConverters.CustomConnectorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.CustomConnectorAuthorizationVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.CustomConnectorAuthorizationVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.DocumentLibraryToolType))
                {
                    return new global::Mistral.JsonConverters.DocumentLibraryToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.DocumentLibraryToolType?))
                {
                    return new global::Mistral.JsonConverters.DocumentLibraryToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FunctionCallEntryConfirmationStatus2))
                {
                    return new global::Mistral.JsonConverters.FunctionCallEntryConfirmationStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FunctionCallEntryConfirmationStatus2?))
                {
                    return new global::Mistral.JsonConverters.FunctionCallEntryConfirmationStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FunctionToolType))
                {
                    return new global::Mistral.JsonConverters.FunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FunctionToolType?))
                {
                    return new global::Mistral.JsonConverters.FunctionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ImageDetail))
                {
                    return new global::Mistral.JsonConverters.ImageDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ImageDetail?))
                {
                    return new global::Mistral.JsonConverters.ImageDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ImageGenerationToolType))
                {
                    return new global::Mistral.JsonConverters.ImageGenerationToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ImageGenerationToolType?))
                {
                    return new global::Mistral.JsonConverters.ImageGenerationToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.MessageInputEntryRole))
                {
                    return new global::Mistral.JsonConverters.MessageInputEntryRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.MessageInputEntryRole?))
                {
                    return new global::Mistral.JsonConverters.MessageInputEntryRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ModelConversationToolDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.ModelConversationToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ModelConversationToolDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.ModelConversationToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ModerationLLMAction))
                {
                    return new global::Mistral.JsonConverters.ModerationLLMActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ModerationLLMAction?))
                {
                    return new global::Mistral.JsonConverters.ModerationLLMActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OAuth2TokenAuthType))
                {
                    return new global::Mistral.JsonConverters.OAuth2TokenAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OAuth2TokenAuthType?))
                {
                    return new global::Mistral.JsonConverters.OAuth2TokenAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.RequestSource))
                {
                    return new global::Mistral.JsonConverters.RequestSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.RequestSource?))
                {
                    return new global::Mistral.JsonConverters.RequestSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ResponseFormats))
                {
                    return new global::Mistral.JsonConverters.ResponseFormatsJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ResponseFormats?))
                {
                    return new global::Mistral.JsonConverters.ResponseFormatsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolCallConfirmationConfirmation))
                {
                    return new global::Mistral.JsonConverters.ToolCallConfirmationConfirmationJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolCallConfirmationConfirmation?))
                {
                    return new global::Mistral.JsonConverters.ToolCallConfirmationConfirmationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolChoiceEnum))
                {
                    return new global::Mistral.JsonConverters.ToolChoiceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolChoiceEnum?))
                {
                    return new global::Mistral.JsonConverters.ToolChoiceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.WebSearchPremiumToolType))
                {
                    return new global::Mistral.JsonConverters.WebSearchPremiumToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.WebSearchPremiumToolType?))
                {
                    return new global::Mistral.JsonConverters.WebSearchPremiumToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.WebSearchToolType))
                {
                    return new global::Mistral.JsonConverters.WebSearchToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.WebSearchToolType?))
                {
                    return new global::Mistral.JsonConverters.WebSearchToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FunctionCallEventConfirmationStatus2))
                {
                    return new global::Mistral.JsonConverters.FunctionCallEventConfirmationStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FunctionCallEventConfirmationStatus2?))
                {
                    return new global::Mistral.JsonConverters.FunctionCallEventConfirmationStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.SSETypes))
                {
                    return new global::Mistral.JsonConverters.SSETypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.SSETypes?))
                {
                    return new global::Mistral.JsonConverters.SSETypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConversationEventsDataDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.ConversationEventsDataDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConversationEventsDataDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.ConversationEventsDataDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConversationRequestBaseHandoffExecution2))
                {
                    return new global::Mistral.JsonConverters.ConversationRequestBaseHandoffExecution2JsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConversationRequestBaseHandoffExecution2?))
                {
                    return new global::Mistral.JsonConverters.ConversationRequestBaseHandoffExecution2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConversationRequestBaseToolsVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.ConversationRequestBaseToolsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConversationRequestBaseToolsVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.ConversationRequestBaseToolsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConversationAppendRequestBaseHandoffExecution))
                {
                    return new global::Mistral.JsonConverters.ConversationAppendRequestBaseHandoffExecutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConversationAppendRequestBaseHandoffExecution?))
                {
                    return new global::Mistral.JsonConverters.ConversationAppendRequestBaseHandoffExecutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConversationRestartRequestBaseHandoffExecution))
                {
                    return new global::Mistral.JsonConverters.ConversationRestartRequestBaseHandoffExecutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConversationRestartRequestBaseHandoffExecution?))
                {
                    return new global::Mistral.JsonConverters.ConversationRestartRequestBaseHandoffExecutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FilePurpose))
                {
                    return new global::Mistral.JsonConverters.FilePurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FilePurpose?))
                {
                    return new global::Mistral.JsonConverters.FilePurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FileVisibility))
                {
                    return new global::Mistral.JsonConverters.FileVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FileVisibility?))
                {
                    return new global::Mistral.JsonConverters.FileVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.SampleType))
                {
                    return new global::Mistral.JsonConverters.SampleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.SampleType?))
                {
                    return new global::Mistral.JsonConverters.SampleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.Source))
                {
                    return new global::Mistral.JsonConverters.SourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.Source?))
                {
                    return new global::Mistral.JsonConverters.SourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FineTuneableModelType))
                {
                    return new global::Mistral.JsonConverters.FineTuneableModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FineTuneableModelType?))
                {
                    return new global::Mistral.JsonConverters.FineTuneableModelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierJobOutStatus))
                {
                    return new global::Mistral.JsonConverters.ClassifierJobOutStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierJobOutStatus?))
                {
                    return new global::Mistral.JsonConverters.ClassifierJobOutStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionJobOutStatus))
                {
                    return new global::Mistral.JsonConverters.CompletionJobOutStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionJobOutStatus?))
                {
                    return new global::Mistral.JsonConverters.CompletionJobOutStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.CompletionJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.CompletionJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionJobOutRepositorieDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.CompletionJobOutRepositorieDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionJobOutRepositorieDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.CompletionJobOutRepositorieDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsOutDataItemDiscriminatorJobType))
                {
                    return new global::Mistral.JsonConverters.JobsOutDataItemDiscriminatorJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsOutDataItemDiscriminatorJobType?))
                {
                    return new global::Mistral.JsonConverters.JobsOutDataItemDiscriminatorJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FTClassifierLossFunction))
                {
                    return new global::Mistral.JsonConverters.FTClassifierLossFunctionJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FTClassifierLossFunction?))
                {
                    return new global::Mistral.JsonConverters.FTClassifierLossFunctionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.JobInIntegrationsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.JobInIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.JobInRepositoriesVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.JobInRepositoriesVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutStatus))
                {
                    return new global::Mistral.JsonConverters.ClassifierDetailedJobOutStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutStatus?))
                {
                    return new global::Mistral.JsonConverters.ClassifierDetailedJobOutStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutStatus))
                {
                    return new global::Mistral.JsonConverters.CompletionDetailedJobOutStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutStatus?))
                {
                    return new global::Mistral.JsonConverters.CompletionDetailedJobOutStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.CompletionDetailedJobOutRepositorieDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.CompletionDetailedJobOutRepositorieDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.BatchJobStatus))
                {
                    return new global::Mistral.JsonConverters.BatchJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.BatchJobStatus?))
                {
                    return new global::Mistral.JsonConverters.BatchJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ApiEndpoint))
                {
                    return new global::Mistral.JsonConverters.ApiEndpointJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ApiEndpoint?))
                {
                    return new global::Mistral.JsonConverters.ApiEndpointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ChatCompletionRequestMessageDiscriminatorRole))
                {
                    return new global::Mistral.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ChatCompletionRequestMessageDiscriminatorRole?))
                {
                    return new global::Mistral.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ChatCompletionRequestReasoningEffort))
                {
                    return new global::Mistral.JsonConverters.ChatCompletionRequestReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ChatCompletionRequestReasoningEffort?))
                {
                    return new global::Mistral.JsonConverters.ChatCompletionRequestReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole))
                {
                    return new global::Mistral.JsonConverters.ChatModerationRequestInputVariant1ItemDiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole?))
                {
                    return new global::Mistral.JsonConverters.ChatModerationRequestInputVariant1ItemDiscriminatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole))
                {
                    return new global::Mistral.JsonConverters.ChatModerationRequestInputVariant2ItemItemDiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole?))
                {
                    return new global::Mistral.JsonConverters.ChatModerationRequestInputVariant2ItemItemDiscriminatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EmbeddingDtype))
                {
                    return new global::Mistral.JsonConverters.EmbeddingDtypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EmbeddingDtype?))
                {
                    return new global::Mistral.JsonConverters.EmbeddingDtypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EncodingFormat))
                {
                    return new global::Mistral.JsonConverters.EncodingFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EncodingFormat?))
                {
                    return new global::Mistral.JsonConverters.EncodingFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.InstructRequestMessageDiscriminatorRole))
                {
                    return new global::Mistral.JsonConverters.InstructRequestMessageDiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.InstructRequestMessageDiscriminatorRole?))
                {
                    return new global::Mistral.JsonConverters.InstructRequestMessageDiscriminatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.MistralPromptMode))
                {
                    return new global::Mistral.JsonConverters.MistralPromptModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.MistralPromptMode?))
                {
                    return new global::Mistral.JsonConverters.MistralPromptModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.OCRPageObjectBlocksVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.OCRPageObjectBlocksVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRRequestTableFormat2))
                {
                    return new global::Mistral.JsonConverters.OCRRequestTableFormat2JsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRRequestTableFormat2?))
                {
                    return new global::Mistral.JsonConverters.OCRRequestTableFormat2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRRequestConfidenceScoresGranularity2))
                {
                    return new global::Mistral.JsonConverters.OCRRequestConfidenceScoresGranularity2JsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRRequestConfidenceScoresGranularity2?))
                {
                    return new global::Mistral.JsonConverters.OCRRequestConfidenceScoresGranularity2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRTableObjectFormat))
                {
                    return new global::Mistral.JsonConverters.OCRTableObjectFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRTableObjectFormat?))
                {
                    return new global::Mistral.JsonConverters.OCRTableObjectFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolTypes))
                {
                    return new global::Mistral.JsonConverters.ToolTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolTypes?))
                {
                    return new global::Mistral.JsonConverters.ToolTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.SpeechOutputFormat))
                {
                    return new global::Mistral.JsonConverters.SpeechOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.SpeechOutputFormat?))
                {
                    return new global::Mistral.JsonConverters.SpeechOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.SpeechStreamEventsEvent))
                {
                    return new global::Mistral.JsonConverters.SpeechStreamEventsEventJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.SpeechStreamEventsEvent?))
                {
                    return new global::Mistral.JsonConverters.SpeechStreamEventsEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.SpeechStreamEventsDataDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.SpeechStreamEventsDataDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.SpeechStreamEventsDataDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.SpeechStreamEventsDataDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.TimestampGranularity))
                {
                    return new global::Mistral.JsonConverters.TimestampGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.TimestampGranularity?))
                {
                    return new global::Mistral.JsonConverters.TimestampGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.TranscriptionStreamEventsDataDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.TranscriptionStreamEventsDataDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.TranscriptionStreamEventsDataDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.TranscriptionStreamEventsDataDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.TranscriptionStreamEventTypes))
                {
                    return new global::Mistral.JsonConverters.TranscriptionStreamEventTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.TranscriptionStreamEventTypes?))
                {
                    return new global::Mistral.JsonConverters.TranscriptionStreamEventTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.RealtimeTranscriptionClientMessageDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.RealtimeTranscriptionClientMessageDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AudioEncoding))
                {
                    return new global::Mistral.JsonConverters.AudioEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AudioEncoding?))
                {
                    return new global::Mistral.JsonConverters.AudioEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AgentsCompletionRequestMessageDiscriminatorRole))
                {
                    return new global::Mistral.JsonConverters.AgentsCompletionRequestMessageDiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AgentsCompletionRequestMessageDiscriminatorRole?))
                {
                    return new global::Mistral.JsonConverters.AgentsCompletionRequestMessageDiscriminatorRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AgentsCompletionRequestReasoningEffort))
                {
                    return new global::Mistral.JsonConverters.AgentsCompletionRequestReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AgentsCompletionRequestReasoningEffort?))
                {
                    return new global::Mistral.JsonConverters.AgentsCompletionRequestReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ContentChunkDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.ContentChunkDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ContentChunkDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.ContentChunkDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.SystemMessageContentChunksDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.SystemMessageContentChunksDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FilterConditionOp))
                {
                    return new global::Mistral.JsonConverters.FilterConditionOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FilterConditionOp?))
                {
                    return new global::Mistral.JsonConverters.FilterConditionOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ProcessStatus))
                {
                    return new global::Mistral.JsonConverters.ProcessStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ProcessStatus?))
                {
                    return new global::Mistral.JsonConverters.ProcessStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ShareEnum))
                {
                    return new global::Mistral.JsonConverters.ShareEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ShareEnum?))
                {
                    return new global::Mistral.JsonConverters.ShareEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EntityType))
                {
                    return new global::Mistral.JsonConverters.EntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EntityType?))
                {
                    return new global::Mistral.JsonConverters.EntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.BaseFieldDefinitionType))
                {
                    return new global::Mistral.JsonConverters.BaseFieldDefinitionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.BaseFieldDefinitionType?))
                {
                    return new global::Mistral.JsonConverters.BaseFieldDefinitionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.BaseFieldDefinitionSupportedOperator))
                {
                    return new global::Mistral.JsonConverters.BaseFieldDefinitionSupportedOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.BaseFieldDefinitionSupportedOperator?))
                {
                    return new global::Mistral.JsonConverters.BaseFieldDefinitionSupportedOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.BaseTaskStatus))
                {
                    return new global::Mistral.JsonConverters.BaseTaskStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.BaseTaskStatus?))
                {
                    return new global::Mistral.JsonConverters.BaseTaskStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConversationSource))
                {
                    return new global::Mistral.JsonConverters.ConversationSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConversationSource?))
                {
                    return new global::Mistral.JsonConverters.ConversationSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JudgeOutputType))
                {
                    return new global::Mistral.JsonConverters.JudgeOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JudgeOutputType?))
                {
                    return new global::Mistral.JsonConverters.JudgeOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JudgePreviewOutputDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.JudgePreviewOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JudgePreviewOutputDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.JudgePreviewOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.PostJudgeInSchemaOutputDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.PostJudgeInSchemaOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.PostJudgeInSchemaOutputDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.PostJudgeInSchemaOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.PutJudgeInSchemaOutputDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.PutJudgeInSchemaOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.PutJudgeInSchemaOutputDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.PutJudgeInSchemaOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ObservabilityErrorCode))
                {
                    return new global::Mistral.JsonConverters.ObservabilityErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ObservabilityErrorCode?))
                {
                    return new global::Mistral.JsonConverters.ObservabilityErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AnnotationsAudienceVariant1Item))
                {
                    return new global::Mistral.JsonConverters.AnnotationsAudienceVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AnnotationsAudienceVariant1Item?))
                {
                    return new global::Mistral.JsonConverters.AnnotationsAudienceVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConnectorSupportedLanguage))
                {
                    return new global::Mistral.JsonConverters.ConnectorSupportedLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConnectorSupportedLanguage?))
                {
                    return new global::Mistral.JsonConverters.ConnectorSupportedLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ResourceVisibility))
                {
                    return new global::Mistral.JsonConverters.ResourceVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ResourceVisibility?))
                {
                    return new global::Mistral.JsonConverters.ResourceVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionResponseStreamChoiceFinishReason))
                {
                    return new global::Mistral.JsonConverters.CompletionResponseStreamChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionResponseStreamChoiceFinishReason?))
                {
                    return new global::Mistral.JsonConverters.CompletionResponseStreamChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ChatCompletionChoiceFinishReason))
                {
                    return new global::Mistral.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ChatCompletionChoiceFinishReason?))
                {
                    return new global::Mistral.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.CustomTaskInProgressAttributesResponsePayloadDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.CustomTaskInProgressAttributesResponsePayloadDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EncodedPayloadOptions))
                {
                    return new global::Mistral.JsonConverters.EncodedPayloadOptionsJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EncodedPayloadOptions?))
                {
                    return new global::Mistral.JsonConverters.EncodedPayloadOptionsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EventProgressStatus))
                {
                    return new global::Mistral.JsonConverters.EventProgressStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EventProgressStatus?))
                {
                    return new global::Mistral.JsonConverters.EventProgressStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EventSource))
                {
                    return new global::Mistral.JsonConverters.EventSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EventSource?))
                {
                    return new global::Mistral.JsonConverters.EventSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EventType))
                {
                    return new global::Mistral.JsonConverters.EventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.EventType?))
                {
                    return new global::Mistral.JsonConverters.EventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp))
                {
                    return new global::Mistral.JsonConverters.JSONPatchPayloadResponseValueItemDiscriminatorOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp?))
                {
                    return new global::Mistral.JsonConverters.JSONPatchPayloadResponseValueItemDiscriminatorOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.TempoTraceScopeKind))
                {
                    return new global::Mistral.JsonConverters.TempoTraceScopeKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.TempoTraceScopeKind?))
                {
                    return new global::Mistral.JsonConverters.TempoTraceScopeKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.WorkflowEventType))
                {
                    return new global::Mistral.JsonConverters.WorkflowEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.WorkflowEventType?))
                {
                    return new global::Mistral.JsonConverters.WorkflowEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.WorkflowExecutionStatus))
                {
                    return new global::Mistral.JsonConverters.WorkflowExecutionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.WorkflowExecutionStatus?))
                {
                    return new global::Mistral.JsonConverters.WorkflowExecutionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.WorkflowType))
                {
                    return new global::Mistral.JsonConverters.WorkflowTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.WorkflowType?))
                {
                    return new global::Mistral.JsonConverters.WorkflowTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.MCPSupportedLanguage))
                {
                    return new global::Mistral.JsonConverters.MCPSupportedLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.MCPSupportedLanguage?))
                {
                    return new global::Mistral.JsonConverters.MCPSupportedLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.MCPUIToolMetaVisibilityVariant1Item))
                {
                    return new global::Mistral.JsonConverters.MCPUIToolMetaVisibilityVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.MCPUIToolMetaVisibilityVariant1Item?))
                {
                    return new global::Mistral.JsonConverters.MCPUIToolMetaVisibilityVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OutboundAuthenticationType))
                {
                    return new global::Mistral.JsonConverters.OutboundAuthenticationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OutboundAuthenticationType?))
                {
                    return new global::Mistral.JsonConverters.OutboundAuthenticationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolExecutionTaskSupport2))
                {
                    return new global::Mistral.JsonConverters.ToolExecutionTaskSupport2JsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolExecutionTaskSupport2?))
                {
                    return new global::Mistral.JsonConverters.ToolExecutionTaskSupport2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolType))
                {
                    return new global::Mistral.JsonConverters.ToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolType?))
                {
                    return new global::Mistral.JsonConverters.ToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility))
                {
                    return new global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility?))
                {
                    return new global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus2))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus2?))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesBatchGetBatchJobsOrderBy))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesBatchGetBatchJobsOrderByJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesBatchGetBatchJobsOrderBy?))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesBatchGetBatchJobsOrderByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperator))
                {
                    return new global::Mistral.JsonConverters.GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperator?))
                {
                    return new global::Mistral.JsonConverters.GetChatCompletionFieldOptionsV1ObservabilityChatCompletionFieldsFieldNameOptionsGetOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope))
                {
                    return new global::Mistral.JsonConverters.GetStreamEventsV1WorkflowsEventsStreamGetScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope?))
                {
                    return new global::Mistral.JsonConverters.GetStreamEventsV1WorkflowsEventsStreamGetScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType?))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType?))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType?))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType?))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType?))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[3];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}