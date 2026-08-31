<!-- Generated file — do not edit; regenerated with the SDK. -->

# Reports — operations

Accessor: `client.Reports` · Source: `Api/Reports.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateReport

- **Signature**: `CreateReport(string? organizationId, CreateAdhocReportRequest createAdhocReportRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `organizationId` ← `organizationId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CreateReportError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateAdhocReportRequest` | `Models/CreateAdhocReportRequest.cs` |
| `CreateReportError` | `Errors/CreateReportError.cs` |

### GetReportByReportId

- **Signature**: `GetReportByReportId(string reportId, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `organizationId` ← `organizationId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetReportByReportIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetReportByReportIdError` | `Errors/GetReportByReportIdError.cs` |

### SearchReports

- **Signature**: `SearchReports(DateTimeOffset startTime, DateTimeOffset endTime, string timeQueryType, string? organizationId, string? reportMimeType, string? reportFrequency, string? reportName, int? reportDefinitionId, string? reportStatus, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`organizationId` … `reportStatus`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `startTime` ← `startTime`, `endTime` ← `endTime`, `timeQueryType` ← `timeQueryType`, `organizationId` ← `organizationId`, `reportMimeType` ← `reportMimeType`, `reportFrequency` ← `reportFrequency`, `reportName` ← `reportName`, `reportDefinitionId` ← `reportDefinitionId`, `reportStatus` ← `reportStatus`
- **Returns**: `void` (Task)
- **Error**: `SdkException<SearchReportsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SearchReportsError` | `Errors/SearchReportsError.cs` |

