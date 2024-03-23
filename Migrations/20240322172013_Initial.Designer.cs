﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tp3_dev_csharp.DAL;

#nullable disable

namespace tp3_dev_csharp.Migrations
{
    [DbContext(typeof(InfnetDbContext))]
    [Migration("20240322172013_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Computador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Hd")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Memoria")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroPatrimonio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PlacaMae")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Processador")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Computadores");
                });
#pragma warning restore 612, 618
        }
    }
}