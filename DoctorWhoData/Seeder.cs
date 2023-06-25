using DoctorWhoDomain;
using Microsoft.EntityFrameworkCore;

namespace DoctorWhoData
{
    internal static class Seeder
    {
        internal static void Seed(ModelBuilder modelBuilder)
        {
            SeedAuthors(modelBuilder);
           // SeedEnemy(modelBuilder);
        }
        private static void SeedAuthors(ModelBuilder modelBuilder) {
                modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, Name = "Author 1" },
                new Author { AuthorId = 2, Name = "Author 2" },
                new Author { AuthorId = 3, Name = "Author 3" },
                new Author { AuthorId = 4, Name = "Author 4" },
                new Author { AuthorId = 5, Name = "Author 5" }
            );
        }
       // private static void SeedEnemy(ModelBuilder modelBuilder) { }

    }

}