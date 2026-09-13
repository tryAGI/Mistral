
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Mistral
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FineTuneableModelType), TypeInfoPropertyName = "FineTuneableModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOutStatus), TypeInfoPropertyName = "ClassifierJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item), TypeInfoPropertyName = "IntegrationsVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WandbIntegrationOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobMetadataOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierTrainingParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutStatus), TypeInfoPropertyName = "CompletionJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item2), TypeInfoPropertyName = "IntegrationsVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "CompletionJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionTrainingParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesItem), TypeInfoPropertyName = "RepositoriesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GithubRepositoryOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutRepositorieDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutRepositorieDiscriminatorType), TypeInfoPropertyName = "CompletionJobOutRepositorieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DataItem2), TypeInfoPropertyName = "DataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsOutDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsOutDataItemDiscriminatorJobType), TypeInfoPropertyName = "JobsOutDataItemDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.LegacyJobMetadataOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierTargetIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FTClassifierLossFunction), TypeInfoPropertyName = "FTClassifierLossFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierTrainingParametersIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionTrainingParametersIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.GithubRepositoryIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobIn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.TrainingFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.TrainingFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item3), TypeInfoPropertyName = "IntegrationsVariant1Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.WandbIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "JobInIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.CompletionTrainingParametersIn, global::Mistral.ClassifierTrainingParametersIn>), TypeInfoPropertyName = "AnyOfCompletionTrainingParametersInClassifierTrainingParametersIn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.RepositoriesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesVariant1Item), TypeInfoPropertyName = "RepositoriesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType), TypeInfoPropertyName = "JobInRepositoriesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ClassifierTargetIn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CheckpointOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.MetricOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOutStatus), TypeInfoPropertyName = "ClassifierDetailedJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item4), TypeInfoPropertyName = "IntegrationsVariant1Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.EventOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.EventOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.CheckpointOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.ClassifierTargetOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierTargetOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutStatus), TypeInfoPropertyName = "CompletionDetailedJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item5), TypeInfoPropertyName = "IntegrationsVariant1Item52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesItem2), TypeInfoPropertyName = "RepositoriesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType), TypeInfoPropertyName = "CompletionDetailedJobOutRepositorieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus), TypeInfoPropertyName = "JobsApiRoutesFineTuningGetFineTuningJobsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?, global::Mistral.LegacyJobMetadataOut>), TypeInfoPropertyName = "AnyOfJobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1LegacyJobMetadataOut2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1), TypeInfoPropertyName = "JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType), TypeInfoPropertyName = "JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponse), TypeInfoPropertyName = "JobsApiRoutesFineTuningGetFineTuningJobResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType), TypeInfoPropertyName = "JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponse), TypeInfoPropertyName = "JobsApiRoutesFineTuningCancelFineTuningJobResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType), TypeInfoPropertyName = "JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponse), TypeInfoPropertyName = "JobsApiRoutesFineTuningStartFineTuningJobResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType), TypeInfoPropertyName = "JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FineTuneableModelType?), TypeInfoPropertyName = "NullableFineTuneableModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOutStatus?), TypeInfoPropertyName = "NullableClassifierJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item?), TypeInfoPropertyName = "NullableIntegrationsVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableClassifierJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutStatus?), TypeInfoPropertyName = "NullableCompletionJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item2?), TypeInfoPropertyName = "NullableIntegrationsVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableCompletionJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesItem?), TypeInfoPropertyName = "NullableRepositoriesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionJobOutRepositorieDiscriminatorType?), TypeInfoPropertyName = "NullableCompletionJobOutRepositorieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.DataItem2?), TypeInfoPropertyName = "NullableDataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsOutDataItemDiscriminatorJobType?), TypeInfoPropertyName = "NullableJobsOutDataItemDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.FTClassifierLossFunction?), TypeInfoPropertyName = "NullableFTClassifierLossFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item3?), TypeInfoPropertyName = "NullableIntegrationsVariant1Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableJobInIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.CompletionTrainingParametersIn, global::Mistral.ClassifierTrainingParametersIn>?), TypeInfoPropertyName = "NullableAnyOfCompletionTrainingParametersInClassifierTrainingParametersIn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesVariant1Item?), TypeInfoPropertyName = "NullableRepositoriesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableJobInRepositoriesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOutStatus?), TypeInfoPropertyName = "NullableClassifierDetailedJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item4?), TypeInfoPropertyName = "NullableIntegrationsVariant1Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutStatus?), TypeInfoPropertyName = "NullableCompletionDetailedJobOutStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.IntegrationsVariant1Item5?), TypeInfoPropertyName = "NullableIntegrationsVariant1Item52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableCompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.RepositoriesItem2?), TypeInfoPropertyName = "NullableRepositoriesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType?), TypeInfoPropertyName = "NullableCompletionDetailedJobOutRepositorieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningGetFineTuningJobsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.AnyOf<global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?, global::Mistral.LegacyJobMetadataOut>?), TypeInfoPropertyName = "NullableAnyOfJobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1LegacyJobMetadataOut2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningCreateFineTuningJobResponseVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponse?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningGetFineTuningJobResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponse?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningCancelFineTuningJobResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponse?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningStartFineTuningJobResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType?), TypeInfoPropertyName = "NullableJobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.IntegrationsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.IntegrationsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.RepositoriesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.TrainingFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.IntegrationsVariant1Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.RepositoriesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ClassifierTargetIn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.IntegrationsVariant1Item4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.EventOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.CheckpointOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.ClassifierTargetOut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.IntegrationsVariant1Item5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mistral.RepositoriesItem2>))]
    internal sealed partial class DeprecatedFineTuningSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeprecatedFineTuningSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DeprecatedFineTuningSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DeprecatedFineTuningSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Mistral.JsonConverters.IntegrationsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.IntegrationsVariant1Item2JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.RepositoriesItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.DataItem2JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.IntegrationsVariant1Item3JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.RepositoriesVariant1ItemJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.IntegrationsVariant1Item4JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.IntegrationsVariant1Item5JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.RepositoriesItem2JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1JsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCancelFineTuningJobResponseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseJsonConverter());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, int?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.CompletionTrainingParametersIn, global::Mistral.ClassifierTrainingParametersIn>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, byte[]>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<object, string>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<int>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, string, int?, double?, global::System.DateTime?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<bool>>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<bool?, int?, double?, string, global::System.DateTime?, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, bool?, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1?, global::Mistral.LegacyJobMetadataOut>());
            options.Converters.Add(new global::Mistral.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Mistral.FineTuneableModelType)

                    || typeToConvert == typeof(global::Mistral.FineTuneableModelType?)

                    || typeToConvert == typeof(global::Mistral.ClassifierJobOutStatus)

                    || typeToConvert == typeof(global::Mistral.ClassifierJobOutStatus?)

                    || typeToConvert == typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.CompletionJobOutStatus)

                    || typeToConvert == typeof(global::Mistral.CompletionJobOutStatus?)

                    || typeToConvert == typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.CompletionJobOutRepositorieDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.CompletionJobOutRepositorieDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.JobsOutDataItemDiscriminatorJobType)

                    || typeToConvert == typeof(global::Mistral.JobsOutDataItemDiscriminatorJobType?)

                    || typeToConvert == typeof(global::Mistral.FTClassifierLossFunction)

                    || typeToConvert == typeof(global::Mistral.FTClassifierLossFunction?)

                    || typeToConvert == typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutStatus)

                    || typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutStatus?)

                    || typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutStatus)

                    || typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutStatus?)

                    || typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType)

                    || typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType?)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus?)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType?)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType?)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType?)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType)

                    || typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Mistral.FineTuneableModelType))
                {
                    return new global::Mistral.JsonConverters.FineTuneableModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FineTuneableModelType?))
                {
                    return new global::Mistral.JsonConverters.FineTuneableModelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierJobOutStatus))
                {
                    return new global::Mistral.JsonConverters.ClassifierJobOutStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierJobOutStatus?))
                {
                    return new global::Mistral.JsonConverters.ClassifierJobOutStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.ClassifierJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionJobOutStatus))
                {
                    return new global::Mistral.JsonConverters.CompletionJobOutStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionJobOutStatus?))
                {
                    return new global::Mistral.JsonConverters.CompletionJobOutStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.CompletionJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionJobOutIntegrationsVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.CompletionJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionJobOutRepositorieDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.CompletionJobOutRepositorieDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionJobOutRepositorieDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.CompletionJobOutRepositorieDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsOutDataItemDiscriminatorJobType))
                {
                    return new global::Mistral.JsonConverters.JobsOutDataItemDiscriminatorJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsOutDataItemDiscriminatorJobType?))
                {
                    return new global::Mistral.JsonConverters.JobsOutDataItemDiscriminatorJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FTClassifierLossFunction))
                {
                    return new global::Mistral.JsonConverters.FTClassifierLossFunctionJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.FTClassifierLossFunction?))
                {
                    return new global::Mistral.JsonConverters.FTClassifierLossFunctionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.JobInIntegrationsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobInIntegrationsVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.JobInIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.JobInRepositoriesVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobInRepositoriesVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.JobInRepositoriesVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutStatus))
                {
                    return new global::Mistral.JsonConverters.ClassifierDetailedJobOutStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutStatus?))
                {
                    return new global::Mistral.JsonConverters.ClassifierDetailedJobOutStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.ClassifierDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutStatus))
                {
                    return new global::Mistral.JsonConverters.CompletionDetailedJobOutStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutStatus?))
                {
                    return new global::Mistral.JsonConverters.CompletionDetailedJobOutStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.CompletionDetailedJobOutIntegrationsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType))
                {
                    return new global::Mistral.JsonConverters.CompletionDetailedJobOutRepositorieDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.CompletionDetailedJobOutRepositorieDiscriminatorType?))
                {
                    return new global::Mistral.JsonConverters.CompletionDetailedJobOutRepositorieDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus?))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType?))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType?))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType?))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobType?))
                {
                    return new global::Mistral.JsonConverters.JobsApiRoutesFineTuningStartFineTuningJobResponseDiscriminatorJobTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new DeprecatedFineTuningSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}