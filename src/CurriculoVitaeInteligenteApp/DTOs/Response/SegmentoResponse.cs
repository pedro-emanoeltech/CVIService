using CurriculoVitaeInteligenteApp.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class SegmentoResponse : BaseResponse
    {

        public string? Descricao { get; set; }

        public virtual PerfilResponse? Perfil { get; set; }
        public virtual HistoricoProfissionalResponse? HistoricoProfissional { get; set; }
    }
}
