﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial2_aplicada2_2017_0826.DAL;

namespace Parcial2_aplicada2_2017_0826.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Parcial2_aplicada2_2017_0826.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Nombres = "FERRETERIA GAMA"
                        },
                        new
                        {
                            ClienteId = 2,
                            Nombres = "AVALON DISCO"
                        },
                        new
                        {
                            ClienteId = 3,
                            Nombres = "PRESTAMOS CEFIPROD"
                        });
                });

            modelBuilder.Entity("Parcial2_aplicada2_2017_0826.Models.Cobros", b =>
                {
                    b.Property<int>("cobroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("TotalCobros")
                        .HasColumnType("REAL");

                    b.Property<int>("TotalPagados")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VentaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("clienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("observaciones")
                        .HasColumnType("TEXT");

                    b.HasKey("cobroId");

                    b.ToTable("Cobros");
                });

            modelBuilder.Entity("Parcial2_aplicada2_2017_0826.Models.CobrosDetalle", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("cobrado")
                        .HasColumnType("REAL");

                    b.Property<int>("cobroId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("fuePagado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ventaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("cobroId");

                    b.ToTable("CobrosDetalle");
                });

            modelBuilder.Entity("Parcial2_aplicada2_2017_0826.Models.Ventas", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Balance")
                        .HasColumnType("REAL");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.HasKey("VentaId");

                    b.ToTable("Ventas");

                    b.HasData(
                        new
                        {
                            VentaId = 1,
                            Balance = 1000.0,
                            ClienteId = 1,
                            Fecha = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 1000.0
                        },
                        new
                        {
                            VentaId = 2,
                            Balance = 800.0,
                            ClienteId = 1,
                            Fecha = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 900.0
                        },
                        new
                        {
                            VentaId = 3,
                            Balance = 2000.0,
                            ClienteId = 2,
                            Fecha = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 2000.0
                        },
                        new
                        {
                            VentaId = 4,
                            Balance = 1800.0,
                            ClienteId = 2,
                            Fecha = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 1900.0
                        },
                        new
                        {
                            VentaId = 5,
                            Balance = 3000.0,
                            ClienteId = 3,
                            Fecha = new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 3000.0
                        },
                        new
                        {
                            VentaId = 6,
                            Balance = 1900.0,
                            ClienteId = 3,
                            Fecha = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Monto = 2900.0
                        });
                });

            modelBuilder.Entity("Parcial2_aplicada2_2017_0826.Models.CobrosDetalle", b =>
                {
                    b.HasOne("Parcial2_aplicada2_2017_0826.Models.Cobros", null)
                        .WithMany("CobrosDetalles")
                        .HasForeignKey("cobroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Parcial2_aplicada2_2017_0826.Models.Cobros", b =>
                {
                    b.Navigation("CobrosDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}
