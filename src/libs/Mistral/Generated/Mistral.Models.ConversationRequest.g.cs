#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConversationRequest : global::System.IEquatable<ConversationRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ConversationRequestBase? Base { get; init; }
#else
        public global::Mistral.ConversationRequestBase? Base { get; }
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
        public global::Mistral.ConversationRequestVariant2? ConversationRequestVariant2 { get; init; }
#else
        public global::Mistral.ConversationRequestVariant2? ConversationRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationRequestVariant2))]
#endif
        public bool IsConversationRequestVariant2 => ConversationRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationRequest(global::Mistral.ConversationRequestBase value) => new ConversationRequest((global::Mistral.ConversationRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ConversationRequestBase?(ConversationRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ConversationRequest(global::Mistral.ConversationRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationRequest(global::Mistral.ConversationRequestVariant2 value) => new ConversationRequest((global::Mistral.ConversationRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ConversationRequestVariant2?(ConversationRequest @this) => @this.ConversationRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ConversationRequest(global::Mistral.ConversationRequestVariant2? value)
        {
            ConversationRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationRequest(
            global::Mistral.ConversationRequestBase? @base,
            global::Mistral.ConversationRequestVariant2? conversationRequestVariant2
            )
        {
            Base = @base;
            ConversationRequestVariant2 = conversationRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ConversationRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsConversationRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.ConversationRequestBase?, TResult>? @base = null,
            global::System.Func<global::Mistral.ConversationRequestVariant2?, TResult>? conversationRequestVariant2 = null,
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
            else if (IsConversationRequestVariant2 && conversationRequestVariant2 != null)
            {
                return conversationRequestVariant2(ConversationRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.ConversationRequestBase?>? @base = null,
            global::System.Action<global::Mistral.ConversationRequestVariant2?>? conversationRequestVariant2 = null,
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
            else if (IsConversationRequestVariant2)
            {
                conversationRequestVariant2?.Invoke(ConversationRequestVariant2!);
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
                typeof(global::Mistral.ConversationRequestBase),
                ConversationRequestVariant2,
                typeof(global::Mistral.ConversationRequestVariant2),
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
        public bool Equals(ConversationRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ConversationRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ConversationRequestVariant2?>.Default.Equals(ConversationRequestVariant2, other.ConversationRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationRequest obj1, ConversationRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationRequest obj1, ConversationRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationRequest o && Equals(o);
        }
    }
}
