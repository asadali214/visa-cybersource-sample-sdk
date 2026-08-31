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
using CyberSourceMergedSpec.Models.Enums;

namespace CyberSourceMergedSpec.Api;

/// <summary>
/// Update the settings for the invoice payment page.
/// </summary>
public sealed class InvoiceSettings
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal InvoiceSettings(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Allows you to retrieve the invoice settings for the payment page.
    /// </summary>
    /// <param name="productType">Allows you to choose which product type settings you want to update.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicingV2InvoiceSettingsGet200Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetInvoiceSettingsError"/> when the server returns an error response.</exception>
    public Task<InvoicingV2InvoiceSettingsGet200Response> GetInvoiceSettings(ProductType? productType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invoicing/v2/invoiceSettings"),
            [],
            [new Param("productType", productType)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<InvoicingV2InvoiceSettingsGet200Response>(),
            GetInvoiceSettingsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Allows you to customize the payment page, the checkout experience, email communication and payer authentication. You can customize the invoice to match your brand with your business name, logo and brand colors, and a VAT Tax number. You can choose to capture the payers shipping details, phone number and email during the checkout process. You can add a custom message to all invoice emails and enable or disable payer authentication for invoice payments.
    /// </summary>
    /// <param name="productType">Allows you to choose which product type settings you want to update.</param>
    /// <param name="invoiceSettingsRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvoicingV2InvoiceSettingsPut200Response"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateInvoiceSettingsError"/> when the server returns an error response.</exception>
    public Task<InvoicingV2InvoiceSettingsPut200Response> UpdateInvoiceSettings(ProductType? productType,
        InvoiceSettingsRequest invoiceSettingsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invoicing/v2/invoiceSettings"),
            [],
            [new Param("productType", productType)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(invoiceSettingsRequest),
            JsonResponse.Create<InvoicingV2InvoiceSettingsPut200Response>(),
            UpdateInvoiceSettingsErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
