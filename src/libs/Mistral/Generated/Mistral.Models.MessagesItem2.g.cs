using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesItem2 : global::System.IEquatable<MessagesItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionRequestMessageDiscriminatorRole? Role { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.SystemMessage? SystemMessage { get; init; }
#else
        public global::Mistral.SystemMessage? SystemMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemMessage))]
#endif
        public bool IsSystemMessage => SystemMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem2(global::Mistral.SystemMessage value) => new MessagesItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.SystemMessage?(MessagesItem2 @this) => @this.SystemMessage;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem2(global::Mistral.SystemMessage? value)
        {
            SystemMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.UserMessage? UserMessage { get; init; }
#else
        public global::Mistral.UserMessage? UserMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMessage))]
#endif
        public bool IsUserMessage => UserMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem2(global::Mistral.UserMessage value) => new MessagesItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.UserMessage?(MessagesItem2 @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem2(global::Mistral.UserMessage? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.AssistantMessage? AssistantMessage { get; init; }
#else
        public global::Mistral.AssistantMessage? AssistantMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantMessage))]
#endif
        public bool IsAssistantMessage => AssistantMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem2(global::Mistral.AssistantMessage value) => new MessagesItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.AssistantMessage?(MessagesItem2 @this) => @this.AssistantMessage;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem2(global::Mistral.AssistantMessage? value)
        {
            AssistantMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ToolMessage? ToolMessage { get; init; }
#else
        public global::Mistral.ToolMessage? ToolMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolMessage))]
#endif
        public bool IsToolMessage => ToolMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem2(global::Mistral.ToolMessage value) => new MessagesItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ToolMessage?(MessagesItem2 @this) => @this.ToolMessage;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem2(global::Mistral.ToolMessage? value)
        {
            ToolMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem2(
            global::Mistral.ChatCompletionRequestMessageDiscriminatorRole? role,
            global::Mistral.SystemMessage? systemMessage,
            global::Mistral.UserMessage? userMessage,
            global::Mistral.AssistantMessage? assistantMessage,
            global::Mistral.ToolMessage? toolMessage
            )
        {
            Role = role;

            SystemMessage = systemMessage;
            UserMessage = userMessage;
            AssistantMessage = assistantMessage;
            ToolMessage = toolMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolMessage as object ??
            AssistantMessage as object ??
            UserMessage as object ??
            SystemMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystemMessage && !IsUserMessage && !IsAssistantMessage && !IsToolMessage || !IsSystemMessage && IsUserMessage && !IsAssistantMessage && !IsToolMessage || !IsSystemMessage && !IsUserMessage && IsAssistantMessage && !IsToolMessage || !IsSystemMessage && !IsUserMessage && !IsAssistantMessage && IsToolMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.SystemMessage?, TResult>? systemMessage = null,
            global::System.Func<global::Mistral.UserMessage?, TResult>? userMessage = null,
            global::System.Func<global::Mistral.AssistantMessage?, TResult>? assistantMessage = null,
            global::System.Func<global::Mistral.ToolMessage?, TResult>? toolMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystemMessage && systemMessage != null)
            {
                return systemMessage(SystemMessage!);
            }
            else if (IsUserMessage && userMessage != null)
            {
                return userMessage(UserMessage!);
            }
            else if (IsAssistantMessage && assistantMessage != null)
            {
                return assistantMessage(AssistantMessage!);
            }
            else if (IsToolMessage && toolMessage != null)
            {
                return toolMessage(ToolMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.SystemMessage?>? systemMessage = null,
            global::System.Action<global::Mistral.UserMessage?>? userMessage = null,
            global::System.Action<global::Mistral.AssistantMessage?>? assistantMessage = null,
            global::System.Action<global::Mistral.ToolMessage?>? toolMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystemMessage)
            {
                systemMessage?.Invoke(SystemMessage!);
            }
            else if (IsUserMessage)
            {
                userMessage?.Invoke(UserMessage!);
            }
            else if (IsAssistantMessage)
            {
                assistantMessage?.Invoke(AssistantMessage!);
            }
            else if (IsToolMessage)
            {
                toolMessage?.Invoke(ToolMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SystemMessage,
                typeof(global::Mistral.SystemMessage),
                UserMessage,
                typeof(global::Mistral.UserMessage),
                AssistantMessage,
                typeof(global::Mistral.AssistantMessage),
                ToolMessage,
                typeof(global::Mistral.ToolMessage),
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
        public bool Equals(MessagesItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.SystemMessage?>.Default.Equals(SystemMessage, other.SystemMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.UserMessage?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.AssistantMessage?>.Default.Equals(AssistantMessage, other.AssistantMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ToolMessage?>.Default.Equals(ToolMessage, other.ToolMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesItem2 obj1, MessagesItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesItem2 obj1, MessagesItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesItem2 o && Equals(o);
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
        public static global::Mistral.MessagesItem2? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Mistral.MessagesItem2),
                jsonSerializerContext) as global::Mistral.MessagesItem2?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Mistral.MessagesItem2? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.MessagesItem2>(
                json,
                jsonSerializerOptions);
        }

    }
}
