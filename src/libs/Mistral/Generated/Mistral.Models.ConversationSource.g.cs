
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationSource
    {
        /// <summary>
        /// 
        /// </summary>
        DirectInput,
        /// <summary>
        /// 
        /// </summary>
        Explorer,
        /// <summary>
        /// 
        /// </summary>
        Playground,
        /// <summary>
        /// 
        /// </summary>
        UploadedFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationSource value)
        {
            return value switch
            {
                ConversationSource.DirectInput => "DIRECT_INPUT",
                ConversationSource.Explorer => "EXPLORER",
                ConversationSource.Playground => "PLAYGROUND",
                ConversationSource.UploadedFile => "UPLOADED_FILE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationSource? ToEnum(string value)
        {
            return value switch
            {
                "DIRECT_INPUT" => ConversationSource.DirectInput,
                "EXPLORER" => ConversationSource.Explorer,
                "PLAYGROUND" => ConversationSource.Playground,
                "UPLOADED_FILE" => ConversationSource.UploadedFile,
                _ => null,
            };
        }
    }
}