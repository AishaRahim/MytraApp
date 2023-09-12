﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MytraRepository.Context;

#nullable disable

namespace MytraRepository.Migrations
{
    [DbContext(typeof(MytraContext))]
<<<<<<<< HEAD:BackEnd/MytraAppApi/MytraRepository/Migrations/20230912064540_locationadded.Designer.cs
    [Migration("20230912064540_locationadded")]
    partial class locationadded
========
    [Migration("20230912094131_createdDB")]
    partial class createdDB
>>>>>>>> origin/main:BackEnd/MytraAppApi/MytraRepository/Migrations/20230912094131_createdDB.Designer.cs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MytraModel.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            LocationName = "Trivandrum"
                        },
                        new
                        {
                            LocationId = 2,
                            LocationName = "Kollam"
                        },
                        new
                        {
                            LocationId = 3,
                            LocationName = "Kochi"
                        },
                        new
                        {
                            LocationId = 4,
                            LocationName = "Kottayam"
                        },
                        new
                        {
                            LocationId = 5,
                            LocationName = "Idukki"
                        });
                });

            modelBuilder.Entity("MytraModel.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<string>("BuildingName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("LocationId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("MytraModel.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ServiceId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("MytraModel.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.ToTable("Service");

                    b.HasData(
                        new
                        {
                            ServiceId = 1,
                            ServiceName = "Cleaning"
                        },
                        new
                        {
                            ServiceId = 5,
                            ServiceName = "Washing"
                        },
                        new
                        {
                            ServiceId = 2,
                            ServiceName = "Plumbing"
                        },
                        new
                        {
                            ServiceId = 4,
                            ServiceName = "Painting"
                        },
                        new
                        {
                            ServiceId = 3,
                            ServiceName = "Repair"
                        });
                });

            modelBuilder.Entity("MytraModel.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("MailId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("MailId")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("MytraModel.Models.Order", b =>
                {
                    b.HasOne("MytraModel.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MytraModel.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MytraModel.Models.OrderDetail", b =>
                {
                    b.HasOne("MytraModel.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MytraModel.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("MytraModel.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
