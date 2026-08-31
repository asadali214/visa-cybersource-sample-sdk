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
/// Offer your customers a simple, convenient, and fast way to pay with the new online invoicing tool.
/// </summary>
public sealed class Invoices
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Invoices(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// The invoicing product enables you to bill any customer with an email address and accept digital payments securely from any connected device. You can either use the system generated email or use the invoice payment link in your own communication. You can add discounts and taxes for the entire invoice or for each line item. To customize the invoice to match your brand see <see href="https://developer.cybersource.com/api-reference-assets/index.html#invoicing_invoice-settings_update-invoice-settings">Invoice Settings</see>. The invoice payment page uses Unified Checkout to process the payments.
    /// The availability of API features for a merchant can depend on the portfolio configuration and may need to be enabled at the portfolio level before they can be added to merchant accounts.
    /// </summary>
    /// <param name="createInvoiceRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicingV2InvoicesPost201Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateInvoiceError"/> when the server returns an error response.</exception>
    public Task<InvoicingV2InvoicesPost201Response> CreateInvoice(CreateInvoiceRequest createInvoiceRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invoicing/v2/invoices"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(createInvoiceRequest),
            JsonResponse.Create<InvoicingV2InvoicesPost201Response>(),
            CreateInvoiceErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Provides a (filtered) list of invoices that have been created in your account. You can filter the list based on Invoice Status by setting the status query parameter to one of DRAFT, CREATED, SENT, PARTIAL, PAID or CANCELED.
    /// </summary>
    /// <param name="offset">Page offset number.</param>
    /// <param name="limit">Maximum number of items you would like returned.</param>
    /// <param name="status">The status of the invoice.  Possible values:   - DRAFT   - CREATED   - SENT   - PARTIAL   - PAID   - CANCELED</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicingV2InvoicesAllGet200Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAllInvoicesError"/> when the server returns an error response.</exception>
    public Task<InvoicingV2InvoicesAllGet200Response> GetAllInvoices(int offset,
        int limit,
        string? status,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invoicing/v2/invoices"),
            [],
            [new Param("offset", offset), new Param("limit", limit), new Param("status", status)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<InvoicingV2InvoicesAllGet200Response>(),
            GetAllInvoicesErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// You can retrieve details of a specific invoice. This can be used to check the Invoice status and get a list of invoice payments in the invoice history section of the response. For each payment transaction you can use the Transaction Details API to get more details on the payment transaction.
    /// </summary>
    /// <param name="id">The invoice number.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicingV2InvoicesGet200Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetInvoiceError"/> when the server returns an error response.</exception>
    public Task<InvoicingV2InvoicesGet200Response> GetInvoice(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invoicing/v2/invoices/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<InvoicingV2InvoicesGet200Response>(),
            GetInvoiceErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// You can cancel an invoice if no payment is made to it. You cannot cancel partially or fully paid invoices.
    /// </summary>
    /// <param name="id">The invoice number.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicingV2InvoicesCancel200Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PerformCancelActionError"/> when the server returns an error response.</exception>
    public Task<InvoicingV2InvoicesCancel200Response> PerformCancelAction(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invoicing/v2/invoices/{id}/cancelation"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(new { }),
            JsonResponse.Create<InvoicingV2InvoicesCancel200Response>(),
            PerformCancelActionErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// You can publish an invoice in DRAFT status. After invoking this method, the invoice status is changed to CREATED.
    /// </summary>
    /// <param name="id">The invoice number.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicingV2InvoicesPublish200Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PerformPublishActionError"/> when the server returns an error response.</exception>
    public Task<InvoicingV2InvoicesPublish200Response> PerformPublishAction(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invoicing/v2/invoices/{id}/publication"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(new { }),
            JsonResponse.Create<InvoicingV2InvoicesPublish200Response>(),
            PerformPublishActionErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// You can send an invoice in draft or created state or resend a sent or partially paid invoice. Fully paid or canceled invoices cannot be resent.
    /// </summary>
    /// <param name="id">The invoice number.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicingV2InvoicesSend200Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PerformSendActionError"/> when the server returns an error response.</exception>
    public Task<InvoicingV2InvoicesSend200Response> PerformSendAction(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invoicing/v2/invoices/{id}/delivery"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(new { }),
            JsonResponse.Create<InvoicingV2InvoicesSend200Response>(),
            PerformSendActionErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// You can update all information except the invoice number till any payment is received for an invoice. Invoices that are partially or fully paid or cancelled cannot be updated.
    /// </summary>
    /// <param name="id">The invoice number.</param>
    /// <param name="updateInvoiceRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicingV2InvoicesPut200Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateInvoiceError"/> when the server returns an error response.</exception>
    public Task<InvoicingV2InvoicesPut200Response> UpdateInvoice(string id,
        UpdateInvoiceRequest updateInvoiceRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invoicing/v2/invoices/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(updateInvoiceRequest),
            JsonResponse.Create<InvoicingV2InvoicesPut200Response>(),
            UpdateInvoiceErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
