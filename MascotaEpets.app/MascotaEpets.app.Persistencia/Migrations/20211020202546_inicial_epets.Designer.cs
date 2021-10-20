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
    [Migration("20211020202546_inicial_epets")]
    partial class inicial_epets
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MascotaEpets.app.Dominio.Empresa", b =>
                {
                    b.Property<int>("IdEmpresa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdEmpresa")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Direccion");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("NIt");

                    b.Property<string>("NombreEmpresa")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("NombreEmpresa");

                    b.HasKey("IdEmpresa");

                    b.ToTable("EmpresaDb");
                });

            modelBuilder.Entity("MascotaEpets.app.Dominio.Mascota", b =>
                {
                    b.Property<int>("IdMascota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdMascota")
                        .UseIdentityColumn();

                    b.Property<string>("ColorOjos")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("ColorOjos");

                    b.Property<string>("ColorPiel")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("ColorPiel");

                    b.Property<string>("EstadoAnimo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("EstadoAnimo");

                    b.Property<double>("FrecuenciaCardiaca")
                        .HasColumnType("float")
                        .HasColumnName("FrecuenciaCardiaca");

                    b.Property<double>("FrecuenciaRespiratoria")
                        .HasColumnType("float")
                        .HasColumnName("FrecuenciaRespiratoria");

                    b.Property<int?>("IdAnimal")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Nombre");

                    b.Property<double>("Peso")
                        .HasColumnType("float")
                        .HasColumnName("Peso");

                    b.Property<double>("Temperatura")
                        .HasColumnType("float")
                        .HasColumnName("Temperatura");

                    b.HasKey("IdMascota");

                    b.HasIndex("IdAnimal");

                    b.ToTable("MascotaDb");
                });

            modelBuilder.Entity("MascotaEpets.app.Dominio.MedicoVeterinario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Apellido");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("Cedula");

                    b.Property<int?>("IdAnimal")
                        .HasColumnType("int");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Nombre");

                    b.Property<int>("TarjetaProfesional")
                        .HasColumnType("int")
                        .HasColumnName("TarjetaProfesional");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("Telefono");

                    b.HasKey("Id");

                    b.HasIndex("IdAnimal");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("MedicoDb");
                });

            modelBuilder.Entity("MascotaEpets.app.Dominio.PropietarioMascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Apellido");

                    b.Property<int>("CantidadMascota")
                        .HasColumnType("int")
                        .HasColumnName("CantidadMascotas");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("Cedula");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Direccion");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Email");

                    b.Property<int?>("IdMascota")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Nombre");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("Telefono");

                    b.HasKey("Id");

                    b.HasIndex("IdMascota");

                    b.ToTable("PropietariosDb");
                });

            modelBuilder.Entity("MascotaEpets.app.Dominio.RegistroMedico", b =>
                {
                    b.Property<int>("IdRegistroMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdRegistroM")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaAtencion")
                        .HasColumnType("datetime2")
                        .HasColumnName("FechaAtencion");

                    b.Property<int?>("IdMedico")
                        .HasColumnType("int");

                    b.Property<string>("Medicamentos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Medicamentos");

                    b.Property<string>("Recomendaciones")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Recomendaciones");

                    b.HasKey("IdRegistroMedico");

                    b.HasIndex("IdMedico");

                    b.ToTable("RegistroMedicoDb");
                });

            modelBuilder.Entity("MascotaEpets.app.Dominio.TipoAnimal", b =>
                {
                    b.Property<int>("IdAnimal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdAnimal")
                        .UseIdentityColumn();

                    b.Property<string>("Animal")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Animal");

                    b.HasKey("IdAnimal");

                    b.ToTable("TipoAnimalDb");
                });

            modelBuilder.Entity("MascotaEpets.app.Dominio.Mascota", b =>
                {
                    b.HasOne("MascotaEpets.app.Dominio.TipoAnimal", "TipoAnimal")
                        .WithMany()
                        .HasForeignKey("IdAnimal");

                    b.Navigation("TipoAnimal");
                });

            modelBuilder.Entity("MascotaEpets.app.Dominio.MedicoVeterinario", b =>
                {
                    b.HasOne("MascotaEpets.app.Dominio.TipoAnimal", "TipoAnimal")
                        .WithMany()
                        .HasForeignKey("IdAnimal");

                    b.HasOne("MascotaEpets.app.Dominio.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("IdEmpresa");

                    b.Navigation("Empresa");

                    b.Navigation("TipoAnimal");
                });

            modelBuilder.Entity("MascotaEpets.app.Dominio.PropietarioMascota", b =>
                {
                    b.HasOne("MascotaEpets.app.Dominio.Mascota", "Mascota")
                        .WithMany()
                        .HasForeignKey("IdMascota");

                    b.Navigation("Mascota");
                });

            modelBuilder.Entity("MascotaEpets.app.Dominio.RegistroMedico", b =>
                {
                    b.HasOne("MascotaEpets.app.Dominio.MedicoVeterinario", "MedicoVeterinario")
                        .WithMany()
                        .HasForeignKey("IdMedico");

                    b.Navigation("MedicoVeterinario");
                });
#pragma warning restore 612, 618
        }
    }
}
