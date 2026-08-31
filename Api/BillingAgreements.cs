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
/// A billingAgreement is a stand-alone transaction that is not linked to any previous transactions. It takes money from
/// your merchant bank account and returns it to the customer.
/// </summary>
public sealed class BillingAgreements
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal BillingAgreements(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// #### Standing Instruction:
    /// Standing Instruction with or without Token.
    /// <para>
    /// #### Revoke Mandate:
    /// When you revoke a mandate, any pending direct debits linked to that mandate are canceled. No notifications are sent.
    /// When you revoke a mandate with no pending direct debits, the Bacs scheme or customer’s bank notify you of any subsequent direct debit events.
    /// When you revoke a mandate, you cannot send a direct debit request using the mandate ID. Customer payments cannot be made against a revoked mandate.
    /// You can revoke a mandate when the customer:
    ///   - Requests that you revoke the mandate.
    ///   - Closes their account with you.
    /// Possible revoke mandate status values -
    ///   - Revoked—the revoke mandate request was successfully processed.
    ///   - Failed—the revoke mandate request was not accepted.
    /// </para>
    /// <para>
    /// #### Update Mandate:
    /// In most cases, the account details of an existing mandate cannot be updated in the Bacs schema,
    /// except by creating a new mandate. However, some very limited customer information, like name and address,
    /// can be updated to the mandate without needing to revoke it first
    /// </para>
    /// <para>
    /// #### Mandate Status:
    /// After the customer signs the mandate, request that the mandate status service verify the mandate status.
    /// Possible mandate status values:
    ///   - Active—the mandate is successfully created. A direct debit can be sent for this mandate ID.
    ///   - Pending—a pending mandate means the mandate is not yet signed.
    ///   - Failed—the customer did not authenticate.
    ///   - Expired—the deadline to create the mandate passed.
    ///   - Revoked—the mandate is cancelled.
    /// </para>
    /// <para>
    /// #### Paypal Billing Agreement:
    /// A billing agreement is set up between PayPal and your customer.
    /// When you collect the details of a customer’s billing agreement, you are able to bill that customer without requiring an authorization for each payment.
    /// You can bill the customer at the same time you process their PayPal Express checkout order, which simplifies your business processes.
    /// </para>
    /// </summary>
    /// <param name="id">ID for de-registration or cancellation of Billing Agreement</param>
    /// <param name="modifyBillingAgreement"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BillingAgreementsDeRegistrationError"/> when the server returns an error response.</exception>
    public Task BillingAgreementsDeRegistration(string id,
        ModifyBillingAgreement modifyBillingAgreement,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/billing-agreements/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(modifyBillingAgreement),
            VoidResponse.Instance,
            BillingAgreementsDeRegistrationErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Standing Instruction with or without Token.
    /// </summary>
    /// <param name="id">ID for intimation of Billing Agreement</param>
    /// <param name="intimateBillingAgreement"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BillingAgreementsIntimationError"/> when the server returns an error response.</exception>
    public Task BillingAgreementsIntimation(string id,
        IntimateBillingAgreement intimateBillingAgreement,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/billing-agreements/{id}/intimations"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(intimateBillingAgreement),
            VoidResponse.Instance,
            BillingAgreementsIntimationErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// #### Standing Instruction:
    /// Standing Instruction with or without Token. Transaction amount in case First payment is coming along with registration. Only 2 decimal places allowed
    /// <para>
    /// #### Create Mandate:
    /// You can create a mandate through the direct debit mandate flow.
    /// Possible create mandate status values:
    ///   - Pending—the create mandate request was successfully processed.
    ///   - Failed—the create mandate request was not accepted.
    /// </para>
    /// <para>
    /// #### Import Mandate:
    /// In the Bacs scheme, a mandate is created with a status of active. Direct debit collections can be made against it immediately.
    /// You can import a mandate to the CyberSource database when:
    ///   - You have existing customers with signed, active mandates
    ///   - You manage mandates outside of CyberSource.
    /// </para>
    /// <para>
    /// When you import an existing mandate to the CyberSource database, provide a unique value for the mandate ID or the request results in an error.
    /// If an import mandate request is not accepted, the import mandate status value is failed.
    /// </para>
    /// </summary>
    /// <param name="createBillingAgreement"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BillingAgreementsRegistrationError"/> when the server returns an error response.</exception>
    public Task BillingAgreementsRegistration(CreateBillingAgreement createBillingAgreement,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/billing-agreements"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(createBillingAgreement),
            VoidResponse.Instance,
            BillingAgreementsRegistrationErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
