﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PFEBackend.Models;

#nullable disable

namespace PFEBackend.Migrations
{
    [DbContext(typeof(VinciMarketContext))]
    [Migration("20211214021508_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PFEBackend.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Maison et Jardin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Outils",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Meubles",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Pour la maison",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Jardin",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 6,
                            Name = "Electroménager",
                            ParentId = 1
                        },
                        new
                        {
                            Id = 7,
                            Name = "Famille"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Santé et beauté",
                            ParentId = 7
                        },
                        new
                        {
                            Id = 9,
                            Name = "Fournitures pour animaux",
                            ParentId = 7
                        },
                        new
                        {
                            Id = 10,
                            Name = "Puériculture et enfants",
                            ParentId = 7
                        },
                        new
                        {
                            Id = 11,
                            Name = "Jouets et jeux",
                            ParentId = 7
                        },
                        new
                        {
                            Id = 12,
                            Name = "Vêtements et accessoires"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Sacs et bagages",
                            ParentId = 12
                        },
                        new
                        {
                            Id = 14,
                            Name = "Vêtements et chaussures femmes",
                            ParentId = 12
                        },
                        new
                        {
                            Id = 15,
                            Name = "Vêtements et chaussures hommes",
                            ParentId = 12
                        },
                        new
                        {
                            Id = 16,
                            Name = "Bijoux et accessoires",
                            ParentId = 12
                        },
                        new
                        {
                            Id = 17,
                            Name = "Loisirs - hobbys"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Vélos",
                            ParentId = 17
                        },
                        new
                        {
                            Id = 19,
                            Name = "Loisirs créatifs",
                            ParentId = 17
                        },
                        new
                        {
                            Id = 20,
                            Name = "Pièces auto",
                            ParentId = 17
                        },
                        new
                        {
                            Id = 21,
                            Name = "Sports et activités d’extérieures",
                            ParentId = 17
                        },
                        new
                        {
                            Id = 22,
                            Name = "Jeux vidéo",
                            ParentId = 17
                        },
                        new
                        {
                            Id = 23,
                            Name = "Livres, films et musique",
                            ParentId = 17
                        },
                        new
                        {
                            Id = 24,
                            Name = "Instruments de musique",
                            ParentId = 17
                        },
                        new
                        {
                            Id = 25,
                            Name = "Antiquité et objets de collection",
                            ParentId = 17
                        },
                        new
                        {
                            Id = 26,
                            Name = "Electronique"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Electronique et ordinateurs",
                            ParentId = 26
                        },
                        new
                        {
                            Id = 28,
                            Name = "Téléphones mobiles",
                            ParentId = 26
                        },
                        new
                        {
                            Id = 29,
                            Name = "Autres"
                        });
                });

            modelBuilder.Entity("PFEBackend.Models.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OfferId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OfferId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("PFEBackend.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CountReport")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Place")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Seller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerEMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Offers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 5,
                            CountReport = 0,
                            Deleted = false,
                            Description = "Tondeuse de luxe automatique",
                            Place = 0,
                            Price = 100.01000000000001,
                            Seller = "60038da5-5166-40c7-a6f8-8988e4c3cb9f",
                            SellerEMail = "vendeur@pfegrp5.onmicrosoft.com",
                            State = 0,
                            Title = "Tondeuse",
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 5,
                            CountReport = 0,
                            Deleted = true,
                            Description = "Tondeuse de luxe automatique",
                            Place = 0,
                            Price = 100.01000000000001,
                            Seller = "60038da5-5166-40c7-a6f8-8988e4c3cb9f",
                            SellerEMail = "vendeur@pfegrp5.onmicrosoft.com",
                            State = 0,
                            Title = "TondeuseDeleted",
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 5,
                            CountReport = 0,
                            Deleted = false,
                            Description = "Tondeuse de luxe automatique",
                            Place = 1,
                            Price = 99.989999999999995,
                            Seller = "60038da5-5166-40c7-a6f8-8988e4c3cb9f",
                            SellerEMail = "vendeur@pfegrp5.onmicrosoft.com",
                            State = 0,
                            Title = "TondeuseIxelles",
                            Type = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 6,
                            CountReport = 0,
                            Deleted = false,
                            Description = "Tondeuse de luxe automatique",
                            Place = 1,
                            Price = 99.989999999999995,
                            Seller = "60038da5-5166-40c7-a6f8-8988e4c3cb9f",
                            SellerEMail = "vendeur@pfegrp5.onmicrosoft.com",
                            State = 0,
                            Title = "TondeuseCheveux",
                            Type = 1
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 6,
                            CountReport = 0,
                            Deleted = false,
                            Description = "Tondeuse de luxe automatique",
                            Place = 2,
                            Price = 99.989999999999995,
                            Seller = "60038da5-5166-40c7-a6f8-8988e4c3cb9f",
                            SellerEMail = "vendeur@pfegrp5.onmicrosoft.com",
                            State = 0,
                            Title = "TondeuseCheveux",
                            Type = 1
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 5,
                            CountReport = 0,
                            Deleted = false,
                            Description = "Tondeuse de luxe automatique",
                            Place = 1,
                            Price = 99.989999999999995,
                            Seller = "60038da5-5166-40c7-a6f8-8988e4c3cb9f",
                            SellerEMail = "vendeur@pfegrp5.onmicrosoft.com",
                            State = 1,
                            Title = "TondeuseVendue",
                            Type = 1
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 5,
                            CountReport = 0,
                            Deleted = false,
                            Description = "Tondeuse de luxe automatique",
                            Place = 1,
                            Price = 99.989999999999995,
                            Seller = "60038da5-5166-40c7-a6f8-8988e4c3cb9f",
                            SellerEMail = "vendeur@pfegrp5.onmicrosoft.com",
                            State = 2,
                            Title = "TondeuseInvisible",
                            Type = 1
                        });
                });

            modelBuilder.Entity("PFEBackend.Models.Category", b =>
                {
                    b.HasOne("PFEBackend.Models.Category", "Parent")
                        .WithMany("ChildCategories")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("PFEBackend.Models.Media", b =>
                {
                    b.HasOne("PFEBackend.Models.Offer", "Offer")
                        .WithMany()
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("PFEBackend.Models.Category", b =>
                {
                    b.Navigation("ChildCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
