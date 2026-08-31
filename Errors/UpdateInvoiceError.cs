using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class UpdateInvoiceError : ApiError
{
    private readonly Optional<InvoicingV2InvoicesPut400Response1> _invoicingV2InvoicesPut400Response1Value;

    private readonly Optional<InvoicingV2InvoicesPut404Response1> _invoicingV2InvoicesPut404Response1Value;

    private readonly Optional<InvoicingV2InvoicesPut502Response1> _invoicingV2InvoicesPut502Response1Value;

    private UpdateInvoiceError(Optional<InvoicingV2InvoicesPut400Response1> invoicingV2InvoicesPut400Response1Value,
        Optional<InvoicingV2InvoicesPut404Response1> invoicingV2InvoicesPut404Response1Value,
        Optional<InvoicingV2InvoicesPut502Response1> invoicingV2InvoicesPut502Response1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _invoicingV2InvoicesPut400Response1Value = invoicingV2InvoicesPut400Response1Value;
        _invoicingV2InvoicesPut404Response1Value = invoicingV2InvoicesPut404Response1Value;
        _invoicingV2InvoicesPut502Response1Value = invoicingV2InvoicesPut502Response1Value;
    }

    private static UpdateInvoiceError AsInvoicingV2InvoicesPut400Response1(InvoicingV2InvoicesPut400Response1 value) =>
        new(Optional<InvoicingV2InvoicesPut400Response1>.Some(value), default, default, default);

    private static UpdateInvoiceError AsInvoicingV2InvoicesPut404Response1(InvoicingV2InvoicesPut404Response1 value) =>
        new(default, Optional<InvoicingV2InvoicesPut404Response1>.Some(value), default, default);

    private static UpdateInvoiceError AsInvoicingV2InvoicesPut502Response1(InvoicingV2InvoicesPut502Response1 value) =>
        new(default, default, Optional<InvoicingV2InvoicesPut502Response1>.Some(value), default);

    private static UpdateInvoiceError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetInvoicingV2InvoicesPut400Response1(out InvoicingV2InvoicesPut400Response1 value) =>
        _invoicingV2InvoicesPut400Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesPut404Response1(out InvoicingV2InvoicesPut404Response1 value) =>
        _invoicingV2InvoicesPut404Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesPut502Response1(out InvoicingV2InvoicesPut502Response1 value) =>
        _invoicingV2InvoicesPut502Response1Value.TryGetValue(out value);

    internal static Task<UpdateInvoiceError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<InvoicingV2InvoicesPut400Response1>(response, ct).As(AsInvoicingV2InvoicesPut400Response1),
            404 => FromJson<InvoicingV2InvoicesPut404Response1>(response, ct).As(AsInvoicingV2InvoicesPut404Response1),
            502 => FromJson<InvoicingV2InvoicesPut502Response1>(response, ct).As(AsInvoicingV2InvoicesPut502Response1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateInvoiceErrorResponse : IErrorResponse<UpdateInvoiceError>
{
    public static UpdateInvoiceErrorResponse Instance { get; } = new();

    private UpdateInvoiceErrorResponse()
    {
    }

    public Task<UpdateInvoiceError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateInvoiceError.Create(response, ct);
}
