<!-- Generated file — do not edit; regenerated with the SDK. -->

# InvoiceSettings — operations

Accessor: `client.InvoiceSettings` · Source: `Api/InvoiceSettings.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetInvoiceSettings

- **Signature**: `GetInvoiceSettings(ProductType? productType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `productType` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `productType` ← `productType`
- **Returns**: `InvoicingV2InvoiceSettingsGet200Response`
- **Error**: `SdkException<GetInvoiceSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetInvoicingV2InvoiceSettingsGet400Response1(out InvoicingV2InvoiceSettingsGet400Response1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ProductType` | `Models/Enums/ProductType.cs` |
| `InvoicingV2InvoiceSettingsGet200Response` | `Models/InvoicingV2InvoiceSettingsGet200Response.cs` |
| `GetInvoiceSettingsError` | `Errors/GetInvoiceSettingsError.cs` |
| `InvoicingV2InvoiceSettingsGet400Response1` | `Models/InvoicingV2InvoiceSettingsGet400Response1.cs` |

### UpdateInvoiceSettings

- **Signature**: `UpdateInvoiceSettings(ProductType? productType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `productType` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `productType` ← `productType`
- **Returns**: `InvoicingV2InvoiceSettingsPut200Response`
- **Error**: `SdkException<UpdateInvoiceSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetInvoicingV2InvoiceSettingsPut400Response1(out InvoicingV2InvoiceSettingsPut400Response1)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ProductType` | `Models/Enums/ProductType.cs` |
| `InvoicingV2InvoiceSettingsPut200Response` | `Models/InvoicingV2InvoiceSettingsPut200Response.cs` |
| `UpdateInvoiceSettingsError` | `Errors/UpdateInvoiceSettingsError.cs` |
| `InvoicingV2InvoiceSettingsPut400Response1` | `Models/InvoicingV2InvoiceSettingsPut400Response1.cs` |

