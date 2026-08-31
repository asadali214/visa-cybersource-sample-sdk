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
/// A stand-alone Payment Instrument is linked to an Instrument Identifier.
/// It stores additional information in relation to a card number(PAN) or bank account (echeck).
/// </summary>
public sealed class PaymentInstrumentApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal PaymentInstrumentApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Standalone Payment Instruments</b>&lt;br&gt;A Payment Instrument represents tokenized payment information such as expiration date, billing address &amp; card type.&lt;br&gt;A Payment Instrument token does not store the card number. A Payment Instrument is associated with an <see href="#token-management_instrument-identifier_create-an-instrument-identifier">Instrument Identifier</see> that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.&lt;br&gt;<b>Standalone Payment Instruments do not belong to a <see href="#token-management_customer_create-a-customer">Customer</see>.</b>|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Deleting a Payment Instrument</b>&lt;br&gt;Your system can use this API to delete an existing Payment Instrument.&lt;br&gt;Any Instrument Identifiers representing the card number will also be deleted if they are not associated with any other Payment Instruments.
    /// </summary>
    /// <param name="paymentInstrumentId">The Id of a payment instrument.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeletePaymentInstrumentError"/> when the server returns an error response.</exception>
    public Task DeletePaymentInstrument(string paymentInstrumentId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v1/paymentinstruments/{paymentInstrumentId}"),
            [new TemplateParam("paymentInstrumentId", paymentInstrumentId)],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeletePaymentInstrumentErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Standalone Payment Instruments</b>&lt;br&gt;A Payment Instrument represents tokenized payment information such as expiration date, billing address &amp; card type.&lt;br&gt;A Payment Instrument token does not store the card number. A Payment Instrument is associated with an <see href="#token-management_instrument-identifier_create-an-instrument-identifier">Instrument Identifier</see> that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.&lt;br&gt;<b>Standalone Payment Instruments do not belong to a <see href="#token-management_customer_create-a-customer">Customer</see>.</b>|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Retrieving a Payment Instrument</b>&lt;br&gt;Your system can use this API to retrieve an existing Payment Instrument.&lt;br&gt;To perform a payment with a particular Payment Instrument simply specify the <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body">Payment Instrument Id in the payments request</see>.
    /// </summary>
    /// <param name="paymentInstrumentId">The Id of a payment instrument.</param>
    /// <param name="retrieveBinDetails">Retrieve the Bin Details of PAN or network token</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrument11"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPaymentInstrumentError"/> when the server returns an error response.</exception>
    public Task<PaymentInstrument11> GetPaymentInstrument(string paymentInstrumentId,
        bool? retrieveBinDetails,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v1/paymentinstruments/{paymentInstrumentId}"),
            [new TemplateParam("paymentInstrumentId", paymentInstrumentId)],
            [new Param("retrieveBinDetails", retrieveBinDetails)],
            [new HeaderParam("profile-id", profileId)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentInstrument11>(),
            GetPaymentInstrumentErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Standalone Payment Instruments</b>&lt;br&gt;A Payment Instrument represents tokenized payment information such as expiration date, billing address &amp; card type.&lt;br&gt;A Payment Instrument token does not store the card number. A Payment Instrument is associated with an <see href="#token-management_instrument-identifier_create-an-instrument-identifier">Instrument Identifier</see> that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.&lt;br&gt;<b>Standalone Payment Instruments do not belong to a <see href="#token-management_customer_create-a-customer">Customer</see>.</b>|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Updating a Payment Instrument</b>&lt;br&gt;Your system can use this API to update an existing Payment Instrument.
    /// </summary>
    /// <param name="paymentInstrumentId">The Id of a payment instrument.</param>
    /// <param name="retrieveBinDetails">Retrieve the Bin Details of PAN or network token</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="ifMatch">Contains an ETag value from a GET request to make the request conditional.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrument11"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchPaymentInstrumentError"/> when the server returns an error response.</exception>
    public Task<PaymentInstrument11> PatchPaymentInstrument(string paymentInstrumentId,
        bool? retrieveBinDetails,
        string? profileId,
        string? ifMatch,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v1/paymentinstruments/{paymentInstrumentId}"),
            [new TemplateParam("paymentInstrumentId", paymentInstrumentId)],
            [new Param("retrieveBinDetails", retrieveBinDetails)],
            [new HeaderParam("profile-id", profileId),
                new HeaderParam("if-match", ifMatch),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            JsonResponse.Create<PaymentInstrument11>(),
            PatchPaymentInstrumentErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |<b>Standalone Payment Instruments</b>&lt;br&gt;A Payment Instrument represents tokenized payment information such as expiration date, billing address &amp; card type.&lt;br&gt;A Payment Instrument token does not store the card number. A Payment Instrument is associated with an <see href="#token-management_instrument-identifier_create-an-instrument-identifier">Instrument Identifier</see> that represents either a payment card number, or in the case of an ACH bank account, the routing and account number.&lt;br&gt;<b>Standalone Payment Instruments do not belong to a <see href="#token-management_customer_create-a-customer">Customer</see>.</b>&lt;br&gt;&lt;br&gt;<b>Creating a Payment Instrument</b>&lt;br&gt;It is recommended you <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-with-token-create_authorization-with-customer-token-creation_liveconsole-tab-request-body">create a Payment Instrument via a Payment Authorization</see>, this can be for a zero amount.&lt;br&gt;In Europe: You should perform Payer Authentication alongside the Authorization.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|<b>Payment Network Tokens</b>&lt;br&gt;Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.&lt;br&gt;A Payment Network Token will be automatically created and used in future payments if you are enabled for the service.&lt;br&gt;A Payment Network Token can also be <see href="#token-management_instrument-identifier_enroll-an-instrument-identifier-for-payment-network-token">provisioned for an existing Instrument Identifier</see>.&lt;br&gt;For more information about Payment Network Tokens see the Developer Guide.&lt;br&gt;&lt;br&gt;<b>Payments with Payment Instruments</b>&lt;br&gt;To perform a payment with a particular Payment Instrument specify the <see href="#payments_payments_process-a-payment_samplerequests-dropdown_authorization-using-tokens_authorization-with-customer-payment-instrument-and-shipping-address-token-id_liveconsole-tab-request-body">Payment Instrument in the payment request</see>.
    /// </summary>
    /// <param name="retrieveBinDetails">Retrieve the Bin Details of PAN or network token</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrument11"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPaymentInstrumentError"/> when the server returns an error response.</exception>
    public Task<PaymentInstrument11> PostPaymentInstrument(bool? retrieveBinDetails,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v1/paymentinstruments"),
            [],
            [new Param("retrieveBinDetails", retrieveBinDetails)],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentInstrument11>(),
            PostPaymentInstrumentErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
