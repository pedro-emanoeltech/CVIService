using CurriculoVitaeInteligenteDomain.Content.Enums;


namespace CurriculoVitaeInteligenteDomain.Entities
{
   public  class Vaga: BaseEntityComData
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

        //relacionamento
        public Endereco? Endereco { get; set; }
        public Contato? Contato { get; set; }

        //navegacao
     
        public Perfil? Perfil{ get; set; }
    }
}
