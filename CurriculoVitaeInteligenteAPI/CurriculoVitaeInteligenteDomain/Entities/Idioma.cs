using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Idioma :BaseEntity
    {
        public string? Nome { get; set; }
        //relacionamento


        //navegaçao 
        public virtual Linguagem? Linguagem { get; set; }

    }
}
