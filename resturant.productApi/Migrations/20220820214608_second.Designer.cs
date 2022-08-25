﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using resturant.productApi.DbContexts;

#nullable disable

namespace resturant.productApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220820214608_second")]
    partial class second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.7.22376.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("resturant.productApi.Models.Dto.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 4,
                            CategoryName = "Category1",
                            Description = "dddd hhhhh dddd fffff",
                            ImgUrl = "/images/4.jpg",
                            Name = "sama",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryName = "Category2",
                            Description = "dddd hhhhh dddd fffff",
                            ImgUrl = "/images/1.jpg",
                            Name = "rewan",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryName = "Category3",
                            Description = "dddd hhhhh dddd fffff",
                            ImgUrl = "/images/2.jpg",
                            Name = "menna",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryName = "Category4",
                            Description = "dddd hhhhh dddd fffff",
                            ImgUrl = "/images/3.jpg",
                            Name = "ahmed",
                            Price = 15.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}