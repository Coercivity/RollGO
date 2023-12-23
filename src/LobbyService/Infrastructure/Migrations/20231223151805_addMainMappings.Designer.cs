﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(LobbyDbContext))]
    [Migration("20231223151805_addMainMappings")]
    partial class addMainMappings
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "uuid-ossp");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.EntertainmentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string[]>("Countries")
                        .HasColumnType("text[]");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("varchar")
                        .HasColumnName("Description");

                    b.Property<int>("FilmLength")
                        .HasColumnType("integer")
                        .HasColumnName("FilmLength");

                    b.Property<string[]>("Genres")
                        .HasColumnType("text[]");

                    b.Property<bool>("IS_SERIES")
                        .HasColumnType("boolean");

                    b.Property<string>("ImdbId")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("ImdbId");

                    b.Property<bool>("IsSeries")
                        .HasColumnType("boolean");

                    b.Property<string>("KinopoiskId")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("KinopoiskId");

                    b.Property<string>("NameEn")
                        .HasColumnType("varchar")
                        .HasColumnName("NameEn");

                    b.Property<string>("NameRu")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("NameRu");

                    b.Property<string>("PosterUrl")
                        .HasColumnType("varchar")
                        .HasColumnName("PosterUrl");

                    b.Property<double>("RatingImdb")
                        .HasColumnType("double precision")
                        .HasColumnName("RatingImdb");

                    b.Property<double>("RatingKinopoisk")
                        .HasColumnType("double precision")
                        .HasColumnName("RatingKinopoisk");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("varchar")
                        .HasColumnName("ShortDescription");

                    b.Property<string>("WebUrl")
                        .HasColumnType("varchar")
                        .HasColumnName("WebUrl");

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasColumnName("Year");

                    b.HasKey("Id");

                    b.ToTable("EntertainmentEntity");

                    b.HasDiscriminator<bool>("IS_SERIES");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Domain.Entities.Lobby", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uuid")
                        .HasColumnName("AdminId");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedDateTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Lobby", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9ea5051e-1e71-4e24-8f57-c985a57a6ac2"),
                            AdminId = new Guid("0b926e47-5292-48cd-bb12-4b0fa8beb65c"),
                            CreatedDateTime = new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3164),
                            Name = "Elijah Rivera"
                        },
                        new
                        {
                            Id = new Guid("36ce8946-ba8b-4ad1-b161-207415a1fb3d"),
                            AdminId = new Guid("80251c73-b7ba-47b8-8117-ef8c003c76b8"),
                            CreatedDateTime = new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3169),
                            Name = "Michelle Wright"
                        },
                        new
                        {
                            Id = new Guid("761b5cb6-ec36-4058-a992-68467b2ae179"),
                            AdminId = new Guid("bb57cca0-25e9-4eab-a068-8362ec243fe4"),
                            CreatedDateTime = new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3178),
                            Name = "Mateo Flores"
                        },
                        new
                        {
                            Id = new Guid("4200daf6-8a52-4f6b-ba84-2cd0ad9590c8"),
                            AdminId = new Guid("643f20f5-fef7-4bea-8f82-893598a83bd7"),
                            CreatedDateTime = new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3180),
                            Name = "Michelle Torres"
                        },
                        new
                        {
                            Id = new Guid("38b63150-e04b-4c02-95f8-169e70d03122"),
                            AdminId = new Guid("ec9052c5-fd2a-49f1-beef-a9e6f18a24af"),
                            CreatedDateTime = new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3185),
                            Name = "Lisa Torres"
                        },
                        new
                        {
                            Id = new Guid("e937a4a0-9657-4a1e-9f75-71383f3a46f3"),
                            AdminId = new Guid("d6a4af77-d8e0-4e2e-a2ce-aac253fba96d"),
                            CreatedDateTime = new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3188),
                            Name = "Jessica Carter"
                        },
                        new
                        {
                            Id = new Guid("8370c42c-6f34-485b-a717-6f830a85d080"),
                            AdminId = new Guid("5f368436-78d6-46df-9046-b68d00b4db0e"),
                            CreatedDateTime = new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3190),
                            Name = "Sharon Jones"
                        },
                        new
                        {
                            Id = new Guid("47987ac3-3e18-400a-9ee4-78f8e07b589f"),
                            AdminId = new Guid("cf981b3c-3ae4-48a1-8a8c-addc0d4ff0b9"),
                            CreatedDateTime = new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3194),
                            Name = "Mateo Lewis"
                        },
                        new
                        {
                            Id = new Guid("bbbcc325-1c9e-419c-975f-c3aaefdf09e9"),
                            AdminId = new Guid("0e014cd9-5b39-4996-ab2d-fdb9abb2c7c2"),
                            CreatedDateTime = new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3196),
                            Name = "Susan Lewis"
                        },
                        new
                        {
                            Id = new Guid("93662aea-f22d-487c-94fc-db55c37e9415"),
                            AdminId = new Guid("bfbdee55-53d1-493c-8af3-335dfb1cb5a9"),
                            CreatedDateTime = new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3199),
                            Name = "Jayden Baker"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Meeting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedDateTime");

                    b.Property<bool?>("IsActive")
                        .IsRequired()
                        .HasColumnType("bool")
                        .HasColumnName("IsActive");

                    b.Property<Guid>("LobbyId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("WinnerId")
                        .HasColumnType("uuid")
                        .HasColumnName("WinnerId");

                    b.HasKey("Id");

                    b.HasIndex("LobbyId");

                    b.ToTable("Meeting", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.UserWeight", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedDateTime");

                    b.Property<Guid>("LobbyId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LobbyId");

                    b.ToTable("UserWeight", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Film", b =>
                {
                    b.HasBaseType("Domain.Entities.EntertainmentEntity");

                    b.HasDiscriminator().HasValue(false);
                });

            modelBuilder.Entity("Domain.Entities.Series", b =>
                {
                    b.HasBaseType("Domain.Entities.EntertainmentEntity");

                    b.HasDiscriminator().HasValue(true);
                });

            modelBuilder.Entity("Domain.Entities.Meeting", b =>
                {
                    b.HasOne("Domain.Entities.Lobby", "Lobby")
                        .WithMany("Meetings")
                        .HasForeignKey("LobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lobby");
                });

            modelBuilder.Entity("Domain.Entities.UserWeight", b =>
                {
                    b.HasOne("Domain.Entities.Lobby", "Lobby")
                        .WithMany("UserWeights")
                        .HasForeignKey("LobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lobby");
                });

            modelBuilder.Entity("Domain.Entities.Lobby", b =>
                {
                    b.Navigation("Meetings");

                    b.Navigation("UserWeights");
                });
#pragma warning restore 612, 618
        }
    }
}
