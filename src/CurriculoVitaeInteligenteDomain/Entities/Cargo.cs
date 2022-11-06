namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Cargo :BaseEntityComData
    {
        public Guid? HistoricoProfissionalId{ get; set; }
        public string? NomeCargo { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Termino { get; set; }
        public string? DescricaoCargo { get; set; }

    }
}
