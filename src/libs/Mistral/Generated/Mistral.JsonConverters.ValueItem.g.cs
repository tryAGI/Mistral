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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JSONPatchPayloadResponseValueItemDiscriminator>(ref readerCopy, options);

            global::Mistral.JSONPatchAppend? append = default;
            if (discriminator?.Op == global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp.Append)
            {
                append = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JSONPatchAppend>(ref reader, options);
            }
            global::Mistral.JSONPatchAdd? add = default;
            if (discriminator?.Op == global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp.Add)
            {
                add = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JSONPatchAdd>(ref reader, options);
            }
            global::Mistral.JSONPatchReplace? replace = default;
            if (discriminator?.Op == global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp.Replace)
            {
                replace = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JSONPatchReplace>(ref reader, options);
            }
            global::Mistral.JSONPatchRemove? remove = default;
            if (discriminator?.Op == global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp.Remove)
            {
                remove = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.JSONPatchRemove>(ref reader, options);
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

            if (value.IsAppend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Append, typeof(global::Mistral.JSONPatchAppend), options);
            }
            else if (value.IsAdd)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Add, typeof(global::Mistral.JSONPatchAdd), options);
            }
            else if (value.IsReplace)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Replace, typeof(global::Mistral.JSONPatchReplace), options);
            }
            else if (value.IsRemove)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Remove, typeof(global::Mistral.JSONPatchRemove), options);
            }
        }
    }
}