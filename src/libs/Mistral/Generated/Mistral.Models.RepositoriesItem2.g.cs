using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RepositoriesItem2 : global::System.IEquatable<RepositoriesItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInRepositorieDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.GithubRepositoryIn? GithubRepositoryIn { get; init; }
#else
        public global::Mistral.GithubRepositoryIn? GithubRepositoryIn { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GithubRepositoryIn))]
#endif
        public bool IsGithubRepositoryIn => GithubRepositoryIn != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoriesItem2(global::Mistral.GithubRepositoryIn value) => new RepositoriesItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.GithubRepositoryIn?(RepositoriesItem2 @this) => @this.GithubRepositoryIn;

        /// <summary>
        /// 
        /// </summary>
        public RepositoriesItem2(global::Mistral.GithubRepositoryIn? value)
        {
            GithubRepositoryIn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RepositoriesItem2(
            global::Mistral.JobInRepositorieDiscriminatorType? type,
            global::Mistral.GithubRepositoryIn? githubRepositoryIn
            )
        {
            Type = type;

            GithubRepositoryIn = githubRepositoryIn;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GithubRepositoryIn as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGithubRepositoryIn;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.GithubRepositoryIn?, TResult>? githubRepositoryIn = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGithubRepositoryIn && githubRepositoryIn != null)
            {
                return githubRepositoryIn(GithubRepositoryIn!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.GithubRepositoryIn?>? githubRepositoryIn = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGithubRepositoryIn)
            {
                githubRepositoryIn?.Invoke(GithubRepositoryIn!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GithubRepositoryIn,
                typeof(global::Mistral.GithubRepositoryIn),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(RepositoriesItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.GithubRepositoryIn?>.Default.Equals(GithubRepositoryIn, other.GithubRepositoryIn) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RepositoriesItem2 obj1, RepositoriesItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RepositoriesItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RepositoriesItem2 obj1, RepositoriesItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RepositoriesItem2 o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Mistral.RepositoriesItem2? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Mistral.RepositoriesItem2),
                jsonSerializerContext) as global::Mistral.RepositoriesItem2?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Mistral.RepositoriesItem2? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.RepositoriesItem2>(
                json,
                jsonSerializerOptions);
        }

    }
}
