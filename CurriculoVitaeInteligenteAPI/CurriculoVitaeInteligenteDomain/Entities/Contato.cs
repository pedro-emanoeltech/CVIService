using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Contato : BaseEntityComData
    {
        public Guid? PessoaId { get; set; }
        public Guid? VagaId { get; set; }

        public string? Email { get; set; }

        public string? Telefone { get; set; }

        public string? Celular { get; set; }

        public string? CelularSecundario { get; set; }

        //navegacao
        public virtual Pessoa? Pessoa { get; set; }

        public virtual Vaga? Vaga { get; set; }
    }
}
