﻿// <auto-generated />
using System;
using ComputerFirm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComputerFirm.Migrations
{
    [DbContext(typeof(ComputerFirmContext))]
    [Migration("20201207161323_Data0712")]
    partial class Data0712
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Computerfirm.Models.Component", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryProduced")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataofIssue")
                        .HasColumnType("datetime2");

                    b.Property<string>("Described")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<long?>("OrderID1")
                        .HasColumnType("bigint");

                    b.Property<long?>("OrderID2")
                        .HasColumnType("bigint");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Specificatrion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TypesofСomponent_ID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("WarrantyPeriod")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.HasIndex("OrderID1");

                    b.HasIndex("OrderID2");

                    b.ToTable("Component");
                });

            modelBuilder.Entity("Computerfirm.Models.Customer", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Computerfirm.Models.Order", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Component_1ID")
                        .HasColumnType("bigint");

                    b.Property<long>("Component_2ID")
                        .HasColumnType("bigint");

                    b.Property<long>("Component_3ID")
                        .HasColumnType("bigint");

                    b.Property<long>("Customer_ID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DueData")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ExecutionMark")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GeneralWarranttyPeriod")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderData")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PaymentMark")
                        .HasColumnType("bit");

                    b.Property<long>("Service_1ID")
                        .HasColumnType("bigint");

                    b.Property<long>("Service_2ID")
                        .HasColumnType("bigint");

                    b.Property<long>("Service_3ID")
                        .HasColumnType("bigint");

                    b.Property<int>("ShareofPrepayment")
                        .HasColumnType("int");

                    b.Property<long>("Staff_ID")
                        .HasColumnType("bigint");

                    b.Property<int>("TotalCost")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Computerfirm.Models.Position", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamePosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("StaffID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("Computerfirm.Models.Service", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<long?>("OrderID1")
                        .HasColumnType("bigint");

                    b.Property<long?>("OrderID2")
                        .HasColumnType("bigint");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.HasIndex("OrderID1");

                    b.HasIndex("OrderID2");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("Computerfirm.Models.Staff", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Age")
                        .HasColumnType("smallint");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<string>("PassportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<long>("Position_ID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Computerfirm.Models.TypesofСomponent", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ComponentID")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameTypesofComponents")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ComponentID");

                    b.ToTable("TypesofСomponent");
                });

            modelBuilder.Entity("Computerfirm.Models.Component", b =>
                {
                    b.HasOne("Computerfirm.Models.Order", null)
                        .WithMany("Component1ID")
                        .HasForeignKey("OrderID");

                    b.HasOne("Computerfirm.Models.Order", null)
                        .WithMany("Component2ID")
                        .HasForeignKey("OrderID1");

                    b.HasOne("Computerfirm.Models.Order", null)
                        .WithMany("Component3ID")
                        .HasForeignKey("OrderID2");
                });

            modelBuilder.Entity("Computerfirm.Models.Customer", b =>
                {
                    b.HasOne("Computerfirm.Models.Order", null)
                        .WithMany("CustomerID")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("Computerfirm.Models.Position", b =>
                {
                    b.HasOne("Computerfirm.Models.Staff", null)
                        .WithMany("Positions_ID")
                        .HasForeignKey("StaffID");
                });

            modelBuilder.Entity("Computerfirm.Models.Service", b =>
                {
                    b.HasOne("Computerfirm.Models.Order", null)
                        .WithMany("Service1ID")
                        .HasForeignKey("OrderID");

                    b.HasOne("Computerfirm.Models.Order", null)
                        .WithMany("Service2ID")
                        .HasForeignKey("OrderID1");

                    b.HasOne("Computerfirm.Models.Order", null)
                        .WithMany("Service3ID")
                        .HasForeignKey("OrderID2");
                });

            modelBuilder.Entity("Computerfirm.Models.Staff", b =>
                {
                    b.HasOne("Computerfirm.Models.Order", null)
                        .WithMany("StaffID")
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("Computerfirm.Models.TypesofСomponent", b =>
                {
                    b.HasOne("Computerfirm.Models.Component", null)
                        .WithMany("TypesofСomponent")
                        .HasForeignKey("ComponentID");
                });
#pragma warning restore 612, 618
        }
    }
}
