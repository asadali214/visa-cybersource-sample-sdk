<!-- Generated file — do not edit; regenerated with the SDK. -->

# CustomerPaymentInstrument — operations

Accessor: `client.CustomerPaymentInstrument` · Source: `Api/CustomerPaymentInstrument.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteCustomerPaymentInstrument

- **Signature**: `DeleteCustomerPaymentInstrument(string customerId, string paymentInstrumentId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteCustomerPaymentInstrumentError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeleteCustomerPaymentInstrumentException1(out DeleteCustomerPaymentInstrumentException1)` [400] · `TryGetDeleteCustomerPaymentInstrumentException21(out DeleteCustomerPaymentInstrumentException21)` [403] · `TryGetDeleteCustomerPaymentInstrumentException31(out DeleteCustomerPaymentInstrumentException31)` [404] · `TryGetDeleteCustomerPaymentInstrumentException41(out DeleteCustomerPaymentInstrumentException41)` [409] · `TryGetDeleteCustomerPaymentInstrumentException51(out DeleteCustomerPaymentInstrumentException51)` [410] · `TryGetDeleteCustomerPaymentInstrumentException61(out DeleteCustomerPaymentInstrumentException61)` [424] · `TryGetDeleteCustomerPaymentInstrumentException71(out DeleteCustomerPaymentInstrumentException71)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCustomerPaymentInstrumentError` | `Errors/DeleteCustomerPaymentInstrumentError.cs` |
| `DeleteCustomerPaymentInstrumentException1` | `Models/DeleteCustomerPaymentInstrumentException1.cs` |
| `DeleteCustomerPaymentInstrumentException21` | `Models/DeleteCustomerPaymentInstrumentException21.cs` |
| `DeleteCustomerPaymentInstrumentException31` | `Models/DeleteCustomerPaymentInstrumentException31.cs` |
| `DeleteCustomerPaymentInstrumentException41` | `Models/DeleteCustomerPaymentInstrumentException41.cs` |
| `DeleteCustomerPaymentInstrumentException51` | `Models/DeleteCustomerPaymentInstrumentException51.cs` |
| `DeleteCustomerPaymentInstrumentException61` | `Models/DeleteCustomerPaymentInstrumentException61.cs` |
| `DeleteCustomerPaymentInstrumentException71` | `Models/DeleteCustomerPaymentInstrumentException71.cs` |

### GetCustomerPaymentInstrument

- **Signature**: `GetCustomerPaymentInstrument(string customerId, string paymentInstrumentId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `PaymentInstrument11`
- **Error**: `SdkException<GetCustomerPaymentInstrumentError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetCustomerPaymentInstrumentException1(out GetCustomerPaymentInstrumentException1)` [400] · `TryGetGetCustomerPaymentInstrumentException21(out GetCustomerPaymentInstrumentException21)` [403] · `TryGetGetCustomerPaymentInstrumentException31(out GetCustomerPaymentInstrumentException31)` [404] · `TryGetGetCustomerPaymentInstrumentException41(out GetCustomerPaymentInstrumentException41)` [410] · `TryGetGetCustomerPaymentInstrumentException51(out GetCustomerPaymentInstrumentException51)` [424] · `TryGetGetCustomerPaymentInstrumentException61(out GetCustomerPaymentInstrumentException61)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PaymentInstrument11` | `Models/PaymentInstrument11.cs` |
| `GetCustomerPaymentInstrumentError` | `Errors/GetCustomerPaymentInstrumentError.cs` |
| `GetCustomerPaymentInstrumentException1` | `Models/GetCustomerPaymentInstrumentException1.cs` |
| `GetCustomerPaymentInstrumentException21` | `Models/GetCustomerPaymentInstrumentException21.cs` |
| `GetCustomerPaymentInstrumentException31` | `Models/GetCustomerPaymentInstrumentException31.cs` |
| `GetCustomerPaymentInstrumentException41` | `Models/GetCustomerPaymentInstrumentException41.cs` |
| `GetCustomerPaymentInstrumentException51` | `Models/GetCustomerPaymentInstrumentException51.cs` |
| `GetCustomerPaymentInstrumentException61` | `Models/GetCustomerPaymentInstrumentException61.cs` |

### GetCustomerPaymentInstrumentsList

- **Signature**: `GetCustomerPaymentInstrumentsList(string customerId, string? profileId, long? offset = 0L, long? limit = 20L, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
  - defaults: `offset` = `0L`, `limit` = `20L`
- **Query params (wire ← C#)**: `offset` ← `offset`, `limit` ← `limit`
- **Returns**: `PaymentInstrumentList`
- **Error**: `SdkException<GetCustomerPaymentInstrumentsListError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetCustomerPaymentInstrumentsListException1(out GetCustomerPaymentInstrumentsListException1)` [400] · `TryGetGetCustomerPaymentInstrumentsListException21(out GetCustomerPaymentInstrumentsListException21)` [403] · `TryGetGetCustomerPaymentInstrumentsListException31(out GetCustomerPaymentInstrumentsListException31)` [404] · `TryGetGetCustomerPaymentInstrumentsListException41(out GetCustomerPaymentInstrumentsListException41)` [410] · `TryGetGetCustomerPaymentInstrumentsListException51(out GetCustomerPaymentInstrumentsListException51)` [424] · `TryGetGetCustomerPaymentInstrumentsListException61(out GetCustomerPaymentInstrumentsListException61)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PaymentInstrumentList` | `Models/PaymentInstrumentList.cs` |
| `GetCustomerPaymentInstrumentsListError` | `Errors/GetCustomerPaymentInstrumentsListError.cs` |
| `GetCustomerPaymentInstrumentsListException1` | `Models/GetCustomerPaymentInstrumentsListException1.cs` |
| `GetCustomerPaymentInstrumentsListException21` | `Models/GetCustomerPaymentInstrumentsListException21.cs` |
| `GetCustomerPaymentInstrumentsListException31` | `Models/GetCustomerPaymentInstrumentsListException31.cs` |
| `GetCustomerPaymentInstrumentsListException41` | `Models/GetCustomerPaymentInstrumentsListException41.cs` |
| `GetCustomerPaymentInstrumentsListException51` | `Models/GetCustomerPaymentInstrumentsListException51.cs` |
| `GetCustomerPaymentInstrumentsListException61` | `Models/GetCustomerPaymentInstrumentsListException61.cs` |

### PatchCustomersPaymentInstrument

- **Signature**: `PatchCustomersPaymentInstrument(string customerId, string paymentInstrumentId, string? profileId, string? ifMatch, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
  - `ifMatch` — nullable, no default → **must pass explicitly**
- **Returns**: `PaymentInstrument11`
- **Error**: `SdkException<PatchCustomersPaymentInstrumentError>` — **Case A (typed)**
- **Error accessors**: `TryGetPatchCustomersPaymentInstrumentException1(out PatchCustomersPaymentInstrumentException1)` [400] · `TryGetPatchCustomersPaymentInstrumentException21(out PatchCustomersPaymentInstrumentException21)` [403] · `TryGetPatchCustomersPaymentInstrumentException31(out PatchCustomersPaymentInstrumentException31)` [404] · `TryGetPatchCustomersPaymentInstrumentException41(out PatchCustomersPaymentInstrumentException41)` [410] · `TryGetPatchCustomersPaymentInstrumentException51(out PatchCustomersPaymentInstrumentException51)` [412] · `TryGetPatchCustomersPaymentInstrumentException61(out PatchCustomersPaymentInstrumentException61)` [424] · `TryGetPatchCustomersPaymentInstrumentException71(out PatchCustomersPaymentInstrumentException71)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PaymentInstrument11` | `Models/PaymentInstrument11.cs` |
| `PatchCustomersPaymentInstrumentError` | `Errors/PatchCustomersPaymentInstrumentError.cs` |
| `PatchCustomersPaymentInstrumentException1` | `Models/PatchCustomersPaymentInstrumentException1.cs` |
| `PatchCustomersPaymentInstrumentException21` | `Models/PatchCustomersPaymentInstrumentException21.cs` |
| `PatchCustomersPaymentInstrumentException31` | `Models/PatchCustomersPaymentInstrumentException31.cs` |
| `PatchCustomersPaymentInstrumentException41` | `Models/PatchCustomersPaymentInstrumentException41.cs` |
| `PatchCustomersPaymentInstrumentException51` | `Models/PatchCustomersPaymentInstrumentException51.cs` |
| `PatchCustomersPaymentInstrumentException61` | `Models/PatchCustomersPaymentInstrumentException61.cs` |
| `PatchCustomersPaymentInstrumentException71` | `Models/PatchCustomersPaymentInstrumentException71.cs` |

### PostCustomerPaymentInstrument

- **Signature**: `PostCustomerPaymentInstrument(string customerId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `PaymentInstrument11`
- **Error**: `SdkException<PostCustomerPaymentInstrumentError>` — **Case A (typed)**
- **Error accessors**: `TryGetPostCustomerPaymentInstrumentException1(out PostCustomerPaymentInstrumentException1)` [400] · `TryGetPostCustomerPaymentInstrumentException21(out PostCustomerPaymentInstrumentException21)` [403] · `TryGetPostCustomerPaymentInstrumentException31(out PostCustomerPaymentInstrumentException31)` [409] · `TryGetPostCustomerPaymentInstrumentException41(out PostCustomerPaymentInstrumentException41)` [424] · `TryGetPostCustomerPaymentInstrumentException51(out PostCustomerPaymentInstrumentException51)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PaymentInstrument11` | `Models/PaymentInstrument11.cs` |
| `PostCustomerPaymentInstrumentError` | `Errors/PostCustomerPaymentInstrumentError.cs` |
| `PostCustomerPaymentInstrumentException1` | `Models/PostCustomerPaymentInstrumentException1.cs` |
| `PostCustomerPaymentInstrumentException21` | `Models/PostCustomerPaymentInstrumentException21.cs` |
| `PostCustomerPaymentInstrumentException31` | `Models/PostCustomerPaymentInstrumentException31.cs` |
| `PostCustomerPaymentInstrumentException41` | `Models/PostCustomerPaymentInstrumentException41.cs` |
| `PostCustomerPaymentInstrumentException51` | `Models/PostCustomerPaymentInstrumentException51.cs` |

