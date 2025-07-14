using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class FixHeThongPhanPhoiPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Person",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "TEXT",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Person",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HeThongPhanPhoi",
                columns: table => new
                {
                    MaHTPP = table.Column<string>(type: "TEXT", nullable: false),
                    TenHTPP = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeThongPhanPhoi", x => x.MaHTPP);
                });

            migrationBuilder.CreateTable(
                name: "DaiLy",
                columns: table => new
                {
                    MaDaiLy = table.Column<string>(type: "TEXT", nullable: false),
                    TenDaiLy = table.Column<string>(type: "TEXT", nullable: false),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: false),
                    NguoiDaiDien = table.Column<string>(type: "TEXT", nullable: false),
                    DienThoai = table.Column<string>(type: "TEXT", nullable: false),
                    MaHTPP = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaiLy", x => x.MaDaiLy);
                    table.ForeignKey(
                        name: "FK_DaiLy_HeThongPhanPhoi_MaHTPP",
                        column: x => x.MaHTPP,
                        principalTable: "HeThongPhanPhoi",
                        principalColumn: "MaHTPP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DaiLy_MaHTPP",
                table: "DaiLy",
                column: "MaHTPP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaiLy");

            migrationBuilder.DropTable(
                name: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Person");
        }
    }
}
