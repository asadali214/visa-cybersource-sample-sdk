<!-- Generated file — do not edit; regenerated with the SDK. -->

# Invoices — operations

Accessor: `client.Invoices` · Source: `Api/Invoices.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateInvoice

- **Signature**: `CreateInvoice(CreateInvoiceRequest createInvoiceRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `InvoicingV2InvoicesPost201Response`
- **Error**: `SdkException<CreateInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetInvoicingV2InvoicesPost400Response1(out InvoicingV2InvoicesPost400Response1)` [400] · `TryGetInvoicingV2InvoicesPost404Response1(out InvoicingV2InvoicesPost404Response1)` [404] · `TryGetInvoicingV2InvoicesPost502Response1(out InvoicingV2InvoicesPost502Response1)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateInvoiceRequest` | `Models/CreateInvoiceRequest.cs` |
| `InvoicingV2InvoicesPost201Response` | `Models/InvoicingV2InvoicesPost201Response.cs` |
| `CreateInvoiceError` | `Errors/CreateInvoiceError.cs` |
| `InvoicingV2InvoicesPost400Response1` | `Models/InvoicingV2InvoicesPost400Response1.cs` |
| `InvoicingV2InvoicesPost404Response1` | `Models/InvoicingV2InvoicesPost404Response1.cs` |
| `InvoicingV2InvoicesPost502Response1` | `Models/InvoicingV2InvoicesPost502Response1.cs` |

### GetAllInvoices

- **Signature**: `GetAllInvoices(int offset, int limit, string? status, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `status` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `offset` ← `offset`, `limit` ← `limit`, `status` ← `status`
- **Returns**: `InvoicingV2InvoicesAllGet200Response`
- **Error**: `SdkException<GetAllInvoicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetInvoicingV2InvoicesAllGet400Response1(out InvoicingV2InvoicesAllGet400Response1)` [400] · `TryGetInvoicingV2InvoicesAllGet404Response1(out InvoicingV2InvoicesAllGet404Response1)` [404] · `TryGetInvoicingV2InvoicesAllGet502Response1(out InvoicingV2InvoicesAllGet502Response1)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `InvoicingV2InvoicesAllGet200Response` | `Models/InvoicingV2InvoicesAllGet200Response.cs` |
| `GetAllInvoicesError` | `Errors/GetAllInvoicesError.cs` |
| `InvoicingV2InvoicesAllGet400Response1` | `Models/InvoicingV2InvoicesAllGet400Response1.cs` |
| `InvoicingV2InvoicesAllGet404Response1` | `Models/InvoicingV2InvoicesAllGet404Response1.cs` |
| `InvoicingV2InvoicesAllGet502Response1` | `Models/InvoicingV2InvoicesAllGet502Response1.cs` |

### GetInvoice

- **Signature**: `GetInvoice(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `InvoicingV2InvoicesGet200Response`
- **Error**: `SdkException<GetInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetInvoicingV2InvoicesGet400Response1(out InvoicingV2InvoicesGet400Response1)` [400] · `TryGetInvoicingV2InvoicesGet404Response1(out InvoicingV2InvoicesGet404Response1)` [404] · `TryGetInvoicingV2InvoicesGet502Response1(out InvoicingV2InvoicesGet502Response1)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `InvoicingV2InvoicesGet200Response` | `Models/InvoicingV2InvoicesGet200Response.cs` |
| `GetInvoiceError` | `Errors/GetInvoiceError.cs` |
| `InvoicingV2InvoicesGet400Response1` | `Models/InvoicingV2InvoicesGet400Response1.cs` |
| `InvoicingV2InvoicesGet404Response1` | `Models/InvoicingV2InvoicesGet404Response1.cs` |
| `InvoicingV2InvoicesGet502Response1` | `Models/InvoicingV2InvoicesGet502Response1.cs` |

### PerformCancelAction

- **Signature**: `PerformCancelAction(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `InvoicingV2InvoicesCancel200Response`
- **Error**: `SdkException<PerformCancelActionError>` — **Case A (typed)**
- **Error accessors**: `TryGetInvoicingV2InvoicesCancel400Response1(out InvoicingV2InvoicesCancel400Response1)` [400] · `TryGetInvoicingV2InvoicesCancel404Response1(out InvoicingV2InvoicesCancel404Response1)` [404] · `TryGetInvoicingV2InvoicesCancel502Response1(out InvoicingV2InvoicesCancel502Response1)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `InvoicingV2InvoicesCancel200Response` | `Models/InvoicingV2InvoicesCancel200Response.cs` |
| `PerformCancelActionError` | `Errors/PerformCancelActionError.cs` |
| `InvoicingV2InvoicesCancel400Response1` | `Models/InvoicingV2InvoicesCancel400Response1.cs` |
| `InvoicingV2InvoicesCancel404Response1` | `Models/InvoicingV2InvoicesCancel404Response1.cs` |
| `InvoicingV2InvoicesCancel502Response1` | `Models/InvoicingV2InvoicesCancel502Response1.cs` |

### PerformPublishAction

- **Signature**: `PerformPublishAction(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `InvoicingV2InvoicesPublish200Response`
- **Error**: `SdkException<PerformPublishActionError>` — **Case A (typed)**
- **Error accessors**: `TryGetInvoicingV2InvoicesPublish400Response1(out InvoicingV2InvoicesPublish400Response1)` [400] · `TryGetInvoicingV2InvoicesPublish404Response1(out InvoicingV2InvoicesPublish404Response1)` [404] · `TryGetInvoicingV2InvoicesPublish502Response1(out InvoicingV2InvoicesPublish502Response1)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `InvoicingV2InvoicesPublish200Response` | `Models/InvoicingV2InvoicesPublish200Response.cs` |
| `PerformPublishActionError` | `Errors/PerformPublishActionError.cs` |
| `InvoicingV2InvoicesPublish400Response1` | `Models/InvoicingV2InvoicesPublish400Response1.cs` |
| `InvoicingV2InvoicesPublish404Response1` | `Models/InvoicingV2InvoicesPublish404Response1.cs` |
| `InvoicingV2InvoicesPublish502Response1` | `Models/InvoicingV2InvoicesPublish502Response1.cs` |

### PerformSendAction

- **Signature**: `PerformSendAction(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `InvoicingV2InvoicesSend200Response`
- **Error**: `SdkException<PerformSendActionError>` — **Case A (typed)**
- **Error accessors**: `TryGetInvoicingV2InvoicesSend400Response1(out InvoicingV2InvoicesSend400Response1)` [400] · `TryGetInvoicingV2InvoicesSend404Response1(out InvoicingV2InvoicesSend404Response1)` [404] · `TryGetInvoicingV2InvoicesSend502Response1(out InvoicingV2InvoicesSend502Response1)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `InvoicingV2InvoicesSend200Response` | `Models/InvoicingV2InvoicesSend200Response.cs` |
| `PerformSendActionError` | `Errors/PerformSendActionError.cs` |
| `InvoicingV2InvoicesSend400Response1` | `Models/InvoicingV2InvoicesSend400Response1.cs` |
| `InvoicingV2InvoicesSend404Response1` | `Models/InvoicingV2InvoicesSend404Response1.cs` |
| `InvoicingV2InvoicesSend502Response1` | `Models/InvoicingV2InvoicesSend502Response1.cs` |

### UpdateInvoice

- **Signature**: `UpdateInvoice(string id, UpdateInvoiceRequest updateInvoiceRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `InvoicingV2InvoicesPut200Response`
- **Error**: `SdkException<UpdateInvoiceError>` — **Case A (typed)**
- **Error accessors**: `TryGetInvoicingV2InvoicesPut400Response1(out InvoicingV2InvoicesPut400Response1)` [400] · `TryGetInvoicingV2InvoicesPut404Response1(out InvoicingV2InvoicesPut404Response1)` [404] · `TryGetInvoicingV2InvoicesPut502Response1(out InvoicingV2InvoicesPut502Response1)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateInvoiceRequest` | `Models/UpdateInvoiceRequest.cs` |
| `InvoicingV2InvoicesPut200Response` | `Models/InvoicingV2InvoicesPut200Response.cs` |
| `UpdateInvoiceError` | `Errors/UpdateInvoiceError.cs` |
| `InvoicingV2InvoicesPut400Response1` | `Models/InvoicingV2InvoicesPut400Response1.cs` |
| `InvoicingV2InvoicesPut404Response1` | `Models/InvoicingV2InvoicesPut404Response1.cs` |
| `InvoicingV2InvoicesPut502Response1` | `Models/InvoicingV2InvoicesPut502Response1.cs` |

