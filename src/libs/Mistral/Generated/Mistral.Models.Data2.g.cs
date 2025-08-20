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
        public global::Mistral.TranscriptionStreamEventsDataDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.TranscriptionStreamTextDelta? TranscriptionTextDelta { get; init; }
#else
        public global::Mistral.TranscriptionStreamTextDelta? TranscriptionTextDelta { get; }
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
        public static implicit operator Data2(global::Mistral.TranscriptionStreamTextDelta value) => new Data2((global::Mistral.TranscriptionStreamTextDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.TranscriptionStreamTextDelta?(Data2 @this) => @this.TranscriptionTextDelta;

        /// <summary>
        /// 
        /// </summary>
        public Data2(global::Mistral.TranscriptionStreamTextDelta? value)
        {
            TranscriptionTextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.TranscriptionStreamLanguage? TranscriptionLanguage { get; init; }
#else
        public global::Mistral.TranscriptionStreamLanguage? TranscriptionLanguage { get; }
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
        public static implicit operator Data2(global::Mistral.TranscriptionStreamLanguage value) => new Data2((global::Mistral.TranscriptionStreamLanguage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.TranscriptionStreamLanguage?(Data2 @this) => @this.TranscriptionLanguage;

        /// <summary>
        /// 
        /// </summary>
        public Data2(global::Mistral.TranscriptionStreamLanguage? value)
        {
            TranscriptionLanguage = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.TranscriptionStreamSegmentDelta? TranscriptionSegment { get; init; }
#else
        public global::Mistral.TranscriptionStreamSegmentDelta? TranscriptionSegment { get; }
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
        public static implicit operator Data2(global::Mistral.TranscriptionStreamSegmentDelta value) => new Data2((global::Mistral.TranscriptionStreamSegmentDelta?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.TranscriptionStreamSegmentDelta?(Data2 @this) => @this.TranscriptionSegment;

        /// <summary>
        /// 
        /// </summary>
        public Data2(global::Mistral.TranscriptionStreamSegmentDelta? value)
        {
            TranscriptionSegment = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.TranscriptionStreamDone? TranscriptionDone { get; init; }
#else
        public global::Mistral.TranscriptionStreamDone? TranscriptionDone { get; }
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
        public static implicit operator Data2(global::Mistral.TranscriptionStreamDone value) => new Data2((global::Mistral.TranscriptionStreamDone?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.TranscriptionStreamDone?(Data2 @this) => @this.TranscriptionDone;

        /// <summary>
        /// 
        /// </summary>
        public Data2(global::Mistral.TranscriptionStreamDone? value)
        {
            TranscriptionDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Data2(
            global::Mistral.TranscriptionStreamEventsDataDiscriminatorType? type,
            global::Mistral.TranscriptionStreamTextDelta? transcriptionTextDelta,
            global::Mistral.TranscriptionStreamLanguage? transcriptionLanguage,
            global::Mistral.TranscriptionStreamSegmentDelta? transcriptionSegment,
            global::Mistral.TranscriptionStreamDone? transcriptionDone
            )
        {
            Type = type;

            TranscriptionTextDelta = transcriptionTextDelta;
            TranscriptionLanguage = transcriptionLanguage;
            TranscriptionSegment = transcriptionSegment;
            TranscriptionDone = transcriptionDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TranscriptionDone as object ??
            TranscriptionSegment as object ??
            TranscriptionLanguage as object ??
            TranscriptionTextDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TranscriptionTextDelta?.ToString() ??
            TranscriptionLanguage?.ToString() ??
            TranscriptionSegment?.ToString() ??
            TranscriptionDone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTranscriptionTextDelta && !IsTranscriptionLanguage && !IsTranscriptionSegment && !IsTranscriptionDone || !IsTranscriptionTextDelta && IsTranscriptionLanguage && !IsTranscriptionSegment && !IsTranscriptionDone || !IsTranscriptionTextDelta && !IsTranscriptionLanguage && IsTranscriptionSegment && !IsTranscriptionDone || !IsTranscriptionTextDelta && !IsTranscriptionLanguage && !IsTranscriptionSegment && IsTranscriptionDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.TranscriptionStreamTextDelta?, TResult>? transcriptionTextDelta = null,
            global::System.Func<global::Mistral.TranscriptionStreamLanguage?, TResult>? transcriptionLanguage = null,
            global::System.Func<global::Mistral.TranscriptionStreamSegmentDelta?, TResult>? transcriptionSegment = null,
            global::System.Func<global::Mistral.TranscriptionStreamDone?, TResult>? transcriptionDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptionTextDelta && transcriptionTextDelta != null)
            {
                return transcriptionTextDelta(TranscriptionTextDelta!);
            }
            else if (IsTranscriptionLanguage && transcriptionLanguage != null)
            {
                return transcriptionLanguage(TranscriptionLanguage!);
            }
            else if (IsTranscriptionSegment && transcriptionSegment != null)
            {
                return transcriptionSegment(TranscriptionSegment!);
            }
            else if (IsTranscriptionDone && transcriptionDone != null)
            {
                return transcriptionDone(TranscriptionDone!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.TranscriptionStreamTextDelta?>? transcriptionTextDelta = null,
            global::System.Action<global::Mistral.TranscriptionStreamLanguage?>? transcriptionLanguage = null,
            global::System.Action<global::Mistral.TranscriptionStreamSegmentDelta?>? transcriptionSegment = null,
            global::System.Action<global::Mistral.TranscriptionStreamDone?>? transcriptionDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscriptionTextDelta)
            {
                transcriptionTextDelta?.Invoke(TranscriptionTextDelta!);
            }
            else if (IsTranscriptionLanguage)
            {
                transcriptionLanguage?.Invoke(TranscriptionLanguage!);
            }
            else if (IsTranscriptionSegment)
            {
                transcriptionSegment?.Invoke(TranscriptionSegment!);
            }
            else if (IsTranscriptionDone)
            {
                transcriptionDone?.Invoke(TranscriptionDone!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TranscriptionTextDelta,
                typeof(global::Mistral.TranscriptionStreamTextDelta),
                TranscriptionLanguage,
                typeof(global::Mistral.TranscriptionStreamLanguage),
                TranscriptionSegment,
                typeof(global::Mistral.TranscriptionStreamSegmentDelta),
                TranscriptionDone,
                typeof(global::Mistral.TranscriptionStreamDone),
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
                global::System.Collections.Generic.EqualityComparer<global::Mistral.TranscriptionStreamTextDelta?>.Default.Equals(TranscriptionTextDelta, other.TranscriptionTextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.TranscriptionStreamLanguage?>.Default.Equals(TranscriptionLanguage, other.TranscriptionLanguage) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.TranscriptionStreamSegmentDelta?>.Default.Equals(TranscriptionSegment, other.TranscriptionSegment) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.TranscriptionStreamDone?>.Default.Equals(TranscriptionDone, other.TranscriptionDone) 
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
