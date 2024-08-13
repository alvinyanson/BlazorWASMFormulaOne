﻿// <auto-generated />
using FormulaOne.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FormulaOne.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240813090545_SeedTable")]
    partial class SeedTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FormulaOne.Shared.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RacingNb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Michael Schumacher",
                            RacingNb = "3",
                            Team = "Mercedes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Nico Rosberg",
                            RacingNb = "6",
                            Team = "Mercedes"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lewis Hamilton",
                            RacingNb = "44",
                            Team = "Mercedes"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Valtteri Bottas",
                            RacingNb = "77",
                            Team = "Mercedes"
                        },
                        new
                        {
                            Id = 5,
                            Name = "George Russell",
                            RacingNb = "63",
                            Team = "Mercedes"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
