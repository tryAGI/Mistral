
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilesApiRoutesUploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility), TypeInfoPropertyName = "FilesApiRoutesUploadFileRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.SampleType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.Source>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilePurpose?), TypeInfoPropertyName = "NullableFilePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FileVisibility?), TypeInfoPropertyName = "NullableFileVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.SampleType?), TypeInfoPropertyName = "NullableSampleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.Source?), TypeInfoPropertyName = "NullableSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility?), TypeInfoPropertyName = "NullableFilesApiRoutesUploadFileRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.FileSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.SampleType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.Source>))]
    internal sealed partial class FilesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FilesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FilesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FilesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Mistral.FilePurpose)

                    || typeToConvert == typeof(global::Mistral.FilePurpose?)

                    || typeToConvert == typeof(global::Mistral.FileVisibility)

                    || typeToConvert == typeof(global::Mistral.FileVisibility?)

                    || typeToConvert == typeof(global::Mistral.SampleType)

                    || typeToConvert == typeof(global::Mistral.SampleType?)

                    || typeToConvert == typeof(global::Mistral.Source)

                    || typeToConvert == typeof(global::Mistral.Source?)

                    || typeToConvert == typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility)

                    || typeToConvert == typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility))
                {
                    return new global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FilesApiRoutesUploadFileRequestVisibility?))
                {
                    return new global::Mistral.JsonConverters.FilesApiRoutesUploadFileRequestVisibilityNullableJsonConverter();
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
                    0 => new FilesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}