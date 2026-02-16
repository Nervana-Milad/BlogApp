using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SyncSyntax.Models;

namespace SyncSyntax.Data
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Technology"},
                new Category { Id = 2, Name = "Health" },
                new Category { Id = 3, Name = "LifeStyle" }
                );
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "Latest Tech Trends",
                    Content = "Content of latest technology trends.",
                    Author = "John Doe",
                    PublishedDate = new DateTime(2023, 1, 1),
                    CategoryId = 1,
                    FeatureImagePath = "tech1.jpg"
                },
                new Post
                {
                    Id = 2,
                    Title = "AI in Modern Life",
                    Content = "How artificial intelligence is changing the world.",
                    Author = "Jane Smith",
                    PublishedDate = new DateTime(2023, 2, 10),
                    CategoryId = 1,
                    FeatureImagePath = "tech2.jpg"
                },
                new Post
                {
                    Id = 3,
                    Title = "Healthy Living Tips",
                    Content = "Simple tips to live a healthier life.",
                    Author = "Dr. Ahmed",
                    PublishedDate = new DateTime(2023, 3, 5),
                    CategoryId = 2,
                    FeatureImagePath = "health1.jpg"
                },
                new Post
                {
                    Id = 4,
                    Title = "Mental Health Awareness",
                    Content = "Why mental health is as important as physical health.",
                    Author = "Sarah Ali",
                    PublishedDate = new DateTime(2023, 4, 15),
                    CategoryId = 2,
                    FeatureImagePath = "health2.jpg"
                },
                new Post
                {
                    Id = 5,
                    Title = "Work-Life Balance",
                    Content = "How to balance your work and personal life.",
                    Author = "Mohamed Hassan",
                    PublishedDate = new DateTime(2023, 5, 20),
                    CategoryId = 3,
                    FeatureImagePath = "lifestyle1.jpg"
                },
                new Post
                {
                    Id = 6,
                    Title = "Daily Habits for Success",
                    Content = "Habits that successful people follow every day.",
                    Author = "Nour Adel",
                    PublishedDate = new DateTime(2023, 6, 10),
                    CategoryId = 3,
                    FeatureImagePath = "lifestyle2.jpg"
                },
                new Post
                {
                    Id = 7,
                    Title = "Future of Technology",
                    Content = "Predictions about the future of technology.",
                    Author = "John Doe",
                    PublishedDate = new DateTime(2023, 7, 1),
                    CategoryId = 1,
                    FeatureImagePath = "tech3.jpg"
                },
                new Post
                {
                    Id = 8,
                    Title = "Tech Post 1",
                    Content = "Content of Tech Post 1",
                    Author = "John Doe",
                    PublishedDate = new DateTime(2023, 1, 1),
                    CategoryId = 1,
                    FeatureImagePath = "tech_image.jpg"
                }

                );
        }
    }
}
