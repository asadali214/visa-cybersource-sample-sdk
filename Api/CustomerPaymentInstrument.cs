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
/// A Customer Payment Instrument is linked to a Customer and an Instrument Identifier.
/// It stores additional information in relation to a card number(PAN) or bank account (echeck).
/// </summary>
public sealed class CustomerPaymentInstrument
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal CustomerPaymentInstrument(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customer Payment Instrument</b>&lt;br&gt;A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address &amp; card type.&lt;br&gt;A <see href="#token-management_customer_create-a-customer">Customer</see> can have <see href="#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument">one or more Payment Instruments</see>, with one allocated as the Customers default for use in payments.&lt;br&gt;A Payment Instrument token does not store the card number. A Payment Instrument is associated with an <see href="#token-management_instrument-identifier_create-an-instrument-identifier">Instrument Identifier</see> that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.&lt;br&gt;|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Deleting a Customers Payment Instrument</b>&lt;br&gt;Your system can use this API to delete an existing Payment Instrument for a Customer.&lt;br&gt;Any Instrument Identifiers representing the card number will also be deleted if they are not associated with any other Payment Instruments.&lt;br&gt;If a customer has more than one Payment Instrument then the default Payment Instrument cannot be deleted without first selecting a <see href="#token-management_customer-payment-instrument_update-a-customer-payment-instrument_samplerequests-dropdown_make-customer-payment-instrument-the-default_liveconsole-tab-request-body">new default Payment Instrument</see>.
    /// </summary>
    /// <param name="customerId">The Id of a Customer.</param>
    /// <param name="paymentInstrumentId">The Id of a payment instrument.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteCustomerPaymentInstrumentError"/> when the server returns an error response.</exception>
    public Task DeleteCustomerPaymentInstrument(string customerId,
        string paymentInstrumentId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers/{customerId}/payment-instruments/{paymentInstrumentId}"),
            [new TemplateParam("customerId", customerId), new TemplateParam("paymentInstrumentId", paymentInstrumentId)],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteCustomerPaymentInstrumentErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customer Payment Instrument</b>&lt;br&gt;A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address &amp; card type.&lt;br&gt;A <see href="#token-management_customer_create-a-customer">Customer</see> can have <see href="#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument">one or more Payment Instruments</see>, with one allocated as the Customers default for use in payments.&lt;br&gt;A Payment Instrument token does not store the card number. A Payment Instrument is associated with an <see href="#token-management_instrument-identifier_create-an-instrument-identifier">Instrument Identifier</see> that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.&lt;br&gt;|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Retrieving a Customer Payment Instrument</b>&lt;br&gt;Your system can use this API to retrieve an existing Payment Instrument for a Customer.&lt;br&gt;To perform a payment with a particular Payment Instrument simply specify the <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body">Payment Instrument Id in the payments request</see>.
    /// </summary>
    /// <param name="customerId">The Id of a Customer.</param>
    /// <param name="paymentInstrumentId">The Id of a payment instrument.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrument11"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCustomerPaymentInstrumentError"/> when the server returns an error response.</exception>
    public Task<PaymentInstrument11> GetCustomerPaymentInstrument(string customerId,
        string paymentInstrumentId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers/{customerId}/payment-instruments/{paymentInstrumentId}"),
            [new TemplateParam("customerId", customerId), new TemplateParam("paymentInstrumentId", paymentInstrumentId)],
            [],
            [new HeaderParam("profile-id", profileId)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentInstrument11>(),
            GetCustomerPaymentInstrumentErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customer Payment Instrument</b>&lt;br&gt;A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address &amp; card type.&lt;br&gt;A <see href="#token-management_customer_create-a-customer">Customer</see> can have <see href="#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument">one or more Payment Instruments</see>, with one allocated as the Customers default for use in payments.&lt;br&gt;A Payment Instrument token does not store the card number. A Payment Instrument is associated with an <see href="#token-management_instrument-identifier_create-an-instrument-identifier">Instrument Identifier</see> that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.&lt;br&gt;|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Retrieving all Customer Payment Instruments</b>&lt;br&gt;Your system can use this API to retrieve all existing Payment Instruments for a Customer.
    /// </summary>
    /// <param name="customerId">The Id of a Customer.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="offset">Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0.</param>
    /// <param name="limit">The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrumentList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCustomerPaymentInstrumentsListError"/> when the server returns an error response.</exception>
    public Task<PaymentInstrumentList> GetCustomerPaymentInstrumentsList(string customerId,
        string? profileId,
        long? offset = 0L,
        long? limit = 20L,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers/{customerId}/payment-instruments"),
            [new TemplateParam("customerId", customerId)],
            [new Param("offset", offset), new Param("limit", limit)],
            [new HeaderParam("profile-id", profileId)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentInstrumentList>(),
            GetCustomerPaymentInstrumentsListErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customer Payment Instrument</b>&lt;br&gt;A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address &amp; card type.&lt;br&gt;A <see href="#token-management_customer_create-a-customer">Customer</see> can have <see href="#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument">one or more Payment Instruments</see>, with one allocated as the Customers default for use in payments.&lt;br&gt;A Payment Instrument token does not store the card number. A Payment Instrument is associated with an <see href="#token-management_instrument-identifier_create-an-instrument-identifier">Instrument Identifier</see> that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.&lt;br&gt;|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Updating a Customers Payment Instrument</b>&lt;br&gt;Your system can use this API to update an existing Payment Instrument for a Customer, including selecting a <see href="#token-management_customer-payment-instrument_update-a-customer-payment-instrument_samplerequests-dropdown_make-customer-payment-instrument-the-default_liveconsole-tab-request-body">default Payment Instrument</see> for use in payments.
    /// </summary>
    /// <param name="customerId">The Id of a Customer.</param>
    /// <param name="paymentInstrumentId">The Id of a payment instrument.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="ifMatch">Contains an ETag value from a GET request to make the request conditional.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrument11"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchCustomersPaymentInstrumentError"/> when the server returns an error response.</exception>
    public Task<PaymentInstrument11> PatchCustomersPaymentInstrument(string customerId,
        string paymentInstrumentId,
        string? profileId,
        string? ifMatch,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers/{customerId}/payment-instruments/{paymentInstrumentId}"),
            [new TemplateParam("customerId", customerId), new TemplateParam("paymentInstrumentId", paymentInstrumentId)],
            [],
            [new HeaderParam("profile-id", profileId),
                new HeaderParam("if-match", ifMatch),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            JsonResponse.Create<PaymentInstrument11>(),
            PatchCustomersPaymentInstrumentErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Customer Payment Instrument</b>&lt;br&gt;A Customer Payment Instrument represents tokenized customer payment information such as expiration date, billing address &amp; card type.&lt;br&gt;A <see href="#token-management_customer_create-a-customer">Customer</see> can have <see href="#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument">one or more Payment Instruments</see>, with one allocated as the Customers default for use in payments.&lt;br&gt;A Payment Instrument token does not store the card number. A Payment Instrument is associated with an <see href="#token-management_instrument-identifier_create-an-instrument-identifier">Instrument Identifier</see> that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.&lt;br&gt;&lt;br&gt;<b>Creating a Customer Payment Instrument</b>&lt;br&gt;It is recommended you <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-create-default-payment-instrument-shipping-address-for-existing-customer_liveconsole-tab-request-body">create a Customer Payment Instrument via a Payment Authorization</see>, this can be for a zero amount.&lt;br&gt;In Europe: You should perform Payer Authentication alongside the Authorization.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Payment Network Tokens</b>&lt;br&gt;Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.&lt;br&gt;A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.&lt;br&gt;A Payment Network Token can also be <see href="#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token">provisioned for an existing Instrument Identifier</see>.&lt;br&gt;For more information about Payment Network Tokens see the Developer Guide.&lt;br&gt;&lt;br&gt;<b>Payments with Customers Payment Instrument</b>&lt;br&gt;To perform a payment with a particular Payment Instrument or Shipping Address specify the <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body">Payment Instrument in the payment request</see>.
    /// </summary>
    /// <param name="customerId">The Id of a Customer.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrument11"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCustomerPaymentInstrumentError"/> when the server returns an error response.</exception>
    public Task<PaymentInstrument11> PostCustomerPaymentInstrument(string customerId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/customers/{customerId}/payment-instruments"),
            [new TemplateParam("customerId", customerId)],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentInstrument11>(),
            PostCustomerPaymentInstrumentErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
