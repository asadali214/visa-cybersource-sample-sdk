<!-- Generated file — do not edit; regenerated with the SDK. -->

# InstrumentIdentifierApi — operations

Accessor: `client.InstrumentIdentifierApi` · Source: `Api/InstrumentIdentifierApi.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteInstrumentIdentifier

- **Signature**: `DeleteInstrumentIdentifier(string instrumentIdentifierId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteInstrumentIdentifierError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeleteInstrumentIdentifierException1(out DeleteInstrumentIdentifierException1)` [403] · `TryGetDeleteInstrumentIdentifierException21(out DeleteInstrumentIdentifierException21)` [404] · `TryGetDeleteInstrumentIdentifierException31(out DeleteInstrumentIdentifierException31)` [409] · `TryGetDeleteInstrumentIdentifierException41(out DeleteInstrumentIdentifierException41)` [410] · `TryGetDeleteInstrumentIdentifierException51(out DeleteInstrumentIdentifierException51)` [424] · `TryGetDeleteInstrumentIdentifierException61(out DeleteInstrumentIdentifierException61)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteInstrumentIdentifierError` | `Errors/DeleteInstrumentIdentifierError.cs` |
| `DeleteInstrumentIdentifierException1` | `Models/DeleteInstrumentIdentifierException1.cs` |
| `DeleteInstrumentIdentifierException21` | `Models/DeleteInstrumentIdentifierException21.cs` |
| `DeleteInstrumentIdentifierException31` | `Models/DeleteInstrumentIdentifierException31.cs` |
| `DeleteInstrumentIdentifierException41` | `Models/DeleteInstrumentIdentifierException41.cs` |
| `DeleteInstrumentIdentifierException51` | `Models/DeleteInstrumentIdentifierException51.cs` |
| `DeleteInstrumentIdentifierException61` | `Models/DeleteInstrumentIdentifierException61.cs` |

### GetInstrumentIdentifier

- **Signature**: `GetInstrumentIdentifier(string instrumentIdentifierId, bool? retrieveBinDetails, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `retrieveBinDetails` — nullable, no default → **must pass explicitly**
  - `profileId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `retrieveBinDetails` ← `retrieveBinDetails`
- **Returns**: `GetInstrumentIdentifierResponse`
- **Error**: `SdkException<GetInstrumentIdentifierError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetInstrumentIdentifierException1(out GetInstrumentIdentifierException1)` [400] · `TryGetGetInstrumentIdentifierException21(out GetInstrumentIdentifierException21)` [403] · `TryGetGetInstrumentIdentifierException31(out GetInstrumentIdentifierException31)` [404] · `TryGetGetInstrumentIdentifierException41(out GetInstrumentIdentifierException41)` [410] · `TryGetGetInstrumentIdentifierException51(out GetInstrumentIdentifierException51)` [424] · `TryGetGetInstrumentIdentifierException61(out GetInstrumentIdentifierException61)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetInstrumentIdentifierResponse` | `Models/GetInstrumentIdentifierResponse.cs` |
| `GetInstrumentIdentifierError` | `Errors/GetInstrumentIdentifierError.cs` |
| `GetInstrumentIdentifierException1` | `Models/GetInstrumentIdentifierException1.cs` |
| `GetInstrumentIdentifierException21` | `Models/GetInstrumentIdentifierException21.cs` |
| `GetInstrumentIdentifierException31` | `Models/GetInstrumentIdentifierException31.cs` |
| `GetInstrumentIdentifierException41` | `Models/GetInstrumentIdentifierException41.cs` |
| `GetInstrumentIdentifierException51` | `Models/GetInstrumentIdentifierException51.cs` |
| `GetInstrumentIdentifierException61` | `Models/GetInstrumentIdentifierException61.cs` |

### GetInstrumentIdentifierPaymentInstrumentsList

- **Signature**: `GetInstrumentIdentifierPaymentInstrumentsList(string instrumentIdentifierId, bool? retrieveBinDetails, string? profileId, long? offset = 0L, long? limit = 20L, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `retrieveBinDetails` — nullable, no default → **must pass explicitly**
  - `profileId` — nullable, no default → **must pass explicitly**
  - defaults: `offset` = `0L`, `limit` = `20L`
- **Query params (wire ← C#)**: `retrieveBinDetails` ← `retrieveBinDetails`, `offset` ← `offset`, `limit` ← `limit`
- **Returns**: `PaymentInstrumentList`
- **Error**: `SdkException<GetInstrumentIdentifierPaymentInstrumentsListError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetInstrumentIdentifierPaymentInstrumentsListException1(out GetInstrumentIdentifierPaymentInstrumentsListException1)` [400] · `TryGetGetInstrumentIdentifierPaymentInstrumentsListException21(out GetInstrumentIdentifierPaymentInstrumentsListException21)` [403] · `TryGetGetInstrumentIdentifierPaymentInstrumentsListException31(out GetInstrumentIdentifierPaymentInstrumentsListException31)` [404] · `TryGetGetInstrumentIdentifierPaymentInstrumentsListException41(out GetInstrumentIdentifierPaymentInstrumentsListException41)` [410] · `TryGetGetInstrumentIdentifierPaymentInstrumentsListException51(out GetInstrumentIdentifierPaymentInstrumentsListException51)` [424] · `TryGetGetInstrumentIdentifierPaymentInstrumentsListException61(out GetInstrumentIdentifierPaymentInstrumentsListException61)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PaymentInstrumentList` | `Models/PaymentInstrumentList.cs` |
| `GetInstrumentIdentifierPaymentInstrumentsListError` | `Errors/GetInstrumentIdentifierPaymentInstrumentsListError.cs` |
| `GetInstrumentIdentifierPaymentInstrumentsListException1` | `Models/GetInstrumentIdentifierPaymentInstrumentsListException1.cs` |
| `GetInstrumentIdentifierPaymentInstrumentsListException21` | `Models/GetInstrumentIdentifierPaymentInstrumentsListException21.cs` |
| `GetInstrumentIdentifierPaymentInstrumentsListException31` | `Models/GetInstrumentIdentifierPaymentInstrumentsListException31.cs` |
| `GetInstrumentIdentifierPaymentInstrumentsListException41` | `Models/GetInstrumentIdentifierPaymentInstrumentsListException41.cs` |
| `GetInstrumentIdentifierPaymentInstrumentsListException51` | `Models/GetInstrumentIdentifierPaymentInstrumentsListException51.cs` |
| `GetInstrumentIdentifierPaymentInstrumentsListException61` | `Models/GetInstrumentIdentifierPaymentInstrumentsListException61.cs` |

### PatchInstrumentIdentifier

- **Signature**: `PatchInstrumentIdentifier(string instrumentIdentifierId, bool? retrieveBinDetails, string? profileId, string? ifMatch, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `retrieveBinDetails` — nullable, no default → **must pass explicitly**
  - `profileId` — nullable, no default → **must pass explicitly**
  - `ifMatch` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `retrieveBinDetails` ← `retrieveBinDetails`
- **Returns**: `PatchInstrumentIdentifierResponse`
- **Error**: `SdkException<PatchInstrumentIdentifierError>` — **Case A (typed)**
- **Error accessors**: `TryGetPatchInstrumentIdentifierException1(out PatchInstrumentIdentifierException1)` [400] · `TryGetPatchInstrumentIdentifierException21(out PatchInstrumentIdentifierException21)` [403] · `TryGetPatchInstrumentIdentifierException31(out PatchInstrumentIdentifierException31)` [404] · `TryGetPatchInstrumentIdentifierException41(out PatchInstrumentIdentifierException41)` [410] · `TryGetPatchInstrumentIdentifierException51(out PatchInstrumentIdentifierException51)` [412] · `TryGetPatchInstrumentIdentifierException61(out PatchInstrumentIdentifierException61)` [424] · `TryGetPatchInstrumentIdentifierException71(out PatchInstrumentIdentifierException71)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchInstrumentIdentifierResponse` | `Models/PatchInstrumentIdentifierResponse.cs` |
| `PatchInstrumentIdentifierError` | `Errors/PatchInstrumentIdentifierError.cs` |
| `PatchInstrumentIdentifierException1` | `Models/PatchInstrumentIdentifierException1.cs` |
| `PatchInstrumentIdentifierException21` | `Models/PatchInstrumentIdentifierException21.cs` |
| `PatchInstrumentIdentifierException31` | `Models/PatchInstrumentIdentifierException31.cs` |
| `PatchInstrumentIdentifierException41` | `Models/PatchInstrumentIdentifierException41.cs` |
| `PatchInstrumentIdentifierException51` | `Models/PatchInstrumentIdentifierException51.cs` |
| `PatchInstrumentIdentifierException61` | `Models/PatchInstrumentIdentifierException61.cs` |
| `PatchInstrumentIdentifierException71` | `Models/PatchInstrumentIdentifierException71.cs` |

### PostInstrumentIdentifier

- **Signature**: `PostInstrumentIdentifier(bool? retrieveBinDetails, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `retrieveBinDetails` — nullable, no default → **must pass explicitly**
  - `profileId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `retrieveBinDetails` ← `retrieveBinDetails`
- **Returns**: `PostInstrumentIdentifierResponse`
- **Error**: `SdkException<PostInstrumentIdentifierError>` — **Case A (typed)**
- **Error accessors**: `TryGetPostInstrumentIdentifierException1(out PostInstrumentIdentifierException1)` [400] · `TryGetPostInstrumentIdentifierException21(out PostInstrumentIdentifierException21)` [403] · `TryGetPostInstrumentIdentifierException31(out PostInstrumentIdentifierException31)` [409] · `TryGetPostInstrumentIdentifierException41(out PostInstrumentIdentifierException41)` [424] · `TryGetPostInstrumentIdentifierException51(out PostInstrumentIdentifierException51)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostInstrumentIdentifierResponse` | `Models/PostInstrumentIdentifierResponse.cs` |
| `PostInstrumentIdentifierError` | `Errors/PostInstrumentIdentifierError.cs` |
| `PostInstrumentIdentifierException1` | `Models/PostInstrumentIdentifierException1.cs` |
| `PostInstrumentIdentifierException21` | `Models/PostInstrumentIdentifierException21.cs` |
| `PostInstrumentIdentifierException31` | `Models/PostInstrumentIdentifierException31.cs` |
| `PostInstrumentIdentifierException41` | `Models/PostInstrumentIdentifierException41.cs` |
| `PostInstrumentIdentifierException51` | `Models/PostInstrumentIdentifierException51.cs` |

### PostInstrumentIdentifierEnrollment

- **Signature**: `PostInstrumentIdentifierEnrollment(string instrumentIdentifierId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `profileId` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<PostInstrumentIdentifierEnrollmentError>` — **Case A (typed)**
- **Error accessors**: `TryGetPostInstrumentIdentifierEnrollmentException1(out PostInstrumentIdentifierEnrollmentException1)` [400] · `TryGetPostInstrumentIdentifierEnrollmentException21(out PostInstrumentIdentifierEnrollmentException21)` [403] · `TryGetPostInstrumentIdentifierEnrollmentException31(out PostInstrumentIdentifierEnrollmentException31)` [404] · `TryGetPostInstrumentIdentifierEnrollmentException41(out PostInstrumentIdentifierEnrollmentException41)` [410] · `TryGetPostInstrumentIdentifierEnrollmentException51(out PostInstrumentIdentifierEnrollmentException51)` [424] · `TryGetPostInstrumentIdentifierEnrollmentException61(out PostInstrumentIdentifierEnrollmentException61)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostInstrumentIdentifierEnrollmentError` | `Errors/PostInstrumentIdentifierEnrollmentError.cs` |
| `PostInstrumentIdentifierEnrollmentException1` | `Models/PostInstrumentIdentifierEnrollmentException1.cs` |
| `PostInstrumentIdentifierEnrollmentException21` | `Models/PostInstrumentIdentifierEnrollmentException21.cs` |
| `PostInstrumentIdentifierEnrollmentException31` | `Models/PostInstrumentIdentifierEnrollmentException31.cs` |
| `PostInstrumentIdentifierEnrollmentException41` | `Models/PostInstrumentIdentifierEnrollmentException41.cs` |
| `PostInstrumentIdentifierEnrollmentException51` | `Models/PostInstrumentIdentifierEnrollmentException51.cs` |
| `PostInstrumentIdentifierEnrollmentException61` | `Models/PostInstrumentIdentifierEnrollmentException61.cs` |

