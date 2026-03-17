#nullable enable

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public sealed class FilesApiRoutesUploadFileRequestVisibilityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.FilesApiRoutesUploadFileRequestVisibility?>
    {
        /// <inheritdoc />
        public override global::Mistral.FilesApiRoutesUploadFileRequestVisibility? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Mistral.FilesApiRoutesUploadFileRequestVisibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mistral.FilesApiRoutesUploadFileRequestVisibility)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mistral.FilesApiRoutesUploadFileRequestVisibility?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.FilesApiRoutesUploadFileRequestVisibility? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mistral.FilesApiRoutesUploadFileRequestVisibilityExtensions.ToValueString(value.Value));
            }
        }
    }
}
