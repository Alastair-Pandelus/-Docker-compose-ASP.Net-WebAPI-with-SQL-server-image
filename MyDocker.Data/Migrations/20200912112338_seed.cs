using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDocker.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WeatherForecasts",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "forecast 1", 11 },
                    { 2, new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "forecast 2", 12 },
                    { 3, new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "forecast 3", 14 },
                    { 4, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "forecast 4", 16 },
                    { 5, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "forecast 5", 18 },
                    { 6, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "forecast 6", 14 },
                    { 7, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "forecast 7", 12 },
                    { 8, new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "forecast 8", 9 },
                    { 9, new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "forecast 9", 7 },
                    { 10, new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "forecast 10", -1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
