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
/// Create a Follow-On Subscription from an already existing successful Transaction.
/// <para>
/// You have option to link subscription to plan or create independent subscriptions.
/// </para>
/// </summary>
public sealed class SubscriptionsFollowOns
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal SubscriptionsFollowOns(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Create a new Subscription based on the Request Id of an existing successful Transaction.
    /// </summary>
    /// <param name="requestId">Request Id of an existing successful Transaction</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateFollowOnSubscriptionError"/> when the server returns an error response.</exception>
    public Task<CreateSubscriptionResponse> CreateFollowOnSubscription(string requestId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/subscriptions/follow-ons/{requestId}"),
            [new TemplateParam("requestId", requestId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CreateSubscriptionResponse>(),
            CreateFollowOnSubscriptionErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get details of the Subscription being created based on the Request Id of an existing successful Transaction.
    /// </summary>
    /// <param name="requestId">Request Id of an existing successful Transaction</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetSubscriptionResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFollowOnSubscriptionError"/> when the server returns an error response.</exception>
    public Task<GetSubscriptionResponse1> GetFollowOnSubscription(string requestId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/rbs/v1/subscriptions/follow-ons/{requestId}"),
            [new TemplateParam("requestId", requestId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetSubscriptionResponse1>(),
            GetFollowOnSubscriptionErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
