using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;
using CyberSourceMergedSpec.Core.Validation.Attributes;

namespace CyberSourceMergedSpec.Models;

public record InvoiceDetails19
{
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
