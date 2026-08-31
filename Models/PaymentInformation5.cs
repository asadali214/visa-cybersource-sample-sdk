using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PaymentInformation5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card4? Card { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank")]
    public Bank2? Bank { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenizedCard")]
    public TokenizedCard? TokenizedCard { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fluidData")]
    public FluidData? FluidData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer")]
    public Customer? Customer { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrument")]
    public PaymentInstrument? PaymentInstrument { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instrumentIdentifier")]
    public InstrumentIdentifier? InstrumentIdentifier { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shippingAddress")]
    public ShippingAddress? ShippingAddress { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legacyToken")]
    public LegacyToken? LegacyToken { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentType")]
    public PaymentType3? PaymentType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eWallet")]
    public EWallet2? EWallet { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentAccountReference")]
    public PaymentAccountReference? PaymentAccountReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thirdPartyToken")]
    public ThirdPartyToken? ThirdPartyToken { get; init; }

    /// <summary>
    /// Mastercard-defined code that indicates how the account information was obtained for credit authorization transactions.
    /// <para>
    /// Possible values:
    /// - <c>00</c>: Card (default)
    /// - <c>01</c>: Mobile network operator (MNO) controlled removable secure element (SIM or UICC) personalized for use with a mobile phone or smartphone
    /// - <c>02</c>: Key fob
    /// - <c>03</c>: Watch
    /// - <c>04</c>: Mobile tag
    /// - <c>05</c>: Wristband
    /// - <c>06</c>: Mobile phone case or sleeve
    /// - <c>07</c>: Mobile phone or smartphone with fixed (nonremovable) secure element controlled by the MNO (for example, code division multiple access (CDMA))
    /// - <c>08</c>: Removable secure element not controlled by the MNO (for example, memory card personalized for use with a mobile phone or smartphone)
    /// - <c>09</c>: Mobile phone or smartphone with a fixed (nonremovable) secure element not controlled by the MNO
    /// - <c>10</c>: MNO-controlled removable secure element (SIM or UICC) personalized for use with a tablet or e-book
    /// - <c>11</c>: Tablet or e-book with a fixed (nonremovable) secure element controlled by the MNO
    /// - <c>12</c>: Removable secure element not controlled by the MNO (for example, memory card personalized for use with a tablet or e-book)
    /// - <c>13</c>: Tablet or e-book with fixed (nonremovable) secure element not controlled by the MNO
    /// - <c>14</c> - <c>99</c>: Reserved for future use
    /// </para>
    /// <para>
    /// This field flows in ISO Field 104 DSID 65 Tag 04.
    /// </para>
    /// <para>
    /// This field is supported for Mastercard credit authorization transactions.
    /// </para>
    /// <para>
    /// #### Used by
    /// <b>Credit Authorization (Standalone)</b>
    /// Optional field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initiationChannel")]
    [MaxLength(2)]
    public string? InitiationChannel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
