﻿// <auto-generated />
using Master;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Master.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210712085254_Order")]
    partial class Order
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Master.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("DiscountId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            id = 1,
                            DiscountId = 1,
                            UserId = 1
                        },
                        new
                        {
                            id = 2,
                            DiscountId = 2,
                            UserId = 2
                        },
                        new
                        {
                            id = 3,
                            DiscountId = 3,
                            UserId = 3
                        },
                        new
                        {
                            id = 4,
                            DiscountId = 1,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("Master.CartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CartId = 1,
                            Count = 2,
                            ProductId = 1
                        },
                        new
                        {
                            id = 2,
                            CartId = 1,
                            Count = 3,
                            ProductId = 5
                        },
                        new
                        {
                            id = 3,
                            CartId = 2,
                            Count = 1,
                            ProductId = 4
                        },
                        new
                        {
                            id = 4,
                            CartId = 3,
                            Count = 5,
                            ProductId = 2
                        },
                        new
                        {
                            id = 5,
                            CartId = 3,
                            Count = 1,
                            ProductId = 1
                        },
                        new
                        {
                            id = 6,
                            CartId = 4,
                            Count = 6,
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("Master.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Name = "Smartphone"
                        },
                        new
                        {
                            id = 2,
                            Name = "PC"
                        },
                        new
                        {
                            id = 3,
                            Name = "Smartwatch"
                        });
                });

            modelBuilder.Entity("Master.Discount", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Discounts");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Value = 10
                        },
                        new
                        {
                            id = 2,
                            Value = 20
                        },
                        new
                        {
                            id = 3,
                            Value = 5
                        });
                });

            modelBuilder.Entity("Master.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("DiscountId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            id = 1,
                            DiscountId = 1,
                            Total = 500m,
                            UserId = 1
                        },
                        new
                        {
                            id = 2,
                            DiscountId = 3,
                            Total = 1700m,
                            UserId = 2
                        },
                        new
                        {
                            id = 3,
                            DiscountId = 3,
                            Total = 800m,
                            UserId = 3
                        },
                        new
                        {
                            id = 4,
                            DiscountId = 2,
                            Total = 1700m,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("Master.OrderItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Count = 1,
                            OrderId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            id = 2,
                            Count = 5,
                            OrderId = 2,
                            ProductId = 5
                        },
                        new
                        {
                            id = 3,
                            Count = 3,
                            OrderId = 3,
                            ProductId = 2
                        },
                        new
                        {
                            id = 4,
                            Count = 2,
                            OrderId = 4,
                            ProductId = 1
                        });
                });

            modelBuilder.Entity("Master.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CategoryId = 1,
                            Name = "iPhone XR",
                            Price = 800
                        },
                        new
                        {
                            id = 2,
                            CategoryId = 1,
                            Name = "Xiaomi MI 3",
                            Price = 349
                        },
                        new
                        {
                            id = 3,
                            CategoryId = 2,
                            Name = "Lenovo ideaPad500",
                            Price = 990
                        },
                        new
                        {
                            id = 4,
                            CategoryId = 2,
                            Name = "iMac Pro",
                            Price = 2500
                        },
                        new
                        {
                            id = 5,
                            CategoryId = 3,
                            Name = "AppleWatch 6",
                            Price = 400
                        });
                });

            modelBuilder.Entity("Master.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Age = 17,
                            Email = "JhonSnow@wolf.com",
                            FirstName = "Jhon",
                            LastName = "Snow"
                        },
                        new
                        {
                            id = 2,
                            Age = 3,
                            Email = "Cersei123@lion.com",
                            FirstName = "Cersei",
                            LastName = "Lannister"
                        },
                        new
                        {
                            id = 3,
                            Age = 45,
                            Email = "RobKing2008@deer.com",
                            FirstName = "Robert",
                            LastName = "Baratheon"
                        },
                        new
                        {
                            id = 4,
                            Age = 18,
                            Email = "Teon777@fish.com",
                            FirstName = "Teon",
                            LastName = "greyjoy"
                        });
                });

            modelBuilder.Entity("Master.UserAddress", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("UserId");

                    b.ToTable("UserAddresses");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Address = "Chkalova str",
                            City = "Tirana",
                            CountryCode = "355",
                            PhoneNumber = "+12345678",
                            UserId = 1
                        },
                        new
                        {
                            id = 2,
                            Address = "Chkalova str",
                            City = "New York",
                            CountryCode = "1",
                            PhoneNumber = "+975139234",
                            State = "New York",
                            UserId = 2
                        },
                        new
                        {
                            id = 3,
                            Address = "Pavlova str",
                            City = "Los Angeles",
                            CountryCode = "1",
                            PhoneNumber = "983508753",
                            State = "California",
                            UserId = 2
                        },
                        new
                        {
                            id = 4,
                            Address = "Shevchnko str",
                            City = "Odessa",
                            CountryCode = "38",
                            PhoneNumber = "983280361",
                            UserId = 3
                        },
                        new
                        {
                            id = 5,
                            Address = "Lenina str",
                            City = "Sochi",
                            CountryCode = "7",
                            PhoneNumber = "977513518",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("Master.Cart", b =>
                {
                    b.HasOne("Master.Discount", "Discount")
                        .WithMany()
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Master.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discount");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Master.CartItem", b =>
                {
                    b.HasOne("Master.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Master.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Master.Order", b =>
                {
                    b.HasOne("Master.Discount", "Discount")
                        .WithMany()
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Master.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discount");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Master.OrderItem", b =>
                {
                    b.HasOne("Master.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Master.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Master.Product", b =>
                {
                    b.HasOne("Master.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Master.UserAddress", b =>
                {
                    b.HasOne("Master.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
