using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record BuyerInformation13
{
    /// <summary>
    /// Company’s tax identifier. This is only used for eCheck service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("companyTaxID")]
    [MaxLength(9)]
    public string? CompanyTaxId { get; init; }

    /// <summary>
    /// Currency used for the order. Use the three-character I<see href="http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf">ISO Standard Currency Codes.</see>
    /// <para>
    /// For an authorization reversal (<c>reversalInformation</c>) or a capture (<c>processingOptions.capture</c> is set to <c>true</c>), you must use the same currency that you used in your payment authorization request.
    /// </para>
    /// <para>
    /// #### DCC for First Data
    /// Your local currency. For details, see the <c>currency</c> field description in <see href="http://apps.cybersource.com/library/documentation/dev_guides/DCC_FirstData_SCMP/DCC_FirstData_SCMP_API.pdf">Dynamic Currency Conversion For First Data Using the SCMP API</see>.
    /// # For details about currency as used in partial authorizations, see "Features for Debit Cards and Prepaid Cards" in the <see href="https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/">Credit Card Services Using the SCMP API Guide</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    [MaxLength(3)]
    public string? Currency { get; init; }

    /// <summary>
    /// Date of birth of the customer. Format: YYYY-MM-DD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfBirth")]
    public DateTimeOffset? DateOfBirth { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalIdentification")]
    public IReadOnlyList<PersonalIdentification9>? PersonalIdentification { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
