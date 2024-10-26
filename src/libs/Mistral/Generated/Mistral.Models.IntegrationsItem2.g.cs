using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IntegrationsItem2 : global::System.IEquatable<IntegrationsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInIntegrationDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.WandbIntegration? Wandb { get; init; }
#else
        public global::Mistral.WandbIntegration? Wandb { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Wandb))]
#endif
        public bool IsWandb => Wandb != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationsItem2(global::Mistral.WandbIntegration value) => new IntegrationsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.WandbIntegration?(IntegrationsItem2 @this) => @this.Wandb;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsItem2(global::Mistral.WandbIntegration? value)
        {
            Wandb = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsItem2(
            global::Mistral.JobInIntegrationDiscriminatorType? type,
            global::Mistral.WandbIntegration? wandb
            )
        {
            Type = type;

            Wandb = wandb;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Wandb as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWandb;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.WandbIntegration?, TResult>? wandb = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWandb && wandb != null)
            {
                return wandb(Wandb!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.WandbIntegration?>? wandb = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWandb)
            {
                wandb?.Invoke(Wandb!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Wandb,
                typeof(global::Mistral.WandbIntegration),
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
        public bool Equals(IntegrationsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.WandbIntegration?>.Default.Equals(Wandb, other.Wandb) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IntegrationsItem2 obj1, IntegrationsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IntegrationsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IntegrationsItem2 obj1, IntegrationsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IntegrationsItem2 o && Equals(o);
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
        public static global::Mistral.IntegrationsItem2? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Mistral.IntegrationsItem2),
                jsonSerializerContext) as global::Mistral.IntegrationsItem2?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Mistral.IntegrationsItem2? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.IntegrationsItem2>(
                json,
                jsonSerializerOptions);
        }

    }
}
