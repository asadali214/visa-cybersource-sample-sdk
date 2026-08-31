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
/// A refund is a follow-on transaction that uses the ID returned from either a payment or capture request.
/// </summary>
public sealed class RefundApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal RefundApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Refund a capture API is only used, if you have requested Capture independenlty using <see href="https://developer.cybersource.com/api-reference-assets/index.html#payments_capture">/pts/v2/payments/{id}/captures</see> API call. Include the capture ID in the POST request to refund the captured amount.
    /// </summary>
    /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
    /// <param name="refundCaptureRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RefundCaptureError"/> when the server returns an error response.</exception>
    public Task RefundCapture(string id,
        RefundCaptureRequest refundCaptureRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/captures/{id}/refunds"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(refundCaptureRequest),
            VoidResponse.Instance,
            RefundCaptureErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Refund a Payment API is only used, if you have requested Authorization and Capture together in <see href="https://developer.cybersource.com/api-reference-assets/index.html#payments_payments">/pts/v2/payments</see> API call. Include the payment ID in the POST request to refund the payment amount.
    /// </summary>
    /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
    /// <param name="refundPaymentRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RefundPaymentError"/> when the server returns an error response.</exception>
    public Task RefundPayment(string id,
        RefundPaymentRequest refundPaymentRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/payments/{id}/refunds"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(refundPaymentRequest),
            VoidResponse.Instance,
            RefundPaymentErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
