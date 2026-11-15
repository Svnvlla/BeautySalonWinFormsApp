using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautySalonWinFormsApp.Migrations
{
    /// <inheritdoc />
    public partial class RenameBookedToBookedPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Booked",
                table: "Appointments",
                newName: "BookedPrice");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookedPrice",
                table: "Appointments",
                newName: "Booked");
        }
    }
}
