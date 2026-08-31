<!-- Generated file — do not edit; regenerated with the SDK. -->

# DownloadDtd — operations

Accessor: `client.DownloadDtd` · Source: `Api/DownloadDtd.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDtdv2

- **Signature**: `GetDtdv2(string reportDefinitionNameVersion, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetDtdv2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDtdv2Error` | `Errors/GetDtdv2Error.cs` |

