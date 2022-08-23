using CurriculoVitaeInteligenteDomain.Content.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurriculoVitaeInteligenteDomain.Content.Enums.Classificacoes;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class HistoricoProfissional : BaseEntityComData
    {
        public Guid? PessoaId { get; set; }

        public string? NomeEmpresa { get; set; }

        public string? Telefone { get; set; }

        public PorteEmpresa? Porte { get; set; }

        public Guid? IdCidade { get; set; }

        public Guid? IdSegmento { get; set; }


        //relacionamento
        public Segmento? Segmento { get; set; }
        public Cidade? Cidade { get; set; }
        public IList<Cargo>? Cargo { get; set; }


        //navegaçao
        public virtual Pessoa? Pessoa { get; set; }
    }
}
