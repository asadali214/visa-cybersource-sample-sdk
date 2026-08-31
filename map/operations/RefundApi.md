<!-- Generated file — do not edit; regenerated with the SDK. -->

# RefundApi — operations

Accessor: `client.RefundApi` · Source: `Api/RefundApi.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### RefundCapture

- **Signature**: `RefundCapture(string id, RefundCaptureRequest refundCaptureRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RefundCaptureError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RefundCaptureRequest` | `Models/RefundCaptureRequest.cs` |
| `RefundCaptureError` | `Errors/RefundCaptureError.cs` |

### RefundPayment

- **Signature**: `RefundPayment(string id, RefundPaymentRequest refundPaymentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RefundPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RefundPaymentRequest` | `Models/RefundPaymentRequest.cs` |
| `RefundPaymentError` | `Errors/RefundPaymentError.cs` |

