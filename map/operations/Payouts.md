<!-- Generated file — do not edit; regenerated with the SDK. -->

# Payouts — operations

Accessor: `client.Payouts` · Source: `Api/Payouts.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### OctCreatePayment

- **Signature**: `OctCreatePayment(OctCreatePaymentRequest octCreatePaymentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<OctCreatePaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OctCreatePaymentRequest` | `Models/OctCreatePaymentRequest.cs` |
| `OctCreatePaymentError` | `Errors/OctCreatePaymentError.cs` |

