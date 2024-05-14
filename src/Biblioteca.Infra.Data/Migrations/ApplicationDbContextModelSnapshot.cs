﻿// <auto-generated />
using System;
using Biblioteca.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Biblioteca.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Biblioteca.Domain.Entities.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AtualizadoEm")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("CriadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("Id");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("Biblioteca.Domain.Entities.Emprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AtualizadoEm")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("CriadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("DataDevolucaoPrevista")
                        .HasColumnType("DATE");

                    b.Property<DateTime?>("DataDevolucaoRealizada")
                        .HasColumnType("DATE");

                    b.Property<DateTime>("DataEmprestimo")
                        .HasColumnType("DATE");

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeRenovacoesPermitida")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeRenovacoesRealizadas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("StatusEmprestimo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LivroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Emprestimos");
                });

            modelBuilder.Entity("Biblioteca.Domain.Entities.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnoPublicacao")
                        .HasColumnType("int");

                    b.Property<DateTime>("AtualizadoEm")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("DATETIME");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<DateTime>("CriadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME");

                    b.Property<string>("Edicao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("Editora")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("NomeArquivoCapa")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<int>("QuantidadeExemplaresDisponiveisEmEstoque")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeExemplaresDisponiveisParaEmprestimo")
                        .HasColumnType("int");

                    b.Property<string>("StatusLivro")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("Biblioteca.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AtualizadoEm")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("DATETIME");

                    b.Property<bool>("Bloqueado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("CriadoEm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("DataFimBloqueio")
                        .HasColumnType("DATE");

                    b.Property<DateTime?>("DataInicioBloqueio")
                        .HasColumnType("DATE");

                    b.Property<int>("DiasBloqueado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("CHAR(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<int>("QuantidadeEmprestimosPermitida")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeEmprestimosRealizados")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Biblioteca.Domain.Entities.Emprestimo", b =>
                {
                    b.HasOne("Biblioteca.Domain.Entities.Livro", "Livro")
                        .WithMany("Emprestimos")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Biblioteca.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Emprestimos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livro");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Biblioteca.Domain.Entities.Livro", b =>
                {
                    b.Navigation("Emprestimos");
                });

            modelBuilder.Entity("Biblioteca.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Emprestimos");
                });
#pragma warning restore 612, 618
        }
    }
}
