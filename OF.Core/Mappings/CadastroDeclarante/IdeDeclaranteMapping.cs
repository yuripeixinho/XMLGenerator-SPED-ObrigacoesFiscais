using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OF.Core.Domain.CadastroDeclarante;

namespace OF.Core.Mappings.CadastroDeclarante;

public class IdeDeclaranteMapping : IEntityTypeConfiguration<IdeDeclarante>
{
    public void Configure(EntityTypeBuilder<IdeDeclarante> entity)
    {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.CNPJDeclarante).IsRequired().HasMaxLength(14).IsUnicode(false);
        entity.Property(e => e.GIIN).HasMaxLength(19);
        entity.Property(e => e.CategoriaDeclarante).HasMaxLength(8);
        entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);

        entity.HasOne(e => e.NIF)
            .WithOne(n => n.Declarante)
            .HasForeignKey<NIF>(n => n.DeclaranteId);
    }
}
