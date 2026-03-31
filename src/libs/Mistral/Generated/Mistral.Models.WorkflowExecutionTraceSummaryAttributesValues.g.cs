#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WorkflowExecutionTraceSummaryAttributesValues : global::System.IEquatable<WorkflowExecutionTraceSummaryAttributesValues>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? Value2 { get; init; }
#else
        public int? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? Value3 { get; init; }
#else
        public double? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? Value4 { get; init; }
#else
        public bool? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value5 { get; init; }
#else
        public object? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowExecutionTraceSummaryAttributesValues(string value) => new WorkflowExecutionTraceSummaryAttributesValues((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(WorkflowExecutionTraceSummaryAttributesValues @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowExecutionTraceSummaryAttributesValues(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowExecutionTraceSummaryAttributesValues(int value) => new WorkflowExecutionTraceSummaryAttributesValues((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(WorkflowExecutionTraceSummaryAttributesValues @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowExecutionTraceSummaryAttributesValues(int? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowExecutionTraceSummaryAttributesValues(double value) => new WorkflowExecutionTraceSummaryAttributesValues((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(WorkflowExecutionTraceSummaryAttributesValues @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowExecutionTraceSummaryAttributesValues(double? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowExecutionTraceSummaryAttributesValues(bool value) => new WorkflowExecutionTraceSummaryAttributesValues((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(WorkflowExecutionTraceSummaryAttributesValues @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowExecutionTraceSummaryAttributesValues(bool? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowExecutionTraceSummaryAttributesValues(
            string? value1,
            int? value2,
            double? value3,
            bool? value4,
            object? value5
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString().ToLowerInvariant() ??
            Value5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<int?, TResult>? value2 = null,
            global::System.Func<double?, TResult>? value3 = null,
            global::System.Func<bool?, TResult>? value4 = null,
            global::System.Func<object?, TResult>? value5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<int?>? value2 = null,
            global::System.Action<double?>? value3 = null,
            global::System.Action<bool?>? value4 = null,
            global::System.Action<object?>? value5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(string),
                Value2,
                typeof(int),
                Value3,
                typeof(double),
                Value4,
                typeof(bool),
                Value5,
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
        public bool Equals(WorkflowExecutionTraceSummaryAttributesValues other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value5, other.Value5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WorkflowExecutionTraceSummaryAttributesValues obj1, WorkflowExecutionTraceSummaryAttributesValues obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkflowExecutionTraceSummaryAttributesValues>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WorkflowExecutionTraceSummaryAttributesValues obj1, WorkflowExecutionTraceSummaryAttributesValues obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkflowExecutionTraceSummaryAttributesValues o && Equals(o);
        }
    }
}
