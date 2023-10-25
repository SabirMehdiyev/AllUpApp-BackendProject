using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllUpApp_BackendProject.Migrations
{
    public partial class addRolesSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
