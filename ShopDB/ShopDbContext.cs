using Microsoft.EntityFrameworkCore;
using ShopDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDB
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext()
        {
            
        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Shops> Shops { get; set; }
        public DbSet<Workers> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


            optionsBuilder.UseSqlServer(@"Data Source = localhost\SQLEXPRESS;
                                 Initial Catalog= ShopDb;
                                 Integrated Security=true;
                                 Connect Timeout = 2;Encrypt=False;
                                 Trust Server Certificate=False;
                                 Application Intent=ReadWrite;
                                 Multi Subnet Failover=False");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Fluent API

            // positions
            modelBuilder.Entity<Positions>()
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();

            // workers
            modelBuilder.Entity<Workers>()
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Workers>()
                .Property(a => a.Surname)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Workers>()
                .Property(a => a.Salary)
                .IsRequired();
            modelBuilder.Entity<Workers>()
                .Property(a => a.Email)
                .HasMaxLength(150)
                .IsRequired();
            modelBuilder.Entity<Workers>()
                .Property(a => a.PhoneNumber)
                .HasMaxLength(100)
                .IsRequired();

            // shops
            modelBuilder.Entity<Shops>()
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Shops>()
                .Property(a => a.Address)
                .HasMaxLength(150)
                .IsRequired();

            // cities
            modelBuilder.Entity<Cities>()
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();

            // countries
            modelBuilder.Entity<Countries>()
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();

            // categories
            modelBuilder.Entity<Categories>()
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();

            // products
            modelBuilder.Entity<Products>()
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Products>()
                .Property(a => a.Price)
                .IsRequired();
            modelBuilder.Entity<Products>()
                .Property(a => a.Discount)
                .IsRequired();
            modelBuilder.Entity<Products>()
                .Property(a => a.Quantity)
                .IsRequired();
            modelBuilder.Entity<Products>()
                .Property(a => a.IsInStock)
                .IsRequired();

            //Relationship Configuration

            modelBuilder.Entity<Positions>()
                .HasMany(f => f.Workers)
                .WithOne(a => a.Position);

            modelBuilder.Entity<Workers>()
                .HasOne(w => w.Position)
                .WithMany(p => p.Workers)
                .HasForeignKey(w => w.PositionId);
            modelBuilder.Entity<Workers>()
                .HasOne(a=>a.Shop)
                .WithMany(s =>s.Workers)
                .HasForeignKey(w=>w.ShopId);

            modelBuilder.Entity<Shops>()
                .HasMany(p => p.Products)
                .WithMany(a => a.Shops);
            modelBuilder.Entity<Shops>()
                .HasMany(a => a.Workers)
                .WithOne(p => p.Shop);
            modelBuilder.Entity<Shops>()
                .HasOne(c=>c.City)
                .WithMany(s=>s.Shops)
                .HasForeignKey(s=>s.CityId);

            modelBuilder.Entity<Cities>()
                .HasOne(c => c.Country)
                .WithMany(a => a.Cities)
                .HasForeignKey(c => c.CountryId);
            modelBuilder.Entity<Cities>()
                .HasMany(s => s.Shops)
                .WithOne(c => c.City)
                .HasForeignKey(s => s.CityId);

            modelBuilder.Entity<Categories>()
                .HasMany(p=>p.Products)
                .WithOne(c=>c.Category)
                .HasForeignKey(p=>p.CategoryId);
            
            modelBuilder.Entity<Products>()
                .HasOne(p=>p.Category)
                .WithMany(a=>a.Products)
                .HasForeignKey(p=> p.CategoryId);
            modelBuilder.Entity<Products>()
                .HasMany(p => p.Shops)
                .WithMany(a => a.Products);
        }
    }
}
