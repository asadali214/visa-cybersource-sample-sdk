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
/// A void cancels a payment or capture. A transaction can be voided only when CyberSource has not already
/// submitted the capture to your processor. You cannot undo a void.
/// </summary>
public sealed class VoidApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal VoidApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// This is to void a previous payment, capture, refund, or credit that merchant does not receive a reply(Mostly due to timeout). To use this feature/API, make sure to pass unique value to field - clientReferenceInformation -&gt; transactionId in your payment, capture, refund, or credit API call and use same transactionId in this API request payload to reverse the payment.
    /// </summary>
    /// <param name="mitVoidRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MitVoidError"/> when the server returns an error response.</exception>
    public Task MitVoid(MitVoidRequest mitVoidRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/voids"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(mitVoidRequest),
            VoidResponse.Instance,
            MitVoidErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Refund a capture API is only used, if you have requested Capture independenlty using <see href="https://developer.cybersource.com/api-reference-assets/index.html#payments_capture">/pts/v2/payments/{id}/captures</see> API call. Include the capture ID in the POST request to cancel the capture.
    /// </summary>
    /// <param name="id">The capture ID returned from a previous capture request.</param>
    /// <param name="voidCaptureRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="VoidCaptureError"/> when the server returns an error response.</exception>
    public Task VoidCapture(string id,
        VoidCaptureRequest voidCaptureRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/captures/{id}/voids"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(voidCaptureRequest),
            VoidResponse.Instance,
            VoidCaptureErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Include the credit ID in the POST request to cancel the credit.
    /// </summary>
    /// <param name="id">The credit ID returned from a previous credit request.</param>
    /// <param name="voidCreditRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="VoidCreditError"/> when the server returns an error response.</exception>
    public Task VoidCredit(string id,
        VoidCreditRequest voidCreditRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/credits/{id}/voids"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(voidCreditRequest),
            VoidResponse.Instance,
            VoidCreditErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Void a Payment API is only used, if you have requested Authorization and Capture together in <see href="https://developer.cybersource.com/api-reference-assets/index.html#payments_payments">/pts/v2/payments</see> API call. Include the payment ID in the POST request to cancel the payment.
    /// </summary>
    /// <param name="id">The payment ID returned from a previous payment request.</param>
    /// <param name="voidPaymentRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="VoidPaymentError"/> when the server returns an error response.</exception>
    public Task VoidPayment(string id,
        VoidPaymentRequest voidPaymentRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/payments/{id}/voids"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(voidPaymentRequest),
            VoidResponse.Instance,
            VoidPaymentErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Include the refund ID in the POST request to cancel the refund.
    /// </summary>
    /// <param name="id">The refund ID returned from a previous refund request.</param>
    /// <param name="voidRefundRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="VoidRefundError"/> when the server returns an error response.</exception>
    public Task VoidRefund(string id,
        VoidRefundRequest voidRefundRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/refunds/{id}/voids"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(voidRefundRequest),
            VoidResponse.Instance,
            VoidRefundErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
