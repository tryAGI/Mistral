#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CompletionArgsStop : global::System.IEquatable<CompletionArgsStop>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? CompletionArgsStopVariant1 { get; init; }
#else
        public string? CompletionArgsStopVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionArgsStopVariant1))]
#endif
        public bool IsCompletionArgsStopVariant1 => CompletionArgsStopVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? CompletionArgsStopVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? CompletionArgsStopVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionArgsStopVariant2))]
#endif
        public bool IsCompletionArgsStopVariant2 => CompletionArgsStopVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CompletionArgsStopVariant3 { get; init; }
#else
        public object? CompletionArgsStopVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionArgsStopVariant3))]
#endif
        public bool IsCompletionArgsStopVariant3 => CompletionArgsStopVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionArgsStop(string value) => new CompletionArgsStop((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(CompletionArgsStop @this) => @this.CompletionArgsStopVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CompletionArgsStop(string? value)
        {
            CompletionArgsStopVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CompletionArgsStop(
            string? completionArgsStopVariant1,
            global::System.Collections.Generic.IList<string>? completionArgsStopVariant2,
            object? completionArgsStopVariant3
            )
        {
            CompletionArgsStopVariant1 = completionArgsStopVariant1;
            CompletionArgsStopVariant2 = completionArgsStopVariant2;
            CompletionArgsStopVariant3 = completionArgsStopVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompletionArgsStopVariant3 as object ??
            CompletionArgsStopVariant2 as object ??
            CompletionArgsStopVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CompletionArgsStopVariant1?.ToString() ??
            CompletionArgsStopVariant2?.ToString() ??
            CompletionArgsStopVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompletionArgsStopVariant1 || IsCompletionArgsStopVariant2 || IsCompletionArgsStopVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? completionArgsStopVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? completionArgsStopVariant2 = null,
            global::System.Func<object?, TResult>? completionArgsStopVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletionArgsStopVariant1 && completionArgsStopVariant1 != null)
            {
                return completionArgsStopVariant1(CompletionArgsStopVariant1!);
            }
            else if (IsCompletionArgsStopVariant2 && completionArgsStopVariant2 != null)
            {
                return completionArgsStopVariant2(CompletionArgsStopVariant2!);
            }
            else if (IsCompletionArgsStopVariant3 && completionArgsStopVariant3 != null)
            {
                return completionArgsStopVariant3(CompletionArgsStopVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? completionArgsStopVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? completionArgsStopVariant2 = null,
            global::System.Action<object?>? completionArgsStopVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletionArgsStopVariant1)
            {
                completionArgsStopVariant1?.Invoke(CompletionArgsStopVariant1!);
            }
            else if (IsCompletionArgsStopVariant2)
            {
                completionArgsStopVariant2?.Invoke(CompletionArgsStopVariant2!);
            }
            else if (IsCompletionArgsStopVariant3)
            {
                completionArgsStopVariant3?.Invoke(CompletionArgsStopVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CompletionArgsStopVariant1,
                typeof(string),
                CompletionArgsStopVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
                CompletionArgsStopVariant3,
                typeof(object),
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
        public bool Equals(CompletionArgsStop other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(CompletionArgsStopVariant1, other.CompletionArgsStopVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(CompletionArgsStopVariant2, other.CompletionArgsStopVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CompletionArgsStopVariant3, other.CompletionArgsStopVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CompletionArgsStop obj1, CompletionArgsStop obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CompletionArgsStop>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CompletionArgsStop obj1, CompletionArgsStop obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompletionArgsStop o && Equals(o);
        }
    }
}
