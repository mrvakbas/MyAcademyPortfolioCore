﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Web.Migrations
{
    /// <inheritdoc />
    public partial class socialMedia_entity_added3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_socialMedias",
                table: "socialMedias");

            migrationBuilder.RenameTable(
                name: "socialMedias",
                newName: "SocialMedias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialMedias",
                table: "SocialMedias",
                column: "SocialMediaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialMedias",
                table: "SocialMedias");

            migrationBuilder.RenameTable(
                name: "SocialMedias",
                newName: "socialMedias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_socialMedias",
                table: "socialMedias",
                column: "SocialMediaID");
        }
    }
}
