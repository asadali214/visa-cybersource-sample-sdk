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
/// Create and manage Recurring Subscriptions.
/// <para>
/// You have option to link subscription to plan or create independent subscriptions.
/// </para>
/// </summary>
public sealed class Subscriptions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Subscriptions(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// # Reactivating a Suspended Subscription
    /// <para>
    /// You can reactivate a suspended subscription for the next billing cycle. You cannot reactivate a canceled or completed subscription.
    /// </para>
    /// <para>
    /// You can specify whether you want to process missed payments for the period during which the subscription was suspended using the <c>processMissedPayments</c> query parameter by setting it to true or false.
    /// If no value is specified, the system will default to <c>true</c>.
    /// </para>
    /// <para>
    /// <b>Important:</b> The "processMissedPayments" query parameter is only effective when the Ask each time before reactivating option is selected in the reactivation settings. If any other option is chosen, the value provided in the request will be ignored by the system. For more information, see the <see href="https://developer.cybersource.com/docs/cybs/en-us/recurring-billing/user/all/rest/recurring-billing-user/recurring-billing-user-about-guide.html">Recurring Billing User Guide</see>.
    /// </para>
    /// <para>
    /// You can check how many payments were missed and the total amount by retrieving the subscription details, where you will find the <c>reactivationInformation</c> object. See: <see href="https://developer.cybersource.com/docs/cybs/en-us/recurring-billing/developer/all/rest/recurring-billing-dev/recur-bill-subscriptions/recur-bill-getting-a-subscription.html">Retrieving a Subscription</see>.
    /// </para>
    /// </summary>
    /// <param name="id">Subscription Id</param>
    /// <param name="processMissedPayments">Indicates if missed payments should be processed from the period when the subscription was suspended. By default, this is set to true. When any option other than "Ask each time before reactivating" is selected in the reactivation settings, the value that you enter will be ignored.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ActivateSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ActivateSubscriptionError"/> when the server returns an error response.</exception>
    public Task<ActivateSubscriptionResponse> ActivateSubscription(string id,
        bool? processMissedPayments = true,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/subscriptions/{id}/activate"),
            [new TemplateParam("id", id)],
            [new Param("processMissedPayments", processMissedPayments)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ActivateSubscriptionResponse>(),
            ActivateSubscriptionErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel a Subscription
    /// </summary>
    /// <param name="id">Subscription Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CancelSubscriptionError"/> when the server returns an error response.</exception>
    public Task<CancelSubscriptionResponse> CancelSubscription(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/subscriptions/{id}/cancel"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CancelSubscriptionResponse>(),
            CancelSubscriptionErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Create a Recurring Billing Subscription
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateSubscriptionError"/> when the server returns an error response.</exception>
    public Task<CreateSubscriptionResponse> CreateSubscription(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/subscriptions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CreateSubscriptionResponse>(),
            CreateSubscriptionErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve Subscriptions by Subscription Code &amp; Subscription Status.
    /// </summary>
    /// <param name="offset">Page offset number.</param>
    /// <param name="limit">Number of items to be returned. Default - <c>20</c>, Max - <c>100</c></param>
    /// <param name="code">Filter by Subscription Code</param>
    /// <param name="status">Filter by Subscription Status</param>
    /// <param name="customerId">Filter by Customer Id</param>
    /// <param name="clientReferenceInformationCode">Filter by Client Reference Information Code / Merchant Reference Number</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetAllSubscriptionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAllSubscriptionsError"/> when the server returns an error response.</exception>
    public Task<GetAllSubscriptionsResponse> GetAllSubscriptions(int? offset,
        int? limit,
        string? code,
        string? status,
        string? customerId,
        string? clientReferenceInformationCode,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/subscriptions"),
            [],
            [new Param("offset", offset),
                new Param("limit", limit),
                new Param("code", code),
                new Param("status", status),
                new Param("customerId", customerId),
                new Param("clientReferenceInformationCode", clientReferenceInformationCode)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetAllSubscriptionsResponse>(),
            GetAllSubscriptionsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get a Subscription by Subscription Id
    /// </summary>
    /// <param name="id">Subscription Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetSubscriptionError"/> when the server returns an error response.</exception>
    public Task<GetSubscriptionResponse> GetSubscription(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/subscriptions/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetSubscriptionResponse>(),
            GetSubscriptionErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get a Unique Subscription Code
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetSubscriptionCodeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetSubscriptionCodeError"/> when the server returns an error response.</exception>
    public Task<GetSubscriptionCodeResponse> GetSubscriptionCode(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/subscriptions/code"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetSubscriptionCodeResponse>(),
            GetSubscriptionCodeErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a list of payments for a specific subscription by its ID.
    /// </summary>
    /// <param name="id">Subscription Id</param>
    /// <param name="offset">Page offset number.</param>
    /// <param name="limit">Number of items to be returned. Default - <c>20</c>, Max - <c>100</c></param>
    /// <param name="scheduledPaymentsCount">Number of existing scheduled payments to be returned. Default - <c>5</c>, Max - <c>9999</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetSubscriptionsPaymentsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubscriptionsIdPaymentsGetError"/> when the server returns an error response.</exception>
    public Task<GetSubscriptionsPaymentsResponse> SubscriptionsIdPaymentsGet(string id,
        int? offset,
        int? limit,
        int? scheduledPaymentsCount,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/subscriptions/{id}/payments"),
            [new TemplateParam("id", id)],
            [new Param("offset", offset),
                new Param("limit", limit),
                new Param("scheduledPaymentsCount", scheduledPaymentsCount)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetSubscriptionsPaymentsResponse>(),
            SubscriptionsIdPaymentsGetErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Modifies the state of a subscription's payments.
    /// Currently, the only possible modifications are "skipping" and "restoring" payments.
    /// Marking a payment as "skipped" means it will not be processed when its scheduled time arrives. "Restoring" a payment removes it from the list of payments to be skipped.
    /// </summary>
    /// <param name="id">Subscription Id</param>
    /// <param name="updatePayments"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetSubscriptionsPaymentsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SubscriptionsIdPaymentsPutError"/> when the server returns an error response.</exception>
    public Task<GetSubscriptionsPaymentsResponse1> SubscriptionsIdPaymentsPut(string id,
        UpdatePayments updatePayments,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/subscriptions/{id}/payments"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(updatePayments),
            JsonResponse.Create<GetSubscriptionsPaymentsResponse1>(),
            SubscriptionsIdPaymentsPutErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Suspend a Subscription
    /// </summary>
    /// <param name="id">Subscription Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SuspendSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SuspendSubscriptionError"/> when the server returns an error response.</exception>
    public Task<SuspendSubscriptionResponse> SuspendSubscription(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/subscriptions/{id}/suspend"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SuspendSubscriptionResponse>(),
            SuspendSubscriptionErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Update a Subscription by Subscription Id
    /// </summary>
    /// <param name="id">Subscription Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateSubscriptionError"/> when the server returns an error response.</exception>
    public Task<UpdateSubscriptionResponse> UpdateSubscription(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/subscriptions/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            JsonResponse.Create<UpdateSubscriptionResponse>(),
            UpdateSubscriptionErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
