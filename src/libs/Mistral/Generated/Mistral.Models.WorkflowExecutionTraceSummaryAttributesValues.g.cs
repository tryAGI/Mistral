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
        public string? WorkflowExecutionTraceSummaryAttributesValuesVariant1 { get; init; }
#else
        public string? WorkflowExecutionTraceSummaryAttributesValuesVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionTraceSummaryAttributesValuesVariant1))]
#endif
        public bool IsWorkflowExecutionTraceSummaryAttributesValuesVariant1 => WorkflowExecutionTraceSummaryAttributesValuesVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowExecutionTraceSummaryAttributesValuesVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = WorkflowExecutionTraceSummaryAttributesValuesVariant1;
            return IsWorkflowExecutionTraceSummaryAttributesValuesVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickWorkflowExecutionTraceSummaryAttributesValuesVariant1() => WorkflowExecutionTraceSummaryAttributesValuesVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowExecutionTraceSummaryAttributesValuesVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public int? WorkflowExecutionTraceSummaryAttributesValuesVariant2 { get; init; }
#else
        public int? WorkflowExecutionTraceSummaryAttributesValuesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionTraceSummaryAttributesValuesVariant2))]
#endif
        public bool IsWorkflowExecutionTraceSummaryAttributesValuesVariant2 => WorkflowExecutionTraceSummaryAttributesValuesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowExecutionTraceSummaryAttributesValuesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = WorkflowExecutionTraceSummaryAttributesValuesVariant2;
            return IsWorkflowExecutionTraceSummaryAttributesValuesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public int PickWorkflowExecutionTraceSummaryAttributesValuesVariant2() => WorkflowExecutionTraceSummaryAttributesValuesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowExecutionTraceSummaryAttributesValuesVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public double? WorkflowExecutionTraceSummaryAttributesValuesVariant3 { get; init; }
#else
        public double? WorkflowExecutionTraceSummaryAttributesValuesVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionTraceSummaryAttributesValuesVariant3))]
#endif
        public bool IsWorkflowExecutionTraceSummaryAttributesValuesVariant3 => WorkflowExecutionTraceSummaryAttributesValuesVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowExecutionTraceSummaryAttributesValuesVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = WorkflowExecutionTraceSummaryAttributesValuesVariant3;
            return IsWorkflowExecutionTraceSummaryAttributesValuesVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public double PickWorkflowExecutionTraceSummaryAttributesValuesVariant3() => WorkflowExecutionTraceSummaryAttributesValuesVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowExecutionTraceSummaryAttributesValuesVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? WorkflowExecutionTraceSummaryAttributesValuesVariant4 { get; init; }
#else
        public bool? WorkflowExecutionTraceSummaryAttributesValuesVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionTraceSummaryAttributesValuesVariant4))]
#endif
        public bool IsWorkflowExecutionTraceSummaryAttributesValuesVariant4 => WorkflowExecutionTraceSummaryAttributesValuesVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowExecutionTraceSummaryAttributesValuesVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = WorkflowExecutionTraceSummaryAttributesValuesVariant4;
            return IsWorkflowExecutionTraceSummaryAttributesValuesVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickWorkflowExecutionTraceSummaryAttributesValuesVariant4() => WorkflowExecutionTraceSummaryAttributesValuesVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowExecutionTraceSummaryAttributesValuesVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? WorkflowExecutionTraceSummaryAttributesValuesVariant5 { get; init; }
#else
        public object? WorkflowExecutionTraceSummaryAttributesValuesVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionTraceSummaryAttributesValuesVariant5))]
#endif
        public bool IsWorkflowExecutionTraceSummaryAttributesValuesVariant5 => WorkflowExecutionTraceSummaryAttributesValuesVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowExecutionTraceSummaryAttributesValuesVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = WorkflowExecutionTraceSummaryAttributesValuesVariant5;
            return IsWorkflowExecutionTraceSummaryAttributesValuesVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickWorkflowExecutionTraceSummaryAttributesValuesVariant5() => WorkflowExecutionTraceSummaryAttributesValuesVariant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowExecutionTraceSummaryAttributesValuesVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkflowExecutionTraceSummaryAttributesValues(string value) => new WorkflowExecutionTraceSummaryAttributesValues((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(WorkflowExecutionTraceSummaryAttributesValues @this) => @this.WorkflowExecutionTraceSummaryAttributesValuesVariant1;

        /// <summary>
        ///
        /// </summary>
        public WorkflowExecutionTraceSummaryAttributesValues(string? value)
        {
            WorkflowExecutionTraceSummaryAttributesValuesVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkflowExecutionTraceSummaryAttributesValues FromWorkflowExecutionTraceSummaryAttributesValuesVariant1(string? value) => new WorkflowExecutionTraceSummaryAttributesValues(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkflowExecutionTraceSummaryAttributesValues(int value) => new WorkflowExecutionTraceSummaryAttributesValues((int?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator int?(WorkflowExecutionTraceSummaryAttributesValues @this) => @this.WorkflowExecutionTraceSummaryAttributesValuesVariant2;

        /// <summary>
        ///
        /// </summary>
        public WorkflowExecutionTraceSummaryAttributesValues(int? value)
        {
            WorkflowExecutionTraceSummaryAttributesValuesVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkflowExecutionTraceSummaryAttributesValues FromWorkflowExecutionTraceSummaryAttributesValuesVariant2(int? value) => new WorkflowExecutionTraceSummaryAttributesValues(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkflowExecutionTraceSummaryAttributesValues(double value) => new WorkflowExecutionTraceSummaryAttributesValues((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(WorkflowExecutionTraceSummaryAttributesValues @this) => @this.WorkflowExecutionTraceSummaryAttributesValuesVariant3;

        /// <summary>
        ///
        /// </summary>
        public WorkflowExecutionTraceSummaryAttributesValues(double? value)
        {
            WorkflowExecutionTraceSummaryAttributesValuesVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkflowExecutionTraceSummaryAttributesValues FromWorkflowExecutionTraceSummaryAttributesValuesVariant3(double? value) => new WorkflowExecutionTraceSummaryAttributesValues(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkflowExecutionTraceSummaryAttributesValues(bool value) => new WorkflowExecutionTraceSummaryAttributesValues((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(WorkflowExecutionTraceSummaryAttributesValues @this) => @this.WorkflowExecutionTraceSummaryAttributesValuesVariant4;

        /// <summary>
        ///
        /// </summary>
        public WorkflowExecutionTraceSummaryAttributesValues(bool? value)
        {
            WorkflowExecutionTraceSummaryAttributesValuesVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkflowExecutionTraceSummaryAttributesValues FromWorkflowExecutionTraceSummaryAttributesValuesVariant4(bool? value) => new WorkflowExecutionTraceSummaryAttributesValues(value);

        /// <summary>
        ///
        /// </summary>
        public WorkflowExecutionTraceSummaryAttributesValues(
            string? workflowExecutionTraceSummaryAttributesValuesVariant1,
            int? workflowExecutionTraceSummaryAttributesValuesVariant2,
            double? workflowExecutionTraceSummaryAttributesValuesVariant3,
            bool? workflowExecutionTraceSummaryAttributesValuesVariant4,
            object? workflowExecutionTraceSummaryAttributesValuesVariant5
            )
        {
            WorkflowExecutionTraceSummaryAttributesValuesVariant1 = workflowExecutionTraceSummaryAttributesValuesVariant1;
            WorkflowExecutionTraceSummaryAttributesValuesVariant2 = workflowExecutionTraceSummaryAttributesValuesVariant2;
            WorkflowExecutionTraceSummaryAttributesValuesVariant3 = workflowExecutionTraceSummaryAttributesValuesVariant3;
            WorkflowExecutionTraceSummaryAttributesValuesVariant4 = workflowExecutionTraceSummaryAttributesValuesVariant4;
            WorkflowExecutionTraceSummaryAttributesValuesVariant5 = workflowExecutionTraceSummaryAttributesValuesVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WorkflowExecutionTraceSummaryAttributesValuesVariant5 as object ??
            WorkflowExecutionTraceSummaryAttributesValuesVariant4 as object ??
            WorkflowExecutionTraceSummaryAttributesValuesVariant3 as object ??
            WorkflowExecutionTraceSummaryAttributesValuesVariant2 as object ??
            WorkflowExecutionTraceSummaryAttributesValuesVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WorkflowExecutionTraceSummaryAttributesValuesVariant1?.ToString() ??
            WorkflowExecutionTraceSummaryAttributesValuesVariant2?.ToString() ??
            WorkflowExecutionTraceSummaryAttributesValuesVariant3?.ToString() ??
            WorkflowExecutionTraceSummaryAttributesValuesVariant4?.ToString().ToLowerInvariant() ??
            WorkflowExecutionTraceSummaryAttributesValuesVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWorkflowExecutionTraceSummaryAttributesValuesVariant1 || IsWorkflowExecutionTraceSummaryAttributesValuesVariant2 || IsWorkflowExecutionTraceSummaryAttributesValuesVariant3 || IsWorkflowExecutionTraceSummaryAttributesValuesVariant4 || IsWorkflowExecutionTraceSummaryAttributesValuesVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? workflowExecutionTraceSummaryAttributesValuesVariant1 = null,
            global::System.Func<int?, TResult>? workflowExecutionTraceSummaryAttributesValuesVariant2 = null,
            global::System.Func<double?, TResult>? workflowExecutionTraceSummaryAttributesValuesVariant3 = null,
            global::System.Func<bool?, TResult>? workflowExecutionTraceSummaryAttributesValuesVariant4 = null,
            global::System.Func<object, TResult>? workflowExecutionTraceSummaryAttributesValuesVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WorkflowExecutionTraceSummaryAttributesValuesVariant1 is { } __value0 && workflowExecutionTraceSummaryAttributesValuesVariant1 != null)
            {
                return workflowExecutionTraceSummaryAttributesValuesVariant1(__value0);
            }
            else if (WorkflowExecutionTraceSummaryAttributesValuesVariant2 is { } __value1 && workflowExecutionTraceSummaryAttributesValuesVariant2 != null)
            {
                return workflowExecutionTraceSummaryAttributesValuesVariant2(__value1);
            }
            else if (WorkflowExecutionTraceSummaryAttributesValuesVariant3 is { } __value2 && workflowExecutionTraceSummaryAttributesValuesVariant3 != null)
            {
                return workflowExecutionTraceSummaryAttributesValuesVariant3(__value2);
            }
            else if (WorkflowExecutionTraceSummaryAttributesValuesVariant4 is { } __value3 && workflowExecutionTraceSummaryAttributesValuesVariant4 != null)
            {
                return workflowExecutionTraceSummaryAttributesValuesVariant4(__value3);
            }
            else if (WorkflowExecutionTraceSummaryAttributesValuesVariant5 is { } __value4 && workflowExecutionTraceSummaryAttributesValuesVariant5 != null)
            {
                return workflowExecutionTraceSummaryAttributesValuesVariant5(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? workflowExecutionTraceSummaryAttributesValuesVariant1 = null,

            global::System.Action<int?>? workflowExecutionTraceSummaryAttributesValuesVariant2 = null,

            global::System.Action<double?>? workflowExecutionTraceSummaryAttributesValuesVariant3 = null,

            global::System.Action<bool?>? workflowExecutionTraceSummaryAttributesValuesVariant4 = null,

            global::System.Action<object>? workflowExecutionTraceSummaryAttributesValuesVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WorkflowExecutionTraceSummaryAttributesValuesVariant1 is { } __value0)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant1?.Invoke(__value0);
            }
            else if (WorkflowExecutionTraceSummaryAttributesValuesVariant2 is { } __value1)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant2?.Invoke(__value1);
            }
            else if (WorkflowExecutionTraceSummaryAttributesValuesVariant3 is { } __value2)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant3?.Invoke(__value2);
            }
            else if (WorkflowExecutionTraceSummaryAttributesValuesVariant4 is { } __value3)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant4?.Invoke(__value3);
            }
            else if (WorkflowExecutionTraceSummaryAttributesValuesVariant5 is { } __value4)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? workflowExecutionTraceSummaryAttributesValuesVariant1 = null,
            global::System.Action<int?>? workflowExecutionTraceSummaryAttributesValuesVariant2 = null,
            global::System.Action<double?>? workflowExecutionTraceSummaryAttributesValuesVariant3 = null,
            global::System.Action<bool?>? workflowExecutionTraceSummaryAttributesValuesVariant4 = null,
            global::System.Action<object>? workflowExecutionTraceSummaryAttributesValuesVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WorkflowExecutionTraceSummaryAttributesValuesVariant1 is { } __value0)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant1?.Invoke(__value0);
            }
            else if (WorkflowExecutionTraceSummaryAttributesValuesVariant2 is { } __value1)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant2?.Invoke(__value1);
            }
            else if (WorkflowExecutionTraceSummaryAttributesValuesVariant3 is { } __value2)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant3?.Invoke(__value2);
            }
            else if (WorkflowExecutionTraceSummaryAttributesValuesVariant4 is { } __value3)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant4?.Invoke(__value3);
            }
            else if (WorkflowExecutionTraceSummaryAttributesValuesVariant5 is { } __value4)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkflowExecutionTraceSummaryAttributesValuesVariant1,
                typeof(string),
                WorkflowExecutionTraceSummaryAttributesValuesVariant2,
                typeof(int),
                WorkflowExecutionTraceSummaryAttributesValuesVariant3,
                typeof(double),
                WorkflowExecutionTraceSummaryAttributesValuesVariant4,
                typeof(bool),
                WorkflowExecutionTraceSummaryAttributesValuesVariant5,
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
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(WorkflowExecutionTraceSummaryAttributesValuesVariant1, other.WorkflowExecutionTraceSummaryAttributesValuesVariant1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(WorkflowExecutionTraceSummaryAttributesValuesVariant2, other.WorkflowExecutionTraceSummaryAttributesValuesVariant2) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(WorkflowExecutionTraceSummaryAttributesValuesVariant3, other.WorkflowExecutionTraceSummaryAttributesValuesVariant3) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(WorkflowExecutionTraceSummaryAttributesValuesVariant4, other.WorkflowExecutionTraceSummaryAttributesValuesVariant4) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(WorkflowExecutionTraceSummaryAttributesValuesVariant5, other.WorkflowExecutionTraceSummaryAttributesValuesVariant5)
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
