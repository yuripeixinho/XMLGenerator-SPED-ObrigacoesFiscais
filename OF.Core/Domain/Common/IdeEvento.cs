using OF.Core.Domain.CadastroDeclarante;
using OF.Core.Enums;

namespace OF.Core.Domain.Common;

public class IdeEvento
{
    public int Id { get; set; }  
    public required EventoCadastroDeclarante EventoCadastroDeclarante { get; set; }
    public required Guid EventoCadastroDeclaranteId { get; set; }
    public required IndicativoRetificacaoEnum IndicativoRetificacao { get; set; } //  ste campo identifica se o arquivo a ser transmitido é original ou retificador de um outro arquivo válido enviado anteriormente.Valores válidos: 1 - para arquivo original 5 2 - para arquivo de retificação espontânea 3 - para arquivo de retificação a pedido
    public required string NumeroRecibo { get; set; } // Preencher com o número do recibo do arquivo a ser retificado. Só deve ser preenchido quando o arquivo a ser transmitido é um evento retificador de um outro evento válido do mesmo tipo enviado anteriormente. O valor a ser inserido deve corresponder ao número do recibo de entrega do arquivo enviado anteriormente que está sendo retificado. Regra de validação: REGRA_OBRIGATORIO_NR_ULTIMO_RECIBO REGRA_VALIDA_NR_RECIBO
    public required string TipoAmbiente { get; set; } // Informar a identificação do ambiente para o qual os dados estão sendo transmitidos. Valores válidos: 1=Produção; 2=Homologação Estes ambientes possuem endereços (URL) distintos. Regra de validação: REGRA_VALIDA_TIPO_AMBIENTE
    public required string AplicativoEmissor { get; set; } // Informar o emissor do aplicativo de emissão do evento Valores válidos: 1=Emissão com aplicativo da empresa; 2=Outros 6 Este campo possibilita o controle, pela própria declarante, sobre qual aplicativo foi utilizado para gerar o arquivo (por exemplo, em eventuais situações de contingência em que a declarante precisou utilizar aplicativos geradores providos por terceiros).
    public required string VersaoAplicativo { get; set; } // Preencher com a versão do aplicativo de emissão do evento. Este campo se destina a permitir um controle, pela própria declarante, da versão do aplicativo que foi utilizado para gerar o arquivo.
}
