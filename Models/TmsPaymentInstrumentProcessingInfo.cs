using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record TmsPaymentInstrumentProcessingInfo
{
    /// <summary>
    /// Flag that indicates that this is a payment for a bill or for an existing contractual loan.
    /// Possible Values:
    /// - <c>true</c>: Bill payment or loan payment.
    /// - <c>false</c> (default): Not a bill payment or loan payment.
    /// # For processor-specific details, see the <c>bill_payment</c> field description in <see href="https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/">Credit Card Services Using the SCMP API.</see>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billPaymentProgramEnabled")]
    public bool? BillPaymentProgramEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankTransferOptions")]
    public BankTransferOptions4? BankTransferOptions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
