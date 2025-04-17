#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem2 : global::System.IEquatable<DataItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModelListDataItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.BaseModelCard? Base { get; init; }
#else
        public global::Mistral.BaseModelCard? Base { get; }
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
        public static implicit operator DataItem2(global::Mistral.BaseModelCard value) => new DataItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.BaseModelCard?(DataItem2 @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::Mistral.BaseModelCard? value)
        {
            Base = value;
        }

        /// <summary>
        /// Extra fields for fine-tuned models.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.FTModelCard? FineTuned { get; init; }
#else
        public global::Mistral.FTModelCard? FineTuned { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FineTuned))]
#endif
        public bool IsFineTuned => FineTuned != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem2(global::Mistral.FTModelCard value) => new DataItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.FTModelCard?(DataItem2 @this) => @this.FineTuned;

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(global::Mistral.FTModelCard? value)
        {
            FineTuned = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataItem2(
            global::Mistral.ModelListDataItemDiscriminatorType? type,
            global::Mistral.BaseModelCard? @base,
            global::Mistral.FTModelCard? fineTuned
            )
        {
            Type = type;

            Base = @base;
            FineTuned = fineTuned;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FineTuned as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            FineTuned?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && !IsFineTuned || !IsBase && IsFineTuned;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.BaseModelCard?, TResult>? @base = null,
            global::System.Func<global::Mistral.FTModelCard?, TResult>? fineTuned = null,
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
            else if (IsFineTuned && fineTuned != null)
            {
                return fineTuned(FineTuned!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.BaseModelCard?>? @base = null,
            global::System.Action<global::Mistral.FTModelCard?>? fineTuned = null,
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
            else if (IsFineTuned)
            {
                fineTuned?.Invoke(FineTuned!);
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
                typeof(global::Mistral.BaseModelCard),
                FineTuned,
                typeof(global::Mistral.FTModelCard),
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
        public bool Equals(DataItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.BaseModelCard?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.FTModelCard?>.Default.Equals(FineTuned, other.FineTuned) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem2 obj1, DataItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem2 obj1, DataItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem2 o && Equals(o);
        }
    }
}
