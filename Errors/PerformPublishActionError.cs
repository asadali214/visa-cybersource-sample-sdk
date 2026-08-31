using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class PerformPublishActionError : ApiError
{
    private readonly Optional<InvoicingV2InvoicesPublish400Response1> _invoicingV2InvoicesPublish400Response1Value;

    private readonly Optional<InvoicingV2InvoicesPublish404Response1> _invoicingV2InvoicesPublish404Response1Value;

    private readonly Optional<InvoicingV2InvoicesPublish502Response1> _invoicingV2InvoicesPublish502Response1Value;

    private PerformPublishActionError(Optional<InvoicingV2InvoicesPublish400Response1> invoicingV2InvoicesPublish400Response1Value,
        Optional<InvoicingV2InvoicesPublish404Response1> invoicingV2InvoicesPublish404Response1Value,
        Optional<InvoicingV2InvoicesPublish502Response1> invoicingV2InvoicesPublish502Response1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _invoicingV2InvoicesPublish400Response1Value = invoicingV2InvoicesPublish400Response1Value;
        _invoicingV2InvoicesPublish404Response1Value = invoicingV2InvoicesPublish404Response1Value;
        _invoicingV2InvoicesPublish502Response1Value = invoicingV2InvoicesPublish502Response1Value;
    }

    private static PerformPublishActionError AsInvoicingV2InvoicesPublish400Response1(InvoicingV2InvoicesPublish400Response1 value) =>
        new(Optional<InvoicingV2InvoicesPublish400Response1>.Some(value), default, default, default);

    private static PerformPublishActionError AsInvoicingV2InvoicesPublish404Response1(InvoicingV2InvoicesPublish404Response1 value) =>
        new(default, Optional<InvoicingV2InvoicesPublish404Response1>.Some(value), default, default);

    private static PerformPublishActionError AsInvoicingV2InvoicesPublish502Response1(InvoicingV2InvoicesPublish502Response1 value) =>
        new(default, default, Optional<InvoicingV2InvoicesPublish502Response1>.Some(value), default);

    private static PerformPublishActionError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetInvoicingV2InvoicesPublish400Response1(out InvoicingV2InvoicesPublish400Response1 value) =>
        _invoicingV2InvoicesPublish400Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesPublish404Response1(out InvoicingV2InvoicesPublish404Response1 value) =>
        _invoicingV2InvoicesPublish404Response1Value.TryGetValue(out value);

    public bool TryGetInvoicingV2InvoicesPublish502Response1(out InvoicingV2InvoicesPublish502Response1 value) =>
        _invoicingV2InvoicesPublish502Response1Value.TryGetValue(out value);

    internal static Task<PerformPublishActionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<InvoicingV2InvoicesPublish400Response1>(response, ct).As(AsInvoicingV2InvoicesPublish400Response1),
            404 => FromJson<InvoicingV2InvoicesPublish404Response1>(response, ct).As(AsInvoicingV2InvoicesPublish404Response1),
            502 => FromJson<InvoicingV2InvoicesPublish502Response1>(response, ct).As(AsInvoicingV2InvoicesPublish502Response1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PerformPublishActionErrorResponse : IErrorResponse<PerformPublishActionError>
{
    public static PerformPublishActionErrorResponse Instance { get; } = new();

    private PerformPublishActionErrorResponse()
    {
    }

    public Task<PerformPublishActionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PerformPublishActionError.Create(response, ct);
}
