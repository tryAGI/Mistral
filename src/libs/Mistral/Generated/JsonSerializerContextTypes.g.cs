
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AgentsCompletionRequest? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.MessagesItem>? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.MessagesItem? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.SystemMessage? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.TextChunk>>? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.TextChunk>? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.TextChunk? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.TextChunkType? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.SystemMessageRole? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UserMessage? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ContentChunk>? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ContentChunk? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ImageURLChunk? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<global::Mistral.ImageURL, string>? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ImageURL? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ImageURLChunkType? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DocumentURLChunk? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DocumentURLChunkType? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ReferenceChunk? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ReferenceChunkType? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ContentChunkDiscriminator? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ContentChunkDiscriminatorType? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UserMessageRole? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AssistantMessage? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AssistantMessageRole? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ToolCall>? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ToolCall? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FunctionCall? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<object, string>? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ToolTypes? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ToolMessage? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ToolMessageRole? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AgentsCompletionRequestMessageDiscriminator? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AgentsCompletionRequestMessageDiscriminatorRole? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Prediction? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.PredictionType? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ResponseFormat? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ResponseFormats? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<global::Mistral.ToolChoice3, global::Mistral.ToolChoiceEnum?>? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ToolChoice3? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FunctionName? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ToolChoiceEnum? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.Tool>? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Tool? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Function? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ApiEndpoint? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ArchiveFTModelOut? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ArchiveFTModelOutObject? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BaseModelCard? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModelCapabilities? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BaseModelCardType? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchError? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchJobIn? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchJobOut? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.BatchError>? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchJobOutObject? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchJobStatus? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchJobsOut? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.BatchJobOut>? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchJobsOutObject? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatClassificationRequest? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatClassificationRequestInputs? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.InstructRequest? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.MessagesItem3>? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.MessagesItem3? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.InstructRequestMessageDiscriminator? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.InstructRequestMessageDiscriminatorRole? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.InstructRequest>? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionChoice? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionChoiceFinishReason? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionRequest? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.MessagesItem2>? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.MessagesItem2? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionRequestMessageDiscriminator? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionRequestMessageDiscriminatorRole? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionResponse? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionResponseBase? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ResponseBase? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UsageInfo? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionResponseBaseVariant2? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionResponseVariant2? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ChatCompletionChoice>? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatModerationRequest? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>>? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.InputVariant1Item? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminator? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.InputVariant2ItemItem? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminator? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CheckpointOut? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTimeOffset? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.MetricOut? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassificationRequest? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassificationResponse? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::Mistral.ClassificationTargetResult>>? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Mistral.ClassificationTargetResult>? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassificationTargetResult? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierDetailedJobOut? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.CheckpointOut>? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ClassifierTargetOut>? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierTargetOut? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTClassifierLossFunction? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.EventOut>? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EventOut? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierTrainingParameters? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.IntegrationsItem>? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.IntegrationsItem? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.WandbIntegrationOut? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.WandbIntegrationOutType? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierDetailedJobOutIntegrationDiscriminator? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierDetailedJobOutIntegrationDiscriminatorType? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierDetailedJobOutJobType? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FineTuneableModel? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierDetailedJobOutObject? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierDetailedJobOutStatus? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierFTModelOut? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTModelCapabilitiesOut? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierFTModelOutModelType? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierFTModelOutObject? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierJobOut? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.IntegrationsItem2>? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.IntegrationsItem2? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierJobOutIntegrationDiscriminator? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierJobOutIntegrationDiscriminatorType? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierJobOutJobType? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierJobOutObject? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierJobOutStatus? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierTargetIn? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassifierTrainingParametersIn? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionChunk? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.CompletionResponseStreamChoice>? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionResponseStreamChoice? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DeltaMessage? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionResponseStreamChoiceFinishReason? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionDetailedJobOut? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionTrainingParameters? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.IntegrationsItem3>? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.IntegrationsItem3? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionDetailedJobOutIntegrationDiscriminator? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionDetailedJobOutIntegrationDiscriminatorType? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionDetailedJobOutJobType? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionDetailedJobOutObject? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem>? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RepositoriesItem? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.GithubRepositoryOut? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.GithubRepositoryOutType? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionDetailedJobOutRepositorieDiscriminator? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionDetailedJobOutStatus? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionEvent? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionFTModelOut? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionFTModelOutModelType? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionFTModelOutObject? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionJobOut? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.IntegrationsItem4>? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.IntegrationsItem4? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionJobOutIntegrationDiscriminator? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionJobOutIntegrationDiscriminatorType? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionJobOutJobType? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionJobOutObject? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem2>? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RepositoriesItem2? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionJobOutRepositorieDiscriminator? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionJobOutRepositorieDiscriminatorType? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionJobOutStatus? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionTrainingParametersIn? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DeleteFileOut? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DeleteModelOut? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EmbeddingRequest? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EmbeddingResponse? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EmbeddingResponseVariant2? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.EmbeddingResponseData>? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EmbeddingResponseData? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FIMCompletionRequest? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FIMCompletionResponse? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FIMCompletionResponseVariant2? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTModelCard? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTModelCardType? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FilePurpose? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FileSchema? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.SampleType? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Source? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FileSignedURL? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FineTuneableModelType? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.GithubRepositoryIn? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.GithubRepositoryInType? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.HTTPValidationError? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ValidationError>? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ValidationError? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.AnyOf<string, int?>>? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<string, int?>? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobIn? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ClassifierTargetIn>? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<global::Mistral.CompletionTrainingParametersIn, global::Mistral.ClassifierTrainingParametersIn>? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.IntegrationsItem5>? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.IntegrationsItem5? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.WandbIntegration? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.WandbIntegrationType? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInIntegrationDiscriminator? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInIntegrationDiscriminatorType? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem3>? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RepositoriesItem3? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInRepositorieDiscriminator? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInRepositorieDiscriminatorType? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.TrainingFile>? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.TrainingFile? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobMetadataOut? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsOut? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.DataItem>? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DataItem? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsOutDataItemDiscriminator? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsOutDataItemDiscriminatorJobType? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsOutObject? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JsonSchema? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.LegacyJobMetadataOut? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.LegacyJobMetadataOutObject? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ListFilesOut? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.FileSchema>? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModelList? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.DataItem2>? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DataItem2? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModelListDataItemDiscriminator? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModelListDataItemDiscriminatorType? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModerationObject? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModerationResponse? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ModerationObject>? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRImageObject? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRPageDimensions? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRPageObject? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.OCRImageObject>? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRRequest? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk>? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRResponse? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.OCRPageObject>? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRUsageInfo? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RetrieveFileOut? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UnarchiveFTModelOut? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UnarchiveFTModelOutObject? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UpdateFTModelIn? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UploadFileOut? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FilesApiRoutesUploadFileRequest? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.BatchJobStatus>? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.SampleType>? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.Source>? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?, global::Mistral.LegacyJobMetadataOut>? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1Discriminator? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponse? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminator? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponse? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminator? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponse? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminator? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponse? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminator? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RetrieveModelV1ModelsModelIdGetResponse? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminator? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType? Type284 { get; set; }
    }
}