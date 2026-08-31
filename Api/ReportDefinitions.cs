using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core;
using CyberSourceMergedSpec.Core.Exceptions;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Request;
using CyberSourceMergedSpec.Core.Response;
using CyberSourceMergedSpec.Errors;

namespace CyberSourceMergedSpec.Api;

/// <summary>
/// Get report definition information
/// </summary>
public sealed class ReportDefinitions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal ReportDefinitions(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// View the attributes of an individual report type. For a list of values for reportDefinitionName, see the <see href="https://www.cybersource.com/developers/documentation/reporting_and_reconciliation/">Reporting Developer Guide</see>
    /// </summary>
    /// <param name="reportDefinitionName">Name of the Report definition to retrieve</param>
    /// <param name="subscriptionType">The subscription type for which report definition is required. By default the type will be CUSTOM. Valid Values: - CLASSIC - CUSTOM - STANDARD</param>
    /// <param name="reportMimeType">The format for which the report definition is required. By default the value will be CSV. Valid Values: - application/xml - text/csv</param>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetResourceInfoByReportDefinitionError"/> when the server returns an error response.</exception>
    public Task GetResourceInfoByReportDefinition(string reportDefinitionName,
        string? subscriptionType,
        string? reportMimeType,
        string? organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/report-definitions/{reportDefinitionName}"),
            [new TemplateParam("reportDefinitionName", reportDefinitionName)],
            [new Param("subscriptionType", subscriptionType),
                new Param("reportMimeType", reportMimeType),
                new Param("organizationId", organizationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetResourceInfoByReportDefinitionErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// View a list of supported reports and their attributes before subscribing to them.
    /// </summary>
    /// <param name="subscriptionType">Valid Values: - CLASSIC - CUSTOM - STANDARD</param>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetResourceV2InfoError"/> when the server returns an error response.</exception>
    public Task GetResourceV2Info(string? subscriptionType,
        string? organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/report-definitions"),
            [],
            [new Param("subscriptionType", subscriptionType), new Param("organizationId", organizationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetResourceV2InfoErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
