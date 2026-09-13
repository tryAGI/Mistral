
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentCreationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem2), TypeInfoPropertyName = "ToolsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentCreationRequestToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentCreationRequestToolDiscriminatorType), TypeInfoPropertyName = "AgentCreationRequestToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ToolsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem3), TypeInfoPropertyName = "ToolsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentUpdateRequestToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentUpdateRequestToolDiscriminatorType), TypeInfoPropertyName = "AgentUpdateRequestToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CodeInterpreterToolType), TypeInfoPropertyName = "CodeInterpreterToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsStop), TypeInfoPropertyName = "CompletionArgsStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Prediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolChoiceEnum), TypeInfoPropertyName = "ToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsReasoningEffort), TypeInfoPropertyName = "CompletionArgsReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorType), TypeInfoPropertyName = "CustomConnectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AuthorizationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OAuth2TokenAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorAuthorizationVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType), TypeInfoPropertyName = "CustomConnectorAuthorizationVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentLibraryToolType), TypeInfoPropertyName = "DocumentLibraryToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionToolType), TypeInfoPropertyName = "FunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV1Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV2Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageGenerationToolType), TypeInfoPropertyName = "ImageGenerationToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem4), TypeInfoPropertyName = "ToolsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMAction), TypeInfoPropertyName = "ModerationLLMAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV1CategoryThresholds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMV2CategoryThresholds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OAuth2TokenAuthType), TypeInfoPropertyName = "OAuth2TokenAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RequestSource), TypeInfoPropertyName = "RequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormats), TypeInfoPropertyName = "ResponseFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchPremiumToolType), TypeInfoPropertyName = "WebSearchPremiumToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchToolType), TypeInfoPropertyName = "WebSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsVariant1Item), TypeInfoPropertyName = "ToolsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.RequestSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<int?, string, object>), TypeInfoPropertyName = "AnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AgentAliasResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.APIKeyAuthType?), TypeInfoPropertyName = "NullableAPIKeyAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem?), TypeInfoPropertyName = "NullableToolsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentToolDiscriminatorType?), TypeInfoPropertyName = "NullableAgentToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem2?), TypeInfoPropertyName = "NullableToolsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentCreationRequestToolDiscriminatorType?), TypeInfoPropertyName = "NullableAgentCreationRequestToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem3?), TypeInfoPropertyName = "NullableToolsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AgentUpdateRequestToolDiscriminatorType?), TypeInfoPropertyName = "NullableAgentUpdateRequestToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CodeInterpreterToolType?), TypeInfoPropertyName = "NullableCodeInterpreterToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsStop?), TypeInfoPropertyName = "NullableCompletionArgsStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolChoiceEnum?), TypeInfoPropertyName = "NullableToolChoiceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionArgsReasoningEffort?), TypeInfoPropertyName = "NullableCompletionArgsReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorType?), TypeInfoPropertyName = "NullableCustomConnectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableCustomConnectorAuthorizationVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentLibraryToolType?), TypeInfoPropertyName = "NullableDocumentLibraryToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FunctionToolType?), TypeInfoPropertyName = "NullableFunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageGenerationToolType?), TypeInfoPropertyName = "NullableImageGenerationToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsItem4?), TypeInfoPropertyName = "NullableToolsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ModerationLLMAction?), TypeInfoPropertyName = "NullableModerationLLMAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OAuth2TokenAuthType?), TypeInfoPropertyName = "NullableOAuth2TokenAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RequestSource?), TypeInfoPropertyName = "NullableRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormats?), TypeInfoPropertyName = "NullableResponseFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchPremiumToolType?), TypeInfoPropertyName = "NullableWebSearchPremiumToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WebSearchToolType?), TypeInfoPropertyName = "NullableWebSearchToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolsVariant1Item?), TypeInfoPropertyName = "NullableToolsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<int?, string, object>?), TypeInfoPropertyName = "NullableAnyOfInt32StringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.GuardrailConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ToolsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.RequestSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AgentAliasResponse>))]
    internal sealed partial class BetaAgentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAgentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BetaAgentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BetaAgentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Mistral.JsonConverters.AuthorizationVariant1JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ToolsItem4JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.CompletionArgsStopJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ToolsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, byte[]>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<int>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<bool>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, bool?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, double?>());
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
                    typeToConvert == typeof(global::Mistral.APIKeyAuthType)

                    || typeToConvert == typeof(global::Mistral.APIKeyAuthType?)

                    || typeToConvert == typeof(global::Mistral.AgentToolDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.AgentToolDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.AgentCreationRequestToolDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.AgentCreationRequestToolDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.AgentUpdateRequestToolDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.AgentUpdateRequestToolDiscriminatorType?)

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

                    || typeToConvert == typeof(global::Mistral.FunctionToolType)

                    || typeToConvert == typeof(global::Mistral.FunctionToolType?)

                    || typeToConvert == typeof(global::Mistral.ImageGenerationToolType)

                    || typeToConvert == typeof(global::Mistral.ImageGenerationToolType?)

                    || typeToConvert == typeof(global::Mistral.ModerationLLMAction)

                    || typeToConvert == typeof(global::Mistral.ModerationLLMAction?)

                    || typeToConvert == typeof(global::Mistral.OAuth2TokenAuthType)

                    || typeToConvert == typeof(global::Mistral.OAuth2TokenAuthType?)

                    || typeToConvert == typeof(global::Mistral.RequestSource)

                    || typeToConvert == typeof(global::Mistral.RequestSource?)

                    || typeToConvert == typeof(global::Mistral.ResponseFormats)

                    || typeToConvert == typeof(global::Mistral.ResponseFormats?)

                    || typeToConvert == typeof(global::Mistral.ToolChoiceEnum)

                    || typeToConvert == typeof(global::Mistral.ToolChoiceEnum?)

                    || typeToConvert == typeof(global::Mistral.WebSearchPremiumToolType)

                    || typeToConvert == typeof(global::Mistral.WebSearchPremiumToolType?)

                    || typeToConvert == typeof(global::Mistral.WebSearchToolType)

                    || typeToConvert == typeof(global::Mistral.WebSearchToolType?);
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

                if (typeToConvert == typeof(global::Mistral.FunctionToolType))
                {
                    return new global::Mistral.JsonConverters.FunctionToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FunctionToolType?))
                {
                    return new global::Mistral.JsonConverters.FunctionToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ImageGenerationToolType))
                {
                    return new global::Mistral.JsonConverters.ImageGenerationToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ImageGenerationToolType?))
                {
                    return new global::Mistral.JsonConverters.ImageGenerationToolTypeNullableJsonConverter();
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
                    0 => new BetaAgentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}