﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace BACKEND.Migrations
{
    [DbContext(typeof(RentaCarContext))]
    [Migration("20211127171500_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Agencija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lokacija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Agencija");
                });

            modelBuilder.Entity("Models.Automobil", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgencijaID")
                        .HasColumnType("int");

                    b.Property<string>("Boja")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("CenaPoDanuRSD")
                        .HasColumnType("float");

                    b.Property<int>("GodinaProizvodnje")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<double>("PotrosnjaPoKm")
                        .HasColumnType("float");

                    b.Property<string>("Proizvodjac")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<double>("SnagaMotora")
                        .HasColumnType("float");

                    b.Property<string>("Tablice")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("ID");

                    b.HasIndex("AgencijaID");

                    b.ToTable("Automobil");
                });

            modelBuilder.Entity("Models.Iznajmljivanje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AutomobilID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum_Iznajmljivanja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datum_Vracanja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AutomobilID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Iznajmljivanje");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Telefon")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("Models.Automobil", b =>
                {
                    b.HasOne("Models.Agencija", null)
                        .WithMany("AutomobiliZaIznajmljivanje")
                        .HasForeignKey("AgencijaID");
                });

            modelBuilder.Entity("Models.Iznajmljivanje", b =>
                {
                    b.HasOne("Models.Automobil", "Automobil")
                        .WithMany("Iznajmljivanja")
                        .HasForeignKey("AutomobilID");

                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("Iznajmljivanja")
                        .HasForeignKey("KorisnikID");

                    b.Navigation("Automobil");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("Models.Agencija", b =>
                {
                    b.Navigation("AutomobiliZaIznajmljivanje");
                });

            modelBuilder.Entity("Models.Automobil", b =>
                {
                    b.Navigation("Iznajmljivanja");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Navigation("Iznajmljivanja");
                });
#pragma warning restore 612, 618
        }
    }
}