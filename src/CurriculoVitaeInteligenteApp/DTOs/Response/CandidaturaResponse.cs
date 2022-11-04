using CurriculoVitaeInteligenteApp.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class CandidaturaResponse : BaseResponse
    {
        public Guid? PerfilId { get; set; }
        public Guid? VagaId { get; set; }

        //navegaçao
        public virtual PerfilResponse? Perfil { get; set; }
        public virtual VagaResponse? Vaga { get; set; }
    }
}
