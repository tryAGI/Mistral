#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IntegrationsVariant1Item : global::System.IEquatable<IntegrationsVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.WandbIntegrationOut? Wandb { get; init; }
#else
        public global::Mistral.WandbIntegrationOut? Wandb { get; }
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
        public static implicit operator IntegrationsVariant1Item(global::Mistral.WandbIntegrationOut value) => new IntegrationsVariant1Item((global::Mistral.WandbIntegrationOut?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.WandbIntegrationOut?(IntegrationsVariant1Item @this) => @this.Wandb;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsVariant1Item(global::Mistral.WandbIntegrationOut? value)
        {
            Wandb = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsVariant1Item(
            global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType? type,
            global::Mistral.WandbIntegrationOut? wandb
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
        public override string? ToString() =>
            Wandb?.ToString() 
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
            global::System.Func<global::Mistral.WandbIntegrationOut?, TResult>? wandb = null,
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
            global::System.Action<global::Mistral.WandbIntegrationOut?>? wandb = null,
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
                typeof(global::Mistral.WandbIntegrationOut),
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
        public bool Equals(IntegrationsVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.WandbIntegrationOut?>.Default.Equals(Wandb, other.Wandb) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IntegrationsVariant1Item obj1, IntegrationsVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IntegrationsVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IntegrationsVariant1Item obj1, IntegrationsVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IntegrationsVariant1Item o && Equals(o);
        }
    }
}
