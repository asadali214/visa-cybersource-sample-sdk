<!-- Generated file — do not edit; regenerated with the SDK. -->

# ConversionDetails — operations

Accessor: `client.ConversionDetails` · Source: `Api/ConversionDetails.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetConversionDetail

- **Signature**: `GetConversionDetail(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `startTime` ← `startTime`, `endTime` ← `endTime`, `organizationId` ← `organizationId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetConversionDetailError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetConversionDetailError` | `Errors/GetConversionDetailError.cs` |

