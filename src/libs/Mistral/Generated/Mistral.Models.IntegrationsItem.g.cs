using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IntegrationsItem : global::System.IEquatable<IntegrationsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOutIntegrationDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.WandbIntegrationOut? WandbIntegrationOut { get; init; }
#else
        public global::Mistral.WandbIntegrationOut? WandbIntegrationOut { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WandbIntegrationOut))]
#endif
        public bool IsWandbIntegrationOut => WandbIntegrationOut != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationsItem(global::Mistral.WandbIntegrationOut value) => new IntegrationsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.WandbIntegrationOut?(IntegrationsItem @this) => @this.WandbIntegrationOut;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsItem(global::Mistral.WandbIntegrationOut? value)
        {
            WandbIntegrationOut = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsItem(
            global::Mistral.DetailedJobOutIntegrationDiscriminatorType? type,
            global::Mistral.WandbIntegrationOut? wandbIntegrationOut
            )
        {
            Type = type;

            WandbIntegrationOut = wandbIntegrationOut;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WandbIntegrationOut as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWandbIntegrationOut;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.WandbIntegrationOut?, TResult>? wandbIntegrationOut = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWandbIntegrationOut && wandbIntegrationOut != null)
            {
                return wandbIntegrationOut(WandbIntegrationOut!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.WandbIntegrationOut?>? wandbIntegrationOut = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWandbIntegrationOut)
            {
                wandbIntegrationOut?.Invoke(WandbIntegrationOut!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WandbIntegrationOut,
                typeof(global::Mistral.WandbIntegrationOut),
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
        public bool Equals(IntegrationsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.WandbIntegrationOut?>.Default.Equals(WandbIntegrationOut, other.WandbIntegrationOut) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IntegrationsItem obj1, IntegrationsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IntegrationsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IntegrationsItem obj1, IntegrationsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IntegrationsItem o && Equals(o);
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
        public static global::Mistral.IntegrationsItem? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Mistral.IntegrationsItem),
                jsonSerializerContext) as global::Mistral.IntegrationsItem?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Mistral.IntegrationsItem? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.IntegrationsItem>(
                json,
                jsonSerializerOptions);
        }

    }
}
