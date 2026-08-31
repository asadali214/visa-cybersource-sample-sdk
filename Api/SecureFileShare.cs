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

public sealed class SecureFileShare
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal SecureFileShare(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Download a file for the given file identifier
    /// </summary>
    /// <param name="fileId">Unique identifier for each file</param>
    /// <param name="organizationId">Valid Cybersource Organization Id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFileError"/> when the server returns an error response.</exception>
    public Task GetFile(string fileId,
        string? organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sfs/v1/files/{fileId}"),
            [new TemplateParam("fileId", fileId)],
            [new Param("organizationId", organizationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetFileErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get list of files and it's information of them available inside the report directory
    /// </summary>
    /// <param name="startDate">Valid start date in <b>ISO 8601 format</b> Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>   <b>Example date format:</b>   - yyyy-MM-dd</param>
    /// <param name="endDate">Valid end date in <b>ISO 8601 format</b> Please refer the following link to know more about ISO 8601 format.<see href="https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14">Rfc Date Format</see>   <b>Example date format:</b>   - yyyy-MM-dd</param>
    /// <param name="organizationId">Valid Cybersource Organization Id</param>
    /// <param name="name"><b>Tailored to searches for specific files with in given Date range</b> example : MyTransactionDetailreport.xml</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetFileDetailError"/> when the server returns an error response.</exception>
    public Task GetFileDetail(DateTimeOffset startDate,
        DateTimeOffset endDate,
        string? organizationId,
        string? name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sfs/v1/file-details"),
            [],
            [new Param("startDate", startDate.ToDate()),
                new Param("endDate", endDate.ToDate()),
                new Param("organizationId", organizationId),
                new Param("name", name)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetFileDetailErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
