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

public sealed class BinLookup
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal BinLookup(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// The BIN Lookup Service is a versatile business tool that provides card network agnostic solution designed to ensure frictionless transaction experience by utilizing up-to-date Bank Identification Number (BIN) attributes sourced from multiple global and regional data sources.
    /// This service helps to improve authorization rates by helping to route transactions to the best-suited card network, minimizes fraud through card detail verification and aids in regulatory compliance by identifying card properties. The service is flexible and provides businesses with a flexible choice of inputs such as primary account number (PAN), network token from major networks (such as Visa, American Express, Discover and several regional networks) which includes device PAN (DPAN), and all types of tokens generated via CyberSource Token Management Service (TMS).
    /// Currently, the range of available credentials is contingent on the networks enabled for the business entity. Therefore, the network information specified in this documentation is illustrative and subject to personalized offerings for each reseller or merchant.
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetAccountInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAccountInfoError"/> when the server returns an error response.</exception>
    public Task<GetAccountInfoResponse> GetAccountInfo(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/bin/v1/binlookup"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<GetAccountInfoResponse>(),
            GetAccountInfoErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
