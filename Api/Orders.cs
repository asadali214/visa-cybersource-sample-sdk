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
/// An order is a service that is used for initiating a transaction with itemized details, shipping, billing and buyer information.
/// </summary>
public sealed class Orders
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Orders(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// A create order request enables you to send the itemized details along with the order. This API can be used by merchants initiating their transactions with the create order API.
    /// </summary>
    /// <param name="createOrderRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateOrderError"/> when the server returns an error response.</exception>
    public Task CreateOrder(CreateOrderRequest createOrderRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/intents"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(createOrderRequest),
            VoidResponse.Instance,
            CreateOrderErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// This API can be used in two flavours - for updating the order as well as saving the order.
    /// </summary>
    /// <param name="id">The ID returned from the original create order response.</param>
    /// <param name="updateOrderRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpdateOrderError"/> when the server returns an error response.</exception>
    public Task UpdateOrder(string id,
        UpdateOrderRequest updateOrderRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v2/intents/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(updateOrderRequest),
            VoidResponse.Instance,
            UpdateOrderErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
