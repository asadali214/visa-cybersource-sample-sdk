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
/// A payout enables an originator to send funds on behalf of itself, merchants, or customers to credit card
/// accounts using an Original Credit Transaction (OCT). An originator is a merchant, government entity, or
/// corporation with a merchant account from an acquiring bank.
/// </summary>
public sealed class Payouts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Payouts(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Send funds from a selected funding source to a designated credit/debit card account or a prepaid card using an Original Credit Transaction (OCT).
    /// The availability of API features for a merchant can depend on the portfolio configuration and may need to be enabled at the portfolio level before they can be added to merchant accounts.
    /// </summary>
    /// <param name="octCreatePaymentRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OctCreatePaymentError"/> when the server returns an error response.</exception>
    public Task OctCreatePayment(OctCreatePaymentRequest octCreatePaymentRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/payouts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(octCreatePaymentRequest),
            VoidResponse.Instance,
            OctCreatePaymentErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
