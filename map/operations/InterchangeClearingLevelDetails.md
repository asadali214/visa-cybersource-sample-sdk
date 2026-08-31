<!-- Generated file — do not edit; regenerated with the SDK. -->

# InterchangeClearingLevelDetails — operations

Accessor: `client.InterchangeClearingLevelDetails` · Source: `Api/InterchangeClearingLevelDetails.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetInterchangeClearingLevelDetails

- **Signature**: `GetInterchangeClearingLevelDetails(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `startTime` ← `startTime`, `endTime` ← `endTime`, `organizationId` ← `organizationId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

