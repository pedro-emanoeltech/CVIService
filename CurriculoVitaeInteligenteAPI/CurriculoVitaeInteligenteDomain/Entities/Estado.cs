using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Estado :BaseEntity
    {
        public string? Nome { get; set; }

        public string? UF { get; set; }

        public Guid? IdPais { get; set; }

        //relacionamento
        public Pais? Pais { get; set; }
    }
}
