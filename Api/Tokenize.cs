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
/// An orchestration resource used to combine multiple API calls into a single request.
/// </summary>
public sealed class Tokenize
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Tokenize(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// |  |  |  |
    /// | --- | --- | --- |
    /// |The <b>Tokenize API</b> endpoint facilitates the creation of various TMS tokens such as Customers, Payment Instruments, Shipping Addresses, and Instrument Identifiers in a single operation. The request includes a processingInformation object, which specifies <b>"TOKEN_CREATE"</b> and the types of tokens to be created. The <b>tokenInformation</b> section of the request includes detailed information relevant to each token type. This includes attributes for Customers, Payment Instruments, Shipping Addresses, Instrument Identifiers and Transient Token data. The payload is flexible, allowing for different combinations of tokens to be created in a single request.|&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;|The <b>API response</b> includes a responses array, which details the outcome of the tokenization process for each requested resource type, such as Customer, Payment Instrument, Shipping Address, and Instrument Identifier. Each entry in this array provides an HTTP status code such as <b>201/200 for successful creations</b>, and a unique identifier for the newly created token.&lt;br&gt;In cases where token creation encounters issues, the response includes a <b>non-2XX</b> status code and an errors array for the affected resource. Each error object in the array details the <b>error type and a descriptive message</b> providing insight into why a particular token creation was not attempted or failed.
    /// </summary>
    /// <param name="profileId">The Id of a profile containing user specific TMS configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokenizeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="TokenizeError"/> when the server returns an error response.</exception>
    public Task<TokenizeResponse> TokenizeInvoke(string? profileId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/tms/v2/tokenize"),
            [],
            [],
            [new HeaderParam("profile-id", profileId), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<TokenizeResponse>(),
            TokenizeErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
