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
/// A Customer Shipping Address is linked to a Customer.
/// It stores shipping information in relation to the Customer.
/// </summary>
public sealed class CustomerShippingAddress
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal CustomerShippingAddress(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customer Shipping Address</b>&lt;br&gt;A Customer Shipping Address represents tokenized customer shipping information.&lt;br&gt;A <see href="#token-management_customer_create-a-customer">Customer</see> can have <see href="#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer">one or more Shipping Addresses</see>, with one allocated as the Customers default for use in payments.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Deleting a Customers Shipping Address</b>&lt;br&gt;Your system can use this API to delete an existing Shipping Address for a Customer.&lt;br&gt;If a customer has more than one Shipping Address then the default Shipping Address cannot be deleted without first selecting a <see href="#token-management_customer-shipping-address_update-a-customer-shipping-address_samplerequests-dropdown_make-customer-shipping-address-the-default_liveconsole-tab-request-body">new default Shipping Address</see>.
    /// </summary>
    /// <param name="customerId">The Id of a Customer.</param>
    /// <param name="shippingAddressId">The Id of a shipping address.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteCustomerShippingAddressError"/> when the server returns an error response.</exception>
    public Task DeleteCustomerShippingAddress(string customerId,
        string shippingAddressId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers/{customerId}/shipping-addresses/{shippingAddressId}"),
            [new TemplateParam("customerId", customerId), new TemplateParam("shippingAddressId", shippingAddressId)],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteCustomerShippingAddressErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customer Shipping Address</b>&lt;br&gt;A Customer Shipping Address represents tokenized customer shipping information.&lt;br&gt;A <see href="#token-management_customer_create-a-customer">Customer</see> can have <see href="#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer">one or more Shipping Addresses</see>, with one allocated as the Customers default for use in payments.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Retrieving a Customer Shipping Address</b>&lt;br&gt;Your system can use this API to retrieve an existing Shipping Address for a Customer.&lt;br&gt;To perform a payment with a particular Shipping Address simply specify the <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body">Shipping Address Id in the payments request</see>.
    /// </summary>
    /// <param name="customerId">The Id of a Customer.</param>
    /// <param name="shippingAddressId">The Id of a shipping address.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetCustomerShippingAddressResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCustomerShippingAddressError"/> when the server returns an error response.</exception>
    public Task<GetCustomerShippingAddressResponse> GetCustomerShippingAddress(string customerId,
        string shippingAddressId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers/{customerId}/shipping-addresses/{shippingAddressId}"),
            [new TemplateParam("customerId", customerId), new TemplateParam("shippingAddressId", shippingAddressId)],
            [],
            [new HeaderParam("profile-id", profileId)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetCustomerShippingAddressResponse>(),
            GetCustomerShippingAddressErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customer Shipping Address</b>&lt;br&gt;A Customer Shipping Address represents tokenized customer shipping information.&lt;br&gt;A <see href="#token-management_customer_create-a-customer">Customer</see> can have <see href="#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer">one or more Shipping Addresses</see>, with one allocated as the Customers default for use in payments.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Retrieving all Customer Shipping Addresses</b>&lt;br&gt;Your system can use this API to retrieve all existing Shipping Addresses for a Customer.
    /// </summary>
    /// <param name="customerId">The Id of a Customer.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="offset">Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0.</param>
    /// <param name="limit">The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ShippingAddressListForCustomer"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCustomerShippingAddressesListError"/> when the server returns an error response.</exception>
    public Task<ShippingAddressListForCustomer> GetCustomerShippingAddressesList(string customerId,
        string? profileId,
        long? offset = 0L,
        long? limit = 20L,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers/{customerId}/shipping-addresses"),
            [new TemplateParam("customerId", customerId)],
            [new Param("offset", offset), new Param("limit", limit)],
            [new HeaderParam("profile-id", profileId)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ShippingAddressListForCustomer>(),
            GetCustomerShippingAddressesListErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customer Shipping Address</b>&lt;br&gt;A Customer Shipping Address represents tokenized customer shipping information.&lt;br&gt;A <see href="#token-management_customer_create-a-customer">Customer</see> can have <see href="#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer">one or more Shipping Addresses</see>, with one allocated as the Customers default for use in payments.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Updating a Customers Shipping Address</b>&lt;br&gt;Your system can use this API to update an existing Shipping Addresses for a Customer, including selecting a <see href="#token-management_customer-shipping-address_update-a-customer-shipping-address_samplerequests-dropdown_make-customer-shipping-address-the-default_liveconsole-tab-request-body">default Shipping Address</see> for use in payments.
    /// </summary>
    /// <param name="customerId">The Id of a Customer.</param>
    /// <param name="shippingAddressId">The Id of a shipping address.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="ifMatch">Contains an ETag value from a GET request to make the request conditional.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PatchCustomersShippingAddressResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchCustomersShippingAddressError"/> when the server returns an error response.</exception>
    public Task<PatchCustomersShippingAddressResponse> PatchCustomersShippingAddress(string customerId,
        string shippingAddressId,
        string? profileId,
        string? ifMatch,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers/{customerId}/shipping-addresses/{shippingAddressId}"),
            [new TemplateParam("customerId", customerId), new TemplateParam("shippingAddressId", shippingAddressId)],
            [],
            [new HeaderParam("profile-id", profileId),
                new HeaderParam("if-match", ifMatch),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            JsonResponse.Create<PatchCustomersShippingAddressResponse>(),
            PatchCustomersShippingAddressErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customer Shipping Address</b>&lt;br&gt;A Customer Shipping Address represents tokenized customer shipping information.&lt;br&gt;A <see href="#token-management_customer_create-a-customer">Customer</see> can have <see href="#token-management_customer-shipping-address_list-shipping-addresses-for-a-customer">one or more Shipping Addresses</see>, with one allocated as the Customers default for use in payments.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Creating a Customer Shipping Address</b>&lt;br&gt;Your system can use this API to create an existing Customers default or non default Shipping Address.&lt;br&gt;You can also create additional Customer Shipping Addresses via the <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-create-default-payment-instrument-shipping-address-for-existing-customer_liveconsole-tab-request-body">Payments API</see>.
    /// </summary>
    /// <param name="customerId">The Id of a Customer.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostCustomerShippingAddressResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCustomerShippingAddressError"/> when the server returns an error response.</exception>
    public Task<PostCustomerShippingAddressResponse> PostCustomerShippingAddress(string customerId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers/{customerId}/shipping-addresses"),
            [new TemplateParam("customerId", customerId)],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<PostCustomerShippingAddressResponse>(),
            PostCustomerShippingAddressErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
