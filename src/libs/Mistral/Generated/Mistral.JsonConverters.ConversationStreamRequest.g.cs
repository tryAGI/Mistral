#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class ConversationStreamRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ConversationStreamRequest>
    {
        /// <inheritdoc />
        public override global::Mistral.ConversationStreamRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Mistral.ConversationRequestBase? conversationRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRequestBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRequestBase).Name}");
                conversationRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Mistral.ConversationStreamRequestVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationStreamRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationStreamRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationStreamRequestVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::Mistral.ConversationStreamRequest(
                conversationRequest,

                value2
                );

            if (conversationRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRequestBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRequestBase).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationStreamRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationStreamRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationStreamRequestVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ConversationStreamRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConversationRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRequestBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationRequestBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationRequest, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationStreamRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationStreamRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationStreamRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}