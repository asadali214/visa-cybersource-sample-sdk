<!-- Generated file — do not edit; regenerated with the SDK. -->

# Tokenize — operations

Accessor: `client.Tokenize` · Source: `Api/Tokenize.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### TokenizeInvoke

- **Signature**: `TokenizeInvoke(string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `TokenizeResponse`
- **Error**: `SdkException<TokenizeError>` — **Case A (typed)**
- **Error accessors**: `TryGetTokenizeException1(out TokenizeException1)` [400] · `TryGetTokenizeException21(out TokenizeException21)` [403] · `TryGetTokenizeException31(out TokenizeException31)` [424] · `TryGetTokenizeException41(out TokenizeException41)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TokenizeResponse` | `Models/TokenizeResponse.cs` |
| `TokenizeError` | `Errors/TokenizeError.cs` |
| `TokenizeException1` | `Models/TokenizeException1.cs` |
| `TokenizeException21` | `Models/TokenizeException21.cs` |
| `TokenizeException31` | `Models/TokenizeException31.cs` |
| `TokenizeException41` | `Models/TokenizeException41.cs` |

