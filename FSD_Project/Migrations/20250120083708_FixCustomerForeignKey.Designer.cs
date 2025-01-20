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
    [Migration("20250120083708_FixCustomerForeignKey")]
    partial class FixCustomerForeignKey
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
                            ConcurrencyStamp = "730bd166-b8fe-42f8-81d5-b9e64547ea12",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECkvazfE8OeH86qA6dgTAU+wUazOqqlZ5M0rLDhRrk92KA5PxUFiRe/pnXQC/Agecg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b0b7c5de-e3e9-4c4d-bba4-e4f9281d0ce6",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
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
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(1884),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(1897),
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
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(1903),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(1904),
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

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("contactNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2382),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2384),
                            Gender = "Male",
                            Name = "David Lee",
                            UpdatedBy = "System",
                            contactNumber = 91234567
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2388),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2389),
                            Gender = "Male",
                            Name = "John Matthew",
                            UpdatedBy = "System",
                            contactNumber = 91234566
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

                    b.Property<int?>("CustomerId")
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

                    b.HasIndex("CustomerId");

                    b.HasIndex("TableID");

                    b.ToTable("Reservation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            CustomerId = 1,
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2756),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2757),
                            Pax = 3,
                            ReservedDateTime = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2752),
                            TableID = 1,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            CustomerId = 2,
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2762),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2763),
                            Pax = 2,
                            ReservedDateTime = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2760),
                            TableID = 2,
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

                    b.Property<int>("contactNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchId = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2960),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2962),
                            Gender = "Male",
                            Name = "Gordon Sim",
                            UpdatedBy = "System",
                            contactNumber = 97581578
                        },
                        new
                        {
                            Id = 2,
                            BranchId = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2965),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2967),
                            Gender = "Female",
                            Name = "En Xuan",
                            UpdatedBy = "System",
                            contactNumber = 98886482
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
                            Capacity = 5,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3173),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3175),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            BranchId = 1,
                            Capacity = 5,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3179),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3180),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            BranchId = 1,
                            Capacity = 5,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3184),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3185),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 4,
                            BranchId = 1,
                            Capacity = 5,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3189),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3190),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 5,
                            BranchId = 1,
                            Capacity = 5,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3208),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3209),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 6,
                            BranchId = 1,
                            Capacity = 5,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3213),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3219),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 7,
                            BranchId = 1,
                            Capacity = 5,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3242),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3244),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 8,
                            BranchId = 1,
                            Capacity = 5,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3248),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3249),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 9,
                            BranchId = 1,
                            Capacity = 5,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3253),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3254),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 10,
                            BranchId = 1,
                            Capacity = 5,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3258),
                            DateUpdated = new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3259),
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
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                            Name = "User",
                            NormalizedName = "USER"
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

            modelBuilder.Entity("FSD_Project.Domain.Reservation", b =>
                {
                    b.HasOne("FSD_Project.Domain.Branch", null)
                        .WithMany("Reservations")
                        .HasForeignKey("BranchId");

                    b.HasOne("FSD_Project.Domain.Customer", null)
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("FSD_Project.Domain.Table", "Table")
                        .WithMany("Reservations")
                        .HasForeignKey("TableID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("FSD_Project.Domain.Staff", b =>
                {
                    b.HasOne("FSD_Project.Domain.Branch", "Branch")
                        .WithMany("Staffs")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
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

            modelBuilder.Entity("FSD_Project.Domain.Table", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
