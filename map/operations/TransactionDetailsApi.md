<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransactionDetailsApi — operations

Accessor: `client.TransactionDetailsApi` · Source: `Api/TransactionDetailsApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTransaction

- **Signature**: `GetTransaction(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetTransactionError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTransactionError` | `Errors/GetTransactionError.cs` |

