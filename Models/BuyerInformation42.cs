using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BuyerInformation42
{
    /// <summary>
    /// Customer's VAT registration number for the individual sender tax identification.
    /// This field flows in ISO field 104, DSID 63 tag 06.
    /// <para>
    /// Visa is recommending the use of the following business application identifier (BAI) values
    /// and merchant category code (MCC) combinations to process domestic bill payments, toll payments,
    /// and business-to-business funding transactions as AFTs in Brazil:
    /// - BB (Business-to-business)
    /// - BP (Non-card bill payment)
    /// - FT (Funds transfer)
    /// - WT (Wallet transfer)
    /// </para>
    /// <para>
    /// MCC: 4784
    /// </para>
    /// <para>
    /// #### Mapping
    /// - SCMP API Field: purchaser_vat_registration_number
    /// - Simple Order API Field: invoiceHeader_purchaserVATRegistrationNumber
    /// - CCS: customer.vatRegistrationNumber
    /// </para>
    /// <para>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vatRegistrationNumber")]
    [MaxLength(13)]
    public string? VatRegistrationNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
