using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Vehicles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Models",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Makes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Colors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Bookings",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "6b82d8c8-0dc5-41ae-81f1-30abb374d227", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "7bea5ade-5be7-4d58-8367-88fb4269e18b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "3ccacc1a-cebb-4d8d-9ce5-1673224b43c4", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEDHku4UY3Nfnn1re5Fpr3Gl93dZ7LB6PZ4TGnsdkO3cnkut6qnY3W9WMp/v37ks1OA==", null, false, "6999835b-5a55-42f4-b2b2-6397adbc9b7e", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 5, 1, 46, 28, 305, DateTimeKind.Local).AddTicks(8442), new DateTime(2022, 12, 5, 1, 46, 28, 307, DateTimeKind.Local).AddTicks(1141), "Black", "System" },
                    { 2, "System", new DateTime(2022, 12, 5, 1, 46, 28, 307, DateTimeKind.Local).AddTicks(2027), new DateTime(2022, 12, 5, 1, 46, 28, 307, DateTimeKind.Local).AddTicks(2032), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 5, 1, 46, 28, 309, DateTimeKind.Local).AddTicks(129), new DateTime(2022, 12, 5, 1, 46, 28, 309, DateTimeKind.Local).AddTicks(158), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 12, 5, 1, 46, 28, 309, DateTimeKind.Local).AddTicks(163), new DateTime(2022, 12, 5, 1, 46, 28, 309, DateTimeKind.Local).AddTicks(165), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 5, 1, 46, 28, 309, DateTimeKind.Local).AddTicks(5564), new DateTime(2022, 12, 5, 1, 46, 28, 309, DateTimeKind.Local).AddTicks(5578), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 12, 5, 1, 46, 28, 309, DateTimeKind.Local).AddTicks(5583), new DateTime(2022, 12, 5, 1, 46, 28, 309, DateTimeKind.Local).AddTicks(5584), "X5", "System" },
                    { 3, "System", new DateTime(2022, 12, 5, 1, 46, 28, 309, DateTimeKind.Local).AddTicks(5587), new DateTime(2022, 12, 5, 1, 46, 28, 309, DateTimeKind.Local).AddTicks(5588), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 12, 5, 1, 46, 28, 309, DateTimeKind.Local).AddTicks(5591), new DateTime(2022, 12, 5, 1, 46, 28, 309, DateTimeKind.Local).AddTicks(5592), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DrivingLicense",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vehicles",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Models",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Makes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Colors",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bookings",
                newName: "id");
        }
    }
}
