<!-- Generated file — do not edit; regenerated with the SDK. -->

# SecureFileShare — operations

Accessor: `client.SecureFileShare` · Source: `Api/SecureFileShare.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetFile

- **Signature**: `GetFile(string fileId, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `organizationId` ← `organizationId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetFileError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFileError` | `Errors/GetFileError.cs` |

### GetFileDetail

- **Signature**: `GetFileDetail(DateTimeOffset startDate, DateTimeOffset endDate, string? organizationId, string? name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
  - `name` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `startDate` ← `startDate`, `endDate` ← `endDate`, `organizationId` ← `organizationId`, `name` ← `name`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetFileDetailError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 401, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetFileDetailError` | `Errors/GetFileDetailError.cs` |

