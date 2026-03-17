#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem4 : global::System.IEquatable<ToolsItem4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModelConversationToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.FunctionTool? Function { get; init; }
#else
        public global::Mistral.FunctionTool? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.WebSearchTool? WebSearch { get; init; }
#else
        public global::Mistral.WebSearchTool? WebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.WebSearchPremiumTool? WebSearchPremium { get; init; }
#else
        public global::Mistral.WebSearchPremiumTool? WebSearchPremium { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchPremium))]
#endif
        public bool IsWebSearchPremium => WebSearchPremium != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.CodeInterpreterTool? CodeInterpreter { get; init; }
#else
        public global::Mistral.CodeInterpreterTool? CodeInterpreter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreter))]
#endif
        public bool IsCodeInterpreter => CodeInterpreter != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ImageGenerationTool? ImageGeneration { get; init; }
#else
        public global::Mistral.ImageGenerationTool? ImageGeneration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGeneration))]
#endif
        public bool IsImageGeneration => ImageGeneration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.DocumentLibraryTool? DocumentLibrary { get; init; }
#else
        public global::Mistral.DocumentLibraryTool? DocumentLibrary { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentLibrary))]
#endif
        public bool IsDocumentLibrary => DocumentLibrary != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.CustomConnector? Connector { get; init; }
#else
        public global::Mistral.CustomConnector? Connector { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Connector))]
#endif
        public bool IsConnector => Connector != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::Mistral.FunctionTool value) => new ToolsItem4((global::Mistral.FunctionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.FunctionTool?(ToolsItem4 @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::Mistral.FunctionTool? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::Mistral.WebSearchTool value) => new ToolsItem4((global::Mistral.WebSearchTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.WebSearchTool?(ToolsItem4 @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::Mistral.WebSearchTool? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::Mistral.WebSearchPremiumTool value) => new ToolsItem4((global::Mistral.WebSearchPremiumTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.WebSearchPremiumTool?(ToolsItem4 @this) => @this.WebSearchPremium;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::Mistral.WebSearchPremiumTool? value)
        {
            WebSearchPremium = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::Mistral.CodeInterpreterTool value) => new ToolsItem4((global::Mistral.CodeInterpreterTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.CodeInterpreterTool?(ToolsItem4 @this) => @this.CodeInterpreter;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::Mistral.CodeInterpreterTool? value)
        {
            CodeInterpreter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::Mistral.ImageGenerationTool value) => new ToolsItem4((global::Mistral.ImageGenerationTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ImageGenerationTool?(ToolsItem4 @this) => @this.ImageGeneration;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::Mistral.ImageGenerationTool? value)
        {
            ImageGeneration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::Mistral.DocumentLibraryTool value) => new ToolsItem4((global::Mistral.DocumentLibraryTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.DocumentLibraryTool?(ToolsItem4 @this) => @this.DocumentLibrary;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::Mistral.DocumentLibraryTool? value)
        {
            DocumentLibrary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::Mistral.CustomConnector value) => new ToolsItem4((global::Mistral.CustomConnector?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.CustomConnector?(ToolsItem4 @this) => @this.Connector;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::Mistral.CustomConnector? value)
        {
            Connector = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(
            global::Mistral.ModelConversationToolDiscriminatorType? type,
            global::Mistral.FunctionTool? function,
            global::Mistral.WebSearchTool? webSearch,
            global::Mistral.WebSearchPremiumTool? webSearchPremium,
            global::Mistral.CodeInterpreterTool? codeInterpreter,
            global::Mistral.ImageGenerationTool? imageGeneration,
            global::Mistral.DocumentLibraryTool? documentLibrary,
            global::Mistral.CustomConnector? connector
            )
        {
            Type = type;

            Function = function;
            WebSearch = webSearch;
            WebSearchPremium = webSearchPremium;
            CodeInterpreter = codeInterpreter;
            ImageGeneration = imageGeneration;
            DocumentLibrary = documentLibrary;
            Connector = connector;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Connector as object ??
            DocumentLibrary as object ??
            ImageGeneration as object ??
            CodeInterpreter as object ??
            WebSearchPremium as object ??
            WebSearch as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            WebSearch?.ToString() ??
            WebSearchPremium?.ToString() ??
            CodeInterpreter?.ToString() ??
            ImageGeneration?.ToString() ??
            DocumentLibrary?.ToString() ??
            Connector?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsWebSearch && !IsWebSearchPremium && !IsCodeInterpreter && !IsImageGeneration && !IsDocumentLibrary && !IsConnector || !IsFunction && IsWebSearch && !IsWebSearchPremium && !IsCodeInterpreter && !IsImageGeneration && !IsDocumentLibrary && !IsConnector || !IsFunction && !IsWebSearch && IsWebSearchPremium && !IsCodeInterpreter && !IsImageGeneration && !IsDocumentLibrary && !IsConnector || !IsFunction && !IsWebSearch && !IsWebSearchPremium && IsCodeInterpreter && !IsImageGeneration && !IsDocumentLibrary && !IsConnector || !IsFunction && !IsWebSearch && !IsWebSearchPremium && !IsCodeInterpreter && IsImageGeneration && !IsDocumentLibrary && !IsConnector || !IsFunction && !IsWebSearch && !IsWebSearchPremium && !IsCodeInterpreter && !IsImageGeneration && IsDocumentLibrary && !IsConnector || !IsFunction && !IsWebSearch && !IsWebSearchPremium && !IsCodeInterpreter && !IsImageGeneration && !IsDocumentLibrary && IsConnector;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.FunctionTool?, TResult>? function = null,
            global::System.Func<global::Mistral.WebSearchTool?, TResult>? webSearch = null,
            global::System.Func<global::Mistral.WebSearchPremiumTool?, TResult>? webSearchPremium = null,
            global::System.Func<global::Mistral.CodeInterpreterTool?, TResult>? codeInterpreter = null,
            global::System.Func<global::Mistral.ImageGenerationTool?, TResult>? imageGeneration = null,
            global::System.Func<global::Mistral.DocumentLibraryTool?, TResult>? documentLibrary = null,
            global::System.Func<global::Mistral.CustomConnector?, TResult>? connector = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }
            else if (IsWebSearchPremium && webSearchPremium != null)
            {
                return webSearchPremium(WebSearchPremium!);
            }
            else if (IsCodeInterpreter && codeInterpreter != null)
            {
                return codeInterpreter(CodeInterpreter!);
            }
            else if (IsImageGeneration && imageGeneration != null)
            {
                return imageGeneration(ImageGeneration!);
            }
            else if (IsDocumentLibrary && documentLibrary != null)
            {
                return documentLibrary(DocumentLibrary!);
            }
            else if (IsConnector && connector != null)
            {
                return connector(Connector!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.FunctionTool?>? function = null,
            global::System.Action<global::Mistral.WebSearchTool?>? webSearch = null,
            global::System.Action<global::Mistral.WebSearchPremiumTool?>? webSearchPremium = null,
            global::System.Action<global::Mistral.CodeInterpreterTool?>? codeInterpreter = null,
            global::System.Action<global::Mistral.ImageGenerationTool?>? imageGeneration = null,
            global::System.Action<global::Mistral.DocumentLibraryTool?>? documentLibrary = null,
            global::System.Action<global::Mistral.CustomConnector?>? connector = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
            else if (IsWebSearchPremium)
            {
                webSearchPremium?.Invoke(WebSearchPremium!);
            }
            else if (IsCodeInterpreter)
            {
                codeInterpreter?.Invoke(CodeInterpreter!);
            }
            else if (IsImageGeneration)
            {
                imageGeneration?.Invoke(ImageGeneration!);
            }
            else if (IsDocumentLibrary)
            {
                documentLibrary?.Invoke(DocumentLibrary!);
            }
            else if (IsConnector)
            {
                connector?.Invoke(Connector!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::Mistral.FunctionTool),
                WebSearch,
                typeof(global::Mistral.WebSearchTool),
                WebSearchPremium,
                typeof(global::Mistral.WebSearchPremiumTool),
                CodeInterpreter,
                typeof(global::Mistral.CodeInterpreterTool),
                ImageGeneration,
                typeof(global::Mistral.ImageGenerationTool),
                DocumentLibrary,
                typeof(global::Mistral.DocumentLibraryTool),
                Connector,
                typeof(global::Mistral.CustomConnector),
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
        public bool Equals(ToolsItem4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.FunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.WebSearchTool?>.Default.Equals(WebSearch, other.WebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.WebSearchPremiumTool?>.Default.Equals(WebSearchPremium, other.WebSearchPremium) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.CodeInterpreterTool?>.Default.Equals(CodeInterpreter, other.CodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ImageGenerationTool?>.Default.Equals(ImageGeneration, other.ImageGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.DocumentLibraryTool?>.Default.Equals(DocumentLibrary, other.DocumentLibrary) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.CustomConnector?>.Default.Equals(Connector, other.Connector) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem4 obj1, ToolsItem4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem4 obj1, ToolsItem4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem4 o && Equals(o);
        }
    }
}
