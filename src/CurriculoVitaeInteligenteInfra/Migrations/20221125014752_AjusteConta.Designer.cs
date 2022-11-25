﻿// <auto-generated />
using System;
using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CurriculoVitaeInteligenteInfra.Migrations
{
    [DbContext(typeof(CVIContext))]
    [Migration("20221125014752_AjusteConta")]
    partial class AjusteConta
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Candidatura", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp without time zone");

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
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DescricaoCargo")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<Guid?>("HistoricoProfissionalId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Inicio")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("NomeCargo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("Termino")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("DateCreate");

                    b.HasIndex("HistoricoProfissionalId")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Cidade", b =>
                {
                    b.Property<Guid?>("Id")
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
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp without time zone");

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

                    b.Property<string>("TipoConta")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

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

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.Property<string>("Texto")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("TipoContato")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("DateCreate");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PerfilId");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Curso", b =>
                {
                    b.Property<Guid?>("Id")
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
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DescricaoCurso")
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime?>("Inicio")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Instituicao")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.Property<string>("SituacaoCurso")
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime?>("Termino")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("CursoId");

                    b.HasIndex("DateCreate");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PerfilId");

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

                    b.Property<Guid?>("CidadeId")
                        .HasColumnType("uuid");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("EstadoId")
                        .HasColumnType("uuid");

                    b.Property<string>("Logradouro")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<long?>("Numero")
                        .HasMaxLength(7)
                        .HasColumnType("bigint");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId")
                        .IsUnique();

                    b.HasIndex("DateCreate");

                    b.HasIndex("EstadoId")
                        .IsUnique();

                    b.HasIndex("Id")
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
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("NivelAcademico")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PerfilId")
                        .IsUnique();

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

                    b.HasIndex("PaisId");

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

                    b.Property<Guid?>("ContatoId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp without time zone");

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

                    b.HasIndex("ContatoId")
                        .IsUnique();

                    b.HasIndex("DateCreate");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PerfilId");

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
                        .HasColumnType("varchar(255)");

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

                    b.Property<string>("NomePais")
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
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("PerfilId")
                        .HasColumnType("uuid");

                    b.Property<string>("PretensaoSalarial")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("ResumoProfissional")
                        .HasColumnType("varchar(500)");

                    b.HasKey("Id");

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
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CNPJ")
                        .HasColumnType("varchar(14)");

                    b.Property<string>("CPF")
                        .HasColumnType("varchar(12)");

                    b.Property<Guid?>("ContaId")
                        .IsRequired()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Genero")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Idade")
                        .HasColumnType("varchar(3)");

                    b.Property<Guid?>("NacionalidadeId")
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(150)");

                    b.Property<Guid?>("SegmentoId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.HasIndex("DateCreate");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("NacionalidadeId");

                    b.HasIndex("SegmentoId");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Segmento", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Setor")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Segmento");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.TokenAuth", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ContaId")
                        .HasMaxLength(300)
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DataExpiracao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int?>("ExpiryTimeStamp")
                        .HasColumnType("integer");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("character varying(600)");

                    b.HasKey("Id");

                    b.HasIndex("DateCreate");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("TokenAuth");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Vaga", b =>
                {
                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Beneficio")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<Guid?>("CidadeId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ContatoId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateCreate")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<Guid?>("EstadoId")
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

                    b.Property<string>("Titulo")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId")
                        .IsUnique();

                    b.HasIndex("ContatoId")
                        .IsUnique();

                    b.HasIndex("DateCreate");

                    b.HasIndex("EstadoId")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PerfilId")
                        .IsUnique();

                    b.ToTable("Vaga");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Candidatura", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId");

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Vaga", "Vaga")
                        .WithMany()
                        .HasForeignKey("VagaId");

                    b.Navigation("Perfil");

                    b.Navigation("Vaga");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Cargo", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", null)
                        .WithOne("Cargo")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Cargo", "HistoricoProfissionalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Contato", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", null)
                        .WithMany("Contato")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.CursoFormacaoAcademica", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId");

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId");

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", null)
                        .WithMany("CursoFormacaoAcademica")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Cidade");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Endereco", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Cidade", "Cidade")
                        .WithOne()
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Endereco", "CidadeId");

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Estado", "Estado")
                        .WithOne()
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Endereco", "EstadoId");

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", null)
                        .WithOne("Endereco")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Endereco", "PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Cidade");

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Escolaridade", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", null)
                        .WithOne("Escolaridade")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Escolaridade", "PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Estado", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId");

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Cidade", "Cidade")
                        .WithOne()
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", "CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Contato", "Contato")
                        .WithOne()
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", "ContatoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", null)
                        .WithMany("HistoricoProfissional")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Segmento", "Segmento")
                        .WithOne()
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", "SegmentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Cidade");

                    b.Navigation("Contato");

                    b.Navigation("Segmento");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Idioma", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", null)
                        .WithOne("Idioma")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Idioma", "PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Objetivo", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", null)
                        .WithOne("Objetivo")
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Objetivo", "PerfilId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Perfil", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Conta", "Conta")
                        .WithMany()
                        .HasForeignKey("ContaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Nacionalidade", "Nacionalidade")
                        .WithMany()
                        .HasForeignKey("NacionalidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Segmento", "Segmento")
                        .WithMany()
                        .HasForeignKey("SegmentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Conta");

                    b.Navigation("Nacionalidade");

                    b.Navigation("Segmento");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Vaga", b =>
                {
                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Estado", "Estado")
                        .WithOne()
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Vaga", "CidadeId");

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Contato", "Contato")
                        .WithOne()
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Vaga", "ContatoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Cidade", "Cidade")
                        .WithOne()
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Vaga", "EstadoId");

                    b.HasOne("CurriculoVitaeInteligenteDomain.Entities.Perfil", "Perfil")
                        .WithOne()
                        .HasForeignKey("CurriculoVitaeInteligenteDomain.Entities.Vaga", "PerfilId");

                    b.Navigation("Cidade");

                    b.Navigation("Contato");

                    b.Navigation("Estado");

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.HistoricoProfissional", b =>
                {
                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("CurriculoVitaeInteligenteDomain.Entities.Perfil", b =>
                {
                    b.Navigation("Contato");

                    b.Navigation("CursoFormacaoAcademica");

                    b.Navigation("Endereco");

                    b.Navigation("Escolaridade");

                    b.Navigation("HistoricoProfissional");

                    b.Navigation("Idioma");

                    b.Navigation("Objetivo");
                });
#pragma warning restore 612, 618
        }
    }
}
