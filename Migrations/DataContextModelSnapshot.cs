﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPInvestigacion.Interfaces;

#nullable disable

namespace TPInvestigacion.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("TPInvestigacion.Clases.Moto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("patente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("precio")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Motos");
                });
#pragma warning restore 612, 618
        }
    }
}
