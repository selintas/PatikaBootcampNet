﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SurvivorApı.Data;

#nullable disable

namespace SurvivorApı.Migrations
{
    [DbContext(typeof(SurvivorDbContext))]
    [Migration("20250105194657_Ilk")]
    partial class Ilk
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SurvivorApı.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 1, 7, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            Name = "Unluler",
                            UpdatedDate = new DateTime(2024, 1, 1, 7, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 1, 7, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            Name = "Gönüllüler",
                            UpdatedDate = new DateTime(2024, 1, 1, 7, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("SurvivorApı.Models.Competitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Competitors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Acun",
                            IsDeleted = false,
                            LastName = "Ilıcalı",
                            UpdatedDate = new DateTime(2024, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("SurvivorApı.Models.Competitor", b =>
                {
                    b.HasOne("SurvivorApı.Models.Category", "Category")
                        .WithMany("Competitors")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SurvivorApı.Models.Category", b =>
                {
                    b.Navigation("Competitors");
                });
#pragma warning restore 612, 618
        }
    }
}
