﻿// <auto-generated />
using System;
using Elenco.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elenco.Migrations
{
    [DbContext(typeof(ElencoContext))]
    [Migration("20221121231731_alfa")]
    partial class alfa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Elenco.Models.Autenticidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Autenticidade");
                });

            modelBuilder.Entity("Elenco.Models.Coadjuvante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AutenticidadeAlfaId")
                        .HasColumnType("int");

                    b.Property<int?>("AutenticidadeBetaId")
                        .HasColumnType("int");

                    b.Property<int?>("AutenticidadeGamaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExperienciaAlfaId")
                        .HasColumnType("int");

                    b.Property<int?>("ExperienciaBetaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrigemId")
                        .HasColumnType("int");

                    b.Property<string>("Retrato")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AutenticidadeAlfaId");

                    b.HasIndex("AutenticidadeBetaId");

                    b.HasIndex("AutenticidadeGamaId");

                    b.HasIndex("ExperienciaAlfaId");

                    b.HasIndex("ExperienciaBetaId");

                    b.HasIndex("OrigemId");

                    b.ToTable("Elenco");
                });

            modelBuilder.Entity("Elenco.Models.Experiencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Experiencia");
                });

            modelBuilder.Entity("Elenco.Models.Origem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Origem");
                });

            modelBuilder.Entity("Elenco.Models.Coadjuvante", b =>
                {
                    b.HasOne("Elenco.Models.Autenticidade", "AutenticidadeAlfa")
                        .WithMany("AutenticidadeAlfa")
                        .HasForeignKey("AutenticidadeAlfaId");

                    b.HasOne("Elenco.Models.Autenticidade", "AutenticidadeBeta")
                        .WithMany("AutenticidadeBeta")
                        .HasForeignKey("AutenticidadeBetaId");

                    b.HasOne("Elenco.Models.Autenticidade", "AutenticidadeGama")
                        .WithMany("AutenticidadeGama")
                        .HasForeignKey("AutenticidadeGamaId");

                    b.HasOne("Elenco.Models.Experiencia", "ExperienciaAlfa")
                        .WithMany("ExperienciaAlfa")
                        .HasForeignKey("ExperienciaAlfaId");

                    b.HasOne("Elenco.Models.Experiencia", "ExperienciaBeta")
                        .WithMany("ExperienciaBeta")
                        .HasForeignKey("ExperienciaBetaId");

                    b.HasOne("Elenco.Models.Origem", "Origem")
                        .WithMany()
                        .HasForeignKey("OrigemId");

                    b.Navigation("AutenticidadeAlfa");

                    b.Navigation("AutenticidadeBeta");

                    b.Navigation("AutenticidadeGama");

                    b.Navigation("ExperienciaAlfa");

                    b.Navigation("ExperienciaBeta");

                    b.Navigation("Origem");
                });

            modelBuilder.Entity("Elenco.Models.Autenticidade", b =>
                {
                    b.Navigation("AutenticidadeAlfa");

                    b.Navigation("AutenticidadeBeta");

                    b.Navigation("AutenticidadeGama");
                });

            modelBuilder.Entity("Elenco.Models.Experiencia", b =>
                {
                    b.Navigation("ExperienciaAlfa");

                    b.Navigation("ExperienciaBeta");
                });
#pragma warning restore 612, 618
        }
    }
}
