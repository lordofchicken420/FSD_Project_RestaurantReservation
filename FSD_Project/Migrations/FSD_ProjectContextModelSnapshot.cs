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
                            ConcurrencyStamp = "1d11f920-c658-4b76-8a5b-e8d2297aab44",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEBkgKWh03leQ33y8bXWf777w3JqbUgshnPvikM9MTKxYfzu6uryFc2KfeEGbnWiD7w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "217307e6-f56e-4d93-b0ba-c678229e3d7b",
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
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9525),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9537),
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
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9542),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9544),
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

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9930),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9931),
                            Email = "David@hotmail.com",
                            Gender = "Male",
                            Name = "David Lee",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9935),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9936),
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
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(137),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(139),
                            Pax = 3,
                            ReservedDateTime = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(134),
                            TableID = 1,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "System",
                            CustomerId = "2",
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(143),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(145),
                            Pax = 2,
                            ReservedDateTime = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(141),
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
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(518),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(519),
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
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(523),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(524),
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
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(727),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(728),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(732),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(733),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(737),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(738),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 4,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(741),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(742),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 5,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(746),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(747),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 6,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(750),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(752),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 7,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(755),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(756),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 8,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(760),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(761),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 9,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(765),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(766),
                            Status = true,
                            UpdatedBy = "System"
                        },
                        new
                        {
                            Id = 10,
                            BranchId = 1,
                            Capacity = 10,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(769),
                            DateUpdated = new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(770),
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
                        .HasForeignKey("CustomerId1");

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
