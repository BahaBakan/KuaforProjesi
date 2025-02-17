﻿// <auto-generated />
using System;
using KuaforProjesi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KuaforProjesi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241223032522_RandevuSınıfıdüzenlendiCreateClaisanIslem")]
    partial class RandevuSınıfıdüzenlendiCreateClaisanIslem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("KuaforProjesi.Data.Calisanlarimiz", b =>
                {
                    b.Property<int>("CalisanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UzmanlikAlani")
                        .HasColumnType("TEXT");

                    b.Property<string>("calismaSaati")
                        .HasColumnType("TEXT");

                    b.HasKey("CalisanId");

                    b.ToTable("Calisanlarimiz");
                });

            modelBuilder.Entity("KuaforProjesi.Data.Islem", b =>
                {
                    b.Property<int>("IslemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IslemAdi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("fiyati")
                        .HasColumnType("INTEGER");

                    b.HasKey("IslemId");

                    b.ToTable("Islemler");
                });

            modelBuilder.Entity("KuaforProjesi.Data.IslemCalisan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CalisanId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IslemId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CalisanId");

                    b.HasIndex("IslemId");

                    b.ToTable("IslemCalisanlar");
                });

            modelBuilder.Entity("KuaforProjesi.Data.Randevu", b =>
                {
                    b.Property<int>("RandevuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CalisanlarimizCalisanId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IslemAdi")
                        .HasColumnType("TEXT");

                    b.Property<int>("IslemId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MusteriAdi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Saat")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("TEXT");

                    b.Property<string>("calisanAdi")
                        .HasColumnType("TEXT");

                    b.HasKey("RandevuId");

                    b.HasIndex("CalisanlarimizCalisanId");

                    b.HasIndex("IslemId");

                    b.ToTable("Randevular");
                });

            modelBuilder.Entity("KuaforProjesi.Data.Register", b =>
                {
                    b.Property<int>("RegisterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Eposta")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sifre")
                        .HasColumnType("TEXT");

                    b.HasKey("RegisterId");

                    b.ToTable("Registers");
                });

            modelBuilder.Entity("KuaforProjesi.Data.IslemCalisan", b =>
                {
                    b.HasOne("KuaforProjesi.Data.Calisanlarimiz", "Calisan")
                        .WithMany("IslemCalisanlar")
                        .HasForeignKey("CalisanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KuaforProjesi.Data.Islem", "Islem")
                        .WithMany("IslemCalisanlar")
                        .HasForeignKey("IslemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calisan");

                    b.Navigation("Islem");
                });

            modelBuilder.Entity("KuaforProjesi.Data.Randevu", b =>
                {
                    b.HasOne("KuaforProjesi.Data.Calisanlarimiz", null)
                        .WithMany("randevular")
                        .HasForeignKey("CalisanlarimizCalisanId");

                    b.HasOne("KuaforProjesi.Data.Islem", "Islem")
                        .WithMany()
                        .HasForeignKey("IslemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Islem");
                });

            modelBuilder.Entity("KuaforProjesi.Data.Calisanlarimiz", b =>
                {
                    b.Navigation("IslemCalisanlar");

                    b.Navigation("randevular");
                });

            modelBuilder.Entity("KuaforProjesi.Data.Islem", b =>
                {
                    b.Navigation("IslemCalisanlar");
                });
#pragma warning restore 612, 618
        }
    }
}
