using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using CyberSourceMergedSpec.Core.Models;

namespace CyberSourceMergedSpec.Models;

public record PersonalIdentification6
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
