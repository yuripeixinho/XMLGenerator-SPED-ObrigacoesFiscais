using OF.Core.Domain.Common;

namespace OF.Core.Domain.CadastroDeclarante;

public class EventoCadastroDeclarante
{
    public Guid Id { get; set; }    
    public required IdeEvento IdentificacaoEvento { get; set; } 
}
