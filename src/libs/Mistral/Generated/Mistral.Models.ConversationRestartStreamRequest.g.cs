#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConversationRestartStreamRequest : global::System.IEquatable<ConversationRestartStreamRequest>
    {
        /// <summary>
        /// Request to restart a new conversation from a given entry in the conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ConversationRestartRequestBase? ConversationRestartRequest { get; init; }
#else
        public global::Mistral.ConversationRestartRequestBase? ConversationRestartRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationRestartRequest))]
#endif
        public bool IsConversationRestartRequest => ConversationRestartRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ConversationRestartStreamRequestVariant2? Value2 { get; init; }
#else
        public global::Mistral.ConversationRestartStreamRequestVariant2? Value2 { get; }
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
        public static implicit operator ConversationRestartStreamRequest(global::Mistral.ConversationRestartRequestBase value) => new ConversationRestartStreamRequest((global::Mistral.ConversationRestartRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ConversationRestartRequestBase?(ConversationRestartStreamRequest @this) => @this.ConversationRestartRequest;

        /// <summary>
        /// 
        /// </summary>
        public ConversationRestartStreamRequest(global::Mistral.ConversationRestartRequestBase? value)
        {
            ConversationRestartRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationRestartStreamRequest(global::Mistral.ConversationRestartStreamRequestVariant2 value) => new ConversationRestartStreamRequest((global::Mistral.ConversationRestartStreamRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ConversationRestartStreamRequestVariant2?(ConversationRestartStreamRequest @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ConversationRestartStreamRequest(global::Mistral.ConversationRestartStreamRequestVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationRestartStreamRequest(
            global::Mistral.ConversationRestartRequestBase? conversationRestartRequest,
            global::Mistral.ConversationRestartStreamRequestVariant2? value2
            )
        {
            ConversationRestartRequest = conversationRestartRequest;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            ConversationRestartRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationRestartRequest?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationRestartRequest && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.ConversationRestartRequestBase?, TResult>? conversationRestartRequest = null,
            global::System.Func<global::Mistral.ConversationRestartStreamRequestVariant2?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationRestartRequest && conversationRestartRequest != null)
            {
                return conversationRestartRequest(ConversationRestartRequest!);
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
            global::System.Action<global::Mistral.ConversationRestartRequestBase?>? conversationRestartRequest = null,
            global::System.Action<global::Mistral.ConversationRestartStreamRequestVariant2?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationRestartRequest)
            {
                conversationRestartRequest?.Invoke(ConversationRestartRequest!);
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
                ConversationRestartRequest,
                typeof(global::Mistral.ConversationRestartRequestBase),
                Value2,
                typeof(global::Mistral.ConversationRestartStreamRequestVariant2),
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
        public bool Equals(ConversationRestartStreamRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ConversationRestartRequestBase?>.Default.Equals(ConversationRestartRequest, other.ConversationRestartRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ConversationRestartStreamRequestVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationRestartStreamRequest obj1, ConversationRestartStreamRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationRestartStreamRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationRestartStreamRequest obj1, ConversationRestartStreamRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationRestartStreamRequest o && Equals(o);
        }
    }
}
