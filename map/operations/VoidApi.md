<!-- Generated file — do not edit; regenerated with the SDK. -->

# VoidApi — operations

Accessor: `client.VoidApi` · Source: `Api/VoidApi.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### MitVoid

- **Signature**: `MitVoid(MitVoidRequest mitVoidRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<MitVoidError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MitVoidRequest` | `Models/MitVoidRequest.cs` |
| `MitVoidError` | `Errors/MitVoidError.cs` |

### VoidCapture

- **Signature**: `VoidCapture(string id, VoidCaptureRequest voidCaptureRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<VoidCaptureError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VoidCaptureRequest` | `Models/VoidCaptureRequest.cs` |
| `VoidCaptureError` | `Errors/VoidCaptureError.cs` |

### VoidCredit

- **Signature**: `VoidCredit(string id, VoidCreditRequest voidCreditRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<VoidCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VoidCreditRequest` | `Models/VoidCreditRequest.cs` |
| `VoidCreditError` | `Errors/VoidCreditError.cs` |

### VoidPayment

- **Signature**: `VoidPayment(string id, VoidPaymentRequest voidPaymentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<VoidPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VoidPaymentRequest` | `Models/VoidPaymentRequest.cs` |
| `VoidPaymentError` | `Errors/VoidPaymentError.cs` |

### VoidRefund

- **Signature**: `VoidRefund(string id, VoidRefundRequest voidRefundRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<VoidRefundError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VoidRefundRequest` | `Models/VoidRefundRequest.cs` |
| `VoidRefundError` | `Errors/VoidRefundError.cs` |

