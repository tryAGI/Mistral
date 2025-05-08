#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputVariant1Item : global::System.IEquatable<InputVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole? Role { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.SystemMessage? System { get; init; }
#else
        public global::Mistral.SystemMessage? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant1Item(global::Mistral.SystemMessage value) => new InputVariant1Item((global::Mistral.SystemMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.SystemMessage?(InputVariant1Item @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant1Item(global::Mistral.SystemMessage? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.UserMessage? User { get; init; }
#else
        public global::Mistral.UserMessage? User { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant1Item(global::Mistral.UserMessage value) => new InputVariant1Item((global::Mistral.UserMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.UserMessage?(InputVariant1Item @this) => @this.User;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant1Item(global::Mistral.UserMessage? value)
        {
            User = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.AssistantMessage? Assistant { get; init; }
#else
        public global::Mistral.AssistantMessage? Assistant { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Assistant))]
#endif
        public bool IsAssistant => Assistant != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant1Item(global::Mistral.AssistantMessage value) => new InputVariant1Item((global::Mistral.AssistantMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.AssistantMessage?(InputVariant1Item @this) => @this.Assistant;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant1Item(global::Mistral.AssistantMessage? value)
        {
            Assistant = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ToolMessage? Tool { get; init; }
#else
        public global::Mistral.ToolMessage? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputVariant1Item(global::Mistral.ToolMessage value) => new InputVariant1Item((global::Mistral.ToolMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ToolMessage?(InputVariant1Item @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public InputVariant1Item(global::Mistral.ToolMessage? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputVariant1Item(
            global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole? role,
            global::Mistral.SystemMessage? system,
            global::Mistral.UserMessage? user,
            global::Mistral.AssistantMessage? assistant,
            global::Mistral.ToolMessage? tool
            )
        {
            Role = role;

            System = system;
            User = user;
            Assistant = assistant;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            Assistant as object ??
            User as object ??
            System as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            System?.ToString() ??
            User?.ToString() ??
            Assistant?.ToString() ??
            Tool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystem && !IsUser && !IsAssistant && !IsTool || !IsSystem && IsUser && !IsAssistant && !IsTool || !IsSystem && !IsUser && IsAssistant && !IsTool || !IsSystem && !IsUser && !IsAssistant && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.SystemMessage?, TResult>? system = null,
            global::System.Func<global::Mistral.UserMessage?, TResult>? user = null,
            global::System.Func<global::Mistral.AssistantMessage?, TResult>? assistant = null,
            global::System.Func<global::Mistral.ToolMessage?, TResult>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem && system != null)
            {
                return system(System!);
            }
            else if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsAssistant && assistant != null)
            {
                return assistant(Assistant!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.SystemMessage?>? system = null,
            global::System.Action<global::Mistral.UserMessage?>? user = null,
            global::System.Action<global::Mistral.AssistantMessage?>? assistant = null,
            global::System.Action<global::Mistral.ToolMessage?>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsAssistant)
            {
                assistant?.Invoke(Assistant!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                System,
                typeof(global::Mistral.SystemMessage),
                User,
                typeof(global::Mistral.UserMessage),
                Assistant,
                typeof(global::Mistral.AssistantMessage),
                Tool,
                typeof(global::Mistral.ToolMessage),
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
        public bool Equals(InputVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.SystemMessage?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.UserMessage?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.AssistantMessage?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ToolMessage?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputVariant1Item obj1, InputVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputVariant1Item obj1, InputVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputVariant1Item o && Equals(o);
        }
    }
}
