using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Noticeboard.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "vacancies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "fsdfkmswedfmkles sdffsdfdasfswde.", "Software developer" });

            migrationBuilder.InsertData(
                table: "vacancies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "asfklnafnaejklf vsdnfgvdlskfcav .", "Software Analyst" });

            migrationBuilder.InsertData(
                table: "vacancies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, " Taasfafn ijafnbead asdashfa.", "Business Analyst" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "vacancies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "vacancies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "vacancies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
