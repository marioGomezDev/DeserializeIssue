using DeserializeIssue.Models;
using Microsoft.EntityFrameworkCore;

namespace DeserializeIssue
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .ToTable("Persons")
                .HasDiscriminator<int>("Type")
                .HasValue<Student>(1)
                .HasValue<Teacher>(2);

            modelBuilder.Entity<Article>()
                .HasOne(t => t.Author)
                .WithMany()
                .HasForeignKey(a => a.AuthorId);

            modelBuilder.Seed();
        }
    }
}
