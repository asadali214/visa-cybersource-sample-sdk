using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetInvoiceError : ApiError
{
    private readonly Optional<InvoicingV2InvoicesGet400Response1> _invoicingV2InvoicesGet400Response1Value;

    private readonly Optional<InvoicingV2InvoicesGet404Response1> _invoicingV2InvoicesGet404Response1Value;

    private readonly Optional<InvoicingV2InvoicesGet502Response1> _invoicingV2InvoicesGet502Response1Value;

    private GetInvoiceError(Optional<InvoicingV2InvoicesGet400Response1> invoicingV2InvoicesGet400Response1Value,
        Optional<InvoicingV2InvoicesGet404Response1> invoicingV2InvoicesGet404Response1Value,
        Optional<InvoicingV2InvoicesGet502Response1> invoicingV2InvoicesGet502Response1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _invoicingV2InvoicesGet400Response1Value = invoicingV2InvoicesGet400Response1Value;
        _invoicingV2InvoicesGet404Response1Value = invoicingV2InvoicesGet404Response1Value;
        _invoicingV2InvoicesGet502Response1Value = invoicingV2InvoicesGet502Response1Value;
    }

    private static GetInvoiceError AsInvoicingV2InvoicesGet400Response1(InvoicingV2InvoicesGet400Response1 value) =>
        new(Optional<InvoicingV2InvoicesGet400Response1>.Some(value), default, default, default);

    private static GetInvoiceError AsInvoicingV2InvoicesGet404Response1(InvoicingV2InvoicesGet404Response1 value) =>
        new(default, Optional<InvoicingV2InvoicesGet404Response1>.Some(value), default, default);

    private static GetInvoiceError AsInvoicingV2InvoicesGet502Response1(InvoicingV2InvoicesGet502Response1 value) =>
        new(default, default, Optional<InvoicingV2InvoicesGet502Response1>.Some(value), default);

    private static GetInvoiceError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetInvoicingV2InvoicesGet400Response1(out InvoicingV2InvoicesGet400Response1 value) =>
        _invoicingV2InvoicesGet400Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesGet404Response1(out InvoicingV2InvoicesGet404Response1 value) =>
        _invoicingV2InvoicesGet404Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesGet502Response1(out InvoicingV2InvoicesGet502Response1 value) =>
        _invoicingV2InvoicesGet502Response1Value.TryGetValue(out value);

    internal static Task<GetInvoiceError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<InvoicingV2InvoicesGet400Response1>(response, ct).As(AsInvoicingV2InvoicesGet400Response1),
            404 => FromJson<InvoicingV2InvoicesGet404Response1>(response, ct).As(AsInvoicingV2InvoicesGet404Response1),
            502 => FromJson<InvoicingV2InvoicesGet502Response1>(response, ct).As(AsInvoicingV2InvoicesGet502Response1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetInvoiceErrorResponse : IErrorResponse<GetInvoiceError>
{
    public static GetInvoiceErrorResponse Instance { get; } = new();

    private GetInvoiceErrorResponse()
    {
    }

    public Task<GetInvoiceError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetInvoiceError.Create(response, ct);
}
