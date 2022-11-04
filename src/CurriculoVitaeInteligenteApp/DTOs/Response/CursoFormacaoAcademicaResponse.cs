﻿using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class CursoFormacaoAcademicaResponse : BaseResponse
    {

        public Guid? PerfilId { get; set; }
        public Guid? CursoId { get; set; }
        public Guid? CidadeId { get; set; }
        public SituacaoCurso? SituacaoCurso { get; set; }

        public DateTime? Inicio { get; set; }
        public DateTime? Termino { get; set; }
        public string? Instituicao { get; set; }

        public string? DescricaoCurso { get; set; }


        public CursoResponse? Curso { get; set; }
        public CidadeResponse? Cidade { get; set; }


        // navegação
        public virtual PerfilResponse? Perfil { get; set; }
    }
}
