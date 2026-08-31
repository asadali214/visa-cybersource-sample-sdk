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
/// Cybersource Payouts Funds Transfer REST API for Account Funding Transaction (AFT)
/// </summary>
public sealed class PullFundsApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal PullFundsApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Refund an Account Funding Transaction (AFT).
    /// </summary>
    /// <param name="id">The transaction id of a previous Account Funding Transaction.</param>
    /// <param name="contentType"></param>
    /// <param name="xRequestid"></param>
    /// <param name="vcMerchantId"></param>
    /// <param name="vcPermissions"></param>
    /// <param name="vcCorrelationId"></param>
    /// <param name="vcOrganizationId"></param>
    /// <param name="pullFundsRefundRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreatePullFundsRefundError"/> when the server returns an error response.</exception>
    public Task CreatePullFundsRefund(string id,
        string contentType,
        string xRequestid,
        string vcMerchantId,
        string vcPermissions,
        string vcCorrelationId,
        string vcOrganizationId,
        PullFundsRefundRequest pullFundsRefundRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v1/pull-funds-transfer/{id}/refund"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("x-requestid", xRequestid),
                new HeaderParam("v-c-merchant-id", vcMerchantId),
                new HeaderParam("v-c-permissions", vcPermissions),
                new HeaderParam("v-c-correlation-id", vcCorrelationId),
                new HeaderParam("v-c-organization-id", vcOrganizationId),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(pullFundsRefundRequest),
            VoidResponse.Instance,
            CreatePullFundsRefundErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Reverse an Account Funding Transaction (AFT).
    /// </summary>
    /// <param name="id">The transaction id of a previous Account Funding Transaction.</param>
    /// <param name="contentType"></param>
    /// <param name="xRequestid"></param>
    /// <param name="vcMerchantId"></param>
    /// <param name="vcPermissions"></param>
    /// <param name="vcCorrelationId"></param>
    /// <param name="vcOrganizationId"></param>
    /// <param name="pullFundsReversalRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreatePullFundsReversalError"/> when the server returns an error response.</exception>
    public Task CreatePullFundsReversal(string id,
        string contentType,
        string xRequestid,
        string vcMerchantId,
        string vcPermissions,
        string vcCorrelationId,
        string vcOrganizationId,
        PullFundsReversalRequest pullFundsReversalRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v1/pull-funds-transfer/{id}/reversal"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("x-requestid", xRequestid),
                new HeaderParam("v-c-merchant-id", vcMerchantId),
                new HeaderParam("v-c-permissions", vcPermissions),
                new HeaderParam("v-c-correlation-id", vcCorrelationId),
                new HeaderParam("v-c-organization-id", vcOrganizationId),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(pullFundsReversalRequest),
            VoidResponse.Instance,
            CreatePullFundsReversalErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Receive funds using an Account Funding Transaction (AFT).
    /// </summary>
    /// <param name="contentType"></param>
    /// <param name="xRequestid"></param>
    /// <param name="vcMerchantId"></param>
    /// <param name="vcPermissions"></param>
    /// <param name="vcCorrelationId"></param>
    /// <param name="vcOrganizationId"></param>
    /// <param name="pullFundsRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreatePullFundsTransferError"/> when the server returns an error response.</exception>
    public Task CreatePullFundsTransfer(string contentType,
        string xRequestid,
        string vcMerchantId,
        string vcPermissions,
        string vcCorrelationId,
        string vcOrganizationId,
        PullFundsRequest pullFundsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v1/pull-funds-transfer"),
            [],
            [],
            [new HeaderParam("Content-Type", contentType),
                new HeaderParam("x-requestid", xRequestid),
                new HeaderParam("v-c-merchant-id", vcMerchantId),
                new HeaderParam("v-c-permissions", vcPermissions),
                new HeaderParam("v-c-correlation-id", vcCorrelationId),
                new HeaderParam("v-c-organization-id", vcOrganizationId),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(pullFundsRequest),
            VoidResponse.Instance,
            CreatePullFundsTransferErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
