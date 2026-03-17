
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetImportTasks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.PaginatedResultDatasetImportTask Tasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetImportTasks" /> class.
        /// </summary>
        /// <param name="tasks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetImportTasks(
            global::Mistral.PaginatedResultDatasetImportTask tasks)
        {
            this.Tasks = tasks ?? throw new global::System.ArgumentNullException(nameof(tasks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetImportTasks" /> class.
        /// </summary>
        public DatasetImportTasks()
        {
        }
    }
}