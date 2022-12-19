using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddSeedDataToRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33a4317d-de4a-4704-9487-8dd6ae3d79f6", "ea6077d4-587f-454c-8fd5-95a42d3b1de1", "User", "USER" },
                    { "4d3ac11f-8ba8-499a-9c71-9628c992ad91", "e3f8106a-bc85-49e7-aa24-cc64512afc08", "Adminstrator", "ADMINSTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "25cbe757-a6b4-4758-8508-88bcfc581dca", 0, "ef13aca0-89d8-4bbd-ae0f-ceee1472a713", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBG2Y3x6vo0nD944BwVSh0VIfTYRFmuXAFHr6JbfbATXhiRY3a1e/QbrdRGKBRoyQA==", null, false, "36096c9b-4015-43e9-b370-f8b523fcb41f", null, false, "admin@localhost.com" },
                    { "ef37b6b6-9687-4cde-9de9-2992bc44c492", 0, "6e4d157f-94f7-4f95-bdc1-a8b12cd4c40b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "System", "User", false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEM5RfRuFmvaEt2JUthPo7en4dLX5bzBKoRrEnQsLZ3oS5ONrh1jGaFM4a/Ou1qtuhQ==", null, false, "906310d4-dc3f-4b9b-a859-8f16869bfeaa", null, false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4d3ac11f-8ba8-499a-9c71-9628c992ad91", "25cbe757-a6b4-4758-8508-88bcfc581dca" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4d3ac11f-8ba8-499a-9c71-9628c992ad91", "ef37b6b6-9687-4cde-9de9-2992bc44c492" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33a4317d-de4a-4704-9487-8dd6ae3d79f6");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d3ac11f-8ba8-499a-9c71-9628c992ad91", "25cbe757-a6b4-4758-8508-88bcfc581dca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d3ac11f-8ba8-499a-9c71-9628c992ad91", "ef37b6b6-9687-4cde-9de9-2992bc44c492" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d3ac11f-8ba8-499a-9c71-9628c992ad91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25cbe757-a6b4-4758-8508-88bcfc581dca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef37b6b6-9687-4cde-9de9-2992bc44c492");
        }
    }
}
