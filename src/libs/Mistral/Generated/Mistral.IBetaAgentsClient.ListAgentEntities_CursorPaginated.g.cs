#nullable enable

namespace Mistral
{
    public partial interface IBetaAgentsClient
    {
        /// <summary>
        /// List agent entities, cursor-paginated.<br/>
        /// Retrieve a page of agent entities. Unlike the deprecated `GET /v1/agents`, this endpoint paginates by opaque cursor and honors per-agent sharing, returning only agents the caller is authorized to see.
        /// </summary>
        /// <param name="pageSize">
        /// Number of agents per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="deploymentChat"></param>
        /// <param name="sources"></param>
        /// <param name="name">
        /// Filter by agent name
        /// </param>
        /// <param name="search">
        /// Search agents by name or ID
        /// </param>
        /// <param name="id"></param>
        /// <param name="pageToken">
        /// Opaque cursor from a previous response's next_page_token. When set, results page forward from the cursor.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AgentListPage> ListAgentEntities_CursorPaginatedAsync(
            int? pageSize = default,
            bool? deploymentChat = default,
            global::System.Collections.Generic.IList<global::Mistral.RequestSource>? sources = default,
            string? name = default,
            string? search = default,
            string? id = default,
            string? pageToken = default,
            object? metadata = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List agent entities, cursor-paginated.<br/>
        /// Retrieve a page of agent entities. Unlike the deprecated `GET /v1/agents`, this endpoint paginates by opaque cursor and honors per-agent sharing, returning only agents the caller is authorized to see.
        /// </summary>
        /// <param name="pageSize">
        /// Number of agents per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="deploymentChat"></param>
        /// <param name="sources"></param>
        /// <param name="name">
        /// Filter by agent name
        /// </param>
        /// <param name="search">
        /// Search agents by name or ID
        /// </param>
        /// <param name="id"></param>
        /// <param name="pageToken">
        /// Opaque cursor from a previous response's next_page_token. When set, results page forward from the cursor.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AutoSDKHttpResponse<global::Mistral.AgentListPage>> ListAgentEntities_CursorPaginatedAsResponseAsync(
            int? pageSize = default,
            bool? deploymentChat = default,
            global::System.Collections.Generic.IList<global::Mistral.RequestSource>? sources = default,
            string? name = default,
            string? search = default,
            string? id = default,
            string? pageToken = default,
            object? metadata = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAgentEntities_CursorPaginatedAsync as an IAsyncEnumerable&lt;global::Mistral.Agent&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// Number of agents per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="deploymentChat"></param>
        /// <param name="sources"></param>
        /// <param name="name">
        /// Filter by agent name
        /// </param>
        /// <param name="search">
        /// Search agents by name or ID
        /// </param>
        /// <param name="id"></param>
        /// <param name="metadata"></param> 
        /// <param name="pageToken">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.Agent> ListAgentEntities_CursorPaginatedAutoPagingAsync(
              int? pageSize = default,
            bool? deploymentChat = default,
            global::System.Collections.Generic.IList<global::Mistral.RequestSource>? sources = default,
            string? name = default,
            string? search = default,
            string? id = default,
            object? metadata = default,
            string? pageToken = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}