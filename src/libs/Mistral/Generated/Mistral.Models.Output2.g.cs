#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Output2 : global::System.IEquatable<Output2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.PostJudgeInSchemaOutputDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.JudgeClassificationOutput? Classification { get; init; }
#else
        public global::Mistral.JudgeClassificationOutput? Classification { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Classification))]
#endif
        public bool IsClassification => Classification != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.JudgeRegressionOutput? Regression { get; init; }
#else
        public global::Mistral.JudgeRegressionOutput? Regression { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Regression))]
#endif
        public bool IsRegression => Regression != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Output2(global::Mistral.JudgeClassificationOutput value) => new Output2((global::Mistral.JudgeClassificationOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.JudgeClassificationOutput?(Output2 @this) => @this.Classification;

        /// <summary>
        /// 
        /// </summary>
        public Output2(global::Mistral.JudgeClassificationOutput? value)
        {
            Classification = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Output2(global::Mistral.JudgeRegressionOutput value) => new Output2((global::Mistral.JudgeRegressionOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.JudgeRegressionOutput?(Output2 @this) => @this.Regression;

        /// <summary>
        /// 
        /// </summary>
        public Output2(global::Mistral.JudgeRegressionOutput? value)
        {
            Regression = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Output2(
            global::Mistral.PostJudgeInSchemaOutputDiscriminatorType? type,
            global::Mistral.JudgeClassificationOutput? classification,
            global::Mistral.JudgeRegressionOutput? regression
            )
        {
            Type = type;

            Classification = classification;
            Regression = regression;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Regression as object ??
            Classification as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Classification?.ToString() ??
            Regression?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsClassification && !IsRegression || !IsClassification && IsRegression;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.JudgeClassificationOutput?, TResult>? classification = null,
            global::System.Func<global::Mistral.JudgeRegressionOutput?, TResult>? regression = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClassification && classification != null)
            {
                return classification(Classification!);
            }
            else if (IsRegression && regression != null)
            {
                return regression(Regression!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.JudgeClassificationOutput?>? classification = null,
            global::System.Action<global::Mistral.JudgeRegressionOutput?>? regression = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClassification)
            {
                classification?.Invoke(Classification!);
            }
            else if (IsRegression)
            {
                regression?.Invoke(Regression!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Classification,
                typeof(global::Mistral.JudgeClassificationOutput),
                Regression,
                typeof(global::Mistral.JudgeRegressionOutput),
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
        public bool Equals(Output2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.JudgeClassificationOutput?>.Default.Equals(Classification, other.Classification) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.JudgeRegressionOutput?>.Default.Equals(Regression, other.Regression) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Output2 obj1, Output2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Output2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Output2 obj1, Output2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Output2 o && Equals(o);
        }
    }
}
