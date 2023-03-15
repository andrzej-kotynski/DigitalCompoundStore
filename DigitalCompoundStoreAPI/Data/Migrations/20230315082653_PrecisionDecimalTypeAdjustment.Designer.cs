﻿// <auto-generated />
using System;
using DigitalCompoundStoreAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DigitalCompoundStoreAPI.Data.Migrations
{
    [DbContext(typeof(DigitalCompoundStoreDbContext))]
    [Migration("20230315082653_PrecisionDecimalTypeAdjustment")]
    partial class PrecisionDecimalTypeAdjustment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DigitalCompoundStoreAPI.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DigitalCompoundStoreAPI.Entities.Facility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("FacilityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("DigitalCompoundStoreAPI.Entities.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("PriceBuy")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceSell")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("DigitalCompoundStoreAPI.Entities.PriceUsed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("PriceBuy")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceSellHigh")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceSellLow")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("PricesUsed");
                });

            modelBuilder.Entity("DigitalCompoundStoreAPI.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateBought")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateSold")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FacilityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PriceId")
                        .HasColumnType("int");

                    b.Property<int?>("PriceUsedId")
                        .HasColumnType("int");

                    b.Property<int?>("VideoGameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.HasIndex("PriceId");

                    b.HasIndex("PriceUsedId");

                    b.HasIndex("VideoGameId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DigitalCompoundStoreAPI.Entities.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConditionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FacilityId")
                        .HasColumnType("int");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoGamePlatform")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("VideoGames");
                });

            modelBuilder.Entity("DigitalCompoundStoreAPI.Entities.Facility", b =>
                {
                    b.HasOne("DigitalCompoundStoreAPI.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("DigitalCompoundStoreAPI.Entities.Product", b =>
                {
                    b.HasOne("DigitalCompoundStoreAPI.Entities.Facility", null)
                        .WithMany("Products")
                        .HasForeignKey("FacilityId");

                    b.HasOne("DigitalCompoundStoreAPI.Entities.Price", "Price")
                        .WithMany()
                        .HasForeignKey("PriceId");

                    b.HasOne("DigitalCompoundStoreAPI.Entities.PriceUsed", "PriceUsed")
                        .WithMany()
                        .HasForeignKey("PriceUsedId");

                    b.HasOne("DigitalCompoundStoreAPI.Entities.VideoGame", "VideoGame")
                        .WithMany()
                        .HasForeignKey("VideoGameId");

                    b.Navigation("Price");

                    b.Navigation("PriceUsed");

                    b.Navigation("VideoGame");
                });

            modelBuilder.Entity("DigitalCompoundStoreAPI.Entities.VideoGame", b =>
                {
                    b.HasOne("DigitalCompoundStoreAPI.Entities.Facility", "Facility")
                        .WithMany("VideoGames")
                        .HasForeignKey("FacilityId");

                    b.Navigation("Facility");
                });

            modelBuilder.Entity("DigitalCompoundStoreAPI.Entities.Facility", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("VideoGames");
                });
#pragma warning restore 612, 618
        }
    }
}