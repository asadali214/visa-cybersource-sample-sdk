<!-- Generated file — do not edit; regenerated with the SDK. -->

# ReportDefinitions — operations

Accessor: `client.ReportDefinitions` · Source: `Api/ReportDefinitions.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetResourceInfoByReportDefinition

- **Signature**: `GetResourceInfoByReportDefinition(string reportDefinitionName, string? subscriptionType, string? reportMimeType, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `subscriptionType` — nullable, no default → **must pass explicitly**
  - `reportMimeType` — nullable, no default → **must pass explicitly**
  - `organizationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `subscriptionType` ← `subscriptionType`, `reportMimeType` ← `reportMimeType`, `organizationId` ← `organizationId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetResourceInfoByReportDefinitionError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetResourceInfoByReportDefinitionError` | `Errors/GetResourceInfoByReportDefinitionError.cs` |

### GetResourceV2Info

- **Signature**: `GetResourceV2Info(string? subscriptionType, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `subscriptionType` — nullable, no default → **must pass explicitly**
  - `organizationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `subscriptionType` ← `subscriptionType`, `organizationId` ← `organizationId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetResourceV2InfoError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetResourceV2InfoError` | `Errors/GetResourceV2InfoError.cs` |

