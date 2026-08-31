using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record MerchantInformation1
{
    /// <summary>
    /// Use this field only if you are requesting payment with Payer Authentication serice together.
    /// <para>
    /// Your company’s name as you want it to appear to the customer in the issuing bank’s authentication form.
    /// This value overrides the value specified by your merchant bank.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantName")]
    [MaxLength(25)]
    public string? MerchantName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDescriptor")]
    public MerchantDescriptor1? MerchantDescriptor { get; init; }

    /// <summary>
    /// The value for this field is a four-digit number that the payment card industry uses to classify
    /// merchants into market segments. A payment card company assigned one or more of these values to your business when you started
    /// accepting the payment card company's cards. When you do not include this field in your request, Cybersource uses the value in your
    /// Cybersource account. Use this field only for clearing with your acquirer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categoryCode")]
    [MaxLength(4)]
    public string? CategoryCode { get; init; }

    /// <summary>
    /// URL for displaying payment results to the consumer (notifications) after the transaction is processed. Usually this URL belongs to merchant and its behavior is defined by merchant
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnUrl")]
    [StringLength(255, MinimumLength = 7)]
    public string? ReturnUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
