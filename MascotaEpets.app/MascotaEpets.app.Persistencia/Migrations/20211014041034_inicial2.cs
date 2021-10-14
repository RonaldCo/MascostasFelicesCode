using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaEpets.app.Persistencia.Migrations
{
    public partial class inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MascotaDb_HistoriaMedicaDb_IdHistoria",
                table: "MascotaDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicoDb_HistoriaMedicaDb_IdHistoria",
                table: "MedicoDb");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicoDb_PersonaDb_IdPersona",
                table: "MedicoDb");

            migrationBuilder.DropForeignKey(
                name: "FK_PropietariosDb_PersonaDb_IdPersona",
                table: "PropietariosDb");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudVisitaDb_HistoriaMedicaDb_IdHistoria",
                table: "SolicitudVisitaDb");

            migrationBuilder.DropTable(
                name: "HistoriaMedicaDb");

            migrationBuilder.DropTable(
                name: "PersonaDb");

            migrationBuilder.DropIndex(
                name: "IX_SolicitudVisitaDb_IdHistoria",
                table: "SolicitudVisitaDb");

            migrationBuilder.DropIndex(
                name: "IX_MedicoDb_IdHistoria",
                table: "MedicoDb");

            migrationBuilder.DropIndex(
                name: "IX_MascotaDb_IdHistoria",
                table: "MascotaDb");

            migrationBuilder.DropColumn(
                name: "IdHistoria",
                table: "SolicitudVisitaDb");

            migrationBuilder.DropColumn(
                name: "IdPropietarioMascota",
                table: "PropietariosDb");

            migrationBuilder.DropColumn(
                name: "Especializacion",
                table: "MedicoDb");

            migrationBuilder.DropColumn(
                name: "IdHistoria",
                table: "MedicoDb");

            migrationBuilder.DropColumn(
                name: "IdMedico",
                table: "MedicoDb");

            migrationBuilder.DropColumn(
                name: "IdHistoria",
                table: "MascotaDb");

            migrationBuilder.RenameColumn(
                name: "claseAnimal",
                table: "TipoAnimalDb",
                newName: "ClaseAnimal");

            migrationBuilder.AlterColumn<int>(
                name: "IdPersona",
                table: "PropietariosDb",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "PropietariosDb",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "PropietariosDb",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "PropietariosDb",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "PropietariosDb",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "IdPersona",
                table: "MedicoDb",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "MedicoDb",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "MedicoDb",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "MedicoDb",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "MedicoDb",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "PropietariosDb");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "PropietariosDb");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "PropietariosDb");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "PropietariosDb");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "MedicoDb");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "MedicoDb");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "MedicoDb");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "MedicoDb");

            migrationBuilder.RenameColumn(
                name: "ClaseAnimal",
                table: "TipoAnimalDb",
                newName: "claseAnimal");

            migrationBuilder.AddColumn<int>(
                name: "IdHistoria",
                table: "SolicitudVisitaDb",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdPersona",
                table: "PropietariosDb",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IdPropietarioMascota",
                table: "PropietariosDb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "IdPersona",
                table: "MedicoDb",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Especializacion",
                table: "MedicoDb",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdHistoria",
                table: "MedicoDb",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdMedico",
                table: "MedicoDb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdHistoria",
                table: "MascotaDb",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HistoriaMedicaDb",
                columns: table => new
                {
                    IdHistoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMascota = table.Column<int>(type: "int", nullable: true),
                    IdRegistroMedico = table.Column<int>(type: "int", nullable: true),
                    IddPropietarioMascota = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriaMedicaDb", x => x.IdHistoria);
                    table.ForeignKey(
                        name: "FK_HistoriaMedicaDb_MascotaDb_IdMascota",
                        column: x => x.IdMascota,
                        principalTable: "MascotaDb",
                        principalColumn: "IdMascota",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoriaMedicaDb_PropietariosDb_IddPropietarioMascota",
                        column: x => x.IddPropietarioMascota,
                        principalTable: "PropietariosDb",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoriaMedicaDb_RegistroMedicoDb_IdRegistroMedico",
                        column: x => x.IdRegistroMedico,
                        principalTable: "RegistroMedicoDb",
                        principalColumn: "IdRegistroM",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaDb",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaDb", x => x.IdPersona);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVisitaDb_IdHistoria",
                table: "SolicitudVisitaDb",
                column: "IdHistoria");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoDb_IdHistoria",
                table: "MedicoDb",
                column: "IdHistoria");

            migrationBuilder.CreateIndex(
                name: "IX_MascotaDb_IdHistoria",
                table: "MascotaDb",
                column: "IdHistoria");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaMedicaDb_IddPropietarioMascota",
                table: "HistoriaMedicaDb",
                column: "IddPropietarioMascota");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaMedicaDb_IdMascota",
                table: "HistoriaMedicaDb",
                column: "IdMascota");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaMedicaDb_IdRegistroMedico",
                table: "HistoriaMedicaDb",
                column: "IdRegistroMedico");

            migrationBuilder.AddForeignKey(
                name: "FK_MascotaDb_HistoriaMedicaDb_IdHistoria",
                table: "MascotaDb",
                column: "IdHistoria",
                principalTable: "HistoriaMedicaDb",
                principalColumn: "IdHistoria",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicoDb_HistoriaMedicaDb_IdHistoria",
                table: "MedicoDb",
                column: "IdHistoria",
                principalTable: "HistoriaMedicaDb",
                principalColumn: "IdHistoria",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicoDb_PersonaDb_IdPersona",
                table: "MedicoDb",
                column: "IdPersona",
                principalTable: "PersonaDb",
                principalColumn: "IdPersona",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropietariosDb_PersonaDb_IdPersona",
                table: "PropietariosDb",
                column: "IdPersona",
                principalTable: "PersonaDb",
                principalColumn: "IdPersona",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudVisitaDb_HistoriaMedicaDb_IdHistoria",
                table: "SolicitudVisitaDb",
                column: "IdHistoria",
                principalTable: "HistoriaMedicaDb",
                principalColumn: "IdHistoria",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
