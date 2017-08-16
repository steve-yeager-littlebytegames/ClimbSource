﻿// <auto-generated />
using Climb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Climb.Migrations
{
    [DbContext(typeof(ClimbContext))]
    [Migration("20170816160226_AddedSeasons")]
    partial class AddedSeasons
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Climb.Models.Game", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("Climb.Models.League", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GameID");

                    b.Property<string>("Name");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("GameID");

                    b.HasIndex("UserID");

                    b.ToTable("League");
                });

            modelBuilder.Entity("Climb.Models.Season", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("Season");
                });

            modelBuilder.Entity("Climb.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Climb.Models.League", b =>
                {
                    b.HasOne("Climb.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Climb.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
