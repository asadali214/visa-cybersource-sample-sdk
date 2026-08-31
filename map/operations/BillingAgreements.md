<!-- Generated file — do not edit; regenerated with the SDK. -->

# BillingAgreements — operations

Accessor: `client.BillingAgreements` · Source: `Api/BillingAgreements.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BillingAgreementsDeRegistration

- **Signature**: `BillingAgreementsDeRegistration(string id, ModifyBillingAgreement modifyBillingAgreement, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<BillingAgreementsDeRegistrationError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ModifyBillingAgreement` | `Models/ModifyBillingAgreement.cs` |
| `BillingAgreementsDeRegistrationError` | `Errors/BillingAgreementsDeRegistrationError.cs` |

### BillingAgreementsIntimation

- **Signature**: `BillingAgreementsIntimation(string id, IntimateBillingAgreement intimateBillingAgreement, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<BillingAgreementsIntimationError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `IntimateBillingAgreement` | `Models/IntimateBillingAgreement.cs` |
| `BillingAgreementsIntimationError` | `Errors/BillingAgreementsIntimationError.cs` |

### BillingAgreementsRegistration

- **Signature**: `BillingAgreementsRegistration(CreateBillingAgreement createBillingAgreement, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<BillingAgreementsRegistrationError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateBillingAgreement` | `Models/CreateBillingAgreement.cs` |
| `BillingAgreementsRegistrationError` | `Errors/BillingAgreementsRegistrationError.cs` |

