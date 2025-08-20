
#nullable enable

namespace Mistral
{
    /// <summary>
    /// The name of the model to fine-tune.
    /// </summary>
    public enum FineTuneableModel
    {
        /// <summary>
        /// 
        /// </summary>
        Ministral3bLatest,
        /// <summary>
        /// 
        /// </summary>
        Ministral8bLatest,
        /// <summary>
        /// 
        /// </summary>
        OpenMistral7b,
        /// <summary>
        /// 
        /// </summary>
        OpenMistralNemo,
        /// <summary>
        /// 
        /// </summary>
        MistralSmallLatest,
        /// <summary>
        /// 
        /// </summary>
        MistralMediumLatest,
        /// <summary>
        /// 
        /// </summary>
        MistralLargeLatest,
        /// <summary>
        /// 
        /// </summary>
        Pixtral12bLatest,
        /// <summary>
        /// 
        /// </summary>
        CodestralLatest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneableModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneableModel value)
        {
            return value switch
            {
                FineTuneableModel.Ministral3bLatest => "ministral-3b-latest",
                FineTuneableModel.Ministral8bLatest => "ministral-8b-latest",
                FineTuneableModel.OpenMistral7b => "open-mistral-7b",
                FineTuneableModel.OpenMistralNemo => "open-mistral-nemo",
                FineTuneableModel.MistralSmallLatest => "mistral-small-latest",
                FineTuneableModel.MistralMediumLatest => "mistral-medium-latest",
                FineTuneableModel.MistralLargeLatest => "mistral-large-latest",
                FineTuneableModel.Pixtral12bLatest => "pixtral-12b-latest",
                FineTuneableModel.CodestralLatest => "codestral-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneableModel? ToEnum(string value)
        {
            return value switch
            {
                "ministral-3b-latest" => FineTuneableModel.Ministral3bLatest,
                "ministral-8b-latest" => FineTuneableModel.Ministral8bLatest,
                "open-mistral-7b" => FineTuneableModel.OpenMistral7b,
                "open-mistral-nemo" => FineTuneableModel.OpenMistralNemo,
                "mistral-small-latest" => FineTuneableModel.MistralSmallLatest,
                "mistral-medium-latest" => FineTuneableModel.MistralMediumLatest,
                "mistral-large-latest" => FineTuneableModel.MistralLargeLatest,
                "pixtral-12b-latest" => FineTuneableModel.Pixtral12bLatest,
                "codestral-latest" => FineTuneableModel.CodestralLatest,
                _ => null,
            };
        }
    }
}