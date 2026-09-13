
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BuiltInConnectors), TypeInfoPropertyName = "BuiltInConnectors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageDetail), TypeInfoPropertyName = "ImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ImageURL, string>), TypeInfoPropertyName = "AnyOfImageURLString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem), TypeInfoPropertyName = "MessagesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolMessage))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FileChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<object, string>), TypeInfoPropertyName = "AnyOfObjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InstructRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.MessagesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem2), TypeInfoPropertyName = "MessagesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InstructRequestMessageDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InstructRequestMessageDiscriminatorRole), TypeInfoPropertyName = "InstructRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>>), TypeInfoPropertyName = "AnyOfStringIListSystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunks), TypeInfoPropertyName = "SystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolTypes), TypeInfoPropertyName = "ToolTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem3), TypeInfoPropertyName = "MessagesItem32")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BuiltInConnectors?), TypeInfoPropertyName = "NullableBuiltInConnectors2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageDetail?), TypeInfoPropertyName = "NullableImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ImageURL, string>?), TypeInfoPropertyName = "NullableAnyOfImageURLString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>?), TypeInfoPropertyName = "NullableAnyOfTextChunkToolReferenceChunkReferenceChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.BuiltInConnectors?, string>?), TypeInfoPropertyName = "NullableAnyOfBuiltInConnectorsString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>?), TypeInfoPropertyName = "NullableAnyOfStringObjectIListContentChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunk?), TypeInfoPropertyName = "NullableContentChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, byte[]>?), TypeInfoPropertyName = "NullableAnyOfStringByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem?), TypeInfoPropertyName = "NullableMessagesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>>?), TypeInfoPropertyName = "NullableAnyOfIListInputVariant1ItemIListIListInputVariant2ItemItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InputVariant1Item?), TypeInfoPropertyName = "NullableInputVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole?), TypeInfoPropertyName = "NullableChatModerationRequestInputVariant1ItemDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InputVariant2ItemItem?), TypeInfoPropertyName = "NullableInputVariant2ItemItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole?), TypeInfoPropertyName = "NullableChatModerationRequestInputVariant2ItemItemDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<object, string>?), TypeInfoPropertyName = "NullableAnyOfObjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem2?), TypeInfoPropertyName = "NullableMessagesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.InstructRequestMessageDiscriminatorRole?), TypeInfoPropertyName = "NullableInstructRequestMessageDiscriminatorRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.SystemMessageContentChunks>>?), TypeInfoPropertyName = "NullableAnyOfStringIListSystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunks?), TypeInfoPropertyName = "NullableSystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolTypes?), TypeInfoPropertyName = "NullableToolTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MessagesItem3?), TypeInfoPropertyName = "NullableMessagesItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatClassificationRequestInputs?), TypeInfoPropertyName = "NullableChatClassificationRequestInputs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunkDiscriminatorType?), TypeInfoPropertyName = "NullableContentChunkDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType?), TypeInfoPropertyName = "NullableSystemMessageContentChunksDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, object, global::System.Collections.Generic.List<global::Mistral.ContentChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ContentChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::System.Collections.Generic.List<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Mistral.InputVariant2ItemItem>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.InputVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Mistral.InputVariant2ItemItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.InputVariant2ItemItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.MessagesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.List<global::Mistral.SystemMessageContentChunks>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.SystemMessageContentChunks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.InstructRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, global::Mistral.ClassificationTargetResult>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ModerationObject>))]
    internal sealed partial class ClassifiersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClassifiersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ClassifiersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ClassifiersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Mistral.JsonConverters.ChatClassificationRequestInputsJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ContentChunkJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.SystemMessageContentChunksJsonConverter());
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

                    || typeToConvert == typeof(global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole)

                    || typeToConvert == typeof(global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole?)

                    || typeToConvert == typeof(global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole)

                    || typeToConvert == typeof(global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole?)

                    || typeToConvert == typeof(global::Mistral.InstructRequestMessageDiscriminatorRole)

                    || typeToConvert == typeof(global::Mistral.InstructRequestMessageDiscriminatorRole?)

                    || typeToConvert == typeof(global::Mistral.ToolTypes)

                    || typeToConvert == typeof(global::Mistral.ToolTypes?)

                    || typeToConvert == typeof(global::Mistral.ContentChunkDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.ContentChunkDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.SystemMessageContentChunksDiscriminatorType?);
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

                if (typeToConvert == typeof(global::Mistral.InstructRequestMessageDiscriminatorRole))
                {
                    return new global::Mistral.JsonConverters.InstructRequestMessageDiscriminatorRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.InstructRequestMessageDiscriminatorRole?))
                {
                    return new global::Mistral.JsonConverters.InstructRequestMessageDiscriminatorRoleNullableJsonConverter();
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
                    0 => new ClassifiersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}