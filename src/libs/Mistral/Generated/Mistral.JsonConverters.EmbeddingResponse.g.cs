#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.EmbeddingResponse>
    {
        /// <inheritdoc />
        public override global::Mistral.EmbeddingResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Mistral.ResponseBase? responseBase = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ResponseBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ResponseBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ResponseBase).Name}");
                responseBase = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Mistral.EmbeddingResponseVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.EmbeddingResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.EmbeddingResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.EmbeddingResponseVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::Mistral.EmbeddingResponse(
                responseBase,

                value2
                );

            if (responseBase != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ResponseBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ResponseBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ResponseBase).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.EmbeddingResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.EmbeddingResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.EmbeddingResponseVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.EmbeddingResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponseBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ResponseBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ResponseBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ResponseBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseBase, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.EmbeddingResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.EmbeddingResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.EmbeddingResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}