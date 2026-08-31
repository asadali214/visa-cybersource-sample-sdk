using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetAllInvoicesError : ApiError
{
    private readonly Optional<InvoicingV2InvoicesAllGet400Response1> _invoicingV2InvoicesAllGet400Response1Value;

    private readonly Optional<InvoicingV2InvoicesAllGet404Response1> _invoicingV2InvoicesAllGet404Response1Value;

    private readonly Optional<InvoicingV2InvoicesAllGet502Response1> _invoicingV2InvoicesAllGet502Response1Value;

    private GetAllInvoicesError(Optional<InvoicingV2InvoicesAllGet400Response1> invoicingV2InvoicesAllGet400Response1Value,
        Optional<InvoicingV2InvoicesAllGet404Response1> invoicingV2InvoicesAllGet404Response1Value,
        Optional<InvoicingV2InvoicesAllGet502Response1> invoicingV2InvoicesAllGet502Response1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _invoicingV2InvoicesAllGet400Response1Value = invoicingV2InvoicesAllGet400Response1Value;
        _invoicingV2InvoicesAllGet404Response1Value = invoicingV2InvoicesAllGet404Response1Value;
        _invoicingV2InvoicesAllGet502Response1Value = invoicingV2InvoicesAllGet502Response1Value;
    }

    private static GetAllInvoicesError AsInvoicingV2InvoicesAllGet400Response1(InvoicingV2InvoicesAllGet400Response1 value) =>
        new(Optional<InvoicingV2InvoicesAllGet400Response1>.Some(value), default, default, default);

    private static GetAllInvoicesError AsInvoicingV2InvoicesAllGet404Response1(InvoicingV2InvoicesAllGet404Response1 value) =>
        new(default, Optional<InvoicingV2InvoicesAllGet404Response1>.Some(value), default, default);

    private static GetAllInvoicesError AsInvoicingV2InvoicesAllGet502Response1(InvoicingV2InvoicesAllGet502Response1 value) =>
        new(default, default, Optional<InvoicingV2InvoicesAllGet502Response1>.Some(value), default);

    private static GetAllInvoicesError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetInvoicingV2InvoicesAllGet400Response1(out InvoicingV2InvoicesAllGet400Response1 value) =>
        _invoicingV2InvoicesAllGet400Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesAllGet404Response1(out InvoicingV2InvoicesAllGet404Response1 value) =>
        _invoicingV2InvoicesAllGet404Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesAllGet502Response1(out InvoicingV2InvoicesAllGet502Response1 value) =>
        _invoicingV2InvoicesAllGet502Response1Value.TryGetValue(out value);

    internal static Task<GetAllInvoicesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<InvoicingV2InvoicesAllGet400Response1>(response, ct).As(AsInvoicingV2InvoicesAllGet400Response1),
            404 => FromJson<InvoicingV2InvoicesAllGet404Response1>(response, ct).As(AsInvoicingV2InvoicesAllGet404Response1),
            502 => FromJson<InvoicingV2InvoicesAllGet502Response1>(response, ct).As(AsInvoicingV2InvoicesAllGet502Response1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAllInvoicesErrorResponse : IErrorResponse<GetAllInvoicesError>
{
    public static GetAllInvoicesErrorResponse Instance { get; } = new();

    private GetAllInvoicesErrorResponse()
    {
    }

    public Task<GetAllInvoicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAllInvoicesError.Create(response, ct);
}
