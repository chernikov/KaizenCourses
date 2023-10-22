using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kaizen.Core.Migrations
{
    /// <inheritdoc />
    public partial class FixTimeSlot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 55, 0, 0), new TimeSpan(0, 10, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 10, 50, 0, 0), new TimeSpan(0, 11, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 12, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 13, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 14, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 14, 35, 0, 0), new TimeSpan(0, 15, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 0, 0, 0), 2, new TimeSpan(0, 9, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 55, 0, 0), new TimeSpan(0, 10, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 10, 50, 0, 0), new TimeSpan(0, 11, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 12, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 13, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 14, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 14, 35, 0, 0), new TimeSpan(0, 15, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 0, 0, 0), 3, new TimeSpan(0, 9, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 55, 0, 0), 3, new TimeSpan(0, 10, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 10, 50, 0, 0), new TimeSpan(0, 11, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 12, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 13, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 14, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 14, 35, 0, 0), new TimeSpan(0, 15, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 0, 0, 0), 4, new TimeSpan(0, 9, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 55, 0, 0), 4, new TimeSpan(0, 10, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 10, 50, 0, 0), 4, new TimeSpan(0, 11, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 12, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 13, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 14, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 14, 35, 0, 0), new TimeSpan(0, 15, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 0, 0, 0), 5, new TimeSpan(0, 9, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 55, 0, 0), 5, new TimeSpan(0, 10, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 10, 50, 0, 0), 5, new TimeSpan(0, 11, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 11, 45, 0, 0), 5, new TimeSpan(0, 12, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 13, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 14, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 14, 35, 0, 0), new TimeSpan(0, 15, 20, 0, 0) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 9, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 55, 0, 0), new TimeSpan(0, 10, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 10, 50, 0, 0), new TimeSpan(0, 11, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 12, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 13, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 50, 0, 0), new TimeSpan(0, 14, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 14, 35, 0, 0), 1, new TimeSpan(0, 15, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 9, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 9, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 55, 0, 0), new TimeSpan(0, 10, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 10, 50, 0, 0), new TimeSpan(0, 11, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 12, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 0, 0, 0), new TimeSpan(0, 13, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 50, 0, 0), 2, new TimeSpan(0, 14, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 14, 35, 0, 0), 2, new TimeSpan(0, 15, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 9, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 9, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 55, 0, 0), new TimeSpan(0, 10, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 10, 50, 0, 0), new TimeSpan(0, 11, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 11, 45, 0, 0), new TimeSpan(0, 12, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 0, 0, 0), 3, new TimeSpan(0, 13, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 50, 0, 0), 3, new TimeSpan(0, 14, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 14, 35, 0, 0), 3, new TimeSpan(0, 15, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 9, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 9, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 55, 0, 0), new TimeSpan(0, 10, 40, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 10, 50, 0, 0), new TimeSpan(0, 11, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 11, 45, 0, 0), 4, new TimeSpan(0, 12, 30, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 0, 0, 0), 4, new TimeSpan(0, 13, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 13, 50, 0, 0), 4, new TimeSpan(0, 14, 35, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[] { new TimeSpan(0, 14, 35, 0, 0), 4, new TimeSpan(0, 15, 20, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 9, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 9, 45, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TimeSlots",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BeginTime", "EndTime" },
                values: new object[] { new TimeSpan(0, 9, 55, 0, 0), new TimeSpan(0, 10, 40, 0, 0) });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "BeginTime", "DayOfWeek", "EndTime" },
                values: new object[,]
                {
                    { 36, new TimeSpan(0, 10, 50, 0, 0), 5, new TimeSpan(0, 11, 35, 0, 0) },
                    { 37, new TimeSpan(0, 11, 45, 0, 0), 5, new TimeSpan(0, 12, 30, 0, 0) },
                    { 38, new TimeSpan(0, 13, 0, 0, 0), 5, new TimeSpan(0, 13, 45, 0, 0) },
                    { 39, new TimeSpan(0, 13, 50, 0, 0), 5, new TimeSpan(0, 14, 35, 0, 0) },
                    { 40, new TimeSpan(0, 14, 35, 0, 0), 5, new TimeSpan(0, 15, 20, 0, 0) }
                });
        }
    }
}
