﻿// <auto-generated />
using System;
using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CurriculoVitaeInteligenteInfra.Migrations
{
    [DbContext(typeof(CVIContext))]
    partial class CVIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Candidatura", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("VagaId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("DateCreate");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PerfilId");

                    b.HasIndex("VagaId");

                    b.ToTable("Candidaturas");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Cargo", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DescricaoCargo")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<Guid?>("HistoricoProfissionalId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Inicio")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NomeCargo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("Termino")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DateCreate");

                    b.HasIndex("HistoricoProfissionalId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Cidade", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CodigoIBge")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Conta", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("TipoPerfil")
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.HasKey("Id");

                    b.HasIndex("DateCreate");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Conta");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Contato", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Celular")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("CelularSecundario")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.Property<string>("Telefone")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<Guid?>("VagaId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("DateCreate");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PerfilId")
                        .IsUnique();

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Curso", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NomeCurso")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.CursoFormacaoAcademica", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CidadeId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CursoId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DescricaoCurso")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<DateTime?>("Inicio")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Instituicao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.Property<string>("SituacaoCurso")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTime?>("Termino")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId")
                        .IsUnique();

                    b.HasIndex("CursoId")
                        .IsUnique();

                    b.HasIndex("DateCreate");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PerfilId")
                        .IsUnique();

                    b.ToTable("CursoFormacaoAcademica");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Endereco", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Bairro")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<long?>("CEP")
                        .HasMaxLength(8)
                        .HasColumnType("bigint");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EnderecoPerfil")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<Guid?>("IdCidade")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("IdEstado")
                        .HasColumnType("uuid");

                    b.Property<long?>("Numero")
                        .HasMaxLength(7)
                        .HasColumnType("bigint");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("VagaId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("DateCreate");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("IdCidade")
                        .IsUnique();

                    b.HasIndex("IdEstado")
                        .IsUnique();

                    b.HasIndex("PerfilId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Escolaridade", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NivelAcademico")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PerfilId");

                    b.ToTable("Escolaridade");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Estado", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<Guid?>("PaisId")
                        .HasColumnType("uuid");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PaisId")
                        .IsUnique();

                    b.HasIndex("UF")
                        .IsUnique();

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CidadeId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CidadeId1")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ContatoId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.Property<string>("Porte")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<Guid?>("SegmentoId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId")
                        .IsUnique();

                    b.HasIndex("CidadeId1")
                        .IsUnique();

                    b.HasIndex("ContatoId")
                        .IsUnique();

                    b.HasIndex("DateCreate");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("SegmentoId")
                        .IsUnique();

                    b.ToTable("HistoricoProfissional");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Idioma", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("NivelConversacao")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("NivelEscrita")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("NivelLeitura")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PerfilId")
                        .IsUnique();

                    b.ToTable("Idioma");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Nacionalidade", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Nacionalidade");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Objetivo", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("AreaInteresse")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid?>("CidadeRegiaoInteresseId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.Property<double?>("PretensaoSalarial")
                        .HasMaxLength(20)
                        .HasColumnType("double precision");

                    b.Property<string>("ResumoProfissional")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.HasKey("Id");

                    b.HasIndex("CidadeRegiaoInteresseId")
                        .IsUnique();

                    b.HasIndex("DateCreate");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PerfilId")
                        .IsUnique();

                    b.ToTable("Objetivo");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Pais", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("character varying(55)");

                    b.Property<string>("Sigla")
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Perfil", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Apelido")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<long?>("CNPJ")
                        .HasMaxLength(14)
                        .HasColumnType("bigint");

                    b.Property<long?>("CPF")
                        .HasMaxLength(12)
                        .HasColumnType("bigint");

                    b.Property<Guid?>("ContaId")
                        .IsRequired()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int?>("Idade")
                        .HasMaxLength(30)
                        .HasColumnType("integer");

                    b.Property<Guid?>("NacionalidadeId")
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<Guid?>("SegmentoId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ContaId")
                        .IsUnique();

                    b.HasIndex("DateCreate");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("NacionalidadeId")
                        .IsUnique();

                    b.HasIndex("SegmentoId")
                        .IsUnique();

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Segmento", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Descricao")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Segmento");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Vaga", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Beneficio")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<Guid?>("ContatoId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descricao")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<Guid?>("EnderecoId")
                        .HasColumnType("uuid");

                    b.Property<string>("ModalidadeTrabalho")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("NomeEmpresa")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.Property<string>("Requisitos")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("TipoPerfil")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Titulo")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("ContatoId")
                        .IsUnique();

                    b.HasIndex("DateCreate");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PerfilId");

                    b.ToTable("Vaga");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Candidatura", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", "Perfil")
                        .WithMany("Candidatura")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Vaga", "Vaga")
                        .WithMany()
                        .HasForeignKey("VagaId");

                    b.Navigation("Perfil");

                    b.Navigation("Vaga");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Cargo", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", "HistoricoProfissional")
                        .WithMany("Cargo")
                        .HasForeignKey("HistoricoProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("HistoricoProfissional");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Contato", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", "Perfil")
                        .WithOne("Contato")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Contato", "PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.CursoFormacaoAcademica", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Cidade", "Cidade")
                        .WithOne("CursoFormacaoAcademica")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.CursoFormacaoAcademica", "CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Curso", "Curso")
                        .WithOne("CursoFormacaoAcademica")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.CursoFormacaoAcademica", "CursoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", "Perfil")
                        .WithOne("CursoFormacaoAcademica")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.CursoFormacaoAcademica", "PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Cidade");

                    b.Navigation("Curso");

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Endereco", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Cidade", "Cidade")
                        .WithOne("Endereco")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Endereco", "IdCidade")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Estado", "Estado")
                        .WithOne("Endereco")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Endereco", "IdEstado")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", "Perfil")
                        .WithOne("Endereco")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Endereco", "PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Cidade");

                    b.Navigation("Estado");

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Escolaridade", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId");

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Estado", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Pais", "Pais")
                        .WithOne("Estado")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Estado", "PaisId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", "Perfil")
                        .WithOne("HistoricoProfissional")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", "CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Cidade", "Cidade")
                        .WithOne("HistoricoProfissional")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", "CidadeId1");

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Contato", "Contato")
                        .WithOne("HistoricoProfissional")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", "ContatoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Segmento", "Segmento")
                        .WithOne("HistoricoProfissional")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", "SegmentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Cidade");

                    b.Navigation("Contato");

                    b.Navigation("Perfil");

                    b.Navigation("Segmento");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Idioma", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", "Perfil")
                        .WithOne("Idioma")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Idioma", "PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Objetivo", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Cidade", "Cidade")
                        .WithOne("Objetivo")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Objetivo", "CidadeRegiaoInteresseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", "Perfil")
                        .WithOne("Objetivo")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Objetivo", "PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Cidade");

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Perfil", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Conta", "Conta")
                        .WithOne("Perfil")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Perfil", "ContaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Nacionalidade", "Nacionalidade")
                        .WithOne("Perfil")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Perfil", "NacionalidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Segmento", "Segmento")
                        .WithOne("Perfil")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Perfil", "SegmentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Conta");

                    b.Navigation("Nacionalidade");

                    b.Navigation("Segmento");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Vaga", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Contato", "Contato")
                        .WithOne("Vaga")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Vaga", "ContatoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Endereco", "Endereco")
                        .WithOne("Vaga")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Vaga", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId");

                    b.Navigation("Contato");

                    b.Navigation("Endereco");

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Cidade", b =>
                {
                    b.Navigation("CursoFormacaoAcademica");

                    b.Navigation("Endereco");

                    b.Navigation("HistoricoProfissional");

                    b.Navigation("Objetivo");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Conta", b =>
                {
                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Contato", b =>
                {
                    b.Navigation("HistoricoProfissional");

                    b.Navigation("Vaga");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Curso", b =>
                {
                    b.Navigation("CursoFormacaoAcademica");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Endereco", b =>
                {
                    b.Navigation("Vaga");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Estado", b =>
                {
                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", b =>
                {
                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Nacionalidade", b =>
                {
                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Pais", b =>
                {
                    b.Navigation("Estado");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Perfil", b =>
                {
                    b.Navigation("Candidatura");

                    b.Navigation("Contato");

                    b.Navigation("CursoFormacaoAcademica");

                    b.Navigation("Endereco");

                    b.Navigation("HistoricoProfissional");

                    b.Navigation("Idioma");

                    b.Navigation("Objetivo");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Segmento", b =>
                {
                    b.Navigation("HistoricoProfissional");

                    b.Navigation("Perfil");
                });
#pragma warning restore 612, 618
        }
    }
}
