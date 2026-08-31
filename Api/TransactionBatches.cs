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
/// Get a list of batch files or details of Individual file processed through the Offline Transaction Submission Services.
/// </summary>
public sealed class TransactionBatches
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal TransactionBatches(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Provides real-time detailed status information about the transactions that you previously uploaded in the Business Center or processed with the Offline Transaction File Submission service.
    /// </summary>
    /// <param name="id">The batch id assigned for the template.</param>
    /// <param name="uploadDate">Date in which the original batch file was uploaded. Date must be in ISO-8601 format. Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see> <b>Example date format:</b>  - yyyy-MM-dd</param>
    /// <param name="status">Allows you to filter by rejected response.  Valid values: - Rejected</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTransactionBatchDetailsError"/> when the server returns an error response.</exception>
    public Task GetTransactionBatchDetails(string id,
        DateTimeOffset? uploadDate,
        string? status,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v1/transaction-batch-details/{id}"),
            [new TemplateParam("id", id)],
            [new Param("uploadDate", uploadDate?.ToDate()), new Param("status", status)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetTransactionBatchDetailsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// This API provides details like upload date, completion date, transaction count and accepted and rejected transaction count of the individual batch file using the batch id
    /// </summary>
    /// <param name="id">The batch id assigned for the template.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTransactionBatchIdError"/> when the server returns an error response.</exception>
    public Task GetTransactionBatchId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v1/transaction-batches/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetTransactionBatchIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Provide the date and time search range to get a list of Batch Files ready for settlement
    /// </summary>
    /// <param name="startTime">Valid report Start Time in <b>ISO 8601 format</b> Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>   <b>Example date format:</b>   - yyyy-MM-dd'T'HH:mm:ss.SSSZZ</param>
    /// <param name="endTime">Valid report End Time in <b>ISO 8601 format</b> Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>   <b>Example date format:</b>   - yyyy-MM-dd'T'HH:mm:ss.SSSZZ</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTransactionBatchesError"/> when the server returns an error response.</exception>
    public Task GetTransactionBatches(DateTimeOffset startTime,
        DateTimeOffset endTime,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/pts/v1/transaction-batches"),
            [],
            [new Param("startTime", startTime.ToIso8601()), new Param("endTime", endTime.ToIso8601())],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetTransactionBatchesErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
