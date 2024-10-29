using Microsoft.EntityFrameworkCore;
using Pratik_Survivor.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Pratik_Survivor.Data
{
    public class SurvivorDbContext : DbContext
    {
        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Competitor> Competitors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competitor>()
                        .HasOne(c => c.Category)
                        .WithMany(c => c.Competitors)
                        .HasForeignKey(c => c.CategoryId);
        }

    }
}
