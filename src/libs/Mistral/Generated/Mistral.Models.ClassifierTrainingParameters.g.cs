
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifierTrainingParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("epochs")]
        public double? Epochs { get; set; }

        /// <summary>
        /// Default Value: 0.0001
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seq_len")]
        public int? SeqLen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_steps")]
        public int? TrainingSteps { get; set; }

        /// <summary>
        /// Default Value: 0.05
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warmup_fraction")]
        public double? WarmupFraction { get; set; }

        /// <summary>
        /// Default Value: 0.1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_decay")]
        public double? WeightDecay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierTrainingParameters" /> class.
        /// </summary>
        /// <param name="epochs"></param>
        /// <param name="learningRate">
        /// Default Value: 0.0001
        /// </param>
        /// <param name="seqLen"></param>
        /// <param name="trainingSteps"></param>
        /// <param name="warmupFraction">
        /// Default Value: 0.05
        /// </param>
        /// <param name="weightDecay">
        /// Default Value: 0.1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierTrainingParameters(
            double? epochs,
            double? learningRate,
            int? seqLen,
            int? trainingSteps,
            double? warmupFraction,
            double? weightDecay)
        {
            this.Epochs = epochs;
            this.LearningRate = learningRate;
            this.SeqLen = seqLen;
            this.TrainingSteps = trainingSteps;
            this.WarmupFraction = warmupFraction;
            this.WeightDecay = weightDecay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierTrainingParameters" /> class.
        /// </summary>
        public ClassifierTrainingParameters()
        {
        }
    }
}