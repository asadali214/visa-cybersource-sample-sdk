<!-- Generated file — do not edit; regenerated with the SDK. -->

# CustomerShippingAddress — operations

Accessor: `client.CustomerShippingAddress` · Source: `Api/CustomerShippingAddress.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteCustomerShippingAddress

- **Signature**: `DeleteCustomerShippingAddress(string customerId, string shippingAddressId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteCustomerShippingAddressError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeleteCustomerShippingAddressException1(out DeleteCustomerShippingAddressException1)` [400] · `TryGetDeleteCustomerShippingAddressException21(out DeleteCustomerShippingAddressException21)` [403] · `TryGetDeleteCustomerShippingAddressException31(out DeleteCustomerShippingAddressException31)` [404] · `TryGetDeleteCustomerShippingAddressException41(out DeleteCustomerShippingAddressException41)` [409] · `TryGetDeleteCustomerShippingAddressException51(out DeleteCustomerShippingAddressException51)` [410] · `TryGetDeleteCustomerShippingAddressException61(out DeleteCustomerShippingAddressException61)` [424] · `TryGetDeleteCustomerShippingAddressException71(out DeleteCustomerShippingAddressException71)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCustomerShippingAddressError` | `Errors/DeleteCustomerShippingAddressError.cs` |
| `DeleteCustomerShippingAddressException1` | `Models/DeleteCustomerShippingAddressException1.cs` |
| `DeleteCustomerShippingAddressException21` | `Models/DeleteCustomerShippingAddressException21.cs` |
| `DeleteCustomerShippingAddressException31` | `Models/DeleteCustomerShippingAddressException31.cs` |
| `DeleteCustomerShippingAddressException41` | `Models/DeleteCustomerShippingAddressException41.cs` |
| `DeleteCustomerShippingAddressException51` | `Models/DeleteCustomerShippingAddressException51.cs` |
| `DeleteCustomerShippingAddressException61` | `Models/DeleteCustomerShippingAddressException61.cs` |
| `DeleteCustomerShippingAddressException71` | `Models/DeleteCustomerShippingAddressException71.cs` |

### GetCustomerShippingAddress

- **Signature**: `GetCustomerShippingAddress(string customerId, string shippingAddressId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `GetCustomerShippingAddressResponse`
- **Error**: `SdkException<GetCustomerShippingAddressError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetCustomerShippingAddressException1(out GetCustomerShippingAddressException1)` [400] · `TryGetGetCustomerShippingAddressException21(out GetCustomerShippingAddressException21)` [403] · `TryGetGetCustomerShippingAddressException31(out GetCustomerShippingAddressException31)` [404] · `TryGetGetCustomerShippingAddressException41(out GetCustomerShippingAddressException41)` [410] · `TryGetGetCustomerShippingAddressException51(out GetCustomerShippingAddressException51)` [424] · `TryGetGetCustomerShippingAddressException61(out GetCustomerShippingAddressException61)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCustomerShippingAddressResponse` | `Models/GetCustomerShippingAddressResponse.cs` |
| `GetCustomerShippingAddressError` | `Errors/GetCustomerShippingAddressError.cs` |
| `GetCustomerShippingAddressException1` | `Models/GetCustomerShippingAddressException1.cs` |
| `GetCustomerShippingAddressException21` | `Models/GetCustomerShippingAddressException21.cs` |
| `GetCustomerShippingAddressException31` | `Models/GetCustomerShippingAddressException31.cs` |
| `GetCustomerShippingAddressException41` | `Models/GetCustomerShippingAddressException41.cs` |
| `GetCustomerShippingAddressException51` | `Models/GetCustomerShippingAddressException51.cs` |
| `GetCustomerShippingAddressException61` | `Models/GetCustomerShippingAddressException61.cs` |

### GetCustomerShippingAddressesList

- **Signature**: `GetCustomerShippingAddressesList(string customerId, string? profileId, long? offset = 0L, long? limit = 20L, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
  - defaults: `offset` = `0L`, `limit` = `20L`
- **Query params (wire ← C#)**: `offset` ← `offset`, `limit` ← `limit`
- **Returns**: `ShippingAddressListForCustomer`
- **Error**: `SdkException<GetCustomerShippingAddressesListError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetCustomerShippingAddressesListException1(out GetCustomerShippingAddressesListException1)` [400] · `TryGetGetCustomerShippingAddressesListException21(out GetCustomerShippingAddressesListException21)` [403] · `TryGetGetCustomerShippingAddressesListException31(out GetCustomerShippingAddressesListException31)` [404] · `TryGetGetCustomerShippingAddressesListException41(out GetCustomerShippingAddressesListException41)` [410] · `TryGetGetCustomerShippingAddressesListException51(out GetCustomerShippingAddressesListException51)` [424] · `TryGetGetCustomerShippingAddressesListException61(out GetCustomerShippingAddressesListException61)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ShippingAddressListForCustomer` | `Models/ShippingAddressListForCustomer.cs` |
| `GetCustomerShippingAddressesListError` | `Errors/GetCustomerShippingAddressesListError.cs` |
| `GetCustomerShippingAddressesListException1` | `Models/GetCustomerShippingAddressesListException1.cs` |
| `GetCustomerShippingAddressesListException21` | `Models/GetCustomerShippingAddressesListException21.cs` |
| `GetCustomerShippingAddressesListException31` | `Models/GetCustomerShippingAddressesListException31.cs` |
| `GetCustomerShippingAddressesListException41` | `Models/GetCustomerShippingAddressesListException41.cs` |
| `GetCustomerShippingAddressesListException51` | `Models/GetCustomerShippingAddressesListException51.cs` |
| `GetCustomerShippingAddressesListException61` | `Models/GetCustomerShippingAddressesListException61.cs` |

### PatchCustomersShippingAddress

- **Signature**: `PatchCustomersShippingAddress(string customerId, string shippingAddressId, string? profileId, string? ifMatch, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
  - `ifMatch` — nullable, no default → **must pass explicitly**
- **Returns**: `PatchCustomersShippingAddressResponse`
- **Error**: `SdkException<PatchCustomersShippingAddressError>` — **Case A (typed)**
- **Error accessors**: `TryGetPatchCustomersShippingAddressException1(out PatchCustomersShippingAddressException1)` [400] · `TryGetPatchCustomersShippingAddressException21(out PatchCustomersShippingAddressException21)` [403] · `TryGetPatchCustomersShippingAddressException31(out PatchCustomersShippingAddressException31)` [404] · `TryGetPatchCustomersShippingAddressException41(out PatchCustomersShippingAddressException41)` [410] · `TryGetPatchCustomersShippingAddressException51(out PatchCustomersShippingAddressException51)` [412] · `TryGetPatchCustomersShippingAddressException61(out PatchCustomersShippingAddressException61)` [424] · `TryGetPatchCustomersShippingAddressException71(out PatchCustomersShippingAddressException71)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchCustomersShippingAddressResponse` | `Models/PatchCustomersShippingAddressResponse.cs` |
| `PatchCustomersShippingAddressError` | `Errors/PatchCustomersShippingAddressError.cs` |
| `PatchCustomersShippingAddressException1` | `Models/PatchCustomersShippingAddressException1.cs` |
| `PatchCustomersShippingAddressException21` | `Models/PatchCustomersShippingAddressException21.cs` |
| `PatchCustomersShippingAddressException31` | `Models/PatchCustomersShippingAddressException31.cs` |
| `PatchCustomersShippingAddressException41` | `Models/PatchCustomersShippingAddressException41.cs` |
| `PatchCustomersShippingAddressException51` | `Models/PatchCustomersShippingAddressException51.cs` |
| `PatchCustomersShippingAddressException61` | `Models/PatchCustomersShippingAddressException61.cs` |
| `PatchCustomersShippingAddressException71` | `Models/PatchCustomersShippingAddressException71.cs` |

### PostCustomerShippingAddress

- **Signature**: `PostCustomerShippingAddress(string customerId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `PostCustomerShippingAddressResponse`
- **Error**: `SdkException<PostCustomerShippingAddressError>` — **Case A (typed)**
- **Error accessors**: `TryGetPostCustomerShippingAddressException1(out PostCustomerShippingAddressException1)` [400] · `TryGetPostCustomerShippingAddressException21(out PostCustomerShippingAddressException21)` [403] · `TryGetPostCustomerShippingAddressException31(out PostCustomerShippingAddressException31)` [409] · `TryGetPostCustomerShippingAddressException41(out PostCustomerShippingAddressException41)` [424] · `TryGetPostCustomerShippingAddressException51(out PostCustomerShippingAddressException51)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCustomerShippingAddressResponse` | `Models/PostCustomerShippingAddressResponse.cs` |
| `PostCustomerShippingAddressError` | `Errors/PostCustomerShippingAddressError.cs` |
| `PostCustomerShippingAddressException1` | `Models/PostCustomerShippingAddressException1.cs` |
| `PostCustomerShippingAddressException21` | `Models/PostCustomerShippingAddressException21.cs` |
| `PostCustomerShippingAddressException31` | `Models/PostCustomerShippingAddressException31.cs` |
| `PostCustomerShippingAddressException41` | `Models/PostCustomerShippingAddressException41.cs` |
| `PostCustomerShippingAddressException51` | `Models/PostCustomerShippingAddressException51.cs` |

