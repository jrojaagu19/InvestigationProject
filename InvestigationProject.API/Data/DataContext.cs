using Microsoft.EntityFrameworkCore;
using InvestigationProject.Shared.Entities;

namespace InvestigationProject.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Investigationproject> InvestigationProjects { get; set; }


        public DbSet<Investigator> Investigators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Investigationproject>().HasIndex(c => c.NameProject).IsUnique();
        }

    }
}