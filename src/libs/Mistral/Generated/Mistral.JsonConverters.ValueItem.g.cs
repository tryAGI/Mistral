#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class ValueItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ValueItem>
    {
        /// <inheritdoc />
        public override global::Mistral.ValueItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JSONPatchPayloadResponseValueItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JSONPatchPayloadResponseValueItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.JSONPatchAppend? append = default;
            if (discriminator?.Op == global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp.Append)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JSONPatchAppend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JSONPatchAppend> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JSONPatchAppend)}");
                append = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.JSONPatchAdd? add = default;
            if (discriminator?.Op == global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp.Add)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JSONPatchAdd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JSONPatchAdd> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JSONPatchAdd)}");
                add = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.JSONPatchReplace? replace = default;
            if (discriminator?.Op == global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp.Replace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JSONPatchReplace), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JSONPatchReplace> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JSONPatchReplace)}");
                replace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.JSONPatchRemove? remove = default;
            if (discriminator?.Op == global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp.Remove)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JSONPatchRemove), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JSONPatchRemove> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.JSONPatchRemove)}");
                remove = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mistral.ValueItem(
                discriminator?.Op,
                append,

                add,

                replace,

                remove
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ValueItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JSONPatchAppend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JSONPatchAppend?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.JSONPatchAppend).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Append, typeInfo);
            }
            else if (value.IsAdd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JSONPatchAdd), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JSONPatchAdd?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.JSONPatchAdd).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Add, typeInfo);
            }
            else if (value.IsReplace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JSONPatchReplace), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JSONPatchReplace?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.JSONPatchReplace).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Replace, typeInfo);
            }
            else if (value.IsRemove)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.JSONPatchRemove), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.JSONPatchRemove?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.JSONPatchRemove).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Remove, typeInfo);
            }
        }
    }
}