using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RetrieveModelV1ModelsModelIdGetResponse : global::System.IEquatable<RetrieveModelV1ModelsModelIdGetResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.BaseModelCard? BaseCard { get; init; }
#else
        public global::Mistral.BaseModelCard? BaseCard { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseCard))]
#endif
        public bool IsBaseCard => BaseCard != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetrieveModelV1ModelsModelIdGetResponse(global::Mistral.BaseModelCard value) => new RetrieveModelV1ModelsModelIdGetResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.BaseModelCard?(RetrieveModelV1ModelsModelIdGetResponse @this) => @this.BaseCard;

        /// <summary>
        /// 
        /// </summary>
        public RetrieveModelV1ModelsModelIdGetResponse(global::Mistral.BaseModelCard? value)
        {
            BaseCard = value;
        }

        /// <summary>
        /// Extra fields for fine-tuned models.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.FTModelCard? FTCard { get; init; }
#else
        public global::Mistral.FTModelCard? FTCard { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FTCard))]
#endif
        public bool IsFTCard => FTCard != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetrieveModelV1ModelsModelIdGetResponse(global::Mistral.FTModelCard value) => new RetrieveModelV1ModelsModelIdGetResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.FTModelCard?(RetrieveModelV1ModelsModelIdGetResponse @this) => @this.FTCard;

        /// <summary>
        /// 
        /// </summary>
        public RetrieveModelV1ModelsModelIdGetResponse(global::Mistral.FTModelCard? value)
        {
            FTCard = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RetrieveModelV1ModelsModelIdGetResponse(
            global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType? type,
            global::Mistral.BaseModelCard? baseCard,
            global::Mistral.FTModelCard? fTCard
            )
        {
            Type = type;

            BaseCard = baseCard;
            FTCard = fTCard;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FTCard as object ??
            BaseCard as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseCard && !IsFTCard || !IsBaseCard && IsFTCard;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.BaseModelCard?, TResult>? baseCard = null,
            global::System.Func<global::Mistral.FTModelCard?, TResult>? fTCard = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseCard && baseCard != null)
            {
                return baseCard(BaseCard!);
            }
            else if (IsFTCard && fTCard != null)
            {
                return fTCard(FTCard!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.BaseModelCard?>? baseCard = null,
            global::System.Action<global::Mistral.FTModelCard?>? fTCard = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseCard)
            {
                baseCard?.Invoke(BaseCard!);
            }
            else if (IsFTCard)
            {
                fTCard?.Invoke(FTCard!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseCard,
                typeof(global::Mistral.BaseModelCard),
                FTCard,
                typeof(global::Mistral.FTModelCard),
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
        public bool Equals(RetrieveModelV1ModelsModelIdGetResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.BaseModelCard?>.Default.Equals(BaseCard, other.BaseCard) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.FTModelCard?>.Default.Equals(FTCard, other.FTCard) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RetrieveModelV1ModelsModelIdGetResponse obj1, RetrieveModelV1ModelsModelIdGetResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RetrieveModelV1ModelsModelIdGetResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RetrieveModelV1ModelsModelIdGetResponse obj1, RetrieveModelV1ModelsModelIdGetResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RetrieveModelV1ModelsModelIdGetResponse o && Equals(o);
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
        public static global::Mistral.RetrieveModelV1ModelsModelIdGetResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Mistral.RetrieveModelV1ModelsModelIdGetResponse),
                jsonSerializerContext) as global::Mistral.RetrieveModelV1ModelsModelIdGetResponse?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Mistral.RetrieveModelV1ModelsModelIdGetResponse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.RetrieveModelV1ModelsModelIdGetResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}
