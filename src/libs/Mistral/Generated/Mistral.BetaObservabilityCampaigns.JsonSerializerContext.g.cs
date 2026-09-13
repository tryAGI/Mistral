
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterConditionOp), TypeInfoPropertyName = "FilterConditionOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>), TypeInfoPropertyName = "AnyOfFilterGroupFilterCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseTaskStatus), TypeInfoPropertyName = "BaseTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CampaignPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgePreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CampaignPreviews))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultCampaignPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CampaignSelectedEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginatedResultChatCompletionEventPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CampaignStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfBooleanInt32DoubleStringDateTimeIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ChatCompletionEventPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ChatCompletionEventPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition, object>), TypeInfoPropertyName = "AnyOfFilterGroupFilterConditionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeClassificationOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.JudgeClassificationOutputOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeClassificationOutputOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output), TypeInfoPropertyName = "Output2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgeRegressionOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgePreviewOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgePreviewOutputDiscriminatorType), TypeInfoPropertyName = "JudgePreviewOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.CampaignPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PostCampaignInSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output2), TypeInfoPropertyName = "Output22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output3), TypeInfoPropertyName = "Output32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ObservabilityErrorCode), TypeInfoPropertyName = "ObservabilityErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ObservabilityErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ObservabilityError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilterConditionOp?), TypeInfoPropertyName = "NullableFilterConditionOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>?), TypeInfoPropertyName = "NullableAnyOfFilterGroupFilterCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BaseTaskStatus?), TypeInfoPropertyName = "NullableBaseTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>?), TypeInfoPropertyName = "NullableAnyOfBooleanInt32DoubleStringDateTimeIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition, object>?), TypeInfoPropertyName = "NullableAnyOfFilterGroupFilterConditionObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output?), TypeInfoPropertyName = "NullableOutput2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JudgePreviewOutputDiscriminatorType?), TypeInfoPropertyName = "NullableJudgePreviewOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output2?), TypeInfoPropertyName = "NullableOutput22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Output3?), TypeInfoPropertyName = "NullableOutput32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ObservabilityErrorCode?), TypeInfoPropertyName = "NullableObservabilityErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ChatCompletionEventPreview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.JudgeClassificationOutputOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.CampaignPreview>))]
    internal sealed partial class BetaObservabilityCampaignsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaObservabilityCampaignsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BetaObservabilityCampaignsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BetaObservabilityCampaignsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Mistral.JsonConverters.OutputJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.Output2JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.Output3JsonConverter());
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
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, bool?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FilterGroup, global::Mistral.FilterCondition, object>());
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
                    typeToConvert == typeof(global::Mistral.FilterConditionOp)

                    || typeToConvert == typeof(global::Mistral.FilterConditionOp?)

                    || typeToConvert == typeof(global::Mistral.BaseTaskStatus)

                    || typeToConvert == typeof(global::Mistral.BaseTaskStatus?)

                    || typeToConvert == typeof(global::Mistral.JudgePreviewOutputDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.JudgePreviewOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.ObservabilityErrorCode)

                    || typeToConvert == typeof(global::Mistral.ObservabilityErrorCode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Mistral.FilterConditionOp))
                {
                    return new global::Mistral.JsonConverters.FilterConditionOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FilterConditionOp?))
                {
                    return new global::Mistral.JsonConverters.FilterConditionOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.BaseTaskStatus))
                {
                    return new global::Mistral.JsonConverters.BaseTaskStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.BaseTaskStatus?))
                {
                    return new global::Mistral.JsonConverters.BaseTaskStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JudgePreviewOutputDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.JudgePreviewOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JudgePreviewOutputDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.JudgePreviewOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ObservabilityErrorCode))
                {
                    return new global::Mistral.JsonConverters.ObservabilityErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ObservabilityErrorCode?))
                {
                    return new global::Mistral.JsonConverters.ObservabilityErrorCodeNullableJsonConverter();
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
                    0 => new BetaObservabilityCampaignsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}