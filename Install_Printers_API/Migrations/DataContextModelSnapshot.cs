﻿// <auto-generated />
using System;
using Install_Printers_API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Install_Printers_API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Install_Printers_Lib.Models.Link", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FileLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("Install_Printers_Lib.Models.Printer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("LinkId")
                        .HasColumnType("int");

                    b.Property<bool>("NetPrinter")
                        .HasColumnType("bit");

                    b.Property<string>("PrinterName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LinkId");

                    b.ToTable("Printers");
                });

            modelBuilder.Entity("Install_Printers_Lib.Models.Printer", b =>
                {
                    b.HasOne("Install_Printers_Lib.Models.Link", "Link")
                        .WithMany()
                        .HasForeignKey("LinkId");

                    b.Navigation("Link");
                });
#pragma warning restore 612, 618
        }
    }
}