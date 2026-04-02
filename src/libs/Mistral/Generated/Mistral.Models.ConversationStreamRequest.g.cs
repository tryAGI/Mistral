#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConversationStreamRequest : global::System.IEquatable<ConversationStreamRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ConversationRequestBase? ConversationRequest { get; init; }
#else
        public global::Mistral.ConversationRequestBase? ConversationRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationRequest))]
#endif
        public bool IsConversationRequest => ConversationRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ConversationStreamRequestVariant2? ConversationStreamRequestVariant2 { get; init; }
#else
        public global::Mistral.ConversationStreamRequestVariant2? ConversationStreamRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationStreamRequestVariant2))]
#endif
        public bool IsConversationStreamRequestVariant2 => ConversationStreamRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationStreamRequest(global::Mistral.ConversationRequestBase value) => new ConversationStreamRequest((global::Mistral.ConversationRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ConversationRequestBase?(ConversationStreamRequest @this) => @this.ConversationRequest;

        /// <summary>
        /// 
        /// </summary>
        public ConversationStreamRequest(global::Mistral.ConversationRequestBase? value)
        {
            ConversationRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationStreamRequest(global::Mistral.ConversationStreamRequestVariant2 value) => new ConversationStreamRequest((global::Mistral.ConversationStreamRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ConversationStreamRequestVariant2?(ConversationStreamRequest @this) => @this.ConversationStreamRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ConversationStreamRequest(global::Mistral.ConversationStreamRequestVariant2? value)
        {
            ConversationStreamRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationStreamRequest(
            global::Mistral.ConversationRequestBase? conversationRequest,
            global::Mistral.ConversationStreamRequestVariant2? conversationStreamRequestVariant2
            )
        {
            ConversationRequest = conversationRequest;
            ConversationStreamRequestVariant2 = conversationStreamRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConversationStreamRequestVariant2 as object ??
            ConversationRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationRequest?.ToString() ??
            ConversationStreamRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationRequest && IsConversationStreamRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.ConversationRequestBase?, TResult>? conversationRequest = null,
            global::System.Func<global::Mistral.ConversationStreamRequestVariant2?, TResult>? conversationStreamRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationRequest && conversationRequest != null)
            {
                return conversationRequest(ConversationRequest!);
            }
            else if (IsConversationStreamRequestVariant2 && conversationStreamRequestVariant2 != null)
            {
                return conversationStreamRequestVariant2(ConversationStreamRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.ConversationRequestBase?>? conversationRequest = null,
            global::System.Action<global::Mistral.ConversationStreamRequestVariant2?>? conversationStreamRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationRequest)
            {
                conversationRequest?.Invoke(ConversationRequest!);
            }
            else if (IsConversationStreamRequestVariant2)
            {
                conversationStreamRequestVariant2?.Invoke(ConversationStreamRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationRequest,
                typeof(global::Mistral.ConversationRequestBase),
                ConversationStreamRequestVariant2,
                typeof(global::Mistral.ConversationStreamRequestVariant2),
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
        public bool Equals(ConversationStreamRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ConversationRequestBase?>.Default.Equals(ConversationRequest, other.ConversationRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ConversationStreamRequestVariant2?>.Default.Equals(ConversationStreamRequestVariant2, other.ConversationStreamRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationStreamRequest obj1, ConversationStreamRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationStreamRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationStreamRequest obj1, ConversationStreamRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationStreamRequest o && Equals(o);
        }
    }
}
