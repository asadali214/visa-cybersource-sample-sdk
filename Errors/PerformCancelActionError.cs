using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PerformCancelActionError : ApiError
{
    private readonly Optional<InvoicingV2InvoicesCancel400Response1> _invoicingV2InvoicesCancel400Response1Value;

    private readonly Optional<InvoicingV2InvoicesCancel404Response1> _invoicingV2InvoicesCancel404Response1Value;

    private readonly Optional<InvoicingV2InvoicesCancel502Response1> _invoicingV2InvoicesCancel502Response1Value;

    private PerformCancelActionError(Optional<InvoicingV2InvoicesCancel400Response1> invoicingV2InvoicesCancel400Response1Value,
        Optional<InvoicingV2InvoicesCancel404Response1> invoicingV2InvoicesCancel404Response1Value,
        Optional<InvoicingV2InvoicesCancel502Response1> invoicingV2InvoicesCancel502Response1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _invoicingV2InvoicesCancel400Response1Value = invoicingV2InvoicesCancel400Response1Value;
        _invoicingV2InvoicesCancel404Response1Value = invoicingV2InvoicesCancel404Response1Value;
        _invoicingV2InvoicesCancel502Response1Value = invoicingV2InvoicesCancel502Response1Value;
    }

    private static PerformCancelActionError AsInvoicingV2InvoicesCancel400Response1(InvoicingV2InvoicesCancel400Response1 value) =>
        new(Optional<InvoicingV2InvoicesCancel400Response1>.Some(value), default, default, default);

    private static PerformCancelActionError AsInvoicingV2InvoicesCancel404Response1(InvoicingV2InvoicesCancel404Response1 value) =>
        new(default, Optional<InvoicingV2InvoicesCancel404Response1>.Some(value), default, default);

    private static PerformCancelActionError AsInvoicingV2InvoicesCancel502Response1(InvoicingV2InvoicesCancel502Response1 value) =>
        new(default, default, Optional<InvoicingV2InvoicesCancel502Response1>.Some(value), default);

    private static PerformCancelActionError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetInvoicingV2InvoicesCancel400Response1(out InvoicingV2InvoicesCancel400Response1 value) =>
        _invoicingV2InvoicesCancel400Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesCancel404Response1(out InvoicingV2InvoicesCancel404Response1 value) =>
        _invoicingV2InvoicesCancel404Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesCancel502Response1(out InvoicingV2InvoicesCancel502Response1 value) =>
        _invoicingV2InvoicesCancel502Response1Value.TryGetValue(out value);

    internal static Task<PerformCancelActionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<InvoicingV2InvoicesCancel400Response1>(response, ct).As(AsInvoicingV2InvoicesCancel400Response1),
            404 => FromJson<InvoicingV2InvoicesCancel404Response1>(response, ct).As(AsInvoicingV2InvoicesCancel404Response1),
            502 => FromJson<InvoicingV2InvoicesCancel502Response1>(response, ct).As(AsInvoicingV2InvoicesCancel502Response1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PerformCancelActionErrorResponse : IErrorResponse<PerformCancelActionError>
{
    public static PerformCancelActionErrorResponse Instance { get; } = new();

    private PerformCancelActionErrorResponse()
    {
    }

    public Task<PerformCancelActionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PerformCancelActionError.Create(response, ct);
}
