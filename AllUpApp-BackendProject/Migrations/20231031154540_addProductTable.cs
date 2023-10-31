using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllUpApp_BackendProject.Migrations
{
    public partial class addProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "money", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    MainImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExTax = table.Column<double>(type: "float", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    IsNewArrival = table.Column<bool>(type: "bit", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    IsBestSeller = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTags_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_ProductId",
                table: "ProductTags",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagId",
                table: "ProductTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Brands");

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
    }
}
