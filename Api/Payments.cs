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
/// A payment authorizes the amount for the transaction. There are a number of supported payment
/// instruments, such as Credit Card, Debit Card, e-Wallet, and Alternative Payments. A payment
/// response includes the status of the request. It also includes processor-specific information
/// when the request is successful and errors if unsuccessful.
/// </summary>
public sealed class Payments
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Payments(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Create a Payment Order Request
    /// </summary>
    /// <param name="id">Request identifier number for the order request.</param>
    /// <param name="orderPaymentRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateOrderRequestError"/> when the server returns an error response.</exception>
    public Task CreateOrderRequest(string id,
        OrderPaymentRequest orderPaymentRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/payment-references/{id}/intents"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(orderPaymentRequest),
            VoidResponse.Instance,
            CreateOrderRequestErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// A payment authorizes the amount for the transaction. There are a number of supported payment features, such as E-commerce and Card Present - Credit Card/Debit Card, Echeck, e-Wallets, Level II/III Data, etc..
    /// <para>
    /// A payment response includes the status of the request. It also includes processor-specific information when the request is successful and errors if unsuccessful. See the <see href="https://developer.cybersource.com/docs/cybs/en-us/payments/developer/ctv/rest/payments/payments-intro.html">Payments Developer Guides Page</see>.
    /// </para>
    /// <para>
    /// Authorization can be requested with Capture, Decision Manager, Payer Authentication(3ds), and Token Creation.
    /// </para>
    /// </summary>
    /// <param name="createPaymentRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreatePaymentError"/> when the server returns an error response.</exception>
    public Task CreatePayment(CreatePaymentRequest createPaymentRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/payments"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(createPaymentRequest),
            VoidResponse.Instance,
            CreatePaymentErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Create Alternative Payments Sessions Request
    /// </summary>
    /// <param name="createSessionReq"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateSessionRequestError"/> when the server returns an error response.</exception>
    public Task CreateSessionRequest(CreateSessionReq createSessionReq,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/payment-references"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(createSessionReq),
            VoidResponse.Instance,
            CreateSessionRequestErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Use this service to authorize additional charges in a lodging or autorental transaction. Include the ID returned from the original authorization in the PATCH request to add additional charges to that authorization.
    /// </summary>
    /// <param name="id">The ID returned from the original authorization request.</param>
    /// <param name="incrementAuthRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="IncrementAuthError"/> when the server returns an error response.</exception>
    public Task IncrementAuth(string id,
        IncrementAuthRequest incrementAuthRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/payments/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(incrementAuthRequest),
            VoidResponse.Instance,
            IncrementAuthErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Checks and updates the payment status
    /// </summary>
    /// <param name="id">The payment id whose status needs to be checked and updated.</param>
    /// <param name="refreshPaymentStatusRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RefreshPaymentStatusError"/> when the server returns an error response.</exception>
    public Task RefreshPaymentStatus(string id,
        RefreshPaymentStatusRequest refreshPaymentStatusRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/refresh-payment-status/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(refreshPaymentStatusRequest),
            VoidResponse.Instance,
            RefreshPaymentStatusErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Update Alternative Payments Sessions Request
    /// </summary>
    /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
    /// <param name="createSessionRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateSessionRequestError"/> when the server returns an error response.</exception>
    public Task UpdateSessionRequest(string id,
        CreateSessionRequest createSessionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/payment-references/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(createSessionRequest),
            VoidResponse.Instance,
            UpdateSessionRequestErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
