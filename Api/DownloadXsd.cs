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
/// API to download report XSDs
/// </summary>
public sealed class DownloadXsd
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal DownloadXsd(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Used to download XSDs for reports on no-auth.
    /// </summary>
    /// <param name="reportDefinitionNameVersion">Name and version of XSD file to download. Some XSDs only have one version. In that case version name is not needed. Some example values are DecisionManagerDetailReport, DecisionManagerTypes</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetXsdv2Error"/> when the server returns an error response.</exception>
    public Task GetXsdv2(string reportDefinitionNameVersion,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reporting/v3/xsds/{reportDefinitionNameVersion}"),
            [new TemplateParam("reportDefinitionNameVersion", reportDefinitionNameVersion)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            GetXsdv2ErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
