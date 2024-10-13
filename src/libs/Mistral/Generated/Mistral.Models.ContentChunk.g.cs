using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentChunk : global::System.IEquatable<ContentChunk>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.TextChunk? Text { get; init; }
#else
        public global::Mistral.TextChunk? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentChunk(global::Mistral.TextChunk value) => new ContentChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.TextChunk?(ContentChunk @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(global::Mistral.TextChunk? value)
        {
            Text = value;
        }

        /// <summary>
        /// {"type":"image_url","image_url":{"url":"data:image/png;base64,iVBORw0
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mistral.ImageURLChunk? ImageURL { get; init; }
#else
        public global::Mistral.ImageURLChunk? ImageURL { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageURL))]
#endif
        public bool IsImageURL => ImageURL != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentChunk(global::Mistral.ImageURLChunk value) => new ContentChunk(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mistral.ImageURLChunk?(ContentChunk @this) => @this.ImageURL;

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(global::Mistral.ImageURLChunk? value)
        {
            ImageURL = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentChunk(
            global::Mistral.TextChunk? text,
            global::Mistral.ImageURLChunk? imageURL
            )
        {
            Text = text;
            ImageURL = imageURL;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageURL as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageURL || !IsText && IsImageURL;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mistral.TextChunk?, TResult>? text = null,
            global::System.Func<global::Mistral.ImageURLChunk?, TResult>? imageURL = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImageURL && imageURL != null)
            {
                return imageURL(ImageURL!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mistral.TextChunk?>? text = null,
            global::System.Action<global::Mistral.ImageURLChunk?>? imageURL = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageURL)
            {
                imageURL?.Invoke(ImageURL!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Mistral.TextChunk),
                ImageURL,
                typeof(global::Mistral.ImageURLChunk),
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
        public bool Equals(ContentChunk other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mistral.TextChunk?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Mistral.ImageURLChunk?>.Default.Equals(ImageURL, other.ImageURL) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentChunk obj1, ContentChunk obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentChunk>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentChunk obj1, ContentChunk obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentChunk o && Equals(o);
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
        public static global::Mistral.ContentChunk? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Mistral.ContentChunk),
                jsonSerializerContext) as global::Mistral.ContentChunk?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Mistral.ContentChunk? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Mistral.ContentChunk>(
                json,
                jsonSerializerOptions);
        }

    }
}
