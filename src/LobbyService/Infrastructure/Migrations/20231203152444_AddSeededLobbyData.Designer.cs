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
    [Migration("20231203152444_AddSeededLobbyData")]
    partial class AddSeededLobbyData
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

            modelBuilder.Entity("Domain.Entities.Lobby", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("uuid_generate_v4()");

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
                            Id = new Guid("7088c068-3e05-41d4-8280-6ecae24b30db"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3343),
                            Name = "Jackson Nelson"
                        },
                        new
                        {
                            Id = new Guid("328fc7c5-febe-4717-93ea-1ec36c9d82d4"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3347),
                            Name = "Jack Moore"
                        },
                        new
                        {
                            Id = new Guid("feacf81a-8f8e-4f65-beb2-bcf2c060355c"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3357),
                            Name = "Dylon Mitchell"
                        },
                        new
                        {
                            Id = new Guid("b362ad62-fbf9-40f8-b249-b5f4f620d75d"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3361),
                            Name = "Michelle Baker"
                        },
                        new
                        {
                            Id = new Guid("fca0a66f-27fa-453d-82a8-06e907d55c37"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3364),
                            Name = "Lucas Lewis"
                        },
                        new
                        {
                            Id = new Guid("0ba9a9a6-73d8-425d-8771-aa79445609dd"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3366),
                            Name = "Ethan Campbell"
                        },
                        new
                        {
                            Id = new Guid("d0167458-3420-45c6-b01e-4840e19afb24"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3370),
                            Name = "Melissa White"
                        },
                        new
                        {
                            Id = new Guid("120bc5d3-c07b-4082-82a1-108979530f88"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3372),
                            Name = "Jacxon Hill"
                        },
                        new
                        {
                            Id = new Guid("55bd1654-a66b-4d4f-9314-20a0e212513b"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3374),
                            Name = "Joseph Carter"
                        },
                        new
                        {
                            Id = new Guid("b098b895-59af-4a05-8a45-73655ba517a9"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3377),
                            Name = "Helen Harris"
                        },
                        new
                        {
                            Id = new Guid("d72d4288-60a8-432a-894e-07e78eb27514"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3381),
                            Name = "Danial Walker"
                        },
                        new
                        {
                            Id = new Guid("e9bfc376-cf45-4cc9-902c-59f7e27f6938"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3382),
                            Name = "John Adams"
                        },
                        new
                        {
                            Id = new Guid("a7bcb7e8-9572-46cf-8dbc-36ccf450cb16"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3384),
                            Name = "Melissa Taylor"
                        },
                        new
                        {
                            Id = new Guid("1aefa716-ac36-43d1-ae6d-113da3e09036"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3386),
                            Name = "Brenda Garcia"
                        },
                        new
                        {
                            Id = new Guid("1be18b58-abea-4046-b6c4-85d1593ef348"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3390),
                            Name = "Nancy Rivera"
                        },
                        new
                        {
                            Id = new Guid("c55cdc99-5dca-4cc6-89a4-b628b7f4c045"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3391),
                            Name = "Liam Anderson"
                        },
                        new
                        {
                            Id = new Guid("b4a90a57-8585-40c8-aeeb-e2a78f534e9c"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3393),
                            Name = "Susan Hall"
                        },
                        new
                        {
                            Id = new Guid("239be8c9-5b1c-46f1-9d2f-c0b0dabedbdc"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3396),
                            Name = "Theodore Lee"
                        },
                        new
                        {
                            Id = new Guid("c7a7c38e-0dc2-4862-b63e-8890343ef18d"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3399),
                            Name = "Patricia Thompson"
                        },
                        new
                        {
                            Id = new Guid("abf99d31-19e5-4672-83c2-d925d61bae97"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3400),
                            Name = "Isaac Nguyen"
                        },
                        new
                        {
                            Id = new Guid("93e71c1e-7602-4e8e-a063-57f89c9e3c44"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3402),
                            Name = "Mason Hall"
                        },
                        new
                        {
                            Id = new Guid("6dc49161-f6fe-4c39-ba9d-8af74b2f577f"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3426),
                            Name = "Helen Harris"
                        },
                        new
                        {
                            Id = new Guid("8906a625-8693-4f88-8d1e-2c61645b3598"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3430),
                            Name = "Sarah Nguyen"
                        },
                        new
                        {
                            Id = new Guid("3818495f-5361-4107-a430-e6238f1a9475"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3432),
                            Name = "Jacxon Rodriguez"
                        },
                        new
                        {
                            Id = new Guid("13b26f2a-4c11-4c73-88a1-ed29aafcf4fe"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3435),
                            Name = "Jessica Moore"
                        },
                        new
                        {
                            Id = new Guid("60e03da6-c3fb-4895-a0a1-0cfb9d95d030"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3437),
                            Name = "Ruth Mitchell"
                        },
                        new
                        {
                            Id = new Guid("3ff6e0d2-37b5-4ff0-b89f-8e44019121ad"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3440),
                            Name = "Carol Flores"
                        },
                        new
                        {
                            Id = new Guid("fdd9586d-ca42-46ba-acf4-b9cecbf4251e"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3442),
                            Name = "Donna Sanchez"
                        },
                        new
                        {
                            Id = new Guid("d9f09e57-d4cf-4a1c-9c82-2d99d96d0974"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3444),
                            Name = "Isaac Lee"
                        },
                        new
                        {
                            Id = new Guid("e4457dd1-3e22-49f6-8d85-8bb381133768"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3446),
                            Name = "Grayson Brown"
                        },
                        new
                        {
                            Id = new Guid("2c1ff806-7c58-49fd-9423-d5a62552a70f"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3450),
                            Name = "Henry Garcia"
                        },
                        new
                        {
                            Id = new Guid("775d1a89-d9be-4213-9b82-8dad3433779c"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3452),
                            Name = "Linda Adams"
                        },
                        new
                        {
                            Id = new Guid("2cfcdf1f-362f-4fb0-a2de-0d1f310edbc0"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3454),
                            Name = "Cynthia Scott"
                        },
                        new
                        {
                            Id = new Guid("20508e3e-f6b9-4ca7-967e-a2f11de3c3a4"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3456),
                            Name = "Lincoln Lopez"
                        },
                        new
                        {
                            Id = new Guid("cb8186d7-bc39-46ba-b64a-912db5732a9d"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3460),
                            Name = "Luke Martin"
                        },
                        new
                        {
                            Id = new Guid("2434e60f-e5d9-4e95-bffb-2e003cf6d161"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3462),
                            Name = "Luke Sanchez"
                        },
                        new
                        {
                            Id = new Guid("341c281a-f544-4158-8b25-903808f4d29d"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3464),
                            Name = "Michelle Lopez"
                        },
                        new
                        {
                            Id = new Guid("8785116e-45d7-46d2-8afd-d3e99a5d1121"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3465),
                            Name = "Margaret Ramirez"
                        },
                        new
                        {
                            Id = new Guid("c302340d-7c7f-4191-98cb-648f75da563a"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3469),
                            Name = "Owen Thomas"
                        },
                        new
                        {
                            Id = new Guid("9e7a8d59-0d8a-40c0-833a-8d41a1dbd7e0"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3470),
                            Name = "Kimberly White"
                        },
                        new
                        {
                            Id = new Guid("13a76d94-4f52-4f79-9f7c-b6e57856803a"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3473),
                            Name = "Wyatt Adams"
                        },
                        new
                        {
                            Id = new Guid("9a4f7972-e958-4b6c-a941-a1593cd2be16"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3474),
                            Name = "Angela Nguyen"
                        },
                        new
                        {
                            Id = new Guid("6fb369ce-bbe3-46c7-a5a8-a8268fa70bcc"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3478),
                            Name = "Linda Hernandez"
                        },
                        new
                        {
                            Id = new Guid("bcf8e173-85a2-49c6-9f12-0a76bec434f6"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3479),
                            Name = "Karen Green"
                        },
                        new
                        {
                            Id = new Guid("3db91276-000d-4082-bb5c-8f51dc8ed87b"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3481),
                            Name = "Maria Wilson"
                        },
                        new
                        {
                            Id = new Guid("b4e5cd25-c774-4404-9332-0170ee915822"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3483),
                            Name = "Asher Miller"
                        },
                        new
                        {
                            Id = new Guid("e2e04fea-f5bb-4c03-96cf-0de8aeb65c7b"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3486),
                            Name = "Barbara Lee"
                        },
                        new
                        {
                            Id = new Guid("102c3b9f-6f19-4fc1-91ba-b7900d1fe8ce"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3488),
                            Name = "Danial Jones"
                        },
                        new
                        {
                            Id = new Guid("3baae940-cb73-4485-9599-37d7aeda034c"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3490),
                            Name = "Nancy Jones"
                        },
                        new
                        {
                            Id = new Guid("ddbdfc84-e321-43af-9a63-c6f26b010d7f"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3492),
                            Name = "James Sanchez"
                        },
                        new
                        {
                            Id = new Guid("9fab262d-0056-4b9b-8ca7-4baa4e84f99f"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3495),
                            Name = "Anna Gonzalez"
                        },
                        new
                        {
                            Id = new Guid("2e107bb1-aced-49db-978c-821498a10358"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3497),
                            Name = "Levi Hall"
                        },
                        new
                        {
                            Id = new Guid("2461b2de-a72f-485c-8452-a74b389955a4"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3499),
                            Name = "Aiden Rodriguez"
                        },
                        new
                        {
                            Id = new Guid("81be7f6e-71ee-46b8-82a8-f5789fda7bba"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3518),
                            Name = "Michelle Moore"
                        },
                        new
                        {
                            Id = new Guid("ad2f3f77-d0b6-40cd-aeaa-d964a5c233f3"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3521),
                            Name = "Cynthia Thomas"
                        },
                        new
                        {
                            Id = new Guid("3ba0844a-b34f-42a9-a0e6-44d69ee85922"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3523),
                            Name = "Sandra Smith"
                        },
                        new
                        {
                            Id = new Guid("16f01135-be1b-4432-90b5-ea1103371de1"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3526),
                            Name = "Christopher Nguyen"
                        },
                        new
                        {
                            Id = new Guid("113f503f-4489-4476-b39e-87ea80c3fe5b"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3528),
                            Name = "Jessica Sanchez"
                        },
                        new
                        {
                            Id = new Guid("78e55d3d-6ff7-4e13-91ad-b758b8aa42f5"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3531),
                            Name = "Sharon Martin"
                        },
                        new
                        {
                            Id = new Guid("c6453dee-3e61-4fae-8764-1146022e2ad8"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3533),
                            Name = "Angela White"
                        },
                        new
                        {
                            Id = new Guid("320a65c7-f49b-44f9-af9e-d6242301dcc8"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3535),
                            Name = "Brenda Young"
                        },
                        new
                        {
                            Id = new Guid("151a9c06-b08b-453a-a452-3f9f6d36eafa"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3537),
                            Name = "Mason Scott"
                        },
                        new
                        {
                            Id = new Guid("ce8d318e-e286-42b7-a2ab-b8ae79855702"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3541),
                            Name = "William Davis"
                        },
                        new
                        {
                            Id = new Guid("371f0efa-cf9a-4049-8f00-7a109bb7ee67"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3543),
                            Name = "Jayden Nelson"
                        },
                        new
                        {
                            Id = new Guid("cb509d77-1928-40a5-b45a-225323c82830"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3545),
                            Name = "Owen Rodriguez"
                        },
                        new
                        {
                            Id = new Guid("b815445b-07b1-4b50-a435-4b747ffcf0cd"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3547),
                            Name = "Sarah Clark"
                        },
                        new
                        {
                            Id = new Guid("1448de8b-0b2c-47a7-bdd5-eafa7bc72999"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3551),
                            Name = "Jacxon Thompson"
                        },
                        new
                        {
                            Id = new Guid("014b408c-ac7d-4333-a542-4c374071d1ef"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3553),
                            Name = "Elizabeth Nelson"
                        },
                        new
                        {
                            Id = new Guid("d4ccfe0f-2d39-4276-a0bc-0268e8504801"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3555),
                            Name = "Aiden Rivera"
                        },
                        new
                        {
                            Id = new Guid("ab5a8aa7-49f5-4214-b3a2-a26b225202fc"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3557),
                            Name = "Jacob Ramirez"
                        },
                        new
                        {
                            Id = new Guid("d3d2c86f-37fa-4eec-b3d4-f64c1aef346e"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3560),
                            Name = "Angela Carter"
                        },
                        new
                        {
                            Id = new Guid("6d6bc34c-bc48-4cd1-b7c9-183bb5abdc29"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3561),
                            Name = "Michael Baker"
                        },
                        new
                        {
                            Id = new Guid("d1f8dda4-3336-4d6c-b53c-80861a82fd64"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3563),
                            Name = "Carter Baker"
                        },
                        new
                        {
                            Id = new Guid("339a7fc7-51aa-4733-90e4-5ff2ee6b7327"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3565),
                            Name = "Henry Gonzalez"
                        },
                        new
                        {
                            Id = new Guid("428e2bca-d870-4fc2-9e61-3c7dac4f7cdb"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3568),
                            Name = "Isaac Harris"
                        },
                        new
                        {
                            Id = new Guid("6be0b6d7-c23e-4c86-9518-39cb05bf52a0"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3570),
                            Name = "Jacob Walker"
                        },
                        new
                        {
                            Id = new Guid("c1019b57-127b-4db6-9bd7-fe5312ddc7be"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3572),
                            Name = "Lincoln Miller"
                        },
                        new
                        {
                            Id = new Guid("c8eef35e-0012-45ed-ab28-7e76ea6e9894"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3574),
                            Name = "Mason Lee"
                        },
                        new
                        {
                            Id = new Guid("2bde6e96-e782-4875-acaf-9e6a4f3da80a"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3577),
                            Name = "Michelle Nguyen"
                        },
                        new
                        {
                            Id = new Guid("b140fd27-a4fc-4c4d-9c6b-106eb49071b3"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3579),
                            Name = "Donna Allen"
                        },
                        new
                        {
                            Id = new Guid("c53a42e2-b658-4b10-8a38-435105269de3"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3581),
                            Name = "Sebastian Williams"
                        },
                        new
                        {
                            Id = new Guid("b5a62df3-92b6-4457-8791-4d77c95c0922"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3618),
                            Name = "Deborah Thomas"
                        },
                        new
                        {
                            Id = new Guid("32fc5116-8f04-48a4-b0eb-5539b3a489ec"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3623),
                            Name = "Leo Wright"
                        },
                        new
                        {
                            Id = new Guid("c548e79a-5884-4e30-82cb-6013bc2756cd"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3625),
                            Name = "Jessica Nelson"
                        },
                        new
                        {
                            Id = new Guid("f179a38f-d12d-45c7-a8c5-5c1b9acdcb1d"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3627),
                            Name = "Lisa Nguyen"
                        },
                        new
                        {
                            Id = new Guid("a2444940-9b5f-4b45-a4bb-c3d552987027"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3629),
                            Name = "Lisa Perez"
                        },
                        new
                        {
                            Id = new Guid("7ae1bf6b-f26a-4678-abc4-a1367c5d4a26"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3632),
                            Name = "Shirley Taylor"
                        },
                        new
                        {
                            Id = new Guid("699de902-a5cd-4272-89e9-73ba6592171d"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3635),
                            Name = "John Nguyen"
                        },
                        new
                        {
                            Id = new Guid("e17fa551-9b11-4b5f-bcf3-b3efae015c58"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3636),
                            Name = "Andre Jackson"
                        },
                        new
                        {
                            Id = new Guid("2afa1988-2d9a-47d4-b3e8-b0641ce9b043"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3638),
                            Name = "Mateo Rivera"
                        },
                        new
                        {
                            Id = new Guid("c0b1adf2-b690-4235-b1a4-54b9c82a0ab2"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3642),
                            Name = "Anthony Green"
                        },
                        new
                        {
                            Id = new Guid("46007c63-d7e2-4703-aec9-782910dbade0"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3644),
                            Name = "Lincoln Martinez"
                        },
                        new
                        {
                            Id = new Guid("b59cb294-4da6-4fab-ad35-22b140a6fb92"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3645),
                            Name = "Logan Smith"
                        },
                        new
                        {
                            Id = new Guid("2f1217de-1f74-4b7d-b523-42ab443a3e6c"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3647),
                            Name = "Jacob Wilson"
                        },
                        new
                        {
                            Id = new Guid("685d7242-f27b-48e1-ae0c-876be7624bcf"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3650),
                            Name = "Maria Carter"
                        },
                        new
                        {
                            Id = new Guid("04b42db1-b473-44f9-9818-ee628ef8fb81"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3652),
                            Name = "Lisa Campbell"
                        },
                        new
                        {
                            Id = new Guid("c325c0ad-31b4-4b3a-991c-1e8840ab9706"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3654),
                            Name = "Laura Hernandez"
                        },
                        new
                        {
                            Id = new Guid("76f03e7f-a318-43d1-bb9b-a66b06d6a3f1"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3656),
                            Name = "Asher Hall"
                        },
                        new
                        {
                            Id = new Guid("8a50612f-59c1-4338-a853-543a07ad8f7b"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3659),
                            Name = "Leo Davis"
                        },
                        new
                        {
                            Id = new Guid("78351a38-8fa2-42a8-8bc4-f34b40f30232"),
                            CreatedDateTime = new DateTime(2023, 12, 3, 15, 24, 44, 732, DateTimeKind.Utc).AddTicks(3661),
                            Name = "Alexander Jackson"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
