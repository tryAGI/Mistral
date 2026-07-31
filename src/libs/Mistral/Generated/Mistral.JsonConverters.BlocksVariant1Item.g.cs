#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class BlocksVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.BlocksVariant1Item>
    {
        /// <inheritdoc />
        public override global::Mistral.BlocksVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mistral.OCRTextBlock? text = default;
            if (discriminator?.Type == global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRTextBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCRTextBlock)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.OCRListBlock? list = default;
            if (discriminator?.Type == global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType.List)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRListBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRListBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCRListBlock)}");
                list = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.OCRImageBlock? image = default;
            if (discriminator?.Type == global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRImageBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRImageBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCRImageBlock)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.OCRTableBlock? table = default;
            if (discriminator?.Type == global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType.Table)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRTableBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRTableBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCRTableBlock)}");
                table = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.OCRTitleBlock? title = default;
            if (discriminator?.Type == global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType.Title)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRTitleBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRTitleBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCRTitleBlock)}");
                title = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.OCREquationBlock? equation = default;
            if (discriminator?.Type == global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType.Equation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCREquationBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCREquationBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCREquationBlock)}");
                equation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.OCRCaptionBlock? caption = default;
            if (discriminator?.Type == global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType.Caption)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRCaptionBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRCaptionBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCRCaptionBlock)}");
                caption = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.OCRCodeBlock? code = default;
            if (discriminator?.Type == global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRCodeBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRCodeBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCRCodeBlock)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.OCRReferencesBlock? references = default;
            if (discriminator?.Type == global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType.References)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRReferencesBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRReferencesBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCRReferencesBlock)}");
                references = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.OCRAsideTextBlock? asideText = default;
            if (discriminator?.Type == global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType.AsideText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRAsideTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRAsideTextBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCRAsideTextBlock)}");
                asideText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.OCRHeaderBlock? header = default;
            if (discriminator?.Type == global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType.Header)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRHeaderBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRHeaderBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCRHeaderBlock)}");
                header = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.OCRFooterBlock? footer = default;
            if (discriminator?.Type == global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType.Footer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRFooterBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRFooterBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCRFooterBlock)}");
                footer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mistral.OCRSignatureBlock? signature = default;
            if (discriminator?.Type == global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType.Signature)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRSignatureBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRSignatureBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mistral.OCRSignatureBlock)}");
                signature = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mistral.BlocksVariant1Item(
                discriminator?.Type,
                text,

                list,

                image,

                table,

                title,

                equation,

                caption,

                code,

                references,

                asideText,

                header,

                footer,

                signature
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.BlocksVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRTextBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OCRTextBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsList)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRListBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRListBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OCRListBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.List!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRImageBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRImageBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OCRImageBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsTable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRTableBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRTableBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OCRTableBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Table!, typeInfo);
            }
            else if (value.IsTitle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRTitleBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRTitleBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OCRTitleBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Title!, typeInfo);
            }
            else if (value.IsEquation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCREquationBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCREquationBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OCREquationBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Equation!, typeInfo);
            }
            else if (value.IsCaption)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRCaptionBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRCaptionBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OCRCaptionBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Caption!, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRCodeBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRCodeBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OCRCodeBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!, typeInfo);
            }
            else if (value.IsReferences)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRReferencesBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRReferencesBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OCRReferencesBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.References!, typeInfo);
            }
            else if (value.IsAsideText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRAsideTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRAsideTextBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OCRAsideTextBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AsideText!, typeInfo);
            }
            else if (value.IsHeader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRHeaderBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRHeaderBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OCRHeaderBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Header!, typeInfo);
            }
            else if (value.IsFooter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRFooterBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRFooterBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OCRFooterBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Footer!, typeInfo);
            }
            else if (value.IsSignature)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mistral.OCRSignatureBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mistral.OCRSignatureBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mistral.OCRSignatureBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Signature!, typeInfo);
            }
        }
    }
}