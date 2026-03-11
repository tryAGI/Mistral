#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionResponseBase : global::System.IEquatable<ChatCompletionResponseBase>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ResponseBase? ResponseBase { get; init; }
#else
        public global::Mistral.ResponseBase? ResponseBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseBase))]
#endif
        public bool IsResponseBase => ResponseBase != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1? Value2 { get; init; }
#else
        public global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1? Value2 { get; }
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
        public static implicit operator ChatCompletionResponseBase(global::Mistral.ResponseBase value) => new ChatCompletionResponseBase((global::Mistral.ResponseBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ResponseBase?(ChatCompletionResponseBase @this) => @this.ResponseBase;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionResponseBase(global::Mistral.ResponseBase? value)
        {
            ResponseBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionResponseBase(global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1 value) => new ChatCompletionResponseBase((global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1?(ChatCompletionResponseBase @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionResponseBase(global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionResponseBase(
            global::Mistral.ResponseBase? responseBase,
            global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1? value2
            )
        {
            ResponseBase = responseBase;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            ResponseBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponseBase?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponseBase && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.ResponseBase?, TResult>? responseBase = null,
            global::System.Func<global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseBase && responseBase != null)
            {
                return responseBase(ResponseBase!);
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
            global::System.Action<global::Mistral.ResponseBase?>? responseBase = null,
            global::System.Action<global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponseBase)
            {
                responseBase?.Invoke(ResponseBase!);
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
                ResponseBase,
                typeof(global::Mistral.ResponseBase),
                Value2,
                typeof(global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1),
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
        public bool Equals(ChatCompletionResponseBase other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ResponseBase?>.Default.Equals(ResponseBase, other.ResponseBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ChatCompletionResponseBaseChatCompletionResponseBase1?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionResponseBase obj1, ChatCompletionResponseBase obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionResponseBase>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionResponseBase obj1, ChatCompletionResponseBase obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionResponseBase o && Equals(o);
        }
    }
}
