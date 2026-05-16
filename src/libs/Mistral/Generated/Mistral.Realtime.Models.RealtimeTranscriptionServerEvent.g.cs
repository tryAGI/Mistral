#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RealtimeTranscriptionServerEvent : global::System.IEquatable<RealtimeTranscriptionServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.Realtime.TranscriptionStreamLanguage? TranscriptionLanguage { get; init; }
#else
        public global::Mistral.Realtime.TranscriptionStreamLanguage? TranscriptionLanguage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptionLanguage))]
#endif
        public bool IsTranscriptionLanguage => TranscriptionLanguage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTranscriptionLanguage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.Realtime.TranscriptionStreamLanguage? value)
        {
            value = TranscriptionLanguage;
            return IsTranscriptionLanguage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Realtime.TranscriptionStreamLanguage PickTranscriptionLanguage() => IsTranscriptionLanguage
            ? TranscriptionLanguage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TranscriptionLanguage' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.Realtime.TranscriptionStreamSegmentDelta? TranscriptionSegment { get; init; }
#else
        public global::Mistral.Realtime.TranscriptionStreamSegmentDelta? TranscriptionSegment { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptionSegment))]
#endif
        public bool IsTranscriptionSegment => TranscriptionSegment != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTranscriptionSegment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.Realtime.TranscriptionStreamSegmentDelta? value)
        {
            value = TranscriptionSegment;
            return IsTranscriptionSegment;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Realtime.TranscriptionStreamSegmentDelta PickTranscriptionSegment() => IsTranscriptionSegment
            ? TranscriptionSegment!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TranscriptionSegment' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.Realtime.TranscriptionStreamTextDelta? TranscriptionTextDelta { get; init; }
#else
        public global::Mistral.Realtime.TranscriptionStreamTextDelta? TranscriptionTextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptionTextDelta))]
#endif
        public bool IsTranscriptionTextDelta => TranscriptionTextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTranscriptionTextDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.Realtime.TranscriptionStreamTextDelta? value)
        {
            value = TranscriptionTextDelta;
            return IsTranscriptionTextDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Realtime.TranscriptionStreamTextDelta PickTranscriptionTextDelta() => IsTranscriptionTextDelta
            ? TranscriptionTextDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TranscriptionTextDelta' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.Realtime.TranscriptionStreamDone? TranscriptionDone { get; init; }
#else
        public global::Mistral.Realtime.TranscriptionStreamDone? TranscriptionDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TranscriptionDone))]
#endif
        public bool IsTranscriptionDone => TranscriptionDone != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTranscriptionDone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.Realtime.TranscriptionStreamDone? value)
        {
            value = TranscriptionDone;
            return IsTranscriptionDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Realtime.TranscriptionStreamDone PickTranscriptionDone() => IsTranscriptionDone
            ? TranscriptionDone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TranscriptionDone' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.Realtime.RealtimeTranscriptionSessionCreated? SessionCreated { get; init; }
#else
        public global::Mistral.Realtime.RealtimeTranscriptionSessionCreated? SessionCreated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionCreated))]
#endif
        public bool IsSessionCreated => SessionCreated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.Realtime.RealtimeTranscriptionSessionCreated? value)
        {
            value = SessionCreated;
            return IsSessionCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Realtime.RealtimeTranscriptionSessionCreated PickSessionCreated() => IsSessionCreated
            ? SessionCreated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionCreated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated? SessionUpdated { get; init; }
#else
        public global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated? SessionUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionUpdated))]
#endif
        public bool IsSessionUpdated => SessionUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated? value)
        {
            value = SessionUpdated;
            return IsSessionUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated PickSessionUpdated() => IsSessionUpdated
            ? SessionUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionUpdated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.Realtime.RealtimeTranscriptionError? Error { get; init; }
#else
        public global::Mistral.Realtime.RealtimeTranscriptionError? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mistral.Realtime.RealtimeTranscriptionError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Realtime.RealtimeTranscriptionError PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranscriptionServerEvent(global::Mistral.Realtime.TranscriptionStreamLanguage value) => new RealtimeTranscriptionServerEvent((global::Mistral.Realtime.TranscriptionStreamLanguage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.Realtime.TranscriptionStreamLanguage?(RealtimeTranscriptionServerEvent @this) => @this.TranscriptionLanguage;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranscriptionServerEvent(global::Mistral.Realtime.TranscriptionStreamLanguage? value)
        {
            TranscriptionLanguage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RealtimeTranscriptionServerEvent FromTranscriptionLanguage(global::Mistral.Realtime.TranscriptionStreamLanguage? value) => new RealtimeTranscriptionServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranscriptionServerEvent(global::Mistral.Realtime.TranscriptionStreamSegmentDelta value) => new RealtimeTranscriptionServerEvent((global::Mistral.Realtime.TranscriptionStreamSegmentDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.Realtime.TranscriptionStreamSegmentDelta?(RealtimeTranscriptionServerEvent @this) => @this.TranscriptionSegment;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranscriptionServerEvent(global::Mistral.Realtime.TranscriptionStreamSegmentDelta? value)
        {
            TranscriptionSegment = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RealtimeTranscriptionServerEvent FromTranscriptionSegment(global::Mistral.Realtime.TranscriptionStreamSegmentDelta? value) => new RealtimeTranscriptionServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranscriptionServerEvent(global::Mistral.Realtime.TranscriptionStreamTextDelta value) => new RealtimeTranscriptionServerEvent((global::Mistral.Realtime.TranscriptionStreamTextDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.Realtime.TranscriptionStreamTextDelta?(RealtimeTranscriptionServerEvent @this) => @this.TranscriptionTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranscriptionServerEvent(global::Mistral.Realtime.TranscriptionStreamTextDelta? value)
        {
            TranscriptionTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RealtimeTranscriptionServerEvent FromTranscriptionTextDelta(global::Mistral.Realtime.TranscriptionStreamTextDelta? value) => new RealtimeTranscriptionServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranscriptionServerEvent(global::Mistral.Realtime.TranscriptionStreamDone value) => new RealtimeTranscriptionServerEvent((global::Mistral.Realtime.TranscriptionStreamDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.Realtime.TranscriptionStreamDone?(RealtimeTranscriptionServerEvent @this) => @this.TranscriptionDone;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranscriptionServerEvent(global::Mistral.Realtime.TranscriptionStreamDone? value)
        {
            TranscriptionDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RealtimeTranscriptionServerEvent FromTranscriptionDone(global::Mistral.Realtime.TranscriptionStreamDone? value) => new RealtimeTranscriptionServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranscriptionServerEvent(global::Mistral.Realtime.RealtimeTranscriptionSessionCreated value) => new RealtimeTranscriptionServerEvent((global::Mistral.Realtime.RealtimeTranscriptionSessionCreated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.Realtime.RealtimeTranscriptionSessionCreated?(RealtimeTranscriptionServerEvent @this) => @this.SessionCreated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranscriptionServerEvent(global::Mistral.Realtime.RealtimeTranscriptionSessionCreated? value)
        {
            SessionCreated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RealtimeTranscriptionServerEvent FromSessionCreated(global::Mistral.Realtime.RealtimeTranscriptionSessionCreated? value) => new RealtimeTranscriptionServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranscriptionServerEvent(global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated value) => new RealtimeTranscriptionServerEvent((global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated?(RealtimeTranscriptionServerEvent @this) => @this.SessionUpdated;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranscriptionServerEvent(global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RealtimeTranscriptionServerEvent FromSessionUpdated(global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated? value) => new RealtimeTranscriptionServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RealtimeTranscriptionServerEvent(global::Mistral.Realtime.RealtimeTranscriptionError value) => new RealtimeTranscriptionServerEvent((global::Mistral.Realtime.RealtimeTranscriptionError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.Realtime.RealtimeTranscriptionError?(RealtimeTranscriptionServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranscriptionServerEvent(global::Mistral.Realtime.RealtimeTranscriptionError? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RealtimeTranscriptionServerEvent FromError(global::Mistral.Realtime.RealtimeTranscriptionError? value) => new RealtimeTranscriptionServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public RealtimeTranscriptionServerEvent(
            global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminatorType? type,
            global::Mistral.Realtime.TranscriptionStreamLanguage? transcriptionLanguage,
            global::Mistral.Realtime.TranscriptionStreamSegmentDelta? transcriptionSegment,
            global::Mistral.Realtime.TranscriptionStreamTextDelta? transcriptionTextDelta,
            global::Mistral.Realtime.TranscriptionStreamDone? transcriptionDone,
            global::Mistral.Realtime.RealtimeTranscriptionSessionCreated? sessionCreated,
            global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated? sessionUpdated,
            global::Mistral.Realtime.RealtimeTranscriptionError? error
            )
        {
            Type = type;

            TranscriptionLanguage = transcriptionLanguage;
            TranscriptionSegment = transcriptionSegment;
            TranscriptionTextDelta = transcriptionTextDelta;
            TranscriptionDone = transcriptionDone;
            SessionCreated = sessionCreated;
            SessionUpdated = sessionUpdated;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            SessionUpdated as object ??
            SessionCreated as object ??
            TranscriptionDone as object ??
            TranscriptionTextDelta as object ??
            TranscriptionSegment as object ??
            TranscriptionLanguage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TranscriptionLanguage?.ToString() ??
            TranscriptionSegment?.ToString() ??
            TranscriptionTextDelta?.ToString() ??
            TranscriptionDone?.ToString() ??
            SessionCreated?.ToString() ??
            SessionUpdated?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTranscriptionLanguage && !IsTranscriptionSegment && !IsTranscriptionTextDelta && !IsTranscriptionDone && !IsSessionCreated && !IsSessionUpdated && !IsError || !IsTranscriptionLanguage && IsTranscriptionSegment && !IsTranscriptionTextDelta && !IsTranscriptionDone && !IsSessionCreated && !IsSessionUpdated && !IsError || !IsTranscriptionLanguage && !IsTranscriptionSegment && IsTranscriptionTextDelta && !IsTranscriptionDone && !IsSessionCreated && !IsSessionUpdated && !IsError || !IsTranscriptionLanguage && !IsTranscriptionSegment && !IsTranscriptionTextDelta && IsTranscriptionDone && !IsSessionCreated && !IsSessionUpdated && !IsError || !IsTranscriptionLanguage && !IsTranscriptionSegment && !IsTranscriptionTextDelta && !IsTranscriptionDone && IsSessionCreated && !IsSessionUpdated && !IsError || !IsTranscriptionLanguage && !IsTranscriptionSegment && !IsTranscriptionTextDelta && !IsTranscriptionDone && !IsSessionCreated && IsSessionUpdated && !IsError || !IsTranscriptionLanguage && !IsTranscriptionSegment && !IsTranscriptionTextDelta && !IsTranscriptionDone && !IsSessionCreated && !IsSessionUpdated && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.Realtime.TranscriptionStreamLanguage, TResult>? transcriptionLanguage = null,
            global::System.Func<global::Mistral.Realtime.TranscriptionStreamSegmentDelta, TResult>? transcriptionSegment = null,
            global::System.Func<global::Mistral.Realtime.TranscriptionStreamTextDelta, TResult>? transcriptionTextDelta = null,
            global::System.Func<global::Mistral.Realtime.TranscriptionStreamDone, TResult>? transcriptionDone = null,
            global::System.Func<global::Mistral.Realtime.RealtimeTranscriptionSessionCreated, TResult>? sessionCreated = null,
            global::System.Func<global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated, TResult>? sessionUpdated = null,
            global::System.Func<global::Mistral.Realtime.RealtimeTranscriptionError, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptionLanguage && transcriptionLanguage != null)
            {
                return transcriptionLanguage(TranscriptionLanguage!);
            }
            else if (IsTranscriptionSegment && transcriptionSegment != null)
            {
                return transcriptionSegment(TranscriptionSegment!);
            }
            else if (IsTranscriptionTextDelta && transcriptionTextDelta != null)
            {
                return transcriptionTextDelta(TranscriptionTextDelta!);
            }
            else if (IsTranscriptionDone && transcriptionDone != null)
            {
                return transcriptionDone(TranscriptionDone!);
            }
            else if (IsSessionCreated && sessionCreated != null)
            {
                return sessionCreated(SessionCreated!);
            }
            else if (IsSessionUpdated && sessionUpdated != null)
            {
                return sessionUpdated(SessionUpdated!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.Realtime.TranscriptionStreamLanguage>? transcriptionLanguage = null,

            global::System.Action<global::Mistral.Realtime.TranscriptionStreamSegmentDelta>? transcriptionSegment = null,

            global::System.Action<global::Mistral.Realtime.TranscriptionStreamTextDelta>? transcriptionTextDelta = null,

            global::System.Action<global::Mistral.Realtime.TranscriptionStreamDone>? transcriptionDone = null,

            global::System.Action<global::Mistral.Realtime.RealtimeTranscriptionSessionCreated>? sessionCreated = null,

            global::System.Action<global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated>? sessionUpdated = null,

            global::System.Action<global::Mistral.Realtime.RealtimeTranscriptionError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptionLanguage)
            {
                transcriptionLanguage?.Invoke(TranscriptionLanguage!);
            }
            else if (IsTranscriptionSegment)
            {
                transcriptionSegment?.Invoke(TranscriptionSegment!);
            }
            else if (IsTranscriptionTextDelta)
            {
                transcriptionTextDelta?.Invoke(TranscriptionTextDelta!);
            }
            else if (IsTranscriptionDone)
            {
                transcriptionDone?.Invoke(TranscriptionDone!);
            }
            else if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Mistral.Realtime.TranscriptionStreamLanguage>? transcriptionLanguage = null,
            global::System.Action<global::Mistral.Realtime.TranscriptionStreamSegmentDelta>? transcriptionSegment = null,
            global::System.Action<global::Mistral.Realtime.TranscriptionStreamTextDelta>? transcriptionTextDelta = null,
            global::System.Action<global::Mistral.Realtime.TranscriptionStreamDone>? transcriptionDone = null,
            global::System.Action<global::Mistral.Realtime.RealtimeTranscriptionSessionCreated>? sessionCreated = null,
            global::System.Action<global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated>? sessionUpdated = null,
            global::System.Action<global::Mistral.Realtime.RealtimeTranscriptionError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptionLanguage)
            {
                transcriptionLanguage?.Invoke(TranscriptionLanguage!);
            }
            else if (IsTranscriptionSegment)
            {
                transcriptionSegment?.Invoke(TranscriptionSegment!);
            }
            else if (IsTranscriptionTextDelta)
            {
                transcriptionTextDelta?.Invoke(TranscriptionTextDelta!);
            }
            else if (IsTranscriptionDone)
            {
                transcriptionDone?.Invoke(TranscriptionDone!);
            }
            else if (IsSessionCreated)
            {
                sessionCreated?.Invoke(SessionCreated!);
            }
            else if (IsSessionUpdated)
            {
                sessionUpdated?.Invoke(SessionUpdated!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TranscriptionLanguage,
                typeof(global::Mistral.Realtime.TranscriptionStreamLanguage),
                TranscriptionSegment,
                typeof(global::Mistral.Realtime.TranscriptionStreamSegmentDelta),
                TranscriptionTextDelta,
                typeof(global::Mistral.Realtime.TranscriptionStreamTextDelta),
                TranscriptionDone,
                typeof(global::Mistral.Realtime.TranscriptionStreamDone),
                SessionCreated,
                typeof(global::Mistral.Realtime.RealtimeTranscriptionSessionCreated),
                SessionUpdated,
                typeof(global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated),
                Error,
                typeof(global::Mistral.Realtime.RealtimeTranscriptionError),
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
        public bool Equals(RealtimeTranscriptionServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.Realtime.TranscriptionStreamLanguage?>.Default.Equals(TranscriptionLanguage, other.TranscriptionLanguage) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.Realtime.TranscriptionStreamSegmentDelta?>.Default.Equals(TranscriptionSegment, other.TranscriptionSegment) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.Realtime.TranscriptionStreamTextDelta?>.Default.Equals(TranscriptionTextDelta, other.TranscriptionTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.Realtime.TranscriptionStreamDone?>.Default.Equals(TranscriptionDone, other.TranscriptionDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.Realtime.RealtimeTranscriptionSessionCreated?>.Default.Equals(SessionCreated, other.SessionCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.Realtime.RealtimeTranscriptionSessionUpdated?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.Realtime.RealtimeTranscriptionError?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RealtimeTranscriptionServerEvent obj1, RealtimeTranscriptionServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RealtimeTranscriptionServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RealtimeTranscriptionServerEvent obj1, RealtimeTranscriptionServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RealtimeTranscriptionServerEvent o && Equals(o);
        }
    }
}
