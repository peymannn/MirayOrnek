﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MirayOrnek.Data;

#nullable disable

namespace MirayOrnek.Data.Data.Migrations
{
    [DbContext(typeof(MirayDbContext))]
    partial class MirayDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MirayOrnek.Data.Entitites.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("MirayOrnek.Data.Entitites.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BasketId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tasarım Çiçek",
                            Price = 90m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Doğum Günü Çiçekleri",
                            Price = 79m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Çiçek Buketleri",
                            Price = 94m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Lilyum & Zambak",
                            Price = 108m
                        });
                });

            modelBuilder.Entity("MirayOrnek.Data.Entitites.Product", b =>
                {
                    b.HasOne("MirayOrnek.Data.Entitites.Basket", null)
                        .WithMany("Products")
                        .HasForeignKey("BasketId");
                });

            modelBuilder.Entity("MirayOrnek.Data.Entitites.Basket", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
