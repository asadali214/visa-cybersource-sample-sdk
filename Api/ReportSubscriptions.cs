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
/// API for creation and retrieval of Report Subscriptions
/// </summary>
public sealed class ReportSubscriptions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal ReportSubscriptions(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Create or update an already existing classic or standard subscription.
    /// </summary>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="predefinedSubscriptionRequestBean"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateStandardOrClassicSubscriptionError"/> when the server returns an error response.</exception>
    public Task CreateStandardOrClassicSubscription(string? organizationId,
        PredefinedSubscriptionRequestBean predefinedSubscriptionRequestBean,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/predefined-report-subscriptions"),
            [],
            [new Param("organizationId", organizationId)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(predefinedSubscriptionRequestBean),
            VoidResponse.Instance,
            CreateStandardOrClassicSubscriptionErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Create a report subscription for your organization. The report name must be unique.
    /// </summary>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="createReportSubscriptionRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateSubscription2Error"/> when the server returns an error response.</exception>
    public Task CreateSubscription2(string? organizationId,
        CreateReportSubscriptionRequest createReportSubscriptionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/report-subscriptions"),
            [],
            [new Param("organizationId", organizationId)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(createReportSubscriptionRequest),
            VoidResponse.Instance,
            CreateSubscription2ErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a report subscription for your organization. You must know the unique name of the report you want to delete.
    /// </summary>
    /// <param name="reportName">Name of the Report to Delete</param>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteSubscriptionError"/> when the server returns an error response.</exception>
    public Task DeleteSubscription(string reportName,
        string? organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/report-subscriptions/{reportName}"),
            [new TemplateParam("reportName", reportName)],
            [new Param("organizationId", organizationId)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteSubscriptionErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// View a summary of all report subscriptions.
    /// </summary>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAllSubscriptions2Error"/> when the server returns an error response.</exception>
    public Task GetAllSubscriptions2(string? organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/report-subscriptions"),
            [],
            [new Param("organizationId", organizationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetAllSubscriptions2ErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// View the details of a report subscription, such as the report format or report frequency, using the report’s unique name.
    /// </summary>
    /// <param name="reportName">Name of the Report to Retrieve</param>
    /// <param name="organizationId">Valid Organization Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetSubscription2Error"/> when the server returns an error response.</exception>
    public Task GetSubscription2(string reportName,
        string? organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/report-subscriptions/{reportName}"),
            [new TemplateParam("reportName", reportName)],
            [new Param("organizationId", organizationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetSubscription2ErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
