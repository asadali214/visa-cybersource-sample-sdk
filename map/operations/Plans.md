<!-- Generated file — do not edit; regenerated with the SDK. -->

# Plans — operations

Accessor: `client.Plans` · Source: `Api/Plans.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivatePlan

- **Signature**: `ActivatePlan(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ActivateDeactivatePlanResponse`
- **Error**: `SdkException<ActivatePlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetActivatePlanException1(out ActivatePlanException1)` [400] · `TryGetActivatePlanException21(out ActivatePlanException21)` [404] · `TryGetActivatePlanException31(out ActivatePlanException31)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ActivateDeactivatePlanResponse` | `Models/ActivateDeactivatePlanResponse.cs` |
| `ActivatePlanError` | `Errors/ActivatePlanError.cs` |
| `ActivatePlanException1` | `Models/ActivatePlanException1.cs` |
| `ActivatePlanException21` | `Models/ActivatePlanException21.cs` |
| `ActivatePlanException31` | `Models/ActivatePlanException31.cs` |

### CreatePlan

- **Signature**: `CreatePlan(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreatePlanResponse`
- **Error**: `SdkException<CreatePlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetCreatePlanException1(out CreatePlanException1)` [400] · `TryGetCreatePlanException21(out CreatePlanException21)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreatePlanResponse` | `Models/CreatePlanResponse.cs` |
| `CreatePlanError` | `Errors/CreatePlanError.cs` |
| `CreatePlanException1` | `Models/CreatePlanException1.cs` |
| `CreatePlanException21` | `Models/CreatePlanException21.cs` |

### DeactivatePlan

- **Signature**: `DeactivatePlan(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ActivateDeactivatePlanResponse`
- **Error**: `SdkException<DeactivatePlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeactivatePlanException1(out DeactivatePlanException1)` [400] · `TryGetDeactivatePlanException21(out DeactivatePlanException21)` [404] · `TryGetDeactivatePlanException31(out DeactivatePlanException31)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ActivateDeactivatePlanResponse` | `Models/ActivateDeactivatePlanResponse.cs` |
| `DeactivatePlanError` | `Errors/DeactivatePlanError.cs` |
| `DeactivatePlanException1` | `Models/DeactivatePlanException1.cs` |
| `DeactivatePlanException21` | `Models/DeactivatePlanException21.cs` |
| `DeactivatePlanException31` | `Models/DeactivatePlanException31.cs` |

### DeletePlan

- **Signature**: `DeletePlan(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DeletePlanResponse`
- **Error**: `SdkException<DeletePlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetDeletePlanException1(out DeletePlanException1)` [400] · `TryGetDeletePlanException21(out DeletePlanException21)` [404] · `TryGetDeletePlanException31(out DeletePlanException31)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePlanResponse` | `Models/DeletePlanResponse.cs` |
| `DeletePlanError` | `Errors/DeletePlanError.cs` |
| `DeletePlanException1` | `Models/DeletePlanException1.cs` |
| `DeletePlanException21` | `Models/DeletePlanException21.cs` |
| `DeletePlanException31` | `Models/DeletePlanException31.cs` |

### GetPlan

- **Signature**: `GetPlan(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetPlanResponse`
- **Error**: `SdkException<GetPlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetPlanException1(out GetPlanException1)` [400] · `TryGetGetPlanException21(out GetPlanException21)` [404] · `TryGetGetPlanException31(out GetPlanException31)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPlanResponse` | `Models/GetPlanResponse.cs` |
| `GetPlanError` | `Errors/GetPlanError.cs` |
| `GetPlanException1` | `Models/GetPlanException1.cs` |
| `GetPlanException21` | `Models/GetPlanException21.cs` |
| `GetPlanException31` | `Models/GetPlanException31.cs` |

### GetPlanCode

- **Signature**: `GetPlanCode(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetPlanCodeResponse`
- **Error**: `SdkException<GetPlanCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetPlanCodeException1(out GetPlanCodeException1)` [400] · `TryGetGetPlanCodeException21(out GetPlanCodeException21)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPlanCodeResponse` | `Models/GetPlanCodeResponse.cs` |
| `GetPlanCodeError` | `Errors/GetPlanCodeError.cs` |
| `GetPlanCodeException1` | `Models/GetPlanCodeException1.cs` |
| `GetPlanCodeException21` | `Models/GetPlanCodeException21.cs` |

### GetPlans

- **Signature**: `GetPlans(int? offset, int? limit, string? code, string? status, string? name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`offset` … `name`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `offset` ← `offset`, `limit` ← `limit`, `code` ← `code`, `status` ← `status`, `name` ← `name`
- **Returns**: `GetAllPlansResponse`
- **Error**: `SdkException<GetPlansError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetPlansException1(out GetPlansException1)` [400] · `TryGetGetPlansException21(out GetPlansException21)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAllPlansResponse` | `Models/GetAllPlansResponse.cs` |
| `GetPlansError` | `Errors/GetPlansError.cs` |
| `GetPlansException1` | `Models/GetPlansException1.cs` |
| `GetPlansException21` | `Models/GetPlansException21.cs` |

### UpdatePlan

- **Signature**: `UpdatePlan(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdatePlanResponse`
- **Error**: `SdkException<UpdatePlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetUpdatePlanException1(out UpdatePlanException1)` [400] · `TryGetUpdatePlanException21(out UpdatePlanException21)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePlanResponse` | `Models/UpdatePlanResponse.cs` |
| `UpdatePlanError` | `Errors/UpdatePlanError.cs` |
| `UpdatePlanException1` | `Models/UpdatePlanException1.cs` |
| `UpdatePlanException21` | `Models/UpdatePlanException21.cs` |

