<!-- Generated file — do not edit; regenerated with the SDK. -->

# Payments — operations

Accessor: `client.Payments` · Source: `Api/Payments.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateOrderRequest

- **Signature**: `CreateOrderRequest(string id, OrderPaymentRequest orderPaymentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CreateOrderRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OrderPaymentRequest` | `Models/OrderPaymentRequest.cs` |
| `CreateOrderRequestError` | `Errors/CreateOrderRequestError.cs` |

### CreatePayment

- **Signature**: `CreatePayment(CreatePaymentRequest createPaymentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CreatePaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreatePaymentRequest` | `Models/CreatePaymentRequest.cs` |
| `CreatePaymentError` | `Errors/CreatePaymentError.cs` |

### CreateSessionRequest

- **Signature**: `CreateSessionRequest(CreateSessionReq createSessionReq, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CreateSessionRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSessionReq` | `Models/CreateSessionReq.cs` |
| `CreateSessionRequestError` | `Errors/CreateSessionRequestError.cs` |

### IncrementAuth

- **Signature**: `IncrementAuth(string id, IncrementAuthRequest incrementAuthRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<IncrementAuthError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IncrementAuthRequest` | `Models/IncrementAuthRequest.cs` |
| `IncrementAuthError` | `Errors/IncrementAuthError.cs` |

### RefreshPaymentStatus

- **Signature**: `RefreshPaymentStatus(string id, RefreshPaymentStatusRequest refreshPaymentStatusRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RefreshPaymentStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RefreshPaymentStatusRequest` | `Models/RefreshPaymentStatusRequest.cs` |
| `RefreshPaymentStatusError` | `Errors/RefreshPaymentStatusError.cs` |

### UpdateSessionRequest

- **Signature**: `UpdateSessionRequest(string id, CreateSessionRequest createSessionRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<UpdateSessionRequestError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSessionRequest` | `Models/CreateSessionRequest.cs` |
| `UpdateSessionRequestError` | `Errors/UpdateSessionRequestError.cs` |

