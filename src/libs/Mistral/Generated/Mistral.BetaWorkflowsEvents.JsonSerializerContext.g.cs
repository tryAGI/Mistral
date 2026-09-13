
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>>), TypeInfoPropertyName = "ActivityTaskFailedResponse_4eb8600ed13d6756")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>), TypeInfoPropertyName = "ActivityTaskFailedResponse_0bde6d32684fee68")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>?), TypeInfoPropertyName = "ActivityTaskFailedResponse_d33e2eb74053f9ed")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OneOf<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>>), TypeInfoPropertyName = "ActivityTaskFailedResponse_40289a742d078cef")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.StreamEventSsePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.StreamEventWorkflowContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowEventType), TypeInfoPropertyName = "WorkflowEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionCanceledAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionCompletedAttributesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionContinuedAsNewAttributesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionFailedAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowExecutionStartedAttributesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowTaskFailedAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowTaskTimedOutAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope), TypeInfoPropertyName = "GetStreamEventsV1WorkflowsEventsStreamGetScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.WorkflowEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Payload?), TypeInfoPropertyName = "NullablePayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType?), TypeInfoPropertyName = "NullableCustomTaskInProgressAttributesResponsePayloadDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ValueItem?), TypeInfoPropertyName = "NullableValueItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp?), TypeInfoPropertyName = "NullableJSONPatchPayloadResponseValueItemDiscriminatorOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WorkflowEventType?), TypeInfoPropertyName = "NullableWorkflowEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope?), TypeInfoPropertyName = "NullableGetStreamEventsV1WorkflowsEventsStreamGetScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ValueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.WorkflowEventType>))]
    internal sealed partial class BetaWorkflowsEventsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaWorkflowsEventsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BetaWorkflowsEventsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BetaWorkflowsEventsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Mistral.JsonConverters.PayloadJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ValueItemJsonConverter());
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
            options.Converters.Add(new global::Mistral.JsonConverters.OneOfJsonConverter<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::Mistral.JsonConverters.OneOfJsonConverter<global::Mistral.WorkflowExecutionStartedResponse, global::Mistral.WorkflowExecutionCompletedResponse, global::Mistral.WorkflowExecutionFailedResponse, global::Mistral.WorkflowExecutionCanceledResponse, global::Mistral.WorkflowExecutionContinuedAsNewResponse, global::Mistral.WorkflowTaskTimedOutResponse, global::Mistral.WorkflowTaskFailedResponse, global::Mistral.CustomTaskStartedResponse, global::Mistral.CustomTaskInProgressResponse, global::Mistral.CustomTaskCompletedResponse, global::Mistral.CustomTaskFailedResponse, global::Mistral.CustomTaskTimedOutResponse, global::Mistral.CustomTaskCanceledResponse, global::Mistral.ActivityTaskStartedResponse, global::Mistral.ActivityTaskCompletedResponse, global::Mistral.ActivityTaskRetryingResponse, global::Mistral.ActivityTaskFailedResponse>());
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
                    typeToConvert == typeof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp)

                    || typeToConvert == typeof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp?)

                    || typeToConvert == typeof(global::Mistral.WorkflowEventType)

                    || typeToConvert == typeof(global::Mistral.WorkflowEventType?)

                    || typeToConvert == typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope)

                    || typeToConvert == typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.CustomTaskInProgressAttributesResponsePayloadDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.CustomTaskInProgressAttributesResponsePayloadDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp))
                {
                    return new global::Mistral.JsonConverters.JSONPatchPayloadResponseValueItemDiscriminatorOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp?))
                {
                    return new global::Mistral.JsonConverters.JSONPatchPayloadResponseValueItemDiscriminatorOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.WorkflowEventType))
                {
                    return new global::Mistral.JsonConverters.WorkflowEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.WorkflowEventType?))
                {
                    return new global::Mistral.JsonConverters.WorkflowEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope))
                {
                    return new global::Mistral.JsonConverters.GetStreamEventsV1WorkflowsEventsStreamGetScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope?))
                {
                    return new global::Mistral.JsonConverters.GetStreamEventsV1WorkflowsEventsStreamGetScopeNullableJsonConverter();
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
                    0 => new BetaWorkflowsEventsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}