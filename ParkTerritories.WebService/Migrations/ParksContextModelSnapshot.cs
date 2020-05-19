﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkTerritories.InfrastructureServices.Gateways.Database;

namespace ParkTerritories.WebService.Migrations
{
    [DbContext(typeof(ParksContext))]
    partial class ParksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("ParkTerritories.DomainObjects.Park", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PlayGround")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SportsGround")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Water")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Location = "Главный вход в парк расположен со стороны улицы Косыгина, рельеф местности спокойный, резкопересечённый, с перепадом высот до 30 м, площадки и дорожки выложены плиткой и асфальтом, за корпусами расположен парк с многолетними деревьями",
                            Name = "Памятник садово-паркового искусства – «Парк Дворца творчества детей и юношества» по адресу ул.Косыгина д.17",
                            PlayGround = 1,
                            SportsGround = 1,
                            Water = "нет"
                        },
                        new
                        {
                            Id = 2L,
                            Location = "улица Большая Филёвская, дом 9",
                            Name = "Детский парк «Фили»",
                            PlayGround = 0,
                            SportsGround = 1,
                            Water = "нет"
                        },
                        new
                        {
                            Id = 3L,
                            Location = "Восточная часть района Ясенево",
                            Name = "Природно-исторический парк «Битцевский лес»",
                            PlayGround = 0,
                            SportsGround = 0,
                            Water = "нет"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
