using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PersonalIdentification
{
    /// <summary>
    /// The type of the identification.
    /// <para>
    /// Possible values:
    ///   - <c>NATIONAL</c>
    ///   - <c>CPF</c>
    ///   - <c>CPNJ</c>
    ///   - <c>CURP</c>
    ///   - <c>SSN</c>
    ///   - <c>DRIVER_LICENSE</c>
    ///   - <c>PASSPORT_NUMBER</c>
    ///   - <c>PERSONAL_ID</c>
    ///   - <c>TAX_ID</c>
    ///   -	<c>BR_CPF</c>     The individual tax ID type, typically is 11 characters long
    ///   -	<c>BR_CNPJ</c>    The business tax ID type, typically is 14 characters long.
    /// </para>
    /// <para>
    /// This field is supported only on the following processors.
    /// </para>
    /// <para>
    /// #### ComercioLatino
    /// Set this field to the Cadastro de Pessoas Fisicas (CPF).
    /// </para>
    /// <para>
    /// #### CyberSource Latin American Processing
    /// Supported for Redecard in Brazil. Set this field to the Cadastro de Pessoas Fisicas (CPF), which is required for AVS for Redecard in Brazil.
    /// <b>Note</b> CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America. The information in this field description is for the specific processing connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The value of the identification type. This field is supported only on the following processors.
    /// <para>
    /// #### ComercioLatino
    /// Set this field to the Cadastro de Pessoas Fisicas (CPF).
    /// </para>
    /// <para>
    /// #### CyberSource Latin American Processing
    /// Supported for Redecard in Brazil. Set this field to the Cadastro de Pessoas Fisicas (CPF), which is required for AVS for Redecard in Brazil.
    /// <b>Note</b> CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America. The information in this field description is for the specific processing connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.
    /// If <c>type = PASSPORT</c>, this is the cardholder's passport number.
    /// Recommended for Discover ProtectBuy.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(26)]
    public string? Id { get; init; }

    /// <summary>
    /// The government agency that issued the driver's license or passport.
    /// <para>
    /// If <b>type</b><c> = DRIVER_LICENSE</c>, this is the State or province where the customer’s driver’s license was issued.
    /// </para>
    /// <para>
    /// If <b>type</b><c> = PASSPORT</c>, this is the Issuing country for the cardholder’s passport. Recommended for Discover ProtectBuy.
    /// </para>
    /// <para>
    /// Use the two-character <see href="https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf">State, Province, and Territory Codes for the United States and Canada</see>.
    /// </para>
    /// <para>
    /// #### TeleCheck
    /// Contact your TeleCheck representative to find out whether this field is required or optional.
    /// </para>
    /// <para>
    /// #### All Other Processors
    /// Not used.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuedBy")]
    public string? IssuedBy { get; init; }

    /// <summary>
    /// Verification results received from Issuer or Card Network for verification transactions. Response Only Field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationResults")]
    public string? VerificationResults { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
