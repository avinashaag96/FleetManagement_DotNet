﻿// <auto-generated />
using System;
using FleetManagement.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FleetManagement.Migrations
{
    [DbContext(typeof(FleetContext))]
    partial class FleetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FleetManagement.Model.AddOnMaster", b =>
                {
                    b.Property<int?>("AddOnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("AddOnId"));

                    b.Property<double?>("AddOnDailyRate")
                        .HasColumnType("float");

                    b.Property<string>("AddOnName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RateValidUpto")
                        .HasColumnType("datetime2");

                    b.HasKey("AddOnId");

                    b.ToTable("AddOnMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.AirportMaster", b =>
                {
                    b.Property<int?>("AirportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("AirportId"));

                    b.Property<int?>("AirportCode")
                        .HasColumnType("int");

                    b.Property<string>("AirportName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("HubId")
                        .HasColumnType("int");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.HasKey("AirportId");

                    b.HasIndex("CityId");

                    b.HasIndex("HubId");

                    b.HasIndex("StateId");

                    b.ToTable("AirportMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.BookingDetail", b =>
                {
                    b.Property<int?>("BookingDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("BookingDetailId"));

                    b.Property<int?>("AddOnId")
                        .HasColumnType("int");

                    b.Property<double?>("AddOnRate")
                        .HasColumnType("float");

                    b.Property<int?>("BookingId")
                        .HasColumnType("int");

                    b.HasKey("BookingDetailId");

                    b.HasIndex("AddOnId");

                    b.ToTable("BookingDetail");
                });

            modelBuilder.Entity("FleetManagement.Model.BookingHeader", b =>
                {
                    b.Property<int?>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("BookingId"));

                    b.Property<DateTime?>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CarTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingId");

                    b.HasIndex("CarTypeId");

                    b.HasIndex("CustomerId");

                    b.ToTable("BookingHeader");
                });

            modelBuilder.Entity("FleetManagement.Model.CarMaster", b =>
                {
                    b.Property<int?>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("CarId"));

                    b.Property<string>("CarDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CartypeId")
                        .HasColumnType("int");

                    b.Property<int?>("HubId")
                        .HasColumnType("int");

                    b.Property<string>("IsAvailable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("MaintenanceDueDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CarId");

                    b.HasIndex("CartypeId");

                    b.HasIndex("HubId");

                    b.ToTable("CarMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.CarTypeMaster", b =>
                {
                    b.Property<int?>("CarTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("CarTypeId"));

                    b.Property<string>("CarTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("DailyRate")
                        .HasColumnType("float");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("MonthRate")
                        .HasColumnType("float");

                    b.Property<double?>("WeeklyRate")
                        .HasColumnType("float");

                    b.HasKey("CarTypeId");

                    b.ToTable("CarTypeMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.CityMaster", b =>
                {
                    b.Property<int?>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("CityId"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("StateId");

                    b.ToTable("CityMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.Customers", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("AdhaarCardNum")
                        .HasColumnType("bigint");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("License")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PhoneNum")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("CityId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FleetManagement.Model.HubMaster", b =>
                {
                    b.Property<int?>("HubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("HubId"));

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("HubAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HubName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.HasKey("HubId");

                    b.HasIndex("CityId");

                    b.HasIndex("StateId");

                    b.ToTable("HubMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.InvoiceDetail", b =>
                {
                    b.Property<int?>("InvoiceDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("InvoiceDetailId"));

                    b.Property<double?>("AddOnAmount")
                        .HasColumnType("float");

                    b.Property<int?>("AddOnId")
                        .HasColumnType("int");

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.HasKey("InvoiceDetailId");

                    b.HasIndex("AddOnId");

                    b.HasIndex("InvoiceId");

                    b.ToTable("InvoiceDetail");
                });

            modelBuilder.Entity("FleetManagement.Model.InvoiceHeader", b =>
                {
                    b.Property<int?>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("InvoiceId"));

                    b.Property<int?>("BookingId")
                        .HasColumnType("int");

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("HandoverDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Odate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("RentalAmount")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("TotalAddOnAmount")
                        .HasColumnType("float");

                    b.Property<double?>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("InvoiceId");

                    b.HasIndex("BookingId");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("InvoiceHeader");
                });

            modelBuilder.Entity("FleetManagement.Model.StateMaster", b =>
                {
                    b.Property<int?>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("StateId"));

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateId");

                    b.ToTable("StateMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.AirportMaster", b =>
                {
                    b.HasOne("FleetManagement.Model.CityMaster", "CityMaster")
                        .WithMany("AirportMaster")
                        .HasForeignKey("CityId");

                    b.HasOne("FleetManagement.Model.HubMaster", "HubMaster")
                        .WithMany("AirportMaster")
                        .HasForeignKey("HubId");

                    b.HasOne("FleetManagement.Model.StateMaster", "StateMaster")
                        .WithMany("AirportMaster")
                        .HasForeignKey("StateId");

                    b.Navigation("CityMaster");

                    b.Navigation("HubMaster");

                    b.Navigation("StateMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.BookingDetail", b =>
                {
                    b.HasOne("FleetManagement.Model.AddOnMaster", "AddOnMaster")
                        .WithMany("BookingDetail")
                        .HasForeignKey("AddOnId");

                    b.Navigation("AddOnMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.BookingHeader", b =>
                {
                    b.HasOne("FleetManagement.Model.CarTypeMaster", "CarTypeMaster")
                        .WithMany("BookingHeader")
                        .HasForeignKey("CarTypeId");

                    b.HasOne("FleetManagement.Model.Customers", "Customers")
                        .WithMany("BookingHeader")
                        .HasForeignKey("CustomerId");

                    b.Navigation("CarTypeMaster");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("FleetManagement.Model.CarMaster", b =>
                {
                    b.HasOne("FleetManagement.Model.CarTypeMaster", "CarTypeMaster")
                        .WithMany("CarMaster")
                        .HasForeignKey("CartypeId");

                    b.HasOne("FleetManagement.Model.HubMaster", "HubMaster")
                        .WithMany("CarMaster")
                        .HasForeignKey("HubId");

                    b.Navigation("CarTypeMaster");

                    b.Navigation("HubMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.CityMaster", b =>
                {
                    b.HasOne("FleetManagement.Model.StateMaster", "StateMaster")
                        .WithMany("CityMaster")
                        .HasForeignKey("StateId");

                    b.Navigation("StateMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.Customers", b =>
                {
                    b.HasOne("FleetManagement.Model.CityMaster", "CityMaster")
                        .WithMany("Customers")
                        .HasForeignKey("CityId");

                    b.Navigation("CityMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.HubMaster", b =>
                {
                    b.HasOne("FleetManagement.Model.CityMaster", "CityMaster")
                        .WithMany("HubMaster")
                        .HasForeignKey("CityId");

                    b.HasOne("FleetManagement.Model.StateMaster", "StateMaster")
                        .WithMany("HubMaster")
                        .HasForeignKey("StateId");

                    b.Navigation("CityMaster");

                    b.Navigation("StateMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.InvoiceDetail", b =>
                {
                    b.HasOne("FleetManagement.Model.AddOnMaster", "AddOnMaster")
                        .WithMany("InvoiceDetail")
                        .HasForeignKey("AddOnId");

                    b.HasOne("FleetManagement.Model.InvoiceHeader", "InvoiceHeader")
                        .WithMany("InvoiceDetail")
                        .HasForeignKey("InvoiceId");

                    b.Navigation("AddOnMaster");

                    b.Navigation("InvoiceHeader");
                });

            modelBuilder.Entity("FleetManagement.Model.InvoiceHeader", b =>
                {
                    b.HasOne("FleetManagement.Model.BookingHeader", "BookingHeader")
                        .WithMany("InvoiceHeader")
                        .HasForeignKey("BookingId");

                    b.HasOne("FleetManagement.Model.CarMaster", "CarMaster")
                        .WithMany("InvoiceHeader")
                        .HasForeignKey("CarId");

                    b.HasOne("FleetManagement.Model.Customers", "Customers")
                        .WithMany("InvoiceHeader")
                        .HasForeignKey("CustomerId");

                    b.Navigation("BookingHeader");

                    b.Navigation("CarMaster");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("FleetManagement.Model.AddOnMaster", b =>
                {
                    b.Navigation("BookingDetail");

                    b.Navigation("InvoiceDetail");
                });

            modelBuilder.Entity("FleetManagement.Model.BookingHeader", b =>
                {
                    b.Navigation("InvoiceHeader");
                });

            modelBuilder.Entity("FleetManagement.Model.CarMaster", b =>
                {
                    b.Navigation("InvoiceHeader");
                });

            modelBuilder.Entity("FleetManagement.Model.CarTypeMaster", b =>
                {
                    b.Navigation("BookingHeader");

                    b.Navigation("CarMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.CityMaster", b =>
                {
                    b.Navigation("AirportMaster");

                    b.Navigation("Customers");

                    b.Navigation("HubMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.Customers", b =>
                {
                    b.Navigation("BookingHeader");

                    b.Navigation("InvoiceHeader");
                });

            modelBuilder.Entity("FleetManagement.Model.HubMaster", b =>
                {
                    b.Navigation("AirportMaster");

                    b.Navigation("CarMaster");
                });

            modelBuilder.Entity("FleetManagement.Model.InvoiceHeader", b =>
                {
                    b.Navigation("InvoiceDetail");
                });

            modelBuilder.Entity("FleetManagement.Model.StateMaster", b =>
                {
                    b.Navigation("AirportMaster");

                    b.Navigation("CityMaster");

                    b.Navigation("HubMaster");
                });
#pragma warning restore 612, 618
        }
    }
}