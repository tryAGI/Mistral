#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConversationAppendRequest : global::System.IEquatable<ConversationAppendRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ConversationAppendRequestBase? Base { get; init; }
#else
        public global::Mistral.ConversationAppendRequestBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ConversationAppendRequestVariant2? ConversationAppendRequestVariant2 { get; init; }
#else
        public global::Mistral.ConversationAppendRequestVariant2? ConversationAppendRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationAppendRequestVariant2))]
#endif
        public bool IsConversationAppendRequestVariant2 => ConversationAppendRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationAppendRequest(global::Mistral.ConversationAppendRequestBase value) => new ConversationAppendRequest((global::Mistral.ConversationAppendRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ConversationAppendRequestBase?(ConversationAppendRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ConversationAppendRequest(global::Mistral.ConversationAppendRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationAppendRequest(global::Mistral.ConversationAppendRequestVariant2 value) => new ConversationAppendRequest((global::Mistral.ConversationAppendRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ConversationAppendRequestVariant2?(ConversationAppendRequest @this) => @this.ConversationAppendRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ConversationAppendRequest(global::Mistral.ConversationAppendRequestVariant2? value)
        {
            ConversationAppendRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationAppendRequest(
            global::Mistral.ConversationAppendRequestBase? @base,
            global::Mistral.ConversationAppendRequestVariant2? conversationAppendRequestVariant2
            )
        {
            Base = @base;
            ConversationAppendRequestVariant2 = conversationAppendRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationAppendRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ConversationAppendRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsConversationAppendRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.ConversationAppendRequestBase?, TResult>? @base = null,
            global::System.Func<global::Mistral.ConversationAppendRequestVariant2?, TResult>? conversationAppendRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsConversationAppendRequestVariant2 && conversationAppendRequestVariant2 != null)
            {
                return conversationAppendRequestVariant2(ConversationAppendRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.ConversationAppendRequestBase?>? @base = null,
            global::System.Action<global::Mistral.ConversationAppendRequestVariant2?>? conversationAppendRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsConversationAppendRequestVariant2)
            {
                conversationAppendRequestVariant2?.Invoke(ConversationAppendRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Mistral.ConversationAppendRequestBase),
                ConversationAppendRequestVariant2,
                typeof(global::Mistral.ConversationAppendRequestVariant2),
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
        public bool Equals(ConversationAppendRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ConversationAppendRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ConversationAppendRequestVariant2?>.Default.Equals(ConversationAppendRequestVariant2, other.ConversationAppendRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationAppendRequest obj1, ConversationAppendRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationAppendRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationAppendRequest obj1, ConversationAppendRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationAppendRequest o && Equals(o);
        }
    }
}
