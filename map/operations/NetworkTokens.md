<!-- Generated file — do not edit; regenerated with the SDK. -->

# NetworkTokens — operations

Accessor: `client.NetworkTokens` · Source: `Api/NetworkTokens.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCardArtAsset

- **Signature**: `GetCardArtAsset(string instrumentIdentifierId, TokenProvider tokenProvider, AssetType assetType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetCardArtAssetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TokenProvider` | `Models/Enums/TokenProvider.cs` |
| `AssetType` | `Models/Enums/AssetType.cs` |
| `GetCardArtAssetResponse` | `Models/GetCardArtAssetResponse.cs` |

### GetTokenizedCard

- **Signature**: `GetTokenizedCard(string tokenizedCardId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `GetTokenizedCardResponse`
- **Error**: `SdkException<GetTokenizedCardError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetTokenizedCardException1(out GetTokenizedCardException1)` [400] · `TryGetGetTokenizedCardException21(out GetTokenizedCardException21)` [403] · `TryGetGetTokenizedCardException31(out GetTokenizedCardException31)` [404] · `TryGetGetTokenizedCardException41(out GetTokenizedCardException41)` [424] · `TryGetGetTokenizedCardException51(out GetTokenizedCardException51)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTokenizedCardResponse` | `Models/GetTokenizedCardResponse.cs` |
| `GetTokenizedCardError` | `Errors/GetTokenizedCardError.cs` |
| `GetTokenizedCardException1` | `Models/GetTokenizedCardException1.cs` |
| `GetTokenizedCardException21` | `Models/GetTokenizedCardException21.cs` |
| `GetTokenizedCardException31` | `Models/GetTokenizedCardException31.cs` |
| `GetTokenizedCardException41` | `Models/GetTokenizedCardException41.cs` |
| `GetTokenizedCardException51` | `Models/GetTokenizedCardException51.cs` |

### PostIssuerLifeCycleSimulation

- **Signature**: `PostIssuerLifeCycleSimulation(string tokenizedCardId, string profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<PostIssuerLifeCycleSimulationError>` — **Case A (typed)**
- **Error accessors**: `TryGetPostIssuerLifeCycleSimulationException1(out PostIssuerLifeCycleSimulationException1)` [400] · `TryGetPostIssuerLifeCycleSimulationException21(out PostIssuerLifeCycleSimulationException21)` [403] · `TryGetPostIssuerLifeCycleSimulationException31(out PostIssuerLifeCycleSimulationException31)` [404] · `TryGetPostIssuerLifeCycleSimulationException41(out PostIssuerLifeCycleSimulationException41)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostIssuerLifeCycleSimulationError` | `Errors/PostIssuerLifeCycleSimulationError.cs` |
| `PostIssuerLifeCycleSimulationException1` | `Models/PostIssuerLifeCycleSimulationException1.cs` |
| `PostIssuerLifeCycleSimulationException21` | `Models/PostIssuerLifeCycleSimulationException21.cs` |
| `PostIssuerLifeCycleSimulationException31` | `Models/PostIssuerLifeCycleSimulationException31.cs` |
| `PostIssuerLifeCycleSimulationException41` | `Models/PostIssuerLifeCycleSimulationException41.cs` |

### PostTokenPaymentCredentials

- **Signature**: `PostTokenPaymentCredentials(string tokenId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<PostTokenPaymentCredentialsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 403, 404, 410, 500, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTokenPaymentCredentialsError` | `Errors/PostTokenPaymentCredentialsError.cs` |

### PostTokenPaymentCredentialsV3

- **Signature**: `PostTokenPaymentCredentialsV3(string tokenId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<PostTokenPaymentCredentialsV3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 403, 404, 409, 410, 500, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTokenPaymentCredentialsV3Error` | `Errors/PostTokenPaymentCredentialsV3Error.cs` |

### PostTokenizedCard

- **Signature**: `PostTokenizedCard(string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `PostTokenizedCardResponse`
- **Error**: `SdkException<PostTokenizedCardError>` — **Case A (typed)**
- **Error accessors**: `TryGetPostTokenizedCardException1(out PostTokenizedCardException1)` [400] · `TryGetPostTokenizedCardException21(out PostTokenizedCardException21)` [403] · `TryGetPostTokenizedCardException31(out PostTokenizedCardException31)` [409] · `TryGetPostTokenizedCardException41(out PostTokenizedCardException41)` [424] · `TryGetPostTokenizedCardException51(out PostTokenizedCardException51)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTokenizedCardResponse` | `Models/PostTokenizedCardResponse.cs` |
| `PostTokenizedCardError` | `Errors/PostTokenizedCardError.cs` |
| `PostTokenizedCardException1` | `Models/PostTokenizedCardException1.cs` |
| `PostTokenizedCardException21` | `Models/PostTokenizedCardException21.cs` |
| `PostTokenizedCardException31` | `Models/PostTokenizedCardException31.cs` |
| `PostTokenizedCardException41` | `Models/PostTokenizedCardException41.cs` |
| `PostTokenizedCardException51` | `Models/PostTokenizedCardException51.cs` |

### PostTokenizedCardDelete

- **Signature**: `PostTokenizedCardDelete(string tokenizedCardId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<PostTokenizedCardDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetPostTokenizedCardDeleteException1(out PostTokenizedCardDeleteException1)` [400] · `TryGetPostTokenizedCardDeleteException21(out PostTokenizedCardDeleteException21)` [403] · `TryGetPostTokenizedCardDeleteException31(out PostTokenizedCardDeleteException31)` [404] · `TryGetPostTokenizedCardDeleteException41(out PostTokenizedCardDeleteException41)` [409] · `TryGetPostTokenizedCardDeleteException51(out PostTokenizedCardDeleteException51)` [410] · `TryGetPostTokenizedCardDeleteException61(out PostTokenizedCardDeleteException61)` [424] · `TryGetPostTokenizedCardDeleteException71(out PostTokenizedCardDeleteException71)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTokenizedCardDeleteError` | `Errors/PostTokenizedCardDeleteError.cs` |
| `PostTokenizedCardDeleteException1` | `Models/PostTokenizedCardDeleteException1.cs` |
| `PostTokenizedCardDeleteException21` | `Models/PostTokenizedCardDeleteException21.cs` |
| `PostTokenizedCardDeleteException31` | `Models/PostTokenizedCardDeleteException31.cs` |
| `PostTokenizedCardDeleteException41` | `Models/PostTokenizedCardDeleteException41.cs` |
| `PostTokenizedCardDeleteException51` | `Models/PostTokenizedCardDeleteException51.cs` |
| `PostTokenizedCardDeleteException61` | `Models/PostTokenizedCardDeleteException61.cs` |
| `PostTokenizedCardDeleteException71` | `Models/PostTokenizedCardDeleteException71.cs` |

