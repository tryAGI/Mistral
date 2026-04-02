#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FIMCompletionResponse : global::System.IEquatable<FIMCompletionResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ChatCompletionResponse? Chat { get; init; }
#else
        public global::Mistral.ChatCompletionResponse? Chat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chat))]
#endif
        public bool IsChat => Chat != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.FIMCompletionResponseVariant2? FIMCompletionResponseVariant2 { get; init; }
#else
        public global::Mistral.FIMCompletionResponseVariant2? FIMCompletionResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FIMCompletionResponseVariant2))]
#endif
        public bool IsFIMCompletionResponseVariant2 => FIMCompletionResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FIMCompletionResponse(global::Mistral.ChatCompletionResponse value) => new FIMCompletionResponse((global::Mistral.ChatCompletionResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ChatCompletionResponse?(FIMCompletionResponse @this) => @this.Chat;

        /// <summary>
        /// 
        /// </summary>
        public FIMCompletionResponse(global::Mistral.ChatCompletionResponse? value)
        {
            Chat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FIMCompletionResponse(global::Mistral.FIMCompletionResponseVariant2 value) => new FIMCompletionResponse((global::Mistral.FIMCompletionResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.FIMCompletionResponseVariant2?(FIMCompletionResponse @this) => @this.FIMCompletionResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FIMCompletionResponse(global::Mistral.FIMCompletionResponseVariant2? value)
        {
            FIMCompletionResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FIMCompletionResponse(
            global::Mistral.ChatCompletionResponse? chat,
            global::Mistral.FIMCompletionResponseVariant2? fIMCompletionResponseVariant2
            )
        {
            Chat = chat;
            FIMCompletionResponseVariant2 = fIMCompletionResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FIMCompletionResponseVariant2 as object ??
            Chat as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Chat?.ToString() ??
            FIMCompletionResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChat && IsFIMCompletionResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.ChatCompletionResponse?, TResult>? chat = null,
            global::System.Func<global::Mistral.FIMCompletionResponseVariant2?, TResult>? fIMCompletionResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChat && chat != null)
            {
                return chat(Chat!);
            }
            else if (IsFIMCompletionResponseVariant2 && fIMCompletionResponseVariant2 != null)
            {
                return fIMCompletionResponseVariant2(FIMCompletionResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.ChatCompletionResponse?>? chat = null,
            global::System.Action<global::Mistral.FIMCompletionResponseVariant2?>? fIMCompletionResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
            else if (IsFIMCompletionResponseVariant2)
            {
                fIMCompletionResponseVariant2?.Invoke(FIMCompletionResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Chat,
                typeof(global::Mistral.ChatCompletionResponse),
                FIMCompletionResponseVariant2,
                typeof(global::Mistral.FIMCompletionResponseVariant2),
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
        public bool Equals(FIMCompletionResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ChatCompletionResponse?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.FIMCompletionResponseVariant2?>.Default.Equals(FIMCompletionResponseVariant2, other.FIMCompletionResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FIMCompletionResponse obj1, FIMCompletionResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FIMCompletionResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FIMCompletionResponse obj1, FIMCompletionResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FIMCompletionResponse o && Equals(o);
        }
    }
}
