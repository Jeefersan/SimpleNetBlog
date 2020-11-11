using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleNetBlog.Migrations
{
    public partial class time : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 11, 16, 51, 50, 620, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 11, 11, 16, 51, 50, 621, DateTimeKind.Utc).AddTicks(9726));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
