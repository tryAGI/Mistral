#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// The current state or incremental update for the task.
    /// </summary>
    public readonly partial struct Payload : global::System.IEquatable<Payload>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType? Type { get; }

        /// <summary>
        /// A payload containing arbitrary JSON data.<br/>
        /// Used for complete state snapshots or final results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.JSONPayloadResponse? Json { get; init; }
#else
        public global::Mistral.JSONPayloadResponse? Json { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Json))]
#endif
        public bool IsJson => Json != null;

        /// <summary>
        /// A payload containing a list of JSON Patch operations.<br/>
        /// Used for streaming incremental updates to workflow state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.JSONPatchPayloadResponse? JsonPatch { get; init; }
#else
        public global::Mistral.JSONPatchPayloadResponse? JsonPatch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonPatch))]
#endif
        public bool IsJsonPatch => JsonPatch != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Payload(global::Mistral.JSONPayloadResponse value) => new Payload((global::Mistral.JSONPayloadResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.JSONPayloadResponse?(Payload @this) => @this.Json;

        /// <summary>
        /// 
        /// </summary>
        public Payload(global::Mistral.JSONPayloadResponse? value)
        {
            Json = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Payload(global::Mistral.JSONPatchPayloadResponse value) => new Payload((global::Mistral.JSONPatchPayloadResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.JSONPatchPayloadResponse?(Payload @this) => @this.JsonPatch;

        /// <summary>
        /// 
        /// </summary>
        public Payload(global::Mistral.JSONPatchPayloadResponse? value)
        {
            JsonPatch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Payload(
            global::Mistral.CustomTaskInProgressAttributesResponsePayloadDiscriminatorType? type,
            global::Mistral.JSONPayloadResponse? json,
            global::Mistral.JSONPatchPayloadResponse? jsonPatch
            )
        {
            Type = type;

            Json = json;
            JsonPatch = jsonPatch;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonPatch as object ??
            Json as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Json?.ToString() ??
            JsonPatch?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJson && !IsJsonPatch || !IsJson && IsJsonPatch;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.JSONPayloadResponse?, TResult>? json = null,
            global::System.Func<global::Mistral.JSONPatchPayloadResponse?, TResult>? jsonPatch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJson && json != null)
            {
                return json(Json!);
            }
            else if (IsJsonPatch && jsonPatch != null)
            {
                return jsonPatch(JsonPatch!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.JSONPayloadResponse?>? json = null,
            global::System.Action<global::Mistral.JSONPatchPayloadResponse?>? jsonPatch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJson)
            {
                json?.Invoke(Json!);
            }
            else if (IsJsonPatch)
            {
                jsonPatch?.Invoke(JsonPatch!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Json,
                typeof(global::Mistral.JSONPayloadResponse),
                JsonPatch,
                typeof(global::Mistral.JSONPatchPayloadResponse),
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
        public bool Equals(Payload other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.JSONPayloadResponse?>.Default.Equals(Json, other.Json) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.JSONPatchPayloadResponse?>.Default.Equals(JsonPatch, other.JsonPatch) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Payload obj1, Payload obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Payload>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Payload obj1, Payload obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Payload o && Equals(o);
        }
    }
}
