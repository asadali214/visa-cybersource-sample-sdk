<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentInstrumentApi — operations

Accessor: `client.PaymentInstrumentApi` · Source: `Api/PaymentInstrumentApi.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeletePaymentInstrument

- **Signature**: `DeletePaymentInstrument(string paymentInstrumentId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeletePaymentInstrumentError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeletePaymentInstrumentException1(out DeletePaymentInstrumentException1)` [403] · `TryGetDeletePaymentInstrumentException21(out DeletePaymentInstrumentException21)` [404] · `TryGetDeletePaymentInstrumentException31(out DeletePaymentInstrumentException31)` [410] · `TryGetDeletePaymentInstrumentException41(out DeletePaymentInstrumentException41)` [424] · `TryGetDeletePaymentInstrumentException51(out DeletePaymentInstrumentException51)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePaymentInstrumentError` | `Errors/DeletePaymentInstrumentError.cs` |
| `DeletePaymentInstrumentException1` | `Models/DeletePaymentInstrumentException1.cs` |
| `DeletePaymentInstrumentException21` | `Models/DeletePaymentInstrumentException21.cs` |
| `DeletePaymentInstrumentException31` | `Models/DeletePaymentInstrumentException31.cs` |
| `DeletePaymentInstrumentException41` | `Models/DeletePaymentInstrumentException41.cs` |
| `DeletePaymentInstrumentException51` | `Models/DeletePaymentInstrumentException51.cs` |

### GetPaymentInstrument

- **Signature**: `GetPaymentInstrument(string paymentInstrumentId, bool? retrieveBinDetails, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `retrieveBinDetails` — nullable, no default → **must pass explicitly**
  - `profileId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `retrieveBinDetails` ← `retrieveBinDetails`
- **Returns**: `PaymentInstrument11`
- **Error**: `SdkException<GetPaymentInstrumentError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetPaymentInstrumentException1(out GetPaymentInstrumentException1)` [400] · `TryGetGetPaymentInstrumentException21(out GetPaymentInstrumentException21)` [403] · `TryGetGetPaymentInstrumentException31(out GetPaymentInstrumentException31)` [404] · `TryGetGetPaymentInstrumentException41(out GetPaymentInstrumentException41)` [410] · `TryGetGetPaymentInstrumentException51(out GetPaymentInstrumentException51)` [424] · `TryGetGetPaymentInstrumentException61(out GetPaymentInstrumentException61)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PaymentInstrument11` | `Models/PaymentInstrument11.cs` |
| `GetPaymentInstrumentError` | `Errors/GetPaymentInstrumentError.cs` |
| `GetPaymentInstrumentException1` | `Models/GetPaymentInstrumentException1.cs` |
| `GetPaymentInstrumentException21` | `Models/GetPaymentInstrumentException21.cs` |
| `GetPaymentInstrumentException31` | `Models/GetPaymentInstrumentException31.cs` |
| `GetPaymentInstrumentException41` | `Models/GetPaymentInstrumentException41.cs` |
| `GetPaymentInstrumentException51` | `Models/GetPaymentInstrumentException51.cs` |
| `GetPaymentInstrumentException61` | `Models/GetPaymentInstrumentException61.cs` |

### PatchPaymentInstrument

- **Signature**: `PatchPaymentInstrument(string paymentInstrumentId, bool? retrieveBinDetails, string? profileId, string? ifMatch, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `retrieveBinDetails` — nullable, no default → **must pass explicitly**
  - `profileId` — nullable, no default → **must pass explicitly**
  - `ifMatch` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `retrieveBinDetails` ← `retrieveBinDetails`
- **Returns**: `PaymentInstrument11`
- **Error**: `SdkException<PatchPaymentInstrumentError>` — **Case A (typed)**
- **Error accessors**: `TryGetPatchPaymentInstrumentException1(out PatchPaymentInstrumentException1)` [400] · `TryGetPatchPaymentInstrumentException21(out PatchPaymentInstrumentException21)` [403] · `TryGetPatchPaymentInstrumentException31(out PatchPaymentInstrumentException31)` [404] · `TryGetPatchPaymentInstrumentException41(out PatchPaymentInstrumentException41)` [410] · `TryGetPatchPaymentInstrumentException51(out PatchPaymentInstrumentException51)` [412] · `TryGetPatchPaymentInstrumentException61(out PatchPaymentInstrumentException61)` [424] · `TryGetPatchPaymentInstrumentException71(out PatchPaymentInstrumentException71)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PaymentInstrument11` | `Models/PaymentInstrument11.cs` |
| `PatchPaymentInstrumentError` | `Errors/PatchPaymentInstrumentError.cs` |
| `PatchPaymentInstrumentException1` | `Models/PatchPaymentInstrumentException1.cs` |
| `PatchPaymentInstrumentException21` | `Models/PatchPaymentInstrumentException21.cs` |
| `PatchPaymentInstrumentException31` | `Models/PatchPaymentInstrumentException31.cs` |
| `PatchPaymentInstrumentException41` | `Models/PatchPaymentInstrumentException41.cs` |
| `PatchPaymentInstrumentException51` | `Models/PatchPaymentInstrumentException51.cs` |
| `PatchPaymentInstrumentException61` | `Models/PatchPaymentInstrumentException61.cs` |
| `PatchPaymentInstrumentException71` | `Models/PatchPaymentInstrumentException71.cs` |

### PostPaymentInstrument

- **Signature**: `PostPaymentInstrument(bool? retrieveBinDetails, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `retrieveBinDetails` — nullable, no default → **must pass explicitly**
  - `profileId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `retrieveBinDetails` ← `retrieveBinDetails`
- **Returns**: `PaymentInstrument11`
- **Error**: `SdkException<PostPaymentInstrumentError>` — **Case A (typed)**
- **Error accessors**: `TryGetPostPaymentInstrumentException1(out PostPaymentInstrumentException1)` [400] · `TryGetPostPaymentInstrumentException21(out PostPaymentInstrumentException21)` [403] · `TryGetPostPaymentInstrumentException31(out PostPaymentInstrumentException31)` [409] · `TryGetPostPaymentInstrumentException41(out PostPaymentInstrumentException41)` [424] · `TryGetPostPaymentInstrumentException51(out PostPaymentInstrumentException51)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PaymentInstrument11` | `Models/PaymentInstrument11.cs` |
| `PostPaymentInstrumentError` | `Errors/PostPaymentInstrumentError.cs` |
| `PostPaymentInstrumentException1` | `Models/PostPaymentInstrumentException1.cs` |
| `PostPaymentInstrumentException21` | `Models/PostPaymentInstrumentException21.cs` |
| `PostPaymentInstrumentException31` | `Models/PostPaymentInstrumentException31.cs` |
| `PostPaymentInstrumentException41` | `Models/PostPaymentInstrumentException41.cs` |
| `PostPaymentInstrumentException51` | `Models/PostPaymentInstrumentException51.cs` |

