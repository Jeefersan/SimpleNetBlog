using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleNetBlog.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 6, 15, 16, 21, 645, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 6, 15, 16, 21, 653, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 6, 15, 16, 21, 653, DateTimeKind.Local).AddTicks(775));
        }
    }
}
