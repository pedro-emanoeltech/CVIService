using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteApp.DTOs.Request
{
   public  class VagaRequest : BaseRequest
    {

        public Guid? PerfilId { get; set; }
        public Guid? CidadeId { get; set; }
        public Guid? EstadoId { get; set; }
        public Guid? ContatoId { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? NomeEmpresa { get; set; }
        public string? Requisitos { get; set; }
        public string? Beneficio { get; set; }
        public string? Url { get; set; }

        public ModalidadeTrabalho? ModalidadeTrabalho{ get; set; }

        public Contato? Contato { get; set; }
        public Cidade? Cidade { get; set; }
        public Estado? Estado { get; set; }

    }
}
