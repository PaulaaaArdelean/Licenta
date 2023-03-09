﻿// <auto-generated />
using System;
using Licenta.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Licenta.Migrations
{
    [DbContext(typeof(LicentaContext))]
    [Migration("20230308130617_tipuriC")]
    partial class tipuriC
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Licenta.Models.TipCombustibil", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("TipulCombustibil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipCombustibil");
                });

            modelBuilder.Entity("Licenta.Models.Vehicul", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AnFabricatie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CapacitateCilindrica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MasaMaxima")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NrInmatriculare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NrLocuri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumarIdentificare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Putere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerieCIV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipCombustibilID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TipCombustibilID");

                    b.ToTable("Vehicul");
                });

            modelBuilder.Entity("Licenta.Models.Vehicul", b =>
                {
                    b.HasOne("Licenta.Models.TipCombustibil", "TipCombustibil")
                        .WithMany("Vehicule")
                        .HasForeignKey("TipCombustibilID");

                    b.Navigation("TipCombustibil");
                });

            modelBuilder.Entity("Licenta.Models.TipCombustibil", b =>
                {
                    b.Navigation("Vehicule");
                });
#pragma warning restore 612, 618
        }
    }
}
