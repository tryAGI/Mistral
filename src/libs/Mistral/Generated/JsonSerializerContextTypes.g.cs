
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
        public global::Mistral.ReferenceChunk? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ReferenceChunkType? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ContentChunkDiscriminator? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ContentChunkDiscriminatorType? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UserMessageRole? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AssistantMessage? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AssistantMessageRole? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ToolCall>? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ToolCall? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FunctionCall? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<object, string>? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ToolTypes? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ToolMessage? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ToolMessageRole? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AgentsCompletionRequestMessageDiscriminator? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AgentsCompletionRequestMessageDiscriminatorRole? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Prediction? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.PredictionType? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ResponseFormat? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ResponseFormats? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<global::Mistral.ToolChoice3, global::Mistral.ToolChoiceEnum?>? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ToolChoice3? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FunctionName? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ToolChoiceEnum? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.Tool>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Tool? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Function? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ApiEndpoint? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ArchiveFTModelOut? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ArchiveFTModelOutObject? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BaseModelCard? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModelCapabilities? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BaseModelCardType? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchError? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchJobIn? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchJobOut? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.BatchError>? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchJobOutObject? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchJobStatus? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchJobsOut? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.BatchJobOut>? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.BatchJobsOutObject? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatClassificationRequest? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>>? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.InputVariant1Item? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminator? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatClassificationRequestInputVariant1ItemDiscriminatorRole? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.InputVariant2ItemItem? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatClassificationRequestInputVariant2ItemItemDiscriminator? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionChoice? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionChoiceFinishReason? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionRequest? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.MessagesItem2>? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.MessagesItem2? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionRequestMessageDiscriminator? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionRequestMessageDiscriminatorRole? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionResponse? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionResponseBase? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ResponseBase? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UsageInfo? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionResponseBaseVariant2? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionResponseVariant2? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ChatCompletionChoice>? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CheckpointOut? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTimeOffset? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.MetricOut? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassificationObject? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassificationRequest? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassificationResponse? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ClassificationObject>? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionChunk? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.CompletionResponseStreamChoice>? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionResponseStreamChoice? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DeltaMessage? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionResponseStreamChoiceFinishReason? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionEvent? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DeleteFileOut? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DeleteModelOut? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOut? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.CheckpointOut>? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.EventOut>? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EventOut? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.TrainingParameters? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.IntegrationsItem>? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.IntegrationsItem? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.WandbIntegrationOut? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.WandbIntegrationOutType? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOutIntegrationDiscriminator? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOutIntegrationDiscriminatorType? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FineTuneableModel? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOutObject? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem>? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RepositoriesItem? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.GithubRepositoryOut? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.GithubRepositoryOutType? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOutRepositorieDiscriminator? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOutRepositorieDiscriminatorType? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOutStatus? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EmbeddingRequest? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EmbeddingResponse? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EmbeddingResponseVariant2? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.EmbeddingResponseData>? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EmbeddingResponseData? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FIMCompletionRequest? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FIMCompletionResponse? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FIMCompletionResponseVariant2? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTModelCapabilitiesOut? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTModelCard? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTModelCardType? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTModelOut? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTModelOutObject? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FilePurpose? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FileSchema? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.SampleType? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Source? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FileSignedURL? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.GithubRepositoryIn? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.GithubRepositoryInType? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.HTTPValidationError? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ValidationError>? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ValidationError? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.AnyOf<string, int?>>? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<string, int?>? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobIn? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.TrainingParametersIn? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.IntegrationsItem2>? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.IntegrationsItem2? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.WandbIntegration? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.WandbIntegrationType? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInIntegrationDiscriminator? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInIntegrationDiscriminatorType? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem2>? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RepositoriesItem2? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInRepositorieDiscriminator? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInRepositorieDiscriminatorType? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.TrainingFile>? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.TrainingFile? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobMetadataOut? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOut? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.IntegrationsItem3>? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.IntegrationsItem3? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOutIntegrationDiscriminator? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOutIntegrationDiscriminatorType? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOutObject? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem3>? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RepositoriesItem3? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOutRepositorieDiscriminator? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOutRepositorieDiscriminatorType? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOutStatus? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsOut? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.JobOut>? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsOutObject? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.LegacyJobMetadataOut? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.LegacyJobMetadataOutObject? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ListFilesOut? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.FileSchema>? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModelList? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.DataItem>? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DataItem? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModelListDataItemDiscriminator? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModelListDataItemDiscriminatorType? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RetrieveFileOut? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UnarchiveFTModelOut? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UnarchiveFTModelOutObject? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UpdateFTModelIn? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UploadFileOut? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FilesApiRoutesUploadFileRequest? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.SampleType>? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.Source>? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<global::Mistral.JobOut, global::Mistral.LegacyJobMetadataOut>? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RetrieveModelV1ModelsModelIdGetResponse? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminator? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType? Type210 { get; set; }
    }
}