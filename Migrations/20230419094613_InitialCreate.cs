using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiebCWebsite.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeModel_AdminModel_AdminModelId",
                        column: x => x.AdminModelId,
                        principalTable: "AdminModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GuestModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminModelId = table.Column<int>(type: "int", nullable: true),
                    EmployeeModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuestModel_AdminModel_AdminModelId",
                        column: x => x.AdminModelId,
                        principalTable: "AdminModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GuestModel_EmployeeModel_EmployeeModelId",
                        column: x => x.EmployeeModelId,
                        principalTable: "EmployeeModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminModelId = table.Column<int>(type: "int", nullable: true),
                    EmployeeModelId = table.Column<int>(type: "int", nullable: true),
                    GuestModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookModel_AdminModel_AdminModelId",
                        column: x => x.AdminModelId,
                        principalTable: "AdminModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookModel_EmployeeModel_EmployeeModelId",
                        column: x => x.EmployeeModelId,
                        principalTable: "EmployeeModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookModel_GuestModel_GuestModelId",
                        column: x => x.GuestModelId,
                        principalTable: "GuestModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CDModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminModelId = table.Column<int>(type: "int", nullable: true),
                    EmployeeModelId = table.Column<int>(type: "int", nullable: true),
                    GuestModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CDModel_AdminModel_AdminModelId",
                        column: x => x.AdminModelId,
                        principalTable: "AdminModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CDModel_EmployeeModel_EmployeeModelId",
                        column: x => x.EmployeeModelId,
                        principalTable: "EmployeeModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CDModel_GuestModel_GuestModelId",
                        column: x => x.GuestModelId,
                        principalTable: "GuestModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminModelId = table.Column<int>(type: "int", nullable: true),
                    EmployeeModelId = table.Column<int>(type: "int", nullable: true),
                    GuestModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemModel_AdminModel_AdminModelId",
                        column: x => x.AdminModelId,
                        principalTable: "AdminModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemModel_EmployeeModel_EmployeeModelId",
                        column: x => x.EmployeeModelId,
                        principalTable: "EmployeeModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemModel_GuestModel_GuestModelId",
                        column: x => x.GuestModelId,
                        principalTable: "GuestModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MovieModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminModelId = table.Column<int>(type: "int", nullable: true),
                    EmployeeModelId = table.Column<int>(type: "int", nullable: true),
                    GuestModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieModel_AdminModel_AdminModelId",
                        column: x => x.AdminModelId,
                        principalTable: "AdminModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MovieModel_EmployeeModel_EmployeeModelId",
                        column: x => x.EmployeeModelId,
                        principalTable: "EmployeeModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MovieModel_GuestModel_GuestModelId",
                        column: x => x.GuestModelId,
                        principalTable: "GuestModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookModel_AdminModelId",
                table: "BookModel",
                column: "AdminModelId");

            migrationBuilder.CreateIndex(
                name: "IX_BookModel_EmployeeModelId",
                table: "BookModel",
                column: "EmployeeModelId");

            migrationBuilder.CreateIndex(
                name: "IX_BookModel_GuestModelId",
                table: "BookModel",
                column: "GuestModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CDModel_AdminModelId",
                table: "CDModel",
                column: "AdminModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CDModel_EmployeeModelId",
                table: "CDModel",
                column: "EmployeeModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CDModel_GuestModelId",
                table: "CDModel",
                column: "GuestModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeModel_AdminModelId",
                table: "EmployeeModel",
                column: "AdminModelId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestModel_AdminModelId",
                table: "GuestModel",
                column: "AdminModelId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestModel_EmployeeModelId",
                table: "GuestModel",
                column: "EmployeeModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemModel_AdminModelId",
                table: "ItemModel",
                column: "AdminModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemModel_EmployeeModelId",
                table: "ItemModel",
                column: "EmployeeModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemModel_GuestModelId",
                table: "ItemModel",
                column: "GuestModelId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieModel_AdminModelId",
                table: "MovieModel",
                column: "AdminModelId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieModel_EmployeeModelId",
                table: "MovieModel",
                column: "EmployeeModelId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieModel_GuestModelId",
                table: "MovieModel",
                column: "GuestModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookModel");

            migrationBuilder.DropTable(
                name: "CDModel");

            migrationBuilder.DropTable(
                name: "ItemModel");

            migrationBuilder.DropTable(
                name: "MovieModel");

            migrationBuilder.DropTable(
                name: "GuestModel");

            migrationBuilder.DropTable(
                name: "EmployeeModel");

            migrationBuilder.DropTable(
                name: "AdminModel");
        }
    }
}
