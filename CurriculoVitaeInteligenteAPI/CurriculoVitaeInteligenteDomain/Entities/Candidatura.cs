using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Candidatura :BaseEntityComData
    {
        public Guid? PessoaId { get; set; }
        public Guid? VagaId { get; set; }

        //navegaçao
        public Pessoa? Pessoa { get; set; }
        public Vaga? Vaga { get; set; }
    }
}
