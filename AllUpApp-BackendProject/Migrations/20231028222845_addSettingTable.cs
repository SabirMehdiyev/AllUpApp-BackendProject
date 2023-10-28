using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllUpApp_BackendProject.Migrations
{
    public partial class addSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "def6f73a-49f0-4b9d-aa1b-90cafa0fce96");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba5177e8-f196-4978-89ed-7ac00a3801d8", "72e8d25f-af54-4565-8200-9ddb9541f5a0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e41cccac-086f-40e9-8776-896ee1257572", "97694b55-0e50-4aa1-90e1-c558fef3fcff" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba5177e8-f196-4978-89ed-7ac00a3801d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e41cccac-086f-40e9-8776-896ee1257572");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72e8d25f-af54-4565-8200-9ddb9541f5a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97694b55-0e50-4aa1-90e1-c558fef3fcff");

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7e075d96-a7d0-4565-b6e7-f9b26c314b60", "7e075d96-a7d0-4565-b6e7-f9b26c314b60", "User", "USER" },
                    { "cbc24547-757b-4030-a983-9539cb9d9ef5", "cbc24547-757b-4030-a983-9539cb9d9ef5", "SuperAdmin", "SUPERADMIN" },
                    { "e8bebd5e-7592-4f1e-b6cd-c83808750f29", "e8bebd5e-7592-4f1e-b6cd-c83808750f29", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2f56f526-3762-452c-84fb-b8acb98e7267", 0, "e29d0413-0e5d-469d-8e53-bf2007ea464a", "sabir@gmail.com", true, "SabirMehdiyev", false, false, null, "SABIR@GMAIL.COM", "SABIR1", "AQAAAAEAACcQAAAAEKXlaA9olPdpfHOo1KJ+yytc/umQpiMwIr9z6OwEt0p4n/lSV0M+ZtUKVBOTCZ5irA==", null, false, "aa2023a7-4aa8-4f57-81ca-d2d9b75e27cf", false, "Sabir1" },
                    { "89c1d8d2-91bc-4999-b031-ba44890920cc", 0, "8e1cf9b8-894a-4574-b9a7-4c279f2a8f3c", "sabirsm@code.edu.az", false, "SabirMehdi", false, false, null, "SABIRSM@CODE.EDU.AZ", "SABIRCODE", "AQAAAAEAACcQAAAAEEPF8mabQ6ykr8boFlHVR9bXL4THyPqUCf9NUqgzDU+/aV2g59PmMUWdYIdfUTimVw==", null, false, "923edaa0-a873-47a0-810a-a054ae6cd180", false, "Sabircode" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e8bebd5e-7592-4f1e-b6cd-c83808750f29", "2f56f526-3762-452c-84fb-b8acb98e7267" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc24547-757b-4030-a983-9539cb9d9ef5", "89c1d8d2-91bc-4999-b031-ba44890920cc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e075d96-a7d0-4565-b6e7-f9b26c314b60");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e8bebd5e-7592-4f1e-b6cd-c83808750f29", "2f56f526-3762-452c-84fb-b8acb98e7267" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc24547-757b-4030-a983-9539cb9d9ef5", "89c1d8d2-91bc-4999-b031-ba44890920cc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc24547-757b-4030-a983-9539cb9d9ef5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8bebd5e-7592-4f1e-b6cd-c83808750f29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f56f526-3762-452c-84fb-b8acb98e7267");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89c1d8d2-91bc-4999-b031-ba44890920cc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ba5177e8-f196-4978-89ed-7ac00a3801d8", "ba5177e8-f196-4978-89ed-7ac00a3801d8", "Admin", "ADMIN" },
                    { "def6f73a-49f0-4b9d-aa1b-90cafa0fce96", "def6f73a-49f0-4b9d-aa1b-90cafa0fce96", "User", "USER" },
                    { "e41cccac-086f-40e9-8776-896ee1257572", "e41cccac-086f-40e9-8776-896ee1257572", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "72e8d25f-af54-4565-8200-9ddb9541f5a0", 0, "dbdfd127-e104-4ca6-9728-049d1dbd91d6", "sabir@gmail.com", true, "SabirMehdiyev", false, false, null, "SABIR@GMAIL.COM", "SABIR1", "AQAAAAEAACcQAAAAEDB1dmWkympLehE0DHHG6w0f0AN6FpMF6DJXwusyL5IUKpRw7SQHwMWzzOx1JRd5Ow==", null, false, "a0958d08-3e32-4b48-afe4-22c9bdbe9dcc", false, "Sabir1" },
                    { "97694b55-0e50-4aa1-90e1-c558fef3fcff", 0, "64ab3ad0-c56b-49c0-a33a-83188df43011", "sabirsm@code.edu.az", false, "SabirMehdi", false, false, null, "SABIRSM@CODE.EDU.AZ", "SABIRCODE", "AQAAAAEAACcQAAAAEJyiYpfpQfjEwi7vwMCj8SQSEqqbKisFsacwvTxJvcRw7gfbtCXgkHUfLSFTunzDUw==", null, false, "44bf6b26-d287-4bb6-b122-7d5a7fa8329b", false, "Sabircode" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ba5177e8-f196-4978-89ed-7ac00a3801d8", "72e8d25f-af54-4565-8200-9ddb9541f5a0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e41cccac-086f-40e9-8776-896ee1257572", "97694b55-0e50-4aa1-90e1-c558fef3fcff" });
        }
    }
}
