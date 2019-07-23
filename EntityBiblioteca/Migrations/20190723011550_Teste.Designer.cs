﻿// <auto-generated />
using System;
using EntityBiblioteca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityBiblioteca.Migrations
{
    [DbContext(typeof(BibliotecaContext))]
    [Migration("20190723011550_Teste")]
    partial class Teste
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BibliotecaModelos.Assunto", b =>
                {
                    b.Property<int>("AssuntoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssuntoObra");

                    b.HasKey("AssuntoId");

                    b.ToTable("Assuntos");
                });

            modelBuilder.Entity("BibliotecaModelos.Autor", b =>
                {
                    b.Property<int>("AutorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeAutor");

                    b.HasKey("AutorId");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("BibliotecaModelos.Classificacao", b =>
                {
                    b.Property<int>("ClassificacaoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassificacaoObra");

                    b.HasKey("ClassificacaoId");

                    b.ToTable("Classificacoes");
                });

            modelBuilder.Entity("BibliotecaModelos.Editora", b =>
                {
                    b.Property<int>("EditoraId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EnderecoId");

                    b.Property<string>("NomeEditora");

                    b.HasKey("EditoraId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Editoras");
                });

            modelBuilder.Entity("BibliotecaModelos.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("CEP");

                    b.Property<string>("Complemento");

                    b.Property<string>("Logradouro");

                    b.Property<int?>("MunicipioId");

                    b.Property<int>("NumeroResidencial");

                    b.HasKey("EnderecoId");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("BibliotecaModelos.Estado", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeEstado");

                    b.Property<int?>("PaisId");

                    b.HasKey("EstadoId");

                    b.HasIndex("PaisId");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("BibliotecaModelos.Exemplar", b =>
                {
                    b.Property<int>("ExemplarId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LivroId");

                    b.Property<int>("NumeroExemplar");

                    b.Property<string>("Registro");

                    b.HasKey("ExemplarId");

                    b.HasIndex("LivroId");

                    b.ToTable("Exemplares");
                });

            modelBuilder.Entity("BibliotecaModelos.Livro", b =>
                {
                    b.Property<int>("LivroId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssuntoId");

                    b.Property<int?>("AutorId");

                    b.Property<int?>("ClassificacaoId");

                    b.Property<int?>("EditoraId");

                    b.Property<string>("Titulo");

                    b.HasKey("LivroId");

                    b.HasIndex("AssuntoId");

                    b.HasIndex("AutorId");

                    b.HasIndex("ClassificacaoId");

                    b.HasIndex("EditoraId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("BibliotecaModelos.Municipio", b =>
                {
                    b.Property<int>("MunicipioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EstadoId");

                    b.Property<string>("NomeMunicipio");

                    b.HasKey("MunicipioId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("BibliotecaModelos.Pais", b =>
                {
                    b.Property<int>("PaisId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomePais");

                    b.HasKey("PaisId");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("BibliotecaModelos.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF");

                    b.Property<DateTime>("DataDeNascimento");

                    b.Property<int?>("EnderecoId");

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.Property<string>("Profissao");

                    b.Property<string>("RG");

                    b.Property<string>("Telefone");

                    b.HasKey("PessoaId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("BibliotecaModelos.Editora", b =>
                {
                    b.HasOne("BibliotecaModelos.Endereco", "Endereco")
                        .WithMany("Editoras")
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("BibliotecaModelos.Endereco", b =>
                {
                    b.HasOne("BibliotecaModelos.Municipio", "Municipio")
                        .WithMany("Enderecos")
                        .HasForeignKey("MunicipioId");
                });

            modelBuilder.Entity("BibliotecaModelos.Estado", b =>
                {
                    b.HasOne("BibliotecaModelos.Pais", "Pais")
                        .WithMany("Estados")
                        .HasForeignKey("PaisId");
                });

            modelBuilder.Entity("BibliotecaModelos.Exemplar", b =>
                {
                    b.HasOne("BibliotecaModelos.Livro", "Livro")
                        .WithMany("Exemplares")
                        .HasForeignKey("LivroId");
                });

            modelBuilder.Entity("BibliotecaModelos.Livro", b =>
                {
                    b.HasOne("BibliotecaModelos.Assunto", "Assunto")
                        .WithMany("Livros")
                        .HasForeignKey("AssuntoId");

                    b.HasOne("BibliotecaModelos.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorId");

                    b.HasOne("BibliotecaModelos.Classificacao", "Classificacao")
                        .WithMany("Livros")
                        .HasForeignKey("ClassificacaoId");

                    b.HasOne("BibliotecaModelos.Editora", "Editora")
                        .WithMany("Livros")
                        .HasForeignKey("EditoraId");
                });

            modelBuilder.Entity("BibliotecaModelos.Municipio", b =>
                {
                    b.HasOne("BibliotecaModelos.Estado", "Estado")
                        .WithMany("Municipios")
                        .HasForeignKey("EstadoId");
                });

            modelBuilder.Entity("BibliotecaModelos.Pessoa", b =>
                {
                    b.HasOne("BibliotecaModelos.Endereco", "Endereco")
                        .WithMany("Pessoas")
                        .HasForeignKey("EnderecoId");
                });
#pragma warning restore 612, 618
        }
    }
}
