<!-- Generated file — do not edit; regenerated with the SDK. -->

# CaptureApi — operations

Accessor: `client.CaptureApi` · Source: `Api/CaptureApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CapturePayment

- **Signature**: `CapturePayment(string id, CapturePaymentRequest capturePaymentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CapturePaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CapturePaymentRequest` | `Models/CapturePaymentRequest.cs` |
| `CapturePaymentError` | `Errors/CapturePaymentError.cs` |

