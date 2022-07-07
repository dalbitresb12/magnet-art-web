﻿// <auto-generated />


#nullable disable

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Starter.API.Shared.Persistence.Contexts;

namespace Starter.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Starter.API.Weather.Domain.Models.Forecast", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<string>("Summary")
                        .HasColumnType("longtext")
                        .HasColumnName("summary");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int")
                        .HasColumnName("temperature_c");

                    b.HasKey("Id")
                        .HasName("p_k_forecasts");

                    b.ToTable("forecasts", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}