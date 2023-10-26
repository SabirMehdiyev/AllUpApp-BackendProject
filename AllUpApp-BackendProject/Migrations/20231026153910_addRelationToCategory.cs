using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllUpApp_BackendProject.Migrations
{
    public partial class addRelationToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "795d03c8-0db4-43cb-a131-1293bcae88b1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5eda4574-978a-4e86-b00b-88deb766bf6d", "9d9515db-ffb0-4a22-8443-ad1878b8ce57" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b3c84a9a-5f88-48ff-93b6-17b098c11a24", "b65c426c-a0fe-48b6-95c4-f02674eb9bf6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5eda4574-978a-4e86-b00b-88deb766bf6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3c84a9a-5f88-48ff-93b6-17b098c11a24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d9515db-ffb0-4a22-8443-ad1878b8ce57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b65c426c-a0fe-48b6-95c4-f02674eb9bf6");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5eda4574-978a-4e86-b00b-88deb766bf6d", "5eda4574-978a-4e86-b00b-88deb766bf6d", "Admin", "ADMIN" },
                    { "795d03c8-0db4-43cb-a131-1293bcae88b1", "795d03c8-0db4-43cb-a131-1293bcae88b1", "User", "USER" },
                    { "b3c84a9a-5f88-48ff-93b6-17b098c11a24", "b3c84a9a-5f88-48ff-93b6-17b098c11a24", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9d9515db-ffb0-4a22-8443-ad1878b8ce57", 0, "4742ff44-36be-4048-ad07-0dd2b5e9a27b", "sabir@gmail.com", true, "SabirMehdiyev", false, false, null, "SABIR@GMAIL.COM", "SABIR1", "AQAAAAEAACcQAAAAEEuYdxAOOIVB+/5ZDyzv0DVF4696VnlwTFqnOPr6gkQi/lEzzROZ1ksXh2hou1KXMA==", null, false, "474078b6-530e-4976-92fc-e5de44eeb7dd", false, "Sabir1" },
                    { "b65c426c-a0fe-48b6-95c4-f02674eb9bf6", 0, "b8a0ac03-426c-4e59-b8c8-8023107ed39d", "sabirsm@code.edu.az", false, "SabirMehdi", false, false, null, "SABIRSM@CODE.EDU.AZ", "SABIRCODE", "AQAAAAEAACcQAAAAEAD70959nVszjxESgqHRGS1WfFF0dNEae35XpylGAJK0Qa+4/cQbmuJS+/mIHR8pXA==", null, false, "ebf22b85-f37d-4bc1-bdd1-e2f0d0412671", false, "Sabircode" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5eda4574-978a-4e86-b00b-88deb766bf6d", "9d9515db-ffb0-4a22-8443-ad1878b8ce57" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b3c84a9a-5f88-48ff-93b6-17b098c11a24", "b65c426c-a0fe-48b6-95c4-f02674eb9bf6" });
        }
    }
}
