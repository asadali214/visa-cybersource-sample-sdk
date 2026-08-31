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

/// <summary>
/// A credit is a stand-alone transaction that is not linked to any previous transactions. It takes money from
/// your merchant bank account and returns it to the customer.
/// </summary>
public sealed class Credit
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Credit(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// POST to the credit resource to credit funds to a specified credit card.
    /// </summary>
    /// <param name="createCreditRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateCreditError"/> when the server returns an error response.</exception>
    public Task CreateCredit(CreateCreditRequest createCreditRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/credits"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(createCreditRequest),
            VoidResponse.Instance,
            CreateCreditErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
