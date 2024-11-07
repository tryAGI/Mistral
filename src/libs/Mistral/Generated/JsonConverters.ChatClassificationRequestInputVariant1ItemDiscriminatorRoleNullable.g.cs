#nullable enable

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatClassificationRequestInputVariant1ItemDiscriminatorRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminatorRole?>
    {
        /// <inheritdoc />
        public override global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminatorRole? Read(
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
                        return global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminatorRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminatorRole)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminatorRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminatorRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
