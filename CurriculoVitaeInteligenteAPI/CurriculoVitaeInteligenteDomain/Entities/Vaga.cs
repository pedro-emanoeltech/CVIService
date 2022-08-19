using CurriculoVitaeInteligenteDomain.Content.Enums;


namespace CurriculoVitaeInteligenteDomain.Entities
{
   public  class Vaga  :BaseEntityComData
    {

        public Guid? PessoaId { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? NomeEmpresa { get; set; }
        public string? Requisitos { get; set; }
        public string? Beneficio { get; set; }

        public TipoPerfil? Perfil { get; set; }
        public ModalidadeTrabalho? ModalidadeTrabalho{ get; set; }

        //relacionamento
        public Endereco? Endereco { get; set; }
        public Contato? Contato { get; set; }

        //navegacao
        public Pessoa? Pessoa { get; set; }
    }
}
