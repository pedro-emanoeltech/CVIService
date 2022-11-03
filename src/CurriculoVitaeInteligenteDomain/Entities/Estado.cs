using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Estado :BaseEntity
    {
        public Guid? Pais_Id { get; set; }
        public string? Nome { get; set; }
        public string? UF { get; set; }


        public virtual Endereco? Endereco { get; set; }

        //navegaçao

        public  Pais? Pais { get; set; }
    }
}
