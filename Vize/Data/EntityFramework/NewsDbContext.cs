using Microsoft.EntityFrameworkCore;
using Vize.Models;
using Vize.Models.DTOs;

namespace Vize.Data.EntityFramework
{
    public class NewsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=DatabaseForVize;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<News> News { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<NewsWithAllColumn> NewsAll { get; set; }
    }
}
