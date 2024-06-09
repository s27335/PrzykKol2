﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppKol.Models;

#nullable disable

namespace WebAppKol.Migrations
{
    [DbContext(typeof(KolDbContext))]
    partial class KolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MuzykUtwor", b =>
                {
                    b.Property<int>("MuzycyIdMuzyk")
                        .HasColumnType("int");

                    b.Property<int>("UtworyIdUtwor")
                        .HasColumnType("int");

                    b.HasKey("MuzycyIdMuzyk", "UtworyIdUtwor");

                    b.HasIndex("UtworyIdUtwor");

                    b.ToTable("MuzykUtwor");
                });

            modelBuilder.Entity("WebAppKol.Models.Album", b =>
                {
                    b.Property<int>("IdAlbum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAlbum"));

                    b.Property<DateTime>("DataWydania")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdWytwornia")
                        .HasColumnType("int");

                    b.Property<string>("NazwaAlbumu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdAlbum")
                        .HasName("Album_PK");

                    b.HasIndex("IdWytwornia");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("WebAppKol.Models.Muzyk", b =>
                {
                    b.Property<int>("IdMuzyk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMuzyk"));

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pseudonim")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdMuzyk")
                        .HasName("Muzyk_PK");

                    b.ToTable("Muzyk");
                });

            modelBuilder.Entity("WebAppKol.Models.Utwor", b =>
                {
                    b.Property<int>("IdUtwor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUtwor"));

                    b.Property<decimal>("CzasTrwania")
                        .HasColumnType("decimal(4,2)");

                    b.Property<int>("IdAlbum")
                        .HasColumnType("int");

                    b.Property<string>("NazwaUtworu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdUtwor")
                        .HasName("Utwor_PK");

                    b.HasIndex("IdAlbum");

                    b.ToTable("Utwor");
                });

            modelBuilder.Entity("WebAppKol.Models.Wytwornia", b =>
                {
                    b.Property<int>("IdWytwornia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdWytwornia"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdWytwornia")
                        .HasName("Wytwornia_PK");

                    b.ToTable("Wytwornia");
                });

            modelBuilder.Entity("MuzykUtwor", b =>
                {
                    b.HasOne("WebAppKol.Models.Muzyk", null)
                        .WithMany()
                        .HasForeignKey("MuzycyIdMuzyk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAppKol.Models.Utwor", null)
                        .WithMany()
                        .HasForeignKey("UtworyIdUtwor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAppKol.Models.Album", b =>
                {
                    b.HasOne("WebAppKol.Models.Wytwornia", "Wytwornia")
                        .WithMany("Albumy")
                        .HasForeignKey("IdWytwornia")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Album_Wytwornia");

                    b.Navigation("Wytwornia");
                });

            modelBuilder.Entity("WebAppKol.Models.Utwor", b =>
                {
                    b.HasOne("WebAppKol.Models.Album", "Album")
                        .WithMany("Utwory")
                        .HasForeignKey("IdAlbum")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("Utwor_Album");

                    b.Navigation("Album");
                });

            modelBuilder.Entity("WebAppKol.Models.Album", b =>
                {
                    b.Navigation("Utwory");
                });

            modelBuilder.Entity("WebAppKol.Models.Wytwornia", b =>
                {
                    b.Navigation("Albumy");
                });
#pragma warning restore 612, 618
        }
    }
}
