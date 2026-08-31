<!-- Generated file — do not edit; regenerated with the SDK. -->

# PayerAuthentication — operations

Accessor: `client.PayerAuthentication` · Source: `Api/PayerAuthentication.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CheckPayerAuthEnrollment

- **Signature**: `CheckPayerAuthEnrollment(CheckPayerAuthEnrollmentRequest checkPayerAuthEnrollmentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CheckPayerAuthEnrollmentError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckPayerAuthEnrollmentRequest` | `Models/CheckPayerAuthEnrollmentRequest.cs` |
| `CheckPayerAuthEnrollmentError` | `Errors/CheckPayerAuthEnrollmentError.cs` |

### PayerAuthSetup

- **Signature**: `PayerAuthSetup(PayerAuthSetupRequest payerAuthSetupRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<PayerAuthSetupError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PayerAuthSetupRequest` | `Models/PayerAuthSetupRequest.cs` |
| `PayerAuthSetupError` | `Errors/PayerAuthSetupError.cs` |

### ValidateAuthenticationResults

- **Signature**: `ValidateAuthenticationResults(ValidateRequest validateRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<ValidateAuthenticationResultsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ValidateRequest` | `Models/ValidateRequest.cs` |
| `ValidateAuthenticationResultsError` | `Errors/ValidateAuthenticationResultsError.cs` |

