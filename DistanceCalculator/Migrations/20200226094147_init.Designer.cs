﻿// <auto-generated />
using DistanceCalculator.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DistanceCalculator.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20200226094147_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DistanceCalculator.Models.GeoPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Distance")
                        .HasColumnType("float");

                    b.Property<double>("Latitude1")
                        .HasColumnType("float");

                    b.Property<double>("Latitude2")
                        .HasColumnType("float");

                    b.Property<double>("Longitude1")
                        .HasColumnType("float");

                    b.Property<double>("Longitude2")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("geoPoints");
                });
#pragma warning restore 612, 618
        }
    }
}
