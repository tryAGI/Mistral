#nullable enable

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public sealed class CompletionDetailedJobOutStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.CompletionDetailedJobOutStatus>
    {
        /// <inheritdoc />
        public override global::Mistral.CompletionDetailedJobOutStatus Read(
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
                        return global::Mistral.CompletionDetailedJobOutStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mistral.CompletionDetailedJobOutStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mistral.CompletionDetailedJobOutStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.CompletionDetailedJobOutStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Mistral.CompletionDetailedJobOutStatusExtensions.ToValueString(value));
        }
    }
}
