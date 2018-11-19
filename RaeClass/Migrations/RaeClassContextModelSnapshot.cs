﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RaeClass.Models;

namespace RaeClass.Migrations
{
    [DbContext(typeof(RaeClassContext))]
    partial class RaeClassContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("RaeClass.Models.ListenContent", b =>
                {
                    b.Property<int>("FId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FCreateTime");

                    b.Property<string>("FJsonData");

                    b.Property<DateTime>("FModifyTime");

                    b.HasKey("FId");

                    b.ToTable("ListenContent","dbo");
                });

            modelBuilder.Entity("RaeClass.Models.ReadContent", b =>
                {
                    b.Property<int>("FId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("FCreateTime");

                    b.Property<string>("FJsonData");

                    b.Property<DateTime>("FModifyTime");

                    b.HasKey("FId");

                    b.ToTable("ReadContent","dbo");
                });
#pragma warning restore 612, 618
        }
    }
}
