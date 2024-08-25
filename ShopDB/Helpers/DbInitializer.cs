using Microsoft.EntityFrameworkCore;
using ShopDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDB.Helpers
{
    public static class DbInitializer
    {
        public static void SeedPositions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Positions>().HasData(
                new Positions[]
                {
                    new Positions()
                    {
                        Id = 1,
                        Name = "Manager"
                    },
                    new Positions()
                    {
                        Id = 2,
                        Name = "Seller"
                    },
                });
        }
        public static void SeedWorkers(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Workers>().HasData(
                new Workers[]
                {
                    new Workers()
                    {
                        Id = 1,
                        Name = "Olesya",
                        Surname = "Kovalenco",
                        Salary = 22000,
                        Email = "Olesya1987@gmail.com",
                        PhoneNumber = "1234567890",
                        PositionId = 1,
                        ShopId = 1
                    },
                    new Workers()
                    {
                        Id = 2,
                        Name = "Maria",
                        Surname = "Lyashcyk",
                        Salary = 12000,
                        Email = "MarisBest@gmail.com",
                        PhoneNumber = "1234567890",
                        PositionId = 2,
                        ShopId = 1
                    },
                    new Workers()
                    {
                        Id = 3,
                        Name = "Oleg",
                        Surname = "Kovalenco",
                        Salary = 15000,
                        Email = "OlegWowk@gmail.com",
                        PhoneNumber = "1234567890",
                        PositionId = 2,
                        ShopId = 2
                    }
                });
        }
        public static void SeedShops(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shops>().HasData(
                new Shops[]
                {
                    new Shops() {
                        Id = 1,
                        Name="ATB",
                        Address="Soborna 414",
                        CityId = 1,
                        ParkingArea = 45
                    },
                    new Shops() {
                        Id = 2,
                        Name="Producty",
                        Address="Soborna 12",
                        CityId = 1,
                        ParkingArea = 90
                    },
                    new Shops() {
                        Id = 3,
                        Name="Welmart",
                        Address="Soborna",
                        CityId = 2
                    }
                });
        }
        public static void SeedCities(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cities>().HasData(
                new Cities[]
                {
                    new Cities()
                    {
                        Id = 1,
                        Name = "Rivne",
                        CountryId = 1,
                    },
                    new Cities()
                    {
                        Id = 2,
                        Name = "Lviv",
                        CountryId = 1,
                    }
                });
        }
        public static void SeedCountries(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Countries>().HasData(
                new Countries[]
                {
                    new Countries()
                    {
                        Id= 1,
                        Name = "Ukraine"
                    },
                    new Countries() {
                        Id= 2,
                        Name = "Spain"
                    }
                });
        }
        public static void SeedCategories(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Categories>().HasData(
                new Categories[]
                {
                    new Categories() 
                    {
                        Id = 1,
                        Name = "Bakery"
                    },
                    new Categories()
                    {
                        Id = 2,
                        Name = "Diary"
                    },
                    new Categories()
                    {
                        Id = 3,
                        Name = "Fish"
                    },
                    new Categories()
                    {
                        Id = 4,
                        Name = "Sweet"
                    },
                    new Categories()
                    {
                        Id = 5,
                        Name = "Meat"
                    },
                 });
        }
        public static void SeedProducts(this ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Products>().HasData(
                new Products[]
                {
                    new Products()
                    {
                        Id = 1,
                        Name = "Bread",
                        Price = 35,
                        Discount = 0,
                        CategoryId = 1,
                        Quantity = 30,
                        IsInStock = true,
                    },
                    new Products()
                    {
                        Id = 2,
                        Name = "Baguette",
                        Price = 50,
                        Discount = 0,
                        CategoryId = 1,
                        Quantity = 20,
                        IsInStock = true,
                    },
                    new Products()
                    {
                        Id = 3,
                        Name = "Milk",
                        Price = 50,
                        Discount = 0,
                        CategoryId = 2,
                        Quantity = 20,
                        IsInStock = true,
                    },
                    new Products()
                    {
                        Id = 4,
                        Name = "Yogurt",
                        Price = 60,
                        Discount = 0,
                        CategoryId = 2,
                        Quantity = 40,
                        IsInStock = true,
                    },
                    new Products()
                    {
                        Id = 5,
                        Name = "Perch",//окунь
                        Price = 60,
                        Discount = 0,
                        CategoryId = 3,
                        Quantity = 10,
                        IsInStock = true,
                    },
                    new Products()
                    {
                        Id = 6,
                        Name = "Mutton",
                        Price = 80,
                        Discount = 0,
                        CategoryId = 5,
                        Quantity = 0,
                        IsInStock = false,
                    },
                    new Products()
                    {
                        Id = 7,
                        Name = "Beef",
                        Price = 60,
                        Discount = 0,
                        CategoryId = 5,
                        Quantity = 10,
                        IsInStock = true,
                    },
                    new Products()
                    {
                        Id = 8,
                        Name = "Cake",
                        Price = 300,
                        Discount = 0,
                        CategoryId = 4,
                        Quantity = 10,
                        IsInStock = true,
                    },
                    new Products()
                    {
                        Id = 9,
                        Name = "Pancakes",
                        Price = 120,
                        Discount = 0,
                        CategoryId = 4,
                        Quantity = 15,
                        IsInStock = true,
                    },


                });

        }

    }
}
