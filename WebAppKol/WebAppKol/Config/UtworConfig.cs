using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppKol.Models;

namespace WebAppKol.Config;

public class UtworConfig : IEntityTypeConfiguration<Utwor>
{
    public void Configure(EntityTypeBuilder<Utwor> builder)
    {
        builder.HasKey(e => e.IdUtwor).HasName("Utwor_PK");
        builder.Property(e => e.IdUtwor).UseIdentityColumn();

        builder.Property(e => e.NazwaUtworu).HasMaxLength(50).IsRequired();
        builder.Property(e => e.CzasTrwania).HasColumnType("decimal(4,2)").IsRequired();
        builder.HasOne(e => e.Album)
            .WithMany(e => e.Utwory)
            .HasForeignKey(e => e.IdAlbum)
            .HasConstraintName("Utwor_Album")
            .OnDelete(DeleteBehavior.Restrict);
    }
}