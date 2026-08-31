<!-- Generated file — do not edit; regenerated with the SDK. -->

# PullFundsApi — operations

Accessor: `client.PullFundsApi` · Source: `Api/PullFundsApi.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreatePullFundsRefund

- **Signature**: `CreatePullFundsRefund(string id, string contentType, string xRequestid, string vcMerchantId, string vcPermissions, string vcCorrelationId, string vcOrganizationId, PullFundsRefundRequest pullFundsRefundRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CreatePullFundsRefundError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 401, 404, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PullFundsRefundRequest` | `Models/PullFundsRefundRequest.cs` |
| `CreatePullFundsRefundError` | `Errors/CreatePullFundsRefundError.cs` |

### CreatePullFundsReversal

- **Signature**: `CreatePullFundsReversal(string id, string contentType, string xRequestid, string vcMerchantId, string vcPermissions, string vcCorrelationId, string vcOrganizationId, PullFundsReversalRequest pullFundsReversalRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CreatePullFundsReversalError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 401, 404, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PullFundsReversalRequest` | `Models/PullFundsReversalRequest.cs` |
| `CreatePullFundsReversalError` | `Errors/CreatePullFundsReversalError.cs` |

### CreatePullFundsTransfer

- **Signature**: `CreatePullFundsTransfer(string contentType, string xRequestid, string vcMerchantId, string vcPermissions, string vcCorrelationId, string vcOrganizationId, PullFundsRequest pullFundsRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CreatePullFundsTransferError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 401, 404, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PullFundsRequest` | `Models/PullFundsRequest.cs` |
| `CreatePullFundsTransferError` | `Errors/CreatePullFundsTransferError.cs` |

