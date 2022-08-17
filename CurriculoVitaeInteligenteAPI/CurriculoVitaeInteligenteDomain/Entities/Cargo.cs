using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Cargo :BaseEntityComData
    {
        public Guid? IdHistoricoProfissional{ get; set; }
        public string? NomeCargo { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Termino { get; set; }
        public string? DescricaoCargo { get; set; }

        public HistoricoProfissional? HistoricoProfissional { get; set; }
    }
}
