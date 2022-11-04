using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Content.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurriculoVitaeInteligenteDomain.Content.Enums.Classificacoes;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class HistoricoProfissionalResponse : BaseResponse
    {
        public Guid? Perfil_Id { get; set; }

        public string? NomeEmpresa { get; set; }
        public PorteEmpresa? Porte { get; set; }

        public Guid? Contato_Id { get; set; }
        public Guid? Cidade_Id { get; set; }
        public Guid? Segmento_Id { get; set; }


        //relacionamento
        public ContatoResponse? Contato { get; set; }
        public SegmentoResponse? Segmento { get; set; }
        public CidadeResponse? Cidade { get; set; }
        public IList<CargoResponse>? Cargo { get; set; }


        //navegaçao
        public virtual PerfilResponse? Perfil { get; set; }
    }
}
