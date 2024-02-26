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
    [Migration("20240225114249_nullableProperties")]
    partial class nullableProperties
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

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("varchar")
                        .HasColumnName("Description");

                    b.Property<int?>("FilmLength")
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

                    b.Property<double?>("RatingImdb")
                        .HasColumnType("double precision")
                        .HasColumnName("RatingImdb");

                    b.Property<double?>("RatingKinopoisk")
                        .HasColumnType("double precision")
                        .HasColumnName("RatingKinopoisk");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("varchar")
                        .HasColumnName("ShortDescription");

                    b.Property<string>("WebUrl")
                        .HasColumnType("varchar")
                        .HasColumnName("WebUrl");

                    b.Property<int?>("Year")
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

                    b.Property<double>("MinimalRating")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("double precision")
                        .HasDefaultValue(1.0)
                        .HasColumnName("MinimalRating");

                    b.Property<int>("MoviesPerUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1)
                        .HasColumnName("MoviesPerUser");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<bool>("WithCoefficient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("WithCoefficient");

                    b.HasKey("Id");

                    b.ToTable("Lobby", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c7ac4319-bc01-4b52-99ec-8f573a905c77"),
                            AdminId = new Guid("b5c17515-c708-4392-a5c7-6137e9cb2964"),
                            CreatedDateTime = new DateTime(2024, 2, 25, 11, 42, 48, 908, DateTimeKind.Utc).AddTicks(4231),
                            MinimalRating = 7.5,
                            MoviesPerUser = 2,
                            Name = "t@t@puchi",
                            WithCoefficient = true
                        },
                        new
                        {
                            Id = new Guid("73dc409e-9385-4f3d-a6f2-7a9a7628d707"),
                            AdminId = new Guid("6574235b-7cfb-45ca-a8ef-ced7baf6f2d6"),
                            CreatedDateTime = new DateTime(2024, 2, 25, 11, 42, 48, 908, DateTimeKind.Utc).AddTicks(4257),
                            MinimalRating = 7.5,
                            MoviesPerUser = 2,
                            Name = "guagg",
                            WithCoefficient = true
                        },
                        new
                        {
                            Id = new Guid("47fdeb74-078e-49d4-a35a-020aad3d0514"),
                            AdminId = new Guid("ced8a9d5-5312-4f03-8823-17e7cc91af52"),
                            CreatedDateTime = new DateTime(2024, 2, 25, 11, 42, 48, 908, DateTimeKind.Utc).AddTicks(4268),
                            MinimalRating = 7.5,
                            MoviesPerUser = 2,
                            Name = "krab",
                            WithCoefficient = true
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

            modelBuilder.Entity("Domain.Entities.MeetingEntertainmentEntityLink", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedDateTime");

                    b.Property<Guid>("EntertainmentEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MeetingId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("EntertainmentEntityId");

                    b.HasIndex("MeetingId");

                    b.ToTable("MeetingEntertainmentEntityLink", (string)null);
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

            modelBuilder.Entity("Domain.Entities.MeetingEntertainmentEntityLink", b =>
                {
                    b.HasOne("Domain.Entities.EntertainmentEntity", "EntertainmentEntity")
                        .WithMany()
                        .HasForeignKey("EntertainmentEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Meeting", "Meeting")
                        .WithMany()
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntertainmentEntity");

                    b.Navigation("Meeting");
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
                    b.Navigation("LobbyUsers");

                    b.Navigation("Meetings");

                    b.Navigation("UserWeights");
                });
#pragma warning restore 612, 618
        }
    }
}