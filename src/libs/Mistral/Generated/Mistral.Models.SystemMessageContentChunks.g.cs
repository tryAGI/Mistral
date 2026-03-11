#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SystemMessageContentChunks : global::System.IEquatable<SystemMessageContentChunks>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.SystemMessageContentChunksDiscriminatorType? Type { get; }

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
        public static implicit operator SystemMessageContentChunks(global::Mistral.TextChunk value) => new SystemMessageContentChunks((global::Mistral.TextChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.TextChunk?(SystemMessageContentChunks @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public SystemMessageContentChunks(global::Mistral.TextChunk? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SystemMessageContentChunks(global::Mistral.ThinkChunk value) => new SystemMessageContentChunks((global::Mistral.ThinkChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ThinkChunk?(SystemMessageContentChunks @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public SystemMessageContentChunks(global::Mistral.ThinkChunk? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SystemMessageContentChunks(
            global::Mistral.SystemMessageContentChunksDiscriminatorType? type,
            global::Mistral.TextChunk? text,
            global::Mistral.ThinkChunk? thinking
            )
        {
            Type = type;

            Text = text;
            Thinking = thinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Thinking as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Thinking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsThinking || !IsText && IsThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.TextChunk?, TResult>? text = null,
            global::System.Func<global::Mistral.ThinkChunk?, TResult>? thinking = null,
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
            else if (IsThinking && thinking != null)
            {
                return thinking(Thinking!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.TextChunk?>? text = null,
            global::System.Action<global::Mistral.ThinkChunk?>? thinking = null,
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
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
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
                Thinking,
                typeof(global::Mistral.ThinkChunk),
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
        public bool Equals(SystemMessageContentChunks other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.TextChunk?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ThinkChunk?>.Default.Equals(Thinking, other.Thinking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SystemMessageContentChunks obj1, SystemMessageContentChunks obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SystemMessageContentChunks>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SystemMessageContentChunks obj1, SystemMessageContentChunks obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SystemMessageContentChunks o && Equals(o);
        }
    }
}
