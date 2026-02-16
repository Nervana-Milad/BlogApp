using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SyncSyntax.Migrations
{
    /// <inheritdoc />
    public partial class SeedingInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FeatureImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Technology" },
                    { 2, null, "Health" },
                    { 3, null, "LifeStyle" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "CategoryId", "Content", "FeatureImagePath", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, "John Doe", 1, "Content of latest technology trends.", "tech1.jpg", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latest Tech Trends" },
                    { 2, "Jane Smith", 1, "How artificial intelligence is changing the world.", "tech2.jpg", new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "AI in Modern Life" },
                    { 3, "Dr. Ahmed", 2, "Simple tips to live a healthier life.", "health1.jpg", new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthy Living Tips" },
                    { 4, "Sarah Ali", 2, "Why mental health is as important as physical health.", "health2.jpg", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mental Health Awareness" },
                    { 5, "Mohamed Hassan", 3, "How to balance your work and personal life.", "lifestyle1.jpg", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Work-Life Balance" },
                    { 6, "Nour Adel", 3, "Habits that successful people follow every day.", "lifestyle2.jpg", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daily Habits for Success" },
                    { 7, "John Doe", 1, "Predictions about the future of technology.", "tech3.jpg", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Future of Technology" },
                    { 8, "John Doe", 1, "Content of Tech Post 1", "tech_image.jpg", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tech Post 1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
