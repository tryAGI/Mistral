
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.APIKeyAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.APIKeyAuthType), TypeInfoPropertyName = "APIKeyAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem), TypeInfoPropertyName = "ToolsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchPremiumTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CodeInterpreterTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageGenerationTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentLibraryTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GuardrailConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MetadataDict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?, object>), TypeInfoPropertyName = "AnyOfStringInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem2), TypeInfoPropertyName = "ToolsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentHandoffEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem3), TypeInfoPropertyName = "ToolsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BuiltInConnectors), TypeInfoPropertyName = "BuiltInConnectors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CodeInterpreterToolType), TypeInfoPropertyName = "CodeInterpreterToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsStop), TypeInfoPropertyName = "CompletionArgsStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Prediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolChoiceEnum), TypeInfoPropertyName = "ToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsReasoningEffort), TypeInfoPropertyName = "CompletionArgsReasoningEffort2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEntryConfirmationStatus), TypeInfoPropertyName = "FunctionCallEntryConfirmationStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEventConfirmationStatus), TypeInfoPropertyName = "FunctionCallEventConfirmationStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Data), TypeInfoPropertyName = "Data2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationEventsDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationEventsDataDiscriminatorType), TypeInfoPropertyName = "ConversationEventsDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>), TypeInfoPropertyName = "AnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>), TypeInfoPropertyName = "AnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunkToolReferenceChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>), TypeInfoPropertyName = "AnyOfMessageInputEntryMessageOutputEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationInputs), TypeInfoPropertyName = "ConversationInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBaseHandoffExecution), TypeInfoPropertyName = "ConversationRequestBaseHandoffExecution2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunk), TypeInfoPropertyName = "ContentChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FileChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunks), TypeInfoPropertyName = "SystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>), TypeInfoPropertyName = "AnyOfModelConversationAgentConversation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.APIKeyAuthType?), TypeInfoPropertyName = "NullableAPIKeyAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem?), TypeInfoPropertyName = "NullableToolsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?, object>?), TypeInfoPropertyName = "NullableAnyOfStringInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem2?), TypeInfoPropertyName = "NullableToolsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem3?), TypeInfoPropertyName = "NullableToolsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BuiltInConnectors?), TypeInfoPropertyName = "NullableBuiltInConnectors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CodeInterpreterToolType?), TypeInfoPropertyName = "NullableCodeInterpreterToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsStop?), TypeInfoPropertyName = "NullableCompletionArgsStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolChoiceEnum?), TypeInfoPropertyName = "NullableToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsReasoningEffort?), TypeInfoPropertyName = "NullableCompletionArgsReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendRequest?), TypeInfoPropertyName = "NullableConversationAppendRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>?), TypeInfoPropertyName = "NullableAnyOfMessageInputEntryMessageOutputEntryFunctionResultEntryFunctionCallEntryToolExecutionEntryAgentHandoffEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartRequest?), TypeInfoPropertyName = "NullableConversationRestartRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorType?), TypeInfoPropertyName = "NullableCustomConnectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableCustomConnectorAuthorizationVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentLibraryToolType?), TypeInfoPropertyName = "NullableDocumentLibraryToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEntryArguments?), TypeInfoPropertyName = "NullableFunctionCallEntryArguments2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEntryConfirmationStatus?), TypeInfoPropertyName = "NullableFunctionCallEntryConfirmationStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormats?), TypeInfoPropertyName = "NullableResponseFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>?), TypeInfoPropertyName = "NullableAnyOfTextChunkToolReferenceChunkReferenceChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolCallConfirmationConfirmation?), TypeInfoPropertyName = "NullableToolCallConfirmationConfirmation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.BuiltInConnectors?, string>?), TypeInfoPropertyName = "NullableAnyOfBuiltInConnectorsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchPremiumToolType?), TypeInfoPropertyName = "NullableWebSearchPremiumToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchToolType?), TypeInfoPropertyName = "NullableWebSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>?), TypeInfoPropertyName = "NullableAnyOfMessageOutputEntryToolExecutionEntryFunctionCallEntryAgentHandoffEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequest?), TypeInfoPropertyName = "NullableConversationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCallEventConfirmationStatus?), TypeInfoPropertyName = "NullableFunctionCallEventConfirmationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::Mistral.OutputContentChunks?>?), TypeInfoPropertyName = "NullableAnyOfStringOutputContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OutputContentChunks?), TypeInfoPropertyName = "NullableOutputContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SSETypes?), TypeInfoPropertyName = "NullableSSETypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Data?), TypeInfoPropertyName = "NullableData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationEventsDataDiscriminatorType?), TypeInfoPropertyName = "NullableConversationEventsDataDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>?), TypeInfoPropertyName = "NullableAnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk, global::Mistral.ToolReferenceChunk>?), TypeInfoPropertyName = "NullableAnyOfTextChunkImageURLChunkToolFileChunkDocumentURLChunkThinkChunkToolReferenceChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>?), TypeInfoPropertyName = "NullableAnyOfMessageInputEntryMessageOutputEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationInputs?), TypeInfoPropertyName = "NullableConversationInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBaseHandoffExecution?), TypeInfoPropertyName = "NullableConversationRequestBaseHandoffExecution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsVariant1Item?), TypeInfoPropertyName = "NullableToolsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRequestBaseToolsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableConversationRequestBaseToolsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationStreamRequest?), TypeInfoPropertyName = "NullableConversationStreamRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendRequestBaseHandoffExecution?), TypeInfoPropertyName = "NullableConversationAppendRequestBaseHandoffExecution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationAppendStreamRequest?), TypeInfoPropertyName = "NullableConversationAppendStreamRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartRequestBaseHandoffExecution?), TypeInfoPropertyName = "NullableConversationRestartRequestBaseHandoffExecution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ConversationRestartStreamRequest?), TypeInfoPropertyName = "NullableConversationRestartStreamRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunk?), TypeInfoPropertyName = "NullableContentChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunks?), TypeInfoPropertyName = "NullableSystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>?), TypeInfoPropertyName = "NullableAnyOfModelConversationAgentConversation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.GuardrailConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>>))]
    internal sealed partial class BetaConversationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaConversationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BetaConversationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BetaConversationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
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
            options.Converters.Add(new global::Mistral.JsonConverters.ContentChunkJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.SystemMessageContentChunksJsonConverter());
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
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, byte[]>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
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
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<bool>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, bool?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ModelConversation, global::Mistral.AgentConversation>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ModelConversation, global::Mistral.AgentConversation>());
            options.Converters.Add(new global::Mistral.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Mistral.APIKeyAuthType)

                    || typeToConvert == typeof(global::Mistral.APIKeyAuthType?)

                    || typeToConvert == typeof(global::Mistral.BuiltInConnectors)

                    || typeToConvert == typeof(global::Mistral.BuiltInConnectors?)

                    || typeToConvert == typeof(global::Mistral.CodeInterpreterToolType)

                    || typeToConvert == typeof(global::Mistral.CodeInterpreterToolType?)

                    || typeToConvert == typeof(global::Mistral.CompletionArgsReasoningEffort)

                    || typeToConvert == typeof(global::Mistral.CompletionArgsReasoningEffort?)

                    || typeToConvert == typeof(global::Mistral.CustomConnectorType)

                    || typeToConvert == typeof(global::Mistral.CustomConnectorType?)

                    || typeToConvert == typeof(global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.DocumentLibraryToolType)

                    || typeToConvert == typeof(global::Mistral.DocumentLibraryToolType?)

                    || typeToConvert == typeof(global::Mistral.FunctionCallEntryConfirmationStatus)

                    || typeToConvert == typeof(global::Mistral.FunctionCallEntryConfirmationStatus?)

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

                    || typeToConvert == typeof(global::Mistral.FunctionCallEventConfirmationStatus)

                    || typeToConvert == typeof(global::Mistral.FunctionCallEventConfirmationStatus?)

                    || typeToConvert == typeof(global::Mistral.SSETypes)

                    || typeToConvert == typeof(global::Mistral.SSETypes?)

                    || typeToConvert == typeof(global::Mistral.ConversationEventsDataDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.ConversationEventsDataDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.ConversationRequestBaseHandoffExecution)

                    || typeToConvert == typeof(global::Mistral.ConversationRequestBaseHandoffExecution?)

                    || typeToConvert == typeof(global::Mistral.ConversationRequestBaseToolsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.ConversationRequestBaseToolsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.ConversationAppendRequestBaseHandoffExecution)

                    || typeToConvert == typeof(global::Mistral.ConversationAppendRequestBaseHandoffExecution?)

                    || typeToConvert == typeof(global::Mistral.ConversationRestartRequestBaseHandoffExecution)

                    || typeToConvert == typeof(global::Mistral.ConversationRestartRequestBaseHandoffExecution?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Mistral.APIKeyAuthType))
                {
                    return new global::Mistral.JsonConverters.APIKeyAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.APIKeyAuthType?))
                {
                    return new global::Mistral.JsonConverters.APIKeyAuthTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Mistral.CompletionArgsReasoningEffort))
                {
                    return new global::Mistral.JsonConverters.CompletionArgsReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionArgsReasoningEffort?))
                {
                    return new global::Mistral.JsonConverters.CompletionArgsReasoningEffortNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Mistral.FunctionCallEntryConfirmationStatus))
                {
                    return new global::Mistral.JsonConverters.FunctionCallEntryConfirmationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FunctionCallEntryConfirmationStatus?))
                {
                    return new global::Mistral.JsonConverters.FunctionCallEntryConfirmationStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Mistral.FunctionCallEventConfirmationStatus))
                {
                    return new global::Mistral.JsonConverters.FunctionCallEventConfirmationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FunctionCallEventConfirmationStatus?))
                {
                    return new global::Mistral.JsonConverters.FunctionCallEventConfirmationStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Mistral.ConversationRequestBaseHandoffExecution))
                {
                    return new global::Mistral.JsonConverters.ConversationRequestBaseHandoffExecutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ConversationRequestBaseHandoffExecution?))
                {
                    return new global::Mistral.JsonConverters.ConversationRequestBaseHandoffExecutionNullableJsonConverter();
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
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new BetaConversationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}