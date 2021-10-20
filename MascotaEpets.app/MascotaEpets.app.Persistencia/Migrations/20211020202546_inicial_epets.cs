using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaEpets.app.Persistencia.Migrations
{
    public partial class inicial_epets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegistroMedicoDb_IdMedico",
                table: "RegistroMedicoDb",
                column: "IdMedico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroMedicoDb");
        }
    }
}
