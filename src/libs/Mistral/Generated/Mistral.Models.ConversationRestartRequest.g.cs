#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConversationRestartRequest : global::System.IEquatable<ConversationRestartRequest>
    {
        /// <summary>
        /// Request to restart a new conversation from a given entry in the conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ConversationRestartRequestBase? Base { get; init; }
#else
        public global::Mistral.ConversationRestartRequestBase? Base { get; }
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
        public global::Mistral.ConversationRestartRequestVariant2? ConversationRestartRequestVariant2 { get; init; }
#else
        public global::Mistral.ConversationRestartRequestVariant2? ConversationRestartRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationRestartRequestVariant2))]
#endif
        public bool IsConversationRestartRequestVariant2 => ConversationRestartRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationRestartRequest(global::Mistral.ConversationRestartRequestBase value) => new ConversationRestartRequest((global::Mistral.ConversationRestartRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ConversationRestartRequestBase?(ConversationRestartRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ConversationRestartRequest(global::Mistral.ConversationRestartRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationRestartRequest(global::Mistral.ConversationRestartRequestVariant2 value) => new ConversationRestartRequest((global::Mistral.ConversationRestartRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ConversationRestartRequestVariant2?(ConversationRestartRequest @this) => @this.ConversationRestartRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ConversationRestartRequest(global::Mistral.ConversationRestartRequestVariant2? value)
        {
            ConversationRestartRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationRestartRequest(
            global::Mistral.ConversationRestartRequestBase? @base,
            global::Mistral.ConversationRestartRequestVariant2? conversationRestartRequestVariant2
            )
        {
            Base = @base;
            ConversationRestartRequestVariant2 = conversationRestartRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationRestartRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ConversationRestartRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsConversationRestartRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.ConversationRestartRequestBase?, TResult>? @base = null,
            global::System.Func<global::Mistral.ConversationRestartRequestVariant2?, TResult>? conversationRestartRequestVariant2 = null,
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
            else if (IsConversationRestartRequestVariant2 && conversationRestartRequestVariant2 != null)
            {
                return conversationRestartRequestVariant2(ConversationRestartRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.ConversationRestartRequestBase?>? @base = null,
            global::System.Action<global::Mistral.ConversationRestartRequestVariant2?>? conversationRestartRequestVariant2 = null,
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
            else if (IsConversationRestartRequestVariant2)
            {
                conversationRestartRequestVariant2?.Invoke(ConversationRestartRequestVariant2!);
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
                typeof(global::Mistral.ConversationRestartRequestBase),
                ConversationRestartRequestVariant2,
                typeof(global::Mistral.ConversationRestartRequestVariant2),
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
        public bool Equals(ConversationRestartRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ConversationRestartRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ConversationRestartRequestVariant2?>.Default.Equals(ConversationRestartRequestVariant2, other.ConversationRestartRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationRestartRequest obj1, ConversationRestartRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationRestartRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationRestartRequest obj1, ConversationRestartRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationRestartRequest o && Equals(o);
        }
    }
}
