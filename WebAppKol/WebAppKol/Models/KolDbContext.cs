using Microsoft.EntityFrameworkCore;

namespace WebAppKol.Models;


public class KolDbContext : DbContext
{

    public KolDbContext()
    {

    }


    public KolDbContext(DbContextOptions<KolDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(KolDbContext).Assembly);
    }
}
