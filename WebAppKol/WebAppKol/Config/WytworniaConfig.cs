using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppKol.Models;

namespace WebAppKol.Config;

public class WytworniaConfig : IEntityTypeConfiguration<Wytwornia>
{
    public void Configure(EntityTypeBuilder<Wytwornia> builder)
    {
        builder.HasKey(e => e.IdWytwornia).HasName("Wytwornia_PK");
        builder.Property(e => e.IdWytwornia).UseIdentityColumn();

        builder.Property(e => e.Nazwa).HasMaxLength(50).IsRequired();
    }
}