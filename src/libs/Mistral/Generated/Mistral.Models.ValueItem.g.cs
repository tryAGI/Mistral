#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ValueItem : global::System.IEquatable<ValueItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp? Op { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.JSONPatchAppend? Append { get; init; }
#else
        public global::Mistral.JSONPatchAppend? Append { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Append))]
#endif
        public bool IsAppend => Append != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.JSONPatchAdd? Add { get; init; }
#else
        public global::Mistral.JSONPatchAdd? Add { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Add))]
#endif
        public bool IsAdd => Add != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.JSONPatchReplace? Replace { get; init; }
#else
        public global::Mistral.JSONPatchReplace? Replace { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Replace))]
#endif
        public bool IsReplace => Replace != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.JSONPatchRemove? Remove { get; init; }
#else
        public global::Mistral.JSONPatchRemove? Remove { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Remove))]
#endif
        public bool IsRemove => Remove != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ValueItem(global::Mistral.JSONPatchAppend value) => new ValueItem((global::Mistral.JSONPatchAppend?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.JSONPatchAppend?(ValueItem @this) => @this.Append;

        /// <summary>
        /// 
        /// </summary>
        public ValueItem(global::Mistral.JSONPatchAppend? value)
        {
            Append = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ValueItem(global::Mistral.JSONPatchAdd value) => new ValueItem((global::Mistral.JSONPatchAdd?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.JSONPatchAdd?(ValueItem @this) => @this.Add;

        /// <summary>
        /// 
        /// </summary>
        public ValueItem(global::Mistral.JSONPatchAdd? value)
        {
            Add = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ValueItem(global::Mistral.JSONPatchReplace value) => new ValueItem((global::Mistral.JSONPatchReplace?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.JSONPatchReplace?(ValueItem @this) => @this.Replace;

        /// <summary>
        /// 
        /// </summary>
        public ValueItem(global::Mistral.JSONPatchReplace? value)
        {
            Replace = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ValueItem(global::Mistral.JSONPatchRemove value) => new ValueItem((global::Mistral.JSONPatchRemove?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.JSONPatchRemove?(ValueItem @this) => @this.Remove;

        /// <summary>
        /// 
        /// </summary>
        public ValueItem(global::Mistral.JSONPatchRemove? value)
        {
            Remove = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ValueItem(
            global::Mistral.JSONPatchPayloadResponseValueItemDiscriminatorOp? op,
            global::Mistral.JSONPatchAppend? append,
            global::Mistral.JSONPatchAdd? add,
            global::Mistral.JSONPatchReplace? replace,
            global::Mistral.JSONPatchRemove? remove
            )
        {
            Op = op;

            Append = append;
            Add = add;
            Replace = replace;
            Remove = remove;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Remove as object ??
            Replace as object ??
            Add as object ??
            Append as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Append?.ToString() ??
            Add?.ToString() ??
            Replace?.ToString() ??
            Remove?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAppend && !IsAdd && !IsReplace && !IsRemove || !IsAppend && IsAdd && !IsReplace && !IsRemove || !IsAppend && !IsAdd && IsReplace && !IsRemove || !IsAppend && !IsAdd && !IsReplace && IsRemove;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.JSONPatchAppend?, TResult>? append = null,
            global::System.Func<global::Mistral.JSONPatchAdd?, TResult>? add = null,
            global::System.Func<global::Mistral.JSONPatchReplace?, TResult>? replace = null,
            global::System.Func<global::Mistral.JSONPatchRemove?, TResult>? remove = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppend && append != null)
            {
                return append(Append!);
            }
            else if (IsAdd && add != null)
            {
                return add(Add!);
            }
            else if (IsReplace && replace != null)
            {
                return replace(Replace!);
            }
            else if (IsRemove && remove != null)
            {
                return remove(Remove!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.JSONPatchAppend?>? append = null,
            global::System.Action<global::Mistral.JSONPatchAdd?>? add = null,
            global::System.Action<global::Mistral.JSONPatchReplace?>? replace = null,
            global::System.Action<global::Mistral.JSONPatchRemove?>? remove = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppend)
            {
                append?.Invoke(Append!);
            }
            else if (IsAdd)
            {
                add?.Invoke(Add!);
            }
            else if (IsReplace)
            {
                replace?.Invoke(Replace!);
            }
            else if (IsRemove)
            {
                remove?.Invoke(Remove!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Append,
                typeof(global::Mistral.JSONPatchAppend),
                Add,
                typeof(global::Mistral.JSONPatchAdd),
                Replace,
                typeof(global::Mistral.JSONPatchReplace),
                Remove,
                typeof(global::Mistral.JSONPatchRemove),
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
        public bool Equals(ValueItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.JSONPatchAppend?>.Default.Equals(Append, other.Append) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.JSONPatchAdd?>.Default.Equals(Add, other.Add) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.JSONPatchReplace?>.Default.Equals(Replace, other.Replace) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.JSONPatchRemove?>.Default.Equals(Remove, other.Remove) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ValueItem obj1, ValueItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ValueItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ValueItem obj1, ValueItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ValueItem o && Equals(o);
        }
    }
}
