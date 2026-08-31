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
/// When you are ready to fulfill a customer’s order and transfer funds from the customer’s
/// bank to your bank, capture the payment for that order.
/// </summary>
public sealed class CaptureApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal CaptureApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Include the payment ID in the POST request to capture the payment amount.
    /// </summary>
    /// <param name="id">The payment ID returned from a previous payment request. This ID links the capture to the payment.</param>
    /// <param name="capturePaymentRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CapturePaymentError"/> when the server returns an error response.</exception>
    public Task CapturePayment(string id,
        CapturePaymentRequest capturePaymentRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/payments/{id}/captures"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(capturePaymentRequest),
            VoidResponse.Instance,
            CapturePaymentErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
