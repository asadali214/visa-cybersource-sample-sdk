using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record ProcessorInformationSellerProtection
{
    /// <summary>
    /// The kind of seller protection in force for the transaction. This field is
    /// returned only when the protection eligibility value is set to
    /// ELIGIBLE or PARTIALLY_ELIGIBLE.
    /// Possible values
    /// - ITEM_NOT_RECEIVED_ELIGIBLE: Sellers are protected
    /// against claims for items not received.
    /// - UNAUTHORIZED_PAYMENT_ELIGIBLE: Sellers are
    /// protected against claims for unauthorized payments.
    /// One or both values can be returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// Indicates whether the transaction is eligible for seller protection. The values returned are described below.
    /// Possible values:
    /// - <c>ELIGIBLE</c>
    /// - <c>PARTIALLY_ELIGIBLE</c>
    /// - <c>INELIGIBLE</c>
    /// - <c>NOT_ELIGIBLE</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eligibility")]
    [MaxLength(36)]
    public string? Eligibility { get; init; }

    /// <summary>
    /// An array of conditions that are covered for the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disputeCategories")]
    public IReadOnlyList<string>? DisputeCategories { get; init; }

    /// <summary>
    /// The kind of seller protection in force for the transaction. This field is returned only when the protection_eligibility property is set to ELIGIBLE or PARTIALLY_ELIGIBLE.
    /// Possible values:
    /// - <c>ITEM_NOT_RECEIVED_ELIGIBLE: Sellers are protected against claims for items not received.</c>
    /// - <c>UNAUTHORIZED_PAYMENT_ELIGIBLE: Sellers are protected against claims for unauthorized payments.</c>
    /// One or both values can be returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eligibilityType")]
    [MaxLength(60)]
    public string? EligibilityType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
