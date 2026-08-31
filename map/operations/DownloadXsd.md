<!-- Generated file — do not edit; regenerated with the SDK. -->

# DownloadXsd — operations

Accessor: `client.DownloadXsd` · Source: `Api/DownloadXsd.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetXsdv2

- **Signature**: `GetXsdv2(string reportDefinitionNameVersion, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetXsdv2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetXsdv2Error` | `Errors/GetXsdv2Error.cs` |

