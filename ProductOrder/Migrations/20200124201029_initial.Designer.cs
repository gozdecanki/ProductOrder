﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductOrder;

namespace ProductOrder.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200124201029_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductOrder.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(15);

                    b.Property<string>("Description");

                    b.Property<byte[]>("Picture");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ProductOrder.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5);

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(40);

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30);

                    b.Property<string>("ContectName")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .HasMaxLength(24);

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ProductOrder.Models.CustomerCustomerDemo", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasMaxLength(5);

                    b.Property<string>("CustomerTypeId")
                        .HasMaxLength(10);

                    b.HasKey("CustomerId", "CustomerTypeId");

                    b.HasIndex("CustomerTypeId")
                        .IsUnique();

                    b.ToTable("CustomerCustomerDemos");
                });

            modelBuilder.Entity("ProductOrder.Models.CustomerDemographic", b =>
                {
                    b.Property<string>("CustomerTypeId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("CustomerDesc");

                    b.HasKey("CustomerTypeId");

                    b.ToTable("CustomerDemographics");
                });

            modelBuilder.Entity("ProductOrder.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Extension")
                        .HasMaxLength(4);

                    b.Property<string>("FirstName")
                        .HasMaxLength(10);

                    b.Property<DateTime>("HireDate");

                    b.Property<string>("HomePhone")
                        .HasMaxLength(24);

                    b.Property<string>("LastName")
                        .HasMaxLength(20);

                    b.Property<string>("Notes");

                    b.Property<byte[]>("Photo");

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(255);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.Property<int?>("ReportsTo");

                    b.Property<string>("Title")
                        .HasMaxLength(30);

                    b.Property<string>("TitleOfCourtesy")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.HasIndex("ReportsTo");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ProductOrder.Models.EmployeeTerritory", b =>
                {
                    b.Property<int>("EmployeeId");

                    b.Property<string>("TerritoryId")
                        .HasMaxLength(20);

                    b.HasKey("EmployeeId", "TerritoryId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.HasIndex("TerritoryId")
                        .IsUnique();

                    b.ToTable("EmployeeTerritories");
                });

            modelBuilder.Entity("ProductOrder.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId");

                    b.Property<int>("EmployeeId");

                    b.Property<double>("Freight");

                    b.Property<DateTime>("OrderDate");

                    b.Property<DateTime>("RequiredDate");

                    b.Property<string>("ShipAddress")
                        .HasMaxLength(60);

                    b.Property<string>("ShipCity")
                        .HasMaxLength(15);

                    b.Property<string>("ShipCountry")
                        .HasMaxLength(15);

                    b.Property<string>("ShipName")
                        .HasMaxLength(40);

                    b.Property<string>("ShipPostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("ShipRegion")
                        .HasMaxLength(15);

                    b.Property<int>("ShipVia");

                    b.Property<DateTime>("ShippedDate");

                    b.Property<int>("ShipperId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique()
                        .HasFilter("[CustomerId] IS NOT NULL");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.HasIndex("ShipperId")
                        .IsUnique();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ProductOrder.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<double>("Discount");

                    b.Property<short>("Quantity");

                    b.Property<double>("UnitPrize");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ProductOrder.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<bool>("Discontinued");

                    b.Property<string>("ProductName")
                        .HasMaxLength(40);

                    b.Property<string>("QuantityPerUnit")
                        .HasMaxLength(20);

                    b.Property<short>("ReorderLevel");

                    b.Property<int>("SupplierId");

                    b.Property<double>("UnitPrice");

                    b.Property<short>("UnitsInStock");

                    b.Property<short>("UnitsOnStock");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductOrder.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RegionDescription")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("ProductOrder.Models.Shipper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.HasKey("Id");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("ProductOrder.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<string>("CampanyName")
                        .HasMaxLength(40);

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("ContactName")
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .HasMaxLength(24);

                    b.Property<string>("HomePage");

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("ProductOrder.Models.Territory", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20);

                    b.Property<int>("RegionId");

                    b.Property<string>("TerritoryDescription")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("RegionId")
                        .IsUnique();

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("ProductOrder.Models.CustomerCustomerDemo", b =>
                {
                    b.HasOne("ProductOrder.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProductOrder.Models.CustomerDemographic", "CustomerDemographic")
                        .WithOne("CustomerCustomerDemo")
                        .HasForeignKey("ProductOrder.Models.CustomerCustomerDemo", "CustomerTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProductOrder.Models.Employee", b =>
                {
                    b.HasOne("ProductOrder.Models.Employee", "EmployeeReportsTo")
                        .WithMany()
                        .HasForeignKey("ReportsTo");
                });

            modelBuilder.Entity("ProductOrder.Models.EmployeeTerritory", b =>
                {
                    b.HasOne("ProductOrder.Models.Employee", "Employee")
                        .WithOne("EmployeeTerritory")
                        .HasForeignKey("ProductOrder.Models.EmployeeTerritory", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProductOrder.Models.Territory", "Territory")
                        .WithOne("EmployeeTerritory")
                        .HasForeignKey("ProductOrder.Models.EmployeeTerritory", "TerritoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProductOrder.Models.Order", b =>
                {
                    b.HasOne("ProductOrder.Models.Customer", "Customer")
                        .WithOne("Order")
                        .HasForeignKey("ProductOrder.Models.Order", "CustomerId");

                    b.HasOne("ProductOrder.Models.Employee", "Employee")
                        .WithOne("Order")
                        .HasForeignKey("ProductOrder.Models.Order", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProductOrder.Models.Shipper", "Shipper")
                        .WithOne("Order")
                        .HasForeignKey("ProductOrder.Models.Order", "ShipperId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProductOrder.Models.OrderDetail", b =>
                {
                    b.HasOne("ProductOrder.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProductOrder.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProductOrder.Models.Product", b =>
                {
                    b.HasOne("ProductOrder.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProductOrder.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProductOrder.Models.Territory", b =>
                {
                    b.HasOne("ProductOrder.Models.Region", "Region")
                        .WithOne("Territory")
                        .HasForeignKey("ProductOrder.Models.Territory", "RegionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
