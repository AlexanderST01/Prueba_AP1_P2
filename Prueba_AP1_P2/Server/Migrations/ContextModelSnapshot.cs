﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba_AP1_P2.Server.DAL;

#nullable disable

namespace Prueba_AP1_P2.Server.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Prueba_AP1_P2.Shared.Models.Entradas", b =>
                {
                    b.Property<int>("EntradaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CantidadProducida")
                        .HasColumnType("REAL");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("PesoTotal")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntradaId");

                    b.ToTable("Entradas");
                });

            modelBuilder.Entity("Prueba_AP1_P2.Shared.Models.EntredasDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CantidadUtilizada")
                        .HasColumnType("REAL");

                    b.Property<int>("EntradaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.HasIndex("EntradaId");

                    b.ToTable("EntradasDetalles");
                });

            modelBuilder.Entity("Prueba_AP1_P2.Shared.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<double>("Existencia")
                        .HasColumnType("REAL");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Descripcion = "Maní",
                            Existencia = 40000.0,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 2,
                            Descripcion = "Pistachos",
                            Existencia = 60000.0,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 3,
                            Descripcion = "Pasas",
                            Existencia = 50000.0,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 4,
                            Descripcion = "Ciruelas",
                            Existencia = 70000.0,
                            Tipo = 0
                        },
                        new
                        {
                            ProductoId = 5,
                            Descripcion = "Mixto MPP 0.5lb",
                            Existencia = 0.0,
                            Tipo = 1
                        },
                        new
                        {
                            ProductoId = 6,
                            Descripcion = "Mixto MPC 0.5lb",
                            Existencia = 0.0,
                            Tipo = 1
                        },
                        new
                        {
                            ProductoId = 7,
                            Descripcion = "Mixto MPP 0.2lb",
                            Existencia = 0.0,
                            Tipo = 1
                        });
                });

            modelBuilder.Entity("Prueba_AP1_P2.Shared.Models.EntredasDetalle", b =>
                {
                    b.HasOne("Prueba_AP1_P2.Shared.Models.Entradas", null)
                        .WithMany("EntradasDetalles")
                        .HasForeignKey("EntradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Prueba_AP1_P2.Shared.Models.Entradas", b =>
                {
                    b.Navigation("EntradasDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}
