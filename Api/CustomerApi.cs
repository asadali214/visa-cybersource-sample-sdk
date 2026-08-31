using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core;
using CyberSourceMergedSpec.Core.Exceptions;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Request;
using CyberSourceMergedSpec.Core.Response;
using CyberSourceMergedSpec.Errors;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Api;

/// <summary>
/// A Customer can be linked to multiple Payment Instruments and Shipping Addresses.
/// With one Payment Instrument and Shipping Address designated as the default.
/// It stores merchant reference information for the Customer such as email and merchant defined data.
/// </summary>
public sealed class CustomerApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal CustomerApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customers</b>&lt;br&gt;A Customer represents your tokenized customer information.&lt;br&gt;You should associate the Customer Id with the customer account on your systems.&lt;br&gt;A Customer can have one or more <see href="#token-management_customer-payment-instrument_create-a-customer-payment-instrumentl">Payment Instruments</see> or <see href="#token-management_customer-shipping-address_create-a-customer-shipping-address">Shipping Addresses</see> with one allocated as the Customers default.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Deleting a Customer</b>&lt;br&gt;Your system can use this API to delete a complete Customer.&lt;br&gt;When a Customer is deleted all associated Payment Instruments &amp; Shipping Addresses are deleted.&lt;br&gt;Any Instrument Identifiers representing the card number will also be deleted if they are not associated with any other Payment Instruments.&lt;br&gt;Note: Individual <see href="#token-management_customer-payment-instrument_delete-a-customer-payment-instrument">Payment Instruments</see> or <see href="#token-management_customer-shipping-address_delete-a-customer-shipping-address">Shipping Addresses</see> can be deleted via their own dedicated API resources.
    /// </summary>
    /// <param name="customerId">The Id of a Customer.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteCustomerError"/> when the server returns an error response.</exception>
    public Task DeleteCustomer(string customerId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers/{customerId}"),
            [new TemplateParam("customerId", customerId)],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteCustomerErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customers</b>&lt;br&gt;A Customer represents your tokenized customer information.&lt;br&gt;You should associate the Customer Id with the customer account on your systems.&lt;br&gt;A Customer can have one or more <see href="#token-management_customer-payment-instrument_create-a-customer-payment-instrumentl">Payment Instruments</see> or <see href="#token-management_customer-shipping-address_create-a-customer-shipping-address">Shipping Addresses</see> with one allocated as the Customers default.&lt;br&gt;&lt;br&gt;<b>Retrieving a Customer</b>&lt;br&gt;When your customer signs into their account, your system can use this API to retrieve the Customers default Payment Instrument and Shipping Address.&lt;br&gt;<b>Note: the actual card data will be masked.</b>&lt;br&gt;If your customer wants to see other available Payment Instruments, your system can <see href="#token-management_customer-payment-instrument_list-payment-instruments-for-a-customer">retrieve all Payment Instruments</see> associated with the Customer.&lt;br&gt;The same applies to <see href="#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer">Shipping Addresses</see>.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Payment Network Tokens</b>&lt;br&gt;Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.&lt;br&gt;A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.&lt;br&gt;A Payment Network Token can also be <see href="#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token">provisioned for an existing Instrument Identifier</see>.&lt;br&gt;For more information about Payment Network Tokens see the Developer Guide.&lt;br&gt;&lt;br&gt;<b>Payments with Customers</b>&lt;br&gt;To perform a payment with the Customers default details specify the <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-token-id_liveconsole-tab-request-body">Customer Id in the payments request</see>.&lt;br&gt;To perform a payment with a particular Payment Instrument or Shipping Address &lt;br&gt;specify the <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body">Payment Instrument or Shipping Address Ids in the payments request</see>.
    /// </summary>
    /// <param name="customerId">The Id of a Customer.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetCustomerResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCustomerError"/> when the server returns an error response.</exception>
    public Task<GetCustomerResponse> GetCustomer(string customerId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers/{customerId}"),
            [new TemplateParam("customerId", customerId)],
            [],
            [new HeaderParam("profile-id", profileId)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetCustomerResponse>(),
            GetCustomerErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customers</b>&lt;br&gt;A Customer represents your tokenized customer information.&lt;br&gt;You should associate the Customer Id with the customer account on your systems.&lt;br&gt;A Customer can have one or more <see href="#token-management_customer-payment-instrument_create-a-customer-payment-instrumentl">Payment Instruments</see> or <see href="#token-management_customer-shipping-address_create-a-customer-shipping-address">Shipping Addresses</see> with one allocated as the Customers default.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Updating a Customer</b>&lt;br&gt;Your system can use this API to update a Customers details including selecting a  <see href="#token-management_customer_update-a-customer_samplerequests-dropdown_update-customers-default-payment-instrument_liveconsole-tab-request-body">default Payment Instrument</see> or <see href="#token-management_customer_update-a-customer_samplerequests-dropdown_update-customers-default-shipping-address_liveconsole-tab-request-body">default Shipping Address</see> for use in payments.&lt;br&gt;Note: Updating a Customers <see href="#token-management_customer-payment-instrument_update-a-customer-payment-instrument">Payment Instrument</see> or <see href="#token-management_customer-shipping-address_update-a-customer-shipping-address">Shipping Address</see> details is performed using their own dedicated API resources.
    /// </summary>
    /// <param name="customerId">The Id of a Customer.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="ifMatch">Contains an ETag value from a GET request to make the request conditional.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PatchCustomerResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchCustomerError"/> when the server returns an error response.</exception>
    public Task<PatchCustomerResponse> PatchCustomer(string customerId,
        string? profileId,
        string? ifMatch,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers/{customerId}"),
            [new TemplateParam("customerId", customerId)],
            [],
            [new HeaderParam("profile-id", profileId),
                new HeaderParam("if-match", ifMatch),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            JsonResponse.Create<PatchCustomerResponse>(),
            PatchCustomerErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customers</b>&lt;br&gt;A Customer represents your tokenized customer information.&lt;br&gt;You should associate the Customer Id with the customer account on your systems.&lt;br&gt;A Customer can have one or more <see href="#token-management_customer-payment-instrument_create-a-customer-payment-instrumentl">Payment Instruments</see> or <see href="#token-management_customer-shipping-address_create-a-customer-shipping-address">Shipping Addresses</see> with one allocated as the Customers default.&lt;br&gt;&lt;br&gt;<b>Creating a Customer</b>&lt;br&gt;It is recommended you <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-customer-token-creation_liveconsole-tab-request-body">create a Customer via a Payment Authorization</see>, this can be for a zero amount.&lt;br&gt;The Customer will be created with a Payment Instrument and Shipping Address.&lt;br&gt;You can also <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-create-default-payment-instrument-shipping-address-for-existing-customer_liveconsole-tab-request-body">add additional Payment Instruments to a Customer via a Payment Authorization</see>.&lt;br&gt;In Europe: You should perform Payer Authentication alongside the Authorization.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Payment Network Tokens</b>&lt;br&gt;Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.&lt;br&gt;A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.&lt;br&gt;A Payment Network Token can also be <see href="#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token">provisioned for an existing Instrument Identifier</see>.&lt;br&gt;For more information about Payment Network Tokens see the Developer Guide.&lt;br&gt;&lt;br&gt;<b>Payments with Customers</b>&lt;br&gt;To perform a payment with the Customers default details specify the <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-token-id_liveconsole-tab-request-body">Customer Id in the payments request</see>.&lt;br&gt;To perform a payment with a particular Payment Instrument or Shipping Address &lt;br&gt;specify the <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body">Payment Instrument or Shipping Address Ids in the payments request</see>.
    /// The availability of API features for a merchant may depend on the portfolio configuration and may need to be enabled at the portfolio level before they can be added to merchant accounts.
    /// </summary>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TmsV2CustomersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCustomerError"/> when the server returns an error response.</exception>
    public Task<TmsV2CustomersResponse> PostCustomer(string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers"),
            [],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<TmsV2CustomersResponse>(),
            PostCustomerErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
