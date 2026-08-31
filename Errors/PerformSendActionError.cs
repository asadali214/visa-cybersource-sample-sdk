using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PerformSendActionError : ApiError
{
    private readonly Optional<InvoicingV2InvoicesSend400Response1> _invoicingV2InvoicesSend400Response1Value;

    private readonly Optional<InvoicingV2InvoicesSend404Response1> _invoicingV2InvoicesSend404Response1Value;

    private readonly Optional<InvoicingV2InvoicesSend502Response1> _invoicingV2InvoicesSend502Response1Value;

    private PerformSendActionError(Optional<InvoicingV2InvoicesSend400Response1> invoicingV2InvoicesSend400Response1Value,
        Optional<InvoicingV2InvoicesSend404Response1> invoicingV2InvoicesSend404Response1Value,
        Optional<InvoicingV2InvoicesSend502Response1> invoicingV2InvoicesSend502Response1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _invoicingV2InvoicesSend400Response1Value = invoicingV2InvoicesSend400Response1Value;
        _invoicingV2InvoicesSend404Response1Value = invoicingV2InvoicesSend404Response1Value;
        _invoicingV2InvoicesSend502Response1Value = invoicingV2InvoicesSend502Response1Value;
    }

    private static PerformSendActionError AsInvoicingV2InvoicesSend400Response1(InvoicingV2InvoicesSend400Response1 value) =>
        new(Optional<InvoicingV2InvoicesSend400Response1>.Some(value), default, default, default);

    private static PerformSendActionError AsInvoicingV2InvoicesSend404Response1(InvoicingV2InvoicesSend404Response1 value) =>
        new(default, Optional<InvoicingV2InvoicesSend404Response1>.Some(value), default, default);

    private static PerformSendActionError AsInvoicingV2InvoicesSend502Response1(InvoicingV2InvoicesSend502Response1 value) =>
        new(default, default, Optional<InvoicingV2InvoicesSend502Response1>.Some(value), default);

    private static PerformSendActionError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetInvoicingV2InvoicesSend400Response1(out InvoicingV2InvoicesSend400Response1 value) =>
        _invoicingV2InvoicesSend400Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesSend404Response1(out InvoicingV2InvoicesSend404Response1 value) =>
        _invoicingV2InvoicesSend404Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesSend502Response1(out InvoicingV2InvoicesSend502Response1 value) =>
        _invoicingV2InvoicesSend502Response1Value.TryGetValue(out value);

    internal static Task<PerformSendActionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<InvoicingV2InvoicesSend400Response1>(response, ct).As(AsInvoicingV2InvoicesSend400Response1),
            404 => FromJson<InvoicingV2InvoicesSend404Response1>(response, ct).As(AsInvoicingV2InvoicesSend404Response1),
            502 => FromJson<InvoicingV2InvoicesSend502Response1>(response, ct).As(AsInvoicingV2InvoicesSend502Response1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PerformSendActionErrorResponse : IErrorResponse<PerformSendActionError>
{
    public static PerformSendActionErrorResponse Instance { get; } = new();

    private PerformSendActionErrorResponse()
    {
    }

    public Task<PerformSendActionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PerformSendActionError.Create(response, ct);
}
