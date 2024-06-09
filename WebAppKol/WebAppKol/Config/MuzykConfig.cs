using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppKol.Models;

namespace WebAppKol.Config;

public class MuzykConfig : IEntityTypeConfiguration<Muzyk>
{
    public void Configure(EntityTypeBuilder<Muzyk> builder)
    {
        builder.HasKey(e => e.IdMuzyk).HasName("Muzyk_PK");
        builder.Property(e => e.IdMuzyk).UseIdentityColumn();
        builder.Property(e => e.Imie).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Nazwisko).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Pseudonim).HasMaxLength(50).IsRequired();
    }
}