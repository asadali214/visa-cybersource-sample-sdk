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
/// API for creation and retrieval of Reports
/// </summary>
public sealed class ReportDownloads
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal ReportDownloads(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Download a report using the unique report name and date.
    /// </summary>
    /// <param name="reportDate">Valid date on which to download the report in <b>ISO 8601 format</b> Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>  <b>Example date format:</b>  yyyy-mm-dd For reports that span multiple days, this value would be the end date of the report in the time zone of the report subscription. Example 1: If your report start date is 2020-03-06 and the end date is 2020-03-09, the reportDate passed in the query is 2020-03-09. Example 2: If your report runs from midnight to midnight on 2020-03-09, the reportDate passed in the query is 2020-03-10</param>
    /// <param name="reportName">Name of the report to download</param>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DownloadReportError"/> when the server returns an error response.</exception>
    public Task DownloadReport(DateTimeOffset reportDate,
        string reportName,
        string? organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/report-downloads"),
            [],
            [new Param("reportDate", reportDate.ToDate()),
                new Param("reportName", reportName),
                new Param("organizationId", organizationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DownloadReportErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
