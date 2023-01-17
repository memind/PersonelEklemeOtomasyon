﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _02_Data_Access;

#nullable disable

namespace _02DataAccess.Migrations
{
    [DbContext(typeof(PersonelContext))]
    [Migration("20230114131102_1")]
    partial class _1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_01_Entity.IletisimBilgisi", b =>
                {
                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar");

                    b.HasKey("PersonelId");

                    b.ToTable("IletisimBilgileri", (string)null);
                });

            modelBuilder.Entity("_01_Entity.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelID"));

                    b.Property<string>("Birim")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Soyisim")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TcKimlikNo")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("char");

                    b.HasKey("PersonelID");

                    b.ToTable("Personeller", (string)null);
                });

            modelBuilder.Entity("_01_Entity.IletisimBilgisi", b =>
                {
                    b.HasOne("_01_Entity.Personel", "Personel")
                        .WithOne("IletisimBilgisi")
                        .HasForeignKey("_01_Entity.IletisimBilgisi", "PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("_01_Entity.Personel", b =>
                {
                    b.Navigation("IletisimBilgisi")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
