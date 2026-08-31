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
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Api;

/// <summary>
/// API for creation and retrieval of Reports
/// </summary>
public sealed class Reports
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Reports(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Create a one-time report. You must specify the type of report in reportDefinitionName. For a list of values for reportDefinitionName, see the <see href="https://www.cybersource.com/developers/documentation/reporting_and_reconciliation">Reporting Developer Guide</see>
    /// </summary>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="createAdhocReportRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateReportError"/> when the server returns an error response.</exception>
    public Task CreateReport(string? organizationId,
        CreateAdhocReportRequest createAdhocReportRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/reports"),
            [],
            [new Param("organizationId", organizationId)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(createAdhocReportRequest),
            VoidResponse.Instance,
            CreateReportErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Download a report using the reportId value. If you don’t already know this value, you can obtain it using the Retrieve available reports call.
    /// </summary>
    /// <param name="reportId">Valid Report Id</param>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetReportByReportIdError"/> when the server returns an error response.</exception>
    public Task GetReportByReportId(string reportId,
        string? organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/reports/{reportId}"),
            [new TemplateParam("reportId", reportId)],
            [new Param("organizationId", organizationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetReportByReportIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a list of the available reports to which you are subscribed. This will also give you the reportId value, which you can also use to download a report.
    /// </summary>
    /// <param name="startTime">Valid report Start Time in <b>ISO 8601 format</b> Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>  <b>Example date format:</b>   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z)</param>
    /// <param name="endTime">Valid report End Time in <b>ISO 8601 format</b> Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>  <b>Example date format:</b>   - yyyy-MM-dd'T'HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z)</param>
    /// <param name="timeQueryType">Specify time you would like to search  Valid values: - reportTimeFrame - executedTime</param>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="reportMimeType">Valid Report Format  Valid values: - application/xml - text/csv</param>
    /// <param name="reportFrequency">Valid Report Frequency  Valid values: - DAILY - WEEKLY - MONTHLY - USER_DEFINED - ADHOC</param>
    /// <param name="reportName">Valid Report Name</param>
    /// <param name="reportDefinitionId">Valid Report Definition Id</param>
    /// <param name="reportStatus">Valid Report Status  Valid values: - COMPLETED - PENDING - QUEUED - RUNNING - ERROR - NO_DATA</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SearchReportsError"/> when the server returns an error response.</exception>
    public Task SearchReports(DateTimeOffset startTime,
        DateTimeOffset endTime,
        string timeQueryType,
        string? organizationId,
        string? reportMimeType,
        string? reportFrequency,
        string? reportName,
        int? reportDefinitionId,
        string? reportStatus,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/reports"),
            [],
            [new Param("startTime", startTime.ToIso8601()),
                new Param("endTime", endTime.ToIso8601()),
                new Param("timeQueryType", timeQueryType),
                new Param("organizationId", organizationId),
                new Param("reportMimeType", reportMimeType),
                new Param("reportFrequency", reportFrequency),
                new Param("reportName", reportName),
                new Param("reportDefinitionId", reportDefinitionId),
                new Param("reportStatus", reportStatus)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            SearchReportsErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
