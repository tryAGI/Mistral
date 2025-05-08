#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct JobsApiRoutesFineTuningGetFineTuningJobResponse : global::System.IEquatable<JobsApiRoutesFineTuningGetFineTuningJobResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType? JobType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.CompletionDetailedJobOut? Completion { get; init; }
#else
        public global::Mistral.CompletionDetailedJobOut? Completion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completion))]
#endif
        public bool IsCompletion => Completion != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JobsApiRoutesFineTuningGetFineTuningJobResponse(global::Mistral.CompletionDetailedJobOut value) => new JobsApiRoutesFineTuningGetFineTuningJobResponse((global::Mistral.CompletionDetailedJobOut?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.CompletionDetailedJobOut?(JobsApiRoutesFineTuningGetFineTuningJobResponse @this) => @this.Completion;

        /// <summary>
        /// 
        /// </summary>
        public JobsApiRoutesFineTuningGetFineTuningJobResponse(global::Mistral.CompletionDetailedJobOut? value)
        {
            Completion = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ClassifierDetailedJobOut? Classifier { get; init; }
#else
        public global::Mistral.ClassifierDetailedJobOut? Classifier { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Classifier))]
#endif
        public bool IsClassifier => Classifier != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JobsApiRoutesFineTuningGetFineTuningJobResponse(global::Mistral.ClassifierDetailedJobOut value) => new JobsApiRoutesFineTuningGetFineTuningJobResponse((global::Mistral.ClassifierDetailedJobOut?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ClassifierDetailedJobOut?(JobsApiRoutesFineTuningGetFineTuningJobResponse @this) => @this.Classifier;

        /// <summary>
        /// 
        /// </summary>
        public JobsApiRoutesFineTuningGetFineTuningJobResponse(global::Mistral.ClassifierDetailedJobOut? value)
        {
            Classifier = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JobsApiRoutesFineTuningGetFineTuningJobResponse(
            global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType? jobType,
            global::Mistral.CompletionDetailedJobOut? completion,
            global::Mistral.ClassifierDetailedJobOut? classifier
            )
        {
            JobType = jobType;

            Completion = completion;
            Classifier = classifier;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Classifier as object ??
            Completion as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Completion?.ToString() ??
            Classifier?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompletion && !IsClassifier || !IsCompletion && IsClassifier;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.CompletionDetailedJobOut?, TResult>? completion = null,
            global::System.Func<global::Mistral.ClassifierDetailedJobOut?, TResult>? classifier = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletion && completion != null)
            {
                return completion(Completion!);
            }
            else if (IsClassifier && classifier != null)
            {
                return classifier(Classifier!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.CompletionDetailedJobOut?>? completion = null,
            global::System.Action<global::Mistral.ClassifierDetailedJobOut?>? classifier = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletion)
            {
                completion?.Invoke(Completion!);
            }
            else if (IsClassifier)
            {
                classifier?.Invoke(Classifier!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Completion,
                typeof(global::Mistral.CompletionDetailedJobOut),
                Classifier,
                typeof(global::Mistral.ClassifierDetailedJobOut),
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
        public bool Equals(JobsApiRoutesFineTuningGetFineTuningJobResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.CompletionDetailedJobOut?>.Default.Equals(Completion, other.Completion) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ClassifierDetailedJobOut?>.Default.Equals(Classifier, other.Classifier) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JobsApiRoutesFineTuningGetFineTuningJobResponse obj1, JobsApiRoutesFineTuningGetFineTuningJobResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JobsApiRoutesFineTuningGetFineTuningJobResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JobsApiRoutesFineTuningGetFineTuningJobResponse obj1, JobsApiRoutesFineTuningGetFineTuningJobResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JobsApiRoutesFineTuningGetFineTuningJobResponse o && Equals(o);
        }
    }
}
