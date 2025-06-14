namespace OF.Core.Domain.CadastroDeclarante;

public class IdeDeclarante
{
    public Guid Id { get; set; } = Guid.NewGuid(); // ser criado pelo padrão da eFinanceira
    public required string CNPJDeclarante { get; set; }
    public string? GIIN { get; set; }  //Preencher com o GIIN (Global Intermediary Identification Number) da Entidade Declarante. O número GIIN da entidade declarante deve ser preenchido, nos termos do acordo do FATCA, conforme as regras de formação descritas no sítio (http://www.irs.gov/PUP/businestes/corporations/giin_composition.pdf), incluindo os pontos(.) como separadores.
    public string? CategoriaDeclarante { get; set; }  // Preencher obrigatoriamente com o código correspondente na tabela “Categorias de Declarante”, vigente na data de recepção do evento. No caso de Instituições Financeiras Brasileiras Informantes, a Categoria de declarante é o FATCA602, pois o Brasil é uma Autoridade Tributária com o IGA Modelo 1 e envia as informações sobre as contas mantidas elas Instituições Brasileiras. Regra de validação: REGRA_EXISTE_CATEGORIA_DECLARANTE
    public NIF? NIF { get; set; }  // Informações de Identificação Fiscal no Exterior da Entidade Declarante Regra de validação: REGRA_VALIDA_CHAVE
    public required PaisResid PaisResid { get; set; } // Preencher com o país de residência fiscal da entidade declarante. O campo deve ser utilizado na e-Financeira independentemente de a condição da entidade declarante prestar informações no escopo do CRS ou FATCA, indicando-se o código “BR”, e outra residência fiscal se houver. Regra de validação: REGRA_VALIDA_CHAVE
    public required string Nome { get; set; } // Preencher com a razão social da Entidade Declarante, nome empresarial ou denominação da entidade declarante, em formato livre, sendo vedado o uso de caracteres especiais.Deve ser usado o nome idêntico ao que consta no Cadastro CNPJ.
    public required string EnderecoLivre { get; set; }
    public required string Municipio { get; set; }
    public required string UF { get; set; }
    public required string CEP { get; set; }
    public required string Pais { get; set; }

}

public class PaisResid
{
    public required string Pais { get; set; } // Preencher com o código do país de residência fiscal da entidade declarante, de acordo com a Tabela de Países vigente na data de recepção do evento. Regra de validação: REGRA_EXISTE_PAIS
}

public class NIF
{
    public int Id { get; set; } // Chave primária local, se for usar EF
    public Guid DeclaranteId { get; set; }
    public IdeDeclarante Declarante { get; set; } = null!;
    public string? NumeroNIF { get; set; } // Se houver, preencher com o Número de Identificação Fiscal no Exterior da Entidade Declarante, utilizado pelo(s) país(es) para o qual(is) o declarante tenha informações a serem transmitidas no escopo do CRS.
    public string? PaisEmissao { get; set; } // Preencher com o país de emissão do NIF, valor da Tabela de Países ISO-3166-1 alfa 2 vigente na data de recepção do evento. Tabela Países Regra de validação: REGRA_EXISTE_PAIS
    public string? TpNIF { get; set; } // Preencher com uma sigla de compreensão do país receptor da informação, ou genericamente a sigla “TIN” (tax identification number). É um campo de texto livre.\
}