using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortal.Data.Migrations
{
    public partial class ffs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("376c1d1e-0b04-47da-9657-a2a87faf0a59"),
                column: "ConcurrencyStamp",
                value: "accf31ce-7783-4539-8bbb-589b61b46a79");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("4e233be7-c199-4567-9c07-9271a9de4c64"),
                column: "ConcurrencyStamp",
                value: "af728b3a-7f4d-4427-a176-3b54f989560f");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("9f685d0f-bd6f-44dd-ab60-c606952eb2a8"),
                column: "ConcurrencyStamp",
                value: "31735d0d-1061-44e8-a2f6-27e3dadf0d3b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("769f41bd-ccd4-45ba-abbd-550ccd0b62e3"),
                columns: new[] { "ConcurrencyStamp", "CreateDate", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "fe797f4b-214f-4659-a1f4-8ab0063d9a57", new DateTime(2023, 8, 25, 19, 58, 27, 715, DateTimeKind.Local).AddTicks(7319), "admin@techgarlic.com", "TECHGARLIC ADMIN", "ADMIN@TECHGARLIC.COM", "ADMIN@TECHGARLIC.COM", "AQAAAAEAACcQAAAAEL5FydaDWTL1FpWhGpIlc4VYYvJ8xYSix7HlV/DBqZgPsIMUfajW8EzAUBQIZnn3JA==", "admin@techgarlic.com" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Flag", "Name" },
                values: new object[] { "Bangladesh.png", "Bangladesh" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Slug" },
                values: new object[] { "Dhaka", "dhaka" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Slug" },
                values: new object[] { "Chittagong", "chittagong" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Slug" },
                values: new object[] { "Syhlet", "sylhet" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Slug" },
                values: new object[] { "Barisal", "barisal" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CategoryId", "Name", "Slug" },
                values: new object[] { 5, 4, "Others", "others" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5);

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
                columns: new[] { "ConcurrencyStamp", "CreateDate", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "9ccdc415-1bae-4771-8b39-19c62f5a5e1a", new DateTime(2023, 8, 19, 16, 45, 8, 830, DateTimeKind.Local).AddTicks(6270), "admin@gmail.com", "Adminitrator", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEA9vV5DYB0E9nheH+AxOYCZ4sm0fuRjhdLru3/w8qmk5cdZHSGjtTZw6cxHCrZs3GQ==", "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Flag", "Name" },
                values: new object[] { "Vietnam.png", "Vietnam" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Slug" },
                values: new object[] { "Ho Chi Minh", "ho-chi-minh" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Slug" },
                values: new object[] { "Ha Noi", "ha-noi" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Slug" },
                values: new object[] { "Da Nang", "da-nang" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Slug" },
                values: new object[] { "Others", "others" });
        }
    }
}
