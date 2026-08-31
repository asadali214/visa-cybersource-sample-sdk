using System;

namespace CyberSourceMergedSpec.Core.Experimental.VisaHttpSignature;

/// <summary>
/// Temporary Visa/Cybersource HTTP Signature support for POC execution.
/// Kept isolated from the generated auth schemes so it can be removed cleanly.
/// </summary>
public sealed class VisaHttpSignatureConfig
{
    public required string MerchantId { get; init; }
    public required string KeyId { get; init; }
    public required string SecretKey { get; init; }

    /// <summary>Overrides the signing clock. Defaults to <see cref="DateTimeOffset.UtcNow"/>.</summary>
    public Func<DateTimeOffset>? Now { get; init; }
}

public sealed class VisaHttpSignatureConfigurationError : Exception
{
    public VisaHttpSignatureConfigurationError(string message) : base(message) { }
}

public sealed class VisaHttpSignatureRequestError : Exception
{
    public VisaHttpSignatureRequestError(string message) : base(message) { }
}
