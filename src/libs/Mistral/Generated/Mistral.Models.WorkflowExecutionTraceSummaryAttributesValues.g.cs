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
            global::System.Func<string?, TResult>? workflowExecutionTraceSummaryAttributesValuesVariant1 = null,
            global::System.Func<int?, TResult>? workflowExecutionTraceSummaryAttributesValuesVariant2 = null,
            global::System.Func<double?, TResult>? workflowExecutionTraceSummaryAttributesValuesVariant3 = null,
            global::System.Func<bool?, TResult>? workflowExecutionTraceSummaryAttributesValuesVariant4 = null,
            global::System.Func<object?, TResult>? workflowExecutionTraceSummaryAttributesValuesVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowExecutionTraceSummaryAttributesValuesVariant1 && workflowExecutionTraceSummaryAttributesValuesVariant1 != null)
            {
                return workflowExecutionTraceSummaryAttributesValuesVariant1(WorkflowExecutionTraceSummaryAttributesValuesVariant1!);
            }
            else if (IsWorkflowExecutionTraceSummaryAttributesValuesVariant2 && workflowExecutionTraceSummaryAttributesValuesVariant2 != null)
            {
                return workflowExecutionTraceSummaryAttributesValuesVariant2(WorkflowExecutionTraceSummaryAttributesValuesVariant2!);
            }
            else if (IsWorkflowExecutionTraceSummaryAttributesValuesVariant3 && workflowExecutionTraceSummaryAttributesValuesVariant3 != null)
            {
                return workflowExecutionTraceSummaryAttributesValuesVariant3(WorkflowExecutionTraceSummaryAttributesValuesVariant3!);
            }
            else if (IsWorkflowExecutionTraceSummaryAttributesValuesVariant4 && workflowExecutionTraceSummaryAttributesValuesVariant4 != null)
            {
                return workflowExecutionTraceSummaryAttributesValuesVariant4(WorkflowExecutionTraceSummaryAttributesValuesVariant4!);
            }
            else if (IsWorkflowExecutionTraceSummaryAttributesValuesVariant5 && workflowExecutionTraceSummaryAttributesValuesVariant5 != null)
            {
                return workflowExecutionTraceSummaryAttributesValuesVariant5(WorkflowExecutionTraceSummaryAttributesValuesVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? workflowExecutionTraceSummaryAttributesValuesVariant1 = null,
            global::System.Action<int?>? workflowExecutionTraceSummaryAttributesValuesVariant2 = null,
            global::System.Action<double?>? workflowExecutionTraceSummaryAttributesValuesVariant3 = null,
            global::System.Action<bool?>? workflowExecutionTraceSummaryAttributesValuesVariant4 = null,
            global::System.Action<object?>? workflowExecutionTraceSummaryAttributesValuesVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowExecutionTraceSummaryAttributesValuesVariant1)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant1?.Invoke(WorkflowExecutionTraceSummaryAttributesValuesVariant1!);
            }
            else if (IsWorkflowExecutionTraceSummaryAttributesValuesVariant2)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant2?.Invoke(WorkflowExecutionTraceSummaryAttributesValuesVariant2!);
            }
            else if (IsWorkflowExecutionTraceSummaryAttributesValuesVariant3)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant3?.Invoke(WorkflowExecutionTraceSummaryAttributesValuesVariant3!);
            }
            else if (IsWorkflowExecutionTraceSummaryAttributesValuesVariant4)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant4?.Invoke(WorkflowExecutionTraceSummaryAttributesValuesVariant4!);
            }
            else if (IsWorkflowExecutionTraceSummaryAttributesValuesVariant5)
            {
                workflowExecutionTraceSummaryAttributesValuesVariant5?.Invoke(WorkflowExecutionTraceSummaryAttributesValuesVariant5!);
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
