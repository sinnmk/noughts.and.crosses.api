﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using noughtsandcrosses.api.Repositories;

namespace noughtsandcrosses.api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181217163651_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("noughtsandcrosses.api.Repositories.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BoardDimension");

                    b.Property<int>("GameLevel");

                    b.Property<bool>("IsGameOver");

                    b.Property<bool>("IsGameWon");

                    b.Property<int>("TurnChoice");

                    b.HasKey("GameId");

                    b.ToTable("Games");
                });
#pragma warning restore 612, 618
        }
    }
}