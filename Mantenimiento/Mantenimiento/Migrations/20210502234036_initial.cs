using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mantenimiento.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "crud_base",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    descripcioncorta = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    descripcionlarga = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    fechacreacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuariocreacion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fechamodificacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuariomodificacion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_crud_base", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "empleado",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    descripcioncorta = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    descripcionlarga = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    fechacreacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuariocreacion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fechamodificacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuariomodificacion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleado", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "crud_base");

            migrationBuilder.DropTable(
                name: "empleado");
        }
    }
}
