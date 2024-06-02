using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortal.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("376c1d1e-0b04-47da-9657-a2a87faf0a59"),
                column: "ConcurrencyStamp",
                value: "b42cfb01-f9ee-4447-a6e9-d6e4d53d3cfa");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4e233be7-c199-4567-9c07-9271a9de4c64"),
                column: "ConcurrencyStamp",
                value: "5075f36f-343e-4460-9ce1-279801d3da9a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("9f685d0f-bd6f-44dd-ab60-c606952eb2a8"),
                column: "ConcurrencyStamp",
                value: "ac511c9b-82f6-4182-b727-417f051b3634");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("769f41bd-ccd4-45ba-abbd-550ccd0b62e3"),
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "a0aeb63b-c810-4875-94bd-3651f34e5f63", new DateTime(2024, 6, 1, 14, 17, 5, 246, DateTimeKind.Local).AddTicks(9037), "AQAAAAEAACcQAAAAEKeqxL9a1Tnu49MqmnJc/1Jw0VsPV2SnZ+EUX0OYfu0TGn2yai5FlZPbsB4cJmVeRg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("376c1d1e-0b04-47da-9657-a2a87faf0a59"),
                column: "ConcurrencyStamp",
                value: "bb760d45-ef93-4c5e-aa36-524ea4960072");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4e233be7-c199-4567-9c07-9271a9de4c64"),
                column: "ConcurrencyStamp",
                value: "dad3c18c-1340-4da2-88b0-f15c9bf65d22");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("9f685d0f-bd6f-44dd-ab60-c606952eb2a8"),
                column: "ConcurrencyStamp",
                value: "8d681dff-b911-4aea-bb97-3be17ba95e48");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("769f41bd-ccd4-45ba-abbd-550ccd0b62e3"),
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "e6d2c4d0-3172-4dff-8c92-499dfe6597a0", new DateTime(2023, 7, 8, 2, 55, 16, 64, DateTimeKind.Local).AddTicks(9520), "AQAAAAEAACcQAAAAEAfXXQh97Y9dgVTzTXk4vJqMeZfUhIdwZ/EDrZOayS3pdscyowtYHMs4yu6Mg7ch3w==" });
        }
    }
}
