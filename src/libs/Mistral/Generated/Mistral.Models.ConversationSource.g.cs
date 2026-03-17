
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
        Explorer,
        /// <summary>
        /// 
        /// </summary>
        UploadedFile,
        /// <summary>
        /// 
        /// </summary>
        DirectInput,
        /// <summary>
        /// 
        /// </summary>
        Playground,
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
                ConversationSource.Explorer => "EXPLORER",
                ConversationSource.UploadedFile => "UPLOADED_FILE",
                ConversationSource.DirectInput => "DIRECT_INPUT",
                ConversationSource.Playground => "PLAYGROUND",
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
                "EXPLORER" => ConversationSource.Explorer,
                "UPLOADED_FILE" => ConversationSource.UploadedFile,
                "DIRECT_INPUT" => ConversationSource.DirectInput,
                "PLAYGROUND" => ConversationSource.Playground,
                _ => null,
            };
        }
    }
}