#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentChunk : global::System.IEquatable<ContentChunk>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ContentChunkDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.TextChunk? Text { get; init; }
#else
        public global::Mistral.TextChunk? Text { get; }
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
        public static implicit operator ContentChunk(global::Mistral.TextChunk value) => new ContentChunk((global::Mistral.TextChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.TextChunk?(ContentChunk @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(global::Mistral.TextChunk? value)
        {
            Text = value;
        }

        /// <summary>
        /// {"type":"image_url","image_url":{"url":"data:image/png;base64,iVBORw0
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ImageURLChunk? ImageUrl { get; init; }
#else
        public global::Mistral.ImageURLChunk? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentChunk(global::Mistral.ImageURLChunk value) => new ContentChunk((global::Mistral.ImageURLChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ImageURLChunk?(ContentChunk @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(global::Mistral.ImageURLChunk? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.DocumentURLChunk? DocumentUrl { get; init; }
#else
        public global::Mistral.DocumentURLChunk? DocumentUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentUrl))]
#endif
        public bool IsDocumentUrl => DocumentUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentChunk(global::Mistral.DocumentURLChunk value) => new ContentChunk((global::Mistral.DocumentURLChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.DocumentURLChunk?(ContentChunk @this) => @this.DocumentUrl;

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(global::Mistral.DocumentURLChunk? value)
        {
            DocumentUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ReferenceChunk? Reference { get; init; }
#else
        public global::Mistral.ReferenceChunk? Reference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reference))]
#endif
        public bool IsReference => Reference != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentChunk(global::Mistral.ReferenceChunk value) => new ContentChunk((global::Mistral.ReferenceChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ReferenceChunk?(ContentChunk @this) => @this.Reference;

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(global::Mistral.ReferenceChunk? value)
        {
            Reference = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.FileChunk? File { get; init; }
#else
        public global::Mistral.FileChunk? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentChunk(global::Mistral.FileChunk value) => new ContentChunk((global::Mistral.FileChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.FileChunk?(ContentChunk @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(global::Mistral.FileChunk? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ThinkChunk? Thinking { get; init; }
#else
        public global::Mistral.ThinkChunk? Thinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thinking))]
#endif
        public bool IsThinking => Thinking != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentChunk(global::Mistral.ThinkChunk value) => new ContentChunk((global::Mistral.ThinkChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ThinkChunk?(ContentChunk @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(global::Mistral.ThinkChunk? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.AudioChunk? InputAudio { get; init; }
#else
        public global::Mistral.AudioChunk? InputAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudio))]
#endif
        public bool IsInputAudio => InputAudio != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentChunk(global::Mistral.AudioChunk value) => new ContentChunk((global::Mistral.AudioChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.AudioChunk?(ContentChunk @this) => @this.InputAudio;

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(global::Mistral.AudioChunk? value)
        {
            InputAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(
            global::Mistral.ContentChunkDiscriminatorType? type,
            global::Mistral.TextChunk? text,
            global::Mistral.ImageURLChunk? imageUrl,
            global::Mistral.DocumentURLChunk? documentUrl,
            global::Mistral.ReferenceChunk? reference,
            global::Mistral.FileChunk? file,
            global::Mistral.ThinkChunk? thinking,
            global::Mistral.AudioChunk? inputAudio
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
            DocumentUrl = documentUrl;
            Reference = reference;
            File = file;
            Thinking = thinking;
            InputAudio = inputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputAudio as object ??
            Thinking as object ??
            File as object ??
            Reference as object ??
            DocumentUrl as object ??
            ImageUrl as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString() ??
            DocumentUrl?.ToString() ??
            Reference?.ToString() ??
            File?.ToString() ??
            Thinking?.ToString() ??
            InputAudio?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl && !IsDocumentUrl && !IsReference && !IsFile && !IsThinking && !IsInputAudio || !IsText && IsImageUrl && !IsDocumentUrl && !IsReference && !IsFile && !IsThinking && !IsInputAudio || !IsText && !IsImageUrl && IsDocumentUrl && !IsReference && !IsFile && !IsThinking && !IsInputAudio || !IsText && !IsImageUrl && !IsDocumentUrl && IsReference && !IsFile && !IsThinking && !IsInputAudio || !IsText && !IsImageUrl && !IsDocumentUrl && !IsReference && IsFile && !IsThinking && !IsInputAudio || !IsText && !IsImageUrl && !IsDocumentUrl && !IsReference && !IsFile && IsThinking && !IsInputAudio || !IsText && !IsImageUrl && !IsDocumentUrl && !IsReference && !IsFile && !IsThinking && IsInputAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.TextChunk?, TResult>? text = null,
            global::System.Func<global::Mistral.ImageURLChunk?, TResult>? imageUrl = null,
            global::System.Func<global::Mistral.DocumentURLChunk?, TResult>? documentUrl = null,
            global::System.Func<global::Mistral.ReferenceChunk?, TResult>? reference = null,
            global::System.Func<global::Mistral.FileChunk?, TResult>? file = null,
            global::System.Func<global::Mistral.ThinkChunk?, TResult>? thinking = null,
            global::System.Func<global::Mistral.AudioChunk?, TResult>? inputAudio = null,
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
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsDocumentUrl && documentUrl != null)
            {
                return documentUrl(DocumentUrl!);
            }
            else if (IsReference && reference != null)
            {
                return reference(Reference!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }
            else if (IsThinking && thinking != null)
            {
                return thinking(Thinking!);
            }
            else if (IsInputAudio && inputAudio != null)
            {
                return inputAudio(InputAudio!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.TextChunk?>? text = null,
            global::System.Action<global::Mistral.ImageURLChunk?>? imageUrl = null,
            global::System.Action<global::Mistral.DocumentURLChunk?>? documentUrl = null,
            global::System.Action<global::Mistral.ReferenceChunk?>? reference = null,
            global::System.Action<global::Mistral.FileChunk?>? file = null,
            global::System.Action<global::Mistral.ThinkChunk?>? thinking = null,
            global::System.Action<global::Mistral.AudioChunk?>? inputAudio = null,
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
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsDocumentUrl)
            {
                documentUrl?.Invoke(DocumentUrl!);
            }
            else if (IsReference)
            {
                reference?.Invoke(Reference!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsInputAudio)
            {
                inputAudio?.Invoke(InputAudio!);
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
                typeof(global::Mistral.TextChunk),
                ImageUrl,
                typeof(global::Mistral.ImageURLChunk),
                DocumentUrl,
                typeof(global::Mistral.DocumentURLChunk),
                Reference,
                typeof(global::Mistral.ReferenceChunk),
                File,
                typeof(global::Mistral.FileChunk),
                Thinking,
                typeof(global::Mistral.ThinkChunk),
                InputAudio,
                typeof(global::Mistral.AudioChunk),
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
        public bool Equals(ContentChunk other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.TextChunk?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ImageURLChunk?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.DocumentURLChunk?>.Default.Equals(DocumentUrl, other.DocumentUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ReferenceChunk?>.Default.Equals(Reference, other.Reference) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.FileChunk?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ThinkChunk?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.AudioChunk?>.Default.Equals(InputAudio, other.InputAudio) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentChunk obj1, ContentChunk obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentChunk>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentChunk obj1, ContentChunk obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentChunk o && Equals(o);
        }
    }
}
