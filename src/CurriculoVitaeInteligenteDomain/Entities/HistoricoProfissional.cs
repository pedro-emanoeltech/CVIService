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
        public Guid? Perfil_Id { get; set; }

        public string? NomeEmpresa { get; set; }
        public PorteEmpresa? Porte { get; set; }

        public Guid? Contato_Id { get; set; }
        public Guid? Cidade_Id { get; set; }
        public Guid? Segmento_Id { get; set; }


        //relacionamento
        public Contato? Contato { get; set; }
        public Segmento? Segmento { get; set; }
        public Cidade? Cidade { get; set; }
        public IList<Cargo>? Cargo { get; set; }


        //navegaçao
        public virtual Perfil? Perfil { get; set; }
    }
}
