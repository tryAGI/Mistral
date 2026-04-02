#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FunctionCallEntryArguments : global::System.IEquatable<FunctionCallEntryArguments>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? FunctionCallEntryArgumentsVariant1 { get; init; }
#else
        public object? FunctionCallEntryArgumentsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallEntryArgumentsVariant1))]
#endif
        public bool IsFunctionCallEntryArgumentsVariant1 => FunctionCallEntryArgumentsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? FunctionCallEntryArgumentsVariant2 { get; init; }
#else
        public string? FunctionCallEntryArgumentsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallEntryArgumentsVariant2))]
#endif
        public bool IsFunctionCallEntryArgumentsVariant2 => FunctionCallEntryArgumentsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionCallEntryArguments(string value) => new FunctionCallEntryArguments((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(FunctionCallEntryArguments @this) => @this.FunctionCallEntryArgumentsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallEntryArguments(string? value)
        {
            FunctionCallEntryArgumentsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallEntryArguments(
            object? functionCallEntryArgumentsVariant1,
            string? functionCallEntryArgumentsVariant2
            )
        {
            FunctionCallEntryArgumentsVariant1 = functionCallEntryArgumentsVariant1;
            FunctionCallEntryArgumentsVariant2 = functionCallEntryArgumentsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionCallEntryArgumentsVariant2 as object ??
            FunctionCallEntryArgumentsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FunctionCallEntryArgumentsVariant1?.ToString() ??
            FunctionCallEntryArgumentsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunctionCallEntryArgumentsVariant1 || IsFunctionCallEntryArgumentsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? functionCallEntryArgumentsVariant1 = null,
            global::System.Func<string?, TResult>? functionCallEntryArgumentsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallEntryArgumentsVariant1 && functionCallEntryArgumentsVariant1 != null)
            {
                return functionCallEntryArgumentsVariant1(FunctionCallEntryArgumentsVariant1!);
            }
            else if (IsFunctionCallEntryArgumentsVariant2 && functionCallEntryArgumentsVariant2 != null)
            {
                return functionCallEntryArgumentsVariant2(FunctionCallEntryArgumentsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? functionCallEntryArgumentsVariant1 = null,
            global::System.Action<string?>? functionCallEntryArgumentsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallEntryArgumentsVariant1)
            {
                functionCallEntryArgumentsVariant1?.Invoke(FunctionCallEntryArgumentsVariant1!);
            }
            else if (IsFunctionCallEntryArgumentsVariant2)
            {
                functionCallEntryArgumentsVariant2?.Invoke(FunctionCallEntryArgumentsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FunctionCallEntryArgumentsVariant1,
                typeof(object),
                FunctionCallEntryArgumentsVariant2,
                typeof(string),
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
        public bool Equals(FunctionCallEntryArguments other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(FunctionCallEntryArgumentsVariant1, other.FunctionCallEntryArgumentsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(FunctionCallEntryArgumentsVariant2, other.FunctionCallEntryArgumentsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionCallEntryArguments obj1, FunctionCallEntryArguments obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionCallEntryArguments>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionCallEntryArguments obj1, FunctionCallEntryArguments obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionCallEntryArguments o && Equals(o);
        }
    }
}
