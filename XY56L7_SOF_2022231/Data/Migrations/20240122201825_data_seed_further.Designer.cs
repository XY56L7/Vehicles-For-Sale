﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XY56L7_SOF_2022231.Data;

#nullable disable

namespace XY56L7_SOF_2022231.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240122201825_data_seed_further")]
    partial class data_seed_further
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("XY56L7_SOF_2022231.Models.Car", b =>
                {
                    b.Property<string>("Uid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Uid");

                    b.HasIndex("OwnerId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Uid = "59ba80f1-8d10-4a28-b8d2-2856ef17cab6",
                            OwnerId = "user1",
                            Title = "Phoenix 1"
                        },
                        new
                        {
                            Uid = "6f56e67a-5692-4095-89d3-f461b1349a1e",
                            OwnerId = "user2",
                            Title = "Nebula 2"
                        },
                        new
                        {
                            Uid = "ea6561a9-9d98-49db-9efc-639686e8017f",
                            OwnerId = "user3",
                            Title = "Quantum 3"
                        },
                        new
                        {
                            Uid = "f9b6127f-b4ce-4430-90af-de1223b7cb14",
                            OwnerId = "user4",
                            Title = "Infinity 4"
                        },
                        new
                        {
                            Uid = "c8b16786-0686-42aa-901e-6470260eca56",
                            OwnerId = "user5",
                            Title = "Pegasus 5"
                        },
                        new
                        {
                            Uid = "8179e0a5-a21b-4f28-94a4-7e9323d31cec",
                            OwnerId = "user6",
                            Title = "Aurora 6"
                        },
                        new
                        {
                            Uid = "ac94881b-92fb-45da-929e-58111b16f01c",
                            OwnerId = "user7",
                            Title = "Raptor 7"
                        },
                        new
                        {
                            Uid = "16d51f5f-3beb-4e3a-82cf-1309d583b1b6",
                            OwnerId = "user8",
                            Title = "Zenith 8"
                        },
                        new
                        {
                            Uid = "56201d89-adbe-4bce-9882-2332c35a1d7c",
                            OwnerId = "user9",
                            Title = "Vortex 9"
                        },
                        new
                        {
                            Uid = "518a5e2f-7882-49d4-8540-a079a193a445",
                            OwnerId = "user10",
                            Title = "Spectra 10"
                        },
                        new
                        {
                            Uid = "87d81206-9073-4e49-8cdb-2f4aa6706c83",
                            OwnerId = "user11",
                            Title = "Phoenix 11"
                        },
                        new
                        {
                            Uid = "1444df50-85f1-4a23-95c5-45e1d47ce0ab",
                            OwnerId = "user12",
                            Title = "Nebula 12"
                        },
                        new
                        {
                            Uid = "6437c5b6-a1fa-490b-9db3-f652ac098c60",
                            OwnerId = "user13",
                            Title = "Quantum 13"
                        },
                        new
                        {
                            Uid = "da815278-031a-4c7e-b86e-33f4e0ec7468",
                            OwnerId = "user14",
                            Title = "Infinity 14"
                        },
                        new
                        {
                            Uid = "87c1fd44-cea5-4691-9d85-95823da0e914",
                            OwnerId = "user15",
                            Title = "Pegasus 15"
                        },
                        new
                        {
                            Uid = "377da23b-f18d-455a-96ca-d532ebb4947d",
                            OwnerId = "user16",
                            Title = "Aurora 16"
                        },
                        new
                        {
                            Uid = "199428d4-ff96-4252-8489-fe457e151bcc",
                            OwnerId = "user17",
                            Title = "Raptor 17"
                        },
                        new
                        {
                            Uid = "74e95ae3-abaa-4c2b-84bb-d37a65c85f6a",
                            OwnerId = "user18",
                            Title = "Zenith 18"
                        },
                        new
                        {
                            Uid = "4bf45715-5450-4f0c-b1ad-60d982827999",
                            OwnerId = "user19",
                            Title = "Vortex 19"
                        },
                        new
                        {
                            Uid = "3741ee39-92c5-4f91-a3b3-3ba4c60d4f21",
                            OwnerId = "user20",
                            Title = "Spectra 20"
                        });
                });

            modelBuilder.Entity("XY56L7_SOF_2022231.Models.SiteUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("SiteUser");

                    b.HasData(
                        new
                        {
                            Id = "user1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9f2109a5-5322-433e-bcb9-1d680c7d5f54",
                            Email = "user1@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e0de5734-d822-4e98-8c94-b6ed3f477432",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 1, 2, 3 },
                            FirstName = "Elena",
                            LastName = "Martinez"
                        },
                        new
                        {
                            Id = "user2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "86408f54-a96a-45a4-a5f7-4f58d09a3c01",
                            Email = "user2@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d300948f-1259-49f0-96f2-b54653045327",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 2, 3, 4 },
                            FirstName = "Victor",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = "user3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8d60cee1-986b-4eec-b563-5b6e52a056a9",
                            Email = "user3@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3df54b47-e3a9-41bf-80ae-e61ba7e03cb4",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 3, 4, 5 },
                            FirstName = "Sophia",
                            LastName = "Garcia"
                        },
                        new
                        {
                            Id = "user4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "453ba5fe-690a-4ec0-a97b-51f507009c9b",
                            Email = "user4@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bdf58f93-9aab-4f62-9422-9144fbfda90b",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 4, 5, 6 },
                            FirstName = "Oliver",
                            LastName = "Johnson"
                        },
                        new
                        {
                            Id = "user5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b978fa9f-2f33-4a1a-a7a2-65447e115535",
                            Email = "user5@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e50891ba-148b-4de9-a002-6dfcadb1d84d",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 5, 6, 7 },
                            FirstName = "Isabella",
                            LastName = "Rodriguez"
                        },
                        new
                        {
                            Id = "user6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a65fe783-0560-4575-a8e0-0857a0c6b2b8",
                            Email = "user6@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a3d468dd-e59f-423d-b632-10d34355c38f",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 6, 7, 8 },
                            FirstName = "Max",
                            LastName = "Brown"
                        },
                        new
                        {
                            Id = "user7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8abd2c1d-4f0f-47e5-b291-dc090113add2",
                            Email = "user7@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5007530f-aa94-4995-b0b8-16ac0c618999",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 7, 8, 9 },
                            FirstName = "Emma",
                            LastName = "Lee"
                        },
                        new
                        {
                            Id = "user8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3f38b4d0-9a26-4d08-945d-4acca855ce86",
                            Email = "user8@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c34bdb8a-1381-4482-9112-b9ff059fe174",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 8, 9, 10 },
                            FirstName = "Leo",
                            LastName = "Davis"
                        },
                        new
                        {
                            Id = "user9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b99f19fc-6f19-4400-83bf-a35774b31784",
                            Email = "user9@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0e1cb82f-2b8a-4e54-b715-9dc08acd030d",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 9, 10, 11 },
                            FirstName = "Ava",
                            LastName = "Hernandez"
                        },
                        new
                        {
                            Id = "user10",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ae55ccec-7878-4966-8c37-e08b91da5ae1",
                            Email = "user10@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ea7cb9b5-9eef-4e94-b23e-c650f86c65de",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 10, 11, 12 },
                            FirstName = "Liam",
                            LastName = "Taylor"
                        },
                        new
                        {
                            Id = "user11",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "16f82b96-ba70-41fe-943d-dbaed9c54061",
                            Email = "user11@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "128aee05-d80c-4be2-b1c5-4a5ae941281b",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 11, 12, 13 },
                            FirstName = "Mia",
                            LastName = "Clark"
                        },
                        new
                        {
                            Id = "user12",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "21f28bd1-a9d0-46b4-be73-e5e02a73329f",
                            Email = "user12@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "819140d2-502b-4141-b004-426aeb7c7574",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 12, 13, 14 },
                            FirstName = "Gabriel",
                            LastName = "Lewis"
                        },
                        new
                        {
                            Id = "user13",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a6854466-760f-436e-af3f-1f822277abe3",
                            Email = "user13@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "66adab50-8ede-4b32-8871-192c7d55b73b",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 13, 14, 15 },
                            FirstName = "Luna",
                            LastName = "Walker"
                        },
                        new
                        {
                            Id = "user14",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a6067129-62dd-4bb6-9a6e-e58ee9a7fee6",
                            Email = "user14@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2b9c75d5-5cc9-4687-aeb4-c4de74b17a73",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 14, 15, 16 },
                            FirstName = "Sebastian",
                            LastName = "Hall"
                        },
                        new
                        {
                            Id = "user15",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2d2f85c0-b5ba-4ec9-a963-7aa920a7db52",
                            Email = "user15@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "51075bee-26e5-42df-be60-413c039a2f7d",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 15, 16, 17 },
                            FirstName = "Zoe",
                            LastName = "Young"
                        },
                        new
                        {
                            Id = "user16",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2e434f1c-3552-4ddf-aff8-16b32f397fb9",
                            Email = "user16@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "576f9dda-cd6a-46a0-9f28-a6a417adfc3d",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 16, 17, 18 },
                            FirstName = "Lucas",
                            LastName = "Hill"
                        },
                        new
                        {
                            Id = "user17",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "496252fd-d7dd-4397-b7fa-cfe2e96514e2",
                            Email = "user17@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9e20e88f-69d5-4eb5-b2bc-4bf0172294ed",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 17, 18, 19 },
                            FirstName = "Chloe",
                            LastName = "Cooper"
                        },
                        new
                        {
                            Id = "user18",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1815cad8-9f83-4d60-8cdb-cd37513ec86f",
                            Email = "user18@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "09e12b65-ac05-4f92-bf04-8568d3aafcce",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 18, 19, 20 },
                            FirstName = "Mateo",
                            LastName = "Baker"
                        },
                        new
                        {
                            Id = "user19",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dd21fea5-c1cd-478f-9172-2af610bd0a2f",
                            Email = "user19@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0217efd2-ce5d-442b-99f4-aba571fd1b84",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 19, 20, 21 },
                            FirstName = "Nora",
                            LastName = "Ward"
                        },
                        new
                        {
                            Id = "user20",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2930d76d-8e8b-4576-89be-0e792a8090b4",
                            Email = "user20@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "673fb79e-7021-4636-a859-1ee04a796949",
                            TwoFactorEnabled = false,
                            ContentType = "",
                            Data = new byte[] { 20, 21, 22 },
                            FirstName = "Alex",
                            LastName = "Anderson"
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("XY56L7_SOF_2022231.Models.Car", b =>
                {
                    b.HasOne("XY56L7_SOF_2022231.Models.SiteUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });
#pragma warning restore 612, 618
        }
    }
}
