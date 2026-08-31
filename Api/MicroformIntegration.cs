using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core;
using CyberSourceMergedSpec.Core.ErrorResponse;
using CyberSourceMergedSpec.Core.Exceptions;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Request;
using CyberSourceMergedSpec.Core.Response;
using CyberSourceMergedSpec.Models;

namespace CyberSourceMergedSpec.Api;

public sealed class MicroformIntegration
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal MicroformIntegration(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// This API is used to generate the Capture Context data structure for the Microform Integration.  Microform is a browser-based acceptance solution that allows a seller to capture payment information is a secure manner from their website.  For more information about Flex Microform transactions, see the <see href="https://developer.cybersource.com/api/developer-guides/dita-flex/SAFlexibleToken.html">Flex Developer Guides Page</see>. For examples on how to integrate Flex Microform within your webpage please see our <see href="https://github.com/CyberSource?q=flex&amp;type=&amp;language=">GitHub Flex Samples</see> This API is a server-to-server API to generate the capture context that can be used to initiate instance of microform on a acceptance page.  The capture context is a digitally signed JWT that provides authentication, one-time keys, and the target origin to the Microform Integration application.  The availability of API features for a merchant may depend on the portfolio configuration and may need to be enabled at the portfolio level before they can be added to merchant accounts.
    /// </summary>
    /// <param name="generateCaptureContextRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task GenerateCaptureContext(GenerateCaptureContextRequest generateCaptureContextRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/microform/v2/sessions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(generateCaptureContextRequest),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
