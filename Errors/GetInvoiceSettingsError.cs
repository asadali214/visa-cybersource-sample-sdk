using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class GetInvoiceSettingsError : ApiError
{
    private readonly Optional<InvoicingV2InvoiceSettingsGet400Response1> _invoicingV2InvoiceSettingsGet400Response1Value;

    private GetInvoiceSettingsError(Optional<InvoicingV2InvoiceSettingsGet400Response1> invoicingV2InvoiceSettingsGet400Response1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _invoicingV2InvoiceSettingsGet400Response1Value = invoicingV2InvoiceSettingsGet400Response1Value;
    }

    private static GetInvoiceSettingsError AsInvoicingV2InvoiceSettingsGet400Response1(InvoicingV2InvoiceSettingsGet400Response1 value) =>
        new(Optional<InvoicingV2InvoiceSettingsGet400Response1>.Some(value), default);

    private static GetInvoiceSettingsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetInvoicingV2InvoiceSettingsGet400Response1(out InvoicingV2InvoiceSettingsGet400Response1 value) =>
        _invoicingV2InvoiceSettingsGet400Response1Value.TryGetValue(out value);

    internal static Task<GetInvoiceSettingsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<InvoicingV2InvoiceSettingsGet400Response1>(response, ct).As(AsInvoicingV2InvoiceSettingsGet400Response1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetInvoiceSettingsErrorResponse : IErrorResponse<GetInvoiceSettingsError>
{
    public static GetInvoiceSettingsErrorResponse Instance { get; } = new();

    private GetInvoiceSettingsErrorResponse()
    {
    }

    public Task<GetInvoiceSettingsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetInvoiceSettingsError.Create(response, ct);
}
