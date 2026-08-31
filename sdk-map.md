<!-- Generated file — do not edit; regenerated with the SDK. -->

# SDK map — CyberSource Merged Spec (.NET)

> A generated table of contents for this SDK. Consult this map and its sub-pages to learn signatures, error types, and server/auth wiring **by lookup**. Model shapes and enum values are *not* duplicated here — the map names the file declaring each type; read the shape there. The compiler is the backstop: a wrong name fails to build.

|  |  |
| --- | --- |
| SDK display name | CyberSource Merged Spec |
| Root namespace | `CyberSourceMergedSpec` |
| Target framework | `netstandard2.0` (C# `LangVersion 14`, `Nullable enable`) |
| API spec version | `0.0.1` |
| Generator | APIMatic |

Staleness check: the API spec version above changes when the SDK is regenerated from a new spec. If a lookup here fails to compile, trust the compiler and re-read the source file named in the row.

All `Source` paths on this map and its sub-pages are relative to the **SDK root** — the directory holding this file and `CyberSourceMergedSpec.csproj` — never to the page that carries them. Open them as-is from the SDK root, from any page; if the SDK sits under a subdirectory of a larger repo, prefix that subdirectory.

---

## Getting a client

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new CyberSourceMergedSpecClientOptions
    {
        Environment = ServerEnvironment.Production,
    };
var client = new CyberSourceMergedSpecClient(httpClient, options);
```

DI alternative (`services.AddCyberSourceMergedSpecClient`):

```csharp
services.AddCyberSourceMergedSpecClient(options =>
    {
        options.Environment = ServerEnvironment.Production;
        // TODO: configure more client options here
    });
```

Every API group is a property on the client (e.g. `client.BinLookup`). Source: `CyberSourceMergedSpecClient.cs`. The only constructor is `CyberSourceMergedSpecClient(HttpClient httpClient, CyberSourceMergedSpecClientOptions options)`.

All `CyberSourceMergedSpecClientOptions` properties (source: `CyberSourceMergedSpecClientOptions.cs`):

| Property | Type |
| --- | --- |
| `Environment` | `ServerEnvironment` |
| `Retry` | `RetryOptions` |
| `Logging` | `LoggingOptions` |
| `Server` | `ServerOptions` |
| `Hooks` | `IReadOnlyList<SdkHook>` |

`RetryOptions` members (namespace `CyberSourceMergedSpec.Core.Configuration` — add `using CyberSourceMergedSpec.Core.Configuration;`; source: `Core/Configuration/RetryOptions.cs`; all members are `required`, so build a full instance or start from `RetryOptions.Default()`):

| Member | Type |
| --- | --- |
| `StatusCodesToRetry` | `IReadOnlyList<HttpStatusCode>` |
| `HttpMethodsToRetry` | `IReadOnlyList<HttpMethod>` |
| `MaxRetries` | `int` |
| `Delay` | `TimeSpan` |
| `Timeout` | `TimeSpan?` |
| `BackOffFactor` | `int` |
| `UseExponentialBackoff` | `bool` |
| `MaxJitter` | `TimeSpan` |
| `OnRetry` | `Action<RetryAttempt>?` |

---

## Error-handling model (read once — applies to every operation)

Operations are **throw-based**. On an error status the SDK throws `SdkException<TError>` (`Core/Exceptions/SdkException.cs`) exposing `.Error` of type `TError`. There are two cases:

- **Case A — typed error.** `TError` is a generated `…Error : ApiError` class with status-specific `TryGet…(out …)` accessors (each returns `true` when that shape is present) plus the inherited `TryGetRawError(out RawError)` fallback. The operation blocks name the exact `TryGet…` methods and the HTTP status each maps to.
- **Case B — raw error.** `TError` is `RawError` (`Core/ErrorResponse/RawError.cs`): `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?`.

Core error types (`Core/ErrorResponse/`) — public members with their **declared types**, verbatim from source:

| Type | Public members | Source |
| --- | --- | --- |
| `ApiError` — abstract base of the 127 typed error classes in `Errors/` | `TryGetRawError(out RawError error): bool` | `Core/ErrorResponse/ApiError.cs` |
| `RawError` | `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | `Core/ErrorResponse/RawError.cs` |

Typed-error payload shapes (the `out` types in each operation page's error-accessor cells) are ordinary records/unions — no special handling. The operation's **Type sources** table gives the file that declares each one; read field names, declared types, and JSON wire names there, as for any other model.

```csharp
try
{
    var response = await client.BinLookup.GetAccountInfo();
}
catch (SdkException<GetAccountInfoError> ex)
{
    // Case A — typed error
    if (ex.Error.TryGetBinLookupv400Response1(out var error))
    {
        // Handle 400
    }
    else if (ex.Error.TryGetRawError(out var raw))
    {
        // Any other error status
    }
}
catch (SdkException<RawError> ex)
{
    // Case B — raw error
    // ex.Error.StatusCode, ex.Error.ReadAsString(), ex.Error.ReadAsJson<T>()
}
```

**No-throw (`…Result`) variants: absent across this SDK** — every operation is throw-only. Of **135 operations**, **127 are Case A (typed)** and **8 are Case B (raw)**.

---

## Operations — by controller (49 groups, 135 operations)

Each links to a sub-page with one row per operation: signature with must-pass-explicitly params and defaults, query-param wire names, return type, error Case A/B, and Case A's typed accessors with their statuses. Each operation also carries a **Type sources** table — every type it names, with the file that declares it — so resolving a body, return, or error payload to its source is a lookup, never a search. `RawError` is excluded there (its members and path are above); an operation with no table names nothing but primitives and `RawError`.

**Each row states what is specific to its operation. Everything below holds for EVERY operation unless that operation's row says otherwise, so a row silent on one of these points is telling you the default here applies — take it and move on rather than opening the source to confirm it.**

| Applies to every operation | Stated where | A row appears only when |
| --- | --- | --- |
| **Throw-only** — no `…Result`/no-throw variant exists anywhere in this SDK | this page, Error-handling model | a no-throw sibling exists (none do at this SDK version) |
| **No pagination** — the operation returns a single response, not a `Pageable` | here | pagination is offered — the block carries a **Pagination** bullet naming the posture (page-, offset-, cursor- or link-based, or the `page`-without-page-size case) |
| **Case B error accessors are always these four** — `StatusCode: HttpStatusCode` · `ReadAsBytes(): ReadOnlyMemory<byte>` · `ReadAsString(): string` · `ReadAsJson<T>(): T?` | the `RawError` row above | never — a `Case B` label always implies exactly these four; Case A rows list their own typed accessors |
| **Server group `Default`** — base URL per Servers & auth below | here | the operation is on another group — its block carries a **Server group** bullet |
| **Parameter names are literal** — signatures are generated code verbatim; in named arguments use the exact parameter names shown (the cancellation-token parameter is named `ct`) | here | never — it always holds |

**The HTTP verb and route live on the operation itself**, in the source file named at the top of its operations page. This map is method-first: the C# method is the interface you call. When something wire-level needs the route — reproducing a raw request, pointing the client at a mock, reading a provider-side log — read it from that file; do not reconstruct it from memory or infer it from the method name.

**The endpoint's behavioural prose lives there too**, as the XML `<remarks>` on the method. Rows here give you the contract — names, types, shapes, errors. Where an operation's *semantics* decide what you must pass — a parameter whose value changes server-side behaviour, an ordering or exclusivity rule between fields — that is what `<remarks>` settles; read it there rather than filling it in from memory.

| Controller (`client.X`) | Ops | Page |
| --- | --- | --- |
| `BinLookup` | 1 | [map/operations/BinLookup.md](map/operations/BinLookup.md) |
| `ChargebackDetails` | 1 | [map/operations/ChargebackDetails.md](map/operations/ChargebackDetails.md) |
| `ChargebackSummaries` | 1 | [map/operations/ChargebackSummaries.md](map/operations/ChargebackSummaries.md) |
| `ConversionDetails` | 1 | [map/operations/ConversionDetails.md](map/operations/ConversionDetails.md) |
| `CustomerApi` | 4 | [map/operations/CustomerApi.md](map/operations/CustomerApi.md) |
| `CustomerPaymentInstrument` | 5 | [map/operations/CustomerPaymentInstrument.md](map/operations/CustomerPaymentInstrument.md) |
| `CustomerShippingAddress` | 5 | [map/operations/CustomerShippingAddress.md](map/operations/CustomerShippingAddress.md) |
| `DecisionManager` | 5 | [map/operations/DecisionManager.md](map/operations/DecisionManager.md) |
| `DownloadDtd` | 1 | [map/operations/DownloadDtd.md](map/operations/DownloadDtd.md) |
| `DownloadXsd` | 1 | [map/operations/DownloadXsd.md](map/operations/DownloadXsd.md) |
| `InstrumentIdentifierApi` | 6 | [map/operations/InstrumentIdentifierApi.md](map/operations/InstrumentIdentifierApi.md) |
| `InterchangeClearingLevelDetails` | 1 | [map/operations/InterchangeClearingLevelDetails.md](map/operations/InterchangeClearingLevelDetails.md) |
| `InvoiceSettings` | 2 | [map/operations/InvoiceSettings.md](map/operations/InvoiceSettings.md) |
| `Invoices` | 7 | [map/operations/Invoices.md](map/operations/Invoices.md) |
| `MerchantDefinedFields` | 4 | [map/operations/MerchantDefinedFields.md](map/operations/MerchantDefinedFields.md) |
| `MicroformIntegration` | 1 | [map/operations/MicroformIntegration.md](map/operations/MicroformIntegration.md) |
| `NetFundings` | 1 | [map/operations/NetFundings.md](map/operations/NetFundings.md) |
| `NetworkTokens` | 7 | [map/operations/NetworkTokens.md](map/operations/NetworkTokens.md) |
| `NotificationOfChanges` | 1 | [map/operations/NotificationOfChanges.md](map/operations/NotificationOfChanges.md) |
| `PayerAuthentication` | 3 | [map/operations/PayerAuthentication.md](map/operations/PayerAuthentication.md) |
| `PaymentBatchSummaries` | 1 | [map/operations/PaymentBatchSummaries.md](map/operations/PaymentBatchSummaries.md) |
| `PaymentInstrumentApi` | 4 | [map/operations/PaymentInstrumentApi.md](map/operations/PaymentInstrumentApi.md) |
| `Payouts` | 1 | [map/operations/Payouts.md](map/operations/Payouts.md) |
| `Plans` | 8 | [map/operations/Plans.md](map/operations/Plans.md) |
| `PullFundsApi` | 3 | [map/operations/PullFundsApi.md](map/operations/PullFundsApi.md) |
| `PurchaseAndRefundDetails` | 1 | [map/operations/PurchaseAndRefundDetails.md](map/operations/PurchaseAndRefundDetails.md) |
| `ReportDefinitions` | 2 | [map/operations/ReportDefinitions.md](map/operations/ReportDefinitions.md) |
| `ReportDownloads` | 1 | [map/operations/ReportDownloads.md](map/operations/ReportDownloads.md) |
| `ReportSubscriptions` | 5 | [map/operations/ReportSubscriptions.md](map/operations/ReportSubscriptions.md) |
| `Reports` | 3 | [map/operations/Reports.md](map/operations/Reports.md) |
| `RetrievalDetails` | 1 | [map/operations/RetrievalDetails.md](map/operations/RetrievalDetails.md) |
| `RetrievalSummaries` | 1 | [map/operations/RetrievalSummaries.md](map/operations/RetrievalSummaries.md) |
| `SearchTransactions` | 2 | [map/operations/SearchTransactions.md](map/operations/SearchTransactions.md) |
| `SecureFileShare` | 2 | [map/operations/SecureFileShare.md](map/operations/SecureFileShare.md) |
| `Subscriptions` | 10 | [map/operations/Subscriptions.md](map/operations/Subscriptions.md) |
| `SubscriptionsFollowOns` | 2 | [map/operations/SubscriptionsFollowOns.md](map/operations/SubscriptionsFollowOns.md) |
| `Tokenize` | 1 | [map/operations/Tokenize.md](map/operations/Tokenize.md) |
| `TransactionBatches` | 3 | [map/operations/TransactionBatches.md](map/operations/TransactionBatches.md) |
| `TransactionDetailsApi` | 1 | [map/operations/TransactionDetailsApi.md](map/operations/TransactionDetailsApi.md) |
| `Verification` | 2 | [map/operations/Verification.md](map/operations/Verification.md) |
| `BillingAgreements` | 3 | [map/operations/BillingAgreements.md](map/operations/BillingAgreements.md) |
| `CaptureApi` | 1 | [map/operations/CaptureApi.md](map/operations/CaptureApi.md) |
| `Credit` | 1 | [map/operations/Credit.md](map/operations/Credit.md) |
| `Orders` | 2 | [map/operations/Orders.md](map/operations/Orders.md) |
| `PaymentTokens` | 1 | [map/operations/PaymentTokens.md](map/operations/PaymentTokens.md) |
| `Payments` | 6 | [map/operations/Payments.md](map/operations/Payments.md) |
| `RefundApi` | 2 | [map/operations/RefundApi.md](map/operations/RefundApi.md) |
| `ReversalApi` | 2 | [map/operations/ReversalApi.md](map/operations/ReversalApi.md) |
| `VoidApi` | 5 | [map/operations/VoidApi.md](map/operations/VoidApi.md) |

---

## Models — where they live, how to build them

**Shapes live only in the source.** Every file under `Models/` and `Errors/` declares exactly one public type, named after the file, and no two share a name — so a type name *is* its path. Take it from the operation's **Type sources** table, or build it from the kind's directory below. Never grep for a type.

| Group | Count | Directory (file = `<TypeName>.cs`) |
| --- | --- | --- |
| Records (plain `record` data models) | 1972 | `Models/` |
| Enums (`StringEnum<T>` / `IntEnum<T>`) — C# member names + wire values | 12 | `Models/Enums/` |
| Typed error classes (`: ApiError`, one per Case A operation) | 127 | `Errors/` |

Conventions: records are immutable, `init`-only; `required` properties must be set in the object initializer; `T?` is optional. A field's wire name is its `[JsonPropertyName]` and often differs from the C# name (`AmountInCents` ↔ `amount_in_cents`) — read it off the property, don't derive it. `OneOf`/`AnyOf` unions wrap `Optional<T>` variants — build via static factory or implicit conversion, read via `TryGet…(out …)`; `AllOf` compositions are not unions — every constituent is a `required` property, so set them all, and those constituent properties carry no `[JsonPropertyName]` and have no wire name of their own, because the generated converter flattens each constituent's own fields directly into the one parent JSON object. Enums are **not** C# enums — build with `Type.FromValue("wire")` or the static members, whose names are PascalCase even when the wire value isn't (`CollectionMethod.Invoice`, not `.invoice`).

Namespaces by content type (add `using` accordingly):

| Contents | Namespace |
| --- | --- |
| Client & options (root) | `CyberSourceMergedSpec` |
| Operation controllers (`Api/`) | `CyberSourceMergedSpec.Api` |
| Records (`Models/`) | `CyberSourceMergedSpec.Models` |
| Enums (`Models/Enums/`) | `CyberSourceMergedSpec.Models.Enums` |
| Error classes (`Errors/`) | `CyberSourceMergedSpec.Errors` |

---

## Servers & auth

**Auth — none.** The spec declares no security schemes; the client sends no credentials.

**Environments.** `options.Environment` selects the target environment (`Servers/ServerEnvironment.cs`):

| Environment | Value | Hosting |
| --- | --- | --- |
| `ServerEnvironment.Production` *(default)* | `production` | — |

**1 server group.** Base-URL templates and override points (`options.Server.…`):

| Group | `Production` base URL | Override point |
| --- | --- | --- |
| `Default` | `https://apitest.cybersource.com/` | `options.Server.Default.Production.BaseUrl` |

Retry/resilience is configurable via `options.Retry` (`RetryOptions`, backed by Polly).

