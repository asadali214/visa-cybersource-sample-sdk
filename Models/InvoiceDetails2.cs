using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record InvoiceDetails2
{
    /// <summary>
    /// Indicates whether CyberSource sent the Level III information to the processor. The possible values are:
    /// <para>
    /// If your account is not enabled for Level III data or if you did not include the purchasing level field in your
    /// request, CyberSource does not include the Level III data in the request sent to the processor.
    /// </para>
    /// <para>
    /// Possible values:
    /// - <b>Y</b> for true
    /// - <b>N</b> for false
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("level3TransmissionStatus")]
    public string? Level3TransmissionStatus { get; init; }

    /// <summary>
    /// Transaction identifier that is generated. You have the option of printing the sales slip number on the receipt.
    /// This field is supported only on Cybersource through Visanet and JCN gateway.
    /// <para>
    /// Optional field.
    /// </para>
    /// <para>
    /// #### Card Present processing message
    /// If you included this field in the request, the returned value is the value that you sent in the request.
    /// If you did not include this field in the request, the system generated this value for you.
    /// </para>
    /// <para>
    /// The difference between this reply field and the <c>processorInformation.systemTraceAuditNumber</c> field is that the
    /// system generates the system trace audit number (STAN), and you must print the receipt number on the receipt;
    /// whereas you can generate the sales slip number, and you can choose to print the sales slip number on the receipt.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("salesSlipNumber")]
    [Maximum(99999)]
    public int? SalesSlipNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
