# Reference

> Source: [CyberSourceMergedSpecClient](CyberSourceMergedSpecClient.cs)

## BinLookup

> Source: [BinLookup](Api/BinLookup.cs)

<details>
<summary><code>Task&lt;GetAccountInfoResponse&gt; GetAccountInfo(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The BIN Lookup Service is a versatile business tool that provides card network agnostic solution designed to ensure frictionless transaction experience by utilizing up-to-date Bank Identification Number (BIN) attributes sourced from multiple global and regional data sources.
This service helps to improve authorization rates by helping to route transactions to the best-suited card network, minimizes fraud through card detail verification and aids in regulatory compliance by identifying card properties. The service is flexible and provides businesses with a flexible choice of inputs such as primary account number (PAN), network token from major networks (such as Visa, American Express, Discover and several regional networks) which includes device PAN (DPAN), and all types of tokens generated via CyberSource Token Management Service (TMS).
Currently, the range of available credentials is contingent on the networks enabled for the business entity. Therefore, the network information specified in this documentation is illustrative and subject to personalized offerings for each reseller or merchant.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BinLookup.GetAccountInfo();
    // TODO: Handle 'response' of type GetAccountInfoResponse
}
catch (SdkException<GetAccountInfoError> ex)
{
    if (ex.Error.TryGetBinLookupv400Response1(out var error))
    {
        // TODO: Handle 'error' of type BinLookupv400Response1
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetAccountInfoResponse](Models/GetAccountInfoResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAccountInfoError](Errors/GetAccountInfoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChargebackDetails

> Source: [ChargebackDetails](Api/ChargebackDetails.cs)

<details>
<summary><code>Task GetChargebackDetails(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Chargeback Detail Report Description

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChargebackDetails.GetChargebackDetails(startTime, endTime, organizationId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>DateTimeOffset</code> | Valid report Start Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>endTime</code> | <code>DateTimeOffset</code> | Valid report End Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ChargebackSummaries

> Source: [ChargebackSummaries](Api/ChargebackSummaries.cs)

<details>
<summary><code>Task GetChargebackSummaries(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Chargeback Summary Report Description

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ChargebackSummaries.GetChargebackSummaries(startTime, endTime, organizationId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>DateTimeOffset</code> | Valid report Start Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>endTime</code> | <code>DateTimeOffset</code> | Valid report End Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ConversionDetails

> Source: [ConversionDetails](Api/ConversionDetails.cs)

<details>
<summary><code>Task GetConversionDetail(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get conversion detail of transactions for a merchant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ConversionDetails.GetConversionDetail(startTime, endTime, organizationId);
}
catch (SdkException<GetConversionDetailError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>DateTimeOffset</code> | Valid report Start Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>endTime</code> | <code>DateTimeOffset</code> | Valid report End Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetConversionDetailError](Errors/GetConversionDetailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CustomerApi

> Source: [CustomerApi](Api/CustomerApi.cs)

<details>
<summary><code>Task DeleteCustomer(string customerId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customers**<br>A Customer represents your tokenized customer information.<br>You should associate the Customer Id with the customer account on your systems.<br>A Customer can have one or more [Payment Instruments](#token-management_customer-payment-instrument_create-a-customer-payment-instrumentl) or [Shipping Addresses](#token-management_customer-shipping-address_create-a-customer-shipping-address) with one allocated as the Customers default.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Deleting a Customer**<br>Your system can use this API to delete a complete Customer.<br>When a Customer is deleted all associated Payment Instruments & Shipping Addresses are deleted.<br>Any Instrument Identifiers representing the card number will also be deleted if they are not associated with any other Payment Instruments.<br>Note: Individual [Payment Instruments](#token-management_customer-payment-instrument_delete-a-customer-payment-instrument) or [Shipping Addresses](#token-management_customer-shipping-address_delete-a-customer-shipping-address) can be deleted via their own dedicated API resources.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CustomerApi.DeleteCustomer(customerId, profileId);
}
catch (SdkException<DeleteCustomerError> ex)
{
    if (ex.Error.TryGetDeleteCustomerException1(out var error))
    {
        // TODO: Handle 'error' of type DeleteCustomerException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Id of a Customer. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteCustomerError](Errors/DeleteCustomerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetCustomerResponse&gt; GetCustomer(string customerId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customers**<br>A Customer represents your tokenized customer information.<br>You should associate the Customer Id with the customer account on your systems.<br>A Customer can have one or more [Payment Instruments](#token-management_customer-payment-instrument_create-a-customer-payment-instrumentl) or [Shipping Addresses](#token-management_customer-shipping-address_create-a-customer-shipping-address) with one allocated as the Customers default.<br><br>**Retrieving a Customer**<br>When your customer signs into their account, your system can use this API to retrieve the Customers default Payment Instrument and Shipping Address.<br>**Note: the actual card data will be masked.**<br>If your customer wants to see other available Payment Instruments, your system can [retrieve all Payment Instruments](#token-management_customer-payment-instrument_list-payment-instruments-for-a-customer) associated with the Customer.<br>The same applies to [Shipping Addresses](#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer).|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Payment Network Tokens**<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.<br>A Payment Network Token can also be [provisioned for an existing Instrument Identifier](#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token).<br>For more information about Payment Network Tokens see the Developer Guide.<br><br>**Payments with Customers**<br>To perform a payment with the Customers default details specify the [Customer Id in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-token-id_liveconsole-tab-request-body).<br>To perform a payment with a particular Payment Instrument or Shipping Address <br>specify the [Payment Instrument or Shipping Address Ids in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerApi.GetCustomer(customerId, profileId);
    // TODO: Handle 'response' of type GetCustomerResponse
}
catch (SdkException<GetCustomerError> ex)
{
    if (ex.Error.TryGetGetCustomerException1(out var error))
    {
        // TODO: Handle 'error' of type GetCustomerException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Id of a Customer. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetCustomerResponse](Models/GetCustomerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCustomerError](Errors/GetCustomerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PatchCustomerResponse&gt; PatchCustomer(string customerId, string? profileId, string? ifMatch, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customers**<br>A Customer represents your tokenized customer information.<br>You should associate the Customer Id with the customer account on your systems.<br>A Customer can have one or more [Payment Instruments](#token-management_customer-payment-instrument_create-a-customer-payment-instrumentl) or [Shipping Addresses](#token-management_customer-shipping-address_create-a-customer-shipping-address) with one allocated as the Customers default.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Updating a Customer**<br>Your system can use this API to update a Customers details including selecting a  [default Payment Instrument](#token-management_customer_update-a-customer_samplerequests-dropdown_update-customers-default-payment-instrument_liveconsole-tab-request-body) or [default Shipping Address](#token-management_customer_update-a-customer_samplerequests-dropdown_update-customers-default-shipping-address_liveconsole-tab-request-body) for use in payments.<br>Note: Updating a Customers [Payment Instrument](#token-management_customer-payment-instrument_update-a-customer-payment-instrument) or [Shipping Address](#token-management_customer-shipping-address_update-a-customer-shipping-address) details is performed using their own dedicated API resources.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerApi.PatchCustomer(customerId, profileId, ifMatch);
    // TODO: Handle 'response' of type PatchCustomerResponse
}
catch (SdkException<PatchCustomerError> ex)
{
    if (ex.Error.TryGetPatchCustomerException1(out var error))
    {
        // TODO: Handle 'error' of type PatchCustomerException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Id of a Customer. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |
| <code>ifMatch</code> | <code>string?</code> | Contains an ETag value from a GET request to make the request conditional. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PatchCustomerResponse](Models/PatchCustomerResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchCustomerError](Errors/PatchCustomerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TmsV2CustomersResponse&gt; PostCustomer(string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customers**<br>A Customer represents your tokenized customer information.<br>You should associate the Customer Id with the customer account on your systems.<br>A Customer can have one or more [Payment Instruments](#token-management_customer-payment-instrument_create-a-customer-payment-instrumentl) or [Shipping Addresses](#token-management_customer-shipping-address_create-a-customer-shipping-address) with one allocated as the Customers default.<br><br>**Creating a Customer**<br>It is recommended you [create a Customer via a Payment Authorization](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-customer-token-creation_liveconsole-tab-request-body), this can be for a zero amount.<br>The Customer will be created with a Payment Instrument and Shipping Address.<br>You can also [add additional Payment Instruments to a Customer via a Payment Authorization](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-create-default-payment-instrument-shipping-address-for-existing-customer_liveconsole-tab-request-body).<br>In Europe: You should perform Payer Authentication alongside the Authorization.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Payment Network Tokens**<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.<br>A Payment Network Token can also be [provisioned for an existing Instrument Identifier](#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token).<br>For more information about Payment Network Tokens see the Developer Guide.<br><br>**Payments with Customers**<br>To perform a payment with the Customers default details specify the [Customer Id in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-token-id_liveconsole-tab-request-body).<br>To perform a payment with a particular Payment Instrument or Shipping Address <br>specify the [Payment Instrument or Shipping Address Ids in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body).
The availability of API features for a merchant may depend on the portfolio configuration and may need to be enabled at the portfolio level before they can be added to merchant accounts.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerApi.PostCustomer(profileId);
    // TODO: Handle 'response' of type TmsV2CustomersResponse
}
catch (SdkException<PostCustomerError> ex)
{
    if (ex.Error.TryGetPostCustomerException1(out var error))
    {
        // TODO: Handle 'error' of type PostCustomerException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TmsV2CustomersResponse](Models/TmsV2CustomersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCustomerError](Errors/PostCustomerError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CustomerPaymentInstrument

> Source: [CustomerPaymentInstrument](Api/CustomerPaymentInstrument.cs)

<details>
<summary><code>Task DeleteCustomerPaymentInstrument(string customerId, string paymentInstrumentId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customer Payment Instrument**<br>A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address & card type.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Payment Instruments](#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument), with one allocated as the Customers default for use in payments.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Deleting a Customers Payment Instrument**<br>Your system can use this API to delete an existing Payment Instrument for a Customer.<br>Any Instrument Identifiers representing the card number will also be deleted if they are not associated with any other Payment Instruments.<br>If a customer has more than one Payment Instrument then the default Payment Instrument cannot be deleted without first selecting a [new default Payment Instrument](#token-management_customer-payment-instrument_update-a-customer-payment-instrument_samplerequests-dropdown_make-customer-payment-instrument-the-default_liveconsole-tab-request-body).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CustomerPaymentInstrument.DeleteCustomerPaymentInstrument(customerId,
        paymentInstrumentId,
        profileId);
}
catch (SdkException<DeleteCustomerPaymentInstrumentError> ex)
{
    if (ex.Error.TryGetDeleteCustomerPaymentInstrumentException1(out var error))
    {
        // TODO: Handle 'error' of type DeleteCustomerPaymentInstrumentException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Id of a Customer. |
| <code>paymentInstrumentId</code> | <code>string</code> | The Id of a payment instrument. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteCustomerPaymentInstrumentError](Errors/DeleteCustomerPaymentInstrumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrument11&gt; GetCustomerPaymentInstrument(string customerId, string paymentInstrumentId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customer Payment Instrument**<br>A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address & card type.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Payment Instruments](#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument), with one allocated as the Customers default for use in payments.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Retrieving a Customer Payment Instrument**<br>Your system can use this API to retrieve an existing Payment Instrument for a Customer.<br>To perform a payment with a particular Payment Instrument simply specify the [Payment Instrument Id in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerPaymentInstrument.GetCustomerPaymentInstrument(customerId,
        paymentInstrumentId,
        profileId);
    // TODO: Handle 'response' of type PaymentInstrument11
}
catch (SdkException<GetCustomerPaymentInstrumentError> ex)
{
    if (ex.Error.TryGetGetCustomerPaymentInstrumentException1(out var error))
    {
        // TODO: Handle 'error' of type GetCustomerPaymentInstrumentException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Id of a Customer. |
| <code>paymentInstrumentId</code> | <code>string</code> | The Id of a payment instrument. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrument11](Models/PaymentInstrument11.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCustomerPaymentInstrumentError](Errors/GetCustomerPaymentInstrumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrumentList&gt; GetCustomerPaymentInstrumentsList(string customerId, string? profileId, long? offset = 0L, long? limit = 20L, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customer Payment Instrument**<br>A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address & card type.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Payment Instruments](#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument), with one allocated as the Customers default for use in payments.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Retrieving all Customer Payment Instruments**<br>Your system can use this API to retrieve all existing Payment Instruments for a Customer.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerPaymentInstrument.GetCustomerPaymentInstrumentsList(customerId, profileId);
    // TODO: Handle 'response' of type PaymentInstrumentList
}
catch (SdkException<GetCustomerPaymentInstrumentsListError> ex)
{
    if (ex.Error.TryGetGetCustomerPaymentInstrumentsListException1(out var error))
    {
        // TODO: Handle 'error' of type GetCustomerPaymentInstrumentsListException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Id of a Customer. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |
| <code>offset</code> | <code>long?</code> | Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0.<br>**Default**: 0L |
| <code>limit</code> | <code>long?</code> | The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100.<br>**Default**: 20L |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrumentList](Models/PaymentInstrumentList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCustomerPaymentInstrumentsListError](Errors/GetCustomerPaymentInstrumentsListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrument11&gt; PatchCustomersPaymentInstrument(string customerId, string paymentInstrumentId, string? profileId, string? ifMatch, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customer Payment Instrument**<br>A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address & card type.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Payment Instruments](#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument), with one allocated as the Customers default for use in payments.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Updating a Customers Payment Instrument**<br>Your system can use this API to update an existing Payment Instrument for a Customer, including selecting a [default Payment Instrument](#token-management_customer-payment-instrument_update-a-customer-payment-instrument_samplerequests-dropdown_make-customer-payment-instrument-the-default_liveconsole-tab-request-body) for use in payments.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerPaymentInstrument.PatchCustomersPaymentInstrument(customerId,
        paymentInstrumentId,
        profileId,
        ifMatch);
    // TODO: Handle 'response' of type PaymentInstrument11
}
catch (SdkException<PatchCustomersPaymentInstrumentError> ex)
{
    if (ex.Error.TryGetPatchCustomersPaymentInstrumentException1(out var error))
    {
        // TODO: Handle 'error' of type PatchCustomersPaymentInstrumentException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Id of a Customer. |
| <code>paymentInstrumentId</code> | <code>string</code> | The Id of a payment instrument. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |
| <code>ifMatch</code> | <code>string?</code> | Contains an ETag value from a GET request to make the request conditional. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrument11](Models/PaymentInstrument11.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchCustomersPaymentInstrumentError](Errors/PatchCustomersPaymentInstrumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrument11&gt; PostCustomerPaymentInstrument(string customerId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customer Payment Instrument**<br>A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address & card type.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Payment Instruments](#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument), with one allocated as the Customers default for use in payments.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br><br>**Creating a Customer Payment Instrument**<br>It is recommended you [create a Customer Payment Instrument via a Payment Authorization](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-create-default-payment-instrument-shipping-address-for-existing-customer_liveconsole-tab-request-body), this can be for a zero amount.<br>In Europe: You should perform Payer Authentication alongside the Authorization.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Payment Network Tokens**<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.<br>A Payment Network Token can also be [provisioned for an existing Instrument Identifier](#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token).<br>For more information about Payment Network Tokens see the Developer Guide.<br><br>**Payments with Customers Payment Instrument**<br>To perform a payment with a particular Payment Instrument or Shipping Address specify the [Payment Instrument in the payment request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerPaymentInstrument.PostCustomerPaymentInstrument(customerId, profileId);
    // TODO: Handle 'response' of type PaymentInstrument11
}
catch (SdkException<PostCustomerPaymentInstrumentError> ex)
{
    if (ex.Error.TryGetPostCustomerPaymentInstrumentException1(out var error))
    {
        // TODO: Handle 'error' of type PostCustomerPaymentInstrumentException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Id of a Customer. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrument11](Models/PaymentInstrument11.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCustomerPaymentInstrumentError](Errors/PostCustomerPaymentInstrumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CustomerShippingAddress

> Source: [CustomerShippingAddress](Api/CustomerShippingAddress.cs)

<details>
<summary><code>Task DeleteCustomerShippingAddress(string customerId, string shippingAddressId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customer Shipping Address**<br>A Customer Shipping Address represents tokenized customer shipping information.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Shipping Addresses](#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer), with one allocated as the Customers default for use in payments.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Deleting a Customers Shipping Address**<br>Your system can use this API to delete an existing Shipping Address for a Customer.<br>If a customer has more than one Shipping Address then the default Shipping Address cannot be deleted without first selecting a [new default Shipping Address](#token-management_customer-shipping-address_update-a-customer-shipping-address_samplerequests-dropdown_make-customer-shipping-address-the-default_liveconsole-tab-request-body).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CustomerShippingAddress.DeleteCustomerShippingAddress(customerId, shippingAddressId, profileId);
}
catch (SdkException<DeleteCustomerShippingAddressError> ex)
{
    if (ex.Error.TryGetDeleteCustomerShippingAddressException1(out var error))
    {
        // TODO: Handle 'error' of type DeleteCustomerShippingAddressException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Id of a Customer. |
| <code>shippingAddressId</code> | <code>string</code> | The Id of a shipping address. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteCustomerShippingAddressError](Errors/DeleteCustomerShippingAddressError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetCustomerShippingAddressResponse&gt; GetCustomerShippingAddress(string customerId, string shippingAddressId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customer Shipping Address**<br>A Customer Shipping Address represents tokenized customer shipping information.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Shipping Addresses](#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer), with one allocated as the Customers default for use in payments.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Retrieving a Customer Shipping Address**<br>Your system can use this API to retrieve an existing Shipping Address for a Customer.<br>To perform a payment with a particular Shipping Address simply specify the [Shipping Address Id in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerShippingAddress.GetCustomerShippingAddress(customerId,
        shippingAddressId,
        profileId);
    // TODO: Handle 'response' of type GetCustomerShippingAddressResponse
}
catch (SdkException<GetCustomerShippingAddressError> ex)
{
    if (ex.Error.TryGetGetCustomerShippingAddressException1(out var error))
    {
        // TODO: Handle 'error' of type GetCustomerShippingAddressException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Id of a Customer. |
| <code>shippingAddressId</code> | <code>string</code> | The Id of a shipping address. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetCustomerShippingAddressResponse](Models/GetCustomerShippingAddressResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCustomerShippingAddressError](Errors/GetCustomerShippingAddressError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ShippingAddressListForCustomer&gt; GetCustomerShippingAddressesList(string customerId, string? profileId, long? offset = 0L, long? limit = 20L, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customer Shipping Address**<br>A Customer Shipping Address represents tokenized customer shipping information.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Shipping Addresses](#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer), with one allocated as the Customers default for use in payments.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Retrieving all Customer Shipping Addresses**<br>Your system can use this API to retrieve all existing Shipping Addresses for a Customer.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerShippingAddress.GetCustomerShippingAddressesList(customerId, profileId);
    // TODO: Handle 'response' of type ShippingAddressListForCustomer
}
catch (SdkException<GetCustomerShippingAddressesListError> ex)
{
    if (ex.Error.TryGetGetCustomerShippingAddressesListException1(out var error))
    {
        // TODO: Handle 'error' of type GetCustomerShippingAddressesListException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Id of a Customer. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |
| <code>offset</code> | <code>long?</code> | Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0.<br>**Default**: 0L |
| <code>limit</code> | <code>long?</code> | The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100.<br>**Default**: 20L |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ShippingAddressListForCustomer](Models/ShippingAddressListForCustomer.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetCustomerShippingAddressesListError](Errors/GetCustomerShippingAddressesListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PatchCustomersShippingAddressResponse&gt; PatchCustomersShippingAddress(string customerId, string shippingAddressId, string? profileId, string? ifMatch, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customer Shipping Address**<br>A Customer Shipping Address represents tokenized customer shipping information.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Shipping Addresses](#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer), with one allocated as the Customers default for use in payments.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Updating a Customers Shipping Address**<br>Your system can use this API to update an existing Shipping Addresses for a Customer, including selecting a [default Shipping Address](#token-management_customer-shipping-address_update-a-customer-shipping-address_samplerequests-dropdown_make-customer-shipping-address-the-default_liveconsole-tab-request-body) for use in payments.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerShippingAddress.PatchCustomersShippingAddress(customerId,
        shippingAddressId,
        profileId,
        ifMatch);
    // TODO: Handle 'response' of type PatchCustomersShippingAddressResponse
}
catch (SdkException<PatchCustomersShippingAddressError> ex)
{
    if (ex.Error.TryGetPatchCustomersShippingAddressException1(out var error))
    {
        // TODO: Handle 'error' of type PatchCustomersShippingAddressException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Id of a Customer. |
| <code>shippingAddressId</code> | <code>string</code> | The Id of a shipping address. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |
| <code>ifMatch</code> | <code>string?</code> | Contains an ETag value from a GET request to make the request conditional. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PatchCustomersShippingAddressResponse](Models/PatchCustomersShippingAddressResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchCustomersShippingAddressError](Errors/PatchCustomersShippingAddressError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostCustomerShippingAddressResponse&gt; PostCustomerShippingAddress(string customerId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Customer Shipping Address**<br>A Customer Shipping Address represents tokenized customer shipping information.<br>A [Customer](#token-management_customer_create-a-customer) can have [one or more Shipping Addresses](#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer), with one allocated as the Customers default for use in payments.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Creating a Customer Shipping Address**<br>Your system can use this API to create an existing Customers default or non default Shipping Address.<br>You can also create additional Customer Shipping Addresses via the [Payments API](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-create-default-payment-instrument-shipping-address-for-existing-customer_liveconsole-tab-request-body).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CustomerShippingAddress.PostCustomerShippingAddress(customerId, profileId);
    // TODO: Handle 'response' of type PostCustomerShippingAddressResponse
}
catch (SdkException<PostCustomerShippingAddressError> ex)
{
    if (ex.Error.TryGetPostCustomerShippingAddressException1(out var error))
    {
        // TODO: Handle 'error' of type PostCustomerShippingAddressException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>customerId</code> | <code>string</code> | The Id of a Customer. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostCustomerShippingAddressResponse](Models/PostCustomerShippingAddressResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostCustomerShippingAddressError](Errors/PostCustomerShippingAddressError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DecisionManager

> Source: [DecisionManager](Api/DecisionManager.cs)

<details>
<summary><code>Task&lt;ActionDecisionManagerCaseResponse&gt; ActionDecisionManagerCase(string id, CaseManagementActionsRequest caseManagementActionsRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Take action on a DM post-transactional case

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DecisionManager.ActionDecisionManagerCase(id, caseManagementActionsRequest);
    // TODO: Handle 'response' of type ActionDecisionManagerCaseResponse
}
catch (SdkException<ActionDecisionManagerCaseError> ex)
{
    if (ex.Error.TryGetActionDecisionManagerCaseException1(out var error))
    {
        // TODO: Handle 'error' of type ActionDecisionManagerCaseException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | An unique identification number generated by Cybersource to identify the submitted request. |
| <code>caseManagementActionsRequest</code> | <code>[CaseManagementActionsRequest](Models/CaseManagementActionsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ActionDecisionManagerCaseResponse](Models/ActionDecisionManagerCaseResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ActionDecisionManagerCaseError](Errors/ActionDecisionManagerCaseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AddNegative(string type, AddNegativeListRequest addNegativeListRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This call adds/deletes/converts the request information in the negative list.

Provide the list to be updated as the path parameter. This value can be 'postiive', 'negative' or 'review'.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DecisionManager.AddNegative(type, addNegativeListRequest);
}
catch (SdkException<AddNegativeError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>type</code> | <code>string</code> | The list to be updated. It can be 'positive', 'negative' or 'review'. |
| <code>addNegativeListRequest</code> | <code>[AddNegativeListRequest](Models/AddNegativeListRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AddNegativeError](Errors/AddNegativeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CommentDecisionManagerCaseResponse&gt; CommentDecisionManagerCase(string id, CaseManagementCommentsRequest caseManagementCommentsRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Add a comment to a DM post-transactional case

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DecisionManager.CommentDecisionManagerCase(id, caseManagementCommentsRequest);
    // TODO: Handle 'response' of type CommentDecisionManagerCaseResponse
}
catch (SdkException<CommentDecisionManagerCaseError> ex)
{
    if (ex.Error.TryGetCommentDecisionManagerCaseException1(out var error))
    {
        // TODO: Handle 'error' of type CommentDecisionManagerCaseException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | An unique identification number generated by Cybersource to identify the submitted request. |
| <code>caseManagementCommentsRequest</code> | <code>[CaseManagementCommentsRequest](Models/CaseManagementCommentsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CommentDecisionManagerCaseResponse](Models/CommentDecisionManagerCaseResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CommentDecisionManagerCaseError](Errors/CommentDecisionManagerCaseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CreateBundledDecisionManagerCase(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Decision Manager can help you automate and streamline your fraud operations. Decision Manager will return a decision based on the request values.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DecisionManager.CreateBundledDecisionManagerCase();
}
catch (SdkException<CreateBundledDecisionManagerCaseError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateBundledDecisionManagerCaseError](Errors/CreateBundledDecisionManagerCaseError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task FraudUpdate(string id, FraudMarkingActionRequest fraudMarkingActionRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This can be used to -
1. Add known fraudulent data to the fraud history
2. Remove data added to history with Transaction Marking Tool or by uploading chargeback files
3. Remove chargeback data from history that was automatically added.
For detailed information, contact your Cybersource representative

Place the request ID of the transaction you want to mark as suspect (or remove from history) as the path parameter in this request.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DecisionManager.FraudUpdate(id, fraudMarkingActionRequest);
}
catch (SdkException<FraudUpdateError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Request ID of the transaction that you want to mark as suspect or remove from history. |
| <code>fraudMarkingActionRequest</code> | <code>[FraudMarkingActionRequest](Models/FraudMarkingActionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[FraudUpdateError](Errors/FraudUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DownloadDtd

> Source: [DownloadDtd](Api/DownloadDtd.cs)

<details>
<summary><code>Task GetDtdv2(string reportDefinitionNameVersion, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Used to download DTDs for reports on no-auth.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DownloadDtd.GetDtdv2(reportDefinitionNameVersion);
}
catch (SdkException<GetDtdv2Error> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>reportDefinitionNameVersion</code> | <code>string</code> | Name and version of DTD file to download. Some DTDs only have one version. In that case version name is not needed. Some example values are ctdr-1.0, tdr, pbdr-1.1 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetDtdv2Error](Errors/GetDtdv2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## DownloadXsd

> Source: [DownloadXsd](Api/DownloadXsd.cs)

<details>
<summary><code>Task GetXsdv2(string reportDefinitionNameVersion, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Used to download XSDs for reports on no-auth.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.DownloadXsd.GetXsdv2(reportDefinitionNameVersion);
}
catch (SdkException<GetXsdv2Error> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>reportDefinitionNameVersion</code> | <code>string</code> | Name and version of XSD file to download. Some XSDs only have one version. In that case version name is not needed. Some example values are DecisionManagerDetailReport, DecisionManagerTypes |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetXsdv2Error](Errors/GetXsdv2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## InstrumentIdentifierApi

> Source: [InstrumentIdentifierApi](Api/InstrumentIdentifierApi.cs)

<details>
<summary><code>Task DeleteInstrumentIdentifier(string instrumentIdentifierId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Instrument Identifiers**<br>An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing <br>and account numbers.<br>The same token Id is returned for a specific card number or bank account & routing number allowing the <br>Instrument Identifier Id to be used for cross-channel payment tracking.<br>An Instrument Identifier can exist independently but also be associated with a [Customer Payment Instrument](#token-management_customer-payment-instrument_create-a-customer-payment-instrument) <br>or [Standalone Payment Instrument](#token-management_payment-instrument_create-a-payment-instrument).|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Deleting an Instrument Identifier**<br>Your system can use this API to delete an existing Instrument Identifier.<br>An Instrument Identifier cannot be deleted if it is linked to any Payment Instruments.<br>You can [retrieve all Payment Instruments associated with an Instrument Identifier](#token-management_instrument-identifier_list-payment-instruments-for-an-instrument-identifier).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.InstrumentIdentifierApi.DeleteInstrumentIdentifier(instrumentIdentifierId, profileId);
}
catch (SdkException<DeleteInstrumentIdentifierError> ex)
{
    if (ex.Error.TryGetDeleteInstrumentIdentifierException1(out var error))
    {
        // TODO: Handle 'error' of type DeleteInstrumentIdentifierException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>instrumentIdentifierId</code> | <code>string</code> | The Id of an Instrument Identifier. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteInstrumentIdentifierError](Errors/DeleteInstrumentIdentifierError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetInstrumentIdentifierResponse&gt; GetInstrumentIdentifier(string instrumentIdentifierId, bool? retrieveBinDetails, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Instrument Identifiers**<br>An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing and account number.<br>The same token Id is returned for a specific card number or bank account & routing number allowing the Instrument Identifier Id to be used for cross-channel payment tracking.<br>An Instrument Identifier can exist independently but also be associated with a [Customer Payment Instrument](#token-management_customer-payment-instrument_create-a-customer-payment-instrument) or [Standalone Payment Instrument](#token-management_payment-instrument_create-a-payment-instrument).<br><br>**Retrieving an Instrument Identifier**<br>Your system can use this API to retrieve an Instrument Identifier.<br>**Note: the actual card data will be masked.**<br>The Instrument Identifier will also be returned when retrieving a [Customer](#token-management_customer_retrieve-a-customer), [Customer Payment Instrument](#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument) or [Standalone Payment Instrument](#token-management_payment-instrument_retrieve-a-payment-instrument).|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Payment Network Tokens**<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.<br>A Payment Network Token can also be [provisioned for an existing Instrument Identifier](#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token).<br>For more information about Payment Network Tokens see the Developer Guide.<br><br>**Payments with Instrument Identifiers**<br>To perform a payment with an Instrument Identifier simply specify the [Instrument Identifier Id in the payments request along with the expiration date, card type, & billing address](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-instrument-identifier-token-id_liveconsole-tab-request-body).<br>When an Instrument Identifier is used in a payment the **_previousTransactionId_** and **_originalAuthorizedAmount_** values are automatically recorded.<br>These values will be added for you to future Merchant Initiated Transaction payments.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstrumentIdentifierApi.GetInstrumentIdentifier(instrumentIdentifierId,
        retrieveBinDetails,
        profileId);
    // TODO: Handle 'response' of type GetInstrumentIdentifierResponse
}
catch (SdkException<GetInstrumentIdentifierError> ex)
{
    if (ex.Error.TryGetGetInstrumentIdentifierException1(out var error))
    {
        // TODO: Handle 'error' of type GetInstrumentIdentifierException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>instrumentIdentifierId</code> | <code>string</code> | The Id of an Instrument Identifier. |
| <code>retrieveBinDetails</code> | <code>bool?</code> | Retrieve the Bin Details of PAN or network token |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetInstrumentIdentifierResponse](Models/GetInstrumentIdentifierResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetInstrumentIdentifierError](Errors/GetInstrumentIdentifierError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrumentList&gt; GetInstrumentIdentifierPaymentInstrumentsList(string instrumentIdentifierId, bool? retrieveBinDetails, string? profileId, long? offset = 0L, long? limit = 20L, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Instrument Identifiers**<br>An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing <br>and account numbers.<br>The same token Id is returned for a specific card number or bank account & routing number allowing the <br>Instrument Identifier Id to be used for cross-channel payment tracking.<br>An Instrument Identifier can exist independently but also be associated with a [Customer Payment Instrument](#token-management_customer-payment-instrument_create-a-customer-payment-instrument) <br>or [Standalone Payment Instrument](#token-management_payment-instrument_create-a-payment-instrument).|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Retrieving all Payment Instruments associated with an Instrument Identifier**<br>Your system can use this API to retrieve all Payment Instruments linked to an Instrument Identifier.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstrumentIdentifierApi.GetInstrumentIdentifierPaymentInstrumentsList(instrumentIdentifierId,
        retrieveBinDetails,
        profileId);
    // TODO: Handle 'response' of type PaymentInstrumentList
}
catch (SdkException<GetInstrumentIdentifierPaymentInstrumentsListError> ex)
{
    if (ex.Error.TryGetGetInstrumentIdentifierPaymentInstrumentsListException1(out var error))
    {
        // TODO: Handle 'error' of type GetInstrumentIdentifierPaymentInstrumentsListException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>instrumentIdentifierId</code> | <code>string</code> | The Id of an Instrument Identifier. |
| <code>retrieveBinDetails</code> | <code>bool?</code> | Retrieve the Bin Details of PAN or network token |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |
| <code>offset</code> | <code>long?</code> | Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0.<br>**Default**: 0L |
| <code>limit</code> | <code>long?</code> | The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100.<br>**Default**: 20L |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrumentList](Models/PaymentInstrumentList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetInstrumentIdentifierPaymentInstrumentsListError](Errors/GetInstrumentIdentifierPaymentInstrumentsListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PatchInstrumentIdentifierResponse&gt; PatchInstrumentIdentifier(string instrumentIdentifierId, bool? retrieveBinDetails, string? profileId, string? ifMatch, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Instrument Identifiers**<br>An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing and account number.<br>The same token Id is returned for a specific card number or bank account & routing number allowing the Instrument Identifier Id to be used for cross-channel payment tracking.<br>An Instrument Identifier can exist independently but also be associated with a [Customer Payment Instrument](#token-management_customer-payment-instrument_create-a-customer-payment-instrument) or [Standalone Payment Instrument](#token-management_payment-instrument_create-a-payment-instrument).|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Updating an Instrument Identifier**<br>When an Instrument Identifier is used in a payment the **_previousTransactionId_** and **_originalAuthorizedAmount_** values are automatically recorded.<br>These values will be added for you to future Merchant Initiated Transaction payments.<br>Your system can use this API to update these values.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstrumentIdentifierApi.PatchInstrumentIdentifier(instrumentIdentifierId,
        retrieveBinDetails,
        profileId,
        ifMatch);
    // TODO: Handle 'response' of type PatchInstrumentIdentifierResponse
}
catch (SdkException<PatchInstrumentIdentifierError> ex)
{
    if (ex.Error.TryGetPatchInstrumentIdentifierException1(out var error))
    {
        // TODO: Handle 'error' of type PatchInstrumentIdentifierException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>instrumentIdentifierId</code> | <code>string</code> | The Id of an Instrument Identifier. |
| <code>retrieveBinDetails</code> | <code>bool?</code> | Retrieve the Bin Details of PAN or network token |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |
| <code>ifMatch</code> | <code>string?</code> | Contains an ETag value from a GET request to make the request conditional. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PatchInstrumentIdentifierResponse](Models/PatchInstrumentIdentifierResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchInstrumentIdentifierError](Errors/PatchInstrumentIdentifierError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostInstrumentIdentifierResponse&gt; PostInstrumentIdentifier(bool? retrieveBinDetails, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Instrument Identifiers**<br>An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing and account number.<br>The same token Id is returned for a specific card number or bank account & routing number allowing the Instrument Identifier Id to be used for cross-channel payment tracking.<br>An Instrument Identifier can exist independently but also be associated with a [Customer Payment Instrument](#token-management_customer-payment-instrument_create-a-customer-payment-instrument) or [Standalone Payment Instrument](#token-management_payment-instrument_create-a-payment-instrument).<br><br>**Creating an Instrument Identifier**<br>It is recommended you [create an Instrument Identifier via a Payment Authorization](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-instrument-identifier-token-creation_liveconsole-tab-request-body), this can be for a zero amount.<br>An Instrument Identifier will also be created if you [create a Customer via a Payment Authorization](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-customer-token-creation_liveconsole-tab-request-body)<br>In Europe: You should perform Payer Authentication alongside the Authorization.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Payment Network Tokens**<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.<br>A Payment Network Token can also be [provisioned for an existing Instrument Identifier](#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token).<br>For more information about Payment Network Tokens see the Developer Guide.<br><br>**Payments with Instrument Identifiers**<br>To perform a payment with an Instrument Identifier simply specify the [Instrument Identifier Id in the payments request along with the expiration date, card type, & billing address](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-instrument-identifier-token-id_liveconsole-tab-request-body).<br>When an Instrument Identifier is used in a payment the **_previousTransactionId_** and **_originalAuthorizedAmount_** values are automatically recorded.<br>These values will be added for you to future Merchant Initiated Transaction payments.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstrumentIdentifierApi.PostInstrumentIdentifier(retrieveBinDetails, profileId);
    // TODO: Handle 'response' of type PostInstrumentIdentifierResponse
}
catch (SdkException<PostInstrumentIdentifierError> ex)
{
    if (ex.Error.TryGetPostInstrumentIdentifierException1(out var error))
    {
        // TODO: Handle 'error' of type PostInstrumentIdentifierException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>retrieveBinDetails</code> | <code>bool?</code> | Retrieve the Bin Details of PAN or network token |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostInstrumentIdentifierResponse](Models/PostInstrumentIdentifierResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostInstrumentIdentifierError](Errors/PostInstrumentIdentifierError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostInstrumentIdentifierEnrollment(string instrumentIdentifierId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Instrument Identifiers**<br>An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing and account number.<br>The same token Id is returned for a specific card number or bank account & routing number allowing the Instrument Identifier Id to be used for cross-channel payment tracking.<br>An Instrument Identifier can exist independently but also be associated with a [Customer Payment Instrument](#token-management_customer-payment-instrument_create-a-customer-payment-instrument) or [Standalone Payment Instrument](#token-management_payment-instrument_create-a-payment-instrument).|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Enroll an Instrument Identifier for a Payment Network Token**<br>Your system can use this API to provision a Network token for an existing Instrument Identifier.<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Network token can be [provisioned when creating an Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier_samplerequests-dropdown_create-instrument-identifier-card-enroll-for-network-token_liveconsole-tab-request-body).This will occur automatically when creating a [Customer](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-customer-token-creation_liveconsole-tab-request-body), [Payment Instrument](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-create-default-payment-instrument-shipping-address-for-existing-customer_liveconsole-tab-request-body) or [Instrument Identifier](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-instrument-identifier-token-creation_liveconsole-tab-request-body) via the Payments API.<br>For more information about Payment Network Tokens see the Developer Guide.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.InstrumentIdentifierApi.PostInstrumentIdentifierEnrollment(instrumentIdentifierId, profileId);
}
catch (SdkException<PostInstrumentIdentifierEnrollmentError> ex)
{
    if (ex.Error.TryGetPostInstrumentIdentifierEnrollmentException1(out var error))
    {
        // TODO: Handle 'error' of type PostInstrumentIdentifierEnrollmentException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>instrumentIdentifierId</code> | <code>string</code> | The Id of an Instrument Identifier. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostInstrumentIdentifierEnrollmentError](Errors/PostInstrumentIdentifierEnrollmentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## InterchangeClearingLevelDetails

> Source: [InterchangeClearingLevelDetails](Api/InterchangeClearingLevelDetails.cs)

<details>
<summary><code>Task GetInterchangeClearingLevelDetails(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Interchange Clearing Level data for an account or a merchant

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.InterchangeClearingLevelDetails.GetInterchangeClearingLevelDetails(startTime,
        endTime,
        organizationId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>DateTimeOffset</code> | Valid report Start Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>endTime</code> | <code>DateTimeOffset</code> | Valid report End Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## InvoiceSettings

> Source: [InvoiceSettings](Api/InvoiceSettings.cs)

<details>
<summary><code>Task&lt;InvoicingV2InvoiceSettingsGet200Response&gt; GetInvoiceSettings(ProductType? productType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows you to retrieve the invoice settings for the payment page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceSettings.GetInvoiceSettings(productType);
    // TODO: Handle 'response' of type InvoicingV2InvoiceSettingsGet200Response
}
catch (SdkException<GetInvoiceSettingsError> ex)
{
    if (ex.Error.TryGetInvoicingV2InvoiceSettingsGet400Response1(out var error))
    {
        // TODO: Handle 'error' of type InvoicingV2InvoiceSettingsGet400Response1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>productType</code> | <code>[ProductType?](Models/Enums/ProductType.cs)</code> | Allows you to choose which product type settings you want to update. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicingV2InvoiceSettingsGet200Response](Models/InvoicingV2InvoiceSettingsGet200Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetInvoiceSettingsError](Errors/GetInvoiceSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoicingV2InvoiceSettingsPut200Response&gt; UpdateInvoiceSettings(ProductType? productType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows you to customize the payment page, the checkout experience, email communication and payer authentication. You can customize the invoice to match your brand with your business name, logo and brand colors, and a VAT Tax number. You can choose to capture the payers shipping details, phone number and email during the checkout process. You can add a custom message to all invoice emails and enable or disable payer authentication for invoice payments.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvoiceSettings.UpdateInvoiceSettings(productType);
    // TODO: Handle 'response' of type InvoicingV2InvoiceSettingsPut200Response
}
catch (SdkException<UpdateInvoiceSettingsError> ex)
{
    if (ex.Error.TryGetInvoicingV2InvoiceSettingsPut400Response1(out var error))
    {
        // TODO: Handle 'error' of type InvoicingV2InvoiceSettingsPut400Response1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>productType</code> | <code>[ProductType?](Models/Enums/ProductType.cs)</code> | Allows you to choose which product type settings you want to update. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicingV2InvoiceSettingsPut200Response](Models/InvoicingV2InvoiceSettingsPut200Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateInvoiceSettingsError](Errors/UpdateInvoiceSettingsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Invoices

> Source: [Invoices](Api/Invoices.cs)

<details>
<summary><code>Task&lt;InvoicingV2InvoicesPost201Response&gt; CreateInvoice(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The invoicing product enables you to bill any customer with an email address and accept digital payments securely from any connected device. You can either use the system generated email or use the invoice payment link in your own communication. You can add discounts and taxes for the entire invoice or for each line item. To customize the invoice to match your brand see [Invoice Settings](https://developer.cybersource.com/api-reference-assets/index.html#invoicing_invoice-settings_update-invoice-settings). The invoice payment page uses Unified Checkout to process the payments.
The availability of API features for a merchant can depend on the portfolio configuration and may need to be enabled at the portfolio level before they can be added to merchant accounts.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.CreateInvoice();
    // TODO: Handle 'response' of type InvoicingV2InvoicesPost201Response
}
catch (SdkException<CreateInvoiceError> ex)
{
    if (ex.Error.TryGetInvoicingV2InvoicesPost400Response1(out var error))
    {
        // TODO: Handle 'error' of type InvoicingV2InvoicesPost400Response1
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicingV2InvoicesPost201Response](Models/InvoicingV2InvoicesPost201Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateInvoiceError](Errors/CreateInvoiceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoicingV2InvoicesAllGet200Response&gt; GetAllInvoices(int offset, int limit, string? status, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides a (filtered) list of invoices that have been created in your account. You can filter the list based on Invoice Status by setting the status query parameter to one of DRAFT, CREATED, SENT, PARTIAL, PAID or CANCELED.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.GetAllInvoices(offset, limit, status);
    // TODO: Handle 'response' of type InvoicingV2InvoicesAllGet200Response
}
catch (SdkException<GetAllInvoicesError> ex)
{
    if (ex.Error.TryGetInvoicingV2InvoicesAllGet400Response1(out var error))
    {
        // TODO: Handle 'error' of type InvoicingV2InvoicesAllGet400Response1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>offset</code> | <code>int</code> | Page offset number. |
| <code>limit</code> | <code>int</code> | Maximum number of items you would like returned. |
| <code>status</code> | <code>string?</code> | The status of the invoice.<br><br>Possible values:<br>  - DRAFT<br>  - CREATED<br>  - SENT<br>  - PARTIAL<br>  - PAID<br>  - CANCELED |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicingV2InvoicesAllGet200Response](Models/InvoicingV2InvoicesAllGet200Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAllInvoicesError](Errors/GetAllInvoicesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoicingV2InvoicesGet200Response&gt; GetInvoice(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You can retrieve details of a specific invoice. This can be used to check the Invoice status and get a list of invoice payments in the invoice history section of the response. For each payment transaction you can use the Transaction Details API to get more details on the payment transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.GetInvoice(id);
    // TODO: Handle 'response' of type InvoicingV2InvoicesGet200Response
}
catch (SdkException<GetInvoiceError> ex)
{
    if (ex.Error.TryGetInvoicingV2InvoicesGet400Response1(out var error))
    {
        // TODO: Handle 'error' of type InvoicingV2InvoicesGet400Response1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The invoice number. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicingV2InvoicesGet200Response](Models/InvoicingV2InvoicesGet200Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetInvoiceError](Errors/GetInvoiceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoicingV2InvoicesCancel200Response&gt; PerformCancelAction(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You can cancel an invoice if no payment is made to it. You cannot cancel partially or fully paid invoices.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.PerformCancelAction(id);
    // TODO: Handle 'response' of type InvoicingV2InvoicesCancel200Response
}
catch (SdkException<PerformCancelActionError> ex)
{
    if (ex.Error.TryGetInvoicingV2InvoicesCancel400Response1(out var error))
    {
        // TODO: Handle 'error' of type InvoicingV2InvoicesCancel400Response1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The invoice number. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicingV2InvoicesCancel200Response](Models/InvoicingV2InvoicesCancel200Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PerformCancelActionError](Errors/PerformCancelActionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoicingV2InvoicesPublish200Response&gt; PerformPublishAction(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You can publish an invoice in DRAFT status. After invoking this method, the invoice status is changed to CREATED.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.PerformPublishAction(id);
    // TODO: Handle 'response' of type InvoicingV2InvoicesPublish200Response
}
catch (SdkException<PerformPublishActionError> ex)
{
    if (ex.Error.TryGetInvoicingV2InvoicesPublish400Response1(out var error))
    {
        // TODO: Handle 'error' of type InvoicingV2InvoicesPublish400Response1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The invoice number. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicingV2InvoicesPublish200Response](Models/InvoicingV2InvoicesPublish200Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PerformPublishActionError](Errors/PerformPublishActionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoicingV2InvoicesSend200Response&gt; PerformSendAction(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You can send an invoice in draft or created state or resend a sent or partially paid invoice. Fully paid or canceled invoices cannot be resent.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.PerformSendAction(id);
    // TODO: Handle 'response' of type InvoicingV2InvoicesSend200Response
}
catch (SdkException<PerformSendActionError> ex)
{
    if (ex.Error.TryGetInvoicingV2InvoicesSend400Response1(out var error))
    {
        // TODO: Handle 'error' of type InvoicingV2InvoicesSend400Response1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The invoice number. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicingV2InvoicesSend200Response](Models/InvoicingV2InvoicesSend200Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PerformSendActionError](Errors/PerformSendActionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvoicingV2InvoicesPut200Response&gt; UpdateInvoice(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

You can update all information except the invoice number till any payment is received for an invoice. Invoices that are partially or fully paid or cancelled cannot be updated.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Invoices.UpdateInvoice(id);
    // TODO: Handle 'response' of type InvoicingV2InvoicesPut200Response
}
catch (SdkException<UpdateInvoiceError> ex)
{
    if (ex.Error.TryGetInvoicingV2InvoicesPut400Response1(out var error))
    {
        // TODO: Handle 'error' of type InvoicingV2InvoicesPut400Response1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The invoice number. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvoicingV2InvoicesPut200Response](Models/InvoicingV2InvoicesPut200Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateInvoiceError](Errors/UpdateInvoiceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MerchantDefinedFields

> Source: [MerchantDefinedFields](Api/MerchantDefinedFields.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CreateMerchantDefinedFieldDefinitionResponse&gt;&gt; CreateMerchantDefinedFieldDefinition(ReferenceType referenceType, MerchantDefinedFieldDefinitionRequest merchantDefinedFieldDefinitionRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create merchant defined field for a given reference type

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantDefinedFields.CreateMerchantDefinedFieldDefinition(referenceType,
        merchantDefinedFieldDefinitionRequest);
    // TODO: Handle 'response' of type IReadOnlyList<CreateMerchantDefinedFieldDefinitionResponse>
}
catch (SdkException<CreateMerchantDefinedFieldDefinitionError> ex)
{
    if (ex.Error.TryGetCreateMerchantDefinedFieldDefinitionException1(out var error))
    {
        // TODO: Handle 'error' of type CreateMerchantDefinedFieldDefinitionException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>referenceType</code> | <code>[ReferenceType](Models/Enums/ReferenceType.cs)</code> | The reference type for which merchant defined fields are to be fetched. Available values are Invoice, Purchase, Donation |
| <code>merchantDefinedFieldDefinitionRequest</code> | <code>[MerchantDefinedFieldDefinitionRequest](Models/MerchantDefinedFieldDefinitionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[CreateMerchantDefinedFieldDefinitionResponse](Models/CreateMerchantDefinedFieldDefinitionResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateMerchantDefinedFieldDefinitionError](Errors/CreateMerchantDefinedFieldDefinitionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteMerchantDefinedFieldsDefinitions(ReferenceType referenceType, long id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a MerchantDefinedField by ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.MerchantDefinedFields.DeleteMerchantDefinedFieldsDefinitions(referenceType, id);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>referenceType</code> | <code>[ReferenceType](Models/Enums/ReferenceType.cs)</code> | - |
| <code>id</code> | <code>long</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;GetMerchantDefinedFieldsDefinitionsResponse&gt;&gt; GetMerchantDefinedFieldsDefinitions(ReferenceType referenceType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get all merchant defined fields for a given reference type

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.MerchantDefinedFields.GetMerchantDefinedFieldsDefinitions(referenceType);
    // TODO: Handle 'response' of type IReadOnlyList<GetMerchantDefinedFieldsDefinitionsResponse>
}
catch (SdkException<GetMerchantDefinedFieldsDefinitionsError> ex)
{
    if (ex.Error.TryGetGetMerchantDefinedFieldsDefinitionsException1(out var error))
    {
        // TODO: Handle 'error' of type GetMerchantDefinedFieldsDefinitionsException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>referenceType</code> | <code>[ReferenceType](Models/Enums/ReferenceType.cs)</code> | The reference type for which merchant defined fields are to be fetched. Available values are Invoice, Purchase, Donation |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[GetMerchantDefinedFieldsDefinitionsResponse](Models/GetMerchantDefinedFieldsDefinitionsResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetMerchantDefinedFieldsDefinitionsError](Errors/GetMerchantDefinedFieldsDefinitionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PutMerchantDefinedFieldsDefinitions(ReferenceType referenceType, long id, MerchantDefinedFieldCore merchantDefinedFieldCore, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a MerchantDefinedField by ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.MerchantDefinedFields.PutMerchantDefinedFieldsDefinitions(referenceType,
        id,
        merchantDefinedFieldCore);
}
catch (SdkException<PutMerchantDefinedFieldsDefinitionsError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>referenceType</code> | <code>[ReferenceType](Models/Enums/ReferenceType.cs)</code> | - |
| <code>id</code> | <code>long</code> | - |
| <code>merchantDefinedFieldCore</code> | <code>[MerchantDefinedFieldCore](Models/MerchantDefinedFieldCore.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PutMerchantDefinedFieldsDefinitionsError](Errors/PutMerchantDefinedFieldsDefinitionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## MicroformIntegration

> Source: [MicroformIntegration](Api/MicroformIntegration.cs)

<details>
<summary><code>Task GenerateCaptureContext(GenerateCaptureContextRequest generateCaptureContextRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API is used to generate the Capture Context data structure for the Microform Integration.  Microform is a browser-based acceptance solution that allows a seller to capture payment information is a secure manner from their website.  For more information about Flex Microform transactions, see the [Flex Developer Guides Page](https://developer.cybersource.com/api/developer-guides/dita-flex/SAFlexibleToken.html). For examples on how to integrate Flex Microform within your webpage please see our [GitHub Flex Samples](https://github.com/CyberSource?q=flex&type=&language=) This API is a server-to-server API to generate the capture context that can be used to initiate instance of microform on a acceptance page.  The capture context is a digitally signed JWT that provides authentication, one-time keys, and the target origin to the Microform Integration application.  The availability of API features for a merchant may depend on the portfolio configuration and may need to be enabled at the portfolio level before they can be added to merchant accounts.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.MicroformIntegration.GenerateCaptureContext(generateCaptureContextRequest);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>generateCaptureContextRequest</code> | <code>[GenerateCaptureContextRequest](Models/GenerateCaptureContextRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## NetFundings

> Source: [NetFundings](Api/NetFundings.cs)

<details>
<summary><code>Task GetNetFundingDetails(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, string? groupName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get Netfunding information for an account or a merchant.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.NetFundings.GetNetFundingDetails(startTime, endTime, organizationId, groupName);
}
catch (SdkException<GetNetFundingDetailsError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>DateTimeOffset</code> | Valid report Start Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>endTime</code> | <code>DateTimeOffset</code> | Valid report End Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |
| <code>groupName</code> | <code>string?</code> | Valid CyberSource Group Name. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetNetFundingDetailsError](Errors/GetNetFundingDetailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## NetworkTokens

> Source: [NetworkTokens](Api/NetworkTokens.cs)

<details>
<summary><code>Task&lt;GetCardArtAssetResponse&gt; GetCardArtAsset(string instrumentIdentifierId, TokenProvider tokenProvider, AssetType assetType, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves Card Art for a specific Instrument Identifier. The Card Art is a visual representation of the cardholder's payment card.
Card Art is only available if a Network Token is successfully provisioned.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.NetworkTokens.GetCardArtAsset(instrumentIdentifierId, tokenProvider, assetType);
    // TODO: Handle 'response' of type GetCardArtAssetResponse
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>instrumentIdentifierId</code> | <code>string</code> | The Id of an Instrument Identifier. |
| <code>tokenProvider</code> | <code>[TokenProvider](Models/Enums/TokenProvider.cs)</code> | The token provider. |
| <code>assetType</code> | <code>[AssetType](Models/Enums/AssetType.cs)</code> | The type of asset. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetCardArtAssetResponse](Models/GetCardArtAssetResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetTokenizedCardResponse&gt; GetTokenizedCard(string tokenizedCardId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|**Tokenized Cards**<br>A Tokenized Card represents a network token.
Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.
This API returns the details of a tokenized card stored in TMS. You can use this API to check the status of a tokenized card and retrieve details such as the last four digits of the underlying card, expiration date, and card type.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.NetworkTokens.GetTokenizedCard(tokenizedCardId, profileId);
    // TODO: Handle 'response' of type GetTokenizedCardResponse
}
catch (SdkException<GetTokenizedCardError> ex)
{
    if (ex.Error.TryGetGetTokenizedCardException1(out var error))
    {
        // TODO: Handle 'error' of type GetTokenizedCardException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>tokenizedCardId</code> | <code>string</code> | The Id of a tokenized card. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetTokenizedCardResponse](Models/GetTokenizedCardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTokenizedCardError](Errors/GetTokenizedCardError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostIssuerLifeCycleSimulation(string tokenizedCardId, string profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Lifecycle Management Events**<br>Simulates an issuer life cycle manegement event for updates on the tokenized card.
The events that can be simulated are:
- Token status changes (e.g. active, suspended, deleted)
- Updates to the underlying card, including card art changes, expiration date changes, and card number suffix.
**Note:** This is only available in CAS environment.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.NetworkTokens.PostIssuerLifeCycleSimulation(tokenizedCardId, profileId);
}
catch (SdkException<PostIssuerLifeCycleSimulationError> ex)
{
    if (ex.Error.TryGetPostIssuerLifeCycleSimulationException1(out var error))
    {
        // TODO: Handle 'error' of type PostIssuerLifeCycleSimulationException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>tokenizedCardId</code> | <code>string</code> | The Id of a tokenized card. |
| <code>profileId</code> | <code>string</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostIssuerLifeCycleSimulationError](Errors/PostIssuerLifeCycleSimulationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostTokenPaymentCredentials(string tokenId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Note**: This resource will be replace by [payment credentials version 3](#/paths/~1tms~1v3~1tokens~1{tokenId}~1payment-credentials/post). The SDK will remain available for now; however, it will no longer be documented or maintain in the Developer Centre.<br>
**Token**<br>A Token can represent your tokenized Customer, Payment Instrument, Instrument Identifier or Tokenized Card information.<br>
**Payment Credentials**<br>Contains payment information such as the network token, generated cryptogram for Visa & MasterCard or dynamic CVV for Amex in a JSON Web Encryption (JWE) response.<br>Your system can use this API to retrieve the Payment Credentials for an existing Customer, Payment Instrument, Instrument Identifier or Tokenized Card.<br>Optionally, **authenticated identities** information from Passkey authentication can be provided to potentially achieve liability shift, which may result in the return of an e-commerce indicator of 5 if successful.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.NetworkTokens.PostTokenPaymentCredentials(tokenId, profileId);
}
catch (SdkException<PostTokenPaymentCredentialsError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>tokenId</code> | <code>string</code> | The Id of a token representing a Customer, Payment Instrument or Instrument Identifier. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTokenPaymentCredentialsError](Errors/PostTokenPaymentCredentialsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostTokenPaymentCredentialsV3(string tokenId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Payment Credentials**<br>Contains payment information such as the network token, generated TAVV cryptogram for Visa & MasterCard, dynamic CVV for Amex, or DTVV cryptogram for VISA. This latest version (v3) returns the Primary Account Number details, if the network token is not present. The response is provided in JSON Web Encryption (JWE) format. <br>Your system can use this API to retrieve the Payment Credentials for an existing Customer, Payment Instrument, Instrument Identifier or Tokenized Card.<br>Optionally, **authenticated identities** information from Passkey authentication can be provided to potentially achieve liability shift, which may result in the return of an e-commerce indicator of 5 if successful.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.NetworkTokens.PostTokenPaymentCredentialsV3(tokenId, profileId);
}
catch (SdkException<PostTokenPaymentCredentialsV3Error> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>tokenId</code> | <code>string</code> | The Id of a token representing a Customer, Payment Instrument or Instrument Identifier. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTokenPaymentCredentialsV3Error](Errors/PostTokenPaymentCredentialsV3Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PostTokenizedCardResponse&gt; PostTokenizedCard(string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Tokenized cards**<br>A Tokenized card represents a network token.
Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.
This API submits a request to the card association to create a network token. If successful, a tokenized card will be created in TMS to represent the network token.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.NetworkTokens.PostTokenizedCard(profileId);
    // TODO: Handle 'response' of type PostTokenizedCardResponse
}
catch (SdkException<PostTokenizedCardError> ex)
{
    if (ex.Error.TryGetPostTokenizedCardException1(out var error))
    {
        // TODO: Handle 'error' of type PostTokenizedCardException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PostTokenizedCardResponse](Models/PostTokenizedCardResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTokenizedCardError](Errors/PostTokenizedCardError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostTokenizedCardDelete(string tokenizedCardId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API attempts to delete a network token from the card association with a specified reason. |
If successful, the corresponding tokenized card will be deleted. |
The reason for deletion can be specified to provide context for the deletion operation.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.NetworkTokens.PostTokenizedCardDelete(tokenizedCardId, profileId);
}
catch (SdkException<PostTokenizedCardDeleteError> ex)
{
    if (ex.Error.TryGetPostTokenizedCardDeleteException1(out var error))
    {
        // TODO: Handle 'error' of type PostTokenizedCardDeleteException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>tokenizedCardId</code> | <code>string</code> | The Id of a tokenized card. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostTokenizedCardDeleteError](Errors/PostTokenizedCardDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## NotificationOfChanges

> Source: [NotificationOfChanges](Api/NotificationOfChanges.cs)

<details>
<summary><code>Task GetNotificationOfChangeReport(DateTimeOffset startTime, DateTimeOffset endTime, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download the Notification of Change report. This report shows eCheck-related fields updated as a result of a response to an eCheck settlement transaction.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.NotificationOfChanges.GetNotificationOfChangeReport(startTime, endTime);
}
catch (SdkException<GetNotificationOfChangeReportError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>DateTimeOffset</code> | Valid report Start Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>endTime</code> | <code>DateTimeOffset</code> | Valid report End Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetNotificationOfChangeReportError](Errors/GetNotificationOfChangeReportError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PayerAuthentication

> Source: [PayerAuthentication](Api/PayerAuthentication.cs)

<details>
<summary><code>Task CheckPayerAuthEnrollment(CheckPayerAuthEnrollmentRequest checkPayerAuthEnrollmentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This call verifies that the card is enrolled in a card authentication program.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PayerAuthentication.CheckPayerAuthEnrollment(checkPayerAuthEnrollmentRequest);
}
catch (SdkException<CheckPayerAuthEnrollmentError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>checkPayerAuthEnrollmentRequest</code> | <code>[CheckPayerAuthEnrollmentRequest](Models/CheckPayerAuthEnrollmentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CheckPayerAuthEnrollmentError](Errors/CheckPayerAuthEnrollmentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PayerAuthSetup(PayerAuthSetupRequest payerAuthSetupRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A new service for Merchants to get reference_id for Digital Wallets to use in place of BIN number in Cardinal. Set up file while authenticating with Cardinal. This service should be called by Merchant when payment instrument chosen or changes. This service has to be called before enrollment check. The availability of API features for a merchant may depend on the portfolio configuration and may need to be enabled at the portfolio level before they can be added to merchant accounts.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PayerAuthentication.PayerAuthSetup(payerAuthSetupRequest);
}
catch (SdkException<PayerAuthSetupError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>payerAuthSetupRequest</code> | <code>[PayerAuthSetupRequest](Models/PayerAuthSetupRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PayerAuthSetupError](Errors/PayerAuthSetupError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task ValidateAuthenticationResults(ValidateRequest validateRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This call retrieves and validates the authentication results from issuer and allows the merchant to proceed with processing the payment.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PayerAuthentication.ValidateAuthenticationResults(validateRequest);
}
catch (SdkException<ValidateAuthenticationResultsError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>validateRequest</code> | <code>[ValidateRequest](Models/ValidateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ValidateAuthenticationResultsError](Errors/ValidateAuthenticationResultsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentBatchSummaries

> Source: [PaymentBatchSummaries](Api/PaymentBatchSummaries.cs)

<details>
<summary><code>Task GetPaymentBatchSummary(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, string? rollUp, string? breakdown, int? startDayOfWeek, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Scope can be either account/merchant or reseller.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PaymentBatchSummaries.GetPaymentBatchSummary(startTime,
        endTime,
        organizationId,
        rollUp,
        breakdown,
        startDayOfWeek);
}
catch (SdkException<GetPaymentBatchSummaryError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>DateTimeOffset</code> | Valid report Start Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>endTime</code> | <code>DateTimeOffset</code> | Valid report End Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |
| <code>rollUp</code> | <code>string?</code> | Conditional - RollUp for data for day/week/month. Required while getting breakdown data for a Merchant |
| <code>breakdown</code> | <code>string?</code> | Conditional - Breakdown on account_rollup/all_merchant/selected_merchant. Required while getting breakdown data for a Merchant. |
| <code>startDayOfWeek</code> | <code>int?</code> | Optional - Start day of week to breakdown data for weeks in a month |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPaymentBatchSummaryError](Errors/GetPaymentBatchSummaryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentInstrumentApi

> Source: [PaymentInstrumentApi](Api/PaymentInstrumentApi.cs)

<details>
<summary><code>Task DeletePaymentInstrument(string paymentInstrumentId, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Standalone Payment Instruments**<br>A Payment Instrument represents tokenized payment information such as expiration date, billing address & card type.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>**Standalone Payment Instruments do not belong to a [Customer](#token-management_customer_create-a-customer).**|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Deleting a Payment Instrument**<br>Your system can use this API to delete an existing Payment Instrument.<br>Any Instrument Identifiers representing the card number will also be deleted if they are not associated with any other Payment Instruments.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PaymentInstrumentApi.DeletePaymentInstrument(paymentInstrumentId, profileId);
}
catch (SdkException<DeletePaymentInstrumentError> ex)
{
    if (ex.Error.TryGetDeletePaymentInstrumentException1(out var error))
    {
        // TODO: Handle 'error' of type DeletePaymentInstrumentException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentInstrumentId</code> | <code>string</code> | The Id of a payment instrument. |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeletePaymentInstrumentError](Errors/DeletePaymentInstrumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrument11&gt; GetPaymentInstrument(string paymentInstrumentId, bool? retrieveBinDetails, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Standalone Payment Instruments**<br>A Payment Instrument represents tokenized payment information such as expiration date, billing address & card type.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>**Standalone Payment Instruments do not belong to a [Customer](#token-management_customer_create-a-customer).**|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Retrieving a Payment Instrument**<br>Your system can use this API to retrieve an existing Payment Instrument.<br>To perform a payment with a particular Payment Instrument simply specify the [Payment Instrument Id in the payments request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstrumentApi.GetPaymentInstrument(paymentInstrumentId,
        retrieveBinDetails,
        profileId);
    // TODO: Handle 'response' of type PaymentInstrument11
}
catch (SdkException<GetPaymentInstrumentError> ex)
{
    if (ex.Error.TryGetGetPaymentInstrumentException1(out var error))
    {
        // TODO: Handle 'error' of type GetPaymentInstrumentException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentInstrumentId</code> | <code>string</code> | The Id of a payment instrument. |
| <code>retrieveBinDetails</code> | <code>bool?</code> | Retrieve the Bin Details of PAN or network token |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrument11](Models/PaymentInstrument11.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPaymentInstrumentError](Errors/GetPaymentInstrumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrument11&gt; PatchPaymentInstrument(string paymentInstrumentId, bool? retrieveBinDetails, string? profileId, string? ifMatch, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Standalone Payment Instruments**<br>A Payment Instrument represents tokenized payment information such as expiration date, billing address & card type.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>**Standalone Payment Instruments do not belong to a [Customer](#token-management_customer_create-a-customer).**|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Updating a Payment Instrument**<br>Your system can use this API to update an existing Payment Instrument.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstrumentApi.PatchPaymentInstrument(paymentInstrumentId,
        retrieveBinDetails,
        profileId,
        ifMatch);
    // TODO: Handle 'response' of type PaymentInstrument11
}
catch (SdkException<PatchPaymentInstrumentError> ex)
{
    if (ex.Error.TryGetPatchPaymentInstrumentException1(out var error))
    {
        // TODO: Handle 'error' of type PatchPaymentInstrumentException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>paymentInstrumentId</code> | <code>string</code> | The Id of a payment instrument. |
| <code>retrieveBinDetails</code> | <code>bool?</code> | Retrieve the Bin Details of PAN or network token |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |
| <code>ifMatch</code> | <code>string?</code> | Contains an ETag value from a GET request to make the request conditional. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrument11](Models/PaymentInstrument11.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PatchPaymentInstrumentError](Errors/PatchPaymentInstrumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInstrument11&gt; PostPaymentInstrument(bool? retrieveBinDetails, string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |
| --- | --- | --- |
|**Standalone Payment Instruments**<br>A Payment Instrument represents tokenized payment information such as expiration date, billing address & card type.<br>A Payment Instrument token does not store the card number. A Payment Instrument is associated with an [Instrument Identifier](#token-management_instrument-identifier_create-an-instrument-identifier) that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.<br>**Standalone Payment Instruments do not belong to a [Customer](#token-management_customer_create-a-customer).**<br><br>**Creating a Payment Instrument**<br>It is recommended you [create a Payment Instrument via a Payment Authorization](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-customer-token-creation_liveconsole-tab-request-body), this can be for a zero amount.<br>In Europe: You should perform Payer Authentication alongside the Authorization.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|**Payment Network Tokens**<br>Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.<br>A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.<br>A Payment Network Token can also be [provisioned for an existing Instrument Identifier](#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token).<br>For more information about Payment Network Tokens see the Developer Guide.<br><br>**Payments with Payment Instruments**<br>To perform a payment with a particular Payment Instrument specify the [Payment Instrument in the payment request](#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInstrumentApi.PostPaymentInstrument(retrieveBinDetails, profileId);
    // TODO: Handle 'response' of type PaymentInstrument11
}
catch (SdkException<PostPaymentInstrumentError> ex)
{
    if (ex.Error.TryGetPostPaymentInstrumentException1(out var error))
    {
        // TODO: Handle 'error' of type PostPaymentInstrumentException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>retrieveBinDetails</code> | <code>bool?</code> | Retrieve the Bin Details of PAN or network token |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInstrument11](Models/PaymentInstrument11.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostPaymentInstrumentError](Errors/PostPaymentInstrumentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Payouts

> Source: [Payouts](Api/Payouts.cs)

<details>
<summary><code>Task OctCreatePayment(OctCreatePaymentRequest octCreatePaymentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT).
The availability of API features for a merchant can depend on the portfolio configuration and may need to be enabled at the portfolio level before they can be added to merchant accounts.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Payouts.OctCreatePayment(octCreatePaymentRequest);
}
catch (SdkException<OctCreatePaymentError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>octCreatePaymentRequest</code> | <code>[OctCreatePaymentRequest](Models/OctCreatePaymentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OctCreatePaymentError](Errors/OctCreatePaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Plans

> Source: [Plans](Api/Plans.cs)

<details>
<summary><code>Task&lt;ActivateDeactivatePlanResponse&gt; ActivatePlan(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Activate a Plan

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Plans.ActivatePlan(id);
    // TODO: Handle 'response' of type ActivateDeactivatePlanResponse
}
catch (SdkException<ActivatePlanError> ex)
{
    if (ex.Error.TryGetActivatePlanException1(out var error))
    {
        // TODO: Handle 'error' of type ActivatePlanException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Plan Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ActivateDeactivatePlanResponse](Models/ActivateDeactivatePlanResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ActivatePlanError](Errors/ActivatePlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreatePlanResponse&gt; CreatePlan(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The recurring billing service enables you to manage payment plans and subscriptions for recurring payment schedules. It securely stores your customer's payment information and personal data within secure Visa data centers, reducing storage risks and PCI DSS scope through the use of *Token Management* (*TMS*).

The three key elements of *Cybersource* Recurring Billing are:

-  **Token**: stores customer billing, shipping, and payment details.

-  **Plan**: stores the billing schedule.

-  **Subscription**: combines the token and plan, and defines the subscription start date, name, and description.

The APIs in this section demonstrate the management of the Plans and Subscriptions. For Tokens please refer to [Token Management](#token-management)
The availability of API features for a merchant can depend on the portfolio configuration and may need to be enabled at the portfolio level before they can be added to merchant accounts.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Plans.CreatePlan();
    // TODO: Handle 'response' of type CreatePlanResponse
}
catch (SdkException<CreatePlanError> ex)
{
    if (ex.Error.TryGetCreatePlanException1(out var error))
    {
        // TODO: Handle 'error' of type CreatePlanException1
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreatePlanResponse](Models/CreatePlanResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreatePlanError](Errors/CreatePlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ActivateDeactivatePlanResponse&gt; DeactivatePlan(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deactivate a Plan

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Plans.DeactivatePlan(id);
    // TODO: Handle 'response' of type ActivateDeactivatePlanResponse
}
catch (SdkException<DeactivatePlanError> ex)
{
    if (ex.Error.TryGetDeactivatePlanException1(out var error))
    {
        // TODO: Handle 'error' of type DeactivatePlanException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Plan Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ActivateDeactivatePlanResponse](Models/ActivateDeactivatePlanResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeactivatePlanError](Errors/DeactivatePlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DeletePlanResponse&gt; DeletePlan(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a Plan is only allowed:
- plan status is in `DRAFT`
- plan status is in `ACTIVE`, and `INACTIVE` only allowed when no subscriptions attached to a plan in the lifetime of a plan


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Plans.DeletePlan(id);
    // TODO: Handle 'response' of type DeletePlanResponse
}
catch (SdkException<DeletePlanError> ex)
{
    if (ex.Error.TryGetDeletePlanException1(out var error))
    {
        // TODO: Handle 'error' of type DeletePlanException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Plan Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DeletePlanResponse](Models/DeletePlanResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeletePlanError](Errors/DeletePlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetPlanResponse&gt; GetPlan(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a Plan details by Plan Id.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Plans.GetPlan(id);
    // TODO: Handle 'response' of type GetPlanResponse
}
catch (SdkException<GetPlanError> ex)
{
    if (ex.Error.TryGetGetPlanException1(out var error))
    {
        // TODO: Handle 'error' of type GetPlanException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Plan Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPlanResponse](Models/GetPlanResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPlanError](Errors/GetPlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetPlanCodeResponse&gt; GetPlanCode(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a Unique Plan Code

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Plans.GetPlanCode();
    // TODO: Handle 'response' of type GetPlanCodeResponse
}
catch (SdkException<GetPlanCodeError> ex)
{
    if (ex.Error.TryGetGetPlanCodeException1(out var error))
    {
        // TODO: Handle 'error' of type GetPlanCodeException1
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetPlanCodeResponse](Models/GetPlanCodeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPlanCodeError](Errors/GetPlanCodeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetAllPlansResponse&gt; GetPlans(int? offset, int? limit, string? code, string? status, string? name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve Plans by Plan Code & Plan Status.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Plans.GetPlans(offset, limit, code, status, name);
    // TODO: Handle 'response' of type GetAllPlansResponse
}
catch (SdkException<GetPlansError> ex)
{
    if (ex.Error.TryGetGetPlansException1(out var error))
    {
        // TODO: Handle 'error' of type GetPlansException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>offset</code> | <code>int?</code> | Page offset number. |
| <code>limit</code> | <code>int?</code> | Number of items to be returned. Default - `20`, Max - `100` |
| <code>code</code> | <code>string?</code> | Filter by Plan Code |
| <code>status</code> | <code>string?</code> | Filter by Plan Status |
| <code>name</code> | <code>string?</code> | Filter by Plan Name. (First sub string or full string) **[Not Recommended]** |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetAllPlansResponse](Models/GetAllPlansResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPlansError](Errors/GetPlansError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdatePlanResponse&gt; UpdatePlan(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Plan

Plan in `DRAFT` status
- All updates are allowed on Plan with `DRAFT` status

Plan in `ACTIVE` status [Following fields are **Not Updatable**]
- `planInformation.billingPeriod`
- `planInformation.billingCycles` [Update is only allowed to **increase** billingCycles]
- `orderInformation.amountDetails.currency`


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Plans.UpdatePlan(id);
    // TODO: Handle 'response' of type UpdatePlanResponse
}
catch (SdkException<UpdatePlanError> ex)
{
    if (ex.Error.TryGetUpdatePlanException1(out var error))
    {
        // TODO: Handle 'error' of type UpdatePlanException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Plan Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdatePlanResponse](Models/UpdatePlanResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdatePlanError](Errors/UpdatePlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PullFundsApi

> Source: [PullFundsApi](Api/PullFundsApi.cs)

<details>
<summary><code>Task CreatePullFundsRefund(string id, string contentType, string xRequestid, string vcMerchantId, string vcPermissions, string vcCorrelationId, string vcOrganizationId, PullFundsRefundRequest pullFundsRefundRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refund an Account Funding Transaction (AFT).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PullFundsApi.CreatePullFundsRefund(id,
        contentType,
        xRequestid,
        vcMerchantId,
        vcPermissions,
        vcCorrelationId,
        vcOrganizationId,
        pullFundsRefundRequest);
}
catch (SdkException<CreatePullFundsRefundError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The transaction id of a previous Account Funding Transaction. |
| <code>contentType</code> | <code>string</code> | - |
| <code>xRequestid</code> | <code>string</code> | - |
| <code>vcMerchantId</code> | <code>string</code> | - |
| <code>vcPermissions</code> | <code>string</code> | - |
| <code>vcCorrelationId</code> | <code>string</code> | - |
| <code>vcOrganizationId</code> | <code>string</code> | - |
| <code>pullFundsRefundRequest</code> | <code>[PullFundsRefundRequest](Models/PullFundsRefundRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreatePullFundsRefundError](Errors/CreatePullFundsRefundError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CreatePullFundsReversal(string id, string contentType, string xRequestid, string vcMerchantId, string vcPermissions, string vcCorrelationId, string vcOrganizationId, PullFundsReversalRequest pullFundsReversalRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Reverse an Account Funding Transaction (AFT).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PullFundsApi.CreatePullFundsReversal(id,
        contentType,
        xRequestid,
        vcMerchantId,
        vcPermissions,
        vcCorrelationId,
        vcOrganizationId,
        pullFundsReversalRequest);
}
catch (SdkException<CreatePullFundsReversalError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The transaction id of a previous Account Funding Transaction. |
| <code>contentType</code> | <code>string</code> | - |
| <code>xRequestid</code> | <code>string</code> | - |
| <code>vcMerchantId</code> | <code>string</code> | - |
| <code>vcPermissions</code> | <code>string</code> | - |
| <code>vcCorrelationId</code> | <code>string</code> | - |
| <code>vcOrganizationId</code> | <code>string</code> | - |
| <code>pullFundsReversalRequest</code> | <code>[PullFundsReversalRequest](Models/PullFundsReversalRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreatePullFundsReversalError](Errors/CreatePullFundsReversalError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CreatePullFundsTransfer(string contentType, string xRequestid, string vcMerchantId, string vcPermissions, string vcCorrelationId, string vcOrganizationId, PullFundsRequest pullFundsRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Receive funds using an Account Funding Transaction (AFT).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PullFundsApi.CreatePullFundsTransfer(contentType,
        xRequestid,
        vcMerchantId,
        vcPermissions,
        vcCorrelationId,
        vcOrganizationId,
        pullFundsRequest);
}
catch (SdkException<CreatePullFundsTransferError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>contentType</code> | <code>string</code> | - |
| <code>xRequestid</code> | <code>string</code> | - |
| <code>vcMerchantId</code> | <code>string</code> | - |
| <code>vcPermissions</code> | <code>string</code> | - |
| <code>vcCorrelationId</code> | <code>string</code> | - |
| <code>vcOrganizationId</code> | <code>string</code> | - |
| <code>pullFundsRequest</code> | <code>[PullFundsRequest](Models/PullFundsRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreatePullFundsTransferError](Errors/CreatePullFundsTransferError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PurchaseAndRefundDetails

> Source: [PurchaseAndRefundDetails](Api/PurchaseAndRefundDetails.cs)

<details>
<summary><code>Task GetPurchaseAndRefundDetails(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, string? groupName, int? offset, string? paymentSubtype = "ALL", string? viewBy = "requestDate", int? limit = 2000, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download the Purchase and Refund Details report. This report report includes all purchases and refund transactions, as well as all activities related to transactions resulting in an adjustment to the net proceeds.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PurchaseAndRefundDetails.GetPurchaseAndRefundDetails(startTime,
        endTime,
        organizationId,
        groupName,
        offset);
}
catch (SdkException<GetPurchaseAndRefundDetailsError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>DateTimeOffset</code> | Valid report Start Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>endTime</code> | <code>DateTimeOffset</code> | Valid report End Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |
| <code>groupName</code> | <code>string?</code> | Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds |
| <code>offset</code> | <code>int?</code> | Offset of the Purchase and Refund Results. |
| <code>paymentSubtype</code> | <code>string?</code> | Payment Subtypes.<br>  - **ALL**:  All Payment Subtypes<br>  - **VI** :  Visa<br>  - **MC** :  Master Card<br>  - **AX** :  American Express<br>  - **DI** :  Discover<br>  - **DP** :  Pinless Debit<br>**Default**: "ALL" |
| <code>viewBy</code> | <code>string?</code> | View results by Request Date or Submission Date.<br>  - **requestDate** : Request Date<br>  - **submissionDate**: Submission Date<br>**Default**: "requestDate" |
| <code>limit</code> | <code>int?</code> | Results count per page. Range(1-2000)<br>**Default**: 2000 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetPurchaseAndRefundDetailsError](Errors/GetPurchaseAndRefundDetailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ReportDefinitions

> Source: [ReportDefinitions](Api/ReportDefinitions.cs)

<details>
<summary><code>Task GetResourceInfoByReportDefinition(string reportDefinitionName, string? subscriptionType, string? reportMimeType, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

View the attributes of an individual report type. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/)


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ReportDefinitions.GetResourceInfoByReportDefinition(reportDefinitionName,
        subscriptionType,
        reportMimeType,
        organizationId);
}
catch (SdkException<GetResourceInfoByReportDefinitionError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>reportDefinitionName</code> | <code>string</code> | Name of the Report definition to retrieve |
| <code>subscriptionType</code> | <code>string?</code> | The subscription type for which report definition is required. By default the type will be CUSTOM.<br>Valid Values:<br>- CLASSIC<br>- CUSTOM<br>- STANDARD |
| <code>reportMimeType</code> | <code>string?</code> | The format for which the report definition is required. By default the value will be CSV.<br>Valid Values:<br>- application/xml<br>- text/csv |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetResourceInfoByReportDefinitionError](Errors/GetResourceInfoByReportDefinitionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetResourceV2Info(string? subscriptionType, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

View a list of supported reports and their attributes before subscribing to them.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ReportDefinitions.GetResourceV2Info(subscriptionType, organizationId);
}
catch (SdkException<GetResourceV2InfoError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>subscriptionType</code> | <code>string?</code> | Valid Values:<br>- CLASSIC<br>- CUSTOM<br>- STANDARD |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetResourceV2InfoError](Errors/GetResourceV2InfoError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ReportDownloads

> Source: [ReportDownloads](Api/ReportDownloads.cs)

<details>
<summary><code>Task DownloadReport(DateTimeOffset reportDate, string reportName, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download a report using the unique report name and date.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ReportDownloads.DownloadReport(reportDate, reportName, organizationId);
}
catch (SdkException<DownloadReportError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>reportDate</code> | <code>DateTimeOffset</code> | Valid date on which to download the report in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br> yyyy-mm-dd<br>For reports that span multiple days, this value would be the end date of the report in the time zone of the report subscription.<br>Example 1: If your report start date is 2020-03-06 and the end date is 2020-03-09, the reportDate passed in the query is 2020-03-09.<br>Example 2: If your report runs from midnight to midnight on 2020-03-09, the reportDate passed in the query is 2020-03-10 |
| <code>reportName</code> | <code>string</code> | Name of the report to download |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DownloadReportError](Errors/DownloadReportError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ReportSubscriptions

> Source: [ReportSubscriptions](Api/ReportSubscriptions.cs)

<details>
<summary><code>Task CreateStandardOrClassicSubscription(string? organizationId, PredefinedSubscriptionRequestBean predefinedSubscriptionRequestBean, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create or update an already existing classic or standard subscription.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ReportSubscriptions.CreateStandardOrClassicSubscription(organizationId,
        predefinedSubscriptionRequestBean);
}
catch (SdkException<CreateStandardOrClassicSubscriptionError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |
| <code>predefinedSubscriptionRequestBean</code> | <code>[PredefinedSubscriptionRequestBean](Models/PredefinedSubscriptionRequestBean.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateStandardOrClassicSubscriptionError](Errors/CreateStandardOrClassicSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CreateSubscription2(string? organizationId, CreateReportSubscriptionRequest createReportSubscriptionRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a report subscription for your organization. The report name must be unique.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ReportSubscriptions.CreateSubscription2(organizationId, createReportSubscriptionRequest);
}
catch (SdkException<CreateSubscription2Error> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |
| <code>createReportSubscriptionRequest</code> | <code>[CreateReportSubscriptionRequest](Models/CreateReportSubscriptionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateSubscription2Error](Errors/CreateSubscription2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteSubscription(string reportName, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a report subscription for your organization. You must know the unique name of the report you want to delete.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ReportSubscriptions.DeleteSubscription(reportName, organizationId);
}
catch (SdkException<DeleteSubscriptionError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>reportName</code> | <code>string</code> | Name of the Report to Delete |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteSubscriptionError](Errors/DeleteSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetAllSubscriptions2(string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

View a summary of all report subscriptions.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ReportSubscriptions.GetAllSubscriptions2(organizationId);
}
catch (SdkException<GetAllSubscriptions2Error> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAllSubscriptions2Error](Errors/GetAllSubscriptions2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetSubscription2(string reportName, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

View the details of a report subscription, such as the report format or report frequency, using the report’s unique name.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ReportSubscriptions.GetSubscription2(reportName, organizationId);
}
catch (SdkException<GetSubscription2Error> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>reportName</code> | <code>string</code> | Name of the Report to Retrieve |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetSubscription2Error](Errors/GetSubscription2Error.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Reports

> Source: [Reports](Api/Reports.cs)

<details>
<summary><code>Task CreateReport(string? organizationId, CreateAdhocReportRequest createAdhocReportRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a one-time report. You must specify the type of report in reportDefinitionName. For a list of values for reportDefinitionName, see the [Reporting Developer Guide](https://www.cybersource.com/developers/documentation/reporting_and_reconciliation)


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Reports.CreateReport(organizationId, createAdhocReportRequest);
}
catch (SdkException<CreateReportError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |
| <code>createAdhocReportRequest</code> | <code>[CreateAdhocReportRequest](Models/CreateAdhocReportRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateReportError](Errors/CreateReportError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetReportByReportId(string reportId, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download a report using the reportId value. If you don’t already know this value, you can obtain it using the Retrieve available reports call.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Reports.GetReportByReportId(reportId, organizationId);
}
catch (SdkException<GetReportByReportIdError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>reportId</code> | <code>string</code> | Valid Report Id |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetReportByReportIdError](Errors/GetReportByReportIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SearchReports(DateTimeOffset startTime, DateTimeOffset endTime, string timeQueryType, string? organizationId, string? reportMimeType, string? reportFrequency, string? reportName, int? reportDefinitionId, string? reportStatus, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a list of the available reports to which you are subscribed. This will also give you the reportId value, which you can also use to download a report.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Reports.SearchReports(startTime,
        endTime,
        timeQueryType,
        organizationId,
        reportMimeType,
        reportFrequency,
        reportName,
        reportDefinitionId,
        reportStatus);
}
catch (SdkException<SearchReportsError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>DateTimeOffset</code> | Valid report Start Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>endTime</code> | <code>DateTimeOffset</code> | Valid report End Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>timeQueryType</code> | <code>string</code> | Specify time you would like to search<br><br>Valid values:<br>- reportTimeFrame<br>- executedTime |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |
| <code>reportMimeType</code> | <code>string?</code> | Valid Report Format<br><br>Valid values:<br>- application/xml<br>- text/csv |
| <code>reportFrequency</code> | <code>string?</code> | Valid Report Frequency<br><br>Valid values:<br>- DAILY<br>- WEEKLY<br>- MONTHLY<br>- USER_DEFINED<br>- ADHOC |
| <code>reportName</code> | <code>string?</code> | Valid Report Name |
| <code>reportDefinitionId</code> | <code>int?</code> | Valid Report Definition Id |
| <code>reportStatus</code> | <code>string?</code> | Valid Report Status<br><br>Valid values:<br>- COMPLETED<br>- PENDING<br>- QUEUED<br>- RUNNING<br>- ERROR<br>- NO_DATA |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SearchReportsError](Errors/SearchReportsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RetrievalDetails

> Source: [RetrievalDetails](Api/RetrievalDetails.cs)

<details>
<summary><code>Task GetRetrievalDetails(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieval Detail Report Description

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.RetrievalDetails.GetRetrievalDetails(startTime, endTime, organizationId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>DateTimeOffset</code> | Valid report Start Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>endTime</code> | <code>DateTimeOffset</code> | Valid report End Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RetrievalSummaries

> Source: [RetrievalSummaries](Api/RetrievalSummaries.cs)

<details>
<summary><code>Task GetRetrievalSummary(DateTimeOffset startTime, DateTimeOffset endTime, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieval Summary Report Description

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.RetrievalSummaries.GetRetrievalSummary(startTime, endTime, organizationId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>DateTimeOffset</code> | Valid report Start Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>endTime</code> | <code>DateTimeOffset</code> | Valid report End Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br>**Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) |
| <code>organizationId</code> | <code>string?</code> | Valid Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SearchTransactions

> Source: [SearchTransactions](Api/SearchTransactions.cs)

<details>
<summary><code>Task&lt;TssV2TransactionsPost201Response&gt; CreateSearch(CreateSearchRequest createSearchRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a search request.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SearchTransactions.CreateSearch(createSearchRequest);
    // TODO: Handle 'response' of type TssV2TransactionsPost201Response
}
catch (SdkException<CreateSearchError> ex)
{
    if (ex.Error.TryGetTssV2TransactionsPost400Response1(out var error))
    {
        // TODO: Handle 'error' of type TssV2TransactionsPost400Response1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>createSearchRequest</code> | <code>[CreateSearchRequest](Models/CreateSearchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TssV2TransactionsPost201Response](Models/TssV2TransactionsPost201Response.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateSearchError](Errors/CreateSearchError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetSearch(string searchId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Include the Search ID in the GET request to retrieve the search results.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SearchTransactions.GetSearch(searchId);
}
catch (SdkException<GetSearchError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>searchId</code> | <code>string</code> | Search ID. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetSearchError](Errors/GetSearchError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SecureFileShare

> Source: [SecureFileShare](Api/SecureFileShare.cs)

<details>
<summary><code>Task GetFile(string fileId, string? organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Download a file for the given file identifier

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SecureFileShare.GetFile(fileId, organizationId);
}
catch (SdkException<GetFileError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>fileId</code> | <code>string</code> | Unique identifier for each file |
| <code>organizationId</code> | <code>string?</code> | Valid Cybersource Organization Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFileError](Errors/GetFileError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetFileDetail(DateTimeOffset startDate, DateTimeOffset endDate, string? organizationId, string? name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get list of files and it's information of them available inside the report directory

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.SecureFileShare.GetFileDetail(startDate, endDate, organizationId, name);
}
catch (SdkException<GetFileDetailError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startDate</code> | <code>DateTimeOffset</code> | Valid start date in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br> **Example date format:**<br>  - yyyy-MM-dd |
| <code>endDate</code> | <code>DateTimeOffset</code> | Valid end date in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br> **Example date format:**<br>  - yyyy-MM-dd |
| <code>organizationId</code> | <code>string?</code> | Valid Cybersource Organization Id |
| <code>name</code> | <code>string?</code> | **Tailored to searches for specific files with in given Date range**<br>example : MyTransactionDetailreport.xml |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFileDetailError](Errors/GetFileDetailError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Subscriptions

> Source: [Subscriptions](Api/Subscriptions.cs)

<details>
<summary><code>Task&lt;ActivateSubscriptionResponse&gt; ActivateSubscription(string id, bool? processMissedPayments = true, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

# Reactivating a Suspended Subscription

You can reactivate a suspended subscription for the next billing cycle. You cannot reactivate a canceled or completed subscription.

You can specify whether you want to process missed payments for the period during which the subscription was suspended using the `processMissedPayments` query parameter by setting it to true or false. 
If no value is specified, the system will default to `true`.

**Important:** The "processMissedPayments" query parameter is only effective when the Ask each time before reactivating option is selected in the reactivation settings. If any other option is chosen, the value provided in the request will be ignored by the system. For more information, see the [Recurring Billing User Guide](https://developer.cybersource.com/docs/cybs/en-us/recurring-billing/user/all/rest/recurring-billing-user/recurring-billing-user-about-guide.html).

You can check how many payments were missed and the total amount by retrieving the subscription details, where you will find the `reactivationInformation` object. See: [Retrieving a Subscription](https://developer.cybersource.com/docs/cybs/en-us/recurring-billing/developer/all/rest/recurring-billing-dev/recur-bill-subscriptions/recur-bill-getting-a-subscription.html).


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.ActivateSubscription(id);
    // TODO: Handle 'response' of type ActivateSubscriptionResponse
}
catch (SdkException<ActivateSubscriptionError> ex)
{
    if (ex.Error.TryGetActivateSubscriptionException1(out var error))
    {
        // TODO: Handle 'error' of type ActivateSubscriptionException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Subscription Id |
| <code>processMissedPayments</code> | <code>bool?</code> | Indicates if missed payments should be processed from the period when the subscription was suspended. By default, this is set to true.<br>When any option other than "Ask each time before reactivating" is selected in the reactivation settings, the value that you enter will be ignored.<br>**Default**: true |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ActivateSubscriptionResponse](Models/ActivateSubscriptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ActivateSubscriptionError](Errors/ActivateSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CancelSubscriptionResponse&gt; CancelSubscription(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancel a Subscription

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.CancelSubscription(id);
    // TODO: Handle 'response' of type CancelSubscriptionResponse
}
catch (SdkException<CancelSubscriptionError> ex)
{
    if (ex.Error.TryGetCancelSubscriptionException1(out var error))
    {
        // TODO: Handle 'error' of type CancelSubscriptionException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Subscription Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CancelSubscriptionResponse](Models/CancelSubscriptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CancelSubscriptionError](Errors/CancelSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreateSubscriptionResponse&gt; CreateSubscription(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Recurring Billing Subscription

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.CreateSubscription();
    // TODO: Handle 'response' of type CreateSubscriptionResponse
}
catch (SdkException<CreateSubscriptionError> ex)
{
    if (ex.Error.TryGetCreateSubscriptionException1(out var error))
    {
        // TODO: Handle 'error' of type CreateSubscriptionException1
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateSubscriptionResponse](Models/CreateSubscriptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateSubscriptionError](Errors/CreateSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetAllSubscriptionsResponse&gt; GetAllSubscriptions(int? offset, int? limit, string? code, string? status, string? customerId, string? clientReferenceInformationCode, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve Subscriptions by Subscription Code & Subscription Status.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.GetAllSubscriptions(offset,
        limit,
        code,
        status,
        customerId,
        clientReferenceInformationCode);
    // TODO: Handle 'response' of type GetAllSubscriptionsResponse
}
catch (SdkException<GetAllSubscriptionsError> ex)
{
    if (ex.Error.TryGetGetAllSubscriptionsException1(out var error))
    {
        // TODO: Handle 'error' of type GetAllSubscriptionsException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>offset</code> | <code>int?</code> | Page offset number. |
| <code>limit</code> | <code>int?</code> | Number of items to be returned. Default - `20`, Max - `100` |
| <code>code</code> | <code>string?</code> | Filter by Subscription Code |
| <code>status</code> | <code>string?</code> | Filter by Subscription Status |
| <code>customerId</code> | <code>string?</code> | Filter by Customer Id |
| <code>clientReferenceInformationCode</code> | <code>string?</code> | Filter by Client Reference Information Code / Merchant Reference Number |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetAllSubscriptionsResponse](Models/GetAllSubscriptionsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetAllSubscriptionsError](Errors/GetAllSubscriptionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetSubscriptionResponse&gt; GetSubscription(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a Subscription by Subscription Id

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.GetSubscription(id);
    // TODO: Handle 'response' of type GetSubscriptionResponse
}
catch (SdkException<GetSubscriptionError> ex)
{
    if (ex.Error.TryGetGetSubscriptionException1(out var error))
    {
        // TODO: Handle 'error' of type GetSubscriptionException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Subscription Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetSubscriptionResponse](Models/GetSubscriptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetSubscriptionError](Errors/GetSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetSubscriptionCodeResponse&gt; GetSubscriptionCode(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a Unique Subscription Code

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.GetSubscriptionCode();
    // TODO: Handle 'response' of type GetSubscriptionCodeResponse
}
catch (SdkException<GetSubscriptionCodeError> ex)
{
    if (ex.Error.TryGetGetSubscriptionCodeException1(out var error))
    {
        // TODO: Handle 'error' of type GetSubscriptionCodeException1
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetSubscriptionCodeResponse](Models/GetSubscriptionCodeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetSubscriptionCodeError](Errors/GetSubscriptionCodeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetSubscriptionsPaymentsResponse&gt; SubscriptionsIdPaymentsGet(string id, int? offset, int? limit, int? scheduledPaymentsCount, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a list of payments for a specific subscription by its ID.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.SubscriptionsIdPaymentsGet(id, offset, limit, scheduledPaymentsCount);
    // TODO: Handle 'response' of type GetSubscriptionsPaymentsResponse
}
catch (SdkException<SubscriptionsIdPaymentsGetError> ex)
{
    if (ex.Error.TryGetSubscriptionsIdPaymentsGetException1(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionsIdPaymentsGetException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Subscription Id |
| <code>offset</code> | <code>int?</code> | Page offset number. |
| <code>limit</code> | <code>int?</code> | Number of items to be returned. Default - `20`, Max - `100` |
| <code>scheduledPaymentsCount</code> | <code>int?</code> | Number of existing scheduled payments to be returned. Default - `5`, Max - `9999` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetSubscriptionsPaymentsResponse](Models/GetSubscriptionsPaymentsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubscriptionsIdPaymentsGetError](Errors/SubscriptionsIdPaymentsGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetSubscriptionsPaymentsResponse1&gt; SubscriptionsIdPaymentsPut(string id, UpdatePayments updatePayments, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Modifies the state of a subscription's payments.
Currently, the only possible modifications are "skipping" and "restoring" payments. 
Marking a payment as "skipped" means it will not be processed when its scheduled time arrives. "Restoring" a payment removes it from the list of payments to be skipped.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.SubscriptionsIdPaymentsPut(id, updatePayments);
    // TODO: Handle 'response' of type GetSubscriptionsPaymentsResponse1
}
catch (SdkException<SubscriptionsIdPaymentsPutError> ex)
{
    if (ex.Error.TryGetSubscriptionsIdPaymentsPutException1(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionsIdPaymentsPutException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Subscription Id |
| <code>updatePayments</code> | <code>[UpdatePayments](Models/UpdatePayments.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetSubscriptionsPaymentsResponse1](Models/GetSubscriptionsPaymentsResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SubscriptionsIdPaymentsPutError](Errors/SubscriptionsIdPaymentsPutError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SuspendSubscriptionResponse&gt; SuspendSubscription(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Suspend a Subscription


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.SuspendSubscription(id);
    // TODO: Handle 'response' of type SuspendSubscriptionResponse
}
catch (SdkException<SuspendSubscriptionError> ex)
{
    if (ex.Error.TryGetSuspendSubscriptionException1(out var error))
    {
        // TODO: Handle 'error' of type SuspendSubscriptionException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Subscription Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SuspendSubscriptionResponse](Models/SuspendSubscriptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SuspendSubscriptionError](Errors/SuspendSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UpdateSubscriptionResponse&gt; UpdateSubscription(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a Subscription by Subscription Id

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.UpdateSubscription(id);
    // TODO: Handle 'response' of type UpdateSubscriptionResponse
}
catch (SdkException<UpdateSubscriptionError> ex)
{
    if (ex.Error.TryGetUpdateSubscriptionException1(out var error))
    {
        // TODO: Handle 'error' of type UpdateSubscriptionException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Subscription Id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UpdateSubscriptionResponse](Models/UpdateSubscriptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateSubscriptionError](Errors/UpdateSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SubscriptionsFollowOns

> Source: [SubscriptionsFollowOns](Api/SubscriptionsFollowOns.cs)

<details>
<summary><code>Task&lt;CreateSubscriptionResponse&gt; CreateFollowOnSubscription(string requestId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new Subscription based on the Request Id of an existing successful Transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubscriptionsFollowOns.CreateFollowOnSubscription(requestId);
    // TODO: Handle 'response' of type CreateSubscriptionResponse
}
catch (SdkException<CreateFollowOnSubscriptionError> ex)
{
    if (ex.Error.TryGetCreateFollowOnSubscriptionException1(out var error))
    {
        // TODO: Handle 'error' of type CreateFollowOnSubscriptionException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>requestId</code> | <code>string</code> | Request Id of an existing successful Transaction |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreateSubscriptionResponse](Models/CreateSubscriptionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateFollowOnSubscriptionError](Errors/CreateFollowOnSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetSubscriptionResponse1&gt; GetFollowOnSubscription(string requestId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get details of the Subscription being created based on the Request Id of an existing successful Transaction.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SubscriptionsFollowOns.GetFollowOnSubscription(requestId);
    // TODO: Handle 'response' of type GetSubscriptionResponse1
}
catch (SdkException<GetFollowOnSubscriptionError> ex)
{
    if (ex.Error.TryGetGetFollowOnSubscriptionException1(out var error))
    {
        // TODO: Handle 'error' of type GetFollowOnSubscriptionException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>requestId</code> | <code>string</code> | Request Id of an existing successful Transaction |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetSubscriptionResponse1](Models/GetSubscriptionResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetFollowOnSubscriptionError](Errors/GetFollowOnSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Tokenize

> Source: [Tokenize](Api/Tokenize.cs)

<details>
<summary><code>Task&lt;TokenizeResponse&gt; TokenizeInvoke(string? profileId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

|  |  |  |  
| --- | --- | --- |
|The **Tokenize API** endpoint facilitates the creation of various TMS tokens such as Customers, Payment Instruments, Shipping Addresses, and Instrument Identifiers in a single operation. The request includes a processingInformation object, which specifies **"TOKEN_CREATE"** and the types of tokens to be created. The **tokenInformation** section of the request includes detailed information relevant to each token type. This includes attributes for Customers, Payment Instruments, Shipping Addresses, Instrument Identifiers and Transient Token data. The payload is flexible, allowing for different combinations of tokens to be created in a single request.|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|The **API response** includes a responses array, which details the outcome of the tokenization process for each requested resource type, such as Customer, Payment Instrument, Shipping Address, and Instrument Identifier. Each entry in this array provides an HTTP status code such as **201/200 for successful creations**, and a unique identifier for the newly created token.<br>In cases where token creation encounters issues, the response includes a **non-2XX** status code and an errors array for the affected resource. Each error object in the array details the **error type and a descriptive message** providing insight into why a particular token creation was not attempted or failed.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Tokenize.TokenizeInvoke(profileId);
    // TODO: Handle 'response' of type TokenizeResponse
}
catch (SdkException<TokenizeError> ex)
{
    if (ex.Error.TryGetTokenizeException1(out var error))
    {
        // TODO: Handle 'error' of type TokenizeException1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>profileId</code> | <code>string?</code> | The Id of a profile containing user specific TMS configuration. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokenizeResponse](Models/TokenizeResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[TokenizeError](Errors/TokenizeError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransactionBatches

> Source: [TransactionBatches](Api/TransactionBatches.cs)

<details>
<summary><code>Task GetTransactionBatchDetails(string id, DateTimeOffset? uploadDate, string? status, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provides real-time detailed status information about the transactions that you previously uploaded in the Business Center or processed with the Offline Transaction File Submission service.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TransactionBatches.GetTransactionBatchDetails(id, uploadDate, status);
}
catch (SdkException<GetTransactionBatchDetailsError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The batch id assigned for the template. |
| <code>uploadDate</code> | <code>DateTimeOffset?</code> | Date in which the original batch file was uploaded. Date must be in ISO-8601 format.<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br>**Example date format:**<br> - yyyy-MM-dd |
| <code>status</code> | <code>string?</code> | Allows you to filter by rejected response.<br><br>Valid values:<br>- Rejected |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTransactionBatchDetailsError](Errors/GetTransactionBatchDetailsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetTransactionBatchId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API provides details like upload date, completion date, transaction count and accepted and rejected transaction count of the individual batch file using the batch id

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TransactionBatches.GetTransactionBatchId(id);
}
catch (SdkException<GetTransactionBatchIdError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The batch id assigned for the template. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTransactionBatchIdError](Errors/GetTransactionBatchIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task GetTransactionBatches(DateTimeOffset startTime, DateTimeOffset endTime, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Provide the date and time search range to get a list of Batch Files ready for settlement

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TransactionBatches.GetTransactionBatches(startTime, endTime);
}
catch (SdkException<GetTransactionBatchesError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>startTime</code> | <code>DateTimeOffset</code> | Valid report Start Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br> **Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZZ |
| <code>endTime</code> | <code>DateTimeOffset</code> | Valid report End Time in **ISO 8601 format**<br>Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)<br><br> **Example date format:**<br>  - yyyy-MM-dd'T'HH:mm:ss.SSSZZ |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTransactionBatchesError](Errors/GetTransactionBatchesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransactionDetailsApi

> Source: [TransactionDetailsApi](Api/TransactionDetailsApi.cs)

<details>
<summary><code>Task GetTransaction(string id, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Include the Request ID in the GET request to retrieve the transaction details.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.TransactionDetailsApi.GetTransaction(id);
}
catch (SdkException<GetTransactionError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Request ID. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[GetTransactionError](Errors/GetTransactionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Verification

> Source: [Verification](Api/Verification.cs)

<details>
<summary><code>Task ValidateExportCompliance(ValidateExportComplianceRequest validateExportComplianceRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This call checks customer data against specified watch lists to ensure export compliance.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Verification.ValidateExportCompliance(validateExportComplianceRequest);
}
catch (SdkException<ValidateExportComplianceError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>validateExportComplianceRequest</code> | <code>[ValidateExportComplianceRequest](Models/ValidateExportComplianceRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ValidateExportComplianceError](Errors/ValidateExportComplianceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task VerifyCustomerAddress(VerifyCustomerAddressRequest verifyCustomerAddressRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This call verifies that the customer address submitted is valid.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Verification.VerifyCustomerAddress(verifyCustomerAddressRequest);
}
catch (SdkException<VerifyCustomerAddressError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>verifyCustomerAddressRequest</code> | <code>[VerifyCustomerAddressRequest](Models/VerifyCustomerAddressRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[VerifyCustomerAddressError](Errors/VerifyCustomerAddressError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BillingAgreements

> Source: [BillingAgreements](Api/BillingAgreements.cs)

<details>
<summary><code>Task BillingAgreementsDeRegistration(string id, ModifyBillingAgreement modifyBillingAgreement, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

#### Standing Instruction:
Standing Instruction with or without Token.

#### Revoke Mandate:
When you revoke a mandate, any pending direct debits linked to that mandate are canceled. No notifications are sent.
When you revoke a mandate with no pending direct debits, the Bacs scheme or customer’s bank notify you of any subsequent direct debit events.
When you revoke a mandate, you cannot send a direct debit request using the mandate ID. Customer payments cannot be made against a revoked mandate.
You can revoke a mandate when the customer:
  - Requests that you revoke the mandate.
  - Closes their account with you.
Possible revoke mandate status values -
  - Revoked—the revoke mandate request was successfully processed.
  - Failed—the revoke mandate request was not accepted.

#### Update Mandate:
In most cases, the account details of an existing mandate cannot be updated in the Bacs schema,
except by creating a new mandate. However, some very limited customer information, like name and address,
can be updated to the mandate without needing to revoke it first

#### Mandate Status:
After the customer signs the mandate, request that the mandate status service verify the mandate status.
Possible mandate status values:
  - Active—the mandate is successfully created. A direct debit can be sent for this mandate ID.
  - Pending—a pending mandate means the mandate is not yet signed.
  - Failed—the customer did not authenticate.
  - Expired—the deadline to create the mandate passed.
  - Revoked—the mandate is cancelled.

#### Paypal Billing Agreement: 
A billing agreement is set up between PayPal and your customer.
When you collect the details of a customer’s billing agreement, you are able to bill that customer without requiring an authorization for each payment. 
You can bill the customer at the same time you process their PayPal Express checkout order, which simplifies your business processes.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.BillingAgreements.BillingAgreementsDeRegistration(id, modifyBillingAgreement);
}
catch (SdkException<BillingAgreementsDeRegistrationError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | ID for de-registration or cancellation of Billing Agreement |
| <code>modifyBillingAgreement</code> | <code>[ModifyBillingAgreement](Models/ModifyBillingAgreement.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BillingAgreementsDeRegistrationError](Errors/BillingAgreementsDeRegistrationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task BillingAgreementsIntimation(string id, IntimateBillingAgreement intimateBillingAgreement, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Standing Instruction with or without Token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.BillingAgreements.BillingAgreementsIntimation(id, intimateBillingAgreement);
}
catch (SdkException<BillingAgreementsIntimationError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | ID for intimation of Billing Agreement |
| <code>intimateBillingAgreement</code> | <code>[IntimateBillingAgreement](Models/IntimateBillingAgreement.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BillingAgreementsIntimationError](Errors/BillingAgreementsIntimationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task BillingAgreementsRegistration(CreateBillingAgreement createBillingAgreement, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

#### Standing Instruction:
Standing Instruction with or without Token. Transaction amount in case First payment is coming along with registration. Only 2 decimal places allowed

#### Create Mandate:
You can create a mandate through the direct debit mandate flow.
Possible create mandate status values:
  - Pending—the create mandate request was successfully processed.
  - Failed—the create mandate request was not accepted.

#### Import Mandate:
In the Bacs scheme, a mandate is created with a status of active. Direct debit collections can be made against it immediately.
You can import a mandate to the CyberSource database when:
  - You have existing customers with signed, active mandates
  - You manage mandates outside of CyberSource.

When you import an existing mandate to the CyberSource database, provide a unique value for the mandate ID or the request results in an error.
If an import mandate request is not accepted, the import mandate status value is failed.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.BillingAgreements.BillingAgreementsRegistration(createBillingAgreement);
}
catch (SdkException<BillingAgreementsRegistrationError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>createBillingAgreement</code> | <code>[CreateBillingAgreement](Models/CreateBillingAgreement.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BillingAgreementsRegistrationError](Errors/BillingAgreementsRegistrationError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CaptureApi

> Source: [CaptureApi](Api/CaptureApi.cs)

<details>
<summary><code>Task CapturePayment(string id, CapturePaymentRequest capturePaymentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Include the payment ID in the POST request to capture the payment amount.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CaptureApi.CapturePayment(id, capturePaymentRequest);
}
catch (SdkException<CapturePaymentError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The payment ID returned from a previous payment request. This ID links the capture to the payment. |
| <code>capturePaymentRequest</code> | <code>[CapturePaymentRequest](Models/CapturePaymentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CapturePaymentError](Errors/CapturePaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Credit

> Source: [Credit](Api/Credit.cs)

<details>
<summary><code>Task CreateCredit(CreateCreditRequest createCreditRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

POST to the credit resource to credit funds to a specified credit card.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Credit.CreateCredit(createCreditRequest);
}
catch (SdkException<CreateCreditError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>createCreditRequest</code> | <code>[CreateCreditRequest](Models/CreateCreditRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateCreditError](Errors/CreateCreditError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Orders

> Source: [Orders](Api/Orders.cs)

<details>
<summary><code>Task CreateOrder(CreateOrderRequest createOrderRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A create order request enables you to send the itemized details along with the order. This API can be used by merchants initiating their transactions with the create order API. 


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Orders.CreateOrder(createOrderRequest);
}
catch (SdkException<CreateOrderError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>createOrderRequest</code> | <code>[CreateOrderRequest](Models/CreateOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateOrderError](Errors/CreateOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UpdateOrder(string id, UpdateOrderRequest updateOrderRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API can be used in two flavours - for updating the order as well as saving the order.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Orders.UpdateOrder(id, updateOrderRequest);
}
catch (SdkException<UpdateOrderError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The ID returned from the original create order response. |
| <code>updateOrderRequest</code> | <code>[UpdateOrderRequest](Models/UpdateOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateOrderError](Errors/UpdateOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PaymentTokens

> Source: [PaymentTokens](Api/PaymentTokens.cs)

<details>
<summary><code>Task RetrieveOrDeletePaymentToken(RequestModel request, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This API can be used in two flavours - for retrieval or deletion of vault id.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.PaymentTokens.RetrieveOrDeletePaymentToken(request);
}
catch (SdkException<RetrieveOrDeletePaymentTokenError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>request</code> | <code>[RequestModel](Models/RequestModel.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RetrieveOrDeletePaymentTokenError](Errors/RetrieveOrDeletePaymentTokenError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Payments

> Source: [Payments](Api/Payments.cs)

<details>
<summary><code>Task CreateOrderRequest(string id, OrderPaymentRequest orderPaymentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a Payment Order Request

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Payments.CreateOrderRequest(id, orderPaymentRequest);
}
catch (SdkException<CreateOrderRequestError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Request identifier number for the order request. |
| <code>orderPaymentRequest</code> | <code>[OrderPaymentRequest](Models/OrderPaymentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateOrderRequestError](Errors/CreateOrderRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CreatePayment(CreatePaymentRequest createPaymentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A payment authorizes the amount for the transaction. There are a number of supported payment features, such as E-commerce and Card Present - Credit Card/Debit Card, Echeck, e-Wallets, Level II/III Data, etc..

A payment response includes the status of the request. It also includes processor-specific information when the request is successful and errors if unsuccessful. See the [Payments Developer Guides Page](https://developer.cybersource.com/docs/cybs/en-us/payments/developer/ctv/rest/payments/payments-intro.html).

Authorization can be requested with Capture, Decision Manager, Payer Authentication(3ds), and Token Creation.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Payments.CreatePayment(createPaymentRequest);
}
catch (SdkException<CreatePaymentError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>createPaymentRequest</code> | <code>[CreatePaymentRequest](Models/CreatePaymentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreatePaymentError](Errors/CreatePaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CreateSessionRequest(CreateSessionReq createSessionReq, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create Alternative Payments Sessions Request

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Payments.CreateSessionRequest(createSessionReq);
}
catch (SdkException<CreateSessionRequestError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>createSessionReq</code> | <code>[CreateSessionReq](Models/CreateSessionReq.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreateSessionRequestError](Errors/CreateSessionRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task IncrementAuth(string id, IncrementAuthRequest incrementAuthRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use this service to authorize additional charges in a lodging or autorental transaction. Include the ID returned from the original authorization in the PATCH request to add additional charges to that authorization.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Payments.IncrementAuth(id, incrementAuthRequest);
}
catch (SdkException<IncrementAuthError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The ID returned from the original authorization request. |
| <code>incrementAuthRequest</code> | <code>[IncrementAuthRequest](Models/IncrementAuthRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[IncrementAuthError](Errors/IncrementAuthError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RefreshPaymentStatus(string id, RefreshPaymentStatusRequest refreshPaymentStatusRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Checks and updates the payment status


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Payments.RefreshPaymentStatus(id, refreshPaymentStatusRequest);
}
catch (SdkException<RefreshPaymentStatusError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The payment id whose status needs to be checked and updated. |
| <code>refreshPaymentStatusRequest</code> | <code>[RefreshPaymentStatusRequest](Models/RefreshPaymentStatusRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RefreshPaymentStatusError](Errors/RefreshPaymentStatusError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UpdateSessionRequest(string id, CreateSessionRequest createSessionRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update Alternative Payments Sessions Request

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Payments.UpdateSessionRequest(id, createSessionRequest);
}
catch (SdkException<UpdateSessionRequestError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The payment ID. This ID is returned from a previous payment request. |
| <code>createSessionRequest</code> | <code>[CreateSessionRequest](Models/CreateSessionRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpdateSessionRequestError](Errors/UpdateSessionRequestError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RefundApi

> Source: [RefundApi](Api/RefundApi.cs)

<details>
<summary><code>Task RefundCapture(string id, RefundCaptureRequest refundCaptureRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refund a capture API is only used, if you have requested Capture independenlty using [/pts/v2/payments/{id}/captures](https://developer.cybersource.com/api-reference-assets/index.html#payments_capture) API call. Include the capture ID in the POST request to refund the captured amount.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.RefundApi.RefundCapture(id, refundCaptureRequest);
}
catch (SdkException<RefundCaptureError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The capture ID. This ID is returned from a previous capture request. |
| <code>refundCaptureRequest</code> | <code>[RefundCaptureRequest](Models/RefundCaptureRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RefundCaptureError](Errors/RefundCaptureError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task RefundPayment(string id, RefundPaymentRequest refundPaymentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refund a Payment API is only used, if you have requested Authorization and Capture together in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call. Include the payment ID in the POST request to refund the payment amount.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.RefundApi.RefundPayment(id, refundPaymentRequest);
}
catch (SdkException<RefundPaymentError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The payment ID. This ID is returned from a previous payment request. |
| <code>refundPaymentRequest</code> | <code>[RefundPaymentRequest](Models/RefundPaymentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RefundPaymentError](Errors/RefundPaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ReversalApi

> Source: [ReversalApi](Api/ReversalApi.cs)

<details>
<summary><code>Task AuthReversal(string id, AuthReversalRequest authReversalRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Include the payment ID in the POST request to reverse the payment amount.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ReversalApi.AuthReversal(id, authReversalRequest);
}
catch (SdkException<AuthReversalError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The payment ID returned from a previous payment request. |
| <code>authReversalRequest</code> | <code>[AuthReversalRequest](Models/AuthReversalRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[AuthReversalError](Errors/AuthReversalError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task MitReversal(MitReversalRequest mitReversalRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This is to reverse a previous payment that merchant does not receive a reply(Mostly due to Timeout). To use this feature/API, make sure to pass unique value to field - clientReferenceInformation -> transactionId in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call and use same transactionId in this API request payload to reverse the payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ReversalApi.MitReversal(mitReversalRequest);
}
catch (SdkException<MitReversalError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>mitReversalRequest</code> | <code>[MitReversalRequest](Models/MitReversalRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MitReversalError](Errors/MitReversalError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## VoidApi

> Source: [VoidApi](Api/VoidApi.cs)

<details>
<summary><code>Task MitVoid(MitVoidRequest mitVoidRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This is to void a previous payment, capture, refund, or credit that merchant does not receive a reply(Mostly due to timeout). To use this feature/API, make sure to pass unique value to field - clientReferenceInformation -> transactionId in your payment, capture, refund, or credit API call and use same transactionId in this API request payload to reverse the payment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VoidApi.MitVoid(mitVoidRequest);
}
catch (SdkException<MitVoidError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>mitVoidRequest</code> | <code>[MitVoidRequest](Models/MitVoidRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MitVoidError](Errors/MitVoidError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task VoidCapture(string id, VoidCaptureRequest voidCaptureRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refund a capture API is only used, if you have requested Capture independenlty using [/pts/v2/payments/{id}/captures](https://developer.cybersource.com/api-reference-assets/index.html#payments_capture) API call. Include the capture ID in the POST request to cancel the capture.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VoidApi.VoidCapture(id, voidCaptureRequest);
}
catch (SdkException<VoidCaptureError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The capture ID returned from a previous capture request. |
| <code>voidCaptureRequest</code> | <code>[VoidCaptureRequest](Models/VoidCaptureRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[VoidCaptureError](Errors/VoidCaptureError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task VoidCredit(string id, VoidCreditRequest voidCreditRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Include the credit ID in the POST request to cancel the credit.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VoidApi.VoidCredit(id, voidCreditRequest);
}
catch (SdkException<VoidCreditError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The credit ID returned from a previous credit request. |
| <code>voidCreditRequest</code> | <code>[VoidCreditRequest](Models/VoidCreditRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[VoidCreditError](Errors/VoidCreditError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task VoidPayment(string id, VoidPaymentRequest voidPaymentRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Void a Payment API is only used, if you have requested Authorization and Capture together in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call. Include the payment ID in the POST request to cancel the payment.


</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VoidApi.VoidPayment(id, voidPaymentRequest);
}
catch (SdkException<VoidPaymentError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The payment ID returned from a previous payment request. |
| <code>voidPaymentRequest</code> | <code>[VoidPaymentRequest](Models/VoidPaymentRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[VoidPaymentError](Errors/VoidPaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task VoidRefund(string id, VoidRefundRequest voidRefundRequest, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Include the refund ID in the POST request to cancel the refund.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.VoidApi.VoidRefund(id, voidRefundRequest);
}
catch (SdkException<VoidRefundError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | The refund ID returned from a previous refund request. |
| <code>voidRefundRequest</code> | <code>[VoidRefundRequest](Models/VoidRefundRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[VoidRefundError](Errors/VoidRefundError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

