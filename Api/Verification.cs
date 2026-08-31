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

public sealed class Verification
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Verification(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// This call checks customer data against specified watch lists to ensure export compliance.
    /// </summary>
    /// <param name="validateExportComplianceRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ValidateExportComplianceError"/> when the server returns an error response.</exception>
    public Task ValidateExportCompliance(ValidateExportComplianceRequest validateExportComplianceRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/risk/v1/export-compliance-inquiries"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(validateExportComplianceRequest),
            VoidResponse.Instance,
            ValidateExportComplianceErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// This call verifies that the customer address submitted is valid.
    /// </summary>
    /// <param name="verifyCustomerAddressRequest"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="VerifyCustomerAddressError"/> when the server returns an error response.</exception>
    public Task VerifyCustomerAddress(VerifyCustomerAddressRequest verifyCustomerAddressRequest,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/risk/v1/address-verifications"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(verifyCustomerAddressRequest),
            VoidResponse.Instance,
            VerifyCustomerAddressErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
