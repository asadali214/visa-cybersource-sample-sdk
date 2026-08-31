<!-- Generated file — do not edit; regenerated with the SDK. -->

# MerchantDefinedFields — operations

Accessor: `client.MerchantDefinedFields` · Source: `Api/MerchantDefinedFields.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateMerchantDefinedFieldDefinition

- **Signature**: `CreateMerchantDefinedFieldDefinition(ReferenceType referenceType, MerchantDefinedFieldDefinitionRequest merchantDefinedFieldDefinitionRequest, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<CreateMerchantDefinedFieldDefinitionResponse>`
- **Error**: `SdkException<CreateMerchantDefinedFieldDefinitionError>` — **Case A (typed)**
- **Error accessors**: `TryGetCreateMerchantDefinedFieldDefinitionException1(out CreateMerchantDefinedFieldDefinitionException1)` [400, 409, 412] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReferenceType` | `Models/Enums/ReferenceType.cs` |
| `MerchantDefinedFieldDefinitionRequest` | `Models/MerchantDefinedFieldDefinitionRequest.cs` |
| `CreateMerchantDefinedFieldDefinitionResponse` | `Models/CreateMerchantDefinedFieldDefinitionResponse.cs` |
| `CreateMerchantDefinedFieldDefinitionError` | `Errors/CreateMerchantDefinedFieldDefinitionError.cs` |
| `CreateMerchantDefinedFieldDefinitionException1` | `Models/CreateMerchantDefinedFieldDefinitionException1.cs` |

### DeleteMerchantDefinedFieldsDefinitions

- **Signature**: `DeleteMerchantDefinedFieldsDefinitions(ReferenceType referenceType, long id, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReferenceType` | `Models/Enums/ReferenceType.cs` |

### GetMerchantDefinedFieldsDefinitions

- **Signature**: `GetMerchantDefinedFieldsDefinitions(ReferenceType referenceType, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<GetMerchantDefinedFieldsDefinitionsResponse>`
- **Error**: `SdkException<GetMerchantDefinedFieldsDefinitionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetGetMerchantDefinedFieldsDefinitionsException1(out GetMerchantDefinedFieldsDefinitionsException1)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReferenceType` | `Models/Enums/ReferenceType.cs` |
| `GetMerchantDefinedFieldsDefinitionsResponse` | `Models/GetMerchantDefinedFieldsDefinitionsResponse.cs` |
| `GetMerchantDefinedFieldsDefinitionsError` | `Errors/GetMerchantDefinedFieldsDefinitionsError.cs` |
| `GetMerchantDefinedFieldsDefinitionsException1` | `Models/GetMerchantDefinedFieldsDefinitionsException1.cs` |

### PutMerchantDefinedFieldsDefinitions

- **Signature**: `PutMerchantDefinedFieldsDefinitions(ReferenceType referenceType, long id, MerchantDefinedFieldCore merchantDefinedFieldCore, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<PutMerchantDefinedFieldsDefinitionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [400, 409] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReferenceType` | `Models/Enums/ReferenceType.cs` |
| `MerchantDefinedFieldCore` | `Models/MerchantDefinedFieldCore.cs` |
| `PutMerchantDefinedFieldsDefinitionsError` | `Errors/PutMerchantDefinedFieldsDefinitionsError.cs` |

