#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AuthorizationVariant1 : global::System.IEquatable<AuthorizationVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.OAuth2TokenAuth? Oauth2Token { get; init; }
#else
        public global::Mistral.OAuth2TokenAuth? Oauth2Token { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Oauth2Token))]
#endif
        public bool IsOauth2Token => Oauth2Token != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.APIKeyAuth? ApiKey { get; init; }
#else
        public global::Mistral.APIKeyAuth? ApiKey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiKey))]
#endif
        public bool IsApiKey => ApiKey != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthorizationVariant1(global::Mistral.OAuth2TokenAuth value) => new AuthorizationVariant1((global::Mistral.OAuth2TokenAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.OAuth2TokenAuth?(AuthorizationVariant1 @this) => @this.Oauth2Token;

        /// <summary>
        /// 
        /// </summary>
        public AuthorizationVariant1(global::Mistral.OAuth2TokenAuth? value)
        {
            Oauth2Token = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthorizationVariant1(global::Mistral.APIKeyAuth value) => new AuthorizationVariant1((global::Mistral.APIKeyAuth?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.APIKeyAuth?(AuthorizationVariant1 @this) => @this.ApiKey;

        /// <summary>
        /// 
        /// </summary>
        public AuthorizationVariant1(global::Mistral.APIKeyAuth? value)
        {
            ApiKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AuthorizationVariant1(
            global::Mistral.CustomConnectorAuthorizationVariant1DiscriminatorType? type,
            global::Mistral.OAuth2TokenAuth? oauth2Token,
            global::Mistral.APIKeyAuth? apiKey
            )
        {
            Type = type;

            Oauth2Token = oauth2Token;
            ApiKey = apiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApiKey as object ??
            Oauth2Token as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Oauth2Token?.ToString() ??
            ApiKey?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOauth2Token && !IsApiKey || !IsOauth2Token && IsApiKey;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.OAuth2TokenAuth?, TResult>? oauth2Token = null,
            global::System.Func<global::Mistral.APIKeyAuth?, TResult>? apiKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOauth2Token && oauth2Token != null)
            {
                return oauth2Token(Oauth2Token!);
            }
            else if (IsApiKey && apiKey != null)
            {
                return apiKey(ApiKey!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.OAuth2TokenAuth?>? oauth2Token = null,
            global::System.Action<global::Mistral.APIKeyAuth?>? apiKey = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOauth2Token)
            {
                oauth2Token?.Invoke(Oauth2Token!);
            }
            else if (IsApiKey)
            {
                apiKey?.Invoke(ApiKey!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Oauth2Token,
                typeof(global::Mistral.OAuth2TokenAuth),
                ApiKey,
                typeof(global::Mistral.APIKeyAuth),
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
        public bool Equals(AuthorizationVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.OAuth2TokenAuth?>.Default.Equals(Oauth2Token, other.Oauth2Token) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.APIKeyAuth?>.Default.Equals(ApiKey, other.ApiKey) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AuthorizationVariant1 obj1, AuthorizationVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AuthorizationVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AuthorizationVariant1 obj1, AuthorizationVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AuthorizationVariant1 o && Equals(o);
        }
    }
}
