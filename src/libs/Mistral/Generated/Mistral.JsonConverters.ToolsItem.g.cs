#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.ToolsItem>
    {
        /// <inheritdoc />
        public override global::Mistral.ToolsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.AgentToolDiscriminator>(ref readerCopy, options);

            global::Mistral.FunctionTool? function = default;
            if (discriminator?.Type == global::Mistral.AgentToolDiscriminatorType.Function)
            {
                function = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.FunctionTool>(ref reader, options);
            }
            global::Mistral.WebSearchTool? webSearch = default;
            if (discriminator?.Type == global::Mistral.AgentToolDiscriminatorType.WebSearch)
            {
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.WebSearchTool>(ref reader, options);
            }
            global::Mistral.WebSearchPremiumTool? webSearchPremium = default;
            if (discriminator?.Type == global::Mistral.AgentToolDiscriminatorType.WebSearchPremium)
            {
                webSearchPremium = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.WebSearchPremiumTool>(ref reader, options);
            }
            global::Mistral.CodeInterpreterTool? codeInterpreter = default;
            if (discriminator?.Type == global::Mistral.AgentToolDiscriminatorType.CodeInterpreter)
            {
                codeInterpreter = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.CodeInterpreterTool>(ref reader, options);
            }
            global::Mistral.ImageGenerationTool? imageGeneration = default;
            if (discriminator?.Type == global::Mistral.AgentToolDiscriminatorType.ImageGeneration)
            {
                imageGeneration = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ImageGenerationTool>(ref reader, options);
            }
            global::Mistral.DocumentLibraryTool? documentLibrary = default;
            if (discriminator?.Type == global::Mistral.AgentToolDiscriminatorType.DocumentLibrary)
            {
                documentLibrary = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.DocumentLibraryTool>(ref reader, options);
            }
            global::Mistral.CustomConnector? connector = default;
            if (discriminator?.Type == global::Mistral.AgentToolDiscriminatorType.Connector)
            {
                connector = global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.CustomConnector>(ref reader, options);
            }

            var __value = new global::Mistral.ToolsItem(
                discriminator?.Type,
                function,

                webSearch,

                webSearchPremium,

                codeInterpreter,

                imageGeneration,

                documentLibrary,

                connector
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.ToolsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::Mistral.FunctionTool), options);
            }
            else if (value.IsWebSearch)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch, typeof(global::Mistral.WebSearchTool), options);
            }
            else if (value.IsWebSearchPremium)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchPremium, typeof(global::Mistral.WebSearchPremiumTool), options);
            }
            else if (value.IsCodeInterpreter)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreter, typeof(global::Mistral.CodeInterpreterTool), options);
            }
            else if (value.IsImageGeneration)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGeneration, typeof(global::Mistral.ImageGenerationTool), options);
            }
            else if (value.IsDocumentLibrary)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentLibrary, typeof(global::Mistral.DocumentLibraryTool), options);
            }
            else if (value.IsConnector)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Connector, typeof(global::Mistral.CustomConnector), options);
            }
        }
    }
}