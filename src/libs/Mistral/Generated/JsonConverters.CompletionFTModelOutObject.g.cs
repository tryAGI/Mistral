#nullable enable

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public sealed class CompletionFTModelOutObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.CompletionFTModelOutObject>
    {
        /// <inheritdoc />
        public override global::Mistral.CompletionFTModelOutObject Read(
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
                        return global::Mistral.CompletionFTModelOutObjectExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mistral.CompletionFTModelOutObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mistral.CompletionFTModelOutObject);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.CompletionFTModelOutObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Mistral.CompletionFTModelOutObjectExtensions.ToValueString(value));
        }
    }
}
