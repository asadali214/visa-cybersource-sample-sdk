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
/// API to download report DTDs
/// </summary>
public sealed class DownloadDtd
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal DownloadDtd(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Used to download DTDs for reports on no-auth.
    /// </summary>
    /// <param name="reportDefinitionNameVersion">Name and version of DTD file to download. Some DTDs only have one version. In that case version name is not needed. Some example values are ctdr-1.0, tdr, pbdr-1.1</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDtdv2Error"/> when the server returns an error response.</exception>
    public Task GetDtdv2(string reportDefinitionNameVersion,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/dtds/{reportDefinitionNameVersion}"),
            [new TemplateParam("reportDefinitionNameVersion", reportDefinitionNameVersion)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetDtdv2ErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
