<!-- Generated file — do not edit; regenerated with the SDK. -->

# ReportSubscriptions — operations

Accessor: `client.ReportSubscriptions` · Source: `Api/ReportSubscriptions.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateStandardOrClassicSubscription

- **Signature**: `CreateStandardOrClassicSubscription(string? organizationId, PredefinedSubscriptionRequestBean predefinedSubscriptionRequestBean, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `organizationId` ← `organizationId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CreateStandardOrClassicSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PredefinedSubscriptionRequestBean` | `Models/PredefinedSubscriptionRequestBean.cs` |
| `CreateStandardOrClassicSubscriptionError` | `Errors/CreateStandardOrClassicSubscriptionError.cs` |

### CreateSubscription2

- **Signature**: `CreateSubscription2(string? organizationId, CreateReportSubscriptionRequest createReportSubscriptionRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `organizationId` ← `organizationId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CreateSubscription2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateReportSubscriptionRequest` | `Models/CreateReportSubscriptionRequest.cs` |
| `CreateSubscription2Error` | `Errors/CreateSubscription2Error.cs` |

### DeleteSubscription

- **Signature**: `DeleteSubscription(string reportName, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `organizationId` ← `organizationId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteSubscriptionError` | `Errors/DeleteSubscriptionError.cs` |

### GetAllSubscriptions2

- **Signature**: `GetAllSubscriptions2(string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `organizationId` ← `organizationId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetAllSubscriptions2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAllSubscriptions2Error` | `Errors/GetAllSubscriptions2Error.cs` |

### GetSubscription2

- **Signature**: `GetSubscription2(string reportName, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `organizationId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `organizationId` ← `organizationId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetSubscription2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSubscription2Error` | `Errors/GetSubscription2Error.cs` |

