using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaEpets.app.Persistencia.Migrations
{
    public partial class inicial_nueva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClaseAnimal",
                table: "TipoAnimalDb",
                newName: "Animal");

            migrationBuilder.RenameColumn(
                name: "IdMedico",
                table: "MedicoDb",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "MedicoDb",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "MedicoDb",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "MedicoDb",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

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
                name: "MascotaDb",
                columns: table => new
                {
                    IdMascota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ColorOjos = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ColorPiel = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Temperatura = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    FrecuenciaRespiratoria = table.Column<double>(type: "float", nullable: false),
                    FrecuenciaCardiaca = table.Column<double>(type: "float", nullable: false),
                    EstadoAnimo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IdAnimal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MascotaDb", x => x.IdMascota);
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CantidadMascotas = table.Column<int>(type: "int", nullable: false),
                    IdMascota = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropietariosDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropietariosDb_MascotaDb_IdMascota",
                        column: x => x.IdMascota,
                        principalTable: "MascotaDb",
                        principalColumn: "IdMascota",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicoDb_IdEmpresa",
                table: "MedicoDb",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_MascotaDb_IdAnimal",
                table: "MascotaDb",
                column: "IdAnimal");

            migrationBuilder.CreateIndex(
                name: "IX_PropietariosDb_IdMascota",
                table: "PropietariosDb",
                column: "IdMascota");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicoDb_EmpresaDb_IdEmpresa",
                table: "MedicoDb",
                column: "IdEmpresa",
                principalTable: "EmpresaDb",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicoDb_EmpresaDb_IdEmpresa",
                table: "MedicoDb");

            migrationBuilder.DropTable(
                name: "EmpresaDb");

            migrationBuilder.DropTable(
                name: "PropietariosDb");

            migrationBuilder.DropTable(
                name: "MascotaDb");

            migrationBuilder.DropIndex(
                name: "IX_MedicoDb_IdEmpresa",
                table: "MedicoDb");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "MedicoDb");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "MedicoDb");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "MedicoDb");

            migrationBuilder.RenameColumn(
                name: "Animal",
                table: "TipoAnimalDb",
                newName: "ClaseAnimal");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MedicoDb",
                newName: "IdMedico");
        }
    }
}
