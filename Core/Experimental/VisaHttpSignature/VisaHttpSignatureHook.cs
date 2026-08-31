using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CyberSourceMergedSpec.Core.Hooks;

namespace CyberSourceMergedSpec.Core.Experimental.VisaHttpSignature;

/// <summary>
/// Signs outgoing requests with Cybersource's HTTP Signature scheme, ported from the
/// official cybersource-rest-client SignatureParameterGenerator.js / HTTPSigToken.js.
/// Runs as an <see cref="SdkHook"/> so it can be plugged in without touching the
/// generated auth schemes or request builders.
/// </summary>
public sealed class VisaHttpSignatureHook : SdkHook
{
    private static readonly HashSet<HttpMethod> BodySigningMethods =
        [HttpMethod.Post, HttpMethod.Put, new HttpMethod("PATCH")];

    private readonly VisaHttpSignatureConfig _config;

    public VisaHttpSignatureHook(VisaHttpSignatureConfig config) => _config = config;

    public override async ValueTask BeforeRequest(HttpRequestMessage request, HookContext context,
        CancellationToken cancellationToken)
    {
        if (request.RequestUri is null)
            throw new VisaHttpSignatureRequestError("Visa HTTP Signature requires an absolute request URI.");

        var date = (_config.Now?.Invoke() ?? DateTimeOffset.UtcNow).UtcDateTime.ToString("R", CultureInfo.InvariantCulture);
        var hasBody = BodySigningMethods.Contains(request.Method);
        var digest = hasBody
            ? BuildDigestHeader(await SerializeBodyForSigning(request.Content, cancellationToken).ConfigureAwait(false))
            : null;

        var signature = BuildSignature(
            host: request.RequestUri.Authority,
            date: date,
            method: request.Method.Method,
            path: request.RequestUri.PathAndQuery,
            digest: digest,
            merchantId: _config.MerchantId,
            keyId: _config.KeyId,
            secretKeyBase64: _config.SecretKey);

        request.Headers.TryAddWithoutValidation("Date", date);
        request.Headers.TryAddWithoutValidation("v-c-date", date);
        request.Headers.TryAddWithoutValidation("v-c-merchant-id", _config.MerchantId);
        if (digest is not null)
            request.Headers.TryAddWithoutValidation("digest", digest);
        request.Headers.TryAddWithoutValidation("signature", signature);
    }

    private static async Task<string> SerializeBodyForSigning(HttpContent? content, CancellationToken cancellationToken)
    {
        if (content is null)
            return "";

        var mediaType = content.Headers.ContentType?.MediaType;
        if (mediaType is not null && mediaType.IndexOf("json", StringComparison.OrdinalIgnoreCase) < 0)
        {
            throw new VisaHttpSignatureRequestError(
                "Visa HTTP Signature POC only supports JSON or empty request bodies.");
        }

#if NET6_0_OR_GREATER
        return await content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
#else
        return await content.ReadAsStringAsync().ConfigureAwait(false);
#endif
    }

    private static string BuildDigestHeader(string body)
    {
        using var sha256 = SHA256.Create();
        var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(body));
        return $"SHA-256={Convert.ToBase64String(hash)}";
    }

    private static string BuildSignature(string host, string date, string method, string path, string? digest,
        string merchantId, string keyId, string secretKeyBase64)
    {
        var httpMethod = method.ToLowerInvariant();
        var hasBody = digest is not null;
        var validationString =
            $"host: {host}\n" +
            $"date: {date}\n" +
            $"request-target: {httpMethod} {path}\n" +
            (hasBody ? $"digest: {digest}\n" : "") +
            $"v-c-merchant-id: {merchantId}";

        var secretKey = Convert.FromBase64String(secretKeyBase64);
        using var hmac = new HMACSHA256(secretKey);
        var signature = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(validationString)));
        var headerList = hasBody
            ? "host date request-target digest v-c-merchant-id"
            : "host date request-target v-c-merchant-id";

        return $"keyid=\"{keyId}\", algorithm=\"HmacSHA256\", headers=\"{headerList}\", signature=\"{signature}\"";
    }
}
