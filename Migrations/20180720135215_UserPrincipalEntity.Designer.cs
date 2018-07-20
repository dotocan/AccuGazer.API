﻿// <auto-generated />
using System;
using AccuGazer.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccuGazer.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180720135215_UserPrincipalEntity")]
    partial class UserPrincipalEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("AccuGazer.API.Models.GazePoint", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("MeasurementId");

                    b.Property<int>("X");

                    b.Property<int>("Y");

                    b.HasKey("Id");

                    b.HasIndex("MeasurementId")
                        .IsUnique();

                    b.ToTable("GazePoints");
                });

            modelBuilder.Entity("AccuGazer.API.Models.Measurement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsHit");

                    b.Property<long>("MeasuredAt");

                    b.Property<long?>("TestResultId");

                    b.HasKey("Id");

                    b.HasIndex("TestResultId");

                    b.ToTable("Measurements");
                });

            modelBuilder.Entity("AccuGazer.API.Models.Rectangle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Height");

                    b.Property<long>("MeasurementId");

                    b.Property<int>("Width");

                    b.Property<int>("X");

                    b.Property<int>("Y");

                    b.HasKey("Id");

                    b.HasIndex("MeasurementId")
                        .IsUnique();

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

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("AccuGazer.API.Models.TestResult", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ScreenHeight");

                    b.Property<int>("ScreenWidth");

                    b.Property<long>("TestId");

                    b.HasKey("Id");

                    b.HasIndex("TestId")
                        .IsUnique();

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

            modelBuilder.Entity("AccuGazer.API.Models.GazePoint", b =>
                {
                    b.HasOne("AccuGazer.API.Models.Measurement", "Measurement")
                        .WithOne("GazePoint")
                        .HasForeignKey("AccuGazer.API.Models.GazePoint", "MeasurementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AccuGazer.API.Models.Measurement", b =>
                {
                    b.HasOne("AccuGazer.API.Models.TestResult")
                        .WithMany("Measurements")
                        .HasForeignKey("TestResultId");
                });

            modelBuilder.Entity("AccuGazer.API.Models.Rectangle", b =>
                {
                    b.HasOne("AccuGazer.API.Models.Measurement", "Measurement")
                        .WithOne("Rectangle")
                        .HasForeignKey("AccuGazer.API.Models.Rectangle", "MeasurementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AccuGazer.API.Models.Test", b =>
                {
                    b.HasOne("AccuGazer.API.Models.User", "User")
                        .WithMany("tests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AccuGazer.API.Models.TestResult", b =>
                {
                    b.HasOne("AccuGazer.API.Models.Test", "Test")
                        .WithOne("TestResult")
                        .HasForeignKey("AccuGazer.API.Models.TestResult", "TestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}