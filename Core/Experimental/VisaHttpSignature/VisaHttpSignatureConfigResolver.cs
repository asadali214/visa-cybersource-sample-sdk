using System;
using System.Collections.Generic;
using System.Linq;

namespace CyberSourceMergedSpec.Core.Experimental.VisaHttpSignature;

/// <summary>
/// Resolves optional Visa HTTP Signature configuration from process environment variables.
/// Opt-in and disabled by default so it never affects the standard auth schemes.
/// </summary>
public static class VisaHttpSignatureConfigResolver
{
    private const string EnabledEnv = "APIMATIC_EXPERIMENTAL_VISA_HTTP_SIGNATURE";
    private const string MerchantIdEnv = "VISA_MERCHANT_ID";
    private const string KeyIdEnv = "VISA_KEY_ID";
    private const string SecretKeyEnv = "VISA_SECRET_KEY";

    public static VisaHttpSignatureConfig? Resolve()
    {
        if (Environment.GetEnvironmentVariable(EnabledEnv) != "true")
            return null;

        var values = new Dictionary<string, string?>
        {
            [MerchantIdEnv] = Environment.GetEnvironmentVariable(MerchantIdEnv),
            [KeyIdEnv] = Environment.GetEnvironmentVariable(KeyIdEnv),
            [SecretKeyEnv] = Environment.GetEnvironmentVariable(SecretKeyEnv),
        };

        var missing = values
            .Where(pair => string.IsNullOrWhiteSpace(pair.Value))
            .Select(pair => pair.Key)
            .ToArray();

        if (missing.Length > 0)
        {
            throw new VisaHttpSignatureConfigurationError(
                $"Visa HTTP Signature is enabled, but required environment variable(s) are missing: {string.Join(", ", missing)}.");
        }

        return new VisaHttpSignatureConfig
        {
            MerchantId = values[MerchantIdEnv]!,
            KeyId = values[KeyIdEnv]!,
            SecretKey = values[SecretKeyEnv]!,
        };
    }
}
