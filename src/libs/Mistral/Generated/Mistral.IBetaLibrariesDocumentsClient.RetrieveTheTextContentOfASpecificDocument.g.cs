#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesDocumentsClient
    {
        /// <summary>
        /// Retrieve the text content of a specific document.<br/>
        /// Given a library and a document in that library, you can retrieve the text content of that document if it exists. For documents like pdf, docx and pptx the text content results from our processing using Mistral OCR.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DocumentTextContent> RetrieveTheTextContentOfASpecificDocumentAsync(
            global::System.Guid libraryId,
            global::System.Guid documentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}