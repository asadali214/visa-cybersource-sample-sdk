<!-- Generated file — do not edit; regenerated with the SDK. -->

# Verification — operations

Accessor: `client.Verification` · Source: `Api/Verification.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ValidateExportCompliance

- **Signature**: `ValidateExportCompliance(ValidateExportComplianceRequest validateExportComplianceRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<ValidateExportComplianceError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ValidateExportComplianceRequest` | `Models/ValidateExportComplianceRequest.cs` |
| `ValidateExportComplianceError` | `Errors/ValidateExportComplianceError.cs` |

### VerifyCustomerAddress

- **Signature**: `VerifyCustomerAddress(VerifyCustomerAddressRequest verifyCustomerAddressRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<VerifyCustomerAddressError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VerifyCustomerAddressRequest` | `Models/VerifyCustomerAddressRequest.cs` |
| `VerifyCustomerAddressError` | `Errors/VerifyCustomerAddressError.cs` |

