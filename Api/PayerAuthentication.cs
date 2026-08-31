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

public sealed class PayerAuthentication
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal PayerAuthentication(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// This call verifies that the card is enrolled in a card authentication program.
    /// </summary>
    /// <param name="checkPayerAuthEnrollmentRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CheckPayerAuthEnrollmentError"/> when the server returns an error response.</exception>
    public Task CheckPayerAuthEnrollment(CheckPayerAuthEnrollmentRequest checkPayerAuthEnrollmentRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/risk/v1/authentications"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(checkPayerAuthEnrollmentRequest),
            VoidResponse.Instance,
            CheckPayerAuthEnrollmentErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// A new service for Merchants to get reference_id for Digital Wallets to use in place of BIN number in Cardinal. Set up file while authenticating with Cardinal. This service should be called by Merchant when payment instrument chosen or changes. This service has to be called before enrollment check. The availability of API features for a merchant may depend on the portfolio configuration and may need to be enabled at the portfolio level before they can be added to merchant accounts.
    /// </summary>
    /// <param name="payerAuthSetupRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PayerAuthSetupError"/> when the server returns an error response.</exception>
    public Task PayerAuthSetup(PayerAuthSetupRequest payerAuthSetupRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/risk/v1/authentication-setups"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(payerAuthSetupRequest),
            VoidResponse.Instance,
            PayerAuthSetupErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// This call retrieves and validates the authentication results from issuer and allows the merchant to proceed with processing the payment.
    /// </summary>
    /// <param name="validateRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ValidateAuthenticationResultsError"/> when the server returns an error response.</exception>
    public Task ValidateAuthenticationResults(ValidateRequest validateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/risk/v1/authentication-results"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(validateRequest),
            VoidResponse.Instance,
            ValidateAuthenticationResultsErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
