#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RealtimeTranscriptionClientMessage : global::System.IEquatable<RealtimeTranscriptionClientMessage>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.RealtimeTranscriptionSessionUpdateMessage? SessionUpdate { get; init; }
#else
        public global::Mistral.RealtimeTranscriptionSessionUpdateMessage? SessionUpdate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdate))]
#endif
        public bool IsSessionUpdate => SessionUpdate != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.RealtimeTranscriptionInputAudioAppend? InputAudioAppend { get; init; }
#else
        public global::Mistral.RealtimeTranscriptionInputAudioAppend? InputAudioAppend { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioAppend))]
#endif
        public bool IsInputAudioAppend => InputAudioAppend != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.RealtimeTranscriptionInputAudioFlush? InputAudioFlush { get; init; }
#else
        public global::Mistral.RealtimeTranscriptionInputAudioFlush? InputAudioFlush { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioFlush))]
#endif
        public bool IsInputAudioFlush => InputAudioFlush != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.RealtimeTranscriptionInputAudioEnd? InputAudioEnd { get; init; }
#else
        public global::Mistral.RealtimeTranscriptionInputAudioEnd? InputAudioEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputAudioEnd))]
#endif
        public bool IsInputAudioEnd => InputAudioEnd != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranscriptionClientMessage(global::Mistral.RealtimeTranscriptionSessionUpdateMessage value) => new RealtimeTranscriptionClientMessage((global::Mistral.RealtimeTranscriptionSessionUpdateMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.RealtimeTranscriptionSessionUpdateMessage?(RealtimeTranscriptionClientMessage @this) => @this.SessionUpdate;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranscriptionClientMessage(global::Mistral.RealtimeTranscriptionSessionUpdateMessage? value)
        {
            SessionUpdate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranscriptionClientMessage(global::Mistral.RealtimeTranscriptionInputAudioAppend value) => new RealtimeTranscriptionClientMessage((global::Mistral.RealtimeTranscriptionInputAudioAppend?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.RealtimeTranscriptionInputAudioAppend?(RealtimeTranscriptionClientMessage @this) => @this.InputAudioAppend;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranscriptionClientMessage(global::Mistral.RealtimeTranscriptionInputAudioAppend? value)
        {
            InputAudioAppend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranscriptionClientMessage(global::Mistral.RealtimeTranscriptionInputAudioFlush value) => new RealtimeTranscriptionClientMessage((global::Mistral.RealtimeTranscriptionInputAudioFlush?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.RealtimeTranscriptionInputAudioFlush?(RealtimeTranscriptionClientMessage @this) => @this.InputAudioFlush;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranscriptionClientMessage(global::Mistral.RealtimeTranscriptionInputAudioFlush? value)
        {
            InputAudioFlush = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranscriptionClientMessage(global::Mistral.RealtimeTranscriptionInputAudioEnd value) => new RealtimeTranscriptionClientMessage((global::Mistral.RealtimeTranscriptionInputAudioEnd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.RealtimeTranscriptionInputAudioEnd?(RealtimeTranscriptionClientMessage @this) => @this.InputAudioEnd;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranscriptionClientMessage(global::Mistral.RealtimeTranscriptionInputAudioEnd? value)
        {
            InputAudioEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranscriptionClientMessage(
            global::Mistral.RealtimeTranscriptionClientMessageDiscriminatorType? type,
            global::Mistral.RealtimeTranscriptionSessionUpdateMessage? sessionUpdate,
            global::Mistral.RealtimeTranscriptionInputAudioAppend? inputAudioAppend,
            global::Mistral.RealtimeTranscriptionInputAudioFlush? inputAudioFlush,
            global::Mistral.RealtimeTranscriptionInputAudioEnd? inputAudioEnd
            )
        {
            Type = type;

            SessionUpdate = sessionUpdate;
            InputAudioAppend = inputAudioAppend;
            InputAudioFlush = inputAudioFlush;
            InputAudioEnd = inputAudioEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputAudioEnd as object ??
            InputAudioFlush as object ??
            InputAudioAppend as object ??
            SessionUpdate as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SessionUpdate?.ToString() ??
            InputAudioAppend?.ToString() ??
            InputAudioFlush?.ToString() ??
            InputAudioEnd?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSessionUpdate && !IsInputAudioAppend && !IsInputAudioFlush && !IsInputAudioEnd || !IsSessionUpdate && IsInputAudioAppend && !IsInputAudioFlush && !IsInputAudioEnd || !IsSessionUpdate && !IsInputAudioAppend && IsInputAudioFlush && !IsInputAudioEnd || !IsSessionUpdate && !IsInputAudioAppend && !IsInputAudioFlush && IsInputAudioEnd;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.RealtimeTranscriptionSessionUpdateMessage?, TResult>? sessionUpdate = null,
            global::System.Func<global::Mistral.RealtimeTranscriptionInputAudioAppend?, TResult>? inputAudioAppend = null,
            global::System.Func<global::Mistral.RealtimeTranscriptionInputAudioFlush?, TResult>? inputAudioFlush = null,
            global::System.Func<global::Mistral.RealtimeTranscriptionInputAudioEnd?, TResult>? inputAudioEnd = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionUpdate && sessionUpdate != null)
            {
                return sessionUpdate(SessionUpdate!);
            }
            else if (IsInputAudioAppend && inputAudioAppend != null)
            {
                return inputAudioAppend(InputAudioAppend!);
            }
            else if (IsInputAudioFlush && inputAudioFlush != null)
            {
                return inputAudioFlush(InputAudioFlush!);
            }
            else if (IsInputAudioEnd && inputAudioEnd != null)
            {
                return inputAudioEnd(InputAudioEnd!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.RealtimeTranscriptionSessionUpdateMessage?>? sessionUpdate = null,
            global::System.Action<global::Mistral.RealtimeTranscriptionInputAudioAppend?>? inputAudioAppend = null,
            global::System.Action<global::Mistral.RealtimeTranscriptionInputAudioFlush?>? inputAudioFlush = null,
            global::System.Action<global::Mistral.RealtimeTranscriptionInputAudioEnd?>? inputAudioEnd = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionUpdate)
            {
                sessionUpdate?.Invoke(SessionUpdate!);
            }
            else if (IsInputAudioAppend)
            {
                inputAudioAppend?.Invoke(InputAudioAppend!);
            }
            else if (IsInputAudioFlush)
            {
                inputAudioFlush?.Invoke(InputAudioFlush!);
            }
            else if (IsInputAudioEnd)
            {
                inputAudioEnd?.Invoke(InputAudioEnd!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionUpdate,
                typeof(global::Mistral.RealtimeTranscriptionSessionUpdateMessage),
                InputAudioAppend,
                typeof(global::Mistral.RealtimeTranscriptionInputAudioAppend),
                InputAudioFlush,
                typeof(global::Mistral.RealtimeTranscriptionInputAudioFlush),
                InputAudioEnd,
                typeof(global::Mistral.RealtimeTranscriptionInputAudioEnd),
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
        public bool Equals(RealtimeTranscriptionClientMessage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.RealtimeTranscriptionSessionUpdateMessage?>.Default.Equals(SessionUpdate, other.SessionUpdate) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.RealtimeTranscriptionInputAudioAppend?>.Default.Equals(InputAudioAppend, other.InputAudioAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.RealtimeTranscriptionInputAudioFlush?>.Default.Equals(InputAudioFlush, other.InputAudioFlush) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.RealtimeTranscriptionInputAudioEnd?>.Default.Equals(InputAudioEnd, other.InputAudioEnd) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RealtimeTranscriptionClientMessage obj1, RealtimeTranscriptionClientMessage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeTranscriptionClientMessage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RealtimeTranscriptionClientMessage obj1, RealtimeTranscriptionClientMessage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeTranscriptionClientMessage o && Equals(o);
        }
    }
}
