using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Candidatura :BaseEntityComData
    {
        public Guid? IdPerfil{ get; set; }
        public Guid? IdVaga { get; set; }

        public PessoaFisica? PessoaFisica { get; set; }
        public Vaga? Vaga{ get; set; }

    }
}
