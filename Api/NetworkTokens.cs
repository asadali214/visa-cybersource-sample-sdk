using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Exceptions;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Request;
using CyberSourceMergedSpec.Core.Response;
using CyberSourceMergedSpec.Errors;
using CyberSourceMergedSpec.Models;
using CyberSourceMergedSpec.Models.Enums;

namespace CyberSourceMergedSpec.Api;

/// <summary>
/// A Network Token represents a tokenized version of a card number (PAN) that can be used for payment transactions and, it's represented by a Tokenized Card in TMS.
/// </summary>
public sealed class NetworkTokens
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal NetworkTokens(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Retrieves Card Art for a specific Instrument Identifier. The Card Art is a visual representation of the cardholder's payment card.
    /// Card Art is only available if a Network Token is successfully provisioned.
    /// </summary>
    /// <param name="instrumentIdentifierId">The Id of an Instrument Identifier.</param>
    /// <param name="tokenProvider">The token provider.</param>
    /// <param name="assetType">The type of asset.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetCardArtAssetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<GetCardArtAssetResponse> GetCardArtAsset(string instrumentIdentifierId,
        TokenProvider tokenProvider,
        AssetType assetType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/tokens/{instrumentIdentifierId}/{tokenProvider}/assets/{assetType}"),
            [new TemplateParam("instrumentIdentifierId", instrumentIdentifierId),
                new TemplateParam("tokenProvider", tokenProvider),
                new TemplateParam("assetType", assetType)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetCardArtAssetResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// |<b>Tokenized Cards</b>&lt;br&gt;A Tokenized Card represents a network token.
    /// Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.
    /// This API returns the details of a tokenized card stored in TMS. You can use this API to check the status of a tokenized card and retrieve details such as the last four digits of the underlying card, expiration date, and card type.
    /// </summary>
    /// <param name="tokenizedCardId">The Id of a tokenized card.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTokenizedCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTokenizedCardError"/> when the server returns an error response.</exception>
    public Task<GetTokenizedCardResponse> GetTokenizedCard(string tokenizedCardId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/tokenized-cards/{tokenizedCardId}"),
            [new TemplateParam("tokenizedCardId", tokenizedCardId)],
            [],
            [new HeaderParam("profile-id", profileId)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetTokenizedCardResponse>(),
            GetTokenizedCardErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// <b>Lifecycle Management Events</b>&lt;br&gt;Simulates an issuer life cycle manegement event for updates on the tokenized card.
    /// The events that can be simulated are:
    /// - Token status changes (e.g. active, suspended, deleted)
    /// - Updates to the underlying card, including card art changes, expiration date changes, and card number suffix.
    /// <b>Note:</b> This is only available in CAS environment.
    /// </summary>
    /// <param name="tokenizedCardId">The Id of a tokenized card.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostIssuerLifeCycleSimulationError"/> when the server returns an error response.</exception>
    public Task PostIssuerLifeCycleSimulation(string tokenizedCardId,
        string profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/tokenized-cards/{tokenizedCardId}/issuer-life-cycle-event-simulations"),
            [new TemplateParam("tokenizedCardId", tokenizedCardId)],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            VoidResponse.Instance,
            PostIssuerLifeCycleSimulationErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// <b>Note</b>: This resource will be replace by <see href="#/paths/~1tms~1v3~1tokens~1{tokenId}~1payment-credentials/post">payment credentials version 3</see>. The SDK will remain available for now; however, it will no longer be documented or maintain in the Developer Centre.&lt;br&gt;
    /// <b>Token</b>&lt;br&gt;A Token can represent your tokenized Customer, Payment Instrument, Instrument Identifier or Tokenized Card information.&lt;br&gt;
    /// <b>Payment Credentials</b>&lt;br&gt;Contains payment information such as the network token, generated cryptogram for Visa &amp; MasterCard or dynamic CVV for Amex in a JSON Web Encryption (JWE) response.&lt;br&gt;Your system can use this API to retrieve the Payment Credentials for an existing Customer, Payment Instrument, Instrument Identifier or Tokenized Card.&lt;br&gt;Optionally, <b>authenticated identities</b> information from Passkey authentication can be provided to potentially achieve liability shift, which may result in the return of an e-commerce indicator of 5 if successful.
    /// </summary>
    /// <param name="tokenId">The Id of a token representing a Customer, Payment Instrument or Instrument Identifier.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostTokenPaymentCredentialsError"/> when the server returns an error response.</exception>
    public Task PostTokenPaymentCredentials(string tokenId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/tokens/{tokenId}/payment-credentials"),
            [new TemplateParam("tokenId", tokenId)],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            VoidResponse.Instance,
            PostTokenPaymentCredentialsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// <b>Payment Credentials</b>&lt;br&gt;Contains payment information such as the network token, generated TAVV cryptogram for Visa &amp; MasterCard, dynamic CVV for Amex, or DTVV cryptogram for VISA. This latest version (v3) returns the Primary Account Number details, if the network token is not present. The response is provided in JSON Web Encryption (JWE) format. &lt;br&gt;Your system can use this API to retrieve the Payment Credentials for an existing Customer, Payment Instrument, Instrument Identifier or Tokenized Card.&lt;br&gt;Optionally, <b>authenticated identities</b> information from Passkey authentication can be provided to potentially achieve liability shift, which may result in the return of an e-commerce indicator of 5 if successful.
    /// </summary>
    /// <param name="tokenId">The Id of a token representing a Customer, Payment Instrument or Instrument Identifier.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostTokenPaymentCredentialsV3Error"/> when the server returns an error response.</exception>
    public Task PostTokenPaymentCredentialsV3(string tokenId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v3/tokens/{tokenId}/payment-credentials"),
            [new TemplateParam("tokenId", tokenId)],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            VoidResponse.Instance,
            PostTokenPaymentCredentialsV3ErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// <b>Tokenized cards</b>&lt;br&gt;A Tokenized card represents a network token.
    /// Network tokens perform better than regular card numbers and they are not necessarily invalidated when a cardholder loses their card, or it expires.
    /// This API submits a request to the card association to create a network token. If successful, a tokenized card will be created in TMS to represent the network token.
    /// </summary>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PostTokenizedCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostTokenizedCardError"/> when the server returns an error response.</exception>
    public Task<PostTokenizedCardResponse> PostTokenizedCard(string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/tokenized-cards"),
            [],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<PostTokenizedCardResponse>(),
            PostTokenizedCardErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// This API attempts to delete a network token from the card association with a specified reason. |
    /// If successful, the corresponding tokenized card will be deleted. |
    /// The reason for deletion can be specified to provide context for the deletion operation.
    /// </summary>
    /// <param name="tokenizedCardId">The Id of a tokenized card.</param>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostTokenizedCardDeleteError"/> when the server returns an error response.</exception>
    public Task PostTokenizedCardDelete(string tokenizedCardId,
        string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/tokenized-cards/{tokenizedCardId}/delete"),
            [new TemplateParam("tokenizedCardId", tokenizedCardId)],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            VoidResponse.Instance,
            PostTokenizedCardDeleteErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
