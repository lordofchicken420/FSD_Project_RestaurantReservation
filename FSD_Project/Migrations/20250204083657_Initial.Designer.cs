﻿// <auto-generated />
using System;
using FSD_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FSD_Project.Migrations
{
    [DbContext(typeof(FSD_ProjectContext))]
    [Migration("20250204083657_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FSD_Project.Data.FSD_ProjectUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b179928-37d3-43a4-86cc-0172fbea5977",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECCseOJBRitgUMU4TgJ8ZiTvGYUZWy8vVjD4szeIB2L+PogjXgg6JSyK4DeORZD51A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "23785aba-5d9d-4b77-9ade-3ade3dbdb7c0",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        },
                        new
                        {
                            Id = "customer1-id",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "af23c522-a7a9-4e8c-8717-f8552cec0b25",
                            Email = "customer1@example.com",
                            EmailConfirmed = true,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER1@EXAMPLE.COM",
                            NormalizedUserName = "CUSTOMER1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHx0yx00eCXlgknkBBA8piPZHPtXW3LiE/ED6PjMPkDh0StWgTfClE8nTt+UzcZG+g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b576e568-4e0b-4baa-842c-2af12178b8a4",
                            TwoFactorEnabled = false,
                            UserName = "customer1@example.com"
                        },
                        new
                        {
                            Id = "staff1-id",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fad6ad30-1394-43da-a25f-e760a6b00854",
                            Email = "staff1@example.com",
                            EmailConfirmed = true,
                            FirstName = "Jane",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF1@EXAMPLE.COM",
                            NormalizedUserName = "STAFF1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAtKIsyUuRN1EOzUqbbDK1WP9M0nBgXf59L4y2TUh2H5NMy27XtiNeWUZ7w+DExEIA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b4e7b07f-43b7-4e07-a995-1ba05feff0ab",
                            TwoFactorEnabled = false,
                            UserName = "staff1@example.com"
                        });
                });

            modelBuilder.Entity("FSD_Project.Domain.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumOfTables")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("contactNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Branch");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(7705),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(7727),
                            Location = "Woodlands",
                            Name = "Branch 1",
                            NumOfTables = 15,
                            UpdatedBy = "System",
                            contactNumber = 61234567
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(7735),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(7737),
                            Location = "Punggol",
                            Name = "Branch 2",
                            NumOfTables = 15,
                            UpdatedBy = "System",
                            contactNumber = 61234566
                        });
                });

            modelBuilder.Entity("FSD_Project.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8230),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8232),
                            Email = "David@hotmail.com",
                            Gender = "Male",
                            Name = "David Lee",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8238),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8240),
                            Email = "johnmatthew@gmail.com",
                            Gender = "Male",
                            Name = "John Matthew",
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("FSD_Project.Domain.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReservedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TableID")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("CustomerId1");

                    b.HasIndex("TableID");

                    b.ToTable("Reservation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            CustomerId = "1",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8500),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8502),
                            ReservedDateTime = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8497),
                            TableID = 1,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            CustomerId = "2",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8509),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8510),
                            ReservedDateTime = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8506),
                            TableID = 2,
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("FSD_Project.Domain.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReservationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReservationId1")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId1");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "The Greek Salad was the perfect mix of vegetables, fruits and dressing!",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 380, DateTimeKind.Local).AddTicks(4567),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 380, DateTimeKind.Local).AddTicks(4603),
                            ReservationId = "1",
                            Score = 5,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "The Baklava was unlike anything I have ever eaten before",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 380, DateTimeKind.Local).AddTicks(4614),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 380, DateTimeKind.Local).AddTicks(4616),
                            ReservationId = "2",
                            Score = 5,
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("FSD_Project.Domain.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("UserId");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchId = 1,
                            ContactNumber = 97581578,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8724),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8725),
                            Email = "Gordon@hotmail.com",
                            Gender = "Male",
                            Name = "Gordon Sim",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            BranchId = 1,
                            ContactNumber = 98886482,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8732),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8734),
                            Email = "EnXuan@hotmail.com",
                            Gender = "Female",
                            Name = "En Xuan",
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("FSD_Project.Domain.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Table");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8951),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8953),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8960),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8961),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8967),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8969),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 4,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8973),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8974),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 5,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8979),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8980),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 6,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8984),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8985),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 7,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8990),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8991),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 8,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8996),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(8997),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 9,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(9001),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(9003),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 10,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(9007),
                            DateUpdated = new DateTime(2025, 2, 4, 16, 36, 56, 111, DateTimeKind.Local).AddTicks(9008),
                            Status = true,
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "customer-role-id",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "staff-role-id",
                            Name = "Staff",
                            NormalizedName = "STAFF"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba"
                        },
                        new
                        {
                            UserId = "customer1-id",
                            RoleId = "customer-role-id"
                        },
                        new
                        {
                            UserId = "staff1-id",
                            RoleId = "staff-role-id"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FSD_Project.Domain.Customer", b =>
                {
                    b.HasOne("FSD_Project.Data.FSD_ProjectUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("FSD_Project.Domain.Reservation", b =>
                {
                    b.HasOne("FSD_Project.Domain.Branch", null)
                        .WithMany("Reservations")
                        .HasForeignKey("BranchId");

                    b.HasOne("FSD_Project.Domain.Customer", null)
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId1");

                    b.HasOne("FSD_Project.Domain.Table", "Table")
                        .WithMany("Reservations")
                        .HasForeignKey("TableID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("FSD_Project.Domain.Review", b =>
                {
                    b.HasOne("FSD_Project.Domain.Reservation", "Reservation")
                        .WithMany("Reviews")
                        .HasForeignKey("ReservationId1");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("FSD_Project.Domain.Staff", b =>
                {
                    b.HasOne("FSD_Project.Domain.Branch", "Branch")
                        .WithMany("Staffs")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSD_Project.Data.FSD_ProjectUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Branch");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FSD_Project.Domain.Table", b =>
                {
                    b.HasOne("FSD_Project.Domain.Branch", "Branch")
                        .WithMany("Tables")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FSD_Project.Data.FSD_ProjectUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FSD_Project.Data.FSD_ProjectUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FSD_Project.Data.FSD_ProjectUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FSD_Project.Data.FSD_ProjectUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FSD_Project.Domain.Branch", b =>
                {
                    b.Navigation("Reservations");

                    b.Navigation("Staffs");

                    b.Navigation("Tables");
                });

            modelBuilder.Entity("FSD_Project.Domain.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("FSD_Project.Domain.Reservation", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("FSD_Project.Domain.Table", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
