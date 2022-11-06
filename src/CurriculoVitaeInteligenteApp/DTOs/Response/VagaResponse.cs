using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
   public  class VagaResponse : BaseResponse
    {
        public Guid? PerfilId { get; set; }

        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? NomeEmpresa { get; set; }
        public string? Requisitos { get; set; }
        public string? Beneficio { get; set; }
        public ModalidadeTrabalho? ModalidadeTrabalho { get; set; }
        public Endereco? Endereco { get; set; }
        public Contato? Contato { get; set; }


        //relacionamento
        public Perfil? Perfil { get; set; }
    }
}
