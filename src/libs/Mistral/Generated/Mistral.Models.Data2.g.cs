#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Data2 : global::System.IEquatable<Data2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.SpeechStreamEventsDataDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.SpeechStreamAudioDelta? SpeechAudioDelta { get; init; }
#else
        public global::Mistral.SpeechStreamAudioDelta? SpeechAudioDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechAudioDelta))]
#endif
        public bool IsSpeechAudioDelta => SpeechAudioDelta != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.SpeechStreamDone? SpeechAudioDone { get; init; }
#else
        public global::Mistral.SpeechStreamDone? SpeechAudioDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechAudioDone))]
#endif
        public bool IsSpeechAudioDone => SpeechAudioDone != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data2(global::Mistral.SpeechStreamAudioDelta value) => new Data2((global::Mistral.SpeechStreamAudioDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.SpeechStreamAudioDelta?(Data2 @this) => @this.SpeechAudioDelta;

        /// <summary>
        /// 
        /// </summary>
        public Data2(global::Mistral.SpeechStreamAudioDelta? value)
        {
            SpeechAudioDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data2(global::Mistral.SpeechStreamDone value) => new Data2((global::Mistral.SpeechStreamDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.SpeechStreamDone?(Data2 @this) => @this.SpeechAudioDone;

        /// <summary>
        /// 
        /// </summary>
        public Data2(global::Mistral.SpeechStreamDone? value)
        {
            SpeechAudioDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Data2(
            global::Mistral.SpeechStreamEventsDataDiscriminatorType? type,
            global::Mistral.SpeechStreamAudioDelta? speechAudioDelta,
            global::Mistral.SpeechStreamDone? speechAudioDone
            )
        {
            Type = type;

            SpeechAudioDelta = speechAudioDelta;
            SpeechAudioDone = speechAudioDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SpeechAudioDone as object ??
            SpeechAudioDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SpeechAudioDelta?.ToString() ??
            SpeechAudioDone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSpeechAudioDelta && !IsSpeechAudioDone || !IsSpeechAudioDelta && IsSpeechAudioDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.SpeechStreamAudioDelta?, TResult>? speechAudioDelta = null,
            global::System.Func<global::Mistral.SpeechStreamDone?, TResult>? speechAudioDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeechAudioDelta && speechAudioDelta != null)
            {
                return speechAudioDelta(SpeechAudioDelta!);
            }
            else if (IsSpeechAudioDone && speechAudioDone != null)
            {
                return speechAudioDone(SpeechAudioDone!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.SpeechStreamAudioDelta?>? speechAudioDelta = null,
            global::System.Action<global::Mistral.SpeechStreamDone?>? speechAudioDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpeechAudioDelta)
            {
                speechAudioDelta?.Invoke(SpeechAudioDelta!);
            }
            else if (IsSpeechAudioDone)
            {
                speechAudioDone?.Invoke(SpeechAudioDone!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SpeechAudioDelta,
                typeof(global::Mistral.SpeechStreamAudioDelta),
                SpeechAudioDone,
                typeof(global::Mistral.SpeechStreamDone),
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
        public bool Equals(Data2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.SpeechStreamAudioDelta?>.Default.Equals(SpeechAudioDelta, other.SpeechAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.SpeechStreamDone?>.Default.Equals(SpeechAudioDone, other.SpeechAudioDone) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Data2 obj1, Data2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Data2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Data2 obj1, Data2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Data2 o && Equals(o);
        }
    }
}
