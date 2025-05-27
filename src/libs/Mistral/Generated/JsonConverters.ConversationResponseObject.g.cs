#nullable enable

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationResponseObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ConversationResponseObject>
    {
        /// <inheritdoc />
        public override global::Mistral.ConversationResponseObject Read(
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
                        return global::Mistral.ConversationResponseObjectExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mistral.ConversationResponseObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mistral.ConversationResponseObject);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ConversationResponseObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Mistral.ConversationResponseObjectExtensions.ToValueString(value));
        }
    }
}
