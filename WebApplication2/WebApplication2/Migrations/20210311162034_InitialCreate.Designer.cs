﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.DBContexts;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20210311162034_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Description = "Electronic Items", Name = "Electronics" },
                        new { Id = 2, Description = "Dresses", Name = "Clothes" },
                        new { Id = 3, Description = "Grocery Items", Name = "Grocery" }
                    );
                });

            modelBuilder.Entity("WebApplication1.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, CategoryId = 1, Description = "Electronic Items", Name = "Computer", Price = 1000m },
                        new { Id = 2, CategoryId = 1, Description = "Electronic Items", Name = "Smartphone", Price = 500m },
                        new { Id = 3, CategoryId = 2, Description = "Clothes items", Name = "Camicia", Price = 25m }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
