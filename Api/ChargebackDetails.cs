using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Exceptions;
using CyberSourceMergedSpec.Core.Extensions;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Request;
using CyberSourceMergedSpec.Core.Response;

namespace CyberSourceMergedSpec.Api;

/// <summary>
/// API for requesting Chargeback Details.
/// </summary>
public sealed class ChargebackDetails
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal ChargebackDetails(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Chargeback Detail Report Description
    /// </summary>
    /// <param name="startTime">Valid report Start Time in <b>ISO 8601 format</b> Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>  <b>Example date format:</b>   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z)</param>
    /// <param name="endTime">Valid report End Time in <b>ISO 8601 format</b> Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>  <b>Example date format:</b>   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z)</param>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task GetChargebackDetails(DateTimeOffset startTime,
        DateTimeOffset endTime,
        string? organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/chargeback-details"),
            [],
            [new Param("startTime", startTime.ToIso8601()),
                new Param("endTime", endTime.ToIso8601()),
                new Param("organizationId", organizationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
