<!-- Generated file — do not edit; regenerated with the SDK. -->

# NotificationOfChanges — operations

Accessor: `client.NotificationOfChanges` · Source: `Api/NotificationOfChanges.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetNotificationOfChangeReport

- **Signature**: `GetNotificationOfChangeReport(DateTimeOffset startTime, DateTimeOffset endTime, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `startTime` ← `startTime`, `endTime` ← `endTime`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetNotificationOfChangeReportError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 401, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetNotificationOfChangeReportError` | `Errors/GetNotificationOfChangeReportError.cs` |

