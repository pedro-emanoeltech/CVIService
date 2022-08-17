﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurriculoVitaeInteligenteDomain.Content.Enums.Classificacoes;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class FormacaoAcademica : BaseEntityComData
    {

        public Guid? IdPerfil{ get; set; }
        public Guid? IdCurso { get; set; }
        public Guid? IdCidade { get; set; }

        public NivelAcademico? NivelAcademico{ get; set; }
        public SituacaoCurso? SituacaoCurso { get; set; }



        public DateTime? Inicio { get; set; }
        public DateTime? Termino { get; set; }
        public string? Instituicao { get; set; }
        public string? DescricaoCurso { get; set; }
       


        public Curso? Curso { get; set; }
        public HistoricoProfissional? HistoricoProfissional { get; set; }
        public Cidade? Cidade { get; set; }

        public PessoaFisica? PessoaFisica { get; set; }
    }
}
