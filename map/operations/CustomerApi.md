<!-- Generated file — do not edit; regenerated with the SDK. -->

# CustomerApi — operations

Accessor: `client.CustomerApi` · Source: `Api/CustomerApi.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteCustomer

- **Signature**: `DeleteCustomer(string customerId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteCustomerError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeleteCustomerException1(out DeleteCustomerException1)` [400] · `TryGetDeleteCustomerException21(out DeleteCustomerException21)` [403] · `TryGetDeleteCustomerException31(out DeleteCustomerException31)` [404] · `TryGetDeleteCustomerException41(out DeleteCustomerException41)` [410] · `TryGetDeleteCustomerException51(out DeleteCustomerException51)` [424] · `TryGetDeleteCustomerException61(out DeleteCustomerException61)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCustomerError` | `Errors/DeleteCustomerError.cs` |
| `DeleteCustomerException1` | `Models/DeleteCustomerException1.cs` |
| `DeleteCustomerException21` | `Models/DeleteCustomerException21.cs` |
| `DeleteCustomerException31` | `Models/DeleteCustomerException31.cs` |
| `DeleteCustomerException41` | `Models/DeleteCustomerException41.cs` |
| `DeleteCustomerException51` | `Models/DeleteCustomerException51.cs` |
| `DeleteCustomerException61` | `Models/DeleteCustomerException61.cs` |

### GetCustomer

- **Signature**: `GetCustomer(string customerId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `GetCustomerResponse`
- **Error**: `SdkException<GetCustomerError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetCustomerException1(out GetCustomerException1)` [400] · `TryGetGetCustomerException21(out GetCustomerException21)` [403] · `TryGetGetCustomerException31(out GetCustomerException31)` [404] · `TryGetGetCustomerException41(out GetCustomerException41)` [410] · `TryGetGetCustomerException51(out GetCustomerException51)` [424] · `TryGetGetCustomerException61(out GetCustomerException61)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCustomerResponse` | `Models/GetCustomerResponse.cs` |
| `GetCustomerError` | `Errors/GetCustomerError.cs` |
| `GetCustomerException1` | `Models/GetCustomerException1.cs` |
| `GetCustomerException21` | `Models/GetCustomerException21.cs` |
| `GetCustomerException31` | `Models/GetCustomerException31.cs` |
| `GetCustomerException41` | `Models/GetCustomerException41.cs` |
| `GetCustomerException51` | `Models/GetCustomerException51.cs` |
| `GetCustomerException61` | `Models/GetCustomerException61.cs` |

### PatchCustomer

- **Signature**: `PatchCustomer(string customerId, string? profileId, string? ifMatch, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
  - `ifMatch` — nullable, no default → **must pass explicitly**
- **Returns**: `PatchCustomerResponse`
- **Error**: `SdkException<PatchCustomerError>` — **Case A (typed)**
- **Error accessors**: `TryGetPatchCustomerException1(out PatchCustomerException1)` [400] · `TryGetPatchCustomerException21(out PatchCustomerException21)` [403] · `TryGetPatchCustomerException31(out PatchCustomerException31)` [404] · `TryGetPatchCustomerException41(out PatchCustomerException41)` [410] · `TryGetPatchCustomerException51(out PatchCustomerException51)` [412] · `TryGetPatchCustomerException61(out PatchCustomerException61)` [424] · `TryGetPatchCustomerException71(out PatchCustomerException71)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchCustomerResponse` | `Models/PatchCustomerResponse.cs` |
| `PatchCustomerError` | `Errors/PatchCustomerError.cs` |
| `PatchCustomerException1` | `Models/PatchCustomerException1.cs` |
| `PatchCustomerException21` | `Models/PatchCustomerException21.cs` |
| `PatchCustomerException31` | `Models/PatchCustomerException31.cs` |
| `PatchCustomerException41` | `Models/PatchCustomerException41.cs` |
| `PatchCustomerException51` | `Models/PatchCustomerException51.cs` |
| `PatchCustomerException61` | `Models/PatchCustomerException61.cs` |
| `PatchCustomerException71` | `Models/PatchCustomerException71.cs` |

### PostCustomer

- **Signature**: `PostCustomer(string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `TmsV2CustomersResponse`
- **Error**: `SdkException<PostCustomerError>` — **Case A (typed)**
- **Error accessors**: `TryGetPostCustomerException1(out PostCustomerException1)` [400] · `TryGetPostCustomerException21(out PostCustomerException21)` [403] · `TryGetPostCustomerException31(out PostCustomerException31)` [409] · `TryGetPostCustomerException41(out PostCustomerException41)` [424] · `TryGetPostCustomerException51(out PostCustomerException51)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TmsV2CustomersResponse` | `Models/TmsV2CustomersResponse.cs` |
| `PostCustomerError` | `Errors/PostCustomerError.cs` |
| `PostCustomerException1` | `Models/PostCustomerException1.cs` |
| `PostCustomerException21` | `Models/PostCustomerException21.cs` |
| `PostCustomerException31` | `Models/PostCustomerException31.cs` |
| `PostCustomerException41` | `Models/PostCustomerException41.cs` |
| `PostCustomerException51` | `Models/PostCustomerException51.cs` |

