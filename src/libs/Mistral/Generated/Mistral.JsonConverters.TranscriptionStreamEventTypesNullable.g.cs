#nullable enable

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public sealed class TranscriptionStreamEventTypesNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.TranscriptionStreamEventTypes?>
    {
        /// <inheritdoc />
        public override global::Mistral.TranscriptionStreamEventTypes? Read(
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
                        return global::Mistral.TranscriptionStreamEventTypesExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mistral.TranscriptionStreamEventTypes)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mistral.TranscriptionStreamEventTypes?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.TranscriptionStreamEventTypes? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mistral.TranscriptionStreamEventTypesExtensions.ToValueString(value.Value));
            }
        }
    }
}
