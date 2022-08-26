using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Segmento: BaseEntity
    {

        public string? Descricao { get; set; }

        public virtual Perfil? Perfil { get; set; }
        public virtual HistoricoProfissional? HistoricoProfissional { get; set; }
    }
}
