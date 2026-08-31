<!-- Generated file — do not edit; regenerated with the SDK. -->

# ReversalApi — operations

Accessor: `client.ReversalApi` · Source: `Api/ReversalApi.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AuthReversal

- **Signature**: `AuthReversal(string id, AuthReversalRequest authReversalRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AuthReversalError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AuthReversalRequest` | `Models/AuthReversalRequest.cs` |
| `AuthReversalError` | `Errors/AuthReversalError.cs` |

### MitReversal

- **Signature**: `MitReversal(MitReversalRequest mitReversalRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<MitReversalError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MitReversalRequest` | `Models/MitReversalRequest.cs` |
| `MitReversalError` | `Errors/MitReversalError.cs` |

