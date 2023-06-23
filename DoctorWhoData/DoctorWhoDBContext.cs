using Microsoft.EntityFrameworkCore;
using DoctorWhoDomain;
namespace DoctorWhoData
{
    public class DoctorWhoDBContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Episode> Episodes { get; set;}
        public DbSet<EpisodeEnemy> EpisodeEnemies { get;set; }
        public DbSet<EpisodeCompanion> EpisodeCompanions { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DoctorWhoDB"
            );
        }
    }
}