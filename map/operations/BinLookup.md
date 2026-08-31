<!-- Generated file — do not edit; regenerated with the SDK. -->

# BinLookup — operations

Accessor: `client.BinLookup` · Source: `Api/BinLookup.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountInfo

- **Signature**: `GetAccountInfo(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetAccountInfoResponse`
- **Error**: `SdkException<GetAccountInfoError>` — **Case A (typed)**
- **Error accessors**: `TryGetBinLookupv400Response1(out BinLookupv400Response1)` [400] · `TryGetBinLookup403Response1(out BinLookup403Response1)` [403] · `TryGetGetAccountInfoException1(out GetAccountInfoException1)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountInfoResponse` | `Models/GetAccountInfoResponse.cs` |
| `GetAccountInfoError` | `Errors/GetAccountInfoError.cs` |
| `BinLookupv400Response1` | `Models/BinLookupv400Response1.cs` |
| `BinLookup403Response1` | `Models/BinLookup403Response1.cs` |
| `GetAccountInfoException1` | `Models/GetAccountInfoException1.cs` |

