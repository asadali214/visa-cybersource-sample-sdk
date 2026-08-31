using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ElectronicBenefitsTransfer
{
    /// <summary>
    /// Flag that specifies the category for the EBT transaction.
    /// <para>
    /// Possible values:
    /// - <c>CASH</c>: Cash benefits, which can be used to purchase any item at a participating retailer, as well as to obtain cash-back or make a cash withdrawal from a participating ATM.
    /// - <c>FOOD</c>: Food stamp benefits, which can be used only to purchase food items authorized by the USDA SNAP program.
    /// </para>
    /// <para>
    /// #### PIN debit
    /// Required field for EBT transactions that use PIN debit credit or PIN debit purchase; otherwise, not used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    [MaxLength(4)]
    public string? Category { get; init; }

    /// <summary>
    /// The serial number printed on the EBT voucher.
    /// <para>
    /// #### PIN debit
    /// Required field for EBT voucher transactions that use PIN debit purchase; otherwise, not used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("voucherSerialNumber")]
    [MaxLength(15)]
    public string? VoucherSerialNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
