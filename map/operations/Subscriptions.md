<!-- Generated file — do not edit; regenerated with the SDK. -->

# Subscriptions — operations

Accessor: `client.Subscriptions` · Source: `Api/Subscriptions.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateSubscription

- **Signature**: `ActivateSubscription(string id, bool? processMissedPayments = true, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `processMissedPayments` = `true`
- **Query params (wire ← C#)**: `processMissedPayments` ← `processMissedPayments`
- **Returns**: `ActivateSubscriptionResponse`
- **Error**: `SdkException<ActivateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetActivateSubscriptionException1(out ActivateSubscriptionException1)` [400] · `TryGetActivateSubscriptionException21(out ActivateSubscriptionException21)` [404] · `TryGetActivateSubscriptionException31(out ActivateSubscriptionException31)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ActivateSubscriptionResponse` | `Models/ActivateSubscriptionResponse.cs` |
| `ActivateSubscriptionError` | `Errors/ActivateSubscriptionError.cs` |
| `ActivateSubscriptionException1` | `Models/ActivateSubscriptionException1.cs` |
| `ActivateSubscriptionException21` | `Models/ActivateSubscriptionException21.cs` |
| `ActivateSubscriptionException31` | `Models/ActivateSubscriptionException31.cs` |

### CancelSubscription

- **Signature**: `CancelSubscription(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CancelSubscriptionResponse`
- **Error**: `SdkException<CancelSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetCancelSubscriptionException1(out CancelSubscriptionException1)` [400] · `TryGetCancelSubscriptionException21(out CancelSubscriptionException21)` [404] · `TryGetCancelSubscriptionException31(out CancelSubscriptionException31)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelSubscriptionResponse` | `Models/CancelSubscriptionResponse.cs` |
| `CancelSubscriptionError` | `Errors/CancelSubscriptionError.cs` |
| `CancelSubscriptionException1` | `Models/CancelSubscriptionException1.cs` |
| `CancelSubscriptionException21` | `Models/CancelSubscriptionException21.cs` |
| `CancelSubscriptionException31` | `Models/CancelSubscriptionException31.cs` |

### CreateSubscription

- **Signature**: `CreateSubscription(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateSubscriptionResponse`
- **Error**: `SdkException<CreateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetCreateSubscriptionException1(out CreateSubscriptionException1)` [400] · `TryGetCreateSubscriptionException21(out CreateSubscriptionException21)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSubscriptionResponse` | `Models/CreateSubscriptionResponse.cs` |
| `CreateSubscriptionError` | `Errors/CreateSubscriptionError.cs` |
| `CreateSubscriptionException1` | `Models/CreateSubscriptionException1.cs` |
| `CreateSubscriptionException21` | `Models/CreateSubscriptionException21.cs` |

### GetAllSubscriptions

- **Signature**: `GetAllSubscriptions(int? offset, int? limit, string? code, string? status, string? customerId, string? clientReferenceInformationCode, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`offset` … `clientReferenceInformationCode`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `offset` ← `offset`, `limit` ← `limit`, `code` ← `code`, `status` ← `status`, `customerId` ← `customerId`, `clientReferenceInformationCode` ← `clientReferenceInformationCode`
- **Returns**: `GetAllSubscriptionsResponse`
- **Error**: `SdkException<GetAllSubscriptionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetAllSubscriptionsException1(out GetAllSubscriptionsException1)` [400] · `TryGetGetAllSubscriptionsException21(out GetAllSubscriptionsException21)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAllSubscriptionsResponse` | `Models/GetAllSubscriptionsResponse.cs` |
| `GetAllSubscriptionsError` | `Errors/GetAllSubscriptionsError.cs` |
| `GetAllSubscriptionsException1` | `Models/GetAllSubscriptionsException1.cs` |
| `GetAllSubscriptionsException21` | `Models/GetAllSubscriptionsException21.cs` |

### GetSubscription

- **Signature**: `GetSubscription(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetSubscriptionResponse`
- **Error**: `SdkException<GetSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetSubscriptionException1(out GetSubscriptionException1)` [400] · `TryGetGetSubscriptionException21(out GetSubscriptionException21)` [404] · `TryGetGetSubscriptionException31(out GetSubscriptionException31)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSubscriptionResponse` | `Models/GetSubscriptionResponse.cs` |
| `GetSubscriptionError` | `Errors/GetSubscriptionError.cs` |
| `GetSubscriptionException1` | `Models/GetSubscriptionException1.cs` |
| `GetSubscriptionException21` | `Models/GetSubscriptionException21.cs` |
| `GetSubscriptionException31` | `Models/GetSubscriptionException31.cs` |

### GetSubscriptionCode

- **Signature**: `GetSubscriptionCode(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetSubscriptionCodeResponse`
- **Error**: `SdkException<GetSubscriptionCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetSubscriptionCodeException1(out GetSubscriptionCodeException1)` [400] · `TryGetGetSubscriptionCodeException21(out GetSubscriptionCodeException21)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSubscriptionCodeResponse` | `Models/GetSubscriptionCodeResponse.cs` |
| `GetSubscriptionCodeError` | `Errors/GetSubscriptionCodeError.cs` |
| `GetSubscriptionCodeException1` | `Models/GetSubscriptionCodeException1.cs` |
| `GetSubscriptionCodeException21` | `Models/GetSubscriptionCodeException21.cs` |

### SubscriptionsIdPaymentsGet

- **Signature**: `SubscriptionsIdPaymentsGet(string id, int? offset, int? limit, int? scheduledPaymentsCount, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `offset` — nullable, no default → **must pass explicitly**
  - `limit` — nullable, no default → **must pass explicitly**
  - `scheduledPaymentsCount` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `offset` ← `offset`, `limit` ← `limit`, `scheduledPaymentsCount` ← `scheduledPaymentsCount`
- **Returns**: `GetSubscriptionsPaymentsResponse`
- **Error**: `SdkException<SubscriptionsIdPaymentsGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionsIdPaymentsGetException1(out SubscriptionsIdPaymentsGetException1)` [400] · `TryGetSubscriptionsIdPaymentsGetException21(out SubscriptionsIdPaymentsGetException21)` [404] · `TryGetSubscriptionsIdPaymentsGetException31(out SubscriptionsIdPaymentsGetException31)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSubscriptionsPaymentsResponse` | `Models/GetSubscriptionsPaymentsResponse.cs` |
| `SubscriptionsIdPaymentsGetError` | `Errors/SubscriptionsIdPaymentsGetError.cs` |
| `SubscriptionsIdPaymentsGetException1` | `Models/SubscriptionsIdPaymentsGetException1.cs` |
| `SubscriptionsIdPaymentsGetException21` | `Models/SubscriptionsIdPaymentsGetException21.cs` |
| `SubscriptionsIdPaymentsGetException31` | `Models/SubscriptionsIdPaymentsGetException31.cs` |

### SubscriptionsIdPaymentsPut

- **Signature**: `SubscriptionsIdPaymentsPut(string id, UpdatePayments updatePayments, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetSubscriptionsPaymentsResponse1`
- **Error**: `SdkException<SubscriptionsIdPaymentsPutError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionsIdPaymentsPutException1(out SubscriptionsIdPaymentsPutException1)` [400] · `TryGetSubscriptionsIdPaymentsPutException21(out SubscriptionsIdPaymentsPutException21)` [404] · `TryGetSubscriptionsIdPaymentsPutException31(out SubscriptionsIdPaymentsPutException31)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePayments` | `Models/UpdatePayments.cs` |
| `GetSubscriptionsPaymentsResponse1` | `Models/GetSubscriptionsPaymentsResponse1.cs` |
| `SubscriptionsIdPaymentsPutError` | `Errors/SubscriptionsIdPaymentsPutError.cs` |
| `SubscriptionsIdPaymentsPutException1` | `Models/SubscriptionsIdPaymentsPutException1.cs` |
| `SubscriptionsIdPaymentsPutException21` | `Models/SubscriptionsIdPaymentsPutException21.cs` |
| `SubscriptionsIdPaymentsPutException31` | `Models/SubscriptionsIdPaymentsPutException31.cs` |

### SuspendSubscription

- **Signature**: `SuspendSubscription(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SuspendSubscriptionResponse`
- **Error**: `SdkException<SuspendSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSuspendSubscriptionException1(out SuspendSubscriptionException1)` [400] · `TryGetSuspendSubscriptionException21(out SuspendSubscriptionException21)` [404] · `TryGetSuspendSubscriptionException31(out SuspendSubscriptionException31)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SuspendSubscriptionResponse` | `Models/SuspendSubscriptionResponse.cs` |
| `SuspendSubscriptionError` | `Errors/SuspendSubscriptionError.cs` |
| `SuspendSubscriptionException1` | `Models/SuspendSubscriptionException1.cs` |
| `SuspendSubscriptionException21` | `Models/SuspendSubscriptionException21.cs` |
| `SuspendSubscriptionException31` | `Models/SuspendSubscriptionException31.cs` |

### UpdateSubscription

- **Signature**: `UpdateSubscription(string id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UpdateSubscriptionResponse`
- **Error**: `SdkException<UpdateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetUpdateSubscriptionException1(out UpdateSubscriptionException1)` [400] · `TryGetUpdateSubscriptionException21(out UpdateSubscriptionException21)` [404] · `TryGetUpdateSubscriptionException31(out UpdateSubscriptionException31)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateSubscriptionResponse` | `Models/UpdateSubscriptionResponse.cs` |
| `UpdateSubscriptionError` | `Errors/UpdateSubscriptionError.cs` |
| `UpdateSubscriptionException1` | `Models/UpdateSubscriptionException1.cs` |
| `UpdateSubscriptionException21` | `Models/UpdateSubscriptionException21.cs` |
| `UpdateSubscriptionException31` | `Models/UpdateSubscriptionException31.cs` |

