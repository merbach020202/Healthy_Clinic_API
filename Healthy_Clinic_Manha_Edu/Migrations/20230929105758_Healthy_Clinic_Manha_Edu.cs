using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Healthy_Clinic_Manha_Edu.Migrations
{
    /// <inheritdoc />
    public partial class Healthy_Clinic_Manha_Edu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinica",
                columns: table => new
                {
                    IdClinica = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    HorarioAbertura = table.Column<TimeSpan>(type: "TIME", nullable: false),
                    HorarioFechamento = table.Column<TimeSpan>(type: "TIME", nullable: false),
                    CNPJ = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    NomeFantasia = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    RazaoSocial = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinica", x => x.IdClinica);
                });

            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    IdEspecialdiades = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EspecialidadesMedico = table.Column<string>(type: "VARCHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.IdEspecialdiades);
                });

            migrationBuilder.CreateTable(
                name: "Prontuario",
                columns: table => new
                {
                    IdProntuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescricaoConsulta = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prontuario", x => x.IdProntuario);
                });

            migrationBuilder.CreateTable(
                name: "TiposUsuario",
                columns: table => new
                {
                    IdTiposUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tiposUsuario = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUsuario", x => x.IdTiposUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Administrador",
                columns: table => new
                {
                    IdAdministrador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Senha = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrador", x => x.IdAdministrador);
                    table.ForeignKey(
                        name: "FK_Administrador_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    IdMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    CRM = table.Column<string>(type: "VARCHAR(6)", maxLength: 6, nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdClinica = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEspecialidades = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.IdMedico);
                    table.ForeignKey(
                        name: "FK_Medico_Clinica_IdClinica",
                        column: x => x.IdClinica,
                        principalTable: "Clinica",
                        principalColumn: "IdClinica",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medico_Especialidade_IdEspecialidades",
                        column: x => x.IdEspecialidades,
                        principalTable: "Especialidade",
                        principalColumn: "IdEspecialdiades",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medico_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    IdPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.IdPaciente);
                    table.ForeignKey(
                        name: "FK_Paciente_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agendamento",
                columns: table => new
                {
                    IdAgendamento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataConsulta = table.Column<DateTime>(type: "DATE", nullable: false),
                    HorarioConsulta = table.Column<TimeSpan>(type: "TIME", nullable: false),
                    IdMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAdministrador = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamento", x => x.IdAgendamento);
                    table.ForeignKey(
                        name: "FK_Agendamento_Administrador_IdAdministrador",
                        column: x => x.IdAdministrador,
                        principalTable: "Administrador",
                        principalColumn: "IdAdministrador",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Agendamento_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Agendamento_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    IdConsulta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataConsulta = table.Column<DateTime>(type: "DATE", nullable: false),
                    HorarioConsulta = table.Column<TimeSpan>(type: "TIME", nullable: false),
                    IdMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Idpaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProntuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.IdConsulta);
                    table.ForeignKey(
                        name: "FK_Consulta_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Consulta_Paciente_Idpaciente",
                        column: x => x.Idpaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Consulta_Prontuario_IdProntuario",
                        column: x => x.IdProntuario,
                        principalTable: "Prontuario",
                        principalColumn: "IdProntuario",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Comentario",
                columns: table => new
                {
                    DescricaoComentarios = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdConsulta = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentario", x => x.DescricaoComentarios);
                    table.ForeignKey(
                        name: "FK_Comentario_Consulta_IdConsulta",
                        column: x => x.IdConsulta,
                        principalTable: "Consulta",
                        principalColumn: "IdConsulta",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Comentario_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Comentario_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrador_IdUsuario",
                table: "Administrador",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_IdAdministrador",
                table: "Agendamento",
                column: "IdAdministrador");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_IdMedico",
                table: "Agendamento",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_IdPaciente",
                table: "Agendamento",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_IdConsulta",
                table: "Comentario",
                column: "IdConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_IdMedico",
                table: "Comentario",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_IdPaciente",
                table: "Comentario",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_IdMedico",
                table: "Consulta",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_Idpaciente",
                table: "Consulta",
                column: "Idpaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_IdProntuario",
                table: "Consulta",
                column: "IdProntuario");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_CRM",
                table: "Medico",
                column: "CRM",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medico_IdClinica",
                table: "Medico",
                column: "IdClinica");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_IdEspecialidades",
                table: "Medico",
                column: "IdEspecialidades");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_IdUsuario",
                table: "Medico",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_IdUsuario",
                table: "Paciente",
                column: "IdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamento");

            migrationBuilder.DropTable(
                name: "Comentario");

            migrationBuilder.DropTable(
                name: "TiposUsuario");

            migrationBuilder.DropTable(
                name: "Administrador");

            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Prontuario");

            migrationBuilder.DropTable(
                name: "Clinica");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
