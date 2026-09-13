
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageDetail), TypeInfoPropertyName = "ImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageURLChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ImageURL, string>), TypeInfoPropertyName = "AnyOfImageURLString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormats), TypeInfoPropertyName = "ResponseFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TextChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ThinkChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ReferenceChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunk), TypeInfoPropertyName = "ContentChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AudioChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FileChunk))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRRequestTableFormat), TypeInfoPropertyName = "OCRRequestTableFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRRequestConfidenceScoresGranularity), TypeInfoPropertyName = "OCRRequestConfidenceScoresGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.OCRPageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRUsageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRTableObjectFormat), TypeInfoPropertyName = "OCRTableObjectFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunks), TypeInfoPropertyName = "SystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ImageDetail?), TypeInfoPropertyName = "NullableImageDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.ImageURL, string>?), TypeInfoPropertyName = "NullableAnyOfImageURLString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ResponseFormats?), TypeInfoPropertyName = "NullableResponseFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ContentChunk?), TypeInfoPropertyName = "NullableContentChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.BlocksVariant1Item?), TypeInfoPropertyName = "NullableBlocksVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableOCRPageObjectBlocksVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.FileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk>?), TypeInfoPropertyName = "NullableAnyOfFileChunkDocumentURLChunkImageURLChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<int>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRRequestTableFormat?), TypeInfoPropertyName = "NullableOCRRequestTableFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRRequestConfidenceScoresGranularity?), TypeInfoPropertyName = "NullableOCRRequestConfidenceScoresGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.OCRTableObjectFormat?), TypeInfoPropertyName = "NullableOCRTableObjectFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SystemMessageContentChunks?), TypeInfoPropertyName = "NullableSystemMessageContentChunks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OCRConfidenceScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OCRImageObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OCRTableObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.BlocksVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, global::System.Collections.Generic.List<int>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.OCRPageObject>))]
    internal sealed partial class OcrSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OcrSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OcrSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OcrSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Mistral.JsonConverters.BlocksVariant1ItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.ContentChunkJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.SystemMessageContentChunksJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ImageURL, string>());
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
                    typeToConvert == typeof(global::Mistral.ImageDetail)

                    || typeToConvert == typeof(global::Mistral.ImageDetail?)

                    || typeToConvert == typeof(global::Mistral.ResponseFormats)

                    || typeToConvert == typeof(global::Mistral.ResponseFormats?)

                    || typeToConvert == typeof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.OCRRequestTableFormat)

                    || typeToConvert == typeof(global::Mistral.OCRRequestTableFormat?)

                    || typeToConvert == typeof(global::Mistral.OCRRequestConfidenceScoresGranularity)

                    || typeToConvert == typeof(global::Mistral.OCRRequestConfidenceScoresGranularity?)

                    || typeToConvert == typeof(global::Mistral.OCRTableObjectFormat)

                    || typeToConvert == typeof(global::Mistral.OCRTableObjectFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Mistral.ImageDetail))
                {
                    return new global::Mistral.JsonConverters.ImageDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ImageDetail?))
                {
                    return new global::Mistral.JsonConverters.ImageDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ResponseFormats))
                {
                    return new global::Mistral.JsonConverters.ResponseFormatsJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ResponseFormats?))
                {
                    return new global::Mistral.JsonConverters.ResponseFormatsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.OCRPageObjectBlocksVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.OCRPageObjectBlocksVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRRequestTableFormat))
                {
                    return new global::Mistral.JsonConverters.OCRRequestTableFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRRequestTableFormat?))
                {
                    return new global::Mistral.JsonConverters.OCRRequestTableFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRRequestConfidenceScoresGranularity))
                {
                    return new global::Mistral.JsonConverters.OCRRequestConfidenceScoresGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRRequestConfidenceScoresGranularity?))
                {
                    return new global::Mistral.JsonConverters.OCRRequestConfidenceScoresGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRTableObjectFormat))
                {
                    return new global::Mistral.JsonConverters.OCRTableObjectFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.OCRTableObjectFormat?))
                {
                    return new global::Mistral.JsonConverters.OCRTableObjectFormatNullableJsonConverter();
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
                    0 => new OcrSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}