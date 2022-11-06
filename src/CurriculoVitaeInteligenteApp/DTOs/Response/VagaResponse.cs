using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Content.Enums;


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
        public Guid? Endereco_Id { get; set; }
        public Guid? Contato_Id { get; set; }

        public TipoPerfil? TipoPerfil { get; set; }
        public ModalidadeTrabalho? ModalidadeTrabalho{ get; set; }

        //relacionamento
        public EnderecoResponse? Endereco { get; set; }
        public ContatoResponse? Contato { get; set; }

        //navegacao
     
        public PerfilResponse? Perfil{ get; set; }
    }
}
