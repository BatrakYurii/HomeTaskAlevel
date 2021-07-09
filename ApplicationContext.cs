using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;


namespace Master
{
    class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =localhost;Database=Consumer2;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<User>()
                .HasData
                (
                    new List<User>
                    {
                        new User()
                        {
                            FirstName="Jhon",LastName="Snow", Email="JhonSnow@wolf.com",Age=17,id=1
                        },
                        new User()
                        {
                            FirstName="Cersei",LastName="Lannister", Email="Cersei123@lion.com",Age=3,id=2
                        },
                        new User()
                        {
                            FirstName="Robert",LastName="Baratheon", Email="RobKing2008@deer.com",Age=45,id=3
                        },
                        new User()
                        {
                            FirstName="Teon",LastName="greyjoy", Email="Teon777@fish.com",Age=18,id=4
                        },
                    }

                );

            modelbuilder.Entity<Product>()
                .HasData
                (
                    new List<Product>
                    {
                        new Product()
                        {
                            Name="iPhone XR",Price=800,CategoryId=1,id=1
                        },
                        new Product()
                        {
                            Name="Xiaomi MI 3",Price=349,CategoryId=1,id=2
                        },
                        new Product()
                        {
                            Name="Lenovo ideaPad500",Price=990,CategoryId=2,id=3
                        },
                        new Product()
                        {
                            Name="iMac Pro",Price=2500,CategoryId=2,id=4
                        },
                        new Product()
                        {
                            Name="AppleWatch 6",Price=400,CategoryId=3,id=5
                        },
                    }
                ) ;
            modelbuilder.Entity<Category>()
                .HasData
                (
                    new List<Category>
                    {
                        new Category
                        {
                            Name="Smartphone",id=1
                        },
                        new Category
                        {
                            Name="PC",id=2
                        },
                        new Category
                        {
                            Name="Smartwatch",id=3
                        }
                    }
                );

            modelbuilder.Entity<Cart>().HasData
                (
                    new List<Cart>
                    {
                        new Cart
                        {
                            UserId=1,DiscountId=1,id=1
                        },
                        new Cart
                        {
                            UserId=2,DiscountId=2,id=2
                        },
                        new Cart
                        {
                            UserId=3,DiscountId=3,id=3
                        },
                        new Cart
                        {
                            UserId=4,DiscountId=1,id=4
                        }
                    }
                );
            
            modelbuilder.Entity<Cart>()
                .HasIndex(c => c.UserId)
                .IsUnique();

            modelbuilder.Entity<Discount>()
                .HasData
                (
                    new List<Discount>
                    {
                        new Discount
                        {
                            Value=10,id=1
                        },
                        new Discount
                        {
                            Value=20,id=2
                        },
                        new Discount
                        {
                            Value=5,id=3
                        }
                    }
                );
            modelbuilder.Entity<UserAddress>()
                .HasData
                (
                    new List<UserAddress>
                    {
                        new UserAddress
                        {
                            UserId=1,CountryCode="355",City="Tirana",Address="Chkalova str",PhoneNumber="+12345678",id=1
                        },
                        new UserAddress
                        {
                            UserId=2,CountryCode="1",State="New York",City="New York",Address="Chkalova str",PhoneNumber="+975139234",id=2
                        },
                        new UserAddress
                        {
                            UserId=2,CountryCode="1",State="California",City="Los Angeles",Address="Pavlova str",PhoneNumber="983508753",id=3
                        },
                        new UserAddress
                        {
                            UserId=3,CountryCode="38",City="Odessa",Address="Shevchnko str",PhoneNumber="983280361",id=4
                        } ,  
                        new UserAddress
                        {
                            UserId=4,CountryCode="7",City="Sochi",Address="Lenina str",PhoneNumber="977513518",id=5
                        }
                    }
                );
            modelbuilder.Entity<CartItem>()
                .HasData
                (
                    new List<CartItem>
                    {
                        new CartItem
                        {
                            CartId=1,ProductId=1,Count=2,id=1
                        },
                        new CartItem
                        {
                            CartId=1,ProductId=5,Count=3,id=2
                        },
                        new CartItem
                        {
                            CartId=2,ProductId=4,Count=1,id=3
                        },
                        new CartItem
                        {
                            CartId=3,ProductId=2,Count=5,id=4
                        },
                        new CartItem
                        {
                            CartId=3,ProductId=1,Count=1,id=5
                        },
                        new CartItem
                        {
                            CartId=4,ProductId=3,Count=6,id=6
                        }
                    }
                );
        }


    }
}
