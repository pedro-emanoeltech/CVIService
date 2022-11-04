﻿using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteDomain.Content.Enums;


namespace CurriculoVitaeInteligenteDomain.Entities
{
   public class PerfilRequest : BaseRequest
    {
        public string? Nome { get; set; }
        public string? Apelido { get; set; }
        public Int64? CPF { get; set; }
        public Int64? CNPJ { get; set; }
        public int? Idade { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Genero Genero { get; set; }
        public Guid? Segmento_Id { get; set; }
        public Guid? Nacionalidade_Id { get; set; }


    }
}