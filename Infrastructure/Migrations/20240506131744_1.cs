using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomFields_Persons_PersonId",
                table: "CustomFields");

            migrationBuilder.AlterColumn<Guid>(
                name: "PersonId",
                table: "CustomFields",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFields_Persons_PersonId",
                table: "CustomFields",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomFields_Persons_PersonId",
                table: "CustomFields");

            migrationBuilder.AlterColumn<Guid>(
                name: "PersonId",
                table: "CustomFields",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFields_Persons_PersonId",
                table: "CustomFields",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
