<!-- Generated file — do not edit; regenerated with the SDK. -->

# NetFundings — operations

Accessor: `client.NetFundings` · Source: `Api/NetFundings.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetNetFundingDetails

- **Signature**: `GetNetFundingDetails(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, string? groupName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
  - `groupName` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `startTime` ← `startTime`, `endTime` ← `endTime`, `organizationId` ← `organizationId`, `groupName` ← `groupName`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetNetFundingDetailsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 401, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetNetFundingDetailsError` | `Errors/GetNetFundingDetailsError.cs` |

