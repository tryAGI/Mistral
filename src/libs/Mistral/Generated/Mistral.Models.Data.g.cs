#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Data : global::System.IEquatable<Data>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ConversationEventsDataDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ResponseStartedEvent? ConversationResponseStarted { get; init; }
#else
        public global::Mistral.ResponseStartedEvent? ConversationResponseStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationResponseStarted))]
#endif
        public bool IsConversationResponseStarted => ConversationResponseStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Mistral.ResponseStartedEvent value) => new Data((global::Mistral.ResponseStartedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ResponseStartedEvent?(Data @this) => @this.ConversationResponseStarted;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Mistral.ResponseStartedEvent? value)
        {
            ConversationResponseStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ResponseDoneEvent? ConversationResponseDone { get; init; }
#else
        public global::Mistral.ResponseDoneEvent? ConversationResponseDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationResponseDone))]
#endif
        public bool IsConversationResponseDone => ConversationResponseDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Mistral.ResponseDoneEvent value) => new Data((global::Mistral.ResponseDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ResponseDoneEvent?(Data @this) => @this.ConversationResponseDone;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Mistral.ResponseDoneEvent? value)
        {
            ConversationResponseDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ResponseErrorEvent? ConversationResponseError { get; init; }
#else
        public global::Mistral.ResponseErrorEvent? ConversationResponseError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConversationResponseError))]
#endif
        public bool IsConversationResponseError => ConversationResponseError != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Mistral.ResponseErrorEvent value) => new Data((global::Mistral.ResponseErrorEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ResponseErrorEvent?(Data @this) => @this.ConversationResponseError;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Mistral.ResponseErrorEvent? value)
        {
            ConversationResponseError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ToolExecutionStartedEvent? ToolExecutionStarted { get; init; }
#else
        public global::Mistral.ToolExecutionStartedEvent? ToolExecutionStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolExecutionStarted))]
#endif
        public bool IsToolExecutionStarted => ToolExecutionStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Mistral.ToolExecutionStartedEvent value) => new Data((global::Mistral.ToolExecutionStartedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ToolExecutionStartedEvent?(Data @this) => @this.ToolExecutionStarted;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Mistral.ToolExecutionStartedEvent? value)
        {
            ToolExecutionStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ToolExecutionDeltaEvent? ToolExecutionDelta { get; init; }
#else
        public global::Mistral.ToolExecutionDeltaEvent? ToolExecutionDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolExecutionDelta))]
#endif
        public bool IsToolExecutionDelta => ToolExecutionDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Mistral.ToolExecutionDeltaEvent value) => new Data((global::Mistral.ToolExecutionDeltaEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ToolExecutionDeltaEvent?(Data @this) => @this.ToolExecutionDelta;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Mistral.ToolExecutionDeltaEvent? value)
        {
            ToolExecutionDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ToolExecutionDoneEvent? ToolExecutionDone { get; init; }
#else
        public global::Mistral.ToolExecutionDoneEvent? ToolExecutionDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolExecutionDone))]
#endif
        public bool IsToolExecutionDone => ToolExecutionDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Mistral.ToolExecutionDoneEvent value) => new Data((global::Mistral.ToolExecutionDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ToolExecutionDoneEvent?(Data @this) => @this.ToolExecutionDone;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Mistral.ToolExecutionDoneEvent? value)
        {
            ToolExecutionDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.MessageOutputEvent? MessageOutputDelta { get; init; }
#else
        public global::Mistral.MessageOutputEvent? MessageOutputDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageOutputDelta))]
#endif
        public bool IsMessageOutputDelta => MessageOutputDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Mistral.MessageOutputEvent value) => new Data((global::Mistral.MessageOutputEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.MessageOutputEvent?(Data @this) => @this.MessageOutputDelta;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Mistral.MessageOutputEvent? value)
        {
            MessageOutputDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.FunctionCallEvent? FunctionCallDelta { get; init; }
#else
        public global::Mistral.FunctionCallEvent? FunctionCallDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallDelta))]
#endif
        public bool IsFunctionCallDelta => FunctionCallDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Mistral.FunctionCallEvent value) => new Data((global::Mistral.FunctionCallEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.FunctionCallEvent?(Data @this) => @this.FunctionCallDelta;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Mistral.FunctionCallEvent? value)
        {
            FunctionCallDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.AgentHandoffStartedEvent? AgentHandoffStarted { get; init; }
#else
        public global::Mistral.AgentHandoffStartedEvent? AgentHandoffStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentHandoffStarted))]
#endif
        public bool IsAgentHandoffStarted => AgentHandoffStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Mistral.AgentHandoffStartedEvent value) => new Data((global::Mistral.AgentHandoffStartedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.AgentHandoffStartedEvent?(Data @this) => @this.AgentHandoffStarted;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Mistral.AgentHandoffStartedEvent? value)
        {
            AgentHandoffStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.AgentHandoffDoneEvent? AgentHandoffDone { get; init; }
#else
        public global::Mistral.AgentHandoffDoneEvent? AgentHandoffDone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentHandoffDone))]
#endif
        public bool IsAgentHandoffDone => AgentHandoffDone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Data(global::Mistral.AgentHandoffDoneEvent value) => new Data((global::Mistral.AgentHandoffDoneEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.AgentHandoffDoneEvent?(Data @this) => @this.AgentHandoffDone;

        /// <summary>
        /// 
        /// </summary>
        public Data(global::Mistral.AgentHandoffDoneEvent? value)
        {
            AgentHandoffDone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Data(
            global::Mistral.ConversationEventsDataDiscriminatorType? type,
            global::Mistral.ResponseStartedEvent? conversationResponseStarted,
            global::Mistral.ResponseDoneEvent? conversationResponseDone,
            global::Mistral.ResponseErrorEvent? conversationResponseError,
            global::Mistral.ToolExecutionStartedEvent? toolExecutionStarted,
            global::Mistral.ToolExecutionDeltaEvent? toolExecutionDelta,
            global::Mistral.ToolExecutionDoneEvent? toolExecutionDone,
            global::Mistral.MessageOutputEvent? messageOutputDelta,
            global::Mistral.FunctionCallEvent? functionCallDelta,
            global::Mistral.AgentHandoffStartedEvent? agentHandoffStarted,
            global::Mistral.AgentHandoffDoneEvent? agentHandoffDone
            )
        {
            Type = type;

            ConversationResponseStarted = conversationResponseStarted;
            ConversationResponseDone = conversationResponseDone;
            ConversationResponseError = conversationResponseError;
            ToolExecutionStarted = toolExecutionStarted;
            ToolExecutionDelta = toolExecutionDelta;
            ToolExecutionDone = toolExecutionDone;
            MessageOutputDelta = messageOutputDelta;
            FunctionCallDelta = functionCallDelta;
            AgentHandoffStarted = agentHandoffStarted;
            AgentHandoffDone = agentHandoffDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentHandoffDone as object ??
            AgentHandoffStarted as object ??
            FunctionCallDelta as object ??
            MessageOutputDelta as object ??
            ToolExecutionDone as object ??
            ToolExecutionDelta as object ??
            ToolExecutionStarted as object ??
            ConversationResponseError as object ??
            ConversationResponseDone as object ??
            ConversationResponseStarted as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConversationResponseStarted?.ToString() ??
            ConversationResponseDone?.ToString() ??
            ConversationResponseError?.ToString() ??
            ToolExecutionStarted?.ToString() ??
            ToolExecutionDelta?.ToString() ??
            ToolExecutionDone?.ToString() ??
            MessageOutputDelta?.ToString() ??
            FunctionCallDelta?.ToString() ??
            AgentHandoffStarted?.ToString() ??
            AgentHandoffDone?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConversationResponseStarted && !IsConversationResponseDone && !IsConversationResponseError && !IsToolExecutionStarted && !IsToolExecutionDelta && !IsToolExecutionDone && !IsMessageOutputDelta && !IsFunctionCallDelta && !IsAgentHandoffStarted && !IsAgentHandoffDone || !IsConversationResponseStarted && IsConversationResponseDone && !IsConversationResponseError && !IsToolExecutionStarted && !IsToolExecutionDelta && !IsToolExecutionDone && !IsMessageOutputDelta && !IsFunctionCallDelta && !IsAgentHandoffStarted && !IsAgentHandoffDone || !IsConversationResponseStarted && !IsConversationResponseDone && IsConversationResponseError && !IsToolExecutionStarted && !IsToolExecutionDelta && !IsToolExecutionDone && !IsMessageOutputDelta && !IsFunctionCallDelta && !IsAgentHandoffStarted && !IsAgentHandoffDone || !IsConversationResponseStarted && !IsConversationResponseDone && !IsConversationResponseError && IsToolExecutionStarted && !IsToolExecutionDelta && !IsToolExecutionDone && !IsMessageOutputDelta && !IsFunctionCallDelta && !IsAgentHandoffStarted && !IsAgentHandoffDone || !IsConversationResponseStarted && !IsConversationResponseDone && !IsConversationResponseError && !IsToolExecutionStarted && IsToolExecutionDelta && !IsToolExecutionDone && !IsMessageOutputDelta && !IsFunctionCallDelta && !IsAgentHandoffStarted && !IsAgentHandoffDone || !IsConversationResponseStarted && !IsConversationResponseDone && !IsConversationResponseError && !IsToolExecutionStarted && !IsToolExecutionDelta && IsToolExecutionDone && !IsMessageOutputDelta && !IsFunctionCallDelta && !IsAgentHandoffStarted && !IsAgentHandoffDone || !IsConversationResponseStarted && !IsConversationResponseDone && !IsConversationResponseError && !IsToolExecutionStarted && !IsToolExecutionDelta && !IsToolExecutionDone && IsMessageOutputDelta && !IsFunctionCallDelta && !IsAgentHandoffStarted && !IsAgentHandoffDone || !IsConversationResponseStarted && !IsConversationResponseDone && !IsConversationResponseError && !IsToolExecutionStarted && !IsToolExecutionDelta && !IsToolExecutionDone && !IsMessageOutputDelta && IsFunctionCallDelta && !IsAgentHandoffStarted && !IsAgentHandoffDone || !IsConversationResponseStarted && !IsConversationResponseDone && !IsConversationResponseError && !IsToolExecutionStarted && !IsToolExecutionDelta && !IsToolExecutionDone && !IsMessageOutputDelta && !IsFunctionCallDelta && IsAgentHandoffStarted && !IsAgentHandoffDone || !IsConversationResponseStarted && !IsConversationResponseDone && !IsConversationResponseError && !IsToolExecutionStarted && !IsToolExecutionDelta && !IsToolExecutionDone && !IsMessageOutputDelta && !IsFunctionCallDelta && !IsAgentHandoffStarted && IsAgentHandoffDone;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.ResponseStartedEvent?, TResult>? conversationResponseStarted = null,
            global::System.Func<global::Mistral.ResponseDoneEvent?, TResult>? conversationResponseDone = null,
            global::System.Func<global::Mistral.ResponseErrorEvent?, TResult>? conversationResponseError = null,
            global::System.Func<global::Mistral.ToolExecutionStartedEvent?, TResult>? toolExecutionStarted = null,
            global::System.Func<global::Mistral.ToolExecutionDeltaEvent?, TResult>? toolExecutionDelta = null,
            global::System.Func<global::Mistral.ToolExecutionDoneEvent?, TResult>? toolExecutionDone = null,
            global::System.Func<global::Mistral.MessageOutputEvent?, TResult>? messageOutputDelta = null,
            global::System.Func<global::Mistral.FunctionCallEvent?, TResult>? functionCallDelta = null,
            global::System.Func<global::Mistral.AgentHandoffStartedEvent?, TResult>? agentHandoffStarted = null,
            global::System.Func<global::Mistral.AgentHandoffDoneEvent?, TResult>? agentHandoffDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationResponseStarted && conversationResponseStarted != null)
            {
                return conversationResponseStarted(ConversationResponseStarted!);
            }
            else if (IsConversationResponseDone && conversationResponseDone != null)
            {
                return conversationResponseDone(ConversationResponseDone!);
            }
            else if (IsConversationResponseError && conversationResponseError != null)
            {
                return conversationResponseError(ConversationResponseError!);
            }
            else if (IsToolExecutionStarted && toolExecutionStarted != null)
            {
                return toolExecutionStarted(ToolExecutionStarted!);
            }
            else if (IsToolExecutionDelta && toolExecutionDelta != null)
            {
                return toolExecutionDelta(ToolExecutionDelta!);
            }
            else if (IsToolExecutionDone && toolExecutionDone != null)
            {
                return toolExecutionDone(ToolExecutionDone!);
            }
            else if (IsMessageOutputDelta && messageOutputDelta != null)
            {
                return messageOutputDelta(MessageOutputDelta!);
            }
            else if (IsFunctionCallDelta && functionCallDelta != null)
            {
                return functionCallDelta(FunctionCallDelta!);
            }
            else if (IsAgentHandoffStarted && agentHandoffStarted != null)
            {
                return agentHandoffStarted(AgentHandoffStarted!);
            }
            else if (IsAgentHandoffDone && agentHandoffDone != null)
            {
                return agentHandoffDone(AgentHandoffDone!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.ResponseStartedEvent?>? conversationResponseStarted = null,
            global::System.Action<global::Mistral.ResponseDoneEvent?>? conversationResponseDone = null,
            global::System.Action<global::Mistral.ResponseErrorEvent?>? conversationResponseError = null,
            global::System.Action<global::Mistral.ToolExecutionStartedEvent?>? toolExecutionStarted = null,
            global::System.Action<global::Mistral.ToolExecutionDeltaEvent?>? toolExecutionDelta = null,
            global::System.Action<global::Mistral.ToolExecutionDoneEvent?>? toolExecutionDone = null,
            global::System.Action<global::Mistral.MessageOutputEvent?>? messageOutputDelta = null,
            global::System.Action<global::Mistral.FunctionCallEvent?>? functionCallDelta = null,
            global::System.Action<global::Mistral.AgentHandoffStartedEvent?>? agentHandoffStarted = null,
            global::System.Action<global::Mistral.AgentHandoffDoneEvent?>? agentHandoffDone = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConversationResponseStarted)
            {
                conversationResponseStarted?.Invoke(ConversationResponseStarted!);
            }
            else if (IsConversationResponseDone)
            {
                conversationResponseDone?.Invoke(ConversationResponseDone!);
            }
            else if (IsConversationResponseError)
            {
                conversationResponseError?.Invoke(ConversationResponseError!);
            }
            else if (IsToolExecutionStarted)
            {
                toolExecutionStarted?.Invoke(ToolExecutionStarted!);
            }
            else if (IsToolExecutionDelta)
            {
                toolExecutionDelta?.Invoke(ToolExecutionDelta!);
            }
            else if (IsToolExecutionDone)
            {
                toolExecutionDone?.Invoke(ToolExecutionDone!);
            }
            else if (IsMessageOutputDelta)
            {
                messageOutputDelta?.Invoke(MessageOutputDelta!);
            }
            else if (IsFunctionCallDelta)
            {
                functionCallDelta?.Invoke(FunctionCallDelta!);
            }
            else if (IsAgentHandoffStarted)
            {
                agentHandoffStarted?.Invoke(AgentHandoffStarted!);
            }
            else if (IsAgentHandoffDone)
            {
                agentHandoffDone?.Invoke(AgentHandoffDone!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConversationResponseStarted,
                typeof(global::Mistral.ResponseStartedEvent),
                ConversationResponseDone,
                typeof(global::Mistral.ResponseDoneEvent),
                ConversationResponseError,
                typeof(global::Mistral.ResponseErrorEvent),
                ToolExecutionStarted,
                typeof(global::Mistral.ToolExecutionStartedEvent),
                ToolExecutionDelta,
                typeof(global::Mistral.ToolExecutionDeltaEvent),
                ToolExecutionDone,
                typeof(global::Mistral.ToolExecutionDoneEvent),
                MessageOutputDelta,
                typeof(global::Mistral.MessageOutputEvent),
                FunctionCallDelta,
                typeof(global::Mistral.FunctionCallEvent),
                AgentHandoffStarted,
                typeof(global::Mistral.AgentHandoffStartedEvent),
                AgentHandoffDone,
                typeof(global::Mistral.AgentHandoffDoneEvent),
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
        public bool Equals(Data other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ResponseStartedEvent?>.Default.Equals(ConversationResponseStarted, other.ConversationResponseStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ResponseDoneEvent?>.Default.Equals(ConversationResponseDone, other.ConversationResponseDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ResponseErrorEvent?>.Default.Equals(ConversationResponseError, other.ConversationResponseError) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ToolExecutionStartedEvent?>.Default.Equals(ToolExecutionStarted, other.ToolExecutionStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ToolExecutionDeltaEvent?>.Default.Equals(ToolExecutionDelta, other.ToolExecutionDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ToolExecutionDoneEvent?>.Default.Equals(ToolExecutionDone, other.ToolExecutionDone) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.MessageOutputEvent?>.Default.Equals(MessageOutputDelta, other.MessageOutputDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.FunctionCallEvent?>.Default.Equals(FunctionCallDelta, other.FunctionCallDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.AgentHandoffStartedEvent?>.Default.Equals(AgentHandoffStarted, other.AgentHandoffStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.AgentHandoffDoneEvent?>.Default.Equals(AgentHandoffDone, other.AgentHandoffDone) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Data obj1, Data obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Data>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Data obj1, Data obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Data o && Equals(o);
        }
    }
}
