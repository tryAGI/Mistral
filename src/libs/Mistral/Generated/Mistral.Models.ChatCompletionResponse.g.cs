#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatCompletionResponse : global::System.IEquatable<ChatCompletionResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ChatCompletionResponseBase? Base { get; init; }
#else
        public global::Mistral.ChatCompletionResponseBase? Base { get; }
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
        public global::Mistral.ChatCompletionResponseChatCompletionResponse1? Response1 { get; init; }
#else
        public global::Mistral.ChatCompletionResponseChatCompletionResponse1? Response1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Response1))]
#endif
        public bool IsResponse1 => Response1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionResponse(global::Mistral.ChatCompletionResponseBase value) => new ChatCompletionResponse((global::Mistral.ChatCompletionResponseBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ChatCompletionResponseBase?(ChatCompletionResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionResponse(global::Mistral.ChatCompletionResponseBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionResponse(global::Mistral.ChatCompletionResponseChatCompletionResponse1 value) => new ChatCompletionResponse((global::Mistral.ChatCompletionResponseChatCompletionResponse1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ChatCompletionResponseChatCompletionResponse1?(ChatCompletionResponse @this) => @this.Response1;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionResponse(global::Mistral.ChatCompletionResponseChatCompletionResponse1? value)
        {
            Response1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionResponse(
            global::Mistral.ChatCompletionResponseBase? @base,
            global::Mistral.ChatCompletionResponseChatCompletionResponse1? response1
            )
        {
            Base = @base;
            Response1 = response1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Response1 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            Response1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsResponse1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.ChatCompletionResponseBase?, TResult>? @base = null,
            global::System.Func<global::Mistral.ChatCompletionResponseChatCompletionResponse1?, TResult>? response1 = null,
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
            else if (IsResponse1 && response1 != null)
            {
                return response1(Response1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.ChatCompletionResponseBase?>? @base = null,
            global::System.Action<global::Mistral.ChatCompletionResponseChatCompletionResponse1?>? response1 = null,
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
            else if (IsResponse1)
            {
                response1?.Invoke(Response1!);
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
                typeof(global::Mistral.ChatCompletionResponseBase),
                Response1,
                typeof(global::Mistral.ChatCompletionResponseChatCompletionResponse1),
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
        public bool Equals(ChatCompletionResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ChatCompletionResponseBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ChatCompletionResponseChatCompletionResponse1?>.Default.Equals(Response1, other.Response1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionResponse obj1, ChatCompletionResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionResponse obj1, ChatCompletionResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionResponse o && Equals(o);
        }
    }
}
