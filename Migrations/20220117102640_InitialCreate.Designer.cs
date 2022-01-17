﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tiempo.Models;

namespace Tiempo.Migrations
{
    [DbContext(typeof(TiempoContext))]
    [Migration("20220117102640_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Tiempo.Tiempo", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("GpxX")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GpxY")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Humedad")
                        .HasColumnType("int");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precipitaciones")
                        .HasColumnType("int");

                    b.Property<string>("Provincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Temperatura")
                        .HasColumnType("int");

                    b.Property<int>("VelViento")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Tiempo");
                });
#pragma warning restore 612, 618
        }
    }
}
