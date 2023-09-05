using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightBooking.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangedUserPropertyMIgration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailConfirmed",
                table: "Users",
                newName: "IsEmailConfirmed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsEmailConfirmed",
                table: "Users",
                newName: "EmailConfirmed");
        }
    }
}
