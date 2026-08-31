using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record Service
{
    /// <summary>
    /// Category code for the ancillary service that is provided. Obtain the codes from the International
    /// Air Transport Association (IATA).
    /// <b>Note</b> <c>#</c> is either 0, 1, 2, or 3.
    /// <b>Important</b> This field is required in the U.S. in order for you to qualify for either the custom
    /// payment service (CPS) or the electronic interchange reimbursement fee (EIRF)program.
    /// Format: English characters only.
    /// Optional request field for ancillary services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categoryCode")]
    [MaxLength(4)]
    public string? CategoryCode { get; init; }

    /// <summary>
    /// Subcategory code for the ancillary service category. Obtain the codes from the International
    /// Air Transport Association (IATA).
    /// <b>Note</b> <c>#</c> is either 0, 1, 2, or 3.
    /// Format  English characters only.
    /// Optional request field for ancillary services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subCategoryCode")]
    [MaxLength(4)]
    public string? SubCategoryCode { get; init; }

    /// <summary>
    /// This field contains the fee amount. This value cannot be negative.
    /// You can include a decimal point (.), but no other special characters.
    /// Format: String, 15 characters maximum.
    /// Optional field for ancillary services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("feeAmount")]
    [MaxLength(15)]
    public string? FeeAmount { get; init; }

    /// <summary>
    /// This field contains the ancillary fee code.
    /// Format: Alphanumeric, 4 characters maximum.
    /// Optional field for ancillary services.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("feeCode")]
    [MaxLength(4)]
    public string? FeeCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
