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
    [Migration("20240127171218_UpdateLobbySettings")]
    partial class UpdateLobbySettings
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
                            Id = new Guid("f6a82301-492b-4823-a99e-9cadc170f8bf"),
                            AdminId = new Guid("6babba78-6b9e-4f2f-83dc-3c2d2a3e6cc0"),
                            CreatedDateTime = new DateTime(2024, 1, 27, 17, 12, 17, 880, DateTimeKind.Utc).AddTicks(9598),
                            MinimalRating = 7.5,
                            MoviesPerUser = 2,
                            Name = "13_wacky_dog3",
                            WithCoefficient = true
                        },
                        new
                        {
                            Id = new Guid("69574a7a-7901-4276-82cb-db9fef200ac1"),
                            AdminId = new Guid("3289df17-e89a-41ec-bce8-576e5819b7b8"),
                            CreatedDateTime = new DateTime(2024, 1, 27, 17, 12, 17, 880, DateTimeKind.Utc).AddTicks(9688),
                            MinimalRating = 7.5,
                            MoviesPerUser = 2,
                            Name = "shu@gg",
                            WithCoefficient = true
                        },
                        new
                        {
                            Id = new Guid("b8b93828-8935-44c2-915a-62eb1dabed64"),
                            AdminId = new Guid("f6da600e-43c5-4f5c-8a9b-ea24f6324799"),
                            CreatedDateTime = new DateTime(2024, 1, 27, 17, 12, 17, 880, DateTimeKind.Utc).AddTicks(9728),
                            MinimalRating = 7.5,
                            MoviesPerUser = 2,
                            Name = "b01b",
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
                        .WithMany("MeetingEntertainmentEntityLinks")
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

            modelBuilder.Entity("Domain.Entities.Meeting", b =>
                {
                    b.Navigation("MeetingEntertainmentEntityLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
