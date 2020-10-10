using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace parcial_1.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IDUsuario = table.Column<int>(name: "ID Usuario", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Usuario = table.Column<string>(type: "varchar(30)", nullable: false),
                    Clave = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IDUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Nombre",
                columns: table => new
                {
                    IDRecurso = table.Column<int>(name: "ID Recurso", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "varchar(30)", nullable: false),
                    IdUsuario = table.Column<int>(nullable: false),
                    UsuarioIdUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nombre", x => x.IDRecurso);
                    table.ForeignKey(
                        name: "FK_Nombre_Usuarios_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "ID Usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    IDTarea = table.Column<int>(name: "ID Tarea", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Vencimiento = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Estimacion = table.Column<int>(type: "int", nullable: false),
                    IdRecursos = table.Column<int>(nullable: false),
                    ResponsableIdRecursos = table.Column<int>(nullable: true),
                    Estado = table.Column<bool>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.IDTarea);
                    table.ForeignKey(
                        name: "FK_Tareas_Nombre_ResponsableIdRecursos",
                        column: x => x.ResponsableIdRecursos,
                        principalTable: "Nombre",
                        principalColumn: "ID Recurso",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalles",
                columns: table => new
                {
                    IdDetalles = table.Column<int>(name: "Id Detalles", type: "int", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Tiempo = table.Column<int>(type: "int", nullable: false),
                    IdRecursos = table.Column<int>(nullable: false),
                    RecursoIdRecursos = table.Column<int>(nullable: true),
                    IdTareas = table.Column<int>(nullable: false),
                    TareaIdTareas = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles", x => x.IdDetalles);
                    table.ForeignKey(
                        name: "FK_Detalles_Nombre_RecursoIdRecursos",
                        column: x => x.RecursoIdRecursos,
                        principalTable: "Nombre",
                        principalColumn: "ID Recurso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalles_Tareas_TareaIdTareas",
                        column: x => x.TareaIdTareas,
                        principalTable: "Tareas",
                        principalColumn: "ID Tarea",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_RecursoIdRecursos",
                table: "Detalles",
                column: "RecursoIdRecursos");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_TareaIdTareas",
                table: "Detalles",
                column: "TareaIdTareas");

            migrationBuilder.CreateIndex(
                name: "IX_Nombre_UsuarioIdUsuario",
                table: "Nombre",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Tareas_ResponsableIdRecursos",
                table: "Tareas",
                column: "ResponsableIdRecursos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalles");

            migrationBuilder.DropTable(
                name: "Tareas");

            migrationBuilder.DropTable(
                name: "Nombre");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
