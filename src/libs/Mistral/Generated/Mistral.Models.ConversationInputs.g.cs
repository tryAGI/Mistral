#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ConversationInputs : global::System.IEquatable<ConversationInputs>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ConversationInputsVariant1 { get; init; }
#else
        public string? ConversationInputsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationInputsVariant1))]
#endif
        public bool IsConversationInputsVariant1 => ConversationInputsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>? InputEntries { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>? InputEntries { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputEntries))]
#endif
        public bool IsInputEntries => InputEntries != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConversationInputs(string value) => new ConversationInputs((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ConversationInputs @this) => @this.ConversationInputsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ConversationInputs(string? value)
        {
            ConversationInputsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationInputs(
            string? conversationInputsVariant1,
            global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>? inputEntries
            )
        {
            ConversationInputsVariant1 = conversationInputsVariant1;
            InputEntries = inputEntries;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputEntries as object ??
            ConversationInputsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationInputsVariant1?.ToString() ??
            InputEntries?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationInputsVariant1 || IsInputEntries;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? conversationInputsVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>?, TResult>? inputEntries = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationInputsVariant1 && conversationInputsVariant1 != null)
            {
                return conversationInputsVariant1(ConversationInputsVariant1!);
            }
            else if (IsInputEntries && inputEntries != null)
            {
                return inputEntries(InputEntries!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? conversationInputsVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>?>? inputEntries = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationInputsVariant1)
            {
                conversationInputsVariant1?.Invoke(ConversationInputsVariant1!);
            }
            else if (IsInputEntries)
            {
                inputEntries?.Invoke(InputEntries!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationInputsVariant1,
                typeof(string),
                InputEntries,
                typeof(global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>),
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
        public bool Equals(ConversationInputs other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ConversationInputsVariant1, other.ConversationInputsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>?>.Default.Equals(InputEntries, other.InputEntries) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConversationInputs obj1, ConversationInputs obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConversationInputs>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConversationInputs obj1, ConversationInputs obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConversationInputs o && Equals(o);
        }
    }
}
