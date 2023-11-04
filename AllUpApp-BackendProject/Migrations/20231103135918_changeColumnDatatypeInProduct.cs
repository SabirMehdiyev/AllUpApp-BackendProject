using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllUpApp_BackendProject.Migrations
{
    public partial class changeColumnDatatypeInProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "970696af-73a9-4e19-a60f-e2f8f810d28f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ec98e8b4-0689-4b16-b99f-60dd2dc7fe28", "3481617b-09a5-47bb-8ef6-fff59e12d0de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b61a9eea-2713-4e63-abf9-b5e2b98292b4", "ba1e7abb-5332-4b14-bacd-35012fff2374" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b61a9eea-2713-4e63-abf9-b5e2b98292b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec98e8b4-0689-4b16-b99f-60dd2dc7fe28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3481617b-09a5-47bb-8ef6-fff59e12d0de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba1e7abb-5332-4b14-bacd-35012fff2374");

            migrationBuilder.AlterColumn<bool>(
                name: "IsBestSeller",
                table: "Products",
                type: "bit",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "91cc3777-a63d-4f8c-b82b-cc2ed1e0361e", "91cc3777-a63d-4f8c-b82b-cc2ed1e0361e", "Admin", "ADMIN" },
                    { "d47577f5-e02f-4676-a8dc-3ec699f5d5df", "d47577f5-e02f-4676-a8dc-3ec699f5d5df", "User", "USER" },
                    { "ff9a41e4-b09c-4ac4-afe6-19e8bddafd77", "ff9a41e4-b09c-4ac4-afe6-19e8bddafd77", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8591d319-d622-4cbc-ab2d-31e1aa5fd11a", 0, "bcad00f7-63c0-4785-8cbb-f53fc7c34f73", "sabir@gmail.com", true, "SabirMehdiyev", false, false, null, "SABIR@GMAIL.COM", "SABIR1", "AQAAAAEAACcQAAAAEFlj1tMh5u8TJIXpG7nXSazlBroedfgZ9NAoAf9j0EkypvQ6bNe9zJvIh6gY/Z3SWg==", null, false, "90e6ffa1-049c-4a59-a1b5-34b714c9689b", false, "Sabir1" },
                    { "dde4166d-c696-49d4-b27c-e7e75f143ff6", 0, "a5496af5-9254-4f59-880a-3b82fcde6fcd", "sabirsm@code.edu.az", false, "SabirMehdi", false, false, null, "SABIRSM@CODE.EDU.AZ", "SABIRCODE", "AQAAAAEAACcQAAAAEKhl17lBOvLV074lkHwrKMkzabSdyKUL6EQBd6qyGSAwKrvCwEK6PQ/Erl4y3pd8xw==", null, false, "086319e6-c98b-4c32-aaf9-984826b1f0a7", false, "Sabircode" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "91cc3777-a63d-4f8c-b82b-cc2ed1e0361e", "8591d319-d622-4cbc-ab2d-31e1aa5fd11a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ff9a41e4-b09c-4ac4-afe6-19e8bddafd77", "dde4166d-c696-49d4-b27c-e7e75f143ff6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d47577f5-e02f-4676-a8dc-3ec699f5d5df");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "91cc3777-a63d-4f8c-b82b-cc2ed1e0361e", "8591d319-d622-4cbc-ab2d-31e1aa5fd11a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff9a41e4-b09c-4ac4-afe6-19e8bddafd77", "dde4166d-c696-49d4-b27c-e7e75f143ff6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91cc3777-a63d-4f8c-b82b-cc2ed1e0361e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff9a41e4-b09c-4ac4-afe6-19e8bddafd77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8591d319-d622-4cbc-ab2d-31e1aa5fd11a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dde4166d-c696-49d4-b27c-e7e75f143ff6");

            migrationBuilder.AlterColumn<double>(
                name: "IsBestSeller",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "970696af-73a9-4e19-a60f-e2f8f810d28f", "970696af-73a9-4e19-a60f-e2f8f810d28f", "User", "USER" },
                    { "b61a9eea-2713-4e63-abf9-b5e2b98292b4", "b61a9eea-2713-4e63-abf9-b5e2b98292b4", "Admin", "ADMIN" },
                    { "ec98e8b4-0689-4b16-b99f-60dd2dc7fe28", "ec98e8b4-0689-4b16-b99f-60dd2dc7fe28", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3481617b-09a5-47bb-8ef6-fff59e12d0de", 0, "f6e62834-f3dd-408b-90e3-957c0597ca47", "sabirsm@code.edu.az", false, "SabirMehdi", false, false, null, "SABIRSM@CODE.EDU.AZ", "SABIRCODE", "AQAAAAEAACcQAAAAEJWW7I/2l6o9ZrqB+Wexhiid99cd8A1UET3r8u03g+YzoxKwuEEpYOINfYNmwWQD2w==", null, false, "d1431edd-527f-48ce-81ed-9b0f32701916", false, "Sabircode" },
                    { "ba1e7abb-5332-4b14-bacd-35012fff2374", 0, "7a0d2612-8ba6-4b2c-b1fd-d4b4649969f0", "sabir@gmail.com", true, "SabirMehdiyev", false, false, null, "SABIR@GMAIL.COM", "SABIR1", "AQAAAAEAACcQAAAAEFlavxYen17+TKE/H+6lqP01K5vdKWmQLNcsR4vgV/cjLYQGgiVISSud67TRLv7WVg==", null, false, "8987ad22-31e8-4c29-b8c1-c95dd9aed905", false, "Sabir1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ec98e8b4-0689-4b16-b99f-60dd2dc7fe28", "3481617b-09a5-47bb-8ef6-fff59e12d0de" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b61a9eea-2713-4e63-abf9-b5e2b98292b4", "ba1e7abb-5332-4b14-bacd-35012fff2374" });
        }
    }
}
