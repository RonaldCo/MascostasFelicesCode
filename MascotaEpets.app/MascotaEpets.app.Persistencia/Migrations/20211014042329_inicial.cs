using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaEpets.app.Persistencia.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpresaDb",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NIt = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaDb", x => x.IdEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "SignoVitalesDb",
                columns: table => new
                {
                    IdSignos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperatura = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    FrecuenciaRespiratoria = table.Column<double>(type: "float", nullable: false),
                    FrecuenciaCardiaca = table.Column<double>(type: "float", nullable: false),
                    EstadoAnimo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignoVitalesDb", x => x.IdSignos);
                });

            migrationBuilder.CreateTable(
                name: "TipoAnimalDb",
                columns: table => new
                {
                    IdAnimal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaseAnimal = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAnimalDb", x => x.IdAnimal);
                });

            migrationBuilder.CreateTable(
                name: "MascotaDb",
                columns: table => new
                {
                    IdMascota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ColorOjos = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ColorPiel = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IdSignos = table.Column<int>(type: "int", nullable: true),
                    IdAnimal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MascotaDb", x => x.IdMascota);
                    table.ForeignKey(
                        name: "FK_MascotaDb_SignoVitalesDb_IdSignos",
                        column: x => x.IdSignos,
                        principalTable: "SignoVitalesDb",
                        principalColumn: "IdSignos",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MascotaDb_TipoAnimalDb_IdAnimal",
                        column: x => x.IdAnimal,
                        principalTable: "TipoAnimalDb",
                        principalColumn: "IdAnimal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropietariosDb",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CantidadMascotas = table.Column<int>(type: "int", nullable: false),
                    IdMascota = table.Column<int>(type: "int", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropietariosDb", x => x.IdPersona);
                    table.ForeignKey(
                        name: "FK_PropietariosDb_MascotaDb_IdMascota",
                        column: x => x.IdMascota,
                        principalTable: "MascotaDb",
                        principalColumn: "IdMascota",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicoDb",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarjetaProfesional = table.Column<int>(type: "int", nullable: false),
                    IdAnimal = table.Column<int>(type: "int", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int", nullable: true),
                    IdSolicitud = table.Column<int>(type: "int", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoDb", x => x.IdPersona);
                    table.ForeignKey(
                        name: "FK_MedicoDb_EmpresaDb_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "EmpresaDb",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicoDb_TipoAnimalDb_IdAnimal",
                        column: x => x.IdAnimal,
                        principalTable: "TipoAnimalDb",
                        principalColumn: "IdAnimal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistroMedicoDb",
                columns: table => new
                {
                    IdRegistroM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recomendaciones = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaAtencion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Medicamentos = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IdMedico = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroMedicoDb", x => x.IdRegistroM);
                    table.ForeignKey(
                        name: "FK_RegistroMedicoDb_MedicoDb_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "MedicoDb",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudVisitaDb",
                columns: table => new
                {
                    IdSolicitud = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMascota = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdAnimal = table.Column<int>(type: "int", nullable: true),
                    IdMedico = table.Column<int>(type: "int", nullable: true),
                    IdPropietario = table.Column<int>(type: "int", nullable: true),
                    IdRegistroM = table.Column<int>(type: "int", nullable: true),
                    IdMascota = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudVisitaDb", x => x.IdSolicitud);
                    table.ForeignKey(
                        name: "FK_SolicitudVisitaDb_MascotaDb_IdMascota",
                        column: x => x.IdMascota,
                        principalTable: "MascotaDb",
                        principalColumn: "IdMascota",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudVisitaDb_MedicoDb_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "MedicoDb",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudVisitaDb_PropietariosDb_IdPropietario",
                        column: x => x.IdPropietario,
                        principalTable: "PropietariosDb",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudVisitaDb_RegistroMedicoDb_IdRegistroM",
                        column: x => x.IdRegistroM,
                        principalTable: "RegistroMedicoDb",
                        principalColumn: "IdRegistroM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolicitudVisitaDb_TipoAnimalDb_IdAnimal",
                        column: x => x.IdAnimal,
                        principalTable: "TipoAnimalDb",
                        principalColumn: "IdAnimal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MascotaDb_IdAnimal",
                table: "MascotaDb",
                column: "IdAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_MascotaDb_IdSignos",
                table: "MascotaDb",
                column: "IdSignos");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoDb_IdAnimal",
                table: "MedicoDb",
                column: "IdAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoDb_IdEmpresa",
                table: "MedicoDb",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoDb_IdSolicitud",
                table: "MedicoDb",
                column: "IdSolicitud");

            migrationBuilder.CreateIndex(
                name: "IX_PropietariosDb_IdMascota",
                table: "PropietariosDb",
                column: "IdMascota");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroMedicoDb_IdMedico",
                table: "RegistroMedicoDb",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVisitaDb_IdAnimal",
                table: "SolicitudVisitaDb",
                column: "IdAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVisitaDb_IdMascota",
                table: "SolicitudVisitaDb",
                column: "IdMascota");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVisitaDb_IdMedico",
                table: "SolicitudVisitaDb",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVisitaDb_IdPropietario",
                table: "SolicitudVisitaDb",
                column: "IdPropietario");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVisitaDb_IdRegistroM",
                table: "SolicitudVisitaDb",
                column: "IdRegistroM");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicoDb_SolicitudVisitaDb_IdSolicitud",
                table: "MedicoDb",
                column: "IdSolicitud",
                principalTable: "SolicitudVisitaDb",
                principalColumn: "IdSolicitud",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MascotaDb_SignoVitalesDb_IdSignos",
                table: "MascotaDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MascotaDb_TipoAnimalDb_IdAnimal",
                table: "MascotaDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicoDb_TipoAnimalDb_IdAnimal",
                table: "MedicoDb");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudVisitaDb_TipoAnimalDb_IdAnimal",
                table: "SolicitudVisitaDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicoDb_EmpresaDb_IdEmpresa",
                table: "MedicoDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicoDb_SolicitudVisitaDb_IdSolicitud",
                table: "MedicoDb");

            migrationBuilder.DropTable(
                name: "SignoVitalesDb");

            migrationBuilder.DropTable(
                name: "TipoAnimalDb");

            migrationBuilder.DropTable(
                name: "EmpresaDb");

            migrationBuilder.DropTable(
                name: "SolicitudVisitaDb");

            migrationBuilder.DropTable(
                name: "PropietariosDb");

            migrationBuilder.DropTable(
                name: "RegistroMedicoDb");

            migrationBuilder.DropTable(
                name: "MascotaDb");

            migrationBuilder.DropTable(
                name: "MedicoDb");
        }
    }
}
