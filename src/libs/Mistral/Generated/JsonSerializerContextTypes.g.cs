
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
        public global::Mistral.ChatCompletionChoice? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionChoiceFinishReason? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionRequest? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.MessagesItem2>? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.MessagesItem2? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionRequestMessageDiscriminator? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionRequestMessageDiscriminatorRole? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionResponse? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionResponseBase? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ResponseBase? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UsageInfo? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionResponseBaseVariant2? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatCompletionResponseVariant2? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ChatCompletionChoice>? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatModerationRequest? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>>? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.InputVariant1Item? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminator? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.InputVariant2ItemItem? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminator? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CheckpointOut? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTimeOffset? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.MetricOut? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassificationObject? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, bool>? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassificationRequest? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ClassificationResponse? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ClassificationObject>? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionChunk? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.CompletionResponseStreamChoice>? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionResponseStreamChoice? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DeltaMessage? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionResponseStreamChoiceFinishReason? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.CompletionEvent? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DeleteFileOut? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DeleteModelOut? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOut? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.CheckpointOut>? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.EventOut>? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EventOut? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.TrainingParameters? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.IntegrationsItem>? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.IntegrationsItem? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.WandbIntegrationOut? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.WandbIntegrationOutType? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOutIntegrationDiscriminator? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOutIntegrationDiscriminatorType? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FineTuneableModel? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOutObject? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem>? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RepositoriesItem? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.GithubRepositoryOut? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.GithubRepositoryOutType? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOutRepositorieDiscriminator? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOutRepositorieDiscriminatorType? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DetailedJobOutStatus? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EmbeddingRequest? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EmbeddingResponse? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EmbeddingResponseVariant2? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.EmbeddingResponseData>? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.EmbeddingResponseData? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FIMCompletionRequest? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FIMCompletionResponse? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FIMCompletionResponseVariant2? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTModelCapabilitiesOut? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTModelCard? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTModelCardType? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTModelOut? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FTModelOutObject? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FilePurpose? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FileSchema? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.SampleType? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.Source? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FileSignedURL? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.GithubRepositoryIn? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.GithubRepositoryInType? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.HTTPValidationError? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.ValidationError>? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ValidationError? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.AnyOf<string, int?>>? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<string, int?>? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobIn? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.TrainingParametersIn? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.IntegrationsItem2>? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.IntegrationsItem2? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.WandbIntegration? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.WandbIntegrationType? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInIntegrationDiscriminator? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInIntegrationDiscriminatorType? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem2>? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RepositoriesItem2? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInRepositorieDiscriminator? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobInRepositorieDiscriminatorType? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.TrainingFile>? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.TrainingFile? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobMetadataOut? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOut? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.IntegrationsItem3>? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.IntegrationsItem3? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOutIntegrationDiscriminator? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOutIntegrationDiscriminatorType? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOutObject? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem3>? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RepositoriesItem3? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOutRepositorieDiscriminator? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOutRepositorieDiscriminatorType? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobOutStatus? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsOut? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.JobOut>? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsOutObject? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JsonSchema? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.LegacyJobMetadataOut? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.LegacyJobMetadataOutObject? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ListFilesOut? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.FileSchema>? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModelList? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.DataItem>? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.DataItem? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModelListDataItemDiscriminator? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.ModelListDataItemDiscriminatorType? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRImageObject? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRPageDimensions? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRPageObject? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.OCRImageObject>? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRRequest? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk>? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRResponse? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.OCRPageObject>? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.OCRUsageInfo? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RetrieveFileOut? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UnarchiveFTModelOut? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UnarchiveFTModelOutObject? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UpdateFTModelIn? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.UploadFileOut? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.FilesApiRoutesUploadFileRequest? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.SampleType>? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Mistral.Source>? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.AnyOf<global::Mistral.JobOut, global::Mistral.LegacyJobMetadataOut>? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RetrieveModelV1ModelsModelIdGetResponse? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminator? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Mistral.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType? Type222 { get; set; }
    }
}