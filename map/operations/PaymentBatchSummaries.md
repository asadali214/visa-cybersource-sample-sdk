<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentBatchSummaries — operations

Accessor: `client.PaymentBatchSummaries` · Source: `Api/PaymentBatchSummaries.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPaymentBatchSummary

- **Signature**: `GetPaymentBatchSummary(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, string? rollUp, string? breakdown, int? startDayOfWeek, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`organizationId` … `startDayOfWeek`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `startTime` ← `startTime`, `endTime` ← `endTime`, `organizationId` ← `organizationId`, `rollUp` ← `rollUp`, `breakdown` ← `breakdown`, `startDayOfWeek` ← `startDayOfWeek`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetPaymentBatchSummaryError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentBatchSummaryError` | `Errors/GetPaymentBatchSummaryError.cs` |

