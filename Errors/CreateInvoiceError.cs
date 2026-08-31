using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class CreateInvoiceError : ApiError
{
    private readonly Optional<InvoicingV2InvoicesPost400Response1> _invoicingV2InvoicesPost400Response1Value;

    private readonly Optional<InvoicingV2InvoicesPost404Response1> _invoicingV2InvoicesPost404Response1Value;

    private readonly Optional<InvoicingV2InvoicesPost502Response1> _invoicingV2InvoicesPost502Response1Value;

    private CreateInvoiceError(Optional<InvoicingV2InvoicesPost400Response1> invoicingV2InvoicesPost400Response1Value,
        Optional<InvoicingV2InvoicesPost404Response1> invoicingV2InvoicesPost404Response1Value,
        Optional<InvoicingV2InvoicesPost502Response1> invoicingV2InvoicesPost502Response1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _invoicingV2InvoicesPost400Response1Value = invoicingV2InvoicesPost400Response1Value;
        _invoicingV2InvoicesPost404Response1Value = invoicingV2InvoicesPost404Response1Value;
        _invoicingV2InvoicesPost502Response1Value = invoicingV2InvoicesPost502Response1Value;
    }

    private static CreateInvoiceError AsInvoicingV2InvoicesPost400Response1(InvoicingV2InvoicesPost400Response1 value) =>
        new(Optional<InvoicingV2InvoicesPost400Response1>.Some(value), default, default, default);

    private static CreateInvoiceError AsInvoicingV2InvoicesPost404Response1(InvoicingV2InvoicesPost404Response1 value) =>
        new(default, Optional<InvoicingV2InvoicesPost404Response1>.Some(value), default, default);

    private static CreateInvoiceError AsInvoicingV2InvoicesPost502Response1(InvoicingV2InvoicesPost502Response1 value) =>
        new(default, default, Optional<InvoicingV2InvoicesPost502Response1>.Some(value), default);

    private static CreateInvoiceError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetInvoicingV2InvoicesPost400Response1(out InvoicingV2InvoicesPost400Response1 value) =>
        _invoicingV2InvoicesPost400Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesPost404Response1(out InvoicingV2InvoicesPost404Response1 value) =>
        _invoicingV2InvoicesPost404Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesPost502Response1(out InvoicingV2InvoicesPost502Response1 value) =>
        _invoicingV2InvoicesPost502Response1Value.TryGetValue(out value);

    internal static Task<CreateInvoiceError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<InvoicingV2InvoicesPost400Response1>(response, ct).As(AsInvoicingV2InvoicesPost400Response1),
            404 => FromJson<InvoicingV2InvoicesPost404Response1>(response, ct).As(AsInvoicingV2InvoicesPost404Response1),
            502 => FromJson<InvoicingV2InvoicesPost502Response1>(response, ct).As(AsInvoicingV2InvoicesPost502Response1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateInvoiceErrorResponse : IErrorResponse<CreateInvoiceError>
{
    public static CreateInvoiceErrorResponse Instance { get; } = new();

    private CreateInvoiceErrorResponse()
    {
    }

    public Task<CreateInvoiceError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateInvoiceError.Create(response, ct);
}
