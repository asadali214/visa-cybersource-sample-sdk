using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Exceptions;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Request;
using CyberSourceMergedSpec.Core.Response;
using CyberSourceMergedSpec.Errors;
using CyberSourceMergedSpec.Models;
using CyberSourceMergedSpec.Models.Enums;

namespace CyberSourceMergedSpec.Api;

public sealed class MerchantDefinedFields
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal MerchantDefinedFields(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Create merchant defined field for a given reference type
    /// </summary>
    /// <param name="referenceType">The reference type for which merchant defined fields are to be fetched. Available values are Invoice, Purchase, Donation</param>
    /// <param name="merchantDefinedFieldDefinitionRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="CreateMerchantDefinedFieldDefinitionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreateMerchantDefinedFieldDefinitionError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<CreateMerchantDefinedFieldDefinitionResponse>> CreateMerchantDefinedFieldDefinition(ReferenceType referenceType,
        MerchantDefinedFieldDefinitionRequest merchantDefinedFieldDefinitionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invoicing/v2/{referenceType}/merchantDefinedFields"),
            [new TemplateParam("referenceType", referenceType)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(merchantDefinedFieldDefinitionRequest),
            JsonResponse.Create<IReadOnlyList<CreateMerchantDefinedFieldDefinitionResponse>>(),
            CreateMerchantDefinedFieldDefinitionErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a MerchantDefinedField by ID
    /// </summary>
    /// <param name="referenceType"></param>
    /// <param name="id"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task DeleteMerchantDefinedFieldsDefinitions(ReferenceType referenceType,
        long id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invoicing/v2/{referenceType}/merchantDefinedFields/{id}"),
            [new TemplateParam("referenceType", referenceType), new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get all merchant defined fields for a given reference type
    /// </summary>
    /// <param name="referenceType">The reference type for which merchant defined fields are to be fetched. Available values are Invoice, Purchase, Donation</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="GetMerchantDefinedFieldsDefinitionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantDefinedFieldsDefinitionsError"/> when the server returns an error response.</exception>
    public Task<IReadOnlyList<GetMerchantDefinedFieldsDefinitionsResponse>> GetMerchantDefinedFieldsDefinitions(ReferenceType referenceType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invoicing/v2/{referenceType}/merchantDefinedFields"),
            [new TemplateParam("referenceType", referenceType)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<GetMerchantDefinedFieldsDefinitionsResponse>>(),
            GetMerchantDefinedFieldsDefinitionsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Update a MerchantDefinedField by ID
    /// </summary>
    /// <param name="referenceType"></param>
    /// <param name="id"></param>
    /// <param name="merchantDefinedFieldCore"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PutMerchantDefinedFieldsDefinitionsError"/> when the server returns an error response.</exception>
    public Task PutMerchantDefinedFieldsDefinitions(ReferenceType referenceType,
        long id,
        MerchantDefinedFieldCore merchantDefinedFieldCore,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/invoicing/v2/{referenceType}/merchantDefinedFields/{id}"),
            [new TemplateParam("referenceType", referenceType), new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(merchantDefinedFieldCore),
            VoidResponse.Instance,
            PutMerchantDefinedFieldsDefinitionsErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
