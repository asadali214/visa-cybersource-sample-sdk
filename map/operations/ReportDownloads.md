<!-- Generated file — do not edit; regenerated with the SDK. -->

# ReportDownloads — operations

Accessor: `client.ReportDownloads` · Source: `Api/ReportDownloads.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DownloadReport

- **Signature**: `DownloadReport(DateTimeOffset reportDate, string reportName, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `reportDate` ← `reportDate`, `reportName` ← `reportName`, `organizationId` ← `organizationId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DownloadReportError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DownloadReportError` | `Errors/DownloadReportError.cs` |

