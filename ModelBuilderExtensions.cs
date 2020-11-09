using DeserializeIssue.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DeserializeIssue
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Console.WriteLine("Seeding database...");

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, PersonProp = "PersonProp Student 1", StudentProp = "StudentProp 1" }
            );
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 2, PersonProp = "PersonProp Teacher 1", TeacherProp = "TeacherProp 2" }
            );
            modelBuilder.Entity<Article>().HasData(
                new Article
                {
                    Id = 1,
                    ArticleProp = "ArticleProp 1",
                    AuthorId = 1
                }
            );
            modelBuilder.Entity<Article>().HasData(
                new Article
                {
                    Id = 2,
                    ArticleProp = "ArticleProp 2",
                    AuthorId = 2
                }
            );

            Console.WriteLine("Done seeding database.");
        }
    }
}
