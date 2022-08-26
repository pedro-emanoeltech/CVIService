using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Cidade : BaseEntity
    {

        public string? Nome { get; set; }

        public string? CodigoIBge { get; set; }

        public virtual Endereco? Endereco { get; set; }

        public virtual Objetivo? Objetivo { get; set; }

        public virtual HistoricoProfissional? HistoricoProfissional { get; set; }
        public virtual CursoFormacaoAcademica? CursoFormacaoAcademica { get; set; }
        

    }
}
