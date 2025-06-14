using Microsoft.EntityFrameworkCore;
using OF.Core.Domain;
using OF.Data.Mappings;

namespace OF.Data.Context;

public class OFContext : DbContext
{
    public OFContext(DbContextOptions<OFContext> options ) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserMapping());

        base.OnModelCreating(modelBuilder);
    }
}
