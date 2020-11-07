using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleNetBlog.Migrations
{
    public partial class azure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 7, 0, 23, 22, 130, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 7, 0, 23, 22, 138, DateTimeKind.Local).AddTicks(5234));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 6, 21, 30, 18, 76, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 6, 21, 30, 18, 85, DateTimeKind.Local).AddTicks(809));
        }
    }
}
