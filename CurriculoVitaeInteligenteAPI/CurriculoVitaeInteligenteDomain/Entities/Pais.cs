using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
