using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kaizen.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddTimeSlots : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TimeSlot",
                columns: new[] { "Id", "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 9, 0, 0, 0), 1, new TimeSpan(0, 9, 45, 0, 0) },
                    { 2, new TimeSpan(0, 9, 0, 0, 0), 1, new TimeSpan(0, 9, 45, 0, 0) },
                    { 3, new TimeSpan(0, 9, 55, 0, 0), 1, new TimeSpan(0, 10, 40, 0, 0) },
                    { 4, new TimeSpan(0, 10, 50, 0, 0), 1, new TimeSpan(0, 11, 35, 0, 0) },
                    { 5, new TimeSpan(0, 11, 45, 0, 0), 1, new TimeSpan(0, 12, 30, 0, 0) },
                    { 6, new TimeSpan(0, 13, 0, 0, 0), 1, new TimeSpan(0, 13, 45, 0, 0) },
                    { 7, new TimeSpan(0, 13, 50, 0, 0), 1, new TimeSpan(0, 14, 35, 0, 0) },
                    { 8, new TimeSpan(0, 14, 35, 0, 0), 1, new TimeSpan(0, 15, 20, 0, 0) },
                    { 9, new TimeSpan(0, 9, 0, 0, 0), 2, new TimeSpan(0, 9, 45, 0, 0) },
                    { 10, new TimeSpan(0, 9, 0, 0, 0), 2, new TimeSpan(0, 9, 45, 0, 0) },
                    { 11, new TimeSpan(0, 9, 55, 0, 0), 2, new TimeSpan(0, 10, 40, 0, 0) },
                    { 12, new TimeSpan(0, 10, 50, 0, 0), 2, new TimeSpan(0, 11, 35, 0, 0) },
                    { 13, new TimeSpan(0, 11, 45, 0, 0), 2, new TimeSpan(0, 12, 30, 0, 0) },
                    { 14, new TimeSpan(0, 13, 0, 0, 0), 2, new TimeSpan(0, 13, 45, 0, 0) },
                    { 15, new TimeSpan(0, 13, 50, 0, 0), 2, new TimeSpan(0, 14, 35, 0, 0) },
                    { 16, new TimeSpan(0, 14, 35, 0, 0), 2, new TimeSpan(0, 15, 20, 0, 0) },
                    { 17, new TimeSpan(0, 9, 0, 0, 0), 3, new TimeSpan(0, 9, 45, 0, 0) },
                    { 18, new TimeSpan(0, 9, 0, 0, 0), 3, new TimeSpan(0, 9, 45, 0, 0) },
                    { 19, new TimeSpan(0, 9, 55, 0, 0), 3, new TimeSpan(0, 10, 40, 0, 0) },
                    { 20, new TimeSpan(0, 10, 50, 0, 0), 3, new TimeSpan(0, 11, 35, 0, 0) },
                    { 21, new TimeSpan(0, 11, 45, 0, 0), 3, new TimeSpan(0, 12, 30, 0, 0) },
                    { 22, new TimeSpan(0, 13, 0, 0, 0), 3, new TimeSpan(0, 13, 45, 0, 0) },
                    { 23, new TimeSpan(0, 13, 50, 0, 0), 3, new TimeSpan(0, 14, 35, 0, 0) },
                    { 24, new TimeSpan(0, 14, 35, 0, 0), 3, new TimeSpan(0, 15, 20, 0, 0) },
                    { 25, new TimeSpan(0, 9, 0, 0, 0), 4, new TimeSpan(0, 9, 45, 0, 0) },
                    { 26, new TimeSpan(0, 9, 0, 0, 0), 4, new TimeSpan(0, 9, 45, 0, 0) },
                    { 27, new TimeSpan(0, 9, 55, 0, 0), 4, new TimeSpan(0, 10, 40, 0, 0) },
                    { 28, new TimeSpan(0, 10, 50, 0, 0), 4, new TimeSpan(0, 11, 35, 0, 0) },
                    { 29, new TimeSpan(0, 11, 45, 0, 0), 4, new TimeSpan(0, 12, 30, 0, 0) },
                    { 30, new TimeSpan(0, 13, 0, 0, 0), 4, new TimeSpan(0, 13, 45, 0, 0) },
                    { 31, new TimeSpan(0, 13, 50, 0, 0), 4, new TimeSpan(0, 14, 35, 0, 0) },
                    { 32, new TimeSpan(0, 14, 35, 0, 0), 4, new TimeSpan(0, 15, 20, 0, 0) },
                    { 33, new TimeSpan(0, 9, 0, 0, 0), 5, new TimeSpan(0, 9, 45, 0, 0) },
                    { 34, new TimeSpan(0, 9, 0, 0, 0), 5, new TimeSpan(0, 9, 45, 0, 0) },
                    { 35, new TimeSpan(0, 9, 55, 0, 0), 5, new TimeSpan(0, 10, 40, 0, 0) },
                    { 36, new TimeSpan(0, 10, 50, 0, 0), 5, new TimeSpan(0, 11, 35, 0, 0) },
                    { 37, new TimeSpan(0, 11, 45, 0, 0), 5, new TimeSpan(0, 12, 30, 0, 0) },
                    { 38, new TimeSpan(0, 13, 0, 0, 0), 5, new TimeSpan(0, 13, 45, 0, 0) },
                    { 39, new TimeSpan(0, 13, 50, 0, 0), 5, new TimeSpan(0, 14, 35, 0, 0) },
                    { 40, new TimeSpan(0, 14, 35, 0, 0), 5, new TimeSpan(0, 15, 20, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TimeSlot",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}
