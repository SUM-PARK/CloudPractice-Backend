﻿// <auto-generated />
using System;
using Itinere.Infrastructure.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Itinere.Infrastructure.Migrations
{
    [DbContext(typeof(ItinereDbContext))]
    [Migration("20190826135831_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("Itinere.Infrastructure.Model.Footprint", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Footprints");
                });
#pragma warning restore 612, 618
        }
    }
}