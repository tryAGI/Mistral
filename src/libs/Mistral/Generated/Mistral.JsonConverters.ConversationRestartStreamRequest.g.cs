#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class ConversationRestartStreamRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ConversationRestartStreamRequest>
    {
        /// <inheritdoc />
        public override global::Mistral.ConversationRestartStreamRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Mistral.ConversationRestartRequestBase? conversationRestartRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRestartRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRestartRequestBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRestartRequestBase).Name}");
                conversationRestartRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Mistral.ConversationRestartStreamRequestVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRestartStreamRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRestartStreamRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRestartStreamRequestVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::Mistral.ConversationRestartStreamRequest(
                conversationRestartRequest,

                value2
                );

            if (conversationRestartRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRestartRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRestartRequestBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRestartRequestBase).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRestartStreamRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRestartStreamRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRestartStreamRequestVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ConversationRestartStreamRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConversationRestartRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRestartRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRestartRequestBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRestartRequestBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationRestartRequest, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRestartStreamRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRestartStreamRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRestartStreamRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}