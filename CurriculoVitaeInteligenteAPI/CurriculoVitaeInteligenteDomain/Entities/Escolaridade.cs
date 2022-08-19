﻿using CurriculoVitaeInteligenteDomain.Content.Enums;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Escolaridade : BaseEntityComData
    {
        public Guid? PessoaId { get; set; }
        public NivelAcademico? NivelAcademico { get; set; }
        public Pessoa? Pessoa { get; set; }
    }
}