using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OF.Core.Domain.CadastroDeclarante;
using OF.Core.Domain.Common;

namespace OF.Core.Mappings.CadastroDeclarante;

public class EventoCadastroDeclaranteMapping : IEntityTypeConfiguration<EventoCadastroDeclarante>
{
    public void Configure(EntityTypeBuilder<EventoCadastroDeclarante> entity)
    {
        entity.HasKey(e => e.Id);

        entity
            .HasOne(e => e.IdentificacaoEvento)
            .WithOne(i => i.EventoCadastroDeclarante)
            .HasForeignKey<IdeEvento>(i => i.EventoCadastroDeclaranteId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
