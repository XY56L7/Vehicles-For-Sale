﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XY56L7_SOF_2022231.Data.Migrations
{
    public partial class _user_picture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "AspNetUsers");
        }
    }
}
