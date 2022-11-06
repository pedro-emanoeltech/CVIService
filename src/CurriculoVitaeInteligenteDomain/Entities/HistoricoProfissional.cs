using CurriculoVitaeInteligenteDomain.Content.Enums;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class HistoricoProfissional : BaseEntityComData
    {
        public Guid? PerfilId { get; set; }

        public string? NomeEmpresa { get; set; }
        public PorteEmpresa? Porte { get; set; }

        public Guid? ContatoId { get; set; }
        public Guid? CidadeId { get; set; }
        public Guid? SegmentoId { get; set; }

        public Cargo? Cargo { get; set; }
        public Segmento? Segmento { get; set; }
        public Contato? Contato { get; set; }
        public Cidade? Cidade { get; set; }

    }
}
