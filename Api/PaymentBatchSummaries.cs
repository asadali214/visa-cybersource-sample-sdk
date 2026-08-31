using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core;
using CyberSourceMergedSpec.Core.Exceptions;
using CyberSourceMergedSpec.Core.Extensions;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Request;
using CyberSourceMergedSpec.Core.Response;
using CyberSourceMergedSpec.Errors;

namespace CyberSourceMergedSpec.Api;

/// <summary>
/// API for payment batch summary reports
/// </summary>
public sealed class PaymentBatchSummaries
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal PaymentBatchSummaries(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Scope can be either account/merchant or reseller.
    /// </summary>
    /// <param name="startTime">Valid report Start Time in <b>ISO 8601 format</b> Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>  <b>Example date format:</b>   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z)</param>
    /// <param name="endTime">Valid report End Time in <b>ISO 8601 format</b> Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>  <b>Example date format:</b>   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z)</param>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="rollUp">Conditional - RollUp for data for day/week/month. Required while getting breakdown data for a Merchant</param>
    /// <param name="breakdown">Conditional - Breakdown on account_rollup/all_merchant/selected_merchant. Required while getting breakdown data for a Merchant.</param>
    /// <param name="startDayOfWeek">Optional - Start day of week to breakdown data for weeks in a month</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPaymentBatchSummaryError"/> when the server returns an error response.</exception>
    public Task GetPaymentBatchSummary(DateTimeOffset startTime,
        DateTimeOffset endTime,
        string? organizationId,
        string? rollUp,
        string? breakdown,
        int? startDayOfWeek,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/payment-batch-summaries"),
            [],
            [new Param("startTime", startTime.ToIso8601()),
                new Param("endTime", endTime.ToIso8601()),
                new Param("organizationId", organizationId),
                new Param("rollUp", rollUp),
                new Param("breakdown", breakdown),
                new Param("startDayOfWeek", startDayOfWeek)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetPaymentBatchSummaryErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
