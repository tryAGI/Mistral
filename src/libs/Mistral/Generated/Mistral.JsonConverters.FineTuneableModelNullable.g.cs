#nullable enable

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public sealed class FineTuneableModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.FineTuneableModel?>
    {
        /// <inheritdoc />
        public override global::Mistral.FineTuneableModel? Read(
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
                        return global::Mistral.FineTuneableModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mistral.FineTuneableModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mistral.FineTuneableModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.FineTuneableModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Mistral.FineTuneableModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
