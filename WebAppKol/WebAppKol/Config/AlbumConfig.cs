using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppKol.Models;

namespace WebAppKol.Config;

public class AlbumConfig : IEntityTypeConfiguration<Album>
{
    public void Configure(EntityTypeBuilder<Album> builder)
    {
        builder.HasKey(e => e.IdAlbum).HasName("Album_PK");
        builder.Property(e => e.IdAlbum).UseIdentityColumn();

        builder.Property(e => e.NazwaAlbumu).HasMaxLength(50).IsRequired();
        builder.Property(e => e.DataWydania).IsRequired();

        builder.HasOne(e => e.Wytwornia)
            .WithMany(e => e.Albumy)
            .HasForeignKey(e => e.IdWytwornia)
            .HasConstraintName("Album_Wytwornia")
            .OnDelete(DeleteBehavior.Restrict);
    }
}