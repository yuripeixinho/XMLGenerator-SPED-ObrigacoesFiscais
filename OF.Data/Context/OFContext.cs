using Microsoft.EntityFrameworkCore;
using OF.Core.Domain.CadastroDeclarante;
using OF.Core.Domain.Common;
using OF.Core.Mappings.CadastroDeclarante;
using OF.Core.Mappings.Common;

namespace OF.Data.Context;

public class OFContext : DbContext
{
    public OFContext(DbContextOptions<OFContext> options ) : base(options)
    {

    }

    public DbSet<EventoCadastroDeclarante> EventoCadastroDeclarante { get; set; }
    public DbSet<IdeEvento> IdeEvento { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EventoCadastroDeclaranteMapping());
        modelBuilder.ApplyConfiguration(new IdeEventoMapping());


        base.OnModelCreating(modelBuilder);
    }
}
