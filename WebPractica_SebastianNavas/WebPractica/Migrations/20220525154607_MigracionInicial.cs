using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPractica.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    IdRegistro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Documento = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    FechaNac = table.Column<DateTime>(type: "datetime", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Celular = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Genero = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false),
                    Deporte = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Trabaja = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    Sueldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.IdRegistro);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registros");
        }
    }
}
