﻿// <auto-generated />
using System;
using FSD_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FSD_Project.Migrations
{
    [DbContext(typeof(FSD_ProjectContext))]
    partial class FSD_ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            ConcurrencyStamp = "04ef58bb-96af-43c6-be6e-d654589c4ece",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFuDHQ+G38ezO9fPGK9TDpltK23PA6C6gAzksbMX4MPe/fvnsRaAWBNPAoeoybP96Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c998f4c3-25cb-495b-aec8-ca05854d6ffc",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        },
                        new
                        {
                            Id = "customer1-id",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "77c5aed7-abe9-4f95-8138-71c6281efc30",
                            Email = "customer1@example.com",
                            EmailConfirmed = true,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            NormalizedEmail = "CUSTOMER1@EXAMPLE.COM",
                            NormalizedUserName = "CUSTOMER1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHis6llr7zPwgg/fegao76mMDtpozLlUwzNBuIaV1tZr271Wa50qRzYXy+LRYfdvrA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "89b05b8a-5ece-4a3e-959d-c52e0e452b69",
                            TwoFactorEnabled = false,
                            UserName = "customer1@example.com"
                        },
                        new
                        {
                            Id = "staff1-id",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ba353af8-b132-4025-ae40-0e1d765ce9b1",
                            Email = "staff1@example.com",
                            EmailConfirmed = true,
                            FirstName = "Jane",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF1@EXAMPLE.COM",
                            NormalizedUserName = "STAFF1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELI+s86seoiqCJOtRqR7I7ZoHl7xyvVoxN7XNjsxfOVPG3LzSt3TPRgbjK/sXD//Eg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a6d829b5-b3e9-4d87-868d-c912c0cf1e5d",
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
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7674),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7684),
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
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7728),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7729),
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
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7884),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7884),
                            Email = "David@hotmail.com",
                            Gender = "Male",
                            Name = "David Lee",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7886),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7886),
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

                    b.Property<int>("Pax")
                        .HasColumnType("int");

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
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7968),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7968),
                            Pax = 3,
                            ReservedDateTime = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7966),
                            TableID = 1,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            CustomerId = "2",
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7970),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7970),
                            Pax = 2,
                            ReservedDateTime = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(7969),
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
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 59, 27, DateTimeKind.Local).AddTicks(8504),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 59, 27, DateTimeKind.Local).AddTicks(8517),
                            ReservationId = "1",
                            Score = 5,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "The Baklava was unlike anything I have ever eaten before",
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 59, 27, DateTimeKind.Local).AddTicks(8518),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 59, 27, DateTimeKind.Local).AddTicks(8519),
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
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8040),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8041),
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
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8042),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8043),
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
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8100),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8101),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8102),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8103),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8104),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8104),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 4,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8106),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8106),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 5,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8107),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8108),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 6,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8109),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8109),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 7,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8110),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8111),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 8,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8112),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8112),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 9,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8114),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8115),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 10,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8116),
                            DateUpdated = new DateTime(2025, 1, 29, 22, 23, 58, 905, DateTimeKind.Local).AddTicks(8116),
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
                        .OnDelete(DeleteBehavior.Restrict);

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
                        .OnDelete(DeleteBehavior.Restrict);

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
