#nullable enable

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetStreamEventsV1WorkflowsEventsStreamGetScopeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope>
    {
        /// <inheritdoc />
        public override global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope Read(
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
                        return global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScopeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScopeExtensions.ToValueString(value));
        }
    }
}
