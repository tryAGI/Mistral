#nullable enable

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolExecutionTaskSupportNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ToolExecutionTaskSupport?>
    {
        /// <inheritdoc />
        public override global::Mistral.ToolExecutionTaskSupport? Read(
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
                        return global::Mistral.ToolExecutionTaskSupportExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mistral.ToolExecutionTaskSupport)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mistral.ToolExecutionTaskSupport?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ToolExecutionTaskSupport? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mistral.ToolExecutionTaskSupportExtensions.ToValueString(value.Value));
            }
        }
    }
}
