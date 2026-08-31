using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core;
using CyberSourceMergedSpec.Core.Exceptions;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Request;
using CyberSourceMergedSpec.Core.Response;
using CyberSourceMergedSpec.Errors;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Api;

public sealed class SearchTransactions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal SearchTransactions(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Create a search request.
    /// </summary>
    /// <param name="createSearchRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TssV2TransactionsPost201Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateSearchError"/> when the server returns an error response.</exception>
    public Task<TssV2TransactionsPost201Response> CreateSearch(CreateSearchRequest createSearchRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tss/v2/searches"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(createSearchRequest),
            JsonResponse.Create<TssV2TransactionsPost201Response>(),
            CreateSearchErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Include the Search ID in the GET request to retrieve the search results.
    /// </summary>
    /// <param name="searchId">Search ID.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetSearchError"/> when the server returns an error response.</exception>
    public Task GetSearch(string searchId, RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tss/v2/searches/{searchId}"),
            [new TemplateParam("searchId", searchId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetSearchErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
