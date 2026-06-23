#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BlocksVariant1Item : global::System.IEquatable<BlocksVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OCRTextBlock? Text { get; init; }
#else
        public global::Mistral.OCRTextBlock? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.OCRTextBlock? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRTextBlock PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OCRListBlock? List { get; init; }
#else
        public global::Mistral.OCRListBlock? List { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(List))]
#endif
        public bool IsList => List != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickList(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.OCRListBlock? value)
        {
            value = List;
            return IsList;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRListBlock PickList() => IsList
            ? List!
            : throw new global::System.InvalidOperationException($"Expected union variant 'List' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OCRImageBlock? Image { get; init; }
#else
        public global::Mistral.OCRImageBlock? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.OCRImageBlock? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRImageBlock PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OCRTableBlock? Table { get; init; }
#else
        public global::Mistral.OCRTableBlock? Table { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Table))]
#endif
        public bool IsTable => Table != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.OCRTableBlock? value)
        {
            value = Table;
            return IsTable;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRTableBlock PickTable() => IsTable
            ? Table!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Table' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OCRTitleBlock? Title { get; init; }
#else
        public global::Mistral.OCRTitleBlock? Title { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Title))]
#endif
        public bool IsTitle => Title != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTitle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.OCRTitleBlock? value)
        {
            value = Title;
            return IsTitle;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRTitleBlock PickTitle() => IsTitle
            ? Title!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Title' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OCREquationBlock? Equation { get; init; }
#else
        public global::Mistral.OCREquationBlock? Equation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Equation))]
#endif
        public bool IsEquation => Equation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEquation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.OCREquationBlock? value)
        {
            value = Equation;
            return IsEquation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCREquationBlock PickEquation() => IsEquation
            ? Equation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Equation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OCRCaptionBlock? Caption { get; init; }
#else
        public global::Mistral.OCRCaptionBlock? Caption { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Caption))]
#endif
        public bool IsCaption => Caption != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCaption(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.OCRCaptionBlock? value)
        {
            value = Caption;
            return IsCaption;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRCaptionBlock PickCaption() => IsCaption
            ? Caption!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Caption' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OCRCodeBlock? Code { get; init; }
#else
        public global::Mistral.OCRCodeBlock? Code { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.OCRCodeBlock? value)
        {
            value = Code;
            return IsCode;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRCodeBlock PickCode() => IsCode
            ? Code!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Code' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OCRReferencesBlock? References { get; init; }
#else
        public global::Mistral.OCRReferencesBlock? References { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(References))]
#endif
        public bool IsReferences => References != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReferences(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.OCRReferencesBlock? value)
        {
            value = References;
            return IsReferences;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRReferencesBlock PickReferences() => IsReferences
            ? References!
            : throw new global::System.InvalidOperationException($"Expected union variant 'References' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OCRAsideTextBlock? AsideText { get; init; }
#else
        public global::Mistral.OCRAsideTextBlock? AsideText { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AsideText))]
#endif
        public bool IsAsideText => AsideText != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAsideText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.OCRAsideTextBlock? value)
        {
            value = AsideText;
            return IsAsideText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRAsideTextBlock PickAsideText() => IsAsideText
            ? AsideText!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AsideText' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OCRHeaderBlock? Header { get; init; }
#else
        public global::Mistral.OCRHeaderBlock? Header { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Header))]
#endif
        public bool IsHeader => Header != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHeader(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.OCRHeaderBlock? value)
        {
            value = Header;
            return IsHeader;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRHeaderBlock PickHeader() => IsHeader
            ? Header!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Header' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OCRFooterBlock? Footer { get; init; }
#else
        public global::Mistral.OCRFooterBlock? Footer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Footer))]
#endif
        public bool IsFooter => Footer != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFooter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.OCRFooterBlock? value)
        {
            value = Footer;
            return IsFooter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRFooterBlock PickFooter() => IsFooter
            ? Footer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Footer' but the value was {ToString()}.");

        /// <summary>
        /// Signature region. ``content`` is the transcribed name when legible, else ``""``.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OCRSignatureBlock? Signature { get; init; }
#else
        public global::Mistral.OCRSignatureBlock? Signature { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Signature))]
#endif
        public bool IsSignature => Signature != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSignature(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.OCRSignatureBlock? value)
        {
            value = Signature;
            return IsSignature;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRSignatureBlock PickSignature() => IsSignature
            ? Signature!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Signature' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlocksVariant1Item(global::Mistral.OCRTextBlock value) => new BlocksVariant1Item((global::Mistral.OCRTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OCRTextBlock?(BlocksVariant1Item @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(global::Mistral.OCRTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BlocksVariant1Item FromText(global::Mistral.OCRTextBlock? value) => new BlocksVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlocksVariant1Item(global::Mistral.OCRListBlock value) => new BlocksVariant1Item((global::Mistral.OCRListBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OCRListBlock?(BlocksVariant1Item @this) => @this.List;

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(global::Mistral.OCRListBlock? value)
        {
            List = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BlocksVariant1Item FromList(global::Mistral.OCRListBlock? value) => new BlocksVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlocksVariant1Item(global::Mistral.OCRImageBlock value) => new BlocksVariant1Item((global::Mistral.OCRImageBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OCRImageBlock?(BlocksVariant1Item @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(global::Mistral.OCRImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BlocksVariant1Item FromImage(global::Mistral.OCRImageBlock? value) => new BlocksVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlocksVariant1Item(global::Mistral.OCRTableBlock value) => new BlocksVariant1Item((global::Mistral.OCRTableBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OCRTableBlock?(BlocksVariant1Item @this) => @this.Table;

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(global::Mistral.OCRTableBlock? value)
        {
            Table = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BlocksVariant1Item FromTable(global::Mistral.OCRTableBlock? value) => new BlocksVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlocksVariant1Item(global::Mistral.OCRTitleBlock value) => new BlocksVariant1Item((global::Mistral.OCRTitleBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OCRTitleBlock?(BlocksVariant1Item @this) => @this.Title;

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(global::Mistral.OCRTitleBlock? value)
        {
            Title = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BlocksVariant1Item FromTitle(global::Mistral.OCRTitleBlock? value) => new BlocksVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlocksVariant1Item(global::Mistral.OCREquationBlock value) => new BlocksVariant1Item((global::Mistral.OCREquationBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OCREquationBlock?(BlocksVariant1Item @this) => @this.Equation;

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(global::Mistral.OCREquationBlock? value)
        {
            Equation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BlocksVariant1Item FromEquation(global::Mistral.OCREquationBlock? value) => new BlocksVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlocksVariant1Item(global::Mistral.OCRCaptionBlock value) => new BlocksVariant1Item((global::Mistral.OCRCaptionBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OCRCaptionBlock?(BlocksVariant1Item @this) => @this.Caption;

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(global::Mistral.OCRCaptionBlock? value)
        {
            Caption = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BlocksVariant1Item FromCaption(global::Mistral.OCRCaptionBlock? value) => new BlocksVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlocksVariant1Item(global::Mistral.OCRCodeBlock value) => new BlocksVariant1Item((global::Mistral.OCRCodeBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OCRCodeBlock?(BlocksVariant1Item @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(global::Mistral.OCRCodeBlock? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BlocksVariant1Item FromCode(global::Mistral.OCRCodeBlock? value) => new BlocksVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlocksVariant1Item(global::Mistral.OCRReferencesBlock value) => new BlocksVariant1Item((global::Mistral.OCRReferencesBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OCRReferencesBlock?(BlocksVariant1Item @this) => @this.References;

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(global::Mistral.OCRReferencesBlock? value)
        {
            References = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BlocksVariant1Item FromReferences(global::Mistral.OCRReferencesBlock? value) => new BlocksVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlocksVariant1Item(global::Mistral.OCRAsideTextBlock value) => new BlocksVariant1Item((global::Mistral.OCRAsideTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OCRAsideTextBlock?(BlocksVariant1Item @this) => @this.AsideText;

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(global::Mistral.OCRAsideTextBlock? value)
        {
            AsideText = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BlocksVariant1Item FromAsideText(global::Mistral.OCRAsideTextBlock? value) => new BlocksVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlocksVariant1Item(global::Mistral.OCRHeaderBlock value) => new BlocksVariant1Item((global::Mistral.OCRHeaderBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OCRHeaderBlock?(BlocksVariant1Item @this) => @this.Header;

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(global::Mistral.OCRHeaderBlock? value)
        {
            Header = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BlocksVariant1Item FromHeader(global::Mistral.OCRHeaderBlock? value) => new BlocksVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlocksVariant1Item(global::Mistral.OCRFooterBlock value) => new BlocksVariant1Item((global::Mistral.OCRFooterBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OCRFooterBlock?(BlocksVariant1Item @this) => @this.Footer;

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(global::Mistral.OCRFooterBlock? value)
        {
            Footer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BlocksVariant1Item FromFooter(global::Mistral.OCRFooterBlock? value) => new BlocksVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlocksVariant1Item(global::Mistral.OCRSignatureBlock value) => new BlocksVariant1Item((global::Mistral.OCRSignatureBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OCRSignatureBlock?(BlocksVariant1Item @this) => @this.Signature;

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(global::Mistral.OCRSignatureBlock? value)
        {
            Signature = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BlocksVariant1Item FromSignature(global::Mistral.OCRSignatureBlock? value) => new BlocksVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public BlocksVariant1Item(
            global::Mistral.OCRPageObjectBlocksVariant1ItemDiscriminatorType? type,
            global::Mistral.OCRTextBlock? text,
            global::Mistral.OCRListBlock? list,
            global::Mistral.OCRImageBlock? image,
            global::Mistral.OCRTableBlock? table,
            global::Mistral.OCRTitleBlock? title,
            global::Mistral.OCREquationBlock? equation,
            global::Mistral.OCRCaptionBlock? caption,
            global::Mistral.OCRCodeBlock? code,
            global::Mistral.OCRReferencesBlock? references,
            global::Mistral.OCRAsideTextBlock? asideText,
            global::Mistral.OCRHeaderBlock? header,
            global::Mistral.OCRFooterBlock? footer,
            global::Mistral.OCRSignatureBlock? signature
            )
        {
            Type = type;

            Text = text;
            List = list;
            Image = image;
            Table = table;
            Title = title;
            Equation = equation;
            Caption = caption;
            Code = code;
            References = references;
            AsideText = asideText;
            Header = header;
            Footer = footer;
            Signature = signature;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Signature as object ??
            Footer as object ??
            Header as object ??
            AsideText as object ??
            References as object ??
            Code as object ??
            Caption as object ??
            Equation as object ??
            Title as object ??
            Table as object ??
            Image as object ??
            List as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            List?.ToString() ??
            Image?.ToString() ??
            Table?.ToString() ??
            Title?.ToString() ??
            Equation?.ToString() ??
            Caption?.ToString() ??
            Code?.ToString() ??
            References?.ToString() ??
            AsideText?.ToString() ??
            Header?.ToString() ??
            Footer?.ToString() ??
            Signature?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsList && !IsImage && !IsTable && !IsTitle && !IsEquation && !IsCaption && !IsCode && !IsReferences && !IsAsideText && !IsHeader && !IsFooter && !IsSignature || !IsText && IsList && !IsImage && !IsTable && !IsTitle && !IsEquation && !IsCaption && !IsCode && !IsReferences && !IsAsideText && !IsHeader && !IsFooter && !IsSignature || !IsText && !IsList && IsImage && !IsTable && !IsTitle && !IsEquation && !IsCaption && !IsCode && !IsReferences && !IsAsideText && !IsHeader && !IsFooter && !IsSignature || !IsText && !IsList && !IsImage && IsTable && !IsTitle && !IsEquation && !IsCaption && !IsCode && !IsReferences && !IsAsideText && !IsHeader && !IsFooter && !IsSignature || !IsText && !IsList && !IsImage && !IsTable && IsTitle && !IsEquation && !IsCaption && !IsCode && !IsReferences && !IsAsideText && !IsHeader && !IsFooter && !IsSignature || !IsText && !IsList && !IsImage && !IsTable && !IsTitle && IsEquation && !IsCaption && !IsCode && !IsReferences && !IsAsideText && !IsHeader && !IsFooter && !IsSignature || !IsText && !IsList && !IsImage && !IsTable && !IsTitle && !IsEquation && IsCaption && !IsCode && !IsReferences && !IsAsideText && !IsHeader && !IsFooter && !IsSignature || !IsText && !IsList && !IsImage && !IsTable && !IsTitle && !IsEquation && !IsCaption && IsCode && !IsReferences && !IsAsideText && !IsHeader && !IsFooter && !IsSignature || !IsText && !IsList && !IsImage && !IsTable && !IsTitle && !IsEquation && !IsCaption && !IsCode && IsReferences && !IsAsideText && !IsHeader && !IsFooter && !IsSignature || !IsText && !IsList && !IsImage && !IsTable && !IsTitle && !IsEquation && !IsCaption && !IsCode && !IsReferences && IsAsideText && !IsHeader && !IsFooter && !IsSignature || !IsText && !IsList && !IsImage && !IsTable && !IsTitle && !IsEquation && !IsCaption && !IsCode && !IsReferences && !IsAsideText && IsHeader && !IsFooter && !IsSignature || !IsText && !IsList && !IsImage && !IsTable && !IsTitle && !IsEquation && !IsCaption && !IsCode && !IsReferences && !IsAsideText && !IsHeader && IsFooter && !IsSignature || !IsText && !IsList && !IsImage && !IsTable && !IsTitle && !IsEquation && !IsCaption && !IsCode && !IsReferences && !IsAsideText && !IsHeader && !IsFooter && IsSignature;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.OCRTextBlock, TResult>? text = null,
            global::System.Func<global::Mistral.OCRListBlock, TResult>? list = null,
            global::System.Func<global::Mistral.OCRImageBlock, TResult>? image = null,
            global::System.Func<global::Mistral.OCRTableBlock, TResult>? table = null,
            global::System.Func<global::Mistral.OCRTitleBlock, TResult>? title = null,
            global::System.Func<global::Mistral.OCREquationBlock, TResult>? equation = null,
            global::System.Func<global::Mistral.OCRCaptionBlock, TResult>? caption = null,
            global::System.Func<global::Mistral.OCRCodeBlock, TResult>? code = null,
            global::System.Func<global::Mistral.OCRReferencesBlock, TResult>? references = null,
            global::System.Func<global::Mistral.OCRAsideTextBlock, TResult>? asideText = null,
            global::System.Func<global::Mistral.OCRHeaderBlock, TResult>? header = null,
            global::System.Func<global::Mistral.OCRFooterBlock, TResult>? footer = null,
            global::System.Func<global::Mistral.OCRSignatureBlock, TResult>? signature = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsList && list != null)
            {
                return list(List!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsTable && table != null)
            {
                return table(Table!);
            }
            else if (IsTitle && title != null)
            {
                return title(Title!);
            }
            else if (IsEquation && equation != null)
            {
                return equation(Equation!);
            }
            else if (IsCaption && caption != null)
            {
                return caption(Caption!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsReferences && references != null)
            {
                return references(References!);
            }
            else if (IsAsideText && asideText != null)
            {
                return asideText(AsideText!);
            }
            else if (IsHeader && header != null)
            {
                return header(Header!);
            }
            else if (IsFooter && footer != null)
            {
                return footer(Footer!);
            }
            else if (IsSignature && signature != null)
            {
                return signature(Signature!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.OCRTextBlock>? text = null,

            global::System.Action<global::Mistral.OCRListBlock>? list = null,

            global::System.Action<global::Mistral.OCRImageBlock>? image = null,

            global::System.Action<global::Mistral.OCRTableBlock>? table = null,

            global::System.Action<global::Mistral.OCRTitleBlock>? title = null,

            global::System.Action<global::Mistral.OCREquationBlock>? equation = null,

            global::System.Action<global::Mistral.OCRCaptionBlock>? caption = null,

            global::System.Action<global::Mistral.OCRCodeBlock>? code = null,

            global::System.Action<global::Mistral.OCRReferencesBlock>? references = null,

            global::System.Action<global::Mistral.OCRAsideTextBlock>? asideText = null,

            global::System.Action<global::Mistral.OCRHeaderBlock>? header = null,

            global::System.Action<global::Mistral.OCRFooterBlock>? footer = null,

            global::System.Action<global::Mistral.OCRSignatureBlock>? signature = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsList)
            {
                list?.Invoke(List!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsTable)
            {
                table?.Invoke(Table!);
            }
            else if (IsTitle)
            {
                title?.Invoke(Title!);
            }
            else if (IsEquation)
            {
                equation?.Invoke(Equation!);
            }
            else if (IsCaption)
            {
                caption?.Invoke(Caption!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsReferences)
            {
                references?.Invoke(References!);
            }
            else if (IsAsideText)
            {
                asideText?.Invoke(AsideText!);
            }
            else if (IsHeader)
            {
                header?.Invoke(Header!);
            }
            else if (IsFooter)
            {
                footer?.Invoke(Footer!);
            }
            else if (IsSignature)
            {
                signature?.Invoke(Signature!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Mistral.OCRTextBlock>? text = null,
            global::System.Action<global::Mistral.OCRListBlock>? list = null,
            global::System.Action<global::Mistral.OCRImageBlock>? image = null,
            global::System.Action<global::Mistral.OCRTableBlock>? table = null,
            global::System.Action<global::Mistral.OCRTitleBlock>? title = null,
            global::System.Action<global::Mistral.OCREquationBlock>? equation = null,
            global::System.Action<global::Mistral.OCRCaptionBlock>? caption = null,
            global::System.Action<global::Mistral.OCRCodeBlock>? code = null,
            global::System.Action<global::Mistral.OCRReferencesBlock>? references = null,
            global::System.Action<global::Mistral.OCRAsideTextBlock>? asideText = null,
            global::System.Action<global::Mistral.OCRHeaderBlock>? header = null,
            global::System.Action<global::Mistral.OCRFooterBlock>? footer = null,
            global::System.Action<global::Mistral.OCRSignatureBlock>? signature = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsList)
            {
                list?.Invoke(List!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsTable)
            {
                table?.Invoke(Table!);
            }
            else if (IsTitle)
            {
                title?.Invoke(Title!);
            }
            else if (IsEquation)
            {
                equation?.Invoke(Equation!);
            }
            else if (IsCaption)
            {
                caption?.Invoke(Caption!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsReferences)
            {
                references?.Invoke(References!);
            }
            else if (IsAsideText)
            {
                asideText?.Invoke(AsideText!);
            }
            else if (IsHeader)
            {
                header?.Invoke(Header!);
            }
            else if (IsFooter)
            {
                footer?.Invoke(Footer!);
            }
            else if (IsSignature)
            {
                signature?.Invoke(Signature!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Mistral.OCRTextBlock),
                List,
                typeof(global::Mistral.OCRListBlock),
                Image,
                typeof(global::Mistral.OCRImageBlock),
                Table,
                typeof(global::Mistral.OCRTableBlock),
                Title,
                typeof(global::Mistral.OCRTitleBlock),
                Equation,
                typeof(global::Mistral.OCREquationBlock),
                Caption,
                typeof(global::Mistral.OCRCaptionBlock),
                Code,
                typeof(global::Mistral.OCRCodeBlock),
                References,
                typeof(global::Mistral.OCRReferencesBlock),
                AsideText,
                typeof(global::Mistral.OCRAsideTextBlock),
                Header,
                typeof(global::Mistral.OCRHeaderBlock),
                Footer,
                typeof(global::Mistral.OCRFooterBlock),
                Signature,
                typeof(global::Mistral.OCRSignatureBlock),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(BlocksVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OCRTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OCRListBlock?>.Default.Equals(List, other.List) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OCRImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OCRTableBlock?>.Default.Equals(Table, other.Table) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OCRTitleBlock?>.Default.Equals(Title, other.Title) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OCREquationBlock?>.Default.Equals(Equation, other.Equation) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OCRCaptionBlock?>.Default.Equals(Caption, other.Caption) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OCRCodeBlock?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OCRReferencesBlock?>.Default.Equals(References, other.References) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OCRAsideTextBlock?>.Default.Equals(AsideText, other.AsideText) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OCRHeaderBlock?>.Default.Equals(Header, other.Header) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OCRFooterBlock?>.Default.Equals(Footer, other.Footer) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OCRSignatureBlock?>.Default.Equals(Signature, other.Signature) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BlocksVariant1Item obj1, BlocksVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BlocksVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BlocksVariant1Item obj1, BlocksVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BlocksVariant1Item o && Equals(o);
        }
    }
}
