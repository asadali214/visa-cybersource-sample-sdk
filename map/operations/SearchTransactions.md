<!-- Generated file — do not edit; regenerated with the SDK. -->

# SearchTransactions — operations

Accessor: `client.SearchTransactions` · Source: `Api/SearchTransactions.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateSearch

- **Signature**: `CreateSearch(CreateSearchRequest createSearchRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TssV2TransactionsPost201Response`
- **Error**: `SdkException<CreateSearchError>` — **Case A (typed)**
- **Error accessors**: `TryGetTssV2TransactionsPost400Response1(out TssV2TransactionsPost400Response1)` [400] · `TryGetTssV2TransactionsPost502Response1(out TssV2TransactionsPost502Response1)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSearchRequest` | `Models/CreateSearchRequest.cs` |
| `TssV2TransactionsPost201Response` | `Models/TssV2TransactionsPost201Response.cs` |
| `CreateSearchError` | `Errors/CreateSearchError.cs` |
| `TssV2TransactionsPost400Response1` | `Models/TssV2TransactionsPost400Response1.cs` |
| `TssV2TransactionsPost502Response1` | `Models/TssV2TransactionsPost502Response1.cs` |

### GetSearch

- **Signature**: `GetSearch(string searchId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetSearchError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSearchError` | `Errors/GetSearchError.cs` |

