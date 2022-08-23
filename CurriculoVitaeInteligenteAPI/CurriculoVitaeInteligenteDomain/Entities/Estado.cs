using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Estado :BaseEntity
    {
        public Guid? PaisId { get; set; }
        public string? Nome { get; set; }
        public string? UF { get; set; }

      
        //navegaçao

        public virtual Pais? Pais { get; set; }
    }
}
