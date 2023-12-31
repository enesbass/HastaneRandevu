﻿// <auto-generated />
using System;
using HastaneRandevu.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HastaneRandevu.DAL.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20230816104214_hastalar")]
    partial class hastalar
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoktorHasta", b =>
                {
                    b.Property<int>("DoktorlarId")
                        .HasColumnType("int");

                    b.Property<int>("HastalarId")
                        .HasColumnType("int");

                    b.HasKey("DoktorlarId", "HastalarId");

                    b.HasIndex("HastalarId");

                    b.ToTable("DoktorHasta");
                });

            modelBuilder.Entity("HastaneRandevu.Entity.Concrete.Bolum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BolumAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 16, 13, 42, 14, 367, DateTimeKind.Local).AddTicks(2887));

                    b.HasKey("Id");

                    b.HasIndex("BolumAdi")
                        .IsUnique();

                    b.ToTable("Bolumler");
                });

            modelBuilder.Entity("HastaneRandevu.Entity.Concrete.Doktor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BolumId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 16, 13, 42, 14, 367, DateTimeKind.Local).AddTicks(5288));

                    b.Property<string>("DrAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DrSoyadi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BolumId");

                    b.ToTable("Doktorlar");
                });

            modelBuilder.Entity("HastaneRandevu.Entity.Concrete.Hasta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cinsiyeti")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 16, 13, 42, 14, 367, DateTimeKind.Local).AddTicks(6876));

                    b.Property<DateTime?>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("HastaAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HastaSoyadi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HastaTcNo")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Hastalar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cinsiyeti = "Erkek",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HastaAdi = "Ali",
                            HastaSoyadi = "Yilmaz",
                            HastaTcNo = "12345678901"
                        },
                        new
                        {
                            Id = 2,
                            Cinsiyeti = "Erkek",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HastaAdi = "Hasan",
                            HastaSoyadi = "Kaya",
                            HastaTcNo = "12345678902"
                        });
                });

            modelBuilder.Entity("HastaneRandevu.Entity.Concrete.Randevu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BolumId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 16, 13, 42, 14, 367, DateTimeKind.Local).AddTicks(8544));

                    b.Property<int?>("DoktorId")
                        .HasColumnType("int");

                    b.Property<int?>("HastaId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("RandevuSaati")
                        .HasColumnType("time");

                    b.Property<DateTime>("RandevuTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BolumId");

                    b.HasIndex("DoktorId");

                    b.HasIndex("HastaId");

                    b.ToTable("Randevular");
                });

            modelBuilder.Entity("DoktorHasta", b =>
                {
                    b.HasOne("HastaneRandevu.Entity.Concrete.Doktor", null)
                        .WithMany()
                        .HasForeignKey("DoktorlarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HastaneRandevu.Entity.Concrete.Hasta", null)
                        .WithMany()
                        .HasForeignKey("HastalarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HastaneRandevu.Entity.Concrete.Doktor", b =>
                {
                    b.HasOne("HastaneRandevu.Entity.Concrete.Bolum", "Bolum")
                        .WithMany("Doktorlar")
                        .HasForeignKey("BolumId");

                    b.Navigation("Bolum");
                });

            modelBuilder.Entity("HastaneRandevu.Entity.Concrete.Randevu", b =>
                {
                    b.HasOne("HastaneRandevu.Entity.Concrete.Bolum", "Bolum")
                        .WithMany("Randevular")
                        .HasForeignKey("BolumId");

                    b.HasOne("HastaneRandevu.Entity.Concrete.Doktor", "Doktor")
                        .WithMany("Randevular")
                        .HasForeignKey("DoktorId");

                    b.HasOne("HastaneRandevu.Entity.Concrete.Hasta", "Hasta")
                        .WithMany("Randevular")
                        .HasForeignKey("HastaId");

                    b.Navigation("Bolum");

                    b.Navigation("Doktor");

                    b.Navigation("Hasta");
                });

            modelBuilder.Entity("HastaneRandevu.Entity.Concrete.Bolum", b =>
                {
                    b.Navigation("Doktorlar");

                    b.Navigation("Randevular");
                });

            modelBuilder.Entity("HastaneRandevu.Entity.Concrete.Doktor", b =>
                {
                    b.Navigation("Randevular");
                });

            modelBuilder.Entity("HastaneRandevu.Entity.Concrete.Hasta", b =>
                {
                    b.Navigation("Randevular");
                });
#pragma warning restore 612, 618
        }
    }
}
