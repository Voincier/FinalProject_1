﻿// <auto-generated />
using FinalProject1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject1.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20240116064311_Second Migration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("FinalProject1.Models.ItemData", b =>
                {
                    b.Property<int>("paymentDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cardNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("cardOwnerNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("expirationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("securityCode")
                        .HasColumnType("TEXT");

                    b.HasKey("paymentDetailId");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
