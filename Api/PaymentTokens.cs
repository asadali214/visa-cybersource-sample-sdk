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
/// A payment-tokens is a service that is used for retrieving vault details or deleting vault id/payment method.
/// </summary>
public sealed class PaymentTokens
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal PaymentTokens(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// This API can be used in two flavours - for retrieval or deletion of vault id.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RetrieveOrDeletePaymentTokenError"/> when the server returns an error response.</exception>
    public Task RetrieveOrDeletePaymentToken(RequestModel request,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/payment-tokens"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request),
            VoidResponse.Instance,
            RetrieveOrDeletePaymentTokenErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
