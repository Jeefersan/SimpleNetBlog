using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleNetBlog.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 6, 17, 16, 55, 748, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 6, 17, 16, 55, 756, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 6, 17, 16, 55, 756, DateTimeKind.Local).AddTicks(1069));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 6, 16, 53, 38, 105, DateTimeKind.Local).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 6, 16, 53, 38, 113, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 6, 16, 53, 38, 113, DateTimeKind.Local).AddTicks(4893));
        }
    }
}
