
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GuardrailConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BuiltInConnectors), TypeInfoPropertyName = "BuiltInConnectors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Prediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolChoiceEnum), TypeInfoPropertyName = "ToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV1Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV2Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageDetail), TypeInfoPropertyName = "ImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ImageURL, string>), TypeInfoPropertyName = "AnyOfImageURLString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMAction), TypeInfoPropertyName = "ModerationLLMAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV1CategoryThresholds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV2CategoryThresholds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormats), TypeInfoPropertyName = "ResponseFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TextChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ThinkChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>), TypeInfoPropertyName = "AnyOfTextChunkToolReferenceChunkReferenceChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolReferenceChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ReferenceChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.BuiltInConnectors?, string>), TypeInfoPropertyName = "AnyOfBuiltInConnectorsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InputVariant1Item), TypeInfoPropertyName = "InputVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InputVariant2ItemItem), TypeInfoPropertyName = "InputVariant2ItemItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FileChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<object, string>), TypeInfoPropertyName = "AnyOfObjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem2), TypeInfoPropertyName = "MessagesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>>), TypeInfoPropertyName = "AnyOfStringIListSystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunks), TypeInfoPropertyName = "SystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolTypes), TypeInfoPropertyName = "ToolTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem3), TypeInfoPropertyName = "MessagesItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunkDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunkDiscriminatorType), TypeInfoPropertyName = "ContentChunkDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunksDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType), TypeInfoPropertyName = "SystemMessageContentChunksDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BuiltInConnectors?), TypeInfoPropertyName = "NullableBuiltInConnectors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolChoiceEnum?), TypeInfoPropertyName = "NullableToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageDetail?), TypeInfoPropertyName = "NullableImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ImageURL, string>?), TypeInfoPropertyName = "NullableAnyOfImageURLString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMAction?), TypeInfoPropertyName = "NullableModerationLLMAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormats?), TypeInfoPropertyName = "NullableResponseFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>?), TypeInfoPropertyName = "NullableAnyOfTextChunkToolReferenceChunkReferenceChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.BuiltInConnectors?, string>?), TypeInfoPropertyName = "NullableAnyOfBuiltInConnectorsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>?), TypeInfoPropertyName = "NullableAnyOfStringObjectIListContentChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunk?), TypeInfoPropertyName = "NullableContentChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, byte[]>?), TypeInfoPropertyName = "NullableAnyOfStringByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem?), TypeInfoPropertyName = "NullableMessagesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionRequestMessageDiscriminatorRole?), TypeInfoPropertyName = "NullableChatCompletionRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>?), TypeInfoPropertyName = "NullableAnyOfToolChoice2ToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MistralPromptMode?), TypeInfoPropertyName = "NullableMistralPromptMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionRequestReasoningEffort?), TypeInfoPropertyName = "NullableChatCompletionRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InputVariant1Item?), TypeInfoPropertyName = "NullableInputVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InputVariant2ItemItem?), TypeInfoPropertyName = "NullableInputVariant2ItemItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<object, string>?), TypeInfoPropertyName = "NullableAnyOfObjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem2?), TypeInfoPropertyName = "NullableMessagesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>>?), TypeInfoPropertyName = "NullableAnyOfStringIListSystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunks?), TypeInfoPropertyName = "NullableSystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolTypes?), TypeInfoPropertyName = "NullableToolTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem3?), TypeInfoPropertyName = "NullableMessagesItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunkDiscriminatorType?), TypeInfoPropertyName = "NullableContentChunkDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType?), TypeInfoPropertyName = "NullableSystemMessageContentChunksDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionResponseStreamChoiceFinishReason?), TypeInfoPropertyName = "NullableCompletionResponseStreamChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionChoiceFinishReason?), TypeInfoPropertyName = "NullableChatCompletionChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionResponseBase?), TypeInfoPropertyName = "NullableChatCompletionResponseBase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionResponse?), TypeInfoPropertyName = "NullableChatCompletionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.GuardrailConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, object, global::System.Collections.Generic.List<global::Mistral.ContentChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ContentChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.MessagesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Tool3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.List<global::Mistral.SystemMessageContentChunks>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.SystemMessageContentChunks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.CompletionResponseStreamChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ChatCompletionChoice>))]
    internal sealed partial class ChatSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChatSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChatSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Mistral.JsonConverters.MessagesItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.InputVariant1ItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.InputVariant2ItemItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.MessagesItem2JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.MessagesItem3JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ContentChunkJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.SystemMessageContentChunksJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ChatCompletionResponseBaseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ChatCompletionResponseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ImageURL, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>());
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
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, bool?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<int?, string, object>());
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
                    typeToConvert == typeof(global::Mistral.BuiltInConnectors)

                    || typeToConvert == typeof(global::Mistral.BuiltInConnectors?)

                    || typeToConvert == typeof(global::Mistral.ImageDetail)

                    || typeToConvert == typeof(global::Mistral.ImageDetail?)

                    || typeToConvert == typeof(global::Mistral.ModerationLLMAction)

                    || typeToConvert == typeof(global::Mistral.ModerationLLMAction?)

                    || typeToConvert == typeof(global::Mistral.ResponseFormats)

                    || typeToConvert == typeof(global::Mistral.ResponseFormats?)

                    || typeToConvert == typeof(global::Mistral.ToolChoiceEnum)

                    || typeToConvert == typeof(global::Mistral.ToolChoiceEnum?)

                    || typeToConvert == typeof(global::Mistral.ChatCompletionRequestMessageDiscriminatorRole)

                    || typeToConvert == typeof(global::Mistral.ChatCompletionRequestMessageDiscriminatorRole?)

                    || typeToConvert == typeof(global::Mistral.ChatCompletionRequestReasoningEffort)

                    || typeToConvert == typeof(global::Mistral.ChatCompletionRequestReasoningEffort?)

                    || typeToConvert == typeof(global::Mistral.MistralPromptMode)

                    || typeToConvert == typeof(global::Mistral.MistralPromptMode?)

                    || typeToConvert == typeof(global::Mistral.ToolTypes)

                    || typeToConvert == typeof(global::Mistral.ToolTypes?)

                    || typeToConvert == typeof(global::Mistral.ContentChunkDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.ContentChunkDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.CompletionResponseStreamChoiceFinishReason)

                    || typeToConvert == typeof(global::Mistral.CompletionResponseStreamChoiceFinishReason?)

                    || typeToConvert == typeof(global::Mistral.ChatCompletionChoiceFinishReason)

                    || typeToConvert == typeof(global::Mistral.ChatCompletionChoiceFinishReason?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Mistral.BuiltInConnectors))
                {
                    return new global::Mistral.JsonConverters.BuiltInConnectorsJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.BuiltInConnectors?))
                {
                    return new global::Mistral.JsonConverters.BuiltInConnectorsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ImageDetail))
                {
                    return new global::Mistral.JsonConverters.ImageDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ImageDetail?))
                {
                    return new global::Mistral.JsonConverters.ImageDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ModerationLLMAction))
                {
                    return new global::Mistral.JsonConverters.ModerationLLMActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ModerationLLMAction?))
                {
                    return new global::Mistral.JsonConverters.ModerationLLMActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ResponseFormats))
                {
                    return new global::Mistral.JsonConverters.ResponseFormatsJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ResponseFormats?))
                {
                    return new global::Mistral.JsonConverters.ResponseFormatsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolChoiceEnum))
                {
                    return new global::Mistral.JsonConverters.ToolChoiceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolChoiceEnum?))
                {
                    return new global::Mistral.JsonConverters.ToolChoiceEnumNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Mistral.MistralPromptMode))
                {
                    return new global::Mistral.JsonConverters.MistralPromptModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.MistralPromptMode?))
                {
                    return new global::Mistral.JsonConverters.MistralPromptModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolTypes))
                {
                    return new global::Mistral.JsonConverters.ToolTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolTypes?))
                {
                    return new global::Mistral.JsonConverters.ToolTypesNullableJsonConverter();
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
                    0 => new ChatSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}