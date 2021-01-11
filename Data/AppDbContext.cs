using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueModas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(p => p.name)
                .HasMaxLength(50);

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category { Id = 1, name = "Cat1", type = "type1" },
                    new Category { Id = 2, name = "Cat2", type = "type2" },
                    new Category { Id = 3, name = "Cat3", type = "type3" }
                );
        }

    }
}
