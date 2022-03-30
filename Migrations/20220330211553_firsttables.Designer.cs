﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pet_hotel.Models;

#nullable disable

namespace dotnet_bakery.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220330211553_firsttables")]
    partial class firsttables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pet_hotel.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Breed")
                        .HasColumnType("text");

                    b.Property<int>("BreedTypes")
                        .HasColumnType("integer");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<int>("ColorTypes")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("checkedInAt")
                        .HasColumnType("text");

                    b.Property<int>("petOwnderid")
                        .HasColumnType("integer");

                    b.Property<int>("petOwner")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PetsTable");
                });

            modelBuilder.Entity("pet_hotel.PetOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("emailAddress")
                        .HasColumnType("text");

                    b.Property<int?>("petCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PetOwnersTable");
                });
#pragma warning restore 612, 618
        }
    }
}
