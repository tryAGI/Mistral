#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputContentChunks : global::System.IEquatable<OutputContentChunks>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.TextChunk? TextChunk { get; init; }
#else
        public global::Mistral.TextChunk? TextChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextChunk))]
#endif
        public bool IsTextChunk => TextChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputContentChunks(global::Mistral.TextChunk value) => new OutputContentChunks((global::Mistral.TextChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.TextChunk?(OutputContentChunks @this) => @this.TextChunk;

        /// <summary>
        /// 
        /// </summary>
        public OutputContentChunks(global::Mistral.TextChunk? value)
        {
            TextChunk = value;
        }

        /// <summary>
        /// {"type":"image_url","image_url":{"url":"data:image/png;base64,iVBORw0
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ImageURLChunk? ImageURLChunk { get; init; }
#else
        public global::Mistral.ImageURLChunk? ImageURLChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageURLChunk))]
#endif
        public bool IsImageURLChunk => ImageURLChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputContentChunks(global::Mistral.ImageURLChunk value) => new OutputContentChunks((global::Mistral.ImageURLChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ImageURLChunk?(OutputContentChunks @this) => @this.ImageURLChunk;

        /// <summary>
        /// 
        /// </summary>
        public OutputContentChunks(global::Mistral.ImageURLChunk? value)
        {
            ImageURLChunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ToolFileChunk? ToolFileChunk { get; init; }
#else
        public global::Mistral.ToolFileChunk? ToolFileChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolFileChunk))]
#endif
        public bool IsToolFileChunk => ToolFileChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputContentChunks(global::Mistral.ToolFileChunk value) => new OutputContentChunks((global::Mistral.ToolFileChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ToolFileChunk?(OutputContentChunks @this) => @this.ToolFileChunk;

        /// <summary>
        /// 
        /// </summary>
        public OutputContentChunks(global::Mistral.ToolFileChunk? value)
        {
            ToolFileChunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.DocumentURLChunk? DocumentURLChunk { get; init; }
#else
        public global::Mistral.DocumentURLChunk? DocumentURLChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentURLChunk))]
#endif
        public bool IsDocumentURLChunk => DocumentURLChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputContentChunks(global::Mistral.DocumentURLChunk value) => new OutputContentChunks((global::Mistral.DocumentURLChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.DocumentURLChunk?(OutputContentChunks @this) => @this.DocumentURLChunk;

        /// <summary>
        /// 
        /// </summary>
        public OutputContentChunks(global::Mistral.DocumentURLChunk? value)
        {
            DocumentURLChunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ToolReferenceChunk? ToolReferenceChunk { get; init; }
#else
        public global::Mistral.ToolReferenceChunk? ToolReferenceChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolReferenceChunk))]
#endif
        public bool IsToolReferenceChunk => ToolReferenceChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputContentChunks(global::Mistral.ToolReferenceChunk value) => new OutputContentChunks((global::Mistral.ToolReferenceChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ToolReferenceChunk?(OutputContentChunks @this) => @this.ToolReferenceChunk;

        /// <summary>
        /// 
        /// </summary>
        public OutputContentChunks(global::Mistral.ToolReferenceChunk? value)
        {
            ToolReferenceChunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputContentChunks(
            global::Mistral.TextChunk? textChunk,
            global::Mistral.ImageURLChunk? imageURLChunk,
            global::Mistral.ToolFileChunk? toolFileChunk,
            global::Mistral.DocumentURLChunk? documentURLChunk,
            global::Mistral.ToolReferenceChunk? toolReferenceChunk
            )
        {
            TextChunk = textChunk;
            ImageURLChunk = imageURLChunk;
            ToolFileChunk = toolFileChunk;
            DocumentURLChunk = documentURLChunk;
            ToolReferenceChunk = toolReferenceChunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolReferenceChunk as object ??
            DocumentURLChunk as object ??
            ToolFileChunk as object ??
            ImageURLChunk as object ??
            TextChunk as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextChunk?.ToString() ??
            ImageURLChunk?.ToString() ??
            ToolFileChunk?.ToString() ??
            DocumentURLChunk?.ToString() ??
            ToolReferenceChunk?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextChunk || IsImageURLChunk || IsToolFileChunk || IsDocumentURLChunk || IsToolReferenceChunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.TextChunk?, TResult>? textChunk = null,
            global::System.Func<global::Mistral.ImageURLChunk?, TResult>? imageURLChunk = null,
            global::System.Func<global::Mistral.ToolFileChunk?, TResult>? toolFileChunk = null,
            global::System.Func<global::Mistral.DocumentURLChunk?, TResult>? documentURLChunk = null,
            global::System.Func<global::Mistral.ToolReferenceChunk?, TResult>? toolReferenceChunk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextChunk && textChunk != null)
            {
                return textChunk(TextChunk!);
            }
            else if (IsImageURLChunk && imageURLChunk != null)
            {
                return imageURLChunk(ImageURLChunk!);
            }
            else if (IsToolFileChunk && toolFileChunk != null)
            {
                return toolFileChunk(ToolFileChunk!);
            }
            else if (IsDocumentURLChunk && documentURLChunk != null)
            {
                return documentURLChunk(DocumentURLChunk!);
            }
            else if (IsToolReferenceChunk && toolReferenceChunk != null)
            {
                return toolReferenceChunk(ToolReferenceChunk!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.TextChunk?>? textChunk = null,
            global::System.Action<global::Mistral.ImageURLChunk?>? imageURLChunk = null,
            global::System.Action<global::Mistral.ToolFileChunk?>? toolFileChunk = null,
            global::System.Action<global::Mistral.DocumentURLChunk?>? documentURLChunk = null,
            global::System.Action<global::Mistral.ToolReferenceChunk?>? toolReferenceChunk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextChunk)
            {
                textChunk?.Invoke(TextChunk!);
            }
            else if (IsImageURLChunk)
            {
                imageURLChunk?.Invoke(ImageURLChunk!);
            }
            else if (IsToolFileChunk)
            {
                toolFileChunk?.Invoke(ToolFileChunk!);
            }
            else if (IsDocumentURLChunk)
            {
                documentURLChunk?.Invoke(DocumentURLChunk!);
            }
            else if (IsToolReferenceChunk)
            {
                toolReferenceChunk?.Invoke(ToolReferenceChunk!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextChunk,
                typeof(global::Mistral.TextChunk),
                ImageURLChunk,
                typeof(global::Mistral.ImageURLChunk),
                ToolFileChunk,
                typeof(global::Mistral.ToolFileChunk),
                DocumentURLChunk,
                typeof(global::Mistral.DocumentURLChunk),
                ToolReferenceChunk,
                typeof(global::Mistral.ToolReferenceChunk),
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
        public bool Equals(OutputContentChunks other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.TextChunk?>.Default.Equals(TextChunk, other.TextChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ImageURLChunk?>.Default.Equals(ImageURLChunk, other.ImageURLChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ToolFileChunk?>.Default.Equals(ToolFileChunk, other.ToolFileChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.DocumentURLChunk?>.Default.Equals(DocumentURLChunk, other.DocumentURLChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ToolReferenceChunk?>.Default.Equals(ToolReferenceChunk, other.ToolReferenceChunk) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputContentChunks obj1, OutputContentChunks obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputContentChunks>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputContentChunks obj1, OutputContentChunks obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputContentChunks o && Equals(o);
        }
    }
}
