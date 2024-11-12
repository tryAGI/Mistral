#nullable enable

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatClassificationRequestInputVariant2ItemItemDiscriminatorRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole>
    {
        /// <inheritdoc />
        public override global::Mistral.ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole Read(
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
                        return global::Mistral.ChatClassificationRequestInputVariant2ItemItemDiscriminatorRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mistral.ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Mistral.ChatClassificationRequestInputVariant2ItemItemDiscriminatorRoleExtensions.ToValueString(value));
        }
    }
}