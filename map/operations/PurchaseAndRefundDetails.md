<!-- Generated file — do not edit; regenerated with the SDK. -->

# PurchaseAndRefundDetails — operations

Accessor: `client.PurchaseAndRefundDetails` · Source: `Api/PurchaseAndRefundDetails.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPurchaseAndRefundDetails

- **Signature**: `GetPurchaseAndRefundDetails(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, string? groupName, int? offset, string? paymentSubtype = "ALL", string? viewBy = "requestDate", int? limit = 2000, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
  - `groupName` — nullable, no default → **must pass explicitly**
  - `offset` — nullable, no default → **must pass explicitly**
  - defaults: `paymentSubtype` = `"ALL"`, `viewBy` = `"requestDate"`, `limit` = `2000`
- **Query params (wire ← C#)**: `startTime` ← `startTime`, `endTime` ← `endTime`, `organizationId` ← `organizationId`, `paymentSubtype` ← `paymentSubtype`, `viewBy` ← `viewBy`, `groupName` ← `groupName`, `offset` ← `offset`, `limit` ← `limit`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetPurchaseAndRefundDetailsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 401, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPurchaseAndRefundDetailsError` | `Errors/GetPurchaseAndRefundDetailsError.cs` |

