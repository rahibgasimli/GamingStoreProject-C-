﻿// <auto-generated />
using System;
using GamingStoreTekrar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GamingStoreTekrar.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240716091712_mig05")]
    partial class mig05
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GameGameTag", b =>
                {
                    b.Property<Guid>("GameTagsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GamesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GameTagsId", "GamesId");

                    b.HasIndex("GamesId");

                    b.ToTable("GameGameTag");
                });

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.Property<Guid>("GamesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenresId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GamesId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("GameGenre");
                });

            modelBuilder.Entity("GamingStoreTekrar.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<byte>("Age")
                        .HasColumnType("tinyint");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
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

                    b.Property<string>("ProfilePhoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                });

            modelBuilder.Entity("GamingStoreTekrar.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ClickCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ShortDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0e721b54-eb91-4d70-87cb-f6a7fc85232d"),
                            ClickCount = 0,
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1788),
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Impedit minus corrupti voluptate repudiandae assumenda illo consequuntur, quaerat animi. Quisquam, praesentium.",
                            IsDeleted = false,
                            Name = "Call of Duty",
                            PhotoPath = "images/cta-bg.jpg",
                            Price = 60.0,
                            ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit."
                        },
                        new
                        {
                            Id = new Guid("58101529-76de-4e5f-a9e5-8cd86f59b839"),
                            ClickCount = 0,
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1807),
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptas aliquam aspernatur repellendus a, possimus vero at molestias voluptatibus maxime nisi!",
                            IsDeleted = false,
                            Name = "Assassin's Creed",
                            PhotoPath = "images/top-game-01.jpg",
                            Price = 50.0,
                            ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit."
                        },
                        new
                        {
                            Id = new Guid("43476aa3-31ec-42e9-b907-d2181f58c0ab"),
                            ClickCount = 0,
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1810),
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cupiditate quibusdam eveniet voluptatum maiores expedita eos dolore itaque, doloremque ab quae.",
                            IsDeleted = false,
                            Name = "Halo Infinite",
                            PhotoPath = "images/top-game-02.jpg",
                            Price = 70.0,
                            ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit."
                        },
                        new
                        {
                            Id = new Guid("e210ed1d-9149-4cfb-9084-ee8de717d999"),
                            ClickCount = 0,
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1812),
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sint aliquid ab esse expedita veritatis eius quia repellendus, ipsam neque odit.",
                            IsDeleted = false,
                            Name = "The Witcher 3: Wild Hunt",
                            PhotoPath = "images/top-game-03.jpg",
                            Price = 40.0,
                            ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit."
                        },
                        new
                        {
                            Id = new Guid("f7f15f76-d41d-4a6b-9cb9-28e1227c40cf"),
                            ClickCount = 0,
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1814),
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque, quam exercitationem! Deserunt, obcaecati. Eaque minima tempora velit laudantium.",
                            IsDeleted = false,
                            Name = "Red Dead Redemption 2",
                            PhotoPath = "images/top-game-04.jpg",
                            Price = 55.0,
                            ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit."
                        },
                        new
                        {
                            Id = new Guid("24092a9b-62f3-4a7e-ae9d-e50824bfcfc8"),
                            ClickCount = 0,
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1820),
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consequuntur quam deleniti doloribus recusandae sequi, laudantium doloremque quod sit omnis.",
                            IsDeleted = false,
                            Name = "FIFA 22",
                            PhotoPath = "images/top-game-05.jpg",
                            Price = 45.0,
                            ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit."
                        },
                        new
                        {
                            Id = new Guid("5ec23775-6ef2-4db8-9962-3cb6e942856b"),
                            ClickCount = 0,
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1822),
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatem iusto sit quae. Nesciunt, veniam dolorum! Ad, saepe. At, ipsum.",
                            IsDeleted = false,
                            Name = "Minecraft",
                            PhotoPath = "images/top-game-06.jpg",
                            Price = 30.0,
                            ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit."
                        },
                        new
                        {
                            Id = new Guid("d72d42f5-88b9-45ad-8b83-ad32471ab4e9"),
                            ClickCount = 0,
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1836),
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Autem quis iusto, blanditiis fugit dolorem odit nisi laborum sapiente eius!",
                            IsDeleted = false,
                            Name = "Cyberpunk 2077",
                            PhotoPath = "images/top-game-05.jpg",
                            Price = 50.0,
                            ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit."
                        },
                        new
                        {
                            Id = new Guid("ada94c01-8d58-428b-85db-50b221c2dc51"),
                            ClickCount = 0,
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1838),
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat quaerat molestiae laborum corporis, laudantium odit voluptate eligendi tempore vero!",
                            IsDeleted = false,
                            Name = "The Last of Us Part II",
                            PhotoPath = "images/top-game-03.jpg",
                            Price = 45.0,
                            ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit."
                        },
                        new
                        {
                            Id = new Guid("1adea5d0-c77a-456a-933c-584e817dbd0b"),
                            ClickCount = 0,
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1841),
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam nihil odio quos doloribus maiores, laborum minus, quibusdam distinctio consequatur!",
                            IsDeleted = false,
                            Name = "Grand Theft Auto V",
                            PhotoPath = "images/top-game-02.jpg",
                            Price = 40.0,
                            ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit."
                        },
                        new
                        {
                            Id = new Guid("642003f9-7ec2-43c1-a91f-dc8d95f61f3d"),
                            ClickCount = 0,
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1843),
                            Description = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Adipisci voluptas exercitationem reiciendis iure eius dolorem excepturi molestias dolorum voluptatibus.",
                            IsDeleted = false,
                            Name = "Fortnite",
                            PhotoPath = "images/top-game-04.jpg",
                            Price = 0.0,
                            ShortDesc = "Lorem ipsum dolor sit amet consectetur adipisicing elit."
                        });
                });

            modelBuilder.Entity("GamingStoreTekrar.Entities.GameTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("GameTags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("89c0870d-3f03-45ea-aa3f-0911adad553a"),
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1958),
                            IsDeleted = false,
                            Name = "War"
                        },
                        new
                        {
                            Id = new Guid("aca1be9b-f679-4c4d-bdb7-d5191a06d0cf"),
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1962),
                            IsDeleted = false,
                            Name = "Crafting"
                        },
                        new
                        {
                            Id = new Guid("e9b5cdfa-e618-4e67-b8ac-df7ec4ab3016"),
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1964),
                            IsDeleted = false,
                            Name = "Survival"
                        });
                });

            modelBuilder.Entity("GamingStoreTekrar.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7821901f-12c6-4881-b852-9d9d6aebb3d6"),
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1906),
                            IsDeleted = false,
                            Name = "Action"
                        },
                        new
                        {
                            Id = new Guid("d5f3aade-fdc1-4d17-8202-1dd667bff05f"),
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1910),
                            IsDeleted = false,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = new Guid("fc66c941-2d00-4a10-9380-0bb6a210373c"),
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1912),
                            IsDeleted = false,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = new Guid("be8c073c-0e33-46cc-8d6e-d09887fd5964"),
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1914),
                            IsDeleted = false,
                            Name = "Simulation"
                        },
                        new
                        {
                            Id = new Guid("d62c33da-ce53-4e08-8def-e4ef70767e94"),
                            CreatedDate = new DateTime(2024, 7, 16, 13, 17, 11, 453, DateTimeKind.Local).AddTicks(1920),
                            IsDeleted = false,
                            Name = "Battle royale"
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

            modelBuilder.Entity("GameGameTag", b =>
                {
                    b.HasOne("GamingStoreTekrar.Entities.GameTag", null)
                        .WithMany()
                        .HasForeignKey("GameTagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamingStoreTekrar.Entities.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.HasOne("GamingStoreTekrar.Entities.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamingStoreTekrar.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("GamingStoreTekrar.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GamingStoreTekrar.Entities.AppUser", null)
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

                    b.HasOne("GamingStoreTekrar.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GamingStoreTekrar.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
