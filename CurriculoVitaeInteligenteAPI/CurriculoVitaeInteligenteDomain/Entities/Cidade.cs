using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Cidade :BaseEntity
    {
        public string? Nome { get; set; }

        public string? CodigoIBge { get; set; }

        public Guid? IdEstado { get; set; }

        //relacionamento
        public Estado? Estado { get; set; }

    }
}
