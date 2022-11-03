namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Pais:BaseEntity
    {
       
        public string? Nome { get; set; }

        public string? Sigla { get; set; }


        //navegacao
        public virtual Estado? Estado { get; set; }
    }
}
