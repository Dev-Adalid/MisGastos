﻿// <auto-generated />
using System;
using DATOS.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DATOS.Migrations
{
    [DbContext(typeof(MisGastosDbContext))]
    partial class MisGastosDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DATOS.Entidades.Ahorros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMovimiento")
                        .HasColumnType("int");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ObjetivosDeAhorroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMovimiento");

                    b.HasIndex("ObjetivosDeAhorroId");

                    b.ToTable("Ahorros");
                });

            modelBuilder.Entity("DATOS.Entidades.Categorias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("DATOS.Entidades.Movimientos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EsFijo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdAhorro")
                        .HasColumnType("int");

                    b.Property<int?>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdAhorro");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Movimientos");
                });

            modelBuilder.Entity("DATOS.Entidades.ObjetivosDeAhorro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ObjetivosDeAhorros");
                });

            modelBuilder.Entity("DATOS.Entidades.Ahorros", b =>
                {
                    b.HasOne("DATOS.Entidades.Movimientos", "Movimiento")
                        .WithMany()
                        .HasForeignKey("IdMovimiento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATOS.Entidades.ObjetivosDeAhorro", null)
                        .WithMany("Ahorros")
                        .HasForeignKey("ObjetivosDeAhorroId");

                    b.Navigation("Movimiento");
                });

            modelBuilder.Entity("DATOS.Entidades.Movimientos", b =>
                {
                    b.HasOne("DATOS.Entidades.Ahorros", "Ahorro")
                        .WithMany()
                        .HasForeignKey("IdAhorro");

                    b.HasOne("DATOS.Entidades.Categorias", "Categoria")
                        .WithMany("Movimientos")
                        .HasForeignKey("IdCategoria");

                    b.Navigation("Ahorro");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("DATOS.Entidades.Categorias", b =>
                {
                    b.Navigation("Movimientos");
                });

            modelBuilder.Entity("DATOS.Entidades.ObjetivosDeAhorro", b =>
                {
                    b.Navigation("Ahorros");
                });
#pragma warning restore 612, 618
        }
    }
}
