﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Contexts;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    partial class BaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.AdditionalService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<decimal>("DailyPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("DailyPrice");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("AdditionalServices", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Rental", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CarId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerId");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<DateTime>("RentEndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("RentEndDate");

                    b.Property<int?>("RentEndKilometer")
                        .HasColumnType("int")
                        .HasColumnName("RentEndKilometer");

                    b.Property<Guid?>("RentEndRentalBranchId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("RentEndRentalBranchId");

                    b.Property<DateTime>("RentStartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("RentStartDate");

                    b.Property<int>("RentStartKilometer")
                        .HasColumnType("int")
                        .HasColumnName("RentStartKilometer");

                    b.Property<Guid>("RentStartRentalBranchId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("RentStartRentalBranchId");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ReturnDate");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("RentEndRentalBranchId");

                    b.HasIndex("RentStartRentalBranchId");

                    b.ToTable("Rentals", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.RentalBranch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<int>("City")
                        .HasColumnType("int")
                        .HasColumnName("City");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("RentalBranches", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.RentalsAdditionalService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<Guid>("AdditionalServiceId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("AdditionalServiceId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<Guid>("RentalId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("RentalId");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalServiceId");

                    b.HasIndex("RentalId");

                    b.ToTable("RentalsAdditionalServices", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Rental", b =>
                {
                    b.HasOne("Domain.Entities.RentalBranch", "RentEndRentalBranch")
                        .WithMany()
                        .HasForeignKey("RentEndRentalBranchId");

                    b.HasOne("Domain.Entities.RentalBranch", "RentStartRentalBranch")
                        .WithMany()
                        .HasForeignKey("RentStartRentalBranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RentEndRentalBranch");

                    b.Navigation("RentStartRentalBranch");
                });

            modelBuilder.Entity("Domain.Entities.RentalsAdditionalService", b =>
                {
                    b.HasOne("Domain.Entities.AdditionalService", "AdditionalService")
                        .WithMany()
                        .HasForeignKey("AdditionalServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Rental", "Rental")
                        .WithMany("RentalsAdditionalServices")
                        .HasForeignKey("RentalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdditionalService");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("Domain.Entities.Rental", b =>
                {
                    b.Navigation("RentalsAdditionalServices");
                });
#pragma warning restore 612, 618
        }
    }
}
