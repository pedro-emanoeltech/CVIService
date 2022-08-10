using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class PessoaJuridica :BaseEntityConta
    {
        public string? NomeFantasia { get; set; }

        public string? RazaoSocial { get; set; }

        public string? CNPJ { get; set; }

        public Guid? IdSegmento { get; set; }



        // Relacionamento
        public Segmento? Segmento { get; set; }


    }
}
