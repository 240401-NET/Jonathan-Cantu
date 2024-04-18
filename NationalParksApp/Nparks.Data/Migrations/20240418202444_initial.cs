using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nparks.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BucketListParks",
                columns: table => new
                {
                    bucket_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    nationalPark_id = table.Column<int>(type: "int", nullable: true),
                    special_notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bucket_list_item = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "nationalParks",
                columns: table => new
                {
                    nationalPark_id = table.Column<int>(type: "int", nullable: false),
                    nationalPark_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nationalPark_state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nationalPark_summary = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserTable",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false),
                    user_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    admin_privilege = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BucketListParks");

            migrationBuilder.DropTable(
                name: "nationalParks");

            migrationBuilder.DropTable(
                name: "UserTable");
        }
    }
}
