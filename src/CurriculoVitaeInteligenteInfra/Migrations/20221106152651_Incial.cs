using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurriculoVitaeInteligenteInfra.Migrations
{
    public partial class Incial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    CodigoIBge = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Senha = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Status = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NomeCurso = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nacionalidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NomePais = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nacionalidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    Sigla = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Segmento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Descricao = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segmento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: true),
                    Apelido = table.Column<string>(type: "varchar(50)", nullable: true),
                    TipoPerfil = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    CPF = table.Column<string>(type: "varchar(12)", nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(14)", nullable: true),
                    Idade = table.Column<string>(type: "varchar(3)", nullable: true),
                    EstadoCivil = table.Column<string>(type: "varchar(30)", nullable: true),
                    Genero = table.Column<string>(type: "varchar(20)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ContaId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perfil_Conta_ContaId",
                        column: x => x.ContaId,
                        principalTable: "Conta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PaisId = table.Column<Guid>(type: "uuid", nullable: true),
                    Nome = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    UF = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estado_Pais_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Pais",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CursoFormacaoAcademica",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PerfilId = table.Column<Guid>(type: "uuid", nullable: true),
                    CidadeId = table.Column<Guid>(type: "uuid", nullable: true),
                    CursoId = table.Column<Guid>(type: "uuid", nullable: true),
                    SituacaoCurso = table.Column<string>(type: "varchar(500)", nullable: true),
                    Inicio = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Termino = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Instituicao = table.Column<string>(type: "varchar(150)", nullable: false),
                    DescricaoCurso = table.Column<string>(type: "varchar(500)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoFormacaoAcademica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CursoFormacaoAcademica_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CursoFormacaoAcademica_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CursoFormacaoAcademica_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Escolaridade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PerfilId = table.Column<Guid>(type: "uuid", nullable: true),
                    NivelAcademico = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escolaridade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Escolaridade_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Idioma",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PerfilId = table.Column<Guid>(type: "uuid", nullable: true),
                    Nome = table.Column<string>(type: "varchar(255)", nullable: false),
                    NivelLeitura = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    NivelEscrita = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    NivelConversacao = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idioma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Idioma_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Objetivo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PerfilId = table.Column<Guid>(type: "uuid", nullable: true),
                    AreaInteresse = table.Column<string>(type: "varchar(200)", nullable: false),
                    PretensaoSalarial = table.Column<string>(type: "varchar(10)", nullable: true),
                    ResumoProfissional = table.Column<string>(type: "varchar(500)", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objetivo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objetivo_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vaga",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PerfilId = table.Column<Guid>(type: "uuid", nullable: true),
                    Titulo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Descricao = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    NomeEmpresa = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Requisitos = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Beneficio = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    ModalidadeTrabalho = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaga_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Candidaturas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    VagaId = table.Column<Guid>(type: "uuid", nullable: true),
                    PerfilId = table.Column<Guid>(type: "uuid", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidaturas_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Candidaturas_Vaga_VagaId",
                        column: x => x.VagaId,
                        principalTable: "Vaga",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PerfilId = table.Column<Guid>(type: "uuid", nullable: true),
                    VagaId = table.Column<Guid>(type: "uuid", nullable: true),
                    TipoContato = table.Column<string>(type: "varchar(15)", nullable: false),
                    Texto = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contatos_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contatos_Vaga_VagaId",
                        column: x => x.VagaId,
                        principalTable: "Vaga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PerfilId = table.Column<Guid>(type: "uuid", nullable: true),
                    VagaId = table.Column<Guid>(type: "uuid", nullable: true),
                    CidadeId = table.Column<Guid>(type: "uuid", nullable: true),
                    EstadoId = table.Column<Guid>(type: "uuid", nullable: true),
                    Logradouro = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Bairro = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Numero = table.Column<long>(type: "bigint", maxLength: 7, nullable: true),
                    CEP = table.Column<long>(type: "bigint", maxLength: 8, nullable: true),
                    Complemento = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Endereco_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Endereco_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Endereco_Vaga_VagaId",
                        column: x => x.VagaId,
                        principalTable: "Vaga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoProfissional",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PerfilId = table.Column<Guid>(type: "uuid", nullable: true),
                    NomeEmpresa = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Porte = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    ContatoId = table.Column<Guid>(type: "uuid", nullable: true),
                    CidadeId = table.Column<Guid>(type: "uuid", nullable: true),
                    SegmentoId = table.Column<Guid>(type: "uuid", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoProfissional", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoProfissional_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricoProfissional_Contatos_ContatoId",
                        column: x => x.ContatoId,
                        principalTable: "Contatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricoProfissional_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricoProfissional_Segmento_SegmentoId",
                        column: x => x.SegmentoId,
                        principalTable: "Segmento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HistoricoProfissionalId = table.Column<Guid>(type: "uuid", nullable: true),
                    NomeCargo = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Inicio = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Termino = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DescricaoCargo = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cargos_HistoricoProfissional_HistoricoProfissionalId",
                        column: x => x.HistoricoProfissionalId,
                        principalTable: "HistoricoProfissional",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidaturas_DateCreate",
                table: "Candidaturas",
                column: "DateCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Candidaturas_Id",
                table: "Candidaturas",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Candidaturas_PerfilId",
                table: "Candidaturas",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidaturas_VagaId",
                table: "Candidaturas",
                column: "VagaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_DateCreate",
                table: "Cargos",
                column: "DateCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_HistoricoProfissionalId",
                table: "Cargos",
                column: "HistoricoProfissionalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_Id",
                table: "Cargos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conta_DateCreate",
                table: "Conta",
                column: "DateCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Conta_Email",
                table: "Conta",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conta_Id",
                table: "Conta",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_DateCreate",
                table: "Contatos",
                column: "DateCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_Id",
                table: "Contatos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_PerfilId",
                table: "Contatos",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_VagaId",
                table: "Contatos",
                column: "VagaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CursoFormacaoAcademica_CidadeId",
                table: "CursoFormacaoAcademica",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_CursoFormacaoAcademica_CursoId",
                table: "CursoFormacaoAcademica",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_CursoFormacaoAcademica_DateCreate",
                table: "CursoFormacaoAcademica",
                column: "DateCreate");

            migrationBuilder.CreateIndex(
                name: "IX_CursoFormacaoAcademica_Id",
                table: "CursoFormacaoAcademica",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CursoFormacaoAcademica_PerfilId",
                table: "CursoFormacaoAcademica",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_CidadeId",
                table: "Endereco",
                column: "CidadeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_DateCreate",
                table: "Endereco",
                column: "DateCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_EstadoId",
                table: "Endereco",
                column: "EstadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Id",
                table: "Endereco",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_PerfilId",
                table: "Endereco",
                column: "PerfilId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_VagaId",
                table: "Endereco",
                column: "VagaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Escolaridade_Id",
                table: "Escolaridade",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Escolaridade_PerfilId",
                table: "Escolaridade",
                column: "PerfilId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estado_Id",
                table: "Estado",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estado_PaisId",
                table: "Estado",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Estado_UF",
                table: "Estado",
                column: "UF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoProfissional_CidadeId",
                table: "HistoricoProfissional",
                column: "CidadeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoProfissional_ContatoId",
                table: "HistoricoProfissional",
                column: "ContatoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoProfissional_DateCreate",
                table: "HistoricoProfissional",
                column: "DateCreate");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoProfissional_Id",
                table: "HistoricoProfissional",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoProfissional_PerfilId",
                table: "HistoricoProfissional",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoProfissional_SegmentoId",
                table: "HistoricoProfissional",
                column: "SegmentoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Idioma_Id",
                table: "Idioma",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Idioma_PerfilId",
                table: "Idioma",
                column: "PerfilId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nacionalidade_Id",
                table: "Nacionalidade",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Objetivo_DateCreate",
                table: "Objetivo",
                column: "DateCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Objetivo_Id",
                table: "Objetivo",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Objetivo_PerfilId",
                table: "Objetivo",
                column: "PerfilId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pais_Id",
                table: "Pais",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_ContaId",
                table: "Perfil",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_DateCreate",
                table: "Perfil",
                column: "DateCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_Id",
                table: "Perfil",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Segmento_Id",
                table: "Segmento",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_DateCreate",
                table: "Vaga",
                column: "DateCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_Id",
                table: "Vaga",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_PerfilId",
                table: "Vaga",
                column: "PerfilId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidaturas");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "CursoFormacaoAcademica");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Escolaridade");

            migrationBuilder.DropTable(
                name: "Idioma");

            migrationBuilder.DropTable(
                name: "Nacionalidade");

            migrationBuilder.DropTable(
                name: "Objetivo");

            migrationBuilder.DropTable(
                name: "HistoricoProfissional");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Segmento");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "Vaga");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Conta");
        }
    }
}
