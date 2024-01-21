﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(LobbyDbContext))]
    partial class LobbyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("varchar")
                        .HasColumnName("Description");

                    b.Property<int>("FilmLength")
                        .HasColumnType("integer")
                        .HasColumnName("FilmLength");

                    b.Property<string>("ImdbId")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("ImdbId");

                    b.Property<bool>("IsSeries")
                        .HasColumnType("boolean");

                    b.Property<int>("KinopoiskId")
                        .HasColumnType("int")
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

                    b.ToTable("EntertainmentEntities");

                    b.HasDiscriminator<bool>("IsSeries");

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
                            Id = new Guid("253857ff-39a4-4c4b-a25a-415526bf920a"),
                            AdminId = new Guid("a152a4ae-0634-471e-a966-4413d3b3a6f0"),
                            CreatedDateTime = new DateTime(2024, 1, 21, 15, 32, 14, 845, DateTimeKind.Utc).AddTicks(3635),
                            Name = "tatapuchi"
                        },
                        new
                        {
                            Id = new Guid("2343e924-272b-4114-ba99-2a1f3a8787dc"),
                            AdminId = new Guid("2b634477-5420-42ed-bf11-eb5c04cd48f2"),
                            CreatedDateTime = new DateTime(2024, 1, 21, 15, 32, 14, 845, DateTimeKind.Utc).AddTicks(3662),
                            Name = "@mogu$"
                        },
                        new
                        {
                            Id = new Guid("746f4cab-0854-4a76-941f-7aefd2997f87"),
                            AdminId = new Guid("51d9a091-8a0c-4df7-a307-a5f1bbbe8e2c"),
                            CreatedDateTime = new DateTime(2024, 1, 21, 15, 32, 14, 845, DateTimeKind.Utc).AddTicks(3685),
                            Name = "ch33bs"
                        });
                });

            modelBuilder.Entity("Domain.Entities.LobbySettings", b =>
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

                    b.Property<float>("MinimalRating")
                        .HasColumnType("real");

                    b.Property<int>("MoviesPerUser")
                        .HasColumnType("integer");

                    b.Property<bool>("WithKoefficient")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("LobbyId")
                        .IsUnique();

                    b.ToTable("LobbySettings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9ab5bc41-0b1e-4e68-9de7-800ecd71419a"),
                            CreatedDateTime = new DateTime(2024, 1, 21, 15, 32, 14, 845, DateTimeKind.Utc).AddTicks(3744),
                            LobbyId = new Guid("253857ff-39a4-4c4b-a25a-415526bf920a"),
                            MinimalRating = 7.5f,
                            MoviesPerUser = 2,
                            WithKoefficient = true
                        },
                        new
                        {
                            Id = new Guid("28207ac9-35b4-4737-8f9f-bc92beb48eac"),
                            CreatedDateTime = new DateTime(2024, 1, 21, 15, 32, 14, 845, DateTimeKind.Utc).AddTicks(3748),
                            LobbyId = new Guid("2343e924-272b-4114-ba99-2a1f3a8787dc"),
                            MinimalRating = 7.5f,
                            MoviesPerUser = 2,
                            WithKoefficient = true
                        },
                        new
                        {
                            Id = new Guid("2f8ec210-ffd7-4e1e-be07-5c8b045b03bb"),
                            CreatedDateTime = new DateTime(2024, 1, 21, 15, 32, 14, 845, DateTimeKind.Utc).AddTicks(3750),
                            LobbyId = new Guid("746f4cab-0854-4a76-941f-7aefd2997f87"),
                            MinimalRating = 7.5f,
                            MoviesPerUser = 2,
                            WithKoefficient = true
                        });
                });

            modelBuilder.Entity("Domain.Entities.LobbyUser", b =>
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

                    b.ToTable("LobbyUser", (string)null);
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

                    b.Property<Guid?>("WinnerEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("WinnerId")
                        .HasColumnType("uuid")
                        .HasColumnName("WinnerId");

                    b.HasKey("Id");

                    b.HasIndex("LobbyId");

                    b.HasIndex("WinnerEntityId");

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

            modelBuilder.Entity("Domain.Entities.LobbySettings", b =>
                {
                    b.HasOne("Domain.Entities.Lobby", "Lobby")
                        .WithOne("LobbySettings")
                        .HasForeignKey("Domain.Entities.LobbySettings", "LobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lobby");
                });

            modelBuilder.Entity("Domain.Entities.LobbyUser", b =>
                {
                    b.HasOne("Domain.Entities.Lobby", "Lobby")
                        .WithMany("LobbyUsers")
                        .HasForeignKey("LobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lobby");
                });

            modelBuilder.Entity("Domain.Entities.Meeting", b =>
                {
                    b.HasOne("Domain.Entities.Lobby", "Lobby")
                        .WithMany("Meetings")
                        .HasForeignKey("LobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.EntertainmentEntity", "WinnerEntity")
                        .WithMany()
                        .HasForeignKey("WinnerEntityId");

                    b.Navigation("Lobby");

                    b.Navigation("WinnerEntity");
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
                    b.Navigation("LobbySettings");

                    b.Navigation("LobbyUsers");

                    b.Navigation("Meetings");

                    b.Navigation("UserWeights");
                });
#pragma warning restore 612, 618
        }
    }
}
