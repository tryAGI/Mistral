
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DocumentOut>), TypeInfoPropertyName = "ListDocumentOut_System_Collections_Generic_List_global_Mistral_DocumentOut")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ProcessStatus), TypeInfoPropertyName = "ProcessStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentTextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DocumentUpdateIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<bool>>), TypeInfoPropertyName = "AnyOfBooleanStringInt32DoubleDateTimeIListStringIListInt32IListDoubleIListBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.PaginationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DocumentOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ProcessingStatusOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.LibrariesDocumentsUploadV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ProcessStatus?), TypeInfoPropertyName = "NullableProcessStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<bool>>?), TypeInfoPropertyName = "NullableAnyOfBooleanStringInt32DoubleDateTimeIListStringIListInt32IListDoubleIListBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<int>, global::System.Collections.Generic.List<double>, global::System.Collections.Generic.List<bool>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    internal sealed partial class BetaLibrariesDocumentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaLibrariesDocumentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BetaLibrariesDocumentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BetaLibrariesDocumentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Mistral.ProcessStatus)

                    || typeToConvert == typeof(global::Mistral.ProcessStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Mistral.ProcessStatus))
                {
                    return new global::Mistral.JsonConverters.ProcessStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ProcessStatus?))
                {
                    return new global::Mistral.JsonConverters.ProcessStatusNullableJsonConverter();
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
                    0 => new BetaLibrariesDocumentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}