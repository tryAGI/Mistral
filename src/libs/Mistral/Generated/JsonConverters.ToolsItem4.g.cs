#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItem4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ToolsItem4>
    {
        /// <inheritdoc />
        public override global::Mistral.ToolsItem4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ConversationRequestBaseToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ConversationRequestBaseToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ConversationRequestBaseToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.FunctionTool? function = default;
            if (discriminator?.Type == global::Mistral.ConversationRequestBaseToolDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.FunctionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.FunctionTool)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.WebSearchTool? webSearch = default;
            if (discriminator?.Type == global::Mistral.ConversationRequestBaseToolDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.WebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.WebSearchTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.WebSearchTool)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.WebSearchPremiumTool? webSearchPremium = default;
            if (discriminator?.Type == global::Mistral.ConversationRequestBaseToolDiscriminatorType.WebSearchPremium)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.WebSearchPremiumTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.WebSearchPremiumTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.WebSearchPremiumTool)}");
                webSearchPremium = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.CodeInterpreterTool? codeInterpreter = default;
            if (discriminator?.Type == global::Mistral.ConversationRequestBaseToolDiscriminatorType.CodeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.CodeInterpreterTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.CodeInterpreterTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.CodeInterpreterTool)}");
                codeInterpreter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.ImageGenerationTool? imageGeneration = default;
            if (discriminator?.Type == global::Mistral.ConversationRequestBaseToolDiscriminatorType.ImageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ImageGenerationTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ImageGenerationTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.ImageGenerationTool)}");
                imageGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.DocumentLibraryTool? documentLibrary = default;
            if (discriminator?.Type == global::Mistral.ConversationRequestBaseToolDiscriminatorType.DocumentLibrary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.DocumentLibraryTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.DocumentLibraryTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.DocumentLibraryTool)}");
                documentLibrary = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Mistral.ToolsItem4(
                discriminator?.Type,
                function,
                webSearch,
                webSearchPremium,
                codeInterpreter,
                imageGeneration,
                documentLibrary
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ToolsItem4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.FunctionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.FunctionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.WebSearchTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.WebSearchTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.WebSearchTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch, typeInfo);
            }
            else if (value.IsWebSearchPremium)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.WebSearchPremiumTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.WebSearchPremiumTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.WebSearchPremiumTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchPremium, typeInfo);
            }
            else if (value.IsCodeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.CodeInterpreterTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.CodeInterpreterTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.CodeInterpreterTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreter, typeInfo);
            }
            else if (value.IsImageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.ImageGenerationTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.ImageGenerationTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.ImageGenerationTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGeneration, typeInfo);
            }
            else if (value.IsDocumentLibrary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.DocumentLibraryTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.DocumentLibraryTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.DocumentLibraryTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentLibrary, typeInfo);
            }
        }
    }
}