﻿// <auto-generated />
using System;
using AccuGazer.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccuGazer.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("AccuGazer.API.Models.GazePoint", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("X");

                    b.Property<int>("Y");

                    b.HasKey("Id");

                    b.ToTable("GazePoints");
                });

            modelBuilder.Entity("AccuGazer.API.Models.Measurement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("GazePointId");

                    b.Property<bool>("IsHit");

                    b.Property<long>("MeasuredAt");

                    b.Property<long>("RectangleId");

                    b.Property<long?>("TestResultId");

                    b.HasKey("Id");

                    b.HasIndex("GazePointId");

                    b.HasIndex("RectangleId");

                    b.HasIndex("TestResultId");

                    b.ToTable("Measurements");
                });

            modelBuilder.Entity("AccuGazer.API.Models.Rectangle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Height");

                    b.Property<int>("Width");

                    b.Property<int>("X");

                    b.Property<int>("Y");

                    b.HasKey("Id");

                    b.ToTable("Rectangles");
                });

            modelBuilder.Entity("AccuGazer.API.Models.Settings", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NumberOfTests");

                    b.Property<bool>("Shuffle");

                    b.Property<long>("TestDurationInSeconds");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("AccuGazer.API.Models.Test", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("EndTime");

                    b.Property<long>("StartTime");

                    b.Property<long>("TestResultId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TestResultId");

                    b.HasIndex("UserId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("AccuGazer.API.Models.TestResult", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ScreenHeight");

                    b.Property<int>("ScreenWidth");

                    b.HasKey("Id");

                    b.ToTable("TestResults");
                });

            modelBuilder.Entity("AccuGazer.API.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("PassswordSalt");

                    b.Property<byte[]>("PasswordHash");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AccuGazer.API.Models.Measurement", b =>
                {
                    b.HasOne("AccuGazer.API.Models.GazePoint", "GazePoint")
                        .WithMany()
                        .HasForeignKey("GazePointId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AccuGazer.API.Models.Rectangle", "Rectangle")
                        .WithMany()
                        .HasForeignKey("RectangleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AccuGazer.API.Models.TestResult")
                        .WithMany("Measurements")
                        .HasForeignKey("TestResultId");
                });

            modelBuilder.Entity("AccuGazer.API.Models.Test", b =>
                {
                    b.HasOne("AccuGazer.API.Models.TestResult", "TestResult")
                        .WithMany()
                        .HasForeignKey("TestResultId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AccuGazer.API.Models.User", "User")
                        .WithMany("tests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
