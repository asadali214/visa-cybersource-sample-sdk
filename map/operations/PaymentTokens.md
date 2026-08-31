<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentTokens — operations

Accessor: `client.PaymentTokens` · Source: `Api/PaymentTokens.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### RetrieveOrDeletePaymentToken

- **Signature**: `RetrieveOrDeletePaymentToken(RequestModel request, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RetrieveOrDeletePaymentTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RequestModel` | `Models/RequestModel.cs` |
| `RetrieveOrDeletePaymentTokenError` | `Errors/RetrieveOrDeletePaymentTokenError.cs` |

