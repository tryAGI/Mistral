
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolAnnotations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPToolMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPUIToolMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TurbineToolMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.MCPUIToolMetaVisibilityVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPUIToolMetaVisibilityVariant1Item), TypeInfoPropertyName = "MCPUIToolMetaVisibilityVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PublicAuthenticationMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ConnectorAuthenticationHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecutionTaskSupport), TypeInfoPropertyName = "ToolExecutionTaskSupport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolType), TypeInfoPropertyName = "ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TurbineToolLocale))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.IntegrationsSchemasApiToolTool>, global::System.Collections.Generic.IList<global::Mistral.MCPTool>, global::System.Collections.Generic.IList<object>>), TypeInfoPropertyName = "AnyOfIListIntegrationsSchemasApiToolToolIListMCPToolIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.MCPTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.PublicAuthenticationMethod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnnotationsAudienceVariant1Item?), TypeInfoPropertyName = "NullableAnnotationsAudienceVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResourceVisibility?), TypeInfoPropertyName = "NullableResourceVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextResourceContents, global::Mistral.BlobResourceContents>?), TypeInfoPropertyName = "NullableAnyOfTextResourceContentsBlobResourceContents2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>?), TypeInfoPropertyName = "NullableAnyOfTextContentImageContentAudioContentResourceLinkEmbeddedResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OutboundAuthenticationType?), TypeInfoPropertyName = "NullableOutboundAuthenticationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MCPUIToolMetaVisibilityVariant1Item?), TypeInfoPropertyName = "NullableMCPUIToolMetaVisibilityVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolExecutionTaskSupport?), TypeInfoPropertyName = "NullableToolExecutionTaskSupport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ToolType?), TypeInfoPropertyName = "NullableToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.IntegrationsSchemasApiToolTool>, global::System.Collections.Generic.IList<global::Mistral.MCPTool>, global::System.Collections.Generic.IList<object>>?), TypeInfoPropertyName = "NullableAnyOfIListIntegrationsSchemasApiToolToolIListMCPToolIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnnotationsAudienceVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.IntegrationsSchemasApiToolTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.MCPServerIcon>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Connector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AuthenticationConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OutboundAuthenticationType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.MCPUIToolMetaVisibilityVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ConnectorAuthenticationHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::System.Collections.Generic.List<global::Mistral.IntegrationsSchemasApiToolTool>, global::System.Collections.Generic.List<global::Mistral.MCPTool>, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.MCPTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.PublicAuthenticationMethod>))]
    internal sealed partial class BetaConnectorsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaConnectorsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BetaConnectorsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BetaConnectorsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextResourceContents, global::Mistral.BlobResourceContents>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mistral.IntegrationsSchemasApiToolTool>, global::System.Collections.Generic.IList<global::Mistral.MCPTool>, global::System.Collections.Generic.IList<object>>());
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
                    typeToConvert == typeof(global::Mistral.AnnotationsAudienceVariant1Item)

                    || typeToConvert == typeof(global::Mistral.AnnotationsAudienceVariant1Item?)

                    || typeToConvert == typeof(global::Mistral.ResourceVisibility)

                    || typeToConvert == typeof(global::Mistral.ResourceVisibility?)

                    || typeToConvert == typeof(global::Mistral.MCPUIToolMetaVisibilityVariant1Item)

                    || typeToConvert == typeof(global::Mistral.MCPUIToolMetaVisibilityVariant1Item?)

                    || typeToConvert == typeof(global::Mistral.OutboundAuthenticationType)

                    || typeToConvert == typeof(global::Mistral.OutboundAuthenticationType?)

                    || typeToConvert == typeof(global::Mistral.ToolExecutionTaskSupport)

                    || typeToConvert == typeof(global::Mistral.ToolExecutionTaskSupport?)

                    || typeToConvert == typeof(global::Mistral.ToolType)

                    || typeToConvert == typeof(global::Mistral.ToolType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Mistral.AnnotationsAudienceVariant1Item))
                {
                    return new global::Mistral.JsonConverters.AnnotationsAudienceVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.AnnotationsAudienceVariant1Item?))
                {
                    return new global::Mistral.JsonConverters.AnnotationsAudienceVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ResourceVisibility))
                {
                    return new global::Mistral.JsonConverters.ResourceVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ResourceVisibility?))
                {
                    return new global::Mistral.JsonConverters.ResourceVisibilityNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Mistral.ToolExecutionTaskSupport))
                {
                    return new global::Mistral.JsonConverters.ToolExecutionTaskSupportJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolExecutionTaskSupport?))
                {
                    return new global::Mistral.JsonConverters.ToolExecutionTaskSupportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolType))
                {
                    return new global::Mistral.JsonConverters.ToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ToolType?))
                {
                    return new global::Mistral.JsonConverters.ToolTypeNullableJsonConverter();
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
                    0 => new BetaConnectorsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}