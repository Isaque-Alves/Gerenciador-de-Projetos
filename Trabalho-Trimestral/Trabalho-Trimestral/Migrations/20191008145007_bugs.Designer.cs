﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trabalho_Trimestral;

namespace Trabalho_Trimestral.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20191008145007_bugs")]
    partial class bugs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Trabalho_Trimestral.Models.Atribuicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DesenvolvedorId");

                    b.Property<int>("RequisitoId");

                    b.Property<int>("TempoGasto");

                    b.HasKey("Id");

                    b.HasIndex("DesenvolvedorId");

                    b.HasIndex("RequisitoId");

                    b.ToTable("Atribuicoes");
                });

            modelBuilder.Entity("Trabalho_Trimestral.Models.Bug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<int>("DesenvolvedorId");

                    b.Property<int>("DesenvolvedorSolucionadorId");

                    b.Property<string>("Prioridade")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("RequisitoId");

                    b.Property<bool>("Resolucao");

                    b.HasKey("Id");

                    b.HasIndex("DesenvolvedorId");

                    b.HasIndex("DesenvolvedorSolucionadorId");

                    b.HasIndex("RequisitoId");

                    b.ToTable("Bugs");
                });

            modelBuilder.Entity("Trabalho_Trimestral.Models.Desenvolvedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Admin");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Desenvolvedores");
                });

            modelBuilder.Entity("Trabalho_Trimestral.Models.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataEntrega");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Solicitante")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("Trabalho_Trimestral.Models.Requisito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataPrevista");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<bool>("Funcional");

                    b.Property<string>("Observacoes")
                        .HasMaxLength(200);

                    b.Property<int?>("ProjetoId");

                    b.HasKey("Id");

                    b.HasIndex("ProjetoId");

                    b.ToTable("Requisitos");
                });

            modelBuilder.Entity("Trabalho_Trimestral.Models.Atribuicao", b =>
                {
                    b.HasOne("Trabalho_Trimestral.Models.Desenvolvedor")
                        .WithMany("Atribuicoes")
                        .HasForeignKey("DesenvolvedorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Trabalho_Trimestral.Models.Requisito")
                        .WithMany("Atribuicoes")
                        .HasForeignKey("RequisitoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Trabalho_Trimestral.Models.Bug", b =>
                {
                    b.HasOne("Trabalho_Trimestral.Models.Desenvolvedor", "Desenvolvedor")
                        .WithMany("BugsCriados")
                        .HasForeignKey("DesenvolvedorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Trabalho_Trimestral.Models.Desenvolvedor", "DesenvolvedorSolucionador")
                        .WithMany("BugsSolucionados")
                        .HasForeignKey("DesenvolvedorSolucionadorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Trabalho_Trimestral.Models.Requisito")
                        .WithMany("Bugs")
                        .HasForeignKey("RequisitoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Trabalho_Trimestral.Models.Requisito", b =>
                {
                    b.HasOne("Trabalho_Trimestral.Models.Projeto", "Projeto")
                        .WithMany("Requisitos")
                        .HasForeignKey("ProjetoId");
                });
#pragma warning restore 612, 618
        }
    }
}
