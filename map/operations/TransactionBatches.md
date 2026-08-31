<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransactionBatches — operations

Accessor: `client.TransactionBatches` · Source: `Api/TransactionBatches.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTransactionBatchDetails

- **Signature**: `GetTransactionBatchDetails(string id, DateTimeOffset? uploadDate, string? status, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `uploadDate` — nullable, no default → **must pass explicitly**
  - `status` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `uploadDate` ← `uploadDate`, `status` ← `status`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetTransactionBatchDetailsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 401, 403, 404, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTransactionBatchDetailsError` | `Errors/GetTransactionBatchDetailsError.cs` |

### GetTransactionBatchId

- **Signature**: `GetTransactionBatchId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetTransactionBatchIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 401, 403, 404, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTransactionBatchIdError` | `Errors/GetTransactionBatchIdError.cs` |

### GetTransactionBatches

- **Signature**: `GetTransactionBatches(DateTimeOffset startTime, DateTimeOffset endTime, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `startTime` ← `startTime`, `endTime` ← `endTime`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetTransactionBatchesError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 401, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTransactionBatchesError` | `Errors/GetTransactionBatchesError.cs` |

