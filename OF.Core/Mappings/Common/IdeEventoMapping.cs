using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OF.Core.Domain.Common;

namespace OF.Core.Mappings.Common;

public class IdeEventoMapping : IEntityTypeConfiguration<IdeEvento>
{
    public void Configure(EntityTypeBuilder<IdeEvento> entity)
    {
        entity.HasKey(e => e.Id);

        entity
            .Property(e => e.IndicativoRetificacao)
            .IsRequired()
            .HasConversion<byte>();

        entity
            .Property(e => e.NumeroRecibo)
            .HasMaxLength(50);

        entity
            .Property(e => e.TipoAmbiente)
            .IsRequired()
            .HasConversion<byte>();

        entity
            .Property(e => e.AplicativoEmissor)
            .IsRequired()
            .HasConversion<byte>();

        entity
            .Property(e => e.VersaoAplicativo)
            .IsRequired()
            .HasMaxLength(20);
    }
}
