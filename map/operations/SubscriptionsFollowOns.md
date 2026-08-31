<!-- Generated file — do not edit; regenerated with the SDK. -->

# SubscriptionsFollowOns — operations

Accessor: `client.SubscriptionsFollowOns` · Source: `Api/SubscriptionsFollowOns.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateFollowOnSubscription

- **Signature**: `CreateFollowOnSubscription(string requestId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreateSubscriptionResponse`
- **Error**: `SdkException<CreateFollowOnSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetCreateFollowOnSubscriptionException1(out CreateFollowOnSubscriptionException1)` [400] · `TryGetCreateFollowOnSubscriptionException21(out CreateFollowOnSubscriptionException21)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSubscriptionResponse` | `Models/CreateSubscriptionResponse.cs` |
| `CreateFollowOnSubscriptionError` | `Errors/CreateFollowOnSubscriptionError.cs` |
| `CreateFollowOnSubscriptionException1` | `Models/CreateFollowOnSubscriptionException1.cs` |
| `CreateFollowOnSubscriptionException21` | `Models/CreateFollowOnSubscriptionException21.cs` |

### GetFollowOnSubscription

- **Signature**: `GetFollowOnSubscription(string requestId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetSubscriptionResponse1`
- **Error**: `SdkException<GetFollowOnSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetFollowOnSubscriptionException1(out GetFollowOnSubscriptionException1)` [400] · `TryGetGetFollowOnSubscriptionException21(out GetFollowOnSubscriptionException21)` [404] · `TryGetGetFollowOnSubscriptionException31(out GetFollowOnSubscriptionException31)` [502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSubscriptionResponse1` | `Models/GetSubscriptionResponse1.cs` |
| `GetFollowOnSubscriptionError` | `Errors/GetFollowOnSubscriptionError.cs` |
| `GetFollowOnSubscriptionException1` | `Models/GetFollowOnSubscriptionException1.cs` |
| `GetFollowOnSubscriptionException21` | `Models/GetFollowOnSubscriptionException21.cs` |
| `GetFollowOnSubscriptionException31` | `Models/GetFollowOnSubscriptionException31.cs` |

