using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortal.Data.Migrations
{
    public partial class ghsdfhhgsdfhg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("376c1d1e-0b04-47da-9657-a2a87faf0a59"),
                column: "ConcurrencyStamp",
                value: "a84058b4-7f1b-405f-ae28-a979b9ef9980");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4e233be7-c199-4567-9c07-9271a9de4c64"),
                column: "ConcurrencyStamp",
                value: "a1e2ed85-d1ad-49ac-8cb1-dbbc7790c72f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("9f685d0f-bd6f-44dd-ab60-c606952eb2a8"),
                column: "ConcurrencyStamp",
                value: "3ad1d224-b5b3-45b0-98c7-23ae303bff26");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("769f41bd-ccd4-45ba-abbd-550ccd0b62e3"),
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash" },
                values: new object[] { "9ccdc415-1bae-4771-8b39-19c62f5a5e1a", new DateTime(2023, 8, 19, 16, 45, 8, 830, DateTimeKind.Local).AddTicks(6270), "AQAAAAEAACcQAAAAEA9vV5DYB0E9nheH+AxOYCZ4sm0fuRjhdLru3/w8qmk5cdZHSGjtTZw6cxHCrZs3GQ==" });
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
