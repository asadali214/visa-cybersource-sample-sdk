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
/// An Instrument Identifier represents a unique card number(PAN) or bank account (echeck).
/// It can also be associated with a Network Token that can be used for payment transactions.
/// </summary>
public sealed class InstrumentIdentifierApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal InstrumentIdentifierApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Instrument Identifiers</b>&lt;br&gt;An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing &lt;br&gt;and account numbers.&lt;br&gt;The same token Id is returned for a specific card number or bank account &amp; routing number allowing the &lt;br&gt;Instrument Identifier Id to be used for cross-channel payment tracking.&lt;br&gt;An Instrument Identifier can exist independently but also be associated with a <see href="#token-management_customer-payment-instrument_create-a-customer-payment-instrument">Customer Payment Instrument</see> &lt;br&gt;or <see href="#token-management_payment-instrument_create-a-payment-instrument">Standalone Payment Instrument</see>.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Deleting an Instrument Identifier</b>&lt;br&gt;Your system can use this API to delete an existing Instrument Identifier.&lt;br&gt;An Instrument Identifier cannot be deleted if it is linked to any Payment Instruments.&lt;br&gt;You can <see href="#token-management_instrument-identifier_list-payment-instruments-for-an-instrument-identifier">retrieve all Payment Instruments associated with an Instrument Identifier</see>.
    /// </summary>
    /// <param name="instrumentIdentifierId">The Id of an Instrument Identifier.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteInstrumentIdentifierError"/> when the server returns an error response.</exception>
    public Task DeleteInstrumentIdentifier(string instrumentIdentifierId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v1/instrumentidentifiers/{instrumentIdentifierId}"),
            [new TemplateParam("instrumentIdentifierId", instrumentIdentifierId)],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteInstrumentIdentifierErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Instrument Identifiers</b>&lt;br&gt;An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing and account number.&lt;br&gt;The same token Id is returned for a specific card number or bank account &amp; routing number allowing the Instrument Identifier Id to be used for cross-channel payment tracking.&lt;br&gt;An Instrument Identifier can exist independently but also be associated with a <see href="#token-management_customer-payment-instrument_create-a-customer-payment-instrument">Customer Payment Instrument</see> or <see href="#token-management_payment-instrument_create-a-payment-instrument">Standalone Payment Instrument</see>.&lt;br&gt;&lt;br&gt;<b>Retrieving an Instrument Identifier</b>&lt;br&gt;Your system can use this API to retrieve an Instrument Identifier.&lt;br&gt;<b>Note: the actual card data will be masked.</b>&lt;br&gt;The Instrument Identifier will also be returned when retrieving a <see href="#token-management_customer_retrieve-a-customer">Customer</see>, <see href="#token-management_customer-payment-instrument_retrieve-a-customer-payment-instrument">Customer Payment Instrument</see> or <see href="#token-management_payment-instrument_retrieve-a-payment-instrument">Standalone Payment Instrument</see>.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Payment Network Tokens</b>&lt;br&gt;Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.&lt;br&gt;A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.&lt;br&gt;A Payment Network Token can also be <see href="#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token">provisioned for an existing Instrument Identifier</see>.&lt;br&gt;For more information about Payment Network Tokens see the Developer Guide.&lt;br&gt;&lt;br&gt;<b>Payments with Instrument Identifiers</b>&lt;br&gt;To perform a payment with an Instrument Identifier simply specify the <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-instrument-identifier-token-id_liveconsole-tab-request-body">Instrument Identifier Id in the payments request along with the expiration date, card type, &amp; billing address</see>.&lt;br&gt;When an Instrument Identifier is used in a payment the <b>_previousTransactionId_</b> and <b>_originalAuthorizedAmount_</b> values are automatically recorded.&lt;br&gt;These values will be added for you to future Merchant Initiated Transaction payments.
    /// </summary>
    /// <param name="instrumentIdentifierId">The Id of an Instrument Identifier.</param>
    /// <param name="retrieveBinDetails">Retrieve the Bin Details of PAN or network token</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetInstrumentIdentifierResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetInstrumentIdentifierError"/> when the server returns an error response.</exception>
    public Task<GetInstrumentIdentifierResponse> GetInstrumentIdentifier(string instrumentIdentifierId,
        bool? retrieveBinDetails,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v1/instrumentidentifiers/{instrumentIdentifierId}"),
            [new TemplateParam("instrumentIdentifierId", instrumentIdentifierId)],
            [new Param("retrieveBinDetails", retrieveBinDetails)],
            [new HeaderParam("profile-id", profileId)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetInstrumentIdentifierResponse>(),
            GetInstrumentIdentifierErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Instrument Identifiers</b>&lt;br&gt;An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing &lt;br&gt;and account numbers.&lt;br&gt;The same token Id is returned for a specific card number or bank account &amp; routing number allowing the &lt;br&gt;Instrument Identifier Id to be used for cross-channel payment tracking.&lt;br&gt;An Instrument Identifier can exist independently but also be associated with a <see href="#token-management_customer-payment-instrument_create-a-customer-payment-instrument">Customer Payment Instrument</see> &lt;br&gt;or <see href="#token-management_payment-instrument_create-a-payment-instrument">Standalone Payment Instrument</see>.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Retrieving all Payment Instruments associated with an Instrument Identifier</b>&lt;br&gt;Your system can use this API to retrieve all Payment Instruments linked to an Instrument Identifier.
    /// </summary>
    /// <param name="instrumentIdentifierId">The Id of an Instrument Identifier.</param>
    /// <param name="retrieveBinDetails">Retrieve the Bin Details of PAN or network token</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="offset">Starting record in zero-based dataset that should be returned as the first object in the array. Default is 0.</param>
    /// <param name="limit">The maximum number that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrumentList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetInstrumentIdentifierPaymentInstrumentsListError"/> when the server returns an error response.</exception>
    public Task<PaymentInstrumentList> GetInstrumentIdentifierPaymentInstrumentsList(string instrumentIdentifierId,
        bool? retrieveBinDetails,
        string? profileId,
        long? offset = 0L,
        long? limit = 20L,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v1/instrumentidentifiers/{instrumentIdentifierId}/paymentinstruments"),
            [new TemplateParam("instrumentIdentifierId", instrumentIdentifierId)],
            [new Param("retrieveBinDetails", retrieveBinDetails),
                new Param("offset", offset),
                new Param("limit", limit)],
            [new HeaderParam("profile-id", profileId)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentInstrumentList>(),
            GetInstrumentIdentifierPaymentInstrumentsListErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Instrument Identifiers</b>&lt;br&gt;An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing and account number.&lt;br&gt;The same token Id is returned for a specific card number or bank account &amp; routing number allowing the Instrument Identifier Id to be used for cross-channel payment tracking.&lt;br&gt;An Instrument Identifier can exist independently but also be associated with a <see href="#token-management_customer-payment-instrument_create-a-customer-payment-instrument">Customer Payment Instrument</see> or <see href="#token-management_payment-instrument_create-a-payment-instrument">Standalone Payment Instrument</see>.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Updating an Instrument Identifier</b>&lt;br&gt;When an Instrument Identifier is used in a payment the <b>_previousTransactionId_</b> and <b>_originalAuthorizedAmount_</b> values are automatically recorded.&lt;br&gt;These values will be added for you to future Merchant Initiated Transaction payments.&lt;br&gt;Your system can use this API to update these values.
    /// </summary>
    /// <param name="instrumentIdentifierId">The Id of an Instrument Identifier.</param>
    /// <param name="retrieveBinDetails">Retrieve the Bin Details of PAN or network token</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="ifMatch">Contains an ETag value from a GET request to make the request conditional.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PatchInstrumentIdentifierResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchInstrumentIdentifierError"/> when the server returns an error response.</exception>
    public Task<PatchInstrumentIdentifierResponse> PatchInstrumentIdentifier(string instrumentIdentifierId,
        bool? retrieveBinDetails,
        string? profileId,
        string? ifMatch,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v1/instrumentidentifiers/{instrumentIdentifierId}"),
            [new TemplateParam("instrumentIdentifierId", instrumentIdentifierId)],
            [new Param("retrieveBinDetails", retrieveBinDetails)],
            [new HeaderParam("profile-id", profileId),
                new HeaderParam("if-match", ifMatch),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            JsonResponse.Create<PatchInstrumentIdentifierResponse>(),
            PatchInstrumentIdentifierErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Instrument Identifiers</b>&lt;br&gt;An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing and account number.&lt;br&gt;The same token Id is returned for a specific card number or bank account &amp; routing number allowing the Instrument Identifier Id to be used for cross-channel payment tracking.&lt;br&gt;An Instrument Identifier can exist independently but also be associated with a <see href="#token-management_customer-payment-instrument_create-a-customer-payment-instrument">Customer Payment Instrument</see> or <see href="#token-management_payment-instrument_create-a-payment-instrument">Standalone Payment Instrument</see>.&lt;br&gt;&lt;br&gt;<b>Creating an Instrument Identifier</b>&lt;br&gt;It is recommended you <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-instrument-identifier-token-creation_liveconsole-tab-request-body">create an Instrument Identifier via a Payment Authorization</see>, this can be for a zero amount.&lt;br&gt;An Instrument Identifier will also be created if you <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-customer-token-creation_liveconsole-tab-request-body">create a Customer via a Payment Authorization</see>&lt;br&gt;In Europe: You should perform Payer Authentication alongside the Authorization.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Payment Network Tokens</b>&lt;br&gt;Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.&lt;br&gt;A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.&lt;br&gt;A Payment Network Token can also be <see href="#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token">provisioned for an existing Instrument Identifier</see>.&lt;br&gt;For more information about Payment Network Tokens see the Developer Guide.&lt;br&gt;&lt;br&gt;<b>Payments with Instrument Identifiers</b>&lt;br&gt;To perform a payment with an Instrument Identifier simply specify the <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-instrument-identifier-token-id_liveconsole-tab-request-body">Instrument Identifier Id in the payments request along with the expiration date, card type, &amp; billing address</see>.&lt;br&gt;When an Instrument Identifier is used in a payment the <b>_previousTransactionId_</b> and <b>_originalAuthorizedAmount_</b> values are automatically recorded.&lt;br&gt;These values will be added for you to future Merchant Initiated Transaction payments.
    /// </summary>
    /// <param name="retrieveBinDetails">Retrieve the Bin Details of PAN or network token</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostInstrumentIdentifierResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostInstrumentIdentifierError"/> when the server returns an error response.</exception>
    public Task<PostInstrumentIdentifierResponse> PostInstrumentIdentifier(bool? retrieveBinDetails,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v1/instrumentidentifiers"),
            [],
            [new Param("retrieveBinDetails", retrieveBinDetails)],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<PostInstrumentIdentifierResponse>(),
            PostInstrumentIdentifierErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Instrument Identifiers</b>&lt;br&gt;An Instrument Identifier represents either a card number, or in the case of an ACH bank account, the routing and account number.&lt;br&gt;The same token Id is returned for a specific card number or bank account &amp; routing number allowing the Instrument Identifier Id to be used for cross-channel payment tracking.&lt;br&gt;An Instrument Identifier can exist independently but also be associated with a <see href="#token-management_customer-payment-instrument_create-a-customer-payment-instrument">Customer Payment Instrument</see> or <see href="#token-management_payment-instrument_create-a-payment-instrument">Standalone Payment Instrument</see>.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Enroll an Instrument Identifier for a Payment Network Token</b>&lt;br&gt;Your system can use this API to provision a Network token for an existing Instrument Identifier.&lt;br&gt;Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.&lt;br&gt;A Network token can be <see href="#token-management_instrument-identifier_create-an-instrument-identifier_samplerequests-dropdown_create-instrument-identifier-card-enroll-for-network-token_liveconsole-tab-request-body">provisioned when creating an Instrument Identifier</see>.This will occur automatically when creating a <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-customer-token-creation_liveconsole-tab-request-body">Customer</see>, <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-create-default-payment-instrument-shipping-address-for-existing-customer_liveconsole-tab-request-body">Payment Instrument</see> or <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-instrument-identifier-token-creation_liveconsole-tab-request-body">Instrument Identifier</see> via the Payments API.&lt;br&gt;For more information about Payment Network Tokens see the Developer Guide.
    /// </summary>
    /// <param name="instrumentIdentifierId">The Id of an Instrument Identifier.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostInstrumentIdentifierEnrollmentError"/> when the server returns an error response.</exception>
    public Task PostInstrumentIdentifierEnrollment(string instrumentIdentifierId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v1/instrumentidentifiers/{instrumentIdentifierId}/enrollment"),
            [new TemplateParam("instrumentIdentifierId", instrumentIdentifierId)],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            VoidResponse.Instance,
            PostInstrumentIdentifierEnrollmentErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
