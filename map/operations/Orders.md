<!-- Generated file — do not edit; regenerated with the SDK. -->

# Orders — operations

Accessor: `client.Orders` · Source: `Api/Orders.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateOrder

- **Signature**: `CreateOrder(CreateOrderRequest createOrderRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CreateOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateOrderRequest` | `Models/CreateOrderRequest.cs` |
| `CreateOrderError` | `Errors/CreateOrderError.cs` |

### UpdateOrder

- **Signature**: `UpdateOrder(string id, UpdateOrderRequest updateOrderRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<UpdateOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 502] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateOrderRequest` | `Models/UpdateOrderRequest.cs` |
| `UpdateOrderError` | `Errors/UpdateOrderError.cs` |

