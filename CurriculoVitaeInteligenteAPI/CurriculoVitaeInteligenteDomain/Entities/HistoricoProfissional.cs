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
        public Guid? IdPerfil { get; set; }

        public string? NomeEmpresa { get; set; }

        public string? Telefone { get; set; }

        public string? Celular { get; set; }

        public PorteEmpresa? Porte { get; set; }

        public Guid? IdCidade { get; set; }

        public Guid? IdPais { get; set; }

        public Guid? IdSegmento { get; set; }


        //relacionamento
        public Segmento? Segmento { get; set; }
        public Pais? Pais { get; set; }
        public Cidade? Cidade { get; set; }


        // navegação
        public PessoaFisica? PessoaFisica { get; set; }
    }
}
