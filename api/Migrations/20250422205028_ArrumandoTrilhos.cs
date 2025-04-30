using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xablau.Migrations
{
    /// <inheritdoc />
    public partial class ArrumandoTrilhos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "data",
                table: "Manutencao",
                newName: "Data");

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "Manutencao",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "IdTrilho",
                table: "Manutencao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrilhoId",
                table: "Manutencao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TrilhoQtd",
                table: "Manutencao",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Manutencao_TrilhoId",
                table: "Manutencao",
                column: "TrilhoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencao_Trilho_TrilhoId",
                table: "Manutencao",
                column: "TrilhoId",
                principalTable: "Trilho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manutencao_Trilho_TrilhoId",
                table: "Manutencao");

            migrationBuilder.DropIndex(
                name: "IX_Manutencao_TrilhoId",
                table: "Manutencao");

            migrationBuilder.DropColumn(
                name: "IdTrilho",
                table: "Manutencao");

            migrationBuilder.DropColumn(
                name: "TrilhoId",
                table: "Manutencao");

            migrationBuilder.DropColumn(
                name: "TrilhoQtd",
                table: "Manutencao");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Manutencao",
                newName: "data");

            migrationBuilder.AlterColumn<DateTime>(
                name: "data",
                table: "Manutencao",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
