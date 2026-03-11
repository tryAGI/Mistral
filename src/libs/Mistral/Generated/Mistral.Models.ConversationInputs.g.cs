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
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

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
        public static implicit operator string?(ConversationInputs @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ConversationInputs(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConversationInputs(
            string? value1,
            global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>? inputEntries
            )
        {
            Value1 = value1;
            InputEntries = inputEntries;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputEntries as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            InputEntries?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsInputEntries;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>?, TResult>? inputEntries = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
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
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>>?>? inputEntries = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
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
                Value1,
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
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
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
