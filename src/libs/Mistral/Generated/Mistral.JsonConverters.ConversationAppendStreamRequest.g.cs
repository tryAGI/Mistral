#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class ConversationAppendStreamRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ConversationAppendStreamRequest>
    {
        /// <inheritdoc />
        public override global::Mistral.ConversationAppendStreamRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::Mistral.ConversationAppendRequestBase? conversationAppendRequest = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationAppendRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationAppendRequestBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationAppendRequestBase).Name}");
                conversationAppendRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::Mistral.ConversationAppendStreamRequestVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationAppendStreamRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationAppendStreamRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationAppendStreamRequestVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::Mistral.ConversationAppendStreamRequest(
                conversationAppendRequest,

                value2
                );

            if (conversationAppendRequest != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationAppendRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationAppendRequestBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationAppendRequestBase).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationAppendStreamRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationAppendStreamRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationAppendStreamRequestVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ConversationAppendStreamRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConversationAppendRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationAppendRequestBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationAppendRequestBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationAppendRequestBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationAppendRequest, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationAppendStreamRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationAppendStreamRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ConversationAppendStreamRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}