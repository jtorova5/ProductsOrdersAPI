﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsOrdersAPI.Data;

#nullable disable

namespace ProductsOrdersAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241010144328_CategorySeeders2")]
    partial class CategorySeeders2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ProductsOrdersAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Productos relacionados con tecnología y dispositivos electrónicos.",
                            Name = "Electrónica"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Artículos para la casa, desde muebles hasta decoración.",
                            Name = "Hogar"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Ropa y accesorios de última tendencia.",
                            Name = "Moda"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Equipamiento y ropa para diversas actividades deportivas.",
                            Name = "Deportes"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Productos de cuidado personal y bienestar.",
                            Name = "Salud y Belleza"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Juguetes y juegos para niños de todas las edades.",
                            Name = "Juguetes"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Accesorios y piezas para vehículos.",
                            Name = "Automotriz"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Comida y bebidas de diversas culturas.",
                            Name = "Alimentos y Bebidas"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Literatura y libros de texto en diferentes géneros.",
                            Name = "Libros"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Herramientas y productos para el cuidado del jardín.",
                            Name = "Jardinería"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
