#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConversationAppendStreamRequest : global::System.IEquatable<ConversationAppendStreamRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ConversationAppendRequestBase? ConversationAppendRequest { get; init; }
#else
        public global::Mistral.ConversationAppendRequestBase? ConversationAppendRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationAppendRequest))]
#endif
        public bool IsConversationAppendRequest => ConversationAppendRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ConversationAppendStreamRequestVariant2? Value2 { get; init; }
#else
        public global::Mistral.ConversationAppendStreamRequestVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationAppendStreamRequest(global::Mistral.ConversationAppendRequestBase value) => new ConversationAppendStreamRequest((global::Mistral.ConversationAppendRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ConversationAppendRequestBase?(ConversationAppendStreamRequest @this) => @this.ConversationAppendRequest;

        /// <summary>
        /// 
        /// </summary>
        public ConversationAppendStreamRequest(global::Mistral.ConversationAppendRequestBase? value)
        {
            ConversationAppendRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationAppendStreamRequest(global::Mistral.ConversationAppendStreamRequestVariant2 value) => new ConversationAppendStreamRequest((global::Mistral.ConversationAppendStreamRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ConversationAppendStreamRequestVariant2?(ConversationAppendStreamRequest @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ConversationAppendStreamRequest(global::Mistral.ConversationAppendStreamRequestVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationAppendStreamRequest(
            global::Mistral.ConversationAppendRequestBase? conversationAppendRequest,
            global::Mistral.ConversationAppendStreamRequestVariant2? value2
            )
        {
            ConversationAppendRequest = conversationAppendRequest;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            ConversationAppendRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationAppendRequest?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationAppendRequest && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.ConversationAppendRequestBase?, TResult>? conversationAppendRequest = null,
            global::System.Func<global::Mistral.ConversationAppendStreamRequestVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationAppendRequest && conversationAppendRequest != null)
            {
                return conversationAppendRequest(ConversationAppendRequest!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.ConversationAppendRequestBase?>? conversationAppendRequest = null,
            global::System.Action<global::Mistral.ConversationAppendStreamRequestVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationAppendRequest)
            {
                conversationAppendRequest?.Invoke(ConversationAppendRequest!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationAppendRequest,
                typeof(global::Mistral.ConversationAppendRequestBase),
                Value2,
                typeof(global::Mistral.ConversationAppendStreamRequestVariant2),
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
        public bool Equals(ConversationAppendStreamRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ConversationAppendRequestBase?>.Default.Equals(ConversationAppendRequest, other.ConversationAppendRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ConversationAppendStreamRequestVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationAppendStreamRequest obj1, ConversationAppendStreamRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationAppendStreamRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationAppendStreamRequest obj1, ConversationAppendStreamRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationAppendStreamRequest o && Equals(o);
        }
    }
}
