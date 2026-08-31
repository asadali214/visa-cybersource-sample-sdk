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
/// Create and manage Plans for subscriptions.
/// </summary>
public sealed class Plans
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Plans(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Activate a Plan
    /// </summary>
    /// <param name="id">Plan Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ActivateDeactivatePlanResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ActivatePlanError"/> when the server returns an error response.</exception>
    public Task<ActivateDeactivatePlanResponse> ActivatePlan(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/plans/{id}/activate"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ActivateDeactivatePlanResponse>(),
            ActivatePlanErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// The recurring billing service enables you to manage payment plans and subscriptions for recurring payment schedules. It securely stores your customer's payment information and personal data within secure Visa data centers, reducing storage risks and PCI DSS scope through the use of *Token Management* (*TMS*).
    /// <para>
    /// The three key elements of *Cybersource* Recurring Billing are:
    /// </para>
    /// <para>
    /// -  <b>Token</b>: stores customer billing, shipping, and payment details.
    /// </para>
    /// <para>
    /// -  <b>Plan</b>: stores the billing schedule.
    /// </para>
    /// <para>
    /// -  <b>Subscription</b>: combines the token and plan, and defines the subscription start date, name, and description.
    /// </para>
    /// <para>
    /// The APIs in this section demonstrate the management of the Plans and Subscriptions. For Tokens please refer to <see href="#token-management">Token Management</see>
    /// The availability of API features for a merchant can depend on the portfolio configuration and may need to be enabled at the portfolio level before they can be added to merchant accounts.
    /// </para>
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreatePlanResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreatePlanError"/> when the server returns an error response.</exception>
    public Task<CreatePlanResponse> CreatePlan(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/plans"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CreatePlanResponse>(),
            CreatePlanErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Deactivate a Plan
    /// </summary>
    /// <param name="id">Plan Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ActivateDeactivatePlanResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeactivatePlanError"/> when the server returns an error response.</exception>
    public Task<ActivateDeactivatePlanResponse> DeactivatePlan(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/plans/{id}/deactivate"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ActivateDeactivatePlanResponse>(),
            DeactivatePlanErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a Plan is only allowed:
    /// - plan status is in <c>DRAFT</c>
    /// - plan status is in <c>ACTIVE</c>, and <c>INACTIVE</c> only allowed when no subscriptions attached to a plan in the lifetime of a plan
    /// </summary>
    /// <param name="id">Plan Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeletePlanResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeletePlanError"/> when the server returns an error response.</exception>
    public Task<DeletePlanResponse> DeletePlan(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/plans/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeletePlanResponse>(),
            DeletePlanErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a Plan details by Plan Id.
    /// </summary>
    /// <param name="id">Plan Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPlanResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPlanError"/> when the server returns an error response.</exception>
    public Task<GetPlanResponse> GetPlan(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/plans/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetPlanResponse>(),
            GetPlanErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get a Unique Plan Code
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPlanCodeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPlanCodeError"/> when the server returns an error response.</exception>
    public Task<GetPlanCodeResponse> GetPlanCode(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/plans/code"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetPlanCodeResponse>(),
            GetPlanCodeErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve Plans by Plan Code &amp; Plan Status.
    /// </summary>
    /// <param name="offset">Page offset number.</param>
    /// <param name="limit">Number of items to be returned. Default - <c>20</c>, Max - <c>100</c></param>
    /// <param name="code">Filter by Plan Code</param>
    /// <param name="status">Filter by Plan Status</param>
    /// <param name="name">Filter by Plan Name. (First sub string or full string) <b>[Not Recommended]</b></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetAllPlansResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPlansError"/> when the server returns an error response.</exception>
    public Task<GetAllPlansResponse> GetPlans(int? offset,
        int? limit,
        string? code,
        string? status,
        string? name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/plans"),
            [],
            [new Param("offset", offset),
                new Param("limit", limit),
                new Param("code", code),
                new Param("status", status),
                new Param("name", name)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetAllPlansResponse>(),
            GetPlansErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Update a Plan
    /// <para>
    /// Plan in <c>DRAFT</c> status
    /// - All updates are allowed on Plan with <c>DRAFT</c> status
    /// </para>
    /// <para>
    /// Plan in <c>ACTIVE</c> status [Following fields are <b>Not Updatable</b>]
    /// - <c>planInformation.billingPeriod</c>
    /// - <c>planInformation.billingCycles</c> [Update is only allowed to <b>increase</b> billingCycles]
    /// - <c>orderInformation.amountDetails.currency</c>
    /// </para>
    /// </summary>
    /// <param name="id">Plan Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdatePlanResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdatePlanError"/> when the server returns an error response.</exception>
    public Task<UpdatePlanResponse> UpdatePlan(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/plans/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            JsonResponse.Create<UpdatePlanResponse>(),
            UpdatePlanErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
