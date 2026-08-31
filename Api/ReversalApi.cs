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
/// An authorization reversal releases the hold that the payment placed on the customer’s funds.
/// </summary>
public sealed class ReversalApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal ReversalApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Include the payment ID in the POST request to reverse the payment amount.
    /// </summary>
    /// <param name="id">The payment ID returned from a previous payment request.</param>
    /// <param name="authReversalRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="AuthReversalError"/> when the server returns an error response.</exception>
    public Task AuthReversal(string id,
        AuthReversalRequest authReversalRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/payments/{id}/reversals"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(authReversalRequest),
            VoidResponse.Instance,
            AuthReversalErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// This is to reverse a previous payment that merchant does not receive a reply(Mostly due to Timeout). To use this feature/API, make sure to pass unique value to field - clientReferenceInformation -&gt; transactionId in <see href="https://developer.cybersource.com/api-reference-assets/index.html#payments_payments">/pts/v2/payments</see> API call and use same transactionId in this API request payload to reverse the payment.
    /// </summary>
    /// <param name="mitReversalRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MitReversalError"/> when the server returns an error response.</exception>
    public Task MitReversal(MitReversalRequest mitReversalRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/reversals"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(mitReversalRequest),
            VoidResponse.Instance,
            MitReversalErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
