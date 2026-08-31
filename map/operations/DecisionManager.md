<!-- Generated file — do not edit; regenerated with the SDK. -->

# DecisionManager — operations

Accessor: `client.DecisionManager` · Source: `Api/DecisionManager.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActionDecisionManagerCase

- **Signature**: `ActionDecisionManagerCase(string id, CaseManagementActionsRequest caseManagementActionsRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ActionDecisionManagerCaseResponse`
- **Error**: `SdkException<ActionDecisionManagerCaseError>` — **Case A (typed)**
- **Error accessors**: `TryGetActionDecisionManagerCaseException1(out ActionDecisionManagerCaseException1)` [400] · `TryGetActionDecisionManagerCaseException21(out ActionDecisionManagerCaseException21)` [403] · `TryGetActionDecisionManagerCaseException31(out ActionDecisionManagerCaseException31)` [422] · `TryGetActionDecisionManagerCaseException41(out ActionDecisionManagerCaseException41)` [500] · `TryGetActionDecisionManagerCaseException51(out ActionDecisionManagerCaseException51)` [502] · `TryGetActionDecisionManagerCaseException61(out ActionDecisionManagerCaseException61)` [503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CaseManagementActionsRequest` | `Models/CaseManagementActionsRequest.cs` |
| `ActionDecisionManagerCaseResponse` | `Models/ActionDecisionManagerCaseResponse.cs` |
| `ActionDecisionManagerCaseError` | `Errors/ActionDecisionManagerCaseError.cs` |
| `ActionDecisionManagerCaseException1` | `Models/ActionDecisionManagerCaseException1.cs` |
| `ActionDecisionManagerCaseException21` | `Models/ActionDecisionManagerCaseException21.cs` |
| `ActionDecisionManagerCaseException31` | `Models/ActionDecisionManagerCaseException31.cs` |
| `ActionDecisionManagerCaseException41` | `Models/ActionDecisionManagerCaseException41.cs` |
| `ActionDecisionManagerCaseException51` | `Models/ActionDecisionManagerCaseException51.cs` |
| `ActionDecisionManagerCaseException61` | `Models/ActionDecisionManagerCaseException61.cs` |

### AddNegative

- **Signature**: `AddNegative(string type, AddNegativeListRequest addNegativeListRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddNegativeError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddNegativeListRequest` | `Models/AddNegativeListRequest.cs` |
| `AddNegativeError` | `Errors/AddNegativeError.cs` |

### CommentDecisionManagerCase

- **Signature**: `CommentDecisionManagerCase(string id, CaseManagementCommentsRequest caseManagementCommentsRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CommentDecisionManagerCaseResponse`
- **Error**: `SdkException<CommentDecisionManagerCaseError>` — **Case A (typed)**
- **Error accessors**: `TryGetCommentDecisionManagerCaseException1(out CommentDecisionManagerCaseException1)` [400] · `TryGetCommentDecisionManagerCaseException21(out CommentDecisionManagerCaseException21)` [403] · `TryGetCommentDecisionManagerCaseException31(out CommentDecisionManagerCaseException31)` [422] · `TryGetCommentDecisionManagerCaseException41(out CommentDecisionManagerCaseException41)` [500] · `TryGetCommentDecisionManagerCaseException51(out CommentDecisionManagerCaseException51)` [502] · `TryGetCommentDecisionManagerCaseException61(out CommentDecisionManagerCaseException61)` [503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CaseManagementCommentsRequest` | `Models/CaseManagementCommentsRequest.cs` |
| `CommentDecisionManagerCaseResponse` | `Models/CommentDecisionManagerCaseResponse.cs` |
| `CommentDecisionManagerCaseError` | `Errors/CommentDecisionManagerCaseError.cs` |
| `CommentDecisionManagerCaseException1` | `Models/CommentDecisionManagerCaseException1.cs` |
| `CommentDecisionManagerCaseException21` | `Models/CommentDecisionManagerCaseException21.cs` |
| `CommentDecisionManagerCaseException31` | `Models/CommentDecisionManagerCaseException31.cs` |
| `CommentDecisionManagerCaseException41` | `Models/CommentDecisionManagerCaseException41.cs` |
| `CommentDecisionManagerCaseException51` | `Models/CommentDecisionManagerCaseException51.cs` |
| `CommentDecisionManagerCaseException61` | `Models/CommentDecisionManagerCaseException61.cs` |

### CreateBundledDecisionManagerCase

- **Signature**: `CreateBundledDecisionManagerCase(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CreateBundledDecisionManagerCaseError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateBundledDecisionManagerCaseError` | `Errors/CreateBundledDecisionManagerCaseError.cs` |

### FraudUpdate

- **Signature**: `FraudUpdate(string id, FraudMarkingActionRequest fraudMarkingActionRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<FraudUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `FraudMarkingActionRequest` | `Models/FraudMarkingActionRequest.cs` |
| `FraudUpdateError` | `Errors/FraudUpdateError.cs` |

