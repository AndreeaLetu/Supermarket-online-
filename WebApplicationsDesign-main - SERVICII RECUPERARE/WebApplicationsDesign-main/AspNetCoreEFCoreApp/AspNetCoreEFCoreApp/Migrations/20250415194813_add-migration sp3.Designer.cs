﻿// <auto-generated />
using System;
using AspNetCoreEFCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetCoreEFCoreApp.Migrations
{
    [DbContext(typeof(SupermarketContext))]
    [Migration("20250415194813_add-migration sp3")]
    partial class addmigrationsp3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Basket", b =>
                {
                    b.Property<int>("Id_Basket")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Basket"));

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Total_Price")
                        .HasColumnType("int");

                    b.HasKey("Id_Basket");

                    b.ToTable("Basket");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.BasketDetails", b =>
                {
                    b.Property<int>("Id_Product")
                        .HasColumnType("int");

                    b.Property<int>("Id_Basket")
                        .HasColumnType("int");

                    b.HasKey("Id_Product", "Id_Basket");

                    b.HasIndex("Id_Basket");

                    b.ToTable("BasketDetails");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Categories", b =>
                {
                    b.Property<int>("Id_Categories")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Categories"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Categories")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Categories");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Feedback", b =>
                {
                    b.Property<int>("Id_Feedback")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Feedback"));

                    b.Property<int>("CNP")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Full")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Feedback");

                    b.HasIndex("CNP");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Order_Details", b =>
                {
                    b.Property<int>("Id_Order")
                        .HasColumnType("int");

                    b.Property<int>("Id_Product")
                        .HasColumnType("int");

                    b.HasKey("Id_Order", "Id_Product");

                    b.HasIndex("Id_Product");

                    b.ToTable("Order_Details");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Orders", b =>
                {
                    b.Property<int>("Id_Order")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CNP_Client")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total_Price")
                        .HasColumnType("int");

                    b.Property<int>("UsersCNP")
                        .HasColumnType("int");

                    b.HasKey("Id_Order");

                    b.HasIndex("UsersCNP");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Products", b =>
                {
                    b.Property<int>("Id_Product")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Product"));

                    b.Property<string>("Description_Product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Categories")
                        .HasColumnType("int");

                    b.Property<string>("Image_Product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price_Product")
                        .HasColumnType("int");

                    b.HasKey("Id_Product");

                    b.HasIndex("Id_Categories");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.PromoPackets", b =>
                {
                    b.Property<int>("Id_Product")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Product"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo_Pack")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price_Packet")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type_Pack")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Product");

                    b.ToTable("PromoPackets");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.PromoPackets_Products", b =>
                {
                    b.Property<int>("Id_Packet")
                        .HasColumnType("int");

                    b.Property<int>("Id_Product")
                        .HasColumnType("int");

                    b.HasKey("Id_Packet", "Id_Product");

                    b.HasIndex("Id_Product");

                    b.ToTable("PromoPackets_Products");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Users", b =>
                {
                    b.Property<int>("CNP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CNP"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("born_date")
                        .HasColumnType("datetime2");

                    b.HasKey("CNP");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.BasketDetails", b =>
                {
                    b.HasOne("AspNetCoreEFCoreApp.Models.Basket", "Basket")
                        .WithMany("BasketDetails")
                        .HasForeignKey("Id_Basket")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetCoreEFCoreApp.Models.Products", "Products")
                        .WithMany("BasketDetails")
                        .HasForeignKey("Id_Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Feedback", b =>
                {
                    b.HasOne("AspNetCoreEFCoreApp.Models.Users", "Users")
                        .WithMany("Feedbacks")
                        .HasForeignKey("CNP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Order_Details", b =>
                {
                    b.HasOne("AspNetCoreEFCoreApp.Models.Orders", "Orders")
                        .WithMany("Order_Details")
                        .HasForeignKey("Id_Order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetCoreEFCoreApp.Models.Products", "Products")
                        .WithMany("Order_Details")
                        .HasForeignKey("Id_Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Orders", b =>
                {
                    b.HasOne("AspNetCoreEFCoreApp.Models.Basket", "Basket")
                        .WithOne("Orders")
                        .HasForeignKey("AspNetCoreEFCoreApp.Models.Orders", "Id_Order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetCoreEFCoreApp.Models.Users", "Users")
                        .WithMany("Orders")
                        .HasForeignKey("UsersCNP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Products", b =>
                {
                    b.HasOne("AspNetCoreEFCoreApp.Models.Categories", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("Id_Categories")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.PromoPackets_Products", b =>
                {
                    b.HasOne("AspNetCoreEFCoreApp.Models.PromoPackets", "PromoPackets")
                        .WithMany("PromoPackets_Products")
                        .HasForeignKey("Id_Packet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetCoreEFCoreApp.Models.Products", "Products")
                        .WithMany("PromoPackets_Products")
                        .HasForeignKey("Id_Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");

                    b.Navigation("PromoPackets");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Basket", b =>
                {
                    b.Navigation("BasketDetails");

                    b.Navigation("Orders")
                        .IsRequired();
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Orders", b =>
                {
                    b.Navigation("Order_Details");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Products", b =>
                {
                    b.Navigation("BasketDetails");

                    b.Navigation("Order_Details");

                    b.Navigation("PromoPackets_Products");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.PromoPackets", b =>
                {
                    b.Navigation("PromoPackets_Products");
                });

            modelBuilder.Entity("AspNetCoreEFCoreApp.Models.Users", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
