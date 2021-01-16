using AtaliTicaret.DataAccess.Concrete.EntityFramework.Mapping;
using AtaliTicaret.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtaliTicaret.DataAccess.Concrete.EntityFramework
{
    public class AtaliTicaretContext:DbContext
    {

        private const string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=AtaliTicaretDb;Trusted_Connection=True;MultipleActiveResultSets=true";

        public AtaliTicaretContext(DbContextOptions<AtaliTicaretContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dealer> Dealers { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Dealer>().HasMany(c => c.Products).WithOne(c => c.Dealer).HasForeignKey(c => c.DealerId);

            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new DealerMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
        }
    }
}
