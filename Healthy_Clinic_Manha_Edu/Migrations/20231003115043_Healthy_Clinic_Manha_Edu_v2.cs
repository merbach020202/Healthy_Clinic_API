using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Healthy_Clinic_Manha_Edu.Migrations
{
    /// <inheritdoc />
    public partial class Healthy_Clinic_Manha_Edu_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medico_TiposUsuario_IdTipoEspecialidade",
                table: "Medico");

            migrationBuilder.RenameColumn(
                name: "IdTipoEspecialidade",
                table: "Medico",
                newName: "IdTiposUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Medico_IdTipoEspecialidade",
                table: "Medico",
                newName: "IX_Medico_IdTiposUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Medico_TiposUsuario_IdTiposUsuario",
                table: "Medico",
                column: "IdTiposUsuario",
                principalTable: "TiposUsuario",
                principalColumn: "IdTiposUsuario",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medico_TiposUsuario_IdTiposUsuario",
                table: "Medico");

            migrationBuilder.RenameColumn(
                name: "IdTiposUsuario",
                table: "Medico",
                newName: "IdTipoEspecialidade");

            migrationBuilder.RenameIndex(
                name: "IX_Medico_IdTiposUsuario",
                table: "Medico",
                newName: "IX_Medico_IdTipoEspecialidade");

            migrationBuilder.AddForeignKey(
                name: "FK_Medico_TiposUsuario_IdTipoEspecialidade",
                table: "Medico",
                column: "IdTipoEspecialidade",
                principalTable: "TiposUsuario",
                principalColumn: "IdTiposUsuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
