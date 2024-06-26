﻿// <auto-generated />
using System;
using HastaneOtomasyonu.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HastaneOtomasyonu.DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240415162515_8")]
    partial class _8
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HastaneOtomasyonu.EntityLayer.Models.Entity.Giris", b =>
                {
                    b.Property<int>("GirisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GirisId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GirisId");

                    b.HasIndex("PersonelID");

                    b.ToTable("Girises");
                });

            modelBuilder.Entity("HastaneOtomasyonu.EntityLayer.Models.Entity.Hasta", b =>
                {
                    b.Property<int>("HastaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HastaID"));

                    b.Property<string>("HastaAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HastaSoyadı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HastaTCNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hastalık")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KanGrubu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HastaID");

                    b.ToTable("Hastas");
                });

            modelBuilder.Entity("HastaneOtomasyonu.EntityLayer.Models.Entity.Klinik", b =>
                {
                    b.Property<int>("KlinikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KlinikID"));

                    b.Property<string>("KlinikAdı")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar");

                    b.Property<int>("PoliklinikID")
                        .HasColumnType("int");

                    b.HasKey("KlinikID");

                    b.HasIndex("PoliklinikID");

                    b.ToTable("Kliniks");
                });

            modelBuilder.Entity("HastaneOtomasyonu.EntityLayer.Models.Entity.Muayane", b =>
                {
                    b.Property<int>("MuayaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MuayaneId"));

                    b.Property<int>("HastaID")
                        .HasColumnType("int");

                    b.Property<int>("KlinikID")
                        .HasColumnType("int");

                    b.Property<DateTime>("MuayaneZamanı")
                        .HasColumnType("datetime2");

                    b.Property<int>("PoliklinikID")
                        .HasColumnType("int");

                    b.Property<string>("Teshis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MuayaneId");

                    b.HasIndex("HastaID");

                    b.HasIndex("KlinikID");

                    b.ToTable("Muayanes");
                });

            modelBuilder.Entity("HastaneOtomasyonu.EntityLayer.Models.Entity.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelID"));

                    b.Property<int>("KlinikID")
                        .HasColumnType("int");

                    b.Property<string>("PersonelAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonelSoyadı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonelID");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("HastaneOtomasyonu.EntityLayer.Models.Entity.Poliklinik", b =>
                {
                    b.Property<int>("PoliklinikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PoliklinikID"));

                    b.Property<string>("PoliklinikAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PoliklinikID");

                    b.ToTable("Polikliniks");
                });

            modelBuilder.Entity("HastaneOtomasyonu.EntityLayer.Models.Entity.Giris", b =>
                {
                    b.HasOne("HastaneOtomasyonu.EntityLayer.Models.Entity.Personel", "Personel")
                        .WithMany()
                        .HasForeignKey("PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("HastaneOtomasyonu.EntityLayer.Models.Entity.Klinik", b =>
                {
                    b.HasOne("HastaneOtomasyonu.EntityLayer.Models.Entity.Poliklinik", "Poliklinik")
                        .WithMany()
                        .HasForeignKey("PoliklinikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poliklinik");
                });

            modelBuilder.Entity("HastaneOtomasyonu.EntityLayer.Models.Entity.Muayane", b =>
                {
                    b.HasOne("HastaneOtomasyonu.EntityLayer.Models.Entity.Hasta", "hasta")
                        .WithMany("Muayane")
                        .HasForeignKey("HastaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HastaneOtomasyonu.EntityLayer.Models.Entity.Klinik", "klinik")
                        .WithMany()
                        .HasForeignKey("KlinikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hasta");

                    b.Navigation("klinik");
                });

            modelBuilder.Entity("HastaneOtomasyonu.EntityLayer.Models.Entity.Hasta", b =>
                {
                    b.Navigation("Muayane");
                });
#pragma warning restore 612, 618
        }
    }
}
