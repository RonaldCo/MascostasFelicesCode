﻿// <auto-generated />
using System;
using MascotaEpets.app.Persistencia.AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MascotaEpets.app.Persistencia.Migrations
{
    [DbContext(typeof(EfAppContext))]
    [Migration("20211018034747_inicial2")]
    partial class inicial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MascotaEpets.app.Dominio.MedicoVeterinario", b =>
                {
                    b.Property<int>("IdMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdMedico")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Apellido");

                    b.Property<int?>("IdAnimal")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Nombre");

                    b.Property<int>("TarjetaProfesional")
                        .HasColumnType("int")
                        .HasColumnName("TarjetaProfesional");

                    b.HasKey("IdMedico");

                    b.HasIndex("IdAnimal");

                    b.ToTable("MedicoDb");
                });

            modelBuilder.Entity("MascotaEpets.app.Dominio.TipoAnimal", b =>
                {
                    b.Property<int>("idAnimal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdAnimal")
                        .UseIdentityColumn();

                    b.Property<string>("ClaseAnimal")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("ClaseAnimal");

                    b.HasKey("idAnimal");

                    b.ToTable("TipoAnimalDb");
                });

            modelBuilder.Entity("MascotaEpets.app.Dominio.MedicoVeterinario", b =>
                {
                    b.HasOne("MascotaEpets.app.Dominio.TipoAnimal", "TipoAnimal")
                        .WithMany()
                        .HasForeignKey("IdAnimal");

                    b.Navigation("TipoAnimal");
                });
#pragma warning restore 612, 618
        }
    }
}
