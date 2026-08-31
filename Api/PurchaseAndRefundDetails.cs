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
/// API for Purchase and Refund Details
/// </summary>
public sealed class PurchaseAndRefundDetails
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal PurchaseAndRefundDetails(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Download the Purchase and Refund Details report. This report report includes all purchases and refund transactions, as well as all activities related to transactions resulting in an adjustment to the net proceeds.
    /// </summary>
    /// <param name="startTime">Valid report Start Time in <b>ISO 8601 format</b> Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>  <b>Example date format:</b>   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z)</param>
    /// <param name="endTime">Valid report End Time in <b>ISO 8601 format</b> Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>  <b>Example date format:</b>   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z)</param>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="groupName">Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds</param>
    /// <param name="offset">Offset of the Purchase and Refund Results.</param>
    /// <param name="paymentSubtype">Payment Subtypes.   - <b>ALL</b>:  All Payment Subtypes   - <b>VI</b> :  Visa   - <b>MC</b> :  Master Card   - <b>AX</b> :  American Express   - <b>DI</b> :  Discover   - <b>DP</b> :  Pinless Debit</param>
    /// <param name="viewBy">View results by Request Date or Submission Date.   - <b>requestDate</b> : Request Date   - <b>submissionDate</b>: Submission Date</param>
    /// <param name="limit">Results count per page. Range(1-2000)</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPurchaseAndRefundDetailsError"/> when the server returns an error response.</exception>
    public Task GetPurchaseAndRefundDetails(DateTimeOffset startTime,
        DateTimeOffset endTime,
        string? organizationId,
        string? groupName,
        int? offset,
        string? paymentSubtype = "ALL",
        string? viewBy = "requestDate",
        int? limit = 2000,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/purchase-refund-details"),
            [],
            [new Param("startTime", startTime.ToIso8601()),
                new Param("endTime", endTime.ToIso8601()),
                new Param("organizationId", organizationId),
                new Param("paymentSubtype", paymentSubtype),
                new Param("viewBy", viewBy),
                new Param("groupName", groupName),
                new Param("offset", offset),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetPurchaseAndRefundDetailsErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
