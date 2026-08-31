using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Errors;

public sealed class UpdateInvoiceSettingsError : ApiError
{
    private readonly Optional<InvoicingV2InvoiceSettingsPut400Response1> _invoicingV2InvoiceSettingsPut400Response1Value;

    private UpdateInvoiceSettingsError(Optional<InvoicingV2InvoiceSettingsPut400Response1> invoicingV2InvoiceSettingsPut400Response1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _invoicingV2InvoiceSettingsPut400Response1Value = invoicingV2InvoiceSettingsPut400Response1Value;
    }

    private static UpdateInvoiceSettingsError AsInvoicingV2InvoiceSettingsPut400Response1(InvoicingV2InvoiceSettingsPut400Response1 value) =>
        new(Optional<InvoicingV2InvoiceSettingsPut400Response1>.Some(value), default);

    private static UpdateInvoiceSettingsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetInvoicingV2InvoiceSettingsPut400Response1(out InvoicingV2InvoiceSettingsPut400Response1 value) =>
        _invoicingV2InvoiceSettingsPut400Response1Value.TryGetValue(out value);

    internal static Task<UpdateInvoiceSettingsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<InvoicingV2InvoiceSettingsPut400Response1>(response, ct).As(AsInvoicingV2InvoiceSettingsPut400Response1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateInvoiceSettingsErrorResponse : IErrorResponse<UpdateInvoiceSettingsError>
{
    public static UpdateInvoiceSettingsErrorResponse Instance { get; } = new();

    private UpdateInvoiceSettingsErrorResponse()
    {
    }

    public Task<UpdateInvoiceSettingsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateInvoiceSettingsError.Create(response, ct);
}
