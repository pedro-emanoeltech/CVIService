﻿using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteDomain.Content.Enums;


namespace CurriculoVitaeInteligenteApp.DTOs.Request
{
   public  class VagaRequest : BaseRequest
    {

        public Guid? Perfil_Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? NomeEmpresa { get; set; }
        public string? Requisitos { get; set; }
        public string? Beneficio { get; set; }
        public Guid? Endereco_Id { get; set; }
        public Guid? Contato_Id { get; set; }

        public TipoPerfil? TipoPerfil { get; set; }
        public ModalidadeTrabalho? ModalidadeTrabalho{ get; set; }

    }
}